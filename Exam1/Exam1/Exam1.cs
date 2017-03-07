using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using exam;

namespace Exam1
{
    /// <summary>
    /// Exam 1: read number and evaluate if it is either positive, negative or zero.
    /// </summary>
    class Exam1
    {
        static void Main(string[] args)
        {

            Console.Write("Enter number : ");
            string snum = Console.ReadLine();
            try
            {
                int number = int.Parse(snum);
                switch (Number.Check(number))
                {
                    case Number.Sign.NEGATIVE:
                        Console.WriteLine("{0} is negative", number);
                        break;
                    case Number.Sign.POSITIVE:
                        Console.WriteLine("{0} is positive", number);
                        break;
                    case Number.Sign.ZERO:
                        Console.WriteLine("{0} is zero", number);
                        break;
                    default:
                        Console.WriteLine("{0} is not a number?", number);
                        break;
                }
            } catch (Exception ex)
            {
                Console.WriteLine("{0} is not number!", snum);
            }
            Console.ReadKey();
        }
    }
}
