using System.ComponentModel.DataAnnotations;
using BusinessLayer;

namespace UnitTesting
{
    [TestClass]
    public class UnitTest1
    {

        
        [TestMethod]
        public void IsInteger_SUCCESS()
        {
            string validInteger = "123";
            bool result = BusinessLayer.Validator.IsInteger(validInteger);
            Assert.IsTrue(result);
        }
        
        [TestMethod]
        public void IsInteger_FAILURE()
        {
            string nonInteger = "abc";
            bool result = BusinessLayer.Validator.IsInteger(nonInteger);
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void IsPresent_SUCCESS()
        {
            string nonEmptyString = "Hello";
            bool result = BusinessLayer.Validator.IsPresent(nonEmptyString);
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void IsPresent_FAILURE()
        {
            string emptyString = "";
            bool result = BusinessLayer.Validator.IsPresent(emptyString);
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void IsWithinRange_SUCCESS()
        {
            int goodInt = 50;
            bool result = BusinessLayer.Validator.IsWithinRange(goodInt);
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void IsWithinRange_FAILURE()
        {
            int goodInt = 101;
            bool result = BusinessLayer.Validator.IsWithinRange(goodInt);
            Assert.IsFalse(result);
        }
    }
}