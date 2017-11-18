using System;
using System.Collections.Generic;
using System.Text;

namespace MandMCounter.Core
{
    public class Calculator
    {
        public float CalculateMandMs(string unit, float quanity)
        {
            if (string.IsNullOrEmpty(unit))
            {
                throw new Exception("No unit input. Please pass a unit, such as cup, tablespoon, teaspoon, etc");
            }

            //Here is the meat of the math
            float numberOfMandMs = GetCubicCm(unit, quanity) * Constants.MandMSDensityPercent;
            return numberOfMandMs;
        }

        public float CalculateMandMs(string unit, float height, float width, float length)
        {
            if (string.IsNullOrEmpty(unit))
            {
                throw new Exception("No unit input. Please pass a unit, such as cup, tablespoon, teaspoon, etc");
            }

            //Here is the meat of the math
            float numberOfMandMs = GetCubicCm(unit, height, width, length) * Constants.MandMSDensityPercent;
            return numberOfMandMs;
        }

        private float GetCubicCm(string unit, float height, float width, float length)
        {
            switch (unit.ToLower())
            {
                case "cm":
                    return height * width * length;
                case "inch":
                    return Constants.USCubicInchesToCubicCM * height * width * length;
                default:
                    return 0f;
            }
        }

        private float GetCubicCm(string unit, float quantity)
        {
            switch (unit.ToLower())
            {
                case "cup":
                    return Constants.USCupToCubicCm * quantity;
                case "tablespoon":
                    return Constants.USTableSpoonToCubicCm * quantity;
                case "teaspoon":
                    return Constants.USTeaSpoonToCubicCm * quantity;
                default:
                    return 0f;
            }
        }

    }
}
