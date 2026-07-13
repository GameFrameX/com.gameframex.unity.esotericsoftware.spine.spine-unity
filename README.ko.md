<div align="center">

<img src="https://download.alianblank.com/gameframex/gameframex_logo_320.png" alt="Game Frame X Logo" width="160" />

# Game Frame X Spine-Unity 런타임

[![License](https://img.shields.io/github/license/GameFrameX/com.gameframex.unity.esotericsoftware.spine.spine-unity)](https://github.com/GameFrameX/com.gameframex.unity.esotericsoftware.spine.spine-unity/blob/main/LICENSE.md)
[![Version](https://img.shields.io/github/v/release/GameFrameX/com.gameframex.unity.esotericsoftware.spine.spine-unity)](https://github.com/GameFrameX/com.gameframex.unity.esotericsoftware.spine.spine-unity/releases)
[![Unity Version](https://img.shields.io/badge/Unity-2019.4-black?logo=unity)](https://unity.com/)
[![Documentation](https://img.shields.io/badge/Documentation-docs-blue)](https://gameframex.doc.alianblank.com)

인디 게임 개발자를 위한 올인원 솔루션 · 인디 개발자의 꿈을 실현

<br />

[문서](https://gameframex.doc.alianblank.com) · [빠른 시작](#빠른-시작) · QQ 그룹: 467608841 / 233840761

<br />

[English](README.md) | [简体中文](README.zh-CN.md) | [繁體中文](README.zh-TW.md) | [日本語](README.ja.md) | **한국어**

</div>

## 프로젝트 개요

공식 Spine Runtime에서 재패키징된 **Spine-Unity** 런타임의 2차 배포판입니다. 이 라이브러리는 주로 [GameFrameX](https://github.com/AlianBlank/GameFrameX)의 서브모듈로 사용됩니다.

### 공식 버전에서의 변경 사항

1. 스트립 필터링을 위한 `link.xml` 추가
2. 안티 스트리핑 스크립트 `SpineUnityCroppingHelper` 추가

## 빠른 시작

### 설치

다음 방법 중 하나를 선택하세요:

1. Unity 프로젝트의 `Packages/manifest.json`을 편집하여 `scopedRegistries` 섹션을 추가하세요:
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
       "com.gameframex.unity.esotericsoftware.spine.spine-unity": "4.3.96"
     }
   }
   ```

   `scopes`는 이 레지스트리를 통해 어떤 패키지를 해석할지 제어합니다. `com.gameframex`로 시작하는 패키지만 이 레지스트리에서 가져옵니다.

2. `manifest.json`의 `dependencies`에 직접 추가:
   ```json
   {
      "com.gameframex.unity.esotericsoftware.spine.spine-unity": "https://github.com/gameframex/com.gameframex.unity.esotericsoftware.spine.spine-unity.git"
   }
   ```
3. Unity의 **Package Manager**에서 **Git URL**을 사용하여 추가: `https://github.com/gameframex/com.gameframex.unity.esotericsoftware.spine.spine-unity.git`
4. 리포지토리를 Unity 프로젝트의 `Packages` 디렉토리에 클론하세요. 자동으로 로드됩니다.
## 문서 및 자료

- [Spine-Unity 문서](https://zh.esotericsoftware.com/spine-unity)
- [GameFrameX 문서](https://gameframex.doc.alianblank.com)

## 커뮤니티 및 지원

- QQ 그룹: 467608841 / 233840761

## 변경 로그

변경 로그는 [Releases](https://github.com/gameframex/com.gameframex.unity.esotericsoftware.spine.spine-unity/releases)에서 확인하세요.


## 의존성

| 패키지 | 설명 |
|--------|------|
| (无) | - |

## 라이선스

자세한 내용은 [LICENSE.md](LICENSE.md) 파일을 참조하세요.
