using MandMCounter.Service.Controllers;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MandMCounter.Tests.Controllers
{
    [System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
    [TestClass]
    public class SkittleControllerTests
    {
        private SkittleCounterController _controller;
        private const float _tolerance = 0.0001f;

        [TestInitialize]
        public void Setup()
        {
            _controller = new SkittleCounterController();
        }

        [TestMethod]
        public void ControllerCountSkittlesInAUSCupTest()
        {
            //Arrange
            string unit = "Cup";
            float quantity = 1f;
            const float expectedSkittles = 212f;

            //Act
            //SkittleCounterController controller = new SkittleCounterController();
            float result = _controller.GetDataForUnit(unit, quantity);

            //Assert
            Assert.AreEqual(expectedSkittles, System.Math.Round(result, 0), _tolerance);
        }

        [TestMethod]
        public void ControllerCountSkittlesInA1CubicCMTest()
        {
            //Arrange
            string unit = "cm";
            float height = 10;
            float width = 10;
            float length = 10;

            //Act
            //SkittleCounterController controller = new SkittleCounterController();
            float result = _controller.GetDataForRectangle(unit, height, width, length);

            //Assert
            const float expected = 896f;
            Assert.AreEqual(expected, System.Math.Round(result, 0), _tolerance);
        }

        [TestMethod]
        public void ControllerCountSkittlesInACylinderWithCMTest()
        {
            //Arrange
            string unit = "cm";
            float height = 10;
            float radius = 5;

            //Act
            //SkittleCounterController controller = new SkittleCounterController();
            float result = _controller.GetDataForCylinder(unit, height, radius);

            //Assert
            const float expected = 704f;
            Assert.AreEqual(expected, System.Math.Round(result, 0), _tolerance);
        }

    }
}
