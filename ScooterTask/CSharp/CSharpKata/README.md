# Building and testing C# apps
The C# template here is a **class library** - it will not run independently, but it's easy to unit test without any system/console/etc. dependencies.
1. Ensure C# and dotnet are installed with `brew install --cask dotnet`
    > Install the C# Devkit extension for additional debug functionality
2. Build the project with `dotnet build`; restore dependencies with `dotnet restore`
3. Run the Xunit tests with `dotnet test`
   > You can automate testing runs by running `dotnet watch test` in the folder with the test project, `App.Tests`

## Debugging
1. Ensure the (correct) C# solution is open in the Solution Explorer (in the *Explorer* tab on the sidebar, provided by C# Devkit extension)
2. You can now add breakpoints, and run/debug tests by right-clicking on the sidebar icon.