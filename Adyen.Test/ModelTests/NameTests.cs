using Adyen.Model.Checkout;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Adyen.Test.ModelTests
{
    [TestClass]
    public class NameTests
    {
        /// <summary>
        /// Since first name is mandatory, it should not be possible to create a name instance without it
        /// </summary>
        [TestMethod]
        public void CreatingNameWithoutFirstNameFails()
        {
            Assert.ThrowsException<InvalidDataException>(() => new Name(null, null));
        }
        
        /// <summary>
        /// Since last name is mandatory, it should not be possible to create a Name instance without it
        /// </summary>
        [TestMethod]
        public void CreatingNameWithoutLastNameFails()
        {
            Assert.ThrowsException<InvalidDataException>(() => new Name("firstName", null));
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
