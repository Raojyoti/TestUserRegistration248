using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UserRegistrationProblems
{
    public class Pattern
    {
        //UC1-First name starts with Cap and has minimum 3 characters
        public static string pattern ;

        /// <summary>
        /// This method used to check Validation
        /// </summary>
        public string ValidatePattern(string inputs, string pattern)
        {
            if (Regex.IsMatch(inputs, pattern))
            {
                Console.WriteLine("{0}    => valid", inputs);
                return "Valid";
            }
            else
            {
                Console.WriteLine("{0}    => Invalid", inputs);
                return "Invalid";
            }
        }
    }
}
