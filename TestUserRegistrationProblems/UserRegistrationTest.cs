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
        ///  UC3-Email has 3 mandatory parts (abc, bl & co) and 2 optional(xyz & in) with precise @ and.positions
        ///  UC4-Country code follow by space and 10 digit number.
        ///  UC5-Password Rule1– minimum 8 Characters.
        ///  UC6-Password Rule2– Should have at least 1 Upper Case.
        ///  UC7-Password Rule3– Should  have at least 1 numeric number.
        ///  UC9-Sample Emails to Test
        /// </summary>
        [TestMethod]
        [DataRow("^[A-Z]{1}[a-z]{2,}$", "Rahul", "Valid")]
        [DataRow("^[A-Z]{1}[a-z]{2,}$", "Sharma", "Valid")]
        [DataRow(@"^([abc]+)(\.[a-z0-9_\+\-]+)?@([bl]+)\.([co]{2,4})(\.[a-z]{2,})?$", "abc.xyz@bl.co.in", "Valid")]
        [DataRow("^[1-9]{2}?([ ])[0-9]{10}$", "91 9919819801", "Valid")]
        [DataRow("^[a-zA-Z0-9]{8,}$", "jyoti1ra", "Valid")]
        [DataRow("^(?=.*[A-Z])[A-Za-z0-9]{8,}$", "Ritesh1ra", "Valid")]
        [DataRow("^(?=.*[A-Z])(?=.*[0-9])[a-zA-Z0-9]{8,}$", "Piyush1ra", "Valid")]
        [DataRow("^(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9])(?=.*?[#?!@$%^&*-]).{8,}$", "P*iyush1ra", "Valid")]//Piyush1ra=false
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
