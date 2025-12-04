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
            
            float result = Calculator.CountSkittles(unit, quantity);

            //Assert
            Assert.AreEqual(3393f, System.Math.Round(result, 0), 1f);
        }

        [TestMethod]
        public void CountSkittlesInAUSQuartTest()
        {
            //Arrange
            string unit = "Quart";
            float quantity = 1f;

            //Act
            
            float result = Calculator.CountSkittles(unit, quantity);

            //Assert
            Assert.AreEqual(848f, System.Math.Round(result, 0), 1f);
        }

        [TestMethod]
        public void CountSkittlesInAUSCupTest()
        {
            //Arrange
            string unit = "Cup";
            float quantity = 1f;

            //Act
            
            float result = Calculator.CountSkittles(unit, quantity);

            //Assert
            Assert.AreEqual(212f, System.Math.Round(result, 0), 1f);
        }


        [TestMethod]
        public void CountSkittlesInAUSQuarterCupTest()
        {
            //Arrange
            string unit = "Cup";
            float quantity = 0.25f;

            //Act
            
            float result = Calculator.CountSkittles(unit, quantity);

            //Assert
            Assert.AreEqual(53f, System.Math.Round(result, 0), 1f);
        }

        [TestMethod]
        public void CountSkittlesInAUSTableSpoonTest()
        {
            //Arrange
            string unit = "Tablespoon";
            float quantity = 1;

            //Act
            
            float result = Calculator.CountSkittles(unit, quantity);

            //Assert
            Assert.AreEqual(13f, System.Math.Round(result, 0), 1f);
        }

        [TestMethod]
        public void CountSkittlesInAUSTeaSpoonTest()
        {
            //Arrange
            string unit = "Teaspoon";
            float quantity = 1;

            //Act
            
            float result = Calculator.CountSkittles(unit, quantity);

            //Assert
            Assert.AreEqual(4f, System.Math.Round(result, 0), 1f);
        }

        [TestMethod]
        public void CountSkittlesInANullUnitTest()
        {
            //Arrange
            string unit = null;
            float quantity = 1;

            //Act & Assert
            Assert.Throws<Exception>(() => Calculator.CountSkittles(unit, quantity));
        }

        [TestMethod]
        public void CountSkittlesInA1LitreTest()
        {
            //Arrange
            string unit = "Liter";
            float quantity = 1f;

            //Act
            
            float result = Calculator.CountSkittles(unit, quantity);

            //Assert
            Assert.AreEqual(896f, System.Math.Round(result, 0), 1f);
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
            
            float result = Calculator.CountSkittles(unit, height, width, length);

            //Assert
            Assert.AreEqual(896f, System.Math.Round(result, 0), 1f);
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
            
            float result = Calculator.CountSkittles(unit, height, width, length);

            //Assert
            Assert.AreEqual(15f, System.Math.Round(result, 0), 1f);
        }


        [TestMethod]
        public void CountSkittlesInA1CubicNullUnitTest()
        {
            string unit = null;
            float height = 1;
            float width = 1;
            float length = 1;

            Assert.Throws<Exception>(() => Calculator.CountSkittles(unit, height, width, length));
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
            
            float result = Calculator.CountSkittles(unit, height, radius);

            //Assert
            Assert.AreEqual(704f, System.Math.Round(result, 0), 1f);
        }

        [TestMethod]
        public void CountSkittlesInACylinderWithInchTest()
        {
            //Arrange
            string unit = "inch";
            float height = 4;
            float radius = 2;

            //Act
            
            float result = Calculator.CountSkittles(unit, height, radius);

            //Assert
            Assert.AreEqual(738f, System.Math.Round(result, 0), 1f);
        }

        [TestMethod]
        public void CountSkittlesInACylinderWithNullUnitTest()
        {
            string unit = null;
            float height = 10;
            float radius = 5;

            Assert.Throws<Exception>(() => Calculator.CountSkittles(unit, height, radius));
        }

        #endregion

    }
}
