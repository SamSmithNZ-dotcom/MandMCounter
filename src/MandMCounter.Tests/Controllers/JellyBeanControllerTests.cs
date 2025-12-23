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

            //Act
            float result = _controller.GetDataForUnit(unit, quantity);

            //Assert
            Assert.IsLessThan(expectedJellyBeans, result);
        }

        [TestMethod]
        public void ControllerCountJellyBeansInAUSQuartTest()
        {
            //Arrange
            string unit = "Quart";
            float quantity = 1f;
            const float expectedJellyBeans = 2140f;

            //Act
            float result = _controller.GetDataForUnit(unit, quantity);

            //Assert
            Assert.IsLessThan(expectedJellyBeans, result);
        }

        [TestMethod]
        public void ControllerCountJellyBeansInAUSCupTest()
        {
            //Arrange
            string unit = "Cup";
            float quantity = 1f;
            const float expectedJellyBeans = 535f;

            //Act
            float result = _controller.GetDataForUnit(unit, quantity);

            //Assert
            Assert.IsLessThan(expectedJellyBeans, result);
        }

        [TestMethod]
        public void ControllerCountJellyBeansInAUSTableSpoonTest()
        {
            //Arrange
            string unit = "Tablespoon";
            float quantity = 1f;
            const float expectedJellyBeans = 34f;

            //Act
            float result = _controller.GetDataForUnit(unit, quantity);

            //Assert
            Assert.IsLessThan(expectedJellyBeans, result);
        }

        [TestMethod]
        public void ControllerCountJellyBeansInALiterTest()
        {
            //Arrange
            string unit = "Liter";
            float quantity = 1f;
            const float expectedJellyBeans = 2261f;

            //Act
            float result = _controller.GetDataForUnit(unit, quantity);

            //Assert
            Assert.IsLessThan(expectedJellyBeans, result);
        }

        [TestMethod]
        public void ControllerCountJellyBeansInA1CubicCMTest()
        {
            //Arrange
            string unit = "cm";
            float height = 10;
            float width = 10;
            float length = 10;
            const float expectedJellyBeans = 2261f;

            //Act
            float result = _controller.GetDataForRectangle(unit, height, width, length);

            //Assert
            Assert.IsLessThan(expectedJellyBeans, result);
        }

        [TestMethod]
        public void ControllerCountJellyBeansInA1CubicInchTest()
        {
            //Arrange
            string unit = "inch";
            float height = 1;
            float width = 1;
            float length = 1;
            const float expectedJellyBeans = 38f;

            //Act
            float result = _controller.GetDataForRectangle(unit, height, width, length);

            //Assert
            Assert.IsLessThan(expectedJellyBeans, result);
        }

        [TestMethod]
        public void ControllerCountJellyBeansInACylinderWithCMTest()
        {
            //Arrange
            string unit = "cm";
            float height = 10;
            float radius = 5;
            const float expectedJellyBeans = 1776f;

            //Act
            float result = _controller.GetDataForCylinder(unit, height, radius);

            //Assert
            Assert.IsLessThan(expectedJellyBeans, result);
        }

        [TestMethod]
        public void ControllerCountJellyBeansInACylinderWithInchTest()
        {
            //Arrange
            string unit = "inch";
            float height = 4;
            float radius = 2;
            const float expectedJellyBeans = 1863f;

            //Act
            float result = _controller.GetDataForCylinder(unit, height, radius);

            //Assert
            Assert.IsLessThan(expectedJellyBeans, result);
        }

    }
}
