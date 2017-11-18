using System;
using System.Collections.Generic;
using System.Text;

namespace MandMCounter.Core
{
    public class Calculator
    {
        public float CountMandMs(string unit, float quanity)
        {
            if (string.IsNullOrEmpty(unit))
            {
                throw new Exception("No unit input. Please pass a unit, such as cup, tablespoon, teaspoon, etc");
            }

            //Here is the meat of the math
            float numberOfMandMs = GetCubicCm(unit, quanity) * Constants.MandMSDensityPercent;
            return numberOfMandMs;
        }

        public float CountMandMs(string unit, float height, float width, float length)
        {
            if (string.IsNullOrEmpty(unit))
            {
                throw new Exception("No unit input. Please pass a unit, such as cup, tablespoon, teaspoon, etc");
            }

            //Here is the meat of the math
            float numberOfMandMs = GetCubicCm(unit, height, width, length) * Constants.MandMSDensityPercent;
            return numberOfMandMs;
        }

        public float CountMandMs(string unit, float height, float radius)
        {
            if (string.IsNullOrEmpty(unit))
            {
                throw new Exception("No unit input. Please pass a unit, such as cup, tablespoon, teaspoon, etc");
            }

            //Here is the meat of the math
            float numberOfMandMs = GetCubicCm(unit, height, radius) * Constants.MandMSDensityPercent;
            return numberOfMandMs;
        }

        private float GetCubicCm(string unit, float quantity)
        {
            switch (unit.ToLower())
            {
                case "gallon":
                    return Constants.USGallonToCubicCM * quantity;
                case "quart":
                    return Constants.USQuartToCubicCm * quantity;
                case "cup":
                    return Constants.USCupToCubicCm * quantity;
                case "tablespoon":
                    return Constants.USTableSpoonToCubicCm * quantity;
                case "teaspoon":
                    return Constants.USTeaSpoonToCubicCm * quantity;
                default:
                    throw new Exception("Unknown unit when calculating volume of unit: " + unit);
            }
        }

        private float GetCubicCm(string unit, float height, float width, float length)
        {
            float baseCalculation = height * width * length;

            switch (unit.ToLower())
            {
                case "cm":
                    return baseCalculation;
                case "inch":
                    return Constants.USCubicInchesToCubicCM * baseCalculation;
                default:
                    throw new Exception("Unknown unit when calculating volume of rectangle: " + unit);
            }
        }

        private float GetCubicCm(string unit, float height, float radius)
        {

            // radius ^ 2 * (pi) * height
            float baseCalculation = (float)(Convert.ToDouble(radius) * Convert.ToDouble(radius) * Math.PI * Convert.ToDouble(height));

            switch (unit.ToLower())
            {
                case "cm":
                    return baseCalculation;
                case "inch":
                    return Constants.USCubicInchesToCubicCM * baseCalculation;
                default:
                    throw new Exception("Unknown unit when calculating volume of cylinder: " + unit);
            }
        }

    }
}
