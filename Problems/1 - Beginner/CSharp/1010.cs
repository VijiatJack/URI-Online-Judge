using System;

class URI
{
    static void Main(string[] args)
    {
        string ENTRADA1 = System.Console.ReadLine().Trim();
        string ENTRADA2 = System.Console.ReadLine().Trim();

        var DIVISOR1 = ENTRADA1.Split(' ');
        var DIVISOR2 = ENTRADA2.Split(' ');

        int A = Int32.Parse(DIVISOR1[1].Trim());
        double B = Double.Parse(DIVISOR1[2].Trim());

        int C = Int32.Parse(DIVISOR2[1].Trim());
        double D = Double.Parse(DIVISOR2[2].Trim());

        Console.WriteLine("VALOR A PAGAR: R$ {0:F2}", ((A * B) + (C * D)));
    }
}