using System;

namespace SC.SimpleCalculator
{
    public class CalculatorEngine
    {
        public const string OperationAdd = "add";
        public const string OperationSubtract = "subtract";
        public const string OperationDivide = "divide";
        public const string OperationMultiply = "multiply";

        /// <summary>
        /// Calculate the two numbers depending upon the operation
        /// </summary>
        /// <param name="operation">The operation: +, add, -, subtract, /, divide, *, multiply</param>
        /// <param name="firstNumber">The first number</param>
        /// <param name="secondNumber">The second number</param>
        /// <returns>doouble</returns>
        public double Calculate(string operation, double firstNumber, double secondNumber)
        {
            double result;

            switch (operation.ToLower())
            {
                case "+":
                case OperationAdd:
                    result = firstNumber + secondNumber;
                    break;
                case "-":
                case OperationSubtract:
                    result = firstNumber - secondNumber;
                    break;
                case "/":
                case OperationDivide:
                    result = firstNumber / secondNumber;
                    break;
                case "*":
                case OperationMultiply:
                    result = firstNumber * secondNumber;
                    break;
                default:
                    throw new InvalidOperationException("Invalid operation specified!");
            }
            return result;
        }
    }
}