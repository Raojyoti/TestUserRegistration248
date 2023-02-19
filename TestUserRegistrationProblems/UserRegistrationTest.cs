using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using UserRegistrationProblems;

namespace TestUserRegistrationProblems
{
    [TestClass]
    public class UserRegistrationTest
    {
        /// <summary>
        ///  UC1-First name starts with Capital and has minimum 3 characters
        ///  UC2-First name starts with Capital and has minimum 3 characters
        /// </summary>
        [TestMethod]
        [DataRow("^[A-Z]{1}[a-z]{2,}$","Rahul","Valid")]
        [DataRow("^[A-Z]{1}[a-z]{2,}$", "Sharma", "Valid")]
        public void CheckValidationForUserEnterenValue(string pattern, string input, string excepted)
        {
            //AAA
            //Arrange
            Pattern pat = new Pattern();
            //Act
            string actual = pat.ValidatePattern(input ,pattern);
            //Assert
            Assert.AreEqual(excepted, actual);
        }
    }
}
