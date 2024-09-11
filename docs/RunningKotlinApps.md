# Running and building Kotlin apps
> [Back to readme](../README.md)
1. Check your java and gradle versions; if needed, update with `brew install openjdk` & `brew install gradle`
2. [If no gradle project exists] run `gradle init` and pick appropriate options
3. Use the `./gradlew` wrapper to run commands:
    - `./gradlew build`
    - `./gradlew test` - uses Junit, will rebuild automatically if needed
    - `./gradlew run` will rebuild automatically if needed

