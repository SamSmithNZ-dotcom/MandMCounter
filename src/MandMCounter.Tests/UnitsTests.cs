using Microsoft.VisualStudio.TestTools.UnitTesting;
using MandMCounter.Core;
using System.Collections.Generic;
using System.Linq;

namespace MandMCounter.Tests
{
    [System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
    [TestClass]
    public class UnitTests
    {
        [TestMethod]
        public void GetUnitsForVolumeTest()
        {
            //Arrange

            //Act
            List<string> results = Units.GetUnitsForVolume();

            //Assert
            Assert.IsNotNull(results);
            Assert.IsTrue(results.Count > 0);
            Assert.IsFalse(results.Any(s => string.IsNullOrEmpty(s)));
        }

        [TestMethod]
        public void GetUnitsForContainerTest()
        {
            //Arrange

            //Act
            List<string> results = Units.GetUnitsForContainer();

            //Assert
            Assert.IsNotNull(results);
            Assert.IsTrue(results.Count > 0);
            Assert.IsFalse(results.Any(s => string.IsNullOrEmpty(s)));
        }


    }
}
