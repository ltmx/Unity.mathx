# Build documentation locally

All website assets live under **`website/`** at the repo root. Unity package code is in **`package/`**.

Inside `website/`:

- **`docs~`** — MkDocs guide source
- **`Documentation~`** — DocFX API build
- **`overrides~`** — MkDocs theme overrides
- **`site~`** — local MkDocs output (gitignored)

DocFX stubs use `Stubs/Unity.Stubs.stub` (not `.cs`). Never commit `bin/`, `obj/`, or `.dll` outputs.

## Prerequisites

- [.NET 8 SDK](https://dotnet.microsoft.com/download)
- Python 3.10+

## Commands

```bash
# API reference (DocFX)
cd website/Documentation~
dotnet build Mathx.Docs.csproj
dotnet tool install -g docfx   # once
docfx metadata docfx.json
python tools/organize_mathx_api.py
docfx build docfx.json
python tools/patch_mathx_hub.py

# Merge API into docs~ before MkDocs (included in site~ output)
rm -rf ../docs~/api
mkdir -p ../docs~/api
cp -r api/_site/* ../docs~/api/
cp ../docs~/api-stub/index.html ../docs~/api/index.html

# Guides (MkDocs Material)
cd ..
pip install -r requirements-docs.txt
mkdocs build
```

Open `site~/index.html` locally, or run `mkdocs serve` for live reload (guides only until API is copied).

Published site: [ltmx.github.io/Unity.mathx](https://ltmx.github.io/Unity.mathx/)
