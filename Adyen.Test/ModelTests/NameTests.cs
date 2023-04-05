using System;
using Adyen.Model.Checkout;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Adyen.Test.ModelTests
{
    [TestClass]
    public class NameTests
    {
        /// <summary>
        /// Since first name is mandatory, it should not be possible to create a name instance without it
        /// </summary>
        [Ignore]
        [TestMethod]
        public void CreatingNameWithoutFirstNameFails()
        {
            Assert.ThrowsException<ArgumentNullException>(() => new Name());
        }
        
        /// <summary>
        /// Since last name is mandatory, it should not be possible to create a Name instance without it
        /// </summary>
        [Ignore]
        [TestMethod]
        public void CreatingNameWithoutLastNameFails()
        {
            Assert.ThrowsException<ArgumentNullException>(() => new Name("firstName"));
        }
        
        /// <summary>
        /// Since last name is mandatory, it should not be possible to create a Name instance without it
        /// </summary>
        [TestMethod]
        public void CreatingNameWithoutInfixSucceeds()
        {
            var name = new Name("firstName",  "lastName");
            Assert.AreEqual(name.FirstName, "firstName");
            Assert.AreEqual(name.LastName, "lastName");
        }
    }
}
