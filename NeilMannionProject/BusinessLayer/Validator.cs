using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class Validator
    {

        /// <summary>
        /// Checking to make sure the input is an integer
        /// </summary>
        /// <param name="input"></param>
        /// <returns>This should return a true value</returns>
        public static bool IsInteger(string input)
        {
            return int.TryParse(input, out _);
        }

        /// <summary>
        /// Checking to make sure the input has something in it
        /// </summary>
        /// <param name="input"></param>
        /// <returns>This should return a true value</returns>
        public static bool IsPresent(string input)
        {
            return !string.IsNullOrWhiteSpace(input);
        }

        /// <summary>
        /// Checking to make sure the input is within the ranges of 0 and 100
        /// </summary>
        /// <param name="value"></param>
        /// <returns>This should return a true</returns>
        public static bool IsWithinRange(int value)
        {
            int min = 0;
            int max = 100;

            return value >= min && value <= max;
        }
    }
}
