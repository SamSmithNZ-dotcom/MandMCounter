using Microsoft.VisualStudio.TestTools.UnitTesting;
using MandMCounter.Core;
using System.Collections.Generic;

namespace MandMCounter.Tests
{
    [System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
    [TestClass]
    public class UnitsTests
    {
        [TestMethod]
        public void GetUnitsForVolumeTest()
        {
            //Arrange

            //Act
            List<string> results = Units.GetUnitsForVolume();

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
            List<string> results = Units.GetUnitsForContainer();

            //Assert
            Assert.IsNotNull(results);
            Assert.IsNotEmpty(results);
            Assert.IsFalse(string.IsNullOrEmpty(results[0]));
        }


    }
}
