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
                        Console.WriteLine("\nList of valid and Invalid LastName:\n-------------------------------------");
                        Pattern pattern2 = new Pattern();
                        pattern2.ValidatePattern(emailId, code2);
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
