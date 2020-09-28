using System;

namespace SC.SimpleCalculator
{
    public class InputConverter
    {

        /// <summary>
        /// Converts the string to double
        /// </summary>
        /// <param name="input">The string input</param>
        /// <returns>Double</returns>
        public double ConvertInputToNumber(string input)
        {
            double convertedNumber;
            if(!double.TryParse(input, out convertedNumber))
            {
                throw new ArgumentException("Expected a numeric value.");
            }
            return convertedNumber;
        }
    }
}