<div align="center">

<img src="https://download.alianblank.com/gameframex/gameframex_logo_320.png" alt="Game Frame X Logo" width="160" />

# Game Frame X Spine-Unity Runtime

[![License](https://img.shields.io/github/license/GameFrameX/com.gameframex.unity.esotericsoftware.spine.spine-unity)](https://github.com/GameFrameX/com.gameframex.unity.esotericsoftware.spine.spine-unity/blob/main/LICENSE.md)
[![Version](https://img.shields.io/github/v/release/GameFrameX/com.gameframex.unity.esotericsoftware.spine.spine-unity)](https://github.com/GameFrameX/com.gameframex.unity.esotericsoftware.spine.spine-unity/releases)
[![Unity Version](https://img.shields.io/badge/Unity-2019.4-black?logo=unity)](https://unity.com/)
[![Documentation](https://img.shields.io/badge/Documentation-docs-blue)](https://gameframex.doc.alianblank.com)

All-in-One Solution for Indie Game Development · Empowering Indie Developers' Dreams

<br />

[Documentation](https://gameframex.doc.alianblank.com) · [Quick Start](#quick-start) · QQ Group: 467608841 / 233840761

<br />

**English** | [简体中文](README.zh-CN.md) | [繁體中文](README.zh-TW.md) | [日本語](README.ja.md) | [한국어](README.ko.md)

</div>

## Project Overview

A secondary distribution of the **Spine-Unity** runtime, repackaged from the official Spine Runtime. This library primarily serves as a sub-module for [GameFrameX](https://github.com/AlianBlank/GameFrameX).

Supports Spine Editor 4.3 data exported from 4.3.74-beta or 4.3.00 (release) and newer.

### Modifications from Official Version

1. Added `link.xml` for strip filtering
2. Added `SpineUnityCroppingHelper` anti-stripping script

## Quick Start

### Installation

Choose one of the following methods:

1. Edit your Unity project's `Packages/manifest.json` and add the `scopedRegistries` section:
   ```json
   {
     "scopedRegistries": [
       {
         "name": "GameFrameX",
         "url": "https://gameframex.upm.alianblank.uk",
         "scopes": [
           "com.gameframex"
         ]
       }
     ],
     "dependencies": {
       "com.gameframex.unity.esotericsoftware.spine.spine-unity": "4.3.95"
     }
   }
   ```

   `scopes` controls which packages are resolved through this registry. Only packages whose names start with `com.gameframex` will be fetched from it.

2. Add to `manifest.json` dependencies:
   ```json
   {
      "com.gameframex.unity.esotericsoftware.spine.spine-unity": "https://github.com/gameframex/com.gameframex.unity.esotericsoftware.spine.spine-unity.git"
   }
   ```
3. Use **Package Manager** in Unity with **Git URL**: `https://github.com/gameframex/com.gameframex.unity.esotericsoftware.spine.spine-unity.git`
4. Clone the repository into your Unity project's `Packages` directory. It will be loaded automatically.
## Documentation & Resources

- [Spine-Unity Documentation](https://zh.esotericsoftware.com/spine-unity)
- [GameFrameX Documentation](https://gameframex.doc.alianblank.com)

## Community & Support

- QQ Group: 467608841 / 233840761

## Changelog

See [Releases](https://github.com/gameframex/com.gameframex.unity.esotericsoftware.spine.spine-unity/releases) for changelog.


## Dependencies

| Package | Description |
|---------|-------------|
| `com.unity.ugui` / Unity modules | Required by spine-unity UI, animation, physics, and sprite integrations. |

## License

See [LICENSE.md](LICENSE.md) for license information.
