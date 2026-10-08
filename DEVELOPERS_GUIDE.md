# Developer Guide

This guide explains how to build and test the library on macOS.

## Prerequisites

### .NET SDK

The project and tests target .NET 8. Install the .NET SDK with Homebrew:

```sh
brew install dotnet
```

Homebrew currently installs .NET 10. The project builds with .NET 10, but the
.NET 8 test projects require runtime roll-forward when running tests.

Confirm that the installation succeeded:

```sh
dotnet --version
```

### Rider (optional)

You can use any editor that supports .NET. We recommend JetBrains Rider, which
you can install through the JetBrains Toolbox.

## Build the project

From the repository root, restore dependencies and build the solution:

```sh
dotnet build
```

## Run unit tests

From the repository root, run the unit tests:

```sh
DOTNET_ROLL_FORWARD=Major dotnet test Adyen.Test/Adyen.Test.csproj
```

You can also run the tests from Rider using its built-in test runner.

## Run integration tests

The integration tests make requests to the Adyen test environment. Before
running them, copy `Adyen.IntegrationTest/test-config.example.json` to the ignored
`Adyen.IntegrationTest/test-config.json` and complete every value. Alternatively,
provide the raw JSON through `ADYEN_API_LIBRARIES_INTEGRATION_TEST_CONFIG`.

Never commit API keys or other credentials to the repository.

From the repository root, run the integration tests:

```sh
DOTNET_ROLL_FORWARD=Major dotnet test Adyen.IntegrationTest/Adyen.IntegrationTest.csproj
```

See [the integration-test README](Adyen.IntegrationTest/README.md) for configuration
fields, offline validation, and the GitHub workflow. Do not use an
unfiltered solution-level `dotnet test` for offline validation.