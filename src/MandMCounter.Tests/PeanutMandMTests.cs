using Microsoft.VisualStudio.TestTools.UnitTesting;
using MandMCounter.Core;
using System;

namespace MandMCounter.Tests
{
    [System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
    [TestClass]
    public class PeanutMandMTests
    {
        #region " Testing units"

        [TestMethod]
        public void CountPeanutMandMsInAUSGallonTest()
        {
            //Arrange
            string unit = "Gallon";
            float quantity = 1f;

            //Act
            
            float result = Calculator.CountPeanutMandMs(unit, quantity);

            //Assert
            Assert.AreEqual(2892, (int)System.Math.Round(result, 0));
        }

        [TestMethod]
        public void CountPeanutMandMsInAUSQuartTest()
        {
            //Arrange
            string unit = "Quart";
            float quantity = 2f;

            //Act
            
            float result = Calculator.CountPeanutMandMs(unit, quantity);

            //Assert
            Assert.AreEqual(1446, (int)System.Math.Round(result, 0));
        }

        [TestMethod]
        public void CountPeanutMandMsInAUSCupTest()
        {
            //Arrange
            string unit = "Cup";
            float quantity = 1f;

            //Act
            
            float result = Calculator.CountPeanutMandMs(unit, quantity);

            //Assert
            Assert.AreEqual(181, (int)System.Math.Round(result, 0));
        }


        [TestMethod]
        public void CountPeanutMandMsInAUSQuarterCupTest()
        {
            //Arrange
            string unit = "Cup";
            float quantity = 0.25f;

            //Act
            
            float result = Calculator.CountPeanutMandMs(unit, quantity);

            //Assert
            Assert.AreEqual(45, (int)Math.Round(result, 0));
        }

        [TestMethod]
        public void CountPeanutMandMsInAUSTableSpoonTest()
        {
            //Arrange
            string unit = "Tablespoon";
            float quantity = 1;

            //Act
            
            float result = Calculator.CountPeanutMandMs(unit, quantity);

            //Assert
            Assert.AreEqual(11, (int)Math.Round(result, 0));
        }

        [TestMethod]
        public void CountPeanutMandMsInAUSTeaSpoonTest()
        {
            //Arrange
            string unit = "Teaspoon";
            float quantity = 1;

            //Act
            
            float result = Calculator.CountPeanutMandMs(unit, quantity);

            //Assert
            Assert.AreEqual(4, (int)Math.Round(result, 0));
        }

        [TestMethod]
        public void CountPeanutMandMsInANullUnitTest()
        {
            //Arrange
            string unit = null;
            float quantity = 1;

            //Act & Assert
            Assert.Throws<Exception>(() => Calculator.CountPeanutMandMs(unit, quantity));
        }

        [TestMethod]
        public void CountPeanutMandMsInA1LitreTest()
        {
            //Arrange
            string unit = "Liter";
            float quantity = 1f; 

            //Act
            
            float result = Calculator.CountPeanutMandMs(unit, quantity);

            //Assert
            Assert.AreEqual(764, (int)Math.Round(result, 0));
        }

        #endregion

        #region " Testing volume in a rectangle" 

        [TestMethod]
        public void CountPeanutMandMsInA1CubicCMTest()
        {
            //Arrange
            string unit = "cm";
            float height = 10;
            float width = 10;
            float length = 10;

            //Act
            
            float result = Calculator.CountPeanutMandMs(unit, height, width, length);

            //Assert
            Assert.AreEqual(764, (int)Math.Round(result, 0));
        }

        [TestMethod]
        public void CountPeanutMandMsInA1CubicInchTest()
        {
            //Arrange
            string unit = "inch";
            float height = 1;
            float width = 1;
            float length = 1;

            //Act
            
            float result = Calculator.CountPeanutMandMs(unit, height, width, length);

            //Assert
            Assert.AreEqual(13, (int)Math.Round(result, 0));
        }


        [TestMethod]
        public void CountPeanutMandMsInA1CubicNullUnitTest()
        {
            //Arrange
            string unit = null;
            float height = 1;
            float width = 1;
            float length = 1;

            //Act & Assert
            Assert.Throws<Exception>(() =>
            {
                Calculator.CountPeanutMandMs(unit, height, width, length);
            });
        }

        #endregion

        #region " Testing volume in a cylinder" 

        [TestMethod]
        public void CountPeanutMandMsInACylinderWithCMTest()
        {
            //Arrange
            string unit = "cm";
            float height = 10;
            float radius = 5;

            //Act
            
            float result = Calculator.CountPeanutMandMs(unit, height, radius);

            //Assert
            Assert.AreEqual(600, (int)Math.Round(result, 0));
        }

        [TestMethod]
        public void CountPeanutMandMsInACylinderWithInchTest()
        {
            //Arrange
            string unit = "inch";
            float height = 4;
            float radius = 2;

            //Act
            
            float result = Calculator.CountPeanutMandMs(unit, height, radius);

            //Assert
            Assert.AreEqual(629, (int)Math.Round(result, 0));
        }

        [TestMethod]
        public void CountPeanutMandMsInACylinderWithNullUnitTest()
        {
            //Arrange
            string unit = null;
            float height = 10;
            float radius = 5;

            //Act & Assert
            Assert.Throws<Exception>(() =>
            {
                Calculator.CountPeanutMandMs(unit, height, radius);
            });
        }

        #endregion

    }
}
