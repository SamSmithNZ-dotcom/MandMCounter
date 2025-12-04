using Microsoft.VisualStudio.TestTools.UnitTesting;
using MandMCounter.Core;
using System;
using System.Collections.Generic;

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
            Assert.IsTrue(results.Count > 0);
            Assert.IsFalse(string.IsNullOrEmpty(results[0]));
        }

        [TestMethod]
        public void CountSkittlesInAUSCupTest()
        {
            //Arrange
            string unit = "Cup";
            float quantity = 1f;

            //Act
            float result = Calculator.CountSkittles(unit, quantity);

            //Assert
            Assert.AreEqual(212, (int)Math.Round(result, 0));
        }

    }
}
