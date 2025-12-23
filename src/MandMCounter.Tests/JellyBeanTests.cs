using Microsoft.VisualStudio.TestTools.UnitTesting;
using MandMCounter.Core;
using System;

namespace MandMCounter.Tests
{
    [System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
    [TestClass]
    public class JellyBeanTests
    {
        #region " Testing units"

        [TestMethod]
        public void CountJellyBeansInAUSGallonTest()
        {
            //Arrange
            string unit = "Gallon";
            float quantity = 1f;

            //Act
            float result = Calculator.CountJellyBeans(unit, quantity);

            //Assert
            Assert.AreEqual(8556f, System.Math.Round(result, 0), 1f);
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
            Assert.AreEqual(2139f, System.Math.Round(result, 0), 1f);
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
            Assert.AreEqual(535f, System.Math.Round(result, 0), 1f);
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
            Assert.AreEqual(134f, System.Math.Round(result, 0), 1f);
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
            Assert.AreEqual(33f, System.Math.Round(result, 0), 1f);
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
            Assert.AreEqual(11f, System.Math.Round(result, 0), 1f);
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
            Assert.AreEqual(2260f, System.Math.Round(result, 0), 1f);
        }

        #endregion

        #region " Testing volume in a rectangle" 

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
            Assert.AreEqual(2260f, System.Math.Round(result, 0), 1f);
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
            Assert.AreEqual(37f, System.Math.Round(result, 0), 1f);
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

        #endregion

        #region " Testing volume in a cylinder" 

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
            Assert.AreEqual(1777f, System.Math.Round(result, 0), 1f);
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
            Assert.AreEqual(1862f, System.Math.Round(result, 0), 1f);
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

        #endregion

    }
}
