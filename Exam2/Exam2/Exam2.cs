using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using exam;

namespace Exam2
{
    /// <summary>
    /// Exam 2: read number and evaluate if it is either odd or even. 
    /// </summary>
    class Exam2
    {
        static void Main(string[] args)
        {

            Console.Write("Enter number : ");
            string snum = Console.ReadLine();
            try
            {
                int number = int.Parse(snum);
                if (Number.isEven(number))
                {
                    Console.WriteLine("{0} is even", number);
                }
                else
                {
                    Console.WriteLine("{0} is odd", number);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("{0} was not number!", snum);
            }
            Console.ReadKey();
        }
    }
}
