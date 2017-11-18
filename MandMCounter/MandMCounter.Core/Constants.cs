using System;

namespace MandMCounter.Core
{
    public class Constants
    {
        //Reference: https://marcos.kirsch.mx/2004/08/08/how-many-mms-are-in-the-jar/
        public static float MandMVolumeCubicCm = 0.636f;

        //Reference: https://yenra.com/particle-packing/
        public static float MandMSDensityPercent = 0.68f;

        //Conversions done using Google conversion calculater
        public static float USGallonToCubicCM = 3785.4119997685f;
        public static float USQuartToCubicCm = 946.353f;
        public static float USCupToCubicCm = 236.5882f;
        public static float USFluidOunceToCubicCm = 29.5735f;
        public static float USTableSpoonToCubicCm = 14.786750000399932148f;
        public static float USTeaSpoonToCubicCm = 4.92891507305157f;
        public static float USCubicInchesToCubicCM = 16.3871f;
        public static float USCubicFeetToCubicCM = 28316.908804112f;
    }
}
