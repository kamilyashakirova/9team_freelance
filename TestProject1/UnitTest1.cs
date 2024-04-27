using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace freelance.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CheckLocalisated()
        {
            string key = "hello";
            var result = "Bonjour";
            var res = ForUnitTests.CheckLocalization(key);
            Assert.AreEqual(result, res);
        }
        [TestMethod]
        public void TestMailMessage()
        {
            // Arrange
            string validEmailAddress = "test@example.com";
            string invalidEmailAddress = "invalid_email";
            string message = "lhkdjhhfj";

            // Act
            ForUnitTests.CheckSendEmail(validEmailAddress, message);
            ForUnitTests.CheckSendEmail(invalidEmailAddress, message);
        }
    }
}