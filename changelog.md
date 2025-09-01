# Changelog

## [v2025.9.1](https://github.com/devlooped/chromium/tree/v2025.9.1) (2025-08-31)

[Full Changelog](https://github.com/devlooped/chromium/compare/v2025.8.31...v2025.9.1)

## [v2025.8.31](https://github.com/devlooped/chromium/tree/v2025.8.31) (2025-08-16)

[Full Changelog](https://github.com/devlooped/chromium/compare/v2025.8.16...v2025.8.31)

## [v2025.8.16](https://github.com/devlooped/chromium/tree/v2025.8.16) (2025-08-01)

[Full Changelog](https://github.com/devlooped/chromium/compare/v2025.8.1...v2025.8.16)

## [v2025.8.1](https://github.com/devlooped/chromium/tree/v2025.8.1) (2025-07-31)

[Full Changelog](https://github.com/devlooped/chromium/compare/v2025.7.31...v2025.8.1)

## [v2025.7.31](https://github.com/devlooped/chromium/tree/v2025.7.31) (2025-07-16)

[Full Changelog](https://github.com/devlooped/chromium/compare/v2025.7.16...v2025.7.31)

## [v2025.7.16](https://github.com/devlooped/chromium/tree/v2025.7.16) (2025-07-01)

[Full Changelog](https://github.com/devlooped/chromium/compare/v2025.7.1...v2025.7.16)

## [v2025.7.1](https://github.com/devlooped/chromium/tree/v2025.7.1) (2025-06-16)

[Full Changelog](https://github.com/devlooped/chromium/compare/v2025.6.16...v2025.7.1)

## [v2025.6.16](https://github.com/devlooped/chromium/tree/v2025.6.16) (2025-06-01)

[Full Changelog](https://github.com/devlooped/chromium/compare/v2025.6.1...v2025.6.16)

## [v2025.6.1](https://github.com/devlooped/chromium/tree/v2025.6.1) (2025-05-31)

[Full Changelog](https://github.com/devlooped/chromium/compare/v2025.5.31...v2025.6.1)

## [v2025.5.31](https://github.com/devlooped/chromium/tree/v2025.5.31) (2025-05-16)

[Full Changelog](https://github.com/devlooped/chromium/compare/v2025.5.16...v2025.5.31)

## [v2025.5.16](https://github.com/devlooped/chromium/tree/v2025.5.16) (2025-05-01)

[Full Changelog](https://github.com/devlooped/chromium/compare/v2025.5.1...v2025.5.16)

## [v2025.5.1](https://github.com/devlooped/chromium/tree/v2025.5.1) (2025-04-16)

[Full Changelog](https://github.com/devlooped/chromium/compare/v2025.4.16...v2025.5.1)

## [v2025.4.16](https://github.com/devlooped/chromium/tree/v2025.4.16) (2025-04-01)

[Full Changelog](https://github.com/devlooped/chromium/compare/v2025.4.1...v2025.4.16)

## [v2025.4.1](https://github.com/devlooped/chromium/tree/v2025.4.1) (2025-03-31)

[Full Changelog](https://github.com/devlooped/chromium/compare/v2025.3.31...v2025.4.1)

## [v2025.3.31](https://github.com/devlooped/chromium/tree/v2025.3.31) (2025-03-16)

[Full Changelog](https://github.com/devlooped/chromium/compare/v2025.3.16...v2025.3.31)

## [v2025.3.16](https://github.com/devlooped/chromium/tree/v2025.3.16) (2025-03-10)

[Full Changelog](https://github.com/devlooped/chromium/compare/v2025.3.1...v2025.3.16)

## [v2025.3.1](https://github.com/devlooped/chromium/tree/v2025.3.1) (2025-02-26)

[Full Changelog](https://github.com/devlooped/chromium/compare/v2025.02.23...v2025.3.1)

:bug: Fixed bugs:

- Omit leading zeroes in released version [\#111](https://github.com/devlooped/chromium/pull/111) (@kzu)

## [v2025.02.23](https://github.com/devlooped/chromium/tree/v2025.02.23) (2025-02-23)

[Full Changelog](https://github.com/devlooped/chromium/compare/v2025.02.16...v2025.02.23)

:sparkles: Implemented enhancements:

- Make version location more flexible [\#106](https://github.com/devlooped/chromium/pull/106) (@kzu)
- Showcase how to do dynamic runtime native dependencies [\#102](https://github.com/devlooped/chromium/pull/102) (@kzu)

:bug: Fixed bugs:

- Make sure chromium is executable in \*nix [\#110](https://github.com/devlooped/chromium/pull/110) (@kzu)
- Fix path lookup using normalized package version [\#108](https://github.com/devlooped/chromium/pull/108) (@kzu)
- Only consider a successfull path if it actually exists [\#104](https://github.com/devlooped/chromium/pull/104) (@kzu)

:twisted_rightwards_arrows: Merged:

- Make sure we test before release too [\#107](https://github.com/devlooped/chromium/pull/107) (@kzu)
- Run chromium cross-platform test [\#105](https://github.com/devlooped/chromium/pull/105) (@kzu)

## [v2025.02.16](https://github.com/devlooped/chromium/tree/v2025.02.16) (2025-02-08)

[Full Changelog](https://github.com/devlooped/chromium/compare/v2025.02.07...v2025.02.16)

:sparkles: Implemented enhancements:

- Delete all locales except for en-US [\#97](https://github.com/devlooped/chromium/issues/97)
- Cleanup non en-US locales after unpack [\#98](https://github.com/devlooped/chromium/pull/98) (@kzu)

## [v2025.02.07](https://github.com/devlooped/chromium/tree/v2025.02.07) (2025-02-07)

[Full Changelog](https://github.com/devlooped/chromium/compare/v2025.02.01...v2025.02.07)

:sparkles: Implemented enhancements:

- Don't pack interactive\_ui\_tests.exe in the windows runtime [\#95](https://github.com/devlooped/chromium/issues/95)
- Delete unnecessary interactive\_ui\_tests.exe after unzip [\#96](https://github.com/devlooped/chromium/pull/96) (@kzu)

## [v2025.02.01](https://github.com/devlooped/chromium/tree/v2025.02.01) (2025-01-31)

[Full Changelog](https://github.com/devlooped/chromium/compare/v2025.01.31...v2025.02.01)

## [v2025.01.31](https://github.com/devlooped/chromium/tree/v2025.01.31) (2025-01-16)

[Full Changelog](https://github.com/devlooped/chromium/compare/v2025.01.16...v2025.01.31)

## [v2025.01.16](https://github.com/devlooped/chromium/tree/v2025.01.16) (2025-01-01)

[Full Changelog](https://github.com/devlooped/chromium/compare/v2025.01.01...v2025.01.16)

## [v2025.01.01](https://github.com/devlooped/chromium/tree/v2025.01.01) (2024-12-31)

[Full Changelog](https://github.com/devlooped/chromium/compare/v2024.12.31...v2025.01.01)

## [v2024.12.31](https://github.com/devlooped/chromium/tree/v2024.12.31) (2024-12-16)

[Full Changelog](https://github.com/devlooped/chromium/compare/v2024.12.16...v2024.12.31)

## [v2024.12.16](https://github.com/devlooped/chromium/tree/v2024.12.16) (2024-12-01)

[Full Changelog](https://github.com/devlooped/chromium/compare/v2024.12.01...v2024.12.16)

## [v2024.12.01](https://github.com/devlooped/chromium/tree/v2024.12.01) (2024-11-16)

[Full Changelog](https://github.com/devlooped/chromium/compare/v2024.11.16...v2024.12.01)

## [v2024.11.16](https://github.com/devlooped/chromium/tree/v2024.11.16) (2024-11-01)

[Full Changelog](https://github.com/devlooped/chromium/compare/v2024.11.01...v2024.11.16)

## [v2024.11.01](https://github.com/devlooped/chromium/tree/v2024.11.01) (2024-10-31)

[Full Changelog](https://github.com/devlooped/chromium/compare/v2024.10.31...v2024.11.01)

## [v2024.10.31](https://github.com/devlooped/chromium/tree/v2024.10.31) (2024-10-16)

[Full Changelog](https://github.com/devlooped/chromium/compare/v2024.10.16...v2024.10.31)

## [v2024.10.16](https://github.com/devlooped/chromium/tree/v2024.10.16) (2024-10-01)

[Full Changelog](https://github.com/devlooped/chromium/compare/v2024.10.01...v2024.10.16)

## [v2024.10.01](https://github.com/devlooped/chromium/tree/v2024.10.01) (2024-09-16)

[Full Changelog](https://github.com/devlooped/chromium/compare/v2024.09.16...v2024.10.01)

## [v2024.09.16](https://github.com/devlooped/chromium/tree/v2024.09.16) (2024-09-01)

[Full Changelog](https://github.com/devlooped/chromium/compare/v2024.09.01...v2024.09.16)

## [v2024.09.01](https://github.com/devlooped/chromium/tree/v2024.09.01) (2024-08-31)

[Full Changelog](https://github.com/devlooped/chromium/compare/v2024.08.31...v2024.09.01)

## [v2024.08.31](https://github.com/devlooped/chromium/tree/v2024.08.31) (2024-08-16)

[Full Changelog](https://github.com/devlooped/chromium/compare/v2024.08.16...v2024.08.31)

## [v2024.08.16](https://github.com/devlooped/chromium/tree/v2024.08.16) (2024-08-01)

[Full Changelog](https://github.com/devlooped/chromium/compare/v2024.08.01...v2024.08.16)

## [v2024.08.01](https://github.com/devlooped/chromium/tree/v2024.08.01) (2024-07-31)

[Full Changelog](https://github.com/devlooped/chromium/compare/v2024.07.31...v2024.08.01)

## [v2024.07.31](https://github.com/devlooped/chromium/tree/v2024.07.31) (2024-07-16)

[Full Changelog](https://github.com/devlooped/chromium/compare/v2024.07.16...v2024.07.31)

## [v2024.07.16](https://github.com/devlooped/chromium/tree/v2024.07.16) (2024-07-01)

[Full Changelog](https://github.com/devlooped/chromium/compare/v2024.07.01...v2024.07.16)

## [v2024.07.01](https://github.com/devlooped/chromium/tree/v2024.07.01) (2024-06-16)

[Full Changelog](https://github.com/devlooped/chromium/compare/v2024.06.16...v2024.07.01)

## [v2024.06.16](https://github.com/devlooped/chromium/tree/v2024.06.16) (2024-06-13)

[Full Changelog](https://github.com/devlooped/chromium/compare/v2024.06.01...v2024.06.16)

## [v2024.06.01](https://github.com/devlooped/chromium/tree/v2024.06.01) (2024-05-31)

[Full Changelog](https://github.com/devlooped/chromium/compare/v2024.05.31...v2024.06.01)

## [v2024.05.31](https://github.com/devlooped/chromium/tree/v2024.05.31) (2024-05-16)

[Full Changelog](https://github.com/devlooped/chromium/compare/v2024.05.16...v2024.05.31)

## [v2024.05.16](https://github.com/devlooped/chromium/tree/v2024.05.16) (2024-05-01)

[Full Changelog](https://github.com/devlooped/chromium/compare/v2024.05.01...v2024.05.16)

## [v2024.05.01](https://github.com/devlooped/chromium/tree/v2024.05.01) (2024-04-16)

[Full Changelog](https://github.com/devlooped/chromium/compare/v2024.04.16...v2024.05.01)

## [v2024.04.16](https://github.com/devlooped/chromium/tree/v2024.04.16) (2024-04-01)

[Full Changelog](https://github.com/devlooped/chromium/compare/v2024.04.01...v2024.04.16)

## [v2024.04.01](https://github.com/devlooped/chromium/tree/v2024.04.01) (2024-03-31)

[Full Changelog](https://github.com/devlooped/chromium/compare/v2024.03.31...v2024.04.01)

## [v2024.03.31](https://github.com/devlooped/chromium/tree/v2024.03.31) (2024-03-16)

[Full Changelog](https://github.com/devlooped/chromium/compare/v2024.03.16...v2024.03.31)

## [v2024.03.16](https://github.com/devlooped/chromium/tree/v2024.03.16) (2024-03-15)

[Full Changelog](https://github.com/devlooped/chromium/compare/v2024.03.01...v2024.03.16)

:twisted_rightwards_arrows: Merged:

- Update readme.md [\#89](https://github.com/devlooped/chromium/pull/89) (@kzu)

## [v2024.03.01](https://github.com/devlooped/chromium/tree/v2024.03.01) (2024-02-16)

[Full Changelog](https://github.com/devlooped/chromium/compare/v2024.02.16...v2024.03.01)

## [v2024.02.16](https://github.com/devlooped/chromium/tree/v2024.02.16) (2024-02-04)

[Full Changelog](https://github.com/devlooped/chromium/compare/v2024.02.01...v2024.02.16)

## [v2024.02.01](https://github.com/devlooped/chromium/tree/v2024.02.01) (2024-01-31)

[Full Changelog](https://github.com/devlooped/chromium/compare/v2024.01.31...v2024.02.01)

## [v2024.01.31](https://github.com/devlooped/chromium/tree/v2024.01.31) (2024-01-30)

[Full Changelog](https://github.com/devlooped/chromium/compare/v2024.01.30-beta...v2024.01.31)

## [v2024.01.30-beta](https://github.com/devlooped/chromium/tree/v2024.01.30-beta) (2024-01-30)

[Full Changelog](https://github.com/devlooped/chromium/compare/v2024.01.30...v2024.01.30-beta)

:sparkles: Implemented enhancements:

- Bump to latest chromium supported by latest Playwright [\#14](https://github.com/devlooped/chromium/issues/14)

:twisted_rightwards_arrows: Merged:

- Bump dependencies [\#79](https://github.com/devlooped/chromium/pull/79) (@kzu)

## [v2024.01.30](https://github.com/devlooped/chromium/tree/v2024.01.30) (2023-10-12)

[Full Changelog](https://github.com/devlooped/chromium/compare/v2023.10.11...v2024.01.30)

## [v2023.10.11](https://github.com/devlooped/chromium/tree/v2023.10.11) (2023-10-11)

[Full Changelog](https://github.com/devlooped/chromium/compare/v2022.6.4...v2023.10.11)

:sparkles: Implemented enhancements:

- Add SponsorLink to support the project [\#45](https://github.com/devlooped/chromium/pull/45) (@kzu)

:twisted_rightwards_arrows: Merged:

- Update readme.md [\#70](https://github.com/devlooped/chromium/pull/70) (@kzu)

## [v2022.6.4](https://github.com/devlooped/chromium/tree/v2022.6.4) (2022-06-04)

[Full Changelog](https://github.com/devlooped/chromium/compare/v2022.6.4-beta...v2022.6.4)

## [v2022.6.4-beta](https://github.com/devlooped/chromium/tree/v2022.6.4-beta) (2022-06-04)

[Full Changelog](https://github.com/devlooped/chromium/compare/v2022.6.4-alpha...v2022.6.4-beta)

:sparkles: Implemented enhancements:

- Remove linux-x86 which hasn't been updated in years [\#4](https://github.com/devlooped/chromium/issues/4)

:twisted_rightwards_arrows: Merged:

- Remove linux-x86 which hasn't been updated in years [\#6](https://github.com/devlooped/chromium/pull/6) (@kzu)

## [v2022.6.4-alpha](https://github.com/devlooped/chromium/tree/v2022.6.4-alpha) (2022-06-04)

[Full Changelog](https://github.com/devlooped/chromium/compare/04978d40d452bee8fc37b70ba31475a6ae6c1c67...v2022.6.4-alpha)

:twisted_rightwards_arrows: Merged:

- Add the rest of the platforms that chromium supports [\#2](https://github.com/devlooped/chromium/pull/2) (@kzu)
- Fixup native chrome lookup for installed tool scenario [\#1](https://github.com/devlooped/chromium/pull/1) (@kzu)



\* *This Changelog was automatically generated by [github_changelog_generator](https://github.com/github-changelog-generator/github-changelog-generator)*
