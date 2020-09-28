using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SC.SimpleCalculator.Test.Unit
{
    [TestClass]
    public class InputConverterTest
    {
        private readonly InputConverter _inputConverter = new InputConverter();

        [TestMethod]
        public void ConvertValidStringToDoubleTest()
        {
            string input = "5";
            double convertedNumber = _inputConverter.ConvertInputToNumber(input);
            Assert.AreEqual(5, convertedNumber);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void FailsToConvertInvalidNumberTest()
        {
            string input = "S";
            double convertedNumber = _inputConverter.ConvertInputToNumber(input);
        }
    }
}
