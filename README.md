<!--
  ============================================================================
  README 프레임 구조 (GIF 활용형)
  - 각 섹션은 <!-- GUIDE --> 주석의 안내에 맞춰 실제 내용으로 채우세요.
  - GIF 경로는 Documentation/ 폴더 기준입니다. (예: Documentation/package-demo.gif)
  - 불필요한 섹션은 통째로 삭제해도 됩니다.
  ============================================================================
-->

<<<<<<< Updated upstream
![패키지 데모](Documentation/package-demo.gif)
=======
<!-- ===================== 1. 헤더 / 히어로 ===================== -->
<div align="center">

# TTest Giant Scripts

<!-- GUIDE: 패키지 한 줄 소개(태그라인). 무엇을, 왜 쓰는지 한 문장. -->
**Assembly definition & compilation-time 샘플 스크립트 모음**

<!-- GUIDE: 배지. 아래 값들을 실제 정보로 교체하세요. -->
![Unity](https://img.shields.io/badge/Unity-6000.0%2B-black?logo=unity)
![Version](https://img.shields.io/badge/version-1.0.1-blue)
![License](https://img.shields.io/badge/license-MIT-green)

<!-- ===================== 히어로 GIF ===================== -->
<!-- GUIDE: 패키지를 한눈에 보여주는 대표 데모 GIF. 가장 임팩트 있는 장면 하나. -->
<img src="Documentation/package-demo.gif" alt="데모" width="80%" />

</div>

<!-- ===================== 2. 목차 ===================== -->
## 목차

- [소개](#소개)
- [미리보기](#미리보기)
- [주요 기능](#주요-기능)
- [설치](#설치)
- [빠른 시작](#빠른-시작)
- [구성 요소](#구성-요소)
- [라이선스](#라이선스)

---

<!-- ===================== 3. 소개 ===================== -->
## 소개

<!-- GUIDE: 2~4문장. 이 패키지가 해결하는 문제와 대상 사용자.
     "누가 / 언제 / 왜" 쓰는지가 드러나게. -->

---

<!-- ===================== 4. 미리보기 (GIF 테이블) ===================== -->
## 미리보기

<!-- GUIDE: 기능 ↔ GIF 매칭 테이블. GitHub에서 GIF를 나란히 배치하는 표준 방식.
     행을 추가/삭제해 기능 수에 맞추세요. width로 크기를 통일하면 깔끔합니다. -->

| 기능 | 미리보기 |
| :--- | :---: |
| **<!-- 기능명 A -->** <br/> <!-- 한 줄 설명 --> | <img src="Documentation/feature-a.gif" width="320"/> |
| **<!-- 기능명 B -->** <br/> <!-- 한 줄 설명 --> | <img src="Documentation/feature-b.gif" width="320"/> |

<!-- GUIDE(선택): 용량이 큰 GIF나 부가 데모는 토글로 접어두면 로딩/가독성에 좋습니다. -->
<details>
<summary>더 많은 데모 보기</summary>

<br/>

<img src="Documentation/extra-demo.gif" width="60%" />

</details>

---

<!-- ===================== 5. 주요 기능 ===================== -->
## 주요 기능

<!-- GUIDE: 글머리 3~6개. 각 항목은 "결과/이점" 중심으로. -->
- ✨ <!-- 기능 1 -->
- ⚡ <!-- 기능 2 -->
- 🧩 <!-- 기능 3 -->

---

<!-- ===================== 6. 설치 ===================== -->
## 설치

<!-- GUIDE: Unity 패키지 설치 방법. 아래 2가지가 일반적입니다. 불필요한 쪽 삭제. -->

### Package Manager (Git URL)

`Window > Package Manager > + > Add package from git URL...`

```
https://github.com/<OWNER>/<REPO>.git
```

### manifest.json 직접 추가

```jsonc
// Packages/manifest.json
{
  "dependencies": {
    "com.ttest.giant-scripts": "https://github.com/<OWNER>/<REPO>.git#1.0.1"
  }
}
```

---

<!-- ===================== 7. 빠른 시작 ===================== -->
## 빠른 시작

<!-- GUIDE: 설치 후 가장 먼저 해볼 수 있는 최소 예제. GIF와 함께 두면 효과적. -->

```csharp
// GUIDE: 가장 기본적인 사용 예제 코드
```

<!-- GUIDE(선택): 위 코드의 실행 결과 GIF -->
<div align="center">
  <img src="Documentation/quickstart.gif" width="70%" />
</div>

---

<!-- ===================== 8. 구성 요소 ===================== -->
## 구성 요소

<!-- GUIDE: 패키지에 포함된 스크립트/어셈블리 설명. 실제 파일에 맞춰 수정. -->

| 항목 | 설명 |
| :--- | :--- |
| `GiantScripts.asmdef` | <!-- 어셈블리 정의 설명 --> |
| `CompilationTimer.cs` | <!-- 컴파일 시간 측정 로그 출력 등 --> |
| `GiantScript.cs` / `TinyScript.cs` | <!-- 샘플 스크립트 설명 --> |
| `Bonus/` | <!-- asmref 보너스 스크립트 설명 --> |

---

<!-- ===================== 9. 라이선스 ===================== -->
## 라이선스

<!-- GUIDE: LICENSE.md 참조. 라이선스 종류 명시. -->
See [LICENSE.md](LICENSE.md).
>>>>>>> Stashed changes
