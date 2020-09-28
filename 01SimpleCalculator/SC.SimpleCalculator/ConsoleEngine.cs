using System;

namespace SC.SimpleCalculator
{
    /// <summary>
    /// The condole engine
    /// </summary>
    public class ConsoleEngine
    {
        public const ConsoleColor ColorYellow = ConsoleColor.Yellow;
        public const ConsoleColor ColorRed = ConsoleColor.Red;
        public const ConsoleColor ColorGreen = ConsoleColor.Green;
        public const ConsoleColor ColorBlue = ConsoleColor.Blue;
        public const ConsoleColor ColorWhite = ConsoleColor.White;
        public const ConsoleColor ColorCyan = ConsoleColor.Cyan;


        /// <summary>
        /// To display the message in the console with writeLine
        /// </summary>
        /// <param name="message">The message</param>
        /// <param name="color">The message color</param>
        /// <param name="isChangeToWhite">Change the color back to default white</param>
        public void writeLine(string message, ConsoleColor? color = null, bool isChangeToWhite = false)
        {
            changeForgroundColor(color);

            if (!string.IsNullOrWhiteSpace(message))
                Console.WriteLine(message);

            if (isChangeToWhite)
                changeForgroundColor(ColorWhite);
        }

        /// <summary>
        /// To display the message in the console with write
        /// </summary>
        /// <param name="message">The message</param>
        /// <param name="color">The message color</param>
        /// <param name="isChangeToWhite">Change the color back to default white</param>
        public void write(string message, ConsoleColor? color, bool isChangeToWhite = false)
        {
            changeForgroundColor(color);

            if (!string.IsNullOrWhiteSpace(message))
                Console.Write(message);

            if (isChangeToWhite)
                changeForgroundColor(ColorWhite);
        }

        /// <summary>
        /// Change forground color
        /// </summary>
        /// <param name="color">The color</param>
        public void changeForgroundColor(ConsoleColor? color)
        {
            if (color != null)
                Console.ForegroundColor = color.GetValueOrDefault();
        }


        /// <summary>
        /// To read the input from the console
        /// </summary>
        /// <param name="message">The message to display with the read</param>
        /// <param name="isUserWriteLineForMessage">To user WriteLine or Write for the read</param>
        /// <param name="color">The color of the message text</param>
        /// <param name="isChangeToWhite">Change the color back to default white</param>
        /// <returns>The read string</returns>
        public string Read(string message, bool isUserWriteLineForMessage = true, ConsoleColor? color = ColorWhite, bool isChangeToWhite = false)
        {
            if (!string.IsNullOrWhiteSpace(message))
            {
                if (isUserWriteLineForMessage)
                {
                    writeLine(message, color, isChangeToWhite);
                }
                else
                {
                    write(message, color, isChangeToWhite);
                }
            }

            var input = Console.ReadLine();
            return input;
        }

    }
}