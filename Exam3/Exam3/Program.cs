using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using exam;

namespace Exam3
{
    /// <summary>
    /// Exam 3: read number and evaluate if it is:
    ///         - either positive, negative or zero
    ///         - either odd or even
    /// </summary>
    class Exam3
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
                        Console.Write("{0} is negative", number);
                        break;
                    case Number.Sign.POSITIVE:
                        Console.Write("{0} is positive", number);
                        break;
                    case Number.Sign.ZERO:
                        Console.Write("{0} is zero", number);
                        break;
                    default:
                        Console.Write("{0} is not a number?", number);
                        break;
                }

                if (Number.IsEven(number))
                {
                    Console.WriteLine(" and even");
                }
                else
                {
                    Console.WriteLine(" and odd");
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
