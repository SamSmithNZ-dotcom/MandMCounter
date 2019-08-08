using System;
using System.Collections.Generic;

namespace MandMCounter.Core
{
    public class Units
    {
        public List<string> GetUnitsForVolume()
        {
            List<string> units = new List<string>
            {
                "teaspoon",
                "tablespoon",
                "cup",
                "quart",
                "ounce",
                "pound",
                "gallon",
                "liter"
            };
            return units;
        }

        public List<string> GetUnitsForContainer()
        {
            List<string> units = new List<string>
            {
                "cm",
                "meter",
                "inch",
                "feet"
            };
            return units;
        }
    }
}
