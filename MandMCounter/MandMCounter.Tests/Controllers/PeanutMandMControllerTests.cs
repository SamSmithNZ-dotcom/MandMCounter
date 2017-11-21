using Microsoft.VisualStudio.TestTools.UnitTesting;
using MandMCounter.Service.Controllers;
using System;

namespace MandMCounter.Tests.Controllers
{
    [System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
    [TestClass]
    public class PeanutMandMControllerTests
    {
        #region "Testing units"       

        [TestMethod]
        public void ControllerCountPeanutMandMsInAUSCupTest()
        {
            //Arrange
            string unit = "Cup";
            float quantity = 1f;

            //Act
            PeanutMandMCounterController controller = new PeanutMandMCounterController();
            float result = controller.GetData(unit, quantity);

            //Assert
            Assert.IsTrue(System.Math.Round(result, 0) == 181f);
        }                

        #endregion

        #region " Testing volume in a rectangle" 

        [TestMethod]
        public void ControllerCountPeanutMandMsInA1CubicCMTest()
        {
            //Arrange
            string unit = "cm";
            float height = 10;
            float width = 10;
            float length = 10;

            //Act
            PeanutMandMCounterController controller = new PeanutMandMCounterController();
            float result = controller.GetData(unit, height, width, length);

            //Assert
            Assert.IsTrue(System.Math.Round(result, 0) == 764f);
        }      

        #endregion

        #region " Testing volume in a cylinder" 

        [TestMethod]
        public void ControllerCountPeanutMandMsInACylinderWithCMTest()
        {
            //Arrange
            string unit = "cm";
            float height = 10;
            float radius = 5;

            //Act
            PeanutMandMCounterController controller = new PeanutMandMCounterController();
            float result = controller.GetData(unit, height, radius);

            //Assert
            Assert.IsTrue(System.Math.Round(result, 0) == 600f);
        }

        #endregion

    }
}
