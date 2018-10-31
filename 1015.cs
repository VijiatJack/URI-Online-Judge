using System;

class URI
{

    static void Main(string[] args)
    {
        string ENTRADA1 = System.Console.ReadLine().Trim();
        string ENTRADA2 = System.Console.ReadLine().Trim();

        var LINHA1 = ENTRADA1.Split(' ');
        var LINHA2 = ENTRADA2.Split(' ');

        double x1 = double.Parse(LINHA1[0]);
        double y1 = double.Parse(LINHA1[1]);

        double x2 = double.Parse(LINHA2[0]);
        double y2 = double.Parse(LINHA2[1]);

        double DISTANCIA = Math.Sqrt((Math.Pow((x2 - x1), 2)) + (Math.Pow((y2 - y1), 2)));

        Console.WriteLine("{0:F4}", DISTANCIA);
    }
}