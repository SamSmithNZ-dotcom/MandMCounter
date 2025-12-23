using Microsoft.VisualStudio.TestTools.UnitTesting;
using MandMCounter.Core;
using System;

namespace MandMCounter.Tests
{
    [System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
    [TestClass]
    public class SkittleTests
    {
        [TestMethod]
        public void CountSkittlesInAUSGallonTest()
        {
            //Arrange
            string unit = "Gallon";
            float quantity = 1f;

            //Act
            float result = Calculator.CountSkittles(unit, quantity);

            //Assert
            Assert.AreEqual(3393.21, Math.Round(result, 2), 0.01);
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
            Assert.AreEqual(848.3, Math.Round(result, 2), 0.01);
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
            Assert.AreEqual(212.09, Math.Round(result, 2), 0.01);
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
            Assert.AreEqual(53.02, Math.Round(result, 2), 0.01);
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
            Assert.AreEqual(13.25, Math.Round(result, 2), 0.01);
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
            Assert.AreEqual(4.42, Math.Round(result, 2), 0.01);
        }

        [TestMethod]
        public void CountSkittlesInANullUnitTest()
        {
            //Arrange
            string unit = null;
            float quantity = 1;

            //Act & Assert
            Assert.Throws<ArgumentNullException>(() => Calculator.CountSkittles(unit, quantity));
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
            Assert.AreEqual(896.39, Math.Round(result, 2), 0.01);
        }

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
            Assert.AreEqual(896.39, Math.Round(result, 2), 0.01);
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
            Assert.AreEqual(14.69, Math.Round(result, 2), 0.01);
        }


        [TestMethod]
        public void CountSkittlesInA1CubicNullUnitTest()
        {
            //Arrange
            string unit = null;
            float height = 1;
            float width = 1;
            float length = 1;

            //Act

            //Assert
            Assert.Throws<ArgumentNullException>(() => Calculator.CountSkittles(unit, height, width, length));
        }

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
            Assert.AreEqual(704.02, Math.Round(result, 2), 0.01);
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
            Assert.AreEqual(738.36, Math.Round(result, 2), 0.01);
        }

        [TestMethod]
        public void CountSkittlesInACylinderWithNullUnitTest()
        {
            //Arrange
            string unit = null;
            float height = 10;
            float radius = 5;

            //Act & Assert
            Assert.Throws<ArgumentNullException>(() => Calculator.CountSkittles(unit, height, radius));
        }

    }
}
