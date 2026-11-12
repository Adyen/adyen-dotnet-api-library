# Nullability converter fixture

The production API models currently have required booleans but no UUID properties. This generated test-only model exercises the UUID converter branch, required nullable boolean/UUID properties, and an optional UUID. It is compiled into the test assembly only. Its generated `Option<T>` support type is local to the fixture namespace because the production type's `IsSet` member is internal to the SDK assembly.

Regenerate from a local `adyen-sdk-automation` checkout with `dotnet/repo` linked to this library, using the same C# options as `dotnet/build.gradle.kts`:

```sh
java -jar /path/to/openapi-generator-cli-7.16.0.jar generate -g csharp -i dotnet/repo/Adyen.Test/Core/Serialization/Fixtures/NullabilityFixture.openapi.json -t dotnet/repo/templates-v7/csharp/libraries/generichost -o dotnet/build/nullability-fixture --api-package Checkout.Services --model-package Test.Core.Serialization.Fixtures --additional-properties targetFramework=net8.0,library=generichost,packageName=Adyen,corePackageName=Core,apiName=Checkout,serviceName=Checkout,caseInsensitiveResponseHeaders=false,equatable=false,nullableReferenceTypes=true,useDateTimeOffset=true,useOneOfDiscriminatorLookup=true --global-property models=NullabilityFixture,modelDocs=false,modelTests=false
```

Copy `dotnet/build/nullability-fixture/src/Adyen/Test.Core.Serialization.Fixtures/NullabilityFixture.cs` into this directory and trim generated trailing whitespace. Do not edit the converter logic by hand.

Generate the fixture-local support type from the same templates:

```sh
java -jar /path/to/openapi-generator-cli-7.16.0.jar generate -g csharp -i dotnet/repo/Adyen.Test/Core/Serialization/Fixtures/NullabilityFixture.openapi.json -t dotnet/repo/templates-v7/csharp/libraries/generichost -o dotnet/build/nullability-option --additional-properties library=generichost,packageName=Adyen,clientPackage=Test.Core.Serialization.Fixtures,nullableReferenceTypes=true --global-property supportingFiles=Option.cs
```

Copy the generated `Option.cs` from `dotnet/build/nullability-option/src/Adyen/Test.Core.Serialization.Fixtures/` into this directory.
