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
            Calculator calc = new Calculator();
            float result = calc.CountPeanutMandMs(unit, quantity);

            //Assert
            Assert.IsTrue(System.Math.Round(result, 0) == 2892f);
        }

        [TestMethod]
        public void CountPeanutMandMsInAUSQuartTest()
        {
            //Arrange
            string unit = "Quart";
            float quantity = 2f;

            //Act
            Calculator calc = new Calculator();
            float result = calc.CountPeanutMandMs(unit, quantity);

            //Assert
            Assert.IsTrue(System.Math.Round(result, 0) == 1446f);
        }

        [TestMethod]
        public void CountPeanutMandMsInAUSCupTest()
        {
            //Arrange
            string unit = "Cup";
            float quantity = 1f;

            //Act
            Calculator calc = new Calculator();
            float result = calc.CountPeanutMandMs(unit, quantity);

            //Assert
            Assert.IsTrue(System.Math.Round(result, 0) == 181f);
        }


        [TestMethod]
        public void CountPeanutMandMsInAUSQuarterCupTest()
        {
            //Arrange
            string unit = "Cup";
            float quantity = 0.25f;

            //Act
            Calculator calc = new Calculator();
            float result = calc.CountPeanutMandMs(unit, quantity);

            //Assert
            Assert.IsTrue(System.Math.Round(result, 0) == 45f);
        }

        [TestMethod]
        public void CountPeanutMandMsInAUSTableSpoonTest()
        {
            //Arrange
            string unit = "Tablespoon";
            float quantity = 1;

            //Act
            Calculator calc = new Calculator();
            float result = calc.CountPeanutMandMs(unit, quantity);

            //Assert
            Assert.IsTrue(System.Math.Round(result, 0) == 11f);
        }

        [TestMethod]
        public void CountPeanutMandMsInAUSTeaSpoonTest()
        {
            //Arrange
            string unit = "Teaspoon";
            float quantity = 1;

            //Act
            Calculator calc = new Calculator();
            float result = calc.CountPeanutMandMs(unit, quantity);

            //Assert
            Assert.IsTrue(System.Math.Round(result, 0) == 4f);
        }

        [TestMethod]
        public void CountPeanutMandMsInANullUnitTest()
        {
            try
            {
                //Arrange
                string unit = null;
                float quantity = 1;

                //Act
                Calculator calc = new Calculator();
                float result = calc.CountPeanutMandMs(unit, quantity);
            }
            catch (Exception ex)
            {
                //Assert
                Assert.IsTrue(ex != null);
            }
        }

        [TestMethod]
        public void CountPeanutMandMsInA1LitreTest()
        {
            //Arrange
            string unit = "Liter";
            float quantity = 1f; 

            //Act
            Calculator calc = new Calculator();
            float result = calc.CountPeanutMandMs(unit, quantity);

            //Assert
            Assert.IsTrue(System.Math.Round(result, 0) == 764f);
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
            Calculator calc = new Calculator();
            float result = calc.CountPeanutMandMs(unit, height, width, length);

            //Assert
            Assert.IsTrue(System.Math.Round(result, 0) == 764f);
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
            Calculator calc = new Calculator();
            float result = calc.CountPeanutMandMs(unit, height, width, length);

            //Assert
            Assert.IsTrue(System.Math.Round(result, 0) == 13f);
        }


        [TestMethod]
        public void CountPeanutMandMsInA1CubicNullUnitTest()
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
                float result = calc.CountPeanutMandMs(unit, height, width, length);
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
        public void CountPeanutMandMsInACylinderWithCMTest()
        {
            //Arrange
            string unit = "cm";
            float height = 10;
            float radius = 5;

            //Act
            Calculator calc = new Calculator();
            float result = calc.CountPeanutMandMs(unit, height, radius);

            //Assert
            Assert.IsTrue(System.Math.Round(result, 0) == 600f);
        }

        [TestMethod]
        public void CountPeanutMandMsInACylinderWithInchTest()
        {
            //Arrange
            string unit = "inch";
            float height = 4;
            float radius = 2;

            //Act
            Calculator calc = new Calculator();
            float result = calc.CountPeanutMandMs(unit, height, radius);

            //Assert
            Assert.IsTrue(System.Math.Round(result, 0) == 629f);
        }

        [TestMethod]
        public void CountPeanutMandMsInACylinderWithNullUnitTest()
        {
            try
            {
                //Arrange
                string unit = null;
                float height = 10;
                float radius = 5;

                //Act
                Calculator calc = new Calculator();
                float result = calc.CountPeanutMandMs(unit, height, radius);
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
