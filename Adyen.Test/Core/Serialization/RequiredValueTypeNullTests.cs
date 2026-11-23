using System.Reflection;
using System.Text.Json;
using System.Text.Json.Serialization;
using Adyen.Checkout.Models;
using Adyen.Test.Core.Serialization.Fixtures;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Adyen.Test.Core.Serialization
{
    [TestClass]
    public class RequiredValueTypeNullTests
    {
        public static IEnumerable<object[]> RequiredBooleanFields()
        {
            yield return new object[] { typeof(Adyen.AcsWebhooks.Models.AuthenticationInfo), "inPSD2Scope" };
            yield return new object[] { typeof(Adyen.BalancePlatform.Models.BalanceSweepConfigurationsResponse), "hasNext" };
            yield return new object[] { typeof(Adyen.BalancePlatform.Models.BalanceSweepConfigurationsResponse), "hasPrevious" };
            yield return new object[] { typeof(Adyen.BalancePlatform.Models.PaginatedAccountHoldersResponse), "hasNext" };
            yield return new object[] { typeof(Adyen.BalancePlatform.Models.PaginatedAccountHoldersResponse), "hasPrevious" };
            yield return new object[] { typeof(Adyen.BalancePlatform.Models.PaginatedBalanceAccountsResponse), "hasNext" };
            yield return new object[] { typeof(Adyen.BalancePlatform.Models.PaginatedBalanceAccountsResponse), "hasPrevious" };
            yield return new object[] { typeof(Adyen.BalancePlatform.Models.PaginatedGetCardOrderItemResponse), "hasNext" };
            yield return new object[] { typeof(Adyen.BalancePlatform.Models.PaginatedGetCardOrderItemResponse), "hasPrevious" };
            yield return new object[] { typeof(Adyen.BalancePlatform.Models.PaginatedGetCardOrderResponse), "hasNext" };
            yield return new object[] { typeof(Adyen.BalancePlatform.Models.PaginatedGetCardOrderResponse), "hasPrevious" };
            yield return new object[] { typeof(Adyen.BalancePlatform.Models.PaginatedPaymentInstrumentsResponse), "hasNext" };
            yield return new object[] { typeof(Adyen.BalancePlatform.Models.PaginatedPaymentInstrumentsResponse), "hasPrevious" };
            yield return new object[] { typeof(Adyen.Capital.Models.Action), "resolved" };
            yield return new object[] { typeof(Adyen.Checkout.Models.BrowserInfo), "javaEnabled" };
            yield return new object[] { typeof(Adyen.Disputes.Models.DefenseDocumentType), "available" };
            yield return new object[] { typeof(Adyen.Disputes.Models.DefenseReason), "satisfied" };
            yield return new object[] { typeof(Adyen.Disputes.Models.DisputeServiceResult), "success" };
            yield return new object[] { typeof(Adyen.LegalEntityManagement.Models.SourceOfFunds), "adyenProcessedFunds" };
            yield return new object[] { typeof(Adyen.Management.Models.ApiCredential), "active" };
            yield return new object[] { typeof(Adyen.Management.Models.CompanyApiCredential), "active" };
            yield return new object[] { typeof(Adyen.Management.Models.CreateApiCredentialResponse), "active" };
            yield return new object[] { typeof(Adyen.Management.Models.CreateCompanyApiCredentialResponse), "active" };
            yield return new object[] { typeof(Adyen.Management.Models.CreateCompanyWebhookRequest), "active" };
            yield return new object[] { typeof(Adyen.Management.Models.CreateMerchantWebhookRequest), "active" };
            yield return new object[] { typeof(Adyen.Management.Models.DinersInfo), "reuseMidNumber" };
            yield return new object[] { typeof(Adyen.Management.Models.MeApiCredential), "active" };
            yield return new object[] { typeof(Adyen.Management.Models.TerminalReassignmentTarget), "inventory" };
            yield return new object[] { typeof(Adyen.Management.Models.Webhook), "active" };
            yield return new object[] { typeof(Adyen.ManagementWebhooks.Models.AccountCapabilityData), "requested" };
            yield return new object[] { typeof(Adyen.Payment.Models.BrowserInfo), "javaEnabled" };
        }

        [TestMethod]
        [DynamicData(nameof(RequiredBooleanFields))]
        public void Given_RequiredBoolean_When_ExplicitlyNull_Then_ThrowsDescriptiveJsonException(Type modelType, string property)
        {
            string json = "{\"" + property + "\":null}";

            var exception = Assert.ThrowsExactly<JsonException>(() => JsonSerializer.Deserialize(json, modelType));

            StringAssert.Contains(exception.Message, $"Property '{property}' on '{modelType.Name}' cannot be null.");
        }

        [TestMethod]
        [DynamicData(nameof(RequiredBooleanFields))]
        public void Given_RequiredBoolean_When_TrueOrFalse_Then_AcceptsValue(Type modelType, string property)
        {
            var modelProperty = modelType.GetProperties().Single(candidate =>
                candidate.GetCustomAttribute<JsonPropertyNameAttribute>()?.Name == property);

            foreach (bool value in new[] { false, true })
            {
                string json = "{\"" + property + "\":" + (value ? "true" : "false") + "}";

                var model = JsonSerializer.Deserialize(json, modelType);

                Assert.IsNotNull(model);
                Assert.AreEqual(value, modelProperty.GetValue(model));
            }
        }

        [TestMethod]
        public void Given_OptionalBoolean_When_ExplicitlyNull_Then_AcceptsNull()
        {
            var browser = JsonSerializer.Deserialize<BrowserInfo>("{\"javaEnabled\":false,\"javaScriptEnabled\":null}");

            Assert.IsNotNull(browser);
            Assert.IsFalse(browser.JavaEnabled);
            Assert.IsNull(browser.JavaScriptEnabled);
        }

        [TestMethod]
        public void Given_RequiredUuid_When_ExplicitlyNull_Then_ThrowsDescriptiveJsonException()
        {
            var exception = Assert.ThrowsExactly<JsonException>(() =>
                JsonSerializer.Deserialize<NullabilityFixture>("{\"requiredUuid\":null}"));

            StringAssert.Contains(exception.Message, "Property 'requiredUuid' on 'NullabilityFixture' cannot be null.");
        }

        [TestMethod]
        public void Given_NullableValueTypes_When_ExplicitlyNull_Then_AcceptsNull()
        {
            string json = "{\"requiredUuid\":\"123e4567-e89b-12d3-a456-426614174000\"," +
                          "\"nullableUuid\":null,\"nullableBoolean\":null,\"optionalUuid\":null}";

            var fixture = JsonSerializer.Deserialize<NullabilityFixture>(json);

            Assert.IsNotNull(fixture);
            Assert.AreEqual(Guid.Parse("123e4567-e89b-12d3-a456-426614174000"), fixture.RequiredUuid);
            Assert.IsNull(fixture.NullableUuid);
            Assert.IsNull(fixture.NullableBoolean);
            Assert.IsNull(fixture.OptionalUuid);
        }

        [TestMethod]
        [DataRow(false)]
        [DataRow(true)]
        public void Given_NullableValueTypes_When_ValuesProvided_Then_PreservesValues(bool value)
        {
            const string uuid = "123e4567-e89b-12d3-a456-426614174000";
            string json = "{\"requiredUuid\":\"" + uuid + "\",\"nullableUuid\":\"" + uuid +
                          "\",\"optionalUuid\":\"" + uuid + "\",\"nullableBoolean\":" + (value ? "true" : "false") + "}";

            var fixture = JsonSerializer.Deserialize<NullabilityFixture>(json);

            Assert.IsNotNull(fixture);
            Assert.AreEqual(Guid.Parse(uuid), fixture.RequiredUuid);
            Assert.AreEqual(Guid.Parse(uuid), fixture.NullableUuid);
            Assert.AreEqual(Guid.Parse(uuid), fixture.OptionalUuid);
            Assert.AreEqual(value, fixture.NullableBoolean);
        }

        [TestMethod]
        public void Given_RequiredValueTypes_When_Missing_Then_PreservesDefaultBehavior()
        {
            var browser = JsonSerializer.Deserialize<BrowserInfo>("{}");
            var fixture = JsonSerializer.Deserialize<NullabilityFixture>("{}");

            Assert.IsNotNull(browser);
            Assert.IsFalse(browser.JavaEnabled);
            Assert.IsNotNull(fixture);
            Assert.AreEqual(Guid.Empty, fixture.RequiredUuid);
        }
    }
}
