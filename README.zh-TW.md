<div align="center">

<img src="https://download.alianblank.com/gameframex/gameframex_logo_320.png" alt="GameFrameX Logo" width="160"/>

# Game Frame X Spine-Unity 執行時期

[![License](https://img.shields.io/github/license/gameframex/com.gameframex.unity.esotericsoftware.spine.spine-unity)](https://github.com/gameframex/com.gameframex.unity.esotericsoftware.spine.spine-unity/blob/main/LICENSE)
[![Version](https://img.shields.io/github/v/release/gameframex/com.gameframex.unity.esotericsoftware.spine.spine-unity)](https://github.com/gameframex/com.gameframex.unity.esotericsoftware.spine.spine-unity/releases)
[![Documentation](https://img.shields.io/badge/Documentation-文檔-blue)](https://gameframex.doc.alianblank.com)

獨立遊戲前後端一體化解決方案 · 獨立遊戲開發者的圓夢大使

[文檔](https://gameframex.doc.alianblank.com) · [快速開始](#快速開始) · [QQ群](https://qm.qq.com/q/5kbDVBdUeS) · **語言**

[English](README.md) | [简体中文](README.zh-CN.md) | **繁體中文** | [日本語](README.ja.md) | [한국어](README.ko.md)

</div>

---

## 項目簡介

基於 **Spine-Unity** 官方執行時期的二次分發包裝。此函式庫主要服務於 [GameFrameX](https://github.com/AlianBlank/GameFrameX) 作為子庫使用。

### 改動功能

1. 新增 `link.xml` 的裁剪過濾
2. 新增 `SpineUnityCroppingHelper` 防裁剪腳本

## 快速開始

### 安裝方式（任選其一）

1. 直接在 `manifest.json` 的 `dependencies` 節點下新增以下內容：
   ```json
   {
      "com.gameframex.unity.esotericsoftware.spine.spine-unity": "https://github.com/AlianBlank/com.gameframex.unity.esotericsoftware.spine.spine-unity.git"
   }
   ```
2. 在 Unity 的 `Packages Manager` 中使用 `Git URL` 的方式新增庫，地址為：`https://github.com/AlianBlank/com.gameframex.unity.esotericsoftware.spine.spine-unity.git`
3. 直接下載倉庫放置到 Unity 專案的 `Packages` 目錄下，會自動載入識別。

## 文檔與資源

- [Spine-Unity 使用文檔](https://zh.esotericsoftware.com/spine-unity)
- [GameFrameX 文檔](https://gameframex.doc.alianblank.com)

## 社區與支援

- [QQ群](https://qm.qq.com/q/5kbDVBdUeS)

## 更新日誌

查看 [Releases](https://github.com/gameframex/com.gameframex.unity.esotericsoftware.spine.spine-unity/releases) 了解更新日誌。

## 開源協議

本專案基於 [Spine Runtime 授權協議](https://github.com/EsotericSoftware/spine-runtimes/blob/4.1/LICENSE) 開源。
