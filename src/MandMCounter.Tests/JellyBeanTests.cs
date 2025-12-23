using Microsoft.VisualStudio.TestTools.UnitTesting;
using MandMCounter.Core;
using System;

namespace MandMCounter.Tests
{
    [System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
    [TestClass]
    public class JellyBeanTests
    {
        [TestMethod]
        public void CountJellyBeansInAUSGallonTest()
        {
            //Arrange
            string unit = "Gallon";
            float quantity = 1f;

            //Act
            float result = Calculator.CountJellyBeans(unit, quantity);

            //Assert
            Assert.AreEqual(685.82, Math.Round(result, 2), 0.01);
        }

        [TestMethod]
        public void CountJellyBeansInAUSQuartTest()
        {
            //Arrange
            string unit = "Quart";
            float quantity = 1f;

            //Act
            float result = Calculator.CountJellyBeans(unit, quantity);

            //Assert
            Assert.AreEqual(171.46, Math.Round(result, 2), 0.01);
        }

        [TestMethod]
        public void CountJellyBeansInAUSCupTest()
        {
            //Arrange
            string unit = "Cup";
            float quantity = 1f;

            //Act
            float result = Calculator.CountJellyBeans(unit, quantity);

            //Assert
            Assert.AreEqual(42.86, Math.Round(result, 2), 0.01);
        }


        [TestMethod]
        public void CountJellyBeansInAUSQuarterCupTest()
        {
            //Arrange
            string unit = "Cup";
            float quantity = 0.25f;

            //Act
            
            float result = Calculator.CountJellyBeans(unit, quantity);

            //Assert
            Assert.AreEqual(10.72, Math.Round(result, 2), 0.01);
        }

        [TestMethod]
        public void CountJellyBeansInAUSTableSpoonTest()
        {
            //Arrange
            string unit = "Tablespoon";
            float quantity = 1;

            //Act
            
            float result = Calculator.CountJellyBeans(unit, quantity);

            //Assert
            Assert.AreEqual(2.68, Math.Round(result, 2), 0.01);
        }

        [TestMethod]
        public void CountJellyBeansInAUSTeaSpoonTest()
        {
            //Arrange
            string unit = "Teaspoon";
            float quantity = 1;

            //Act
            
            float result = Calculator.CountJellyBeans(unit, quantity);

            //Assert
            Assert.AreEqual(0.89, Math.Round(result, 2), 0.01);
        }

        [TestMethod]
        public void CountJellyBeansInANullUnitTest()
        {
            //Arrange
            string unit = null;
            float quantity = 1;

            //Act & Assert
            Assert.Throws<ArgumentNullException>(() => Calculator.CountJellyBeans(unit, quantity));
        }

        [TestMethod]
        public void CountJellyBeansInA1LitreTest()
        {
            //Arrange
            string unit = "Liter";
            float quantity = 1f;

            //Act
            
            float result = Calculator.CountJellyBeans(unit, quantity);

            //Assert
            Assert.AreEqual(181.17, Math.Round(result, 2), 0.01);
        }

        [TestMethod]
        public void CountJellyBeansInA1CubicCMTest()
        {
            //Arrange
            string unit = "cm";
            float height = 10;
            float width = 10;
            float length = 10;

            //Act
            
            float result = Calculator.CountJellyBeans(unit, height, width, length);

            //Assert
            Assert.AreEqual(181.17, Math.Round(result, 2), 0.01);
        }

        [TestMethod]
        public void CountJellyBeansInA1CubicInchTest()
        {
            //Arrange
            string unit = "inch";
            float height = 1;
            float width = 1;
            float length = 1;

            //Act
            
            float result = Calculator.CountJellyBeans(unit, height, width, length);

            //Assert
            Assert.AreEqual(2.97, Math.Round(result, 2), 0.01);
        }


        [TestMethod]
        public void CountJellyBeansInA1CubicNullUnitTest()
        {
            //Arrange
            string unit = null;
            float height = 1;
            float width = 1;
            float length = 1;

            //Act & Assert
            Assert.Throws<ArgumentNullException>(() => Calculator.CountJellyBeans(unit, height, width, length));
        }

        [TestMethod]
        public void CountJellyBeansInACylinderWithCMTest()
        {
            //Arrange
            string unit = "cm";
            float height = 10;
            float radius = 5;

            //Act
            
            float result = Calculator.CountJellyBeans(unit, height, radius);

            //Assert
            Assert.AreEqual(142.29, Math.Round(result, 2), 0.01);
        }

        [TestMethod]
        public void CountJellyBeansInACylinderWithInchTest()
        {
            //Arrange
            string unit = "inch";
            float height = 4;
            float radius = 2;

            //Act
            
            float result = Calculator.CountJellyBeans(unit, height, radius);

            //Assert
            Assert.AreEqual(149.23, Math.Round(result, 2), 0.01);
        }

        [TestMethod]
        public void CountJellyBeansInACylinderWithNullUnitTest()
        {
            //Arrange
            string unit = null;
            float height = 10;
            float radius = 5;

            //Act & Assert
            Assert.Throws<ArgumentNullException>(() => Calculator.CountJellyBeans(unit, height, radius));
        }

    }
}
