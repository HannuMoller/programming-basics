using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using exam;

namespace Exam1
{
    class Exam1
    {
        static void Main(string[] args)
        {

            Console.Write("Enter number : ");
            string snum = Console.ReadLine();
            try
            {
                int number = int.Parse(snum);
                switch (Number.check(number))
                {
                    case Number.NEGATIVE:
                        Console.WriteLine("{0} is negative", number);
                        break;
                    case Number.POSITIVE:
                        Console.WriteLine("{0} is positive", number);
                        break;
                    default:
                        Console.WriteLine("{0} is zero", number);
                        break;
                }
            } catch (Exception ex)
            {
                Console.WriteLine("{0} was not number!", snum);
            }
            Console.ReadKey();
        }
    }
}
