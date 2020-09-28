using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SC.SimpleCalculator
{
    class Program
    {
        

        #region Commented Code

        /*
        //Use of $ and providing formats
        static void Main(string[] args)
        {
            writeLine("Starting Program", null);
            writeLine("Checking Permissions", null);
            writeLine("Permissions are correct", ConsoleColor.Cyan);
            writeLine("Pinging Server", ConsoleColor.White);
            writeLine("Warning:Pinging response is over 1 second", ConsoleColor.Yellow);
            writeLine("Checking database", ConsoleColor.White);
            writeLine("Error: Database not reachable", ConsoleColor.Red);
            double percentage = 0.40;
            writeLine($"Percentage = {percentage:0.0%}", ConsoleColor.Green);
            int sin = 526193526; //some SIN number, display as 526-193-526
            writeLine($"Some SIN = {sin:000-000-000}", ConsoleColor.Blue);
            long phone = 9051234560;
            writeLine($"Phone = {phone:(000) 000-0000}", ConsoleColor.Green);
            double cur = 45610.05;
            writeLine($"Currency = {cur:c}", ConsoleColor.Blue);
            writeLine($"Currency = {cur:n3}", ConsoleColor.Green);
            writeLine(string.Empty, ConsoleColor.White);

            Console.ReadKey();
        }
        */

        /*
        //Converting input which is string to int
        static void Main(string[] args)
        {
            write("Enter a number: ", ColorYellow);
            string input = Console.ReadLine();

            //if the input is string then the converted value will be 0
            int converted;
            int.TryParse(input, out converted);

            writeLine($"Converted to number as {converted}", ColorGreen);

            Console.ReadKey();
        }
        */

        /*
        static void Main(string[] args)
        {
            int result1 = 20 / 5 * 2;
            int result2 = 20 * 7 / 3;

            writeLine($"result1: {result1}, result2: {result2}");

            Console.ReadKey();
        }
        */

        /*
        //Null conditional operator ?.
        static void Main(string[] args)
        {
            double SumNumbers(List<double[]> setsOfNumbers, int indexOfSetToSum)
            {
                return setsOfNumbers?[indexOfSetToSum]?.Sum() ?? double.NaN;
            }

            var sum = SumNumbers(null, 0);
            writeLine(sum.ToString(), ColorRed);  // output: NaN

            Console.ReadKey();
        }
        */

        #endregion

        static void Main(string[] args)
        {
            ConsoleEngine consoleEngine = new ConsoleEngine();
            
            try
            {
                InputConverter inputConverter = new InputConverter();
                CalculatorEngine calculatorEngine = new CalculatorEngine();

                //get the first number from console and convert to number
                var readNumber1 = consoleEngine.Read("Input first Number: ", false, ConsoleEngine.ColorGreen, true);
                double firstNumber = inputConverter.ConvertInputToNumber(readNumber1);

                //get the second number from console and convert to number
                var readNumber2 = consoleEngine.Read("Input second Number: ", false, ConsoleEngine.ColorCyan, true);
                double secondNumber = inputConverter.ConvertInputToNumber(readNumber2);

                //get the operation
                var operation = consoleEngine.Read("Input operator [+, add, -, subtract, /, divide, *, multiply]: ", false, ConsoleEngine.ColorYellow, true);

                //calculate
                double result = calculatorEngine.Calculate(operation, firstNumber, secondNumber);

                //print
                if (double.IsInfinity(result))
                {
                    consoleEngine.writeLine("Operation result is infinity!", ConsoleEngine.ColorRed);
                }
                else
                {
                    consoleEngine.writeLine($"CalculatedNumber: {result}", ConsoleEngine.ColorBlue);
                }
                
            }
            catch(Exception ex)
            {
                consoleEngine.writeLine(ex.Message, ConsoleEngine.ColorRed);
            }
            
            Console.ReadKey();
        }

        
    }
}
