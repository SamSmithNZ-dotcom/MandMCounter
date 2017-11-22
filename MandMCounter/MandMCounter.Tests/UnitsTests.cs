using Microsoft.VisualStudio.TestTools.UnitTesting;
using MandMCounter.Core;
using System;
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
            Units units = new Units();
            List<string> results = units.GetUnitsForVolume();

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
            Units units = new Units();
            List<string> results = units.GetUnitsForContainer();

            //Assert
            Assert.IsTrue(results != null);
            Assert.IsTrue(results.Count > 0);
            Assert.IsTrue(string.IsNullOrEmpty(results[0]) == false);
        }

        [TestMethod]
        public void CountSkittlesInAUSCupTest()
        {
            //Arrange
            string unit = "Cup";
            float quantity = 1f;

            //Act
            Calculator calc = new Calculator();
            float result = calc.CountSkittles(unit, quantity);

            //Assert
            Assert.IsTrue(System.Math.Round(result, 0) == 212f);
        }

    }
}
