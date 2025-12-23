using MandMCounter.Service.Controllers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
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
            Assert.IsNotNull(results);
            Assert.IsNotEmpty(results);
            Assert.IsFalse(string.IsNullOrEmpty(results[0]));
        }

        [TestMethod]
        public void GetUnitsForContainerTest()
        {
            //Arrange

            //Act
            UnitsController controller = new UnitsController();
            List<string> results = controller.GetUnitsForContainer();

            //Assert
            Assert.IsNotNull(results);
            Assert.IsNotEmpty(results);
            Assert.IsFalse(string.IsNullOrEmpty(results[0]));
        }
    }
}
