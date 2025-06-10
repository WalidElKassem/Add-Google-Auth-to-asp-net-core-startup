# Add-Google-Auth-to-asp-net-core-startup

This is a simple snippet on how to configure Google Authentication service in ASP.NET Core application by using a json settings file

The Google credential key can be generated here: https://console.developers.google.com/apis/credentials

## Continuous Integration

This repository uses GitHub Actions to automatically run unit tests on each push or pull request to the `main` branch. The workflow file is located at `.github/workflows/ci.yml` and executes `dotnet test` against the test project.
