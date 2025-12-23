using Microsoft.VisualStudio.TestTools.UnitTesting;
using MandMCounter.Service.Controllers;
using System;

namespace MandMCounter.Tests.Controllers
{
    [System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
    [TestClass]
    public class PeanutMandMControllerTests
    {
        [TestMethod]
        public void ControllerCountPeanutMandMsInAmericanCupTest()
        {
            //Arrange
            string unit = "Cup";
            float quantity = 1f;

            //Act
            PeanutMandMCounterController controller = new PeanutMandMCounterController();
            float result = controller.GetDataForUnit(unit, quantity);

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
            PeanutMandMCounterController controller = new PeanutMandMCounterController();
            float result = controller.GetDataForRectangle(unit, height, width, length);

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
            PeanutMandMCounterController controller = new PeanutMandMCounterController();
            float result = controller.GetDataForCylinder(unit, height, radius);

            //Assert
            Assert.AreEqual(600f, System.Math.Round(result, 0));
        }

    }
}
