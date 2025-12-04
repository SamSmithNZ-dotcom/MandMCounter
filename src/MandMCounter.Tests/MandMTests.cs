using Microsoft.VisualStudio.TestTools.UnitTesting;
using MandMCounter.Core;
using System;

namespace MandMCounter.Tests
{
    [System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
    [TestClass]
    public class MandMTests
    {
        #region " Testing units"

        [TestMethod]
        public void CountMandMsInAUSGallonTest()
        {
            //Arrange
            string unit = "Gallon";
            float quantity = 1f;

            //Act
            float result = Calculator.CountMandMs(unit, quantity);

            //Assert
            Assert.AreEqual(4047f, (float)System.Math.Round(result, 0), 0.1f);
        }

        [TestMethod]
        public void CountMandMsInAUSQuartTest()
        {
            //Arrange
            string unit = "Quart";
            float quantity = 1f;

            //Act
            float result = Calculator.CountMandMs(unit, quantity);

            //Assert
            Assert.AreEqual(1012f, (float)System.Math.Round(result, 0), 0.1f);
        }

        [TestMethod]
        public void CountMandMsInAUSOunceTest()
        {
            //Arrange
            string unit = "Ounce";
            float quantity = 1f;

            //Act           
            float result = Calculator.CountMandMs(unit, quantity);

            //Assert
            Assert.AreEqual(32f, (float)System.Math.Round(result, 0), 0.1f);
        }

        [TestMethod]
        public void CountMandMsIn21PoundsTest()
        {
            //Arrange
            string unit = "Pound";
            float quantity = 21f;

            //Act           
            float result = Calculator.CountMandMs(unit, quantity);

            //Assert
            Assert.AreEqual(339973f, (float)System.Math.Round(result, 0), 0.1f);
        }


        [TestMethod]
        public void CountMandMsInAUSCupTest()
        {
            //Arrange
            string unit = "Cup";
            float quantity = 1f;

            //Act
            float result = Calculator.CountMandMs(unit, quantity);

            //Assert
            Assert.AreEqual(253f, (float)System.Math.Round(result, 0), 0.1f);
        }


        [TestMethod]
        public void CountMandMsInAUSQuarterCupTest()
        {
            //Arrange
            string unit = "Cup";
            float quantity = 0.25f;

            //Act
            float result = Calculator.CountMandMs(unit, quantity);

            //Assert
            Assert.AreEqual(63f, (float)System.Math.Round(result, 0), 0.1f);
        }

        [TestMethod]
        public void CountMandMsInAUSTableSpoonTest()
        {
            //Arrange
            string unit = "Tablespoon";
            float quantity = 1;

            //Act
            float result = Calculator.CountMandMs(unit, quantity);

            //Assert
            Assert.AreEqual(16f, (float)System.Math.Round(result, 0), 0.1f);
        }

        [TestMethod]
        public void CountMandMsInAUSTeaSpoonTest()
        {
            //Arrange
            string unit = "Teaspoon";
            float quantity = 1;

            //Act
            float result = Calculator.CountMandMs(unit, quantity);

            //Assert
            Assert.IsTrue(System.Math.Round(result, 0) == 5f);
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
                Calculator.CountMandMs(unit, quantity);
            }
            catch (Exception ex)
            {
                //Assert
                Assert.IsTrue(ex != null);
            }
        }

        [TestMethod]
        public void CountMandMsInA1LitreTest()
        {
            //Arrange
            string unit = "Liter";
            float quantity = 1f;

            //Act
            float result = Calculator.CountMandMs(unit, quantity);

            //Assert
            Assert.IsTrue(System.Math.Round(result, 0) == 1069f);
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
            float result = Calculator.CountMandMs(unit, height, width, length);

            //Assert
            Assert.IsTrue(System.Math.Round(result, 0) == 1069f);
        }

        [TestMethod]
        public void CountMandMsInA1CubicMTest()
        {
            //Arrange
            string unit = "m";
            float height = 1;
            float width = 1;
            float length = 1;

            //Act
            float result = Calculator.CountMandMs(unit, height, width, length);

            //Assert
            Assert.IsTrue(System.Math.Round(result, 0) == 1069f);
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
            float result = Calculator.CountMandMs(unit, height, width, length);

            //Assert
            Assert.IsTrue(System.Math.Round(result, 0) == 18f);
        }

        [TestMethod]
        public void CountMandMsInA1CubicFeetTest()
        {
            //Arrange
            string unit = "feet";
            float height = 1;
            float width = 1;
            float length = 1;

            //Act
            float result = Calculator.CountMandMs(unit, height, width, length);

            //Assert
            Assert.IsTrue(System.Math.Round(result, 0) == 30276f);
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
                float result = Calculator.CountMandMs(unit, height, width, length);
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
            float result = Calculator.CountMandMs(unit, height, radius);

            //Assert
            Assert.IsTrue(System.Math.Round(result, 0) == 840f);
        }

        [TestMethod]
        public void CountMandMsInACylinderWithMTest()
        {
            //Arrange
            string unit = "m";
            float height = 1;
            float radius = 1;

            //Act
            float result = Calculator.CountMandMs(unit, height, radius);

            //Assert
            Assert.IsTrue(System.Math.Round(result, 0) == 3359f);
        }

        [TestMethod]
        public void CountMandMsInACylinderWithMeterTest()
        {
            //Arrange
            string unit = "meter";
            float height = 1;
            float radius = 1;

            //Act
            float result = Calculator.CountMandMs(unit, height, radius);

            //Assert
            Assert.IsTrue(System.Math.Round(result, 0) == 3359f);
        }

        [TestMethod]
        public void CountMandMsInACylinderWithInchTest()
        {
            //Arrange
            string unit = "inch";
            float height = 4;
            float radius = 2;

            //Act
            float result = Calculator.CountMandMs(unit, height, radius);

            //Assert
            Assert.IsTrue(System.Math.Round(result, 0) == 881f);
        }

        [TestMethod]
        public void CountMandMsInACylinderWithFeetTest()
        {
            //Arrange
            string unit = "feet";
            float height = 1;
            float radius = 1;

            //Act
            float result = Calculator.CountMandMs(unit, height, radius);

            //Assert
            Assert.IsTrue(System.Math.Round(result, 0) == 95115f);
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
                float result = Calculator.CountMandMs(unit, height, radius);
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
