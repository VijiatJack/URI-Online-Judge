using System;

class URI
{

    static void Main(string[] args)
    {
        int X = Int32.Parse(System.Console.ReadLine().Trim());
        double Y = double.Parse(System.Console.ReadLine().Trim());

        double CONSUMO = (X / Y * 1.0);

        Console.WriteLine("{0:F3} km/l", CONSUMO);
    }
}