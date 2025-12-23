using Microsoft.VisualStudio.TestTools.UnitTesting;
using MandMCounter.Service.Controllers;
using System;

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

        #region "Testing units"

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

        #endregion

        #region " Testing volume in a rectangle" 

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
            const float expected = 2260f;
            const float delta = 0.0001f;
            Assert.AreEqual(expected, System.Math.Round(result, 0), delta);
        }

        #endregion

        #region " Testing volume in a cylinder" 

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
            const float expected = 1777f;
            const float delta = 0.0001f;
            Assert.AreEqual(expected, System.Math.Round(result, 0), delta);
        }

        #endregion

    }
}
