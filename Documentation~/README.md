# Build documentation locally

This folder is named **`Documentation~`** so Unity **ignores it entirely** when mathx is imported as a UPM package (trailing `~` is a Unity convention).

DocFX stubs use `Stubs/Unity.Stubs.stub` (not `.cs`). Never commit `bin/`, `obj/`, or `.dll` outputs — Unity loads them as plugins and conflicts with `Mathematics.Mathx.asmdef`.

## Prerequisites

- [.NET 8 SDK](https://dotnet.microsoft.com/download)
- Python 3.10+

## Commands

```bash
# API reference (DocFX)
cd Documentation~
dotnet build Mathx.Docs.csproj
dotnet tool install -g docfx   # once
docfx metadata docfx.json
docfx build docfx.json

# Merge API into docs before MkDocs (included in site output)
rm -rf docs/api
mkdir -p docs/api
cp -r Documentation~/api/_site/* docs/api/
cp docs/api-stub/index.html docs/api/index.html

# Guides (MkDocs Material)
cd ..
pip install -r requirements-docs.txt
mkdocs build
```

Open `site/index.html` locally, or run `mkdocs serve` for live reload (guides only until API is copied).

Published site: [ltmx.github.io/Unity.mathx](https://ltmx.github.io/Unity.mathx/)
