# Running and building Kotlin apps
> [Back to readme](../README.md)
1. Check your java and gradle versions; if needed, update with `brew install openjdk` & `brew install gradle`
2. [If no gradle project exists] run `gradle init` and pick appropriate options
3. Use the `./gradlew` wrapper to run commands:
    - `./gradlew build`
    - `./gradlew test` - uses Junit, will rebuild automatically if needed
    - `./gradlew run` will rebuild automatically if needed

## Tests and coverage
Run tests with watch using `./gradlew -t test`: `-t` is the Gradle watch flag
- Test output is found at [/app/buiild/reports/tests/test/index.html](app/build/reports/tests/test/index.html)
- Jacoco coverage output is found at [/app/buiild/reports/jacoco/test/html/index.html](app/build/reports/jacoco/test/html/index.html)

## Useful links
- [Gradle CLI reference](https://docs.gradle.org/current/userguide/command_line_interface.html)
- Rename gradle project: in settings.gradle file

