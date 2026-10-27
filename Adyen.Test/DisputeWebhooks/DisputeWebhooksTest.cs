using Microsoft.VisualStudio.TestTools.UnitTesting;
using TypeEnum = Adyen.DisputeWebhooks.Models.DisputeEventNotification.TypeEnum;

namespace Adyen.Test.DisputeWebhooks
{
    [TestClass]
    public class DisputeWebhooksTest
    {
        [TestMethod]
        public void Given_DisputeType_When_FromStringOrDefault_Then_ReturnsExpectedInstance()
        {
            Assert.IsNull(TypeEnum.FromStringOrDefault("some_future_dispute_type"));

            Assert.AreSame(TypeEnum.Fraud, TypeEnum.FromStringOrDefault("fraud"));
            Assert.AreSame(TypeEnum.NotDelivered, TypeEnum.FromStringOrDefault("notDelivered"));
            Assert.AreSame(TypeEnum.Duplicate, TypeEnum.FromStringOrDefault("duplicate"));
            Assert.AreSame(TypeEnum.NotAsDescribed, TypeEnum.FromStringOrDefault("notAsDescribed"));
            Assert.AreSame(TypeEnum.Cancelled, TypeEnum.FromStringOrDefault("cancelled"));
            Assert.AreSame(TypeEnum.Other, TypeEnum.FromStringOrDefault("other"));

            Assert.AreEqual("notAsDescribed", TypeEnum.ToJsonValue(TypeEnum.NotAsDescribed));
            Assert.AreEqual("cancelled", TypeEnum.ToJsonValue(TypeEnum.Cancelled));
        }
    }
}
