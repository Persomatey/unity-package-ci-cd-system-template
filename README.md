# Unity Package CI/CD System Template 
A simple free template CI/CD system for Unity packages using GitHub Actions. 

Check out [Releases](https://github.com/Persomatey/unity-package-ci-cd-system-template/releases) tab to see a history of all versions of this package. 

## Installation 
### Install via Package Manager

<details>
<summary>Select `Install package from git URL...` in the Package Manager</summary>
  <img src="https://raw.githubusercontent.com/Persomatey/unity-package-ci-cd-system-template/refs/heads/main/images/git-url-installation-example.png">
</details>

For latest release:</br>
`https://github.com/Persomatey/unity-package-ci-cd-system-template.git#upm`</br>
Or install specific releases:</br>
`https://github.com/Persomatey/unity-package-ci-cd-system-template.git#v#.#.#`

### Download the tarball directly from release
<details>
<summary>Go to Release and download directly from Assets</summary>
  <img src="https://raw.githubusercontent.com/Persomatey/unity-package-ci-cd-system-template/refs/heads/main/images/release-tab-tarball-circled.png">
</details>

`com.yourcompany.packagename-v#.#.#.tgz`

`com.yourcompany.packagename-v#.#.#.zip`

<details>
<summary>Select `Install package from tarball...` in the Package Manager</summary>
  <img src="https://raw.githubusercontent.com/Persomatey/unity-package-ci-cd-system-template/refs/heads/main/images/tarball-installation-example.png">
</details>

## Features 
- CI-safe Git operations
  - Git identity configured for GitHub Actions
  - Orphan branch creation handled cleanly
  - Fully non-interactive, repeatable pipeline
- Clean UPM-compliant package builds
  - Produces a sanitized package layout suitable for Unity Package Manager
  - Excludes project-only files (Assets, ProjectSettings, .github, etc.)
  - Ensures only package-safe contents are published
- GitHub Releases integration
  - Automatically publishes versioned releases
  - Release artifacts include ready-to-install package archives and git versioned UPM installation 
  - <details><summary>Release notes display changes included in Release; including commit SHA, subject, and description </summary><img src="https://raw.githubusercontent.com/Persomatey/unity-package-ci-cd-system-template/refs/heads/main/images/release-tab-cl2-circled.png"></details>
- Automated [semantic versioning](https://semver.org/) (MAJOR.MINOR.PATCH)
  - Every push increments the PATCH number, with MAJOR and MINOR being incremented maually. 
- Package samples 
  - Automatically converts Samples/ → Samples~/ for UPM compliance
  - Preserves sample scenes and assets
  - <details><summary>Enables the “Import” button in the "Samples" tab in the Package Manager</summary><img src="https://raw.githubusercontent.com/Persomatey/unity-package-ci-cd-system-template/refs/heads/main/images/sample-import-example.png"></details>
- Dedicated upm branch publishing
  - Uses a clean orphan upm branch containing only package contents
  - Force-pushes releases to ensure the branch stays pristine
  - Prevents accidental inclusion of build artifacts
- UPM tarball & zip artifact generation
  - Generates .tgz and .zip archives from the clean UPM build
  - Archives are attached to Release
- Package Manager metadata support (package.json) 
  - <details><summary>Documentation link wired to README.md</summary><img src="https://raw.githubusercontent.com/Persomatey/unity-package-ci-cd-system-template/refs/heads/main/images/package-doc-circled.png"></details>
  - <details><summary>Changelog link wired to GitHub Releases</summary><img src="https://raw.githubusercontent.com/Persomatey/unity-package-ci-cd-system-template/refs/heads/main/images/package-cl-circled.png"></details>
  - <details><summary>Licenses link wired to GitHub License</summary><img src="https://raw.githubusercontent.com/Persomatey/unity-package-ci-cd-system-template/refs/heads/main/images/package-lic-circled.png"></details>

## Workflows 

### Package (`package.yml`)
Every time a push is made to the GitHub repository, ... This will also increment the PATCH version number. A Release Tag will be generated and the builds generated will be included in your repo page's "Releases" tab. 

### Versioning (`version-bump.yml`)
Used to manually version bump the version number. Should be in the format `X.Y.Z`. All future pushes will subsequently start incrementing based on the new MAJOR or MINOR version changes. 
  - Ex: If the last version before triggering this workflow is `v0.0.42`, and the workflow was triggered with `v0.1.0`, the next `build.yml` workflow run will create the version tag `v0.1.1`. 

## Set up  
1. 

## Future Plans 
*No plans on when I'd release these features, would likely depend on my needs for a specific project/boredom/random interest in moving this project along.*
- [OpenUPM](https://openupm.com/) inteegration 
  - Ideally as an optional setting within the yaml 
  - This is necessary to have an automatic fully populated Version History tab in the Package Manager 
- Automated multi-version branches 
  - Having the `version-bump.yml` worflow generate new branches for each version MAJOR and MINOR version with their own CI 
    - Ex: Concurrently supported `v0.1.#` and `v0.2.#` and `v1.0.#` versions 
  - Necessary if you want multiple versions of a package suported in case there are compatability differences or feature additions across unique versions of Unity 
