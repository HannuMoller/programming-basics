using System;

namespace exam
{

    /// <summary>
    /// Class Number: contains static methods for checking number properties
    /// </summary>
    public class Number
    {

        public enum Sign
        {
            NEGATIVE,
            ZERO,
            POSITIVE
        };

        public Number()
        {
        }

        /// <summary>
        /// check if number is either negative, positive or zero
        /// </summary>
        /// <param name="number"> number to be inspected </param>
        /// <returns> Number.NEGATIVE | Number.ZERO | Number.POSITIVE </returns>
        public static Sign Check(int number)
        {
            if (number < 0)
            {
                return Sign.NEGATIVE;
            }
            else if (number > 0)
            {
                return Sign.POSITIVE;
            }
            else
            {
                return Sign.ZERO;
            }
        }

        /// <summary>
        /// check if number is even
        /// </summary>
        /// <param name="number"> number to be inspected </param>
        /// <returns> true, if number is even </returns>
        public static bool IsEven(int number)
        {
            return (number % 2 == 0);
        }
    }
}