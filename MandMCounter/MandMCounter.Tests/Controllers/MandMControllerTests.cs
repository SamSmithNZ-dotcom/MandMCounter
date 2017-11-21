using Microsoft.VisualStudio.TestTools.UnitTesting;
using MandMCounter.Service.Controllers;
using System;

namespace MandMCounter.Tests.Controllers
{
    [System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
    [TestClass]
    public class MandMControllerTests
    {
        #region "Testing units"

        [TestMethod]
        public void ControllerCountMandMsInAUSGallonTest()
        {
            //Arrange
            string unit = "Cup";
            float quantity = 1f;

            //Act
            MandMCounterController controller = new MandMCounterController();
            float result = controller.GetData(unit, quantity);
            
            //Assert
            Assert.IsTrue(System.Math.Round(result, 0) == 253f);
        }     

        #endregion

        #region " Testing volume in a rectangle" 

        [TestMethod]
        public void ControllerCountMandMsInA1CubicCMTest()
        {
            //Arrange
            string unit = "cm";
            float height = 10;
            float width = 10;
            float length = 10;

            //Act
            MandMCounterController controller = new MandMCounterController();
            float result = controller.GetData(unit, height, width, length);

            //Assert
            Assert.IsTrue(System.Math.Round(result, 0) == 1069f);
        }        

        #endregion

        #region " Testing volume in a cylinder" 

        [TestMethod]
        public void ControllerCountMandMsInACylinderWithCMTest()
        {
            //Arrange
            string unit = "cm";
            float height = 10;
            float radius = 5;

            //Act
            MandMCounterController controller = new MandMCounterController();
            float result = controller.GetData(unit, height, radius);

            //Assert
            Assert.IsTrue(System.Math.Round(result, 0) == 840f);
        }      

        #endregion

    }
}
