# Changelog
All notable changes to this project will be documented in this file.

The format is based on [Keep a Changelog](https://keepachangelog.com/en/1.0.0/),
and this project adheres to [Semantic Versioning](https://semver.org/spec/v2.0.0.html).

## [1.3.0] - 2022-09-05
### Added
- RuntimeAnchor: Implementation for collider anchor


## [1.2.1] - 2022-04-19
### Changed
- Variables: Change the way to set the variables


## [1.2.0] - 2022-03-18
### Added
- Add VariablesSO that also raise event on change.
- Auto setter for transform anchor

### Changed
- Anchor base update

### Fixed
- Remove unused using directives
- Fix small error when onplay with addressables


## [1.1.1] - 2021-10-28
### Fix
- Licensing stuff


## [1.1.0] - 2021-10-28
### Changed
- Add `NaughtyAttributes` as a requirement to use this library.
- Move RuntimeAnchors logic into generic class.


## [1.0.1] - 2021-10-28
### Changed
- Make Bool & GameObject channels inherit from BaseSO.


## [1.0.0] - 2021-10-12
First release of the package. Changes made include: 
- Using assembly definition files
- Remonving unused or specific scripts.
- Folder reorganisation.
- Adding README file.
