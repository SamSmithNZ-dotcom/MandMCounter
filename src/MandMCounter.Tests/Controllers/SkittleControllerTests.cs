using MandMCounter.Service.Controllers;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MandMCounter.Tests.Controllers
{
    [System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
    [TestClass]
    public class SkittleControllerTests
    {
        private SkittleCounterController _controller;

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
            const float expectedSkittles = 213f;

            //Act
            //SkittleCounterController controller = new SkittleCounterController();
            float result = _controller.GetDataForUnit(unit, quantity);

            //Assert
            Assert.IsLessThan(expectedSkittles, result);
        }

        [TestMethod]
        public void ControllerCountSkittlesInA1CubicCMTest()
        {
            //Arrange
            string unit = "cm";
            float height = 10;
            float width = 10;
            float length = 10;
            const float expectedSkittles = 897f;

            //Act
            //SkittleCounterController controller = new SkittleCounterController();
            float result = _controller.GetDataForRectangle(unit, height, width, length);

            //Assert
            Assert.IsLessThan(expectedSkittles, result);
        }

        [TestMethod]
        public void ControllerCountSkittlesInACylinderWithCMTest()
        {
            //Arrange
            string unit = "cm";
            float height = 10;
            float radius = 5;
            const float expectedSkittles = 705f;

            //Act
            //SkittleCounterController controller = new SkittleCounterController();
            float result = _controller.GetDataForCylinder(unit, height, radius);

            //Assert
            Assert.IsLessThan(expectedSkittles, result);
        }

    }
}
