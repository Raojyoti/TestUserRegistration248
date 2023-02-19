using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserRegistrationProblems
{
    public class Program
    {
        static void Main(string[] args)
        {
            bool check = true;
            while (check)
            {
                Console.Clear();
                Console.WriteLine("Please choose any options");
                Console.WriteLine("1.Check Validation for First Name\n" +
                    "2.Check Validation for Last Name\n" +
                    "3.Check validation for Email Id\n" +
                    "4.Check validation for Mobile Number\n" +
                    "10.Exit\n");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        Console.Clear();
                        string code = Pattern.pattern= "^[A-Z]{1}[a-z]{2,}$";
                        Console.WriteLine("Enter first name want to check for validation:");
                        string name = Console.ReadLine();
                        Console.WriteLine("\nList of valid and Invalid FirstName:\n-------------------------------------");
                        Pattern pattern = new Pattern();
                        pattern.ValidatePattern(name, code);
                        Console.Write("\nPress any key to continue...... ");
                        Console.ReadLine();
                        break;
                    case 2:
                        Console.Clear();
                        string code1 = Pattern.pattern = "^[A-Z]{1}[a-z]{2,}$";
                        Console.WriteLine("Enter last name want to check for validation:");
                        string lastName = Console.ReadLine();
                        Console.WriteLine("\nList of valid and Invalid LastName:\n-------------------------------------");
                        Pattern pattern1 = new Pattern();
                        pattern1.ValidatePattern(lastName, code1);
                        Console.Write("\nPress any key to continue...... ");
                        Console.ReadLine();
                        break;
                   case 3:
                        Console.Clear();
                        string code2 = Pattern.pattern = @"^([abc]+)(\.[a-z0-9_\+\-]+)?@([bl]+)\.([co]{2,4})(\.[a-z]{2,})?$";//abc.xyz@bl.co.in;
                        Console.WriteLine("Enter emailid want to check for validation:");
                        string emailId = Console.ReadLine();
                        Console.WriteLine("\nList of valid and Invalid emailId:\n-------------------------------------");
                        Pattern pattern2 = new Pattern();
                        pattern2.ValidatePattern(emailId, code2);
                        Console.Write("\nPress any key to continue...... ");
                        Console.ReadLine();
                        break;
                    case 3:
                        Console.Clear();
                        string code3 = Pattern.pattern = "^[1-9]{2}?([ ])[0-9]{10}$";//91 7805982520
                        Console.WriteLine("Enter mobile Number want to check for validation:");
                        string mobileNumber = Console.ReadLine();
                        Console.WriteLine("\nList of valid and Invalid mobileNumber:\n-------------------------------------");
                        Pattern pattern3 = new Pattern();
                        pattern3.ValidatePattern(mobileNumber, code3);
                        Console.Write("\nPress any key to continue...... ");
                        Console.ReadLine();
                        break;
                    case 10:
                        Console.Clear();
                        Console.ReadLine();
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Select only valid options");
                        Console.ReadLine();
                        break;
                }
            }
        }
    }
}
