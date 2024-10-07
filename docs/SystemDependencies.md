# System dependencies

> [Back to readme](../README.md)
## Contents
- Kotlin dependencies
  - [`> java -version`  (run: 2024-09-11)](#-java--version--run-2024-09-11)
  - [`> gradle -version` (run: 2024-09-11)](#-gradle--version-run-2024-09-11)
- C# dependencies
  - [`> dotnet -version`  (run: 2024-10-05)](#-dotnet--version--run-2024-10-05)

---
### Kotlin dependencies
  `> java -version`  (run: 2024-09-11)
  ```
  openjdk version "21.0.1" 2023-10-17
  OpenJDK Runtime Environment (build 21.0.1+12-29)
  OpenJDK 64-Bit Server VM (build 21.0.1+12-29, mixed mode, sharing)
  ```

  ---
  `> gradle -version` (run: 2024-09-11)
  
  ```
  Welcome to Gradle 8.10.1!
  
  Here are the highlights of this release:
   - Support for Java 23
   - Faster configuration cache
   - Better configuration cache reports
  
  For more details see https://docs.gradle.org/8.10.1/release-notes.html
  
  
  ------------------------------------------------------------
  Gradle 8.10.1
  ------------------------------------------------------------
  
  Build time:    2024-09-09 07:42:56 UTC
  Revision:      8716158d3ec8c59e38f87a67f1f311f297b79576
  
  Kotlin:        1.9.24
  Groovy:        3.0.22
  Ant:           Apache Ant(TM) version 1.10.14 compiled on August 16 2023
  Launcher JVM:  22.0.2 (Homebrew 22.0.2)
  Daemon JVM:    /opt/homebrew/Cellar/openjdk/22.0.2/libexec/openjdk.jdk/Contents/Home (no JDK specified, using current Java home)
  OS:            Mac OS X 14.5 aarch64
  ```

  ---
### C# dependencies
  N.B. to target a different .Net version, change the `App.csproj` and `App.Test.csproj` files to target that other version, then rebuild.
  
  `> dotnet -version` (run: 2024-10-05)  
  `8.0.203`
