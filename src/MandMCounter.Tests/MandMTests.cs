using Microsoft.VisualStudio.TestTools.UnitTesting;
using MandMCounter.Core;
using System;

namespace MandMCounter.Tests
{
    [System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
    [TestClass]
    public class MandMTests
    {
        [TestMethod]
        public void CountMandMsInAUSGallonTest()
        {
            //Arrange
            string unit = "Gallon";
            float quantity = 1f;

            //Act
            float result = Calculator.CountMandMs(unit, quantity);

            //Assert
            Assert.AreEqual(4047.3, Math.Round(result, 2), 0.01);
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
            Assert.AreEqual(1011.82, Math.Round(result, 2), 0.01);
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
            Assert.AreEqual(31.62, Math.Round(result, 2), 0.01);
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
            Assert.AreEqual(339972.88, Math.Round(result, 2), 0.01);
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
            Assert.AreEqual(252.96, Math.Round(result, 2), 0.01);
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
            Assert.AreEqual(63.24, Math.Round(result, 2), 0.01);
        }

        [TestMethod]
        public void CountMandMsInAUSTableSpoonTest()
        {
            //Arrange
            string unit = "Tablespoon";
            float quantity = 1f;

            //Act
            float result = Calculator.CountMandMs(unit, quantity);

            //Assert
            Assert.AreEqual(15.81, Math.Round(result, 2), 0.01);
        }

        [TestMethod]
        public void CountMandMsInAUSTeaSpoonTest()
        {
            //Arrange
            string unit = "Teaspoon";
            float quantity = 1f;

            //Act
            float result = Calculator.CountMandMs(unit, quantity);

            //Assert
            Assert.AreEqual(5.27, Math.Round(result, 2), 0.01);
        }

        [TestMethod]
        public void CountMandMsInANullUnitTest()
        {
            //Arrange
            string unit = null;
            float quantity = 1f;

            //Act & Assert
            Assert.Throws<Exception>(() => Calculator.CountMandMs(unit, quantity));
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
            Assert.AreEqual(1069.18, Math.Round(result, 2), 0.01);
        }

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
            Assert.AreEqual(1069.18, Math.Round(result, 2), 0.01);
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
            Assert.AreEqual(1069.18, Math.Round(result, 2), 0.01);
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
            Assert.AreEqual(17.52, Math.Round(result, 2), 0.01);
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
            Assert.AreEqual(30275.94, Math.Round(result, 2), 0.01);
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
                Calculator.CountMandMs(unit, height, width, length);
            }
            catch (Exception ex)
            {
                //Assert
                Assert.IsNotNull(ex);
            }
        }

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
            Assert.AreEqual(839.73, Math.Round(result, 2), 0.01);
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
            Assert.AreEqual(3358.94, Math.Round(result, 2), 0.01);
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
            Assert.AreEqual(3358.94, Math.Round(result, 2), 0.01);
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
            Assert.AreEqual(880.69, Math.Round(result, 2), 0.01);
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
            Assert.AreEqual(95114.68, Math.Round(result, 2), 0.01);
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
                Calculator.CountMandMs(unit, height, radius);
            }
            catch (Exception ex)
            {
                //Assert
                Assert.IsNotNull(ex);
            }
        }

    }
}
