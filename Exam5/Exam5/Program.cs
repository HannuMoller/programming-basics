using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam5
{
    /// <summary>
    /// Exam 5: Read customer data and evaluate ticket price
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter customer data...");

            Console.Write("Enter name : ");
            string name = Console.ReadLine();
            Customer customer = new Customer(name);

            int age = -1;
            while (age < 0)
            {
                Console.Write("Enter age : ");
                if (!int.TryParse(Console.ReadLine(), out age)) 
                {
                    Console.WriteLine("Invalid age!");
                    age = -1;
                }
                else {
                    customer.setAge(age);
                }
            }

            customer.setMTKmember(YesNo("Is customer a member of MTK"));
            customer.setConscript(YesNo("Is customer a conscript"));
            customer.setStudent(YesNo("Is customer a student"));

            Console.WriteLine("Price for {0} is {1:F2}", name, customer.getPrice());
            Console.ReadKey();
        }

        /// <summary>
        /// Accepts only Y or N as answer (ok, lowercase also accepted ;)
        /// </summary>
        /// <param name="prompt"> the question </param>
        /// <returns> true, if Y | false, if N </returns>
        private static bool YesNo(string prompt)
        {
            while (true)
            {
                Console.Write("{0} (Y/N) : ", prompt);
                char c = char.ToUpper(Console.ReadKey().KeyChar);
                Console.WriteLine();
                if (c == 'Y')
                {
                    return true;
                }
                if (c == 'N')
                {
                    return false;
                }
                Console.WriteLine("Please answer Y or N!");
            }
        }
    }
}
