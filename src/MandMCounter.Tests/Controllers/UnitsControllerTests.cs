using MandMCounter.Service.Controllers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace MandMCounter.Tests.Controllers
{
    [System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
    [TestClass]
    public class UnitsControllerTests
    {
        private UnitsController _controller;
 
        [TestInitialize]
        public void Setup()
        {
            _controller = new();
        }

        [TestMethod]
        public void GetUnitsForVolumeTest()
        {
            //Arrange

            //Act
            List<string> results = _controller.GetUnitsForVolume();

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
            List<string> results = _controller.GetUnitsForContainer();

            //Assert
            Assert.IsNotNull(results);
            Assert.IsNotEmpty(results);
            Assert.IsFalse(string.IsNullOrEmpty(results[0]));
        }
    }
}
