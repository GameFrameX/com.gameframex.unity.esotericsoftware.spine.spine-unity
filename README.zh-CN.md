<div align="center">

<img src="https://download.alianblank.com/gameframex/gameframex_logo_320.png" alt="GameFrameX Logo" width="160"/>

# Game Frame X Spine-Unity 运行时

[![License](https://img.shields.io/github/license/gameframex/com.gameframex.unity.esotericsoftware.spine.spine-unity)](https://github.com/gameframex/com.gameframex.unity.esotericsoftware.spine.spine-unity/blob/main/LICENSE)
[![Version](https://img.shields.io/github/v/release/gameframex/com.gameframex.unity.esotericsoftware.spine.spine-unity)](https://github.com/gameframex/com.gameframex.unity.esotericsoftware.spine.spine-unity/releases)
[![Documentation](https://img.shields.io/badge/Documentation-文档-blue)](https://gameframex.doc.alianblank.com)

独立游戏前后端一体化解决方案 · 独立游戏开发者的圆梦大使

[文档](https://gameframex.doc.alianblank.com) · [快速开始](#快速开始) · [QQ群](https://qm.qq.com/q/5kbDVBdUeS) · **语言**

[English](README.md) | **简体中文** | [繁體中文](README.zh-TW.md) | [日本語](README.ja.md) | [한국어](README.ko.md)

</div>

---

## 项目简介

基于 **Spine-Unity** 官方运行时的二次分发包装。该库主要服务于 [GameFrameX](https://github.com/AlianBlank/GameFrameX) 作为子库使用。

### 改动功能

1. 增加 `link.xml` 的裁剪过滤
2. 增加 `SpineUnityCroppingHelper` 防裁剪脚本

## 快速开始

### 安装方式（任选其一）

1. 直接在 `manifest.json` 的 `dependencies` 节点下添加以下内容：
   ```json
   {
      "com.gameframex.unity.esotericsoftware.spine.spine-unity": "https://github.com/AlianBlank/com.gameframex.unity.esotericsoftware.spine.spine-unity.git"
   }
   ```
2. 在 Unity 的 `Packages Manager` 中使用 `Git URL` 的方式添加库，地址为：`https://github.com/AlianBlank/com.gameframex.unity.esotericsoftware.spine.spine-unity.git`
3. 直接下载仓库放置到 Unity 项目的 `Packages` 目录下，会自动加载识别。

## 文档与资源

- [Spine-Unity 使用文档](https://zh.esotericsoftware.com/spine-unity)
- [GameFrameX 文档](https://gameframex.doc.alianblank.com)

## 社区与支持

- [QQ群](https://qm.qq.com/q/5kbDVBdUeS)

## 更新日志

查看 [Releases](https://github.com/gameframex/com.gameframex.unity.esotericsoftware.spine.spine-unity/releases) 了解更新日志。

## 开源协议

本项目基于 [Spine Runtime 许可协议](https://github.com/EsotericSoftware/spine-runtimes/blob/4.1/LICENSE) 开源。
