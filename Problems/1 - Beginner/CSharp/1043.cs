using System;

class URI
{
    static void Main(string[] args)
    {
        var ENTRADA = System.Console.ReadLine().Trim().Split(' ');
        double a = double.Parse(ENTRADA[0]);
        double b = double.Parse(ENTRADA[1]);
        double c = double.Parse(ENTRADA[2]);

        if (a < b + c && b < a + c && c < a + b)
            Console.WriteLine("Perimetro = {0:F1}", (a + b + c));
        else
            Console.WriteLine("Area = {0:F1}", ((a + b) * c) / 2);
    }
}