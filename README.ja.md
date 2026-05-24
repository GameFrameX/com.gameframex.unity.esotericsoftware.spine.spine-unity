<div align="center">

<img src="https://download.alianblank.com/gameframex/gameframex_logo_320.png" alt="GameFrameX Logo" width="160"/>

# Game Frame X Spine-Unity ランタイム

[![License](https://img.shields.io/github/license/gameframex/com.gameframex.unity.esotericsoftware.spine.spine-unity)](https://github.com/gameframex/com.gameframex.unity.esotericsoftware.spine.spine-unity/blob/main/LICENSE)
[![Version](https://img.shields.io/github/v/release/gameframex/com.gameframex.unity.esotericsoftware.spine.spine-unity)](https://github.com/gameframex/com.gameframex.unity.esotericsoftware.spine.spine-unity/releases)
[![Documentation](https://img.shields.io/badge/Documentation-ドキュメント-blue)](https://gameframex.doc.alianblank.com)

インディゲーム開発者向けオールインワンソリューション · インディ開発者の夢を支援

[ドキュメント](https://gameframex.doc.alianblank.com) · [クイックスタート](#クイックスタート) · [QQグループ](https://qm.qq.com/q/5kbDVBdUeS) · **言語**

[English](README.md) | [简体中文](README.zh-CN.md) | [繁體中文](README.zh-TW.md) | **日本語** | [한국어](README.ko.md)

</div>

---

## プロジェクト概要

公式 Spine Runtime から再パッケージされた **Spine-Unity** ランタイムの二次配布版。このライブラリは主に [GameFrameX](https://github.com/AlianBlank/GameFrameX) のサブモジュールとして使用されます。

### 公式版からの変更点

1. ストリップフィルタリング用の `link.xml` を追加
2. アンチストリッピングスクリプト `SpineUnityCroppingHelper` を追加

## クイックスタート

### インストール方法（いずれかを選択）

1. `manifest.json` の `dependencies` に以下を追加：
   ```json
   {
      "com.gameframex.unity.esotericsoftware.spine.spine-unity": "https://github.com/AlianBlank/com.gameframex.unity.esotericsoftware.spine.spine-unity.git"
   }
   ```
2. Unity の `Packages Manager` で `Git URL` を使用して追加：`https://github.com/AlianBlank/com.gameframex.unity.esotericsoftware.spine.spine-unity.git`
3. リポジトリを直接ダウンロードして Unity プロジェクトの `Packages` ディレクトリに配置すると、自動的に読み込まれます。

## ドキュメントとリソース

- [Spine-Unity ドキュメント](https://zh.esotericsoftware.com/spine-unity)
- [GameFrameX ドキュメント](https://gameframex.doc.alianblank.com)

## コミュニティとサポート

- [QQグループ](https://qm.qq.com/q/5kbDVBdUeS)

## 変更履歴

変更履歴は [Releases](https://github.com/gameframex/com.gameframex.unity.esotericsoftware.spine.spine-unity/releases) をご覧ください。

## ライセンス

このプロジェクトは [Spine Runtime ライセンス](https://github.com/EsotericSoftware/spine-runtimes/blob/4.1/LICENSE) の下で公開されています。
