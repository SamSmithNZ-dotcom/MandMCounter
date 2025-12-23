using MandMCounter.Service.Controllers;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MandMCounter.Tests.Controllers
{
    [System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
    [TestClass]
    public class JellyBeanControllerTests
    {
        private JellyBeanCounterController _controller;

        [TestInitialize]
        public void Setup()
        {
            _controller = new JellyBeanCounterController();
        }

        [TestMethod]
        public void ControllerCountJellyBeansInAUSGallonTest()
        {
            //Arrange
            string unit = "Gallon";
            float quantity = 1f;
            const float expectedJellyBeans = 8558f;
            const float tolerance = 0.0001f;

            //Act
            float result = _controller.GetDataForUnit(unit, quantity);

            //Assert
            Assert.AreEqual(expectedJellyBeans, System.Math.Round(result, 0), tolerance);
        }

        [TestMethod]
        public void ControllerCountJellyBeansInAUSQuartTest()
        {
            //Arrange
            string unit = "Quart";
            float quantity = 1f;
            const float expectedJellyBeans = 2139f;
            const float tolerance = 0.0001f;

            //Act
            float result = _controller.GetDataForUnit(unit, quantity);

            //Assert
            Assert.AreEqual(expectedJellyBeans, System.Math.Round(result, 0), tolerance);
        }

        [TestMethod]
        public void ControllerCountJellyBeansInAUSCupTest()
        {
            //Arrange
            string unit = "Cup";
            float quantity = 1f;
            const float expectedJellyBeans = 535f;
            const float tolerance = 0.0001f;

            //Act
            float result = _controller.GetDataForUnit(unit, quantity);

            //Assert
            Assert.AreEqual(expectedJellyBeans, System.Math.Round(result, 0), tolerance);
        }

        [TestMethod]
        public void ControllerCountJellyBeansInAUSTableSpoonTest()
        {
            //Arrange
            string unit = "Tablespoon";
            float quantity = 1f;
            const float expectedJellyBeans = 33f;
            const float tolerance = 0.0001f;

            //Act
            float result = _controller.GetDataForUnit(unit, quantity);

            //Assert
            Assert.AreEqual(expectedJellyBeans, System.Math.Round(result, 0), tolerance);
        }

        [TestMethod]
        public void ControllerCountJellyBeansInALiterTest()
        {
            //Arrange
            string unit = "Liter";
            float quantity = 1f;
            const float expectedJellyBeans = 2261f;
            const float tolerance = 0.0001f;

            //Act
            float result = _controller.GetDataForUnit(unit, quantity);

            //Assert
            Assert.AreEqual(expectedJellyBeans, System.Math.Round(result, 0), tolerance);
        }

        [TestMethod]
        public void ControllerCountJellyBeansInA1CubicCMTest()
        {
            //Arrange
            string unit = "cm";
            float height = 10;
            float width = 10;
            float length = 10;

            //Act
            float result = _controller.GetDataForRectangle(unit, height, width, length);

            //Assert
            const float expected = 2261f;
            const float delta = 0.0001f;
            Assert.AreEqual(expected, System.Math.Round(result, 0), delta);
        }

        [TestMethod]
        public void ControllerCountJellyBeansInA1CubicInchTest()
        {
            //Arrange
            string unit = "inch";
            float height = 1;
            float width = 1;
            float length = 1;

            //Act
            float result = _controller.GetDataForRectangle(unit, height, width, length);

            //Assert
            const float expected = 37f;
            const float delta = 0.0001f;
            Assert.AreEqual(expected, System.Math.Round(result, 0), delta);
        }

        [TestMethod]
        public void ControllerCountJellyBeansInACylinderWithCMTest()
        {
            //Arrange
            string unit = "cm";
            float height = 10;
            float radius = 5;

            //Act
            float result = _controller.GetDataForCylinder(unit, height, radius);

            //Assert
            const float expected = 1776f;
            const float delta = 0.0001f;
            Assert.AreEqual(expected, System.Math.Round(result, 0), delta);
        }

        [TestMethod]
        public void ControllerCountJellyBeansInACylinderWithInchTest()
        {
            //Arrange
            string unit = "inch";
            float height = 4;
            float radius = 2;

            //Act
            float result = _controller.GetDataForCylinder(unit, height, radius);

            //Assert
            const float expected = 1862f;
            const float delta = 0.0001f;
            Assert.AreEqual(expected, System.Math.Round(result, 0), delta);
        }

    }
}
