using System;

class URI
{
    static void Main(string[] args)
    {
        var ENTRADA = System.Console.ReadLine().Trim().Split(' ');

        double A = Double.Parse(ENTRADA[0]);
        double B = Double.Parse(ENTRADA[1]);
        double C = Double.Parse(ENTRADA[2]);

        double DELTA = ((Math.Pow(B, 2)) - 4 * A * C);

        if ((DELTA > 0) && (A != 0))
        {
            double X1 = (((-B) + Math.Sqrt((Math.Pow(B, 2)) - 4 * A * C)) / (2 * A));
            double X2 = (((-B) - Math.Sqrt((Math.Pow(B, 2)) - 4 * A * C)) / (2 * A));

            Console.WriteLine("R1 = {0:F5}\nR2 = {1:F5}", X1, X2);
        }
        else
            Console.WriteLine("Impossivel calcular");
    }
}