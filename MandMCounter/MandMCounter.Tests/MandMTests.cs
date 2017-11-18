using Microsoft.VisualStudio.TestTools.UnitTesting;
using MandMCounter.Core;

namespace MandMCounter.Tests
{
    [TestClass]
    public class MandMTests
    {

        [TestMethod]
        public void NumberOfMandMsInAUSCupTest()
        {
            //Arrange
            string unit = "Cup";
            float quantity = 1f;

            //Act
            Calculator calc = new Calculator();
            float result = calc.CalculateMandMs(unit, quantity);

            //Assert
            Assert.IsTrue(System.Math.Round(result, 0) == 161f);
        }


        [TestMethod]
        public void NumberOfMandMsInAUSQuarterCupTest()
        {
            //Arrange
            string unit = "Cup";
            float quantity = 0.25f;

            //Act
            Calculator calc = new Calculator();
            float result = calc.CalculateMandMs(unit, quantity);

            //Assert
            Assert.IsTrue(System.Math.Round(result, 0) == 40f);
        }

        [TestMethod]
        public void NumberOfMandMsInAUSTableSpoonTest()
        {
            //Arrange
            string unit = "Tablespoon";
            float quantity = 1;

            //Act
            Calculator calc = new Calculator();
            float result = calc.CalculateMandMs(unit, quantity);

            //Assert
            Assert.IsTrue(System.Math.Round(result, 0) == 10f);
        }

        [TestMethod]
        public void NumberOfMandMsInAUSTeaSpoonTest()
        {
            //Arrange
            string unit = "Teaspoon";
            float quantity = 1;

            //Act
            Calculator calc = new Calculator();
            float result = calc.CalculateMandMs(unit, quantity);

            //Assert
            Assert.IsTrue(System.Math.Round(result, 0) == 3f);
        }



        [TestMethod]
        public void NumberOfMandMsInA1CubicCMTest()
        {
            //Arrange
            string unit = "cm";
            float height = 1;
            float width = 1;
            float length = 1;

            //Act
            Calculator calc = new Calculator();
            float result = calc.CalculateMandMs(unit, height, width, length);

            //Assert
            Assert.IsTrue(System.Math.Round(result, 0) == 1f);
        }

        [TestMethod]
        public void NumberOfMandMsInA1CubicInchTest()
        {
            //Arrange
            string unit = "inch";
            float height = 1;
            float width = 1;
            float length = 1;

            //Act
            Calculator calc = new Calculator();
            float result = calc.CalculateMandMs(unit, height, width, length);

            //Assert
            Assert.IsTrue(System.Math.Round(result, 0) == 11f);
        }


    }
}
