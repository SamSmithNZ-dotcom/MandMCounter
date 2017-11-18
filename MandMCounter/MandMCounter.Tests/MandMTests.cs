using Microsoft.VisualStudio.TestTools.UnitTesting;
using MandMCounter.Core;

namespace MandMCounter.Tests
{
    [TestClass]
    public class MandMTests
    {
        #region "Testing units"

        [TestMethod]
        public void CountMandMsInAUSGallonTest()
        {
            //Arrange
            string unit = "Gallon";
            float quantity = 1f;

            //Act
            Calculator calc = new Calculator();
            float result = calc.CountMandMs(unit, quantity);

            //Assert
            Assert.IsTrue(System.Math.Round(result, 0) == 2574f);
        }

        [TestMethod]
        public void CountMandMsInAUSQuartTest()
        {
            //Arrange
            string unit = "Quart";
            float quantity = 1f;

            //Act
            Calculator calc = new Calculator();
            float result = calc.CountMandMs(unit, quantity);

            //Assert
            Assert.IsTrue(System.Math.Round(result, 0) == 644f);
        }

        [TestMethod]
        public void CountMandMsInAUSCupTest()
        {
            //Arrange
            string unit = "Cup";
            float quantity = 1f;

            //Act
            Calculator calc = new Calculator();
            float result = calc.CountMandMs(unit, quantity);

            //Assert
            Assert.IsTrue(System.Math.Round(result, 0) == 161f);
        }


        [TestMethod]
        public void CountMandMsInAUSQuarterCupTest()
        {
            //Arrange
            string unit = "Cup";
            float quantity = 0.25f;

            //Act
            Calculator calc = new Calculator();
            float result = calc.CountMandMs(unit, quantity);

            //Assert
            Assert.IsTrue(System.Math.Round(result, 0) == 40f);
        }

        [TestMethod]
        public void CountMandMsInAUSTableSpoonTest()
        {
            //Arrange
            string unit = "Tablespoon";
            float quantity = 1;

            //Act
            Calculator calc = new Calculator();
            float result = calc.CountMandMs(unit, quantity);

            //Assert
            Assert.IsTrue(System.Math.Round(result, 0) == 10f);
        }

        [TestMethod]
        public void CountMandMsInAUSTeaSpoonTest()
        {
            //Arrange
            string unit = "Teaspoon";
            float quantity = 1;

            //Act
            Calculator calc = new Calculator();
            float result = calc.CountMandMs(unit, quantity);

            //Assert
            Assert.IsTrue(System.Math.Round(result, 0) == 3f);
        }

        #endregion

        #region " Testing volume in a rectangle" 

        [TestMethod]
        public void CountMandMsInA1CubicCMTest()
        {
            //Arrange
            string unit = "cm";
            float height = 10;
            float width = 10;
            float length = 10;

            //Act
            Calculator calc = new Calculator();
            float result = calc.CountMandMs(unit, height, width, length);

            //Assert
            Assert.IsTrue(System.Math.Round(result, 0) == 680f);
        }

        [TestMethod]
        public void CountMandMsInA1CubicInchTest()
        {
            //Arrange
            string unit = "inch";
            float height = 1;
            float width = 1;
            float length = 1;

            //Act
            Calculator calc = new Calculator();
            float result = calc.CountMandMs(unit, height, width, length);

            //Assert
            Assert.IsTrue(System.Math.Round(result, 0) == 11f);
        }

        #endregion

        #region " Testing volume in a cylinder" 

        [TestMethod]
        public void CountMandMsInACylinderTest()
        {
            //Arrange
            string unit = "cm";
            float height = 10;
            float radius = 5;

            //Act
            Calculator calc = new Calculator();
            float result = calc.CountMandMs(unit, height, radius);

            //Assert
            Assert.IsTrue(System.Math.Round(result, 0) == 534f);
        }

        #endregion

    }
}
