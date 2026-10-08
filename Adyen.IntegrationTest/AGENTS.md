<integration_test_guidelines>
## Scope

These instructions apply to files under `Adyen.IntegrationTest`.

## Before Writing a Test

- Read `Adyen.IntegrationTest/README.md`.
- Verify the public service method and model types in the matching API area under `Adyen/`.
- Never edit generated production code to make an integration test pass. Follow the repository's
  template and generation instructions for production changes.
- Only add tests suitable for unattended execution to the continuous integration suite.

## Structure

- Mirror the production API area under `Adyen.IntegrationTest`.
- Use MSTest `[TestClass]` and `[TestMethod]` attributes. Name classes `*IntegrationTest` or
  `*IntegrationTests` and methods `Given_Condition_When_Action_Then_Result`.
- Extend `BaseIntegrationTest`, which loads the shared configuration once, and use its protected
  typed accessors.
- Build dependency-injection hosts with the appropriate `Configure...` extension.
- Use `ApiKey` for Checkout/Management, `LemApiKey` for Legal Entity
  Management, and `BclApiKey` for Balance Platform.
- Keep one observable behavior per test, with Arrange, Act, Assert sections where useful.
- Match surrounding C# conventions and prefer explicit response types.

## Reliability and Safety

- Use unique references and idempotency keys for requests creating remote state, except for tests
  specifically covering behavior without idempotency.
- Do not share mutable state or depend on execution order.
- Clean up remotely created resources when the API supports cleanup.
- Use bounded polling for eventually consistent APIs and suitable request timeouts.
- Always configure clients for `AdyenEnvironment.Test`. Do not introduce LIVE credentials or
  behavior.
- Keep offline execution scoped to the unit-test project or the configuration-test class.
- Never execute an external test unless the user explicitly requests those API calls.
- Never log credentials or configuration values.

## Configuration

- `IntegrationTestConfiguration` loads the shared JSON document from
  `ADYEN_API_LIBRARIES_INTEGRATION_TEST_CONFIG`, or from the ignored local
  `Adyen.IntegrationTest/test-config.json` when the environment variable is absent or blank.
- Never read configuration or individual environment variables directly in API tests.
- To add a setting, update `test-config.example.json`, the typed configuration loader, its offline
  tests, and the README field table together.
- Every documented field must be a non-blank JSON string. Failures report names only, never values.
- Keep secrets in the environment variable or the ignored local JSON file, never tracked files.

## Assertions and Comments

- Assert stable contract fields, identifiers, statuses, and documented error codes.
- Assert exact error wording only when it is part of the documented contract.
- Include assertion messages that explain the violated contract.
- Extract repeated request construction and assertions into focused helpers.
- Limit comments to prerequisites, non-obvious API constraints, and Arrange, Act, Assert markers.

## Validation

Compile without contacting Adyen:

```sh
dotnet build Adyen.IntegrationTest/Adyen.IntegrationTest.csproj
```

The configuration tests are offline and safe to execute:

```sh
DOTNET_ROLL_FORWARD=Major dotnet test Adyen.IntegrationTest/Adyen.IntegrationTest.csproj \
  --filter 'FullyQualifiedName~IntegrationTestConfigurationTests'
```

Run unit tests through `Adyen.Test/Adyen.Test.csproj`. An unfiltered solution-level `dotnet test`
also executes external tests, so never use it for routine validation.

Use the external execution commands from the README only when API calls are explicitly requested.
</integration_test_guidelines>
