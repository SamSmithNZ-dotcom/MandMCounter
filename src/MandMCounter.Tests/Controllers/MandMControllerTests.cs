using MandMCounter.Service.Controllers;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MandMCounter.Tests.Controllers
{
    [System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
    [TestClass]
    public class MandMControllerTests
    {
        private MandMCounterController _controller;

        [TestInitialize]
        public void Setup()
        {
            _controller = new();
        }

        [TestMethod]
        public void ControllerCountMandMsInAUSGallonTest()
        {
            //Arrange
            string unit = "Cup";
            float quantity = 1f;

            //Act
            float result = _controller.GetDataForUnit(unit, quantity);
            
            //Assert
            Assert.IsLessThan(253f, result);
        }     

        [TestMethod]
        public void ControllerCountMandMsInA1CubicCMTest()
        {
            //Arrange
            string unit = "cm";
            float height = 10;
            float width = 10;
            float length = 10;
            const float expectedMandMs = 1070f;

            //Act
            float result = _controller.GetDataForRectangle(unit, height, width, length);

            //Assert
            Assert.IsLessThan(expectedMandMs, result);
        }        

        [TestMethod]
        public void ControllerCountMandMsInACylinderWithCMTest()
        {
            //Arrange
            string unit = "cm";
            float height = 10;
            float radius = 5;
            const float expectedMandMs = 840f;

            //Act
            float result = _controller.GetDataForCylinder(unit, height, radius);

            //Assert
            Assert.IsLessThan(expectedMandMs, result);
        }      

    }
}
