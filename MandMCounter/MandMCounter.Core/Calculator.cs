using System;
using System.Collections.Generic;
using System.Text;

namespace MandMCounter.Core
{
    public class Calculator
    {
        /// <summary>
        /// To count the number of M&Ms in a container based on unit volume (Quart/Gallon/Liter, etc)
        /// </summary>
        /// <param name="unit">String Quart/Gallon/Liter</param>
        /// <param name="quanity">Any float number</param>
        /// <returns>M&M count, as an unrounded float</returns>
        public float CountMandMs(string unit, float quanity)
        {
            //Here is the meat of the math
            float numberOfMandMs = GetCubicCmForVolume(unit, quanity) * Constants.MandMSDensityPercent / Constants.MandMVolumeCubicCm;
            return numberOfMandMs;
        }

        public float CountPeanutMandMs(string unit, float quanity)
        {
            //Here is the meat of the math
            float numberOfMandMs = GetCubicCmForVolume(unit, quanity) * Constants.PeanutMandMSDensityPercent / Constants.PeanutMandMVolumeCubicCm;
            return numberOfMandMs;
        }

        public float CountSkittles(string unit, float quanity)
        {
            //Here is the meat of the math
            float numberOfMandMs = GetCubicCmForVolume(unit, quanity) * Constants.SkittlesDensityPercent / Constants.SkittlesVolumeCubicCm;
            return numberOfMandMs;
        }

        /// <summary>
        /// To count the number of M&Ms in a container based on rectangular container
        /// </summary>
        /// <param name="unit">Inch/ CM</param>
        /// <param name="height">the height of the rectangle</param>
        /// <param name="width">the width of the rectangle</param>
        /// <param name="length">the length of the rectangle</param>
        /// <returns>M&M count, as an unrounded float</returns>
        public float CountMandMs(string unit, float height, float width, float length)
        {
            //Here is the meat of the math
            float numberOfMandMs = GetCubicCmForRectangle(unit, height, width, length) * Constants.MandMSDensityPercent / Constants.MandMVolumeCubicCm;
            return numberOfMandMs;
        }

        public float CountPeanutMandMs(string unit, float height, float width, float length)
        {
            //Here is the meat of the math
            float numberOfMandMs = GetCubicCmForRectangle(unit, height, width, length) * Constants.PeanutMandMSDensityPercent / Constants.PeanutMandMVolumeCubicCm;
            return numberOfMandMs;
        }

        public float CountSkittles(string unit, float height, float width, float length)
        {
            //Here is the meat of the math
            float numberOfMandMs = GetCubicCmForRectangle(unit, height, width, length) * Constants.SkittlesDensityPercent / Constants.SkittlesVolumeCubicCm;
            return numberOfMandMs;
        }

        /// <summary>
        /// To count the number of M&Ms in a container based on rectangular container
        /// </summary>
        /// <param name="unit">Inch/ CM</param>
        /// <param name="height">the height of the cylinder</param>
        /// <param name="radius">the radius of the container (half of the diameter)</param>
        /// <returns>M&M count, as an unrounded float</returns>
        public float CountMandMs(string unit, float height, float radius)
        {
            //Here is the meat of the math
            float numberOfMandMs = GetCubicCmForCylinder(unit, height, radius) * Constants.MandMSDensityPercent / Constants.MandMVolumeCubicCm;
            return numberOfMandMs;
        }

        public float CountPeanutMandMs(string unit, float height, float radius)
        {
            //Here is the meat of the math
            float numberOfMandMs = GetCubicCmForCylinder(unit, height, radius) * Constants.PeanutMandMSDensityPercent / Constants.PeanutMandMVolumeCubicCm;
            return numberOfMandMs;
        }

        public float CountSkittles(string unit, float height, float radius)
        {
            //Here is the meat of the math
            float numberOfMandMs = GetCubicCmForCylinder(unit, height, radius) * Constants.SkittlesDensityPercent / Constants.SkittlesVolumeCubicCm;
            return numberOfMandMs;
        }

        private float GetCubicCmForVolume(string unit, float quantity)
        {
            if (string.IsNullOrEmpty(unit))
            {
                unit = "";
            }

            switch (unit.ToLower())
            {
                case "liter":
                case "litre":
                    return 1000f * quantity;
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

        private float GetCubicCmForRectangle(string unit, float height, float width, float length)
        {
            if (string.IsNullOrEmpty(unit))
            {
                unit = "";
            }

            float baseCalculation = height * width * length;

            switch (unit.ToLower())
            {
                case "cm":
                    return baseCalculation;
                case "m":
                    return 1000f * baseCalculation;
                case "inch":
                    return Constants.USCubicInchesToCubicCM * baseCalculation;
                case "feet":
                    return Constants.USCubicFeetToCubicCM * baseCalculation;
                default:
                    throw new Exception("Unknown unit when calculating volume of rectangle: " + unit);
            }
        }

        private float GetCubicCmForCylinder(string unit, float height, float radius)
        {
            if (string.IsNullOrEmpty(unit))
            {
                unit = "";
            }

            // radius ^ 2 * (pi) * height
            float baseCalculation = (float)(Convert.ToDouble(radius) * Convert.ToDouble(radius) * Math.PI * Convert.ToDouble(height));

            switch (unit.ToLower())
            {
                case "cm":
                    return baseCalculation;
                case "m":
                    return 1000f * baseCalculation;
                case "inch":
                    return Constants.USCubicInchesToCubicCM * baseCalculation;
                case "feet":
                    return Constants.USCubicFeetToCubicCM * baseCalculation;
                default:
                    throw new Exception("Unknown unit when calculating volume of cylinder: " + unit);
            }
        }

    }
}
