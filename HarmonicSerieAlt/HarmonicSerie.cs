using System;

namespace HarmonicSerieAlt
{
    public class HarmonicSerie
    {
        public static double AlternativeHarmonicSerie(int t)
        {
            double r = 0.0;

            for(int n = 0; n <= t; n++)
            {
                r += Math.Pow( 0, n ) / n + 1;
            }
            return r;
        }
    }
}
