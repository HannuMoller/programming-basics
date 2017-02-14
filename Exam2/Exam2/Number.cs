using System;

namespace exam
{

    /// <summary>
    /// Class Number contains static methods for checking numer properties
    /// </summary>
    public class Number
    {

        public const int NEGATIVE = -1;
        public const int ZERO = 0;
        public const int POSITIVE = 1;

        public Number()
        {
        }

        /// <summary>
        /// check if number is either negative, positive or zero
        /// </summary>
        /// <param name="number"> number to be inspected </param>
        /// <returns> Negative | Zero | Positive </returns>
        public static int check(int number)
        {
            if (number < 0)
            {
                return NEGATIVE;
            }
            else if (number > 0)
            {
                return POSITIVE;
            }
            else
            {
                return ZERO;
            }
        }

        /// <summary>
        /// Check if number is even
        /// </summary>
        /// <param name="number"> number to be inspected </param>
        /// <returns> true, if number is even </returns>
        public static bool isEven(int number)
        {
            return (number % 2 == 0);
        }
    }
}