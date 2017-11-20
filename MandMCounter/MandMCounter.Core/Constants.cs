using System;

namespace MandMCounter.Core
{
    public class Constants
    {
        //Reference: https://marcos.kirsch.mx/2004/08/08/how-many-mms-are-in-the-jar/
        public const float MandMVolumeCubicCm = 0.636f;
        //Reference: http://answers.kgb.com/how-many-peanut-mandms-can-you-fit-in-a-gallon-glass-jar/23109715
        public const float PeanutMandMVolumeCubicCm = 0.83776f;
        //Reference: this one thinks it's 0.625f http://www.answers.com/Q/What_is_a_volume_of_one_skittle
        //Reference 2: this one thinks it's  0.7418629f https://community.babycenter.com/post/a37375396/guess_how_many_skittles?cpg=2
        public const float SkittlesVolumeCubicCm = 0.7418629f; //Going with the bigger number, as skittles are bigger than M&Ms

        //Reference: https://yenra.com/particle-packing/
        //Some people think this is 68.5%. https://cims.nyu.edu/~donev/Thesis.pdf
        public const float MandMSDensityPercent = 0.68f;
        //Reference: http://answers.kgb.com/how-many-peanut-mandms-can-you-fit-in-a-gallon-glass-jar/23109715
        public const float PeanutMandMSDensityPercent = 0.64f;
        //Reference: https://community.babycenter.com/post/a37375396/guess_how_many_skittles?cpg=2
        public const float SkittlesDensityPercent = 0.665f; //This feels right too, as skittles are more round than an M&M

        //Conversions done using Google conversion calculater
        public const float USGallonToCubicCM = 3785.4119997685f;
        public const float USQuartToCubicCm = 946.353f;
        public const float USCupToCubicCm = 236.5882f;
        public const float USFluidOunceToCubicCm = 29.5735f;
        public const float USTableSpoonToCubicCm = 14.786750000399932148f;
        public const float USTeaSpoonToCubicCm = 4.92891507305157f;
        public const float USCubicInchesToCubicCM = 16.3871f;
        public const float USCubicFeetToCubicCM = 28316.908804112f;
    }
}
