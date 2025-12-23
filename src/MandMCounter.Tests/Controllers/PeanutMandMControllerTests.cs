using MandMCounter.Service.Controllers;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MandMCounter.Tests.Controllers
{
    [System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
    [TestClass]
    public class PeanutMandMControllerTests
    {
        private PeanutMandMCounterController _controller;

        [TestInitialize]
        public void Setup()
        {
            _controller = new();
        }

        [TestMethod]
        public void ControllerCountPeanutMandMsInAmericanCupTest()
        {
            //Arrange
            string unit = "Cup";
            float quantity = 1f;
            const float expectedPeanutMandMs = 181f;

            //Act
            float result = _controller.GetDataForUnit(unit, quantity);

            //Assert
            Assert.IsLessThan(expectedPeanutMandMs, result);
        }                

        [TestMethod]
        public void ControllerCountPeanutMandMsInA1000CubicCMTest()
        {
            //Arrange
            string unit = "cm";
            float height = 10;
            float width = 10;
            float length = 10;
            const float expectedPeanutMandMs = 764f;

            //Act
            float result = _controller.GetDataForRectangle(unit, height, width, length);

            //Assert
            Assert.IsLessThan(expectedPeanutMandMs, result);
        }      

        [TestMethod]
        public void ControllerCountPeanutMandMsInACylinderWithCMTest()
        {
            //Arrange
            string unit = "cm";
            float height = 10;
            float radius = 5;
            const float expectedPeanutMandMs = 600f;

            //Act
            float result = _controller.GetDataForCylinder(unit, height, radius);

            //Assert
            Assert.IsLessThan(expectedPeanutMandMs, result);
        }

    }
}
