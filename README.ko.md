<div align="center">

<img src="https://download.alianblank.com/gameframex/gameframex_logo_320.png" alt="GameFrameX Logo" width="160"/>

# Game Frame X Spine-Unity 런타임

[![License](https://img.shields.io/github/license/gameframex/com.gameframex.unity.esotericsoftware.spine.spine-unity)](https://github.com/gameframex/com.gameframex.unity.esotericsoftware.spine.spine-unity/blob/main/LICENSE)
[![Version](https://img.shields.io/github/v/release/gameframex/com.gameframex.unity.esotericsoftware.spine.spine-unity)](https://github.com/gameframex/com.gameframex.unity.esotericsoftware.spine.spine-unity/releases)
[![Documentation](https://img.shields.io/badge/Documentation-문서-blue)](https://gameframex.doc.alianblank.com)

인디 게임 개발자를 위한 올인원 솔루션 · 인디 개발자의 꿈을 실현

[문서](https://gameframex.doc.alianblank.com) · [빠른 시작](#빠른-시작) · [QQ 그룹](https://qm.qq.com/q/5kbDVBdUeS) · **언어**

[English](README.md) | [简体中文](README.zh-CN.md) | [繁體中文](README.zh-TW.md) | [日本語](README.ja.md) | **한국어**

</div>

---

## 프로젝트 개요

공식 Spine Runtime에서 재패키징된 **Spine-Unity** 런타임의 2차 배포판입니다. 이 라이브러리는 주로 [GameFrameX](https://github.com/AlianBlank/GameFrameX)의 서브모듈로 사용됩니다.

### 공식 버전에서의 변경 사항

1. 스트립 필터링을 위한 `link.xml` 추가
2. 안티 스트리핑 스크립트 `SpineUnityCroppingHelper` 추가

## 빠른 시작

### 설치 방법 (선택)

1. `manifest.json`의 `dependencies`에 다음 내용을 추가:
   ```json
   {
      "com.gameframex.unity.esotericsoftware.spine.spine-unity": "https://github.com/AlianBlank/com.gameframex.unity.esotericsoftware.spine.spine-unity.git"
   }
   ```
2. Unity의 `Packages Manager`에서 `Git URL`을 사용하여 추가: `https://github.com/AlianBlank/com.gameframex.unity.esotericsoftware.spine.spine-unity.git`
3. 저장소를 직접 다운로드하여 Unity 프로젝트의 `Packages` 디렉토리에 배치하면 자동으로 로드됩니다.

## 문서 및 자료

- [Spine-Unity 문서](https://zh.esotericsoftware.com/spine-unity)
- [GameFrameX 문서](https://gameframex.doc.alianblank.com)

## 커뮤니티 및 지원

- [QQ 그룹](https://qm.qq.com/q/5kbDVBdUeS)

## 변경 로그

변경 로그는 [Releases](https://github.com/gameframex/com.gameframex.unity.esotericsoftware.spine.spine-unity/releases)에서 확인하세요.

## 라이선스

이 프로젝트는 [Spine Runtime 라이선스](https://github.com/EsotericSoftware/spine-runtimes/blob/4.1/LICENSE)에 따라 배포됩니다.
