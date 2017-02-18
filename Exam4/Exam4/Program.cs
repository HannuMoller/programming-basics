using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam4
{
    /// <summary>
    /// Exam 4: Read 3 numbers and output them in ascending order
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            const int COUNT = 3;
            var numbers = new int[COUNT];

            Console.WriteLine("You need to enter {0} numbers...", COUNT);

            int i = 0;
            string snum = null;
            while (i < COUNT)
            {
                try
                {
                    Console.Write("Enter #{0} number : ", i+1);
                    snum = Console.ReadLine();
                    int num = int.Parse(snum);
                    numbers[i] = num;
                    i++;

                } catch (Exception ex)
                {
                    Console.WriteLine("{0} is not a number!", snum);
                }
            }

            sort(numbers);

            Console.Write("Numbers in ascending order: {0}", numbers[0]);
            i = 1;
            while (i < COUNT)
            {
                Console.Write(", {0}", numbers[i]);
                i++;
            }
            Console.WriteLine();
            Console.ReadKey();

        }

        /// <summary>
        /// sort numeric array in ascending order
        /// </summary>
        /// <param name="numbers"> array containing numbers </param>
        /// <returns> sorted array </returns>
        private static int[] sort(int[] numbers)
        {
            int count = numbers.Count();

            int i = 0;
            while (i < count)
            {
                int n1 = numbers[i];
                int j = i + 1;
                while (j < count)
                {
                    int n2 = numbers[j];
                    if (n2 < n1)
                    {
                        // swap numbers
                        numbers[i] = n2;
                        numbers[j] = n1;
                        n1 = n2;
                    }
                    j++;
                }
                i++;
            }
            return numbers;
        }
    }
}
