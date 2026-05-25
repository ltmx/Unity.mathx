#!/usr/bin/env python3
"""Organize mathx API members into file-name categories for DocFX TOC and tabbed hub."""

from __future__ import annotations

import json
import sys
from collections import defaultdict
from pathlib import Path

try:
    import yaml
except ImportError:
    print("PyYAML required: pip install pyyaml", file=sys.stderr)
    sys.exit(1)


CATEGORY_LABELS: dict[str, str] = {
    "angle": "Angle",
    "common": "Common",
    "constants": "Constants",
    "conversion": "Conversion",
    "exponential": "Exponential",
    "fast-math": "Fast math",
    "hash": "Hash",
    "interpolation": "Interpolation",
    "iteration": "Iteration",
    "jobify": "Jobify",
    "klakmath": "KlakMath",
    "logic": "Logic",
    "mathf-translations": "Mathf translations",
    "matrix": "Matrix",
    "mult": "Mult",
    "noise": "Noise",
    "random": "Random",
    "rotation": "Rotation",
    "rounding": "Rounding",
    "sdf": "SDF",
    "selection": "Selection",
    "special": "Special",
    "structs": "Structs",
    "transformation": "Transformation",
    "trigonometry": "Trigonometry",
    "vector": "Vector",
    "floatx": "Float extensions",
    "intx": "Int extensions",
    "other": "Other",
}


def category_from_source_path(path: str) -> str:
    path = path.replace("\\", "/")
    if "/Runtime/" in path:
        rel = path.split("/Runtime/", 1)[1]
    else:
        rel = path.lstrip("./")

    parts = rel.split("/")
    if len(parts) > 1:
        folder = parts[0].lower()
        mapping = {
            "noise": "noise",
            "fastmath": "fast-math",
            "jobify": "jobify",
            "sdf": "sdf",
            "structs": "structs",
            "data": "constants",
            "klakmath": "klakmath",
        }
        return mapping.get(folder, folder)

    filename = parts[-1]
    if not filename.endswith(".cs"):
        return "other"

    stem = filename[:-3]
    if stem == "mathx":
        return "common"

    if stem.startswith("mathx."):
        segment = stem.split(".", 2)[1]
        if segment.lower() == "mathf":
            return "mathf-translations"
        return segment.lower()

    return "other"


def load_mathx_members(yml_path: Path) -> list[dict]:
    with yml_path.open(encoding="utf-8") as handle:
        doc = yaml.safe_load(handle)

    members: list[dict] = []
    for item in doc.get("items", []):
        uid = item.get("uid", "")
        if not uid.startswith("Unity.Mathematics.mathx."):
            continue
        source = item.get("source") or {}
        path = source.get("path") or source.get("remote", {}).get("path") or ""
        members.append(
            {
                "uid": uid,
                "name": item.get("name") or uid.rsplit(".", 1)[-1],
                "type": item.get("type") or "Member",
                "category": category_from_source_path(path),
            }
        )
    return members


def patch_toc(toc_path: Path, members: list[dict]) -> None:
    with toc_path.open(encoding="utf-8") as handle:
        toc = yaml.safe_load(handle)

    by_category: dict[str, list[dict]] = defaultdict(list)
    for member in members:
        by_category[member["category"]].append(member)

    def sort_key(name: str) -> tuple[int, str]:
        return (0 if name in CATEGORY_LABELS else 1, CATEGORY_LABELS.get(name, name))

    categories = sorted(by_category.keys(), key=sort_key)

    mathx_items: list[dict] = []
    for category in categories:
        label = CATEGORY_LABELS.get(category, category.replace("-", " ").title())
        children = sorted(by_category[category], key=lambda m: m["name"].lower())
        mathx_items.append(
            {
                "name": label,
                "items": [
                    {"uid": child["uid"], "name": child["name"], "type": child["type"]}
                    for child in children
                ],
            }
        )

    namespace_items = toc["items"][0]["items"]
    for index, entry in enumerate(namespace_items):
        if entry.get("uid") == "Unity.Mathematics.mathx":
            namespace_items[index] = {
                "uid": "Unity.Mathematics.mathx",
                "name": "mathx",
                "type": "Class",
                "items": mathx_items,
            }
            break
    else:
        raise RuntimeError("mathx entry not found in api/metadata/toc.yml")

    toc["memberLayout"] = "SeparatePages"

    with toc_path.open("w", encoding="utf-8", newline="\n") as handle:
        yaml.safe_dump(
            toc,
            handle,
            sort_keys=False,
            default_flow_style=False,
            allow_unicode=True,
            width=120,
        )


def member_href(uid: str) -> str:
    return uid + ".html"


def write_category_manifest(manifest_dir: Path, members: list[dict]) -> None:
    by_category: dict[str, list[dict]] = defaultdict(list)
    for member in members:
        by_category[member["category"]].append(
            {"name": member["name"], "href": member_href(member["uid"]), "type": member["type"]}
        )

    categories_dir = manifest_dir / "mathx-categories"
    categories_dir.mkdir(parents=True, exist_ok=True)

    for stale in categories_dir.glob("*.json"):
        stale.unlink()

    index = {"categories": []}
    for category in sorted(
        by_category.keys(),
        key=lambda c: (0 if c in CATEGORY_LABELS else 1, CATEGORY_LABELS.get(c, c)),
    ):
        label = CATEGORY_LABELS.get(category, category.replace("-", " ").title())
        payload = sorted(by_category[category], key=lambda m: m["name"].lower())
        (categories_dir / f"{category}.json").write_text(json.dumps(payload, indent=2), encoding="utf-8")
        index["categories"].append({"id": category, "label": label, "count": len(payload)})

    (manifest_dir / "mathx-categories.json").write_text(json.dumps(index, indent=2), encoding="utf-8")


def main() -> int:
    root = Path(__file__).resolve().parents[1]
    metadata_dir = root / "api" / "metadata"
    yml_path = metadata_dir / "Unity.Mathematics.mathx.yml"
    toc_path = metadata_dir / "toc.yml"

    if not yml_path.is_file():
        print(f"Missing metadata: {yml_path}", file=sys.stderr)
        return 1

    members = load_mathx_members(yml_path)
    if not members:
        print("No mathx members found in metadata.", file=sys.stderr)
        return 1

    patch_toc(toc_path, members)
    write_category_manifest(metadata_dir, members)

    counts = defaultdict(int)
    for member in members:
        counts[member["category"]] += 1

    print(f"Organized {len(members)} mathx members into {len(counts)} categories.")
    for category, count in sorted(counts.items(), key=lambda kv: (-kv[1], kv[0])):
        label = CATEGORY_LABELS.get(category, category)
        print(f"  {label}: {count}")

    return 0


if __name__ == "__main__":
    raise SystemExit(main())
