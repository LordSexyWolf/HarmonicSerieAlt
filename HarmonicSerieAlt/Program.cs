namespace HarmonicSerieAlt;

public class Program
{
    public static void Main(string[] args)
    {
        int t = 1000;
        double sum = HarmonicSerie.AlternativeHarmonicSerie(t);

        Console.WriteLine("The sum of the first " + t + " of Harmonic Serie is " + sum);
    }
}