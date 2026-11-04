# Developer Guide

This guide explains how to build and test the library on macOS.

## Prerequisites

### .NET SDK

> We recommend .NET 10 LTS for new applications. Microsoft support for .NET 8 ends on
> [November 10, 2026](https://dotnet.microsoft.com/en-us/platform/support/policy/dotnet-core).
> The library retains its `net8.0` target for compatibility, including use from .NET 10 applications.

The library targets .NET 8, .NET Framework 4.6.2, and .NET Standard 2.0.
The unit and integration test projects target both .NET 8 and .NET 10.
Install the .NET 10 SDK with Homebrew:

```sh
brew install dotnet
```

The .NET 10 SDK is required to build the multi-target test projects. To run
both test targets on their actual runtimes, also install the .NET 8 runtime.
The .NET 10 tests consume the library's existing .NET 8 build.

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

From the repository root, run the unit tests on .NET 10:

```sh
dotnet test Adyen.Test/Adyen.Test.csproj --framework net10.0
```

To test on .NET 8, use `--framework net8.0` with the .NET 8 runtime installed.
Omit `--framework` to run both targets.

You can also run the tests from Rider using its built-in test runner.

## Run integration tests

The integration tests make requests to the Adyen test environment. Before
running them, copy `Adyen.IntegrationTest/test-config.example.json` to the ignored
`Adyen.IntegrationTest/test-config.json` and complete every value. Alternatively,
provide the raw JSON through `ADYEN_API_LIBRARIES_INTEGRATION_TEST_CONFIG`.

Never commit API keys or other credentials to the repository.

From the repository root, run the integration tests:

```sh
dotnet test Adyen.IntegrationTest/Adyen.IntegrationTest.csproj --framework net10.0
```

Use `--framework net8.0` to test on .NET 8, or omit `--framework` to run
both targets. Integration CI runs both sequentially on Ubuntu using the same
shared configuration.

See [the integration-test README](Adyen.IntegrationTest/README.md) for configuration
fields, offline validation, and the GitHub workflow. Do not use an
unfiltered solution-level `dotnet test` for offline validation.