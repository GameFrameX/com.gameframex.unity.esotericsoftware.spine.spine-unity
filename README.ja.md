<div align="center">

<img src="https://download.alianblank.com/gameframex/gameframex_logo_320.png" alt="Game Frame X Logo" width="160" />

# Game Frame X Spine-Unity ランタイム

[![License](https://img.shields.io/github/license/GameFrameX/com.gameframex.unity.esotericsoftware.spine.spine-unity)](https://github.com/GameFrameX/com.gameframex.unity.esotericsoftware.spine.spine-unity/blob/main/LICENSE.md)
[![Version](https://img.shields.io/github/v/release/GameFrameX/com.gameframex.unity.esotericsoftware.spine.spine-unity)](https://github.com/GameFrameX/com.gameframex.unity.esotericsoftware.spine.spine-unity/releases)
[![Unity Version](https://img.shields.io/badge/Unity-2019.4-black?logo=unity)](https://unity.com/)
[![Documentation](https://img.shields.io/badge/Documentation-docs-blue)](https://gameframex.doc.alianblank.com)

インディゲーム開発者向けオールインワンソリューション · インディ開発者の夢を支援

<br />

[ドキュメント](https://gameframex.doc.alianblank.com) · [クイックスタート](#クイックスタート) · QQグループ: 467608841 / 233840761

<br />

[English](README.md) | [简体中文](README.zh-CN.md) | [繁體中文](README.zh-TW.md) | **日本語** | [한국어](README.ko.md)

</div>

## プロジェクト概要

公式 Spine Runtime から再パッケージされた **Spine-Unity** ランタイムの二次配布版。このライブラリは主に [GameFrameX](https://github.com/AlianBlank/GameFrameX) のサブモジュールとして使用されます。

### 公式版からの変更点

1. ストリップフィルタリング用の `link.xml` を追加
2. アンチストリッピングスクリプト `SpineUnityCroppingHelper` を追加

## クイックスタート

### インストール

Unity プロジェクトの `Packages/manifest.json` を編集し、`scopedRegistries` セクションを追加してください：

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
  ]
}
```

`scopes` は、どのパッケージをこのレジストリから解決するかを制御します。`com.gameframex` で始まるパッケージのみがこのレジストリから取得されます。

Then add the package to `dependencies`:

```json
{
  "dependencies": {
    "com.gameframex.unity.esotericsoftware.spine.spine-unity": "3.9.0"
  }
}
```


## ドキュメントとリソース

- [Spine-Unity ドキュメント](https://zh.esotericsoftware.com/spine-unity)
- [GameFrameX ドキュメント](https://gameframex.doc.alianblank.com)

## コミュニティとサポート

- QQグループ: 467608841 / 233840761

## 変更履歴

変更履歴は [Releases](https://github.com/gameframex/com.gameframex.unity.esotericsoftware.spine.spine-unity/releases) をご覧ください。

## ライセンス

このプロジェクトは [Spine Runtime ライセンス](https://github.com/EsotericSoftware/spine-runtimes/blob/4.1/LICENSE) の下で公開されています。
