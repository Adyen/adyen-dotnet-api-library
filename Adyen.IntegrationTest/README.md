# Integration tests

Integration tests exercise the public .NET API library against the Adyen TEST environment.
They use MSTest and live in a separate project from the unit tests.

## Quick start

From the repository root:

```sh
cp Adyen.IntegrationTest/test-config.example.json Adyen.IntegrationTest/test-config.json

DOTNET_ROLL_FORWARD=Major dotnet test Adyen.IntegrationTest/Adyen.IntegrationTest.csproj \
  --logger trx --results-directory TestResults/integration
```

Complete every JSON value before running the tests. The local configuration is ignored by Git
and copied to the test output directory during the build.

`DOTNET_ROLL_FORWARD=Major` lets the .NET 8 tests run when only the .NET 10 runtime is installed,
as with Homebrew. It is unnecessary when the .NET 8 runtime is installed.

## Test projects

| Project | Purpose |
|---|---|
| `Adyen.Test` | Offline unit tests |
| `Adyen.IntegrationTest` | Automated tests that call Adyen, plus offline configuration-loader tests |

Builds do not execute tests. Keep routine unit-test execution scoped to its project:

```sh
dotnet build
DOTNET_ROLL_FORWARD=Major dotnet test Adyen.Test/Adyen.Test.csproj
```

An unfiltered `dotnet test` at the solution root also runs integration tests. Do not use it for
offline validation.

## Running automated integration tests

Run the entire integration-test project, including its offline configuration tests, using the
quick-start command above.

Run one class:

```sh
DOTNET_ROLL_FORWARD=Major dotnet test Adyen.IntegrationTest/Adyen.IntegrationTest.csproj \
  --filter 'FullyQualifiedName~LegalEntityManagementServiceIntegrationTest'
```

Run one method:

```sh
DOTNET_ROLL_FORWARD=Major dotnet test Adyen.IntegrationTest/Adyen.IntegrationTest.csproj \
  --filter 'FullyQualifiedName=Adyen.IntegrationTest.LegalEntityManagement.LegalEntityManagementServiceIntegrationTest.Given_LegalEntityService_When_CreateLegalEntity_Returns_OK'
```

Run multiple classes:

```sh
DOTNET_ROLL_FORWARD=Major dotnet test Adyen.IntegrationTest/Adyen.IntegrationTest.csproj \
  --filter 'FullyQualifiedName~PaymentsServiceIntegrationTest|FullyQualifiedName~ManagementServiceIntegrationTest'
```

## Configuration

`IntegrationTestConfiguration` reads one JSON document from these sources, in order:

1. The `ADYEN_API_LIBRARIES_INTEGRATION_TEST_CONFIG` environment variable containing raw JSON.
2. The ignored local file `Adyen.IntegrationTest/test-config.json`, when the variable is absent
   or blank.

Start with [`test-config.example.json`](test-config.example.json). Its schema matches the Java
integration-test configuration, so both libraries can use the same organizational secret.
The older individual credential and resource environment variables are not used by these tests.

Every field must be a non-blank JSON string. Configuration is validated once, before constructing
API clients. Missing or invalid fields fail the run and list field names only, never values.
Malformed environment JSON fails instead of falling back to the local file. Unknown fields are
ignored.

| Field | Used by |
|---|---|
| `company` | Company account, reserved for future tests |
| `merchantAccount` | Checkout and Management |
| `balancePlatform` | Balance Platform, reserved for future tests |
| `apiKey` | Checkout and Management |
| `lemApiKey` | Legal Entity Management |
| `bclApiKey` | Balance Platform |
| `givingCampaignId` | Giving campaigns, reserved for future tests |
| `legalEntityId` | Legal Entity Management and account-holder creation |
| `businessLineId` | Legal Entity Management, reserved for future tests |
| `documentId` | Legal Entity Management, reserved for future tests |
| `accountHolderId` | Balance Platform |
| `balanceAccountId` | Balance Platform, reserved for future tests |

The configured resources must exist in the TEST environment and be accessible to the matching
API credentials. The PSP credential also needs permission to list merchant users for Management
coverage. Use a dedicated test account holder: one test updates its description.

Never put credentials in command-line arguments, tracked files, or logs.
`BaseIntegrationTest` loads and validates the configuration once, before constructing API clients.
Derived tests use protected accessors such as `MerchantAccount`, `ApiKey`, `LemApiKey`, and
`BclApiKey`, without loading configuration themselves.

## Continuous integration

[`.github/workflows/integration-tests.yml`](../.github/workflows/integration-tests.yml) runs on
pushes to `main` and manual dispatch. Like the Java workflow, it does not run on pull requests.
It serializes runs without cancelling an active run and uses .NET 8 on Ubuntu. It executes the
integration-test project directly, without categories or test-name filters.

The job uses the `integration-tests` GitHub environment. Ensure that environment exists and its
protection rules allow the intended runs. Grant this repository access to the organizational
secret `ADYEN_API_LIBRARIES_INTEGRATION_TEST_CONFIG`, containing the raw JSON document:

```yaml
env:
  ADYEN_API_LIBRARIES_INTEGRATION_TEST_CONFIG: ${{ secrets.ADYEN_API_LIBRARIES_INTEGRATION_TEST_CONFIG }}
```

The workflow never writes the secret to disk. Missing configuration fails the job. On failure,
TRX reports are uploaded as `integration-test-results` and retained for seven days.

## Current coverage

| Test | Behavior |
|---|---|
| `PaymentsServiceIntegrationTest` | Card payments, idempotency behavior, service events, and HTTP-client configuration |
| `LegalEntityManagementServiceIntegrationTest` | Retrieves business lines and creates an individual legal entity |
| `AccountHoldersServiceIntegrationTest` | Creates, retrieves, and updates account holders; lists balance accounts and transaction rules; retrieves a tax-form summary |
| `ManagementServiceIntegrationTest` | Lists merchant users |
| `IntegrationTestConfigurationTests` | Validates configuration parsing and source precedence without external calls |

External execution creates payments, legal entities, and account holders, and updates the
configured account holder. Only run it when those TEST-environment operations are intentional.

## Validation without external calls

Compile without executing tests:

```sh
dotnet build Adyen.IntegrationTest/Adyen.IntegrationTest.csproj
```

Run the offline configuration tests without credentials:

```sh
DOTNET_ROLL_FORWARD=Major dotnet test Adyen.IntegrationTest/Adyen.IntegrationTest.csproj \
  --filter 'FullyQualifiedName~IntegrationTestConfigurationTests'
```

Do not run external tests during routine agent validation. TRX reports from the quick-start
command are written to `TestResults/integration/`.

## Project layout

```text
Adyen.IntegrationTest/
├── AGENTS.md
├── README.md
├── BaseIntegrationTest.cs
├── IntegrationTestConfiguration.cs
├── IntegrationTestConfigurationTests.cs
├── Adyen.IntegrationTest.csproj
├── <API area>/*IntegrationTest.cs
├── test-config.example.json
└── test-config.json             # ignored
```

Feature directories mirror API areas under `Adyen/`.

## Conventions for new tests

1. Use `[TestClass]`, name classes `*IntegrationTest` or `*IntegrationTests`, and name methods
   `Given_Condition_When_Action_Then_Result`.
2. Extend `BaseIntegrationTest` and use its protected configuration accessors instead of reading
   configuration or individual environment variables directly.
3. Always select `AdyenEnvironment.Test`.
4. Use the credential matching the API: `ApiKey`, `LemApiKey`, or `BclApiKey`.
5. Keep one observable behavior per test, using Arrange, Act, Assert sections where helpful.
6. Generate unique references and idempotency keys for requests creating remote state, except
   when explicitly testing behavior without idempotency.
7. Assert stable response fields and documented error codes, with useful assertion messages.
8. Keep tests independent and clean up remote resources when supported.
9. Use bounded polling and suitable timeouts rather than fixed sleeps or unbounded waits.

More specific agent instructions are in [`AGENTS.md`](AGENTS.md).

## Troubleshooting

- **No tests discovered:** check MSTest attributes, project path, and the
  `--filter` expression.
- **Missing configuration:** set the shared JSON environment variable or copy and complete the
  example file, then rebuild so the local file is copied to the test output.
- **Invalid configuration:** complete the listed fields with non-blank JSON strings.
- **HTTP 403 / error code `010`:** check API permissions and access to the merchant or resource.
- **Wrong credential:** use `LemApiKey` for Legal Entity Management and `BclApiKey` for Balance
  Platform, not the PSP `ApiKey`.
- **Missing .NET 8 runtime locally:** install it or use `DOTNET_ROLL_FORWARD=Major`.
