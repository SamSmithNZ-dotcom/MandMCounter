using Microsoft.VisualStudio.TestTools.UnitTesting;
using MandMCounter.Service.Controllers;
using System;
using System.Collections.Generic;

namespace MandMCounter.Tests
{
    [System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
    [TestClass]
    public class UnitsControllerTests
    {
        [TestMethod]
        public void GetUnitsForVolumeTest()
        {
            //Arrange

            //Act
            UnitsController controller = new UnitsController();
            List<string> results = controller.GetUnitsForVolume();

            //Assert
            Assert.IsTrue(results != null);
            Assert.IsTrue(results.Count > 0);
            Assert.IsTrue(string.IsNullOrEmpty(results[0]) == false);
        }

        [TestMethod]
        public void GetUnitsForContainerTest()
        {
            //Arrange

            //Act
            UnitsController controller = new UnitsController();
            List<string> results = controller.GetUnitsForContainer();

            //Assert
            Assert.IsTrue(results != null);
            Assert.IsTrue(results.Count > 0);
            Assert.IsTrue(string.IsNullOrEmpty(results[0]) == false);
        }
    }
}
