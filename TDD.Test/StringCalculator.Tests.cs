using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDD.Test
{
    [TestClass]
    public class StringCalculatorTest
    {
        private StringCalculator _calculator;

        [TestInitialize]
        public void Init()
        {
            _calculator = new StringCalculator();
        }

        [TestMethod]
        public void StringCalculator_EmptyString_ReturnZero()
        {
            // Arrange
            var str = "";

            // Act
            int result = _calculator.Sum(str);

            // Assert
            Assert.AreEqual(result, 0);
        }

        [TestMethod]
        public void StringCalculator_OneNumber_ReturnNumber()
        {
            //Arrange
            var str = "12";

            //Act 
            int result = _calculator.Sum(str);

            //Assert
            Assert.AreEqual(result, 12);            
        }

        [TestMethod]
        public void StringCalculator_InvalidNumber_ReturnZero()
        {
            //Arrange
            var str = "*";

            //Act 
            int result = _calculator.Sum(str);

            //Assert
            Assert.AreEqual(result, 0);
        }

        [TestMethod]
        public void StringCalculator_MoreThanOneNumber_ReturnSumOfThem()
        {
            //Arrange
            var str = "12,,45";

            //Act 
            int result = _calculator.Sum(str);

            //Assert
            Assert.AreEqual(result, 57);
        }

        // 1212,ijigf,13,132        ijigf =0
        // 11,,1,1
        // -3, 3, 7 -> 10
    }
}
