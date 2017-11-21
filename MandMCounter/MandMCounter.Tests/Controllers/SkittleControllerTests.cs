using Microsoft.VisualStudio.TestTools.UnitTesting;
using MandMCounter.Service.Controllers;
using System;

namespace MandMCounter.Tests.Controllers
{
    [System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
    [TestClass]
    public class SkittleControllerTests
    {
        #region "Testing units"

        [TestMethod]
        public void ControllerCountSkittlesInAUSCupTest()
        {
            //Arrange
            string unit = "Cup";
            float quantity = 1f;

            //Act
            SkittleCounterController controller = new SkittleCounterController();
            float result = controller.GetDataForUnit(unit, quantity);

            //Assert
            Assert.IsTrue(System.Math.Round(result, 0) == 212f);
        }

        #endregion

        #region " Testing volume in a rectangle" 

        [TestMethod]
        public void ControllerCountSkittlesInA1CubicCMTest()
        {
            //Arrange
            string unit = "cm";
            float height = 10;
            float width = 10;
            float length = 10;

            //Act
            SkittleCounterController controller = new SkittleCounterController();
            float result = controller.GetDataForRectangle(unit, height, width, length);

            //Assert
            Assert.IsTrue(System.Math.Round(result, 0) == 896f);
        }

        #endregion

        #region " Testing volume in a cylinder" 

        [TestMethod]
        public void ControllerCountSkittlesInACylinderWithCMTest()
        {
            //Arrange
            string unit = "cm";
            float height = 10;
            float radius = 5;

            //Act
            SkittleCounterController controller = new SkittleCounterController();
            float result = controller.GetDataForCylinder(unit, height, radius);

            //Assert
            Assert.IsTrue(System.Math.Round(result, 0) == 704f);
        }

        #endregion

    }
}
