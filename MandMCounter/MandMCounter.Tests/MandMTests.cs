using Microsoft.VisualStudio.TestTools.UnitTesting;
using MandMCounter.Core;
using System;

namespace MandMCounter.Tests
{
    [System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
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

        [TestMethod]
        public void CountMandMsInANullUnitTest()
        {
            try
            {
                //Arrange
                string unit = null;
                float quantity = 1;

                //Act
                Calculator calc = new Calculator();
                float result = calc.CountMandMs(unit, quantity);
            }
            catch (Exception ex)
            {
                //Assert
                Assert.IsTrue(ex != null);
            }
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


        [TestMethod]
        public void CountMandMsInA1CubicNullUnitTest()
        {
            try
            {
                //Arrange
                string unit = null;
                float height = 1;
                float width = 1;
                float length = 1;

                //Act
                Calculator calc = new Calculator();
                float result = calc.CountMandMs(unit, height, width, length);
            }
            catch (Exception ex)
            {
                //Assert
                Assert.IsTrue(ex != null);
            }
        }

        #endregion

        #region " Testing volume in a cylinder" 

        [TestMethod]
        public void CountMandMsInACylinderWithCMTest()
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

        [TestMethod]
        public void CountMandMsInACylinderWithInchTest()
        {
            //Arrange
            string unit = "inch";
            float height = 4;
            float radius = 2;

            //Act
            Calculator calc = new Calculator();
            float result = calc.CountMandMs(unit, height, radius);

            //Assert
            Assert.IsTrue(System.Math.Round(result, 0) == 560f);
        }

        [TestMethod]
        public void CountMandMsInACylinderWithNullUnitTest()
        {
            try
            {
                //Arrange
                string unit = null;
                float height = 10;
                float radius = 5;

                //Act
                Calculator calc = new Calculator();
                float result = calc.CountMandMs(unit, height, radius);
            }
            catch (Exception ex)
            {
                //Assert
                Assert.IsTrue(ex != null);
            }
        }

        #endregion

    }
}
