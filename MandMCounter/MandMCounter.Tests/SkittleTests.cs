using Microsoft.VisualStudio.TestTools.UnitTesting;
using MandMCounter.Core;
using System;

namespace MandMCounter.Tests
{
    [System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
    [TestClass]
    public class SkittleTests
    {
        #region " Testing units"

        [TestMethod]
        public void CountSkittlesInAUSGallonTest()
        {
            //Arrange
            string unit = "Gallon";
            float quantity = 1f;

            //Act
            Calculator calc = new Calculator();
            float result = calc.CountSkittles(unit, quantity);

            //Assert
            Assert.IsTrue(System.Math.Round(result, 0) == 3393f);
        }

        [TestMethod]
        public void CountSkittlesInAUSQuartTest()
        {
            //Arrange
            string unit = "Quart";
            float quantity = 1f;

            //Act
            Calculator calc = new Calculator();
            float result = calc.CountSkittles(unit, quantity);

            //Assert
            Assert.IsTrue(System.Math.Round(result, 0) == 848f);
        }

        [TestMethod]
        public void CountSkittlesInAUSCupTest()
        {
            //Arrange
            string unit = "Cup";
            float quantity = 1f;

            //Act
            Calculator calc = new Calculator();
            float result = calc.CountSkittles(unit, quantity);

            //Assert
            Assert.IsTrue(System.Math.Round(result, 0) == 212f);
        }


        [TestMethod]
        public void CountSkittlesInAUSQuarterCupTest()
        {
            //Arrange
            string unit = "Cup";
            float quantity = 0.25f;

            //Act
            Calculator calc = new Calculator();
            float result = calc.CountSkittles(unit, quantity);

            //Assert
            Assert.IsTrue(System.Math.Round(result, 0) == 53f);
        }

        [TestMethod]
        public void CountSkittlesInAUSTableSpoonTest()
        {
            //Arrange
            string unit = "Tablespoon";
            float quantity = 1;

            //Act
            Calculator calc = new Calculator();
            float result = calc.CountSkittles(unit, quantity);

            //Assert
            Assert.IsTrue(System.Math.Round(result, 0) == 13f);
        }

        [TestMethod]
        public void CountSkittlesInAUSTeaSpoonTest()
        {
            //Arrange
            string unit = "Teaspoon";
            float quantity = 1;

            //Act
            Calculator calc = new Calculator();
            float result = calc.CountSkittles(unit, quantity);

            //Assert
            Assert.IsTrue(System.Math.Round(result, 0) == 4f);
        }

        [TestMethod]
        public void CountSkittlesInANullUnitTest()
        {
            try
            {
                //Arrange
                string unit = null;
                float quantity = 1;

                //Act
                Calculator calc = new Calculator();
                float result = calc.CountSkittles(unit, quantity);
            }
            catch (Exception ex)
            {
                //Assert
                Assert.IsTrue(ex != null);
            }
        }

        [TestMethod]
        public void CountSkittlesInA1LitreTest()
        {
            //Arrange
            string unit = "Liter";
            float quantity = 1f;

            //Act
            Calculator calc = new Calculator();
            float result = calc.CountSkittles(unit, quantity);

            //Assert
            Assert.IsTrue(System.Math.Round(result, 0) == 896f);
        }

        #endregion

        #region " Testing volume in a rectangle" 

        [TestMethod]
        public void CountSkittlesInA1CubicCMTest()
        {
            //Arrange
            string unit = "cm";
            float height = 10;
            float width = 10;
            float length = 10;

            //Act
            Calculator calc = new Calculator();
            float result = calc.CountSkittles(unit, height, width, length);

            //Assert
            Assert.IsTrue(System.Math.Round(result, 0) == 896f);
        }

        [TestMethod]
        public void CountSkittlesInA1CubicInchTest()
        {
            //Arrange
            string unit = "inch";
            float height = 1;
            float width = 1;
            float length = 1;

            //Act
            Calculator calc = new Calculator();
            float result = calc.CountSkittles(unit, height, width, length);

            //Assert
            Assert.IsTrue(System.Math.Round(result, 0) == 15f);
        }


        [TestMethod]
        public void CountSkittlesInA1CubicNullUnitTest()
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
                float result = calc.CountSkittles(unit, height, width, length);
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
        public void CountSkittlesInACylinderWithCMTest()
        {
            //Arrange
            string unit = "cm";
            float height = 10;
            float radius = 5;

            //Act
            Calculator calc = new Calculator();
            float result = calc.CountSkittles(unit, height, radius);

            //Assert
            Assert.IsTrue(System.Math.Round(result, 0) == 704f);
        }

        [TestMethod]
        public void CountSkittlesInACylinderWithInchTest()
        {
            //Arrange
            string unit = "inch";
            float height = 4;
            float radius = 2;

            //Act
            Calculator calc = new Calculator();
            float result = calc.CountSkittles(unit, height, radius);

            //Assert
            Assert.IsTrue(System.Math.Round(result, 0) == 738f);
        }

        [TestMethod]
        public void CountSkittlesInACylinderWithNullUnitTest()
        {
            try
            {
                //Arrange
                string unit = null;
                float height = 10;
                float radius = 5;

                //Act
                Calculator calc = new Calculator();
                float result = calc.CountSkittles(unit, height, radius);
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
