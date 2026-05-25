#!/usr/bin/env python3
"""Inject a tabbed category browser into the built mathx class page."""

from __future__ import annotations

import re
import shutil
import sys
from pathlib import Path

HUB_STYLES = """
<style>
.mathx-api-hub { margin: 0.75rem 0 1rem; }
.mathx-api-hub__intro { opacity: 0.85; margin-bottom: 0.5rem; line-height: 1.35; }
.mathx-api-tabs {
  display: flex;
  flex-wrap: wrap;
  gap: 0.25rem;
  margin-bottom: 0.5rem;
  border-bottom: 1px solid rgba(123, 74, 226, 0.25);
  padding-bottom: 0.45rem;
}
.mathx-api-tabs button {
  border: 1px solid rgba(123, 74, 226, 0.35);
  background: rgba(123, 74, 226, 0.08);
  color: inherit;
  border-radius: 999px;
  padding: 0.2rem 0.65rem;
  font-size: 0.82rem;
  line-height: 1.2;
  cursor: pointer;
}
.mathx-api-tabs button.active,
.mathx-api-tabs button:hover {
  background: #7b4ae2;
  border-color: #7b4ae2;
  color: #fff;
}
.mathx-api-panel { display: none; }
.mathx-api-panel.active { display: block; }
.mathx-api-search {
  width: 100%;
  max-width: 28rem;
  margin-bottom: 0.5rem;
  padding: 0.35rem 0.65rem;
  font-size: 0.9rem;
  line-height: 1.25;
}
.mathx-api-grid {
  display: grid;
  grid-template-columns: repeat(auto-fill, minmax(12rem, 1fr));
  gap: 0.1rem 0.65rem;
  margin: 0;
  padding: 0;
  list-style: none;
}
.mathx-api-grid li {
  margin: 0;
  line-height: 1.25;
}
.mathx-api-grid a {
  text-decoration: none;
  font-family: var(--bs-font-monospace, ui-monospace, monospace);
  font-size: 0.84rem;
}
.mathx-api-grid a:hover { text-decoration: underline; }
.mathx-api-meta {
  font-size: 0.8rem;
  opacity: 0.7;
  margin-bottom: 0.35rem;
  line-height: 1.25;
}
.mathx-api-loading { opacity: 0.7; font-style: italic; margin: 0; }
</style>
"""

HUB_HTML = """
<div id="mathx-api-hub" class="mathx-api-hub">
  <p class="mathx-api-hub__intro">
    Browse extension methods by source category. Each member opens on its own page.
  </p>
  <input id="mathx-api-search" class="form-control mathx-api-search" type="search" placeholder="Filter visible members…" autocomplete="off" disabled />
  <p class="mathx-api-loading" id="mathx-api-loading">Loading categories…</p>
  <div class="mathx-api-tabs" id="mathx-api-tabs"></div>
  <div id="mathx-api-panels"></div>
</div>
"""

HUB_SCRIPT = """
<script>
(() => {
  const root = document.getElementById('mathx-api-hub');
  if (!root) return;

  const tabsHost = document.getElementById('mathx-api-tabs');
  const panelsHost = document.getElementById('mathx-api-panels');
  const loading = document.getElementById('mathx-api-loading');
  const search = document.getElementById('mathx-api-search');
  const cache = new Map();
  let activeId = '';

  function activate(id) {
    activeId = id;
    tabsHost.querySelectorAll('[data-mathx-tab]').forEach(tab => {
      tab.classList.toggle('active', tab.dataset.mathxTab === id);
    });
    panelsHost.querySelectorAll('[data-mathx-panel]').forEach(panel => {
      panel.classList.toggle('active', panel.dataset.mathxPanel === id);
    });
    loadCategory(id);
  }

  function renderMembers(panel, members) {
    const list = panel.querySelector('.mathx-api-grid');
    list.innerHTML = '';
    members.forEach(member => {
      const item = document.createElement('li');
      const link = document.createElement('a');
      link.href = member.href;
      link.textContent = member.name;
      item.appendChild(link);
      list.appendChild(item);
    });
    panel.dataset.loaded = 'true';
  }

  function loadCategory(id) {
    const panel = panelsHost.querySelector(`[data-mathx-panel="${id}"]`);
    if (!panel || panel.dataset.loaded === 'true') return;

    const status = panel.querySelector('.mathx-api-meta');
    status.textContent = 'Loading members…';

    const finish = members => {
      renderMembers(panel, members);
      status.textContent = `${members.length} members`;
      if (search.value.trim()) {
        search.dispatchEvent(new Event('input'));
      }
    };

    if (cache.has(id)) {
      finish(cache.get(id));
      return;
    }

    fetch(`mathx-categories/${id}.json`)
      .then(response => response.json())
      .then(members => {
        cache.set(id, members);
        finish(members);
      })
      .catch(() => {
        status.textContent = 'Could not load members for this category.';
      });
  }

  function renderIndex(manifest) {
    const categories = manifest.categories || [];
    const total = categories.reduce((sum, category) => sum + (category.count || 0), 0);
    root.querySelector('.mathx-api-hub__intro').innerHTML =
      `Browse <strong>${total}</strong> extension methods by source category. Each member opens on its own page.`;

    categories.forEach((category, index) => {
      const button = document.createElement('button');
      button.type = 'button';
      button.dataset.mathxTab = category.id;
      button.textContent = `${category.label} (${category.count})`;
      button.addEventListener('click', () => activate(category.id));
      tabsHost.appendChild(button);

      const panel = document.createElement('div');
      panel.className = 'mathx-api-panel';
      panel.dataset.mathxPanel = category.id;

      const meta = document.createElement('p');
      meta.className = 'mathx-api-meta';
      meta.textContent = `${category.count} members`;
      panel.appendChild(meta);

      const list = document.createElement('ul');
      list.className = 'mathx-api-grid';
      panel.appendChild(list);
      panelsHost.appendChild(panel);

      if (index === 0) activeId = category.id;
    });

    loading.remove();
    search.disabled = false;
    activate(activeId);

    search.addEventListener('input', () => {
      const query = search.value.trim().toLowerCase();
      panelsHost.querySelectorAll('.mathx-api-grid li').forEach(item => {
        const text = item.textContent.toLowerCase();
        item.style.display = !query || text.includes(query) ? '' : 'none';
      });
    });
  }

  fetch('mathx-categories.json')
    .then(response => response.json())
    .then(renderIndex)
    .catch(() => {
      loading.textContent = 'Could not load API categories.';
    });
})();
</script>
"""


def build_hub_markup() -> str:
    return HUB_STYLES + HUB_HTML + HUB_SCRIPT


def strip_member_index(html: str) -> str:
    return re.sub(
        r'<h2 class="section" id="(?:fields|properties|methods)">.*?(?=</article>)',
        "",
        html,
        count=1,
        flags=re.DOTALL,
    )


def patch_mathx_page(page_path: Path, manifest_dir: Path, output_dir: Path) -> None:
    if not page_path.is_file():
        print(f"Skip patch — missing page: {page_path}", file=sys.stderr)
        return

    html = page_path.read_text(encoding="utf-8")
    hub = build_hub_markup()

    if 'id="mathx-api-hub"' in html:
        html = re.sub(r'<style>\s*\.mathx-api-hub.*?</script>', "", html, count=1, flags=re.DOTALL)
        html = strip_member_index(html)

    html = strip_member_index(html)

    marker = '<h2 id="Unity_Mathematics_mathx_remarks">Remarks</h2>'
    if marker in html:
        html = html.replace(marker, hub + marker, 1)
    else:
        html = html.replace("</article>", hub + "</article>", 1)

    page_path.write_text(html, encoding="utf-8")

    output_dir.mkdir(parents=True, exist_ok=True)
    shutil.copy2(manifest_dir / "mathx-categories.json", output_dir / "mathx-categories.json")

    category_output = output_dir / "mathx-categories"
    if category_output.exists():
        shutil.rmtree(category_output)
    shutil.copytree(manifest_dir / "mathx-categories", category_output)

    size_kb = page_path.stat().st_size / 1024
    index_kb = (output_dir / "mathx-categories.json").stat().st_size / 1024
    print(f"Patched {page_path.name} ({size_kb:.1f} KB). Category index: {index_kb:.1f} KB.")


def main() -> int:
    root = Path(__file__).resolve().parents[1]
    manifest_dir = root / "api" / "metadata"
    page_path = root / "api" / "_site" / "api" / "metadata" / "Unity.Mathematics.mathx.html"
    output_dir = page_path.parent

    if not (manifest_dir / "mathx-categories.json").is_file():
        print(f"Missing manifest index: {manifest_dir / 'mathx-categories.json'}", file=sys.stderr)
        return 1

    patch_mathx_page(page_path, manifest_dir, output_dir)
    return 0


if __name__ == "__main__":
    raise SystemExit(main())
