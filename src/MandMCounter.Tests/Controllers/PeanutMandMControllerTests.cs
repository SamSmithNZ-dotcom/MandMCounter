using MandMCounter.Service.Controllers;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MandMCounter.Tests.Controllers
{
    [System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
    [TestClass]
    public class PeanutMandMControllerTests
    {
        private PeanutMandMCounterController _controller;
        private const float _tolerance = 0.0001f;

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

            //Act
            float result = _controller.GetDataForUnit(unit, quantity);

            //Assert
            Assert.AreEqual(181f, System.Math.Round(result, 0));
        }                

        [TestMethod]
        public void ControllerCountPeanutMandMsInA1000CubicCMTest()
        {
            //Arrange
            string unit = "cm";
            float height = 10;
            float width = 10;
            float length = 10;

            //Act
            float result = _controller.GetDataForRectangle(unit, height, width, length);

            //Assert
            Assert.AreEqual(764, (int)System.Math.Round(result, 0));
        }      

        [TestMethod]
        public void ControllerCountPeanutMandMsInACylinderWithCMTest()
        {
            //Arrange
            string unit = "cm";
            float height = 10;
            float radius = 5;

            //Act
            float result = _controller.GetDataForCylinder(unit, height, radius);

            //Assert
            Assert.AreEqual(600f, System.Math.Round(result, 0));
        }

    }
}
