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
            if (IsPalindrome(pal))
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
        static Boolean IsPalindrome(string s)
        {
            var cc = RemoveExtra(s).ToCharArray();

            int i = 0;
            int j = cc.Length - 1;
            while (j > i)
            {
                if (cc[i] != cc[j])
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
        static string RemoveExtra(string s)
        {
            var s2 = new StringBuilder();
            var cc = s.ToCharArray();
            int i = 0;
            while (i < cc.Length)
            {
                if (char.IsLetter(cc[i]))
                {
                    s2.Append(char.ToUpper(cc[i]));
                }
                i++;
            }

            return s2.ToString();
        }
    }
}
