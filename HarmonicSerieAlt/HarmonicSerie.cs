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
                r += Math.Pow(-1, n + 1) / n;
            }
            return r;
        }
    }
}
