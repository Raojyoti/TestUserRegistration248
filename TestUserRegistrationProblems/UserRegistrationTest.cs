using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using UserRegistrationProblems;

namespace TestUserRegistrationProblems
{
    [TestClass]
    public class UserRegistrationTest
    {
        [TestMethod]
        public void CheckValidationForFirstName()
        {
            //AAA
            //Arrange
            string pattern = "^[A-Z]{1}[a-z]{2,}$";
            string input = "Rahul";
            string excepted = "Valid";
            Pattern pat = new Pattern();
            //Act
            string actual = pat.ValidatePattern(input ,pattern);
            //Assert
            Assert.AreEqual(excepted, actual);
        }
    }
}
