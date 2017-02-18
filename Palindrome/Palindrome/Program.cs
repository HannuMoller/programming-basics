using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrome
{
    /// <summary>
    /// read string, check if it is a palindrome
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Palindrome checker v1.0");
            Console.Write("Enter string : ");
            String pal = Console.ReadLine();
            if (isPalindrome(pal))
            {
                Console.WriteLine("- is a palindrome!");
            }
            else
            {
                Console.WriteLine("- is not a palindrome!");
            }
            Console.ReadKey();
        }

        /// <summary>
        /// inspect if given string is a palindrome
        /// </summary>
        /// <param name="s"> string to be inspected </param>
        /// <returns> true, if given string is a palindrome </returns>
        static Boolean isPalindrome(string s)
        {
            s = removeExtra(s);

            int i = 0;
            int j = s.Length - 1;
            while (j > i)
            {
                if (s.ElementAt(i) != s.ElementAt(j))
                {
                    return false;
                }
                i++;
                j--;
            }

            return true;
        }

        /// <summary>
        /// remove extra characters, leaving only letters
        /// and letters will be uppercased
        /// </summary>
        /// <param name="s"> original string </param>
        /// <returns> cleaned up version of string </returns>
        static string removeExtra(string s)
        {
            string s2 = "";
            int i = 0;
            while (i < s.Length)
            {
                char c = s.ElementAt(i);
                if (char.IsLetter(c))
                {
                    s2 += char.ToUpper(c);
                }
                i++;
            }

            return s2;
        }
    }
}
