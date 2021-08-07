using System.Collections.Generic;

namespace MandMCounter.Core
{
    public class Units
    {
        public static List<string> GetUnitsForVolume()
        {
            List<string> units = new()
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

        public static List<string> GetUnitsForContainer()
        {
            List<string> units = new()
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
