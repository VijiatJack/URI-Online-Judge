using System;

class URI
{

    static void Main(string[] args)
    {

        double A = Double.Parse(System.Console.ReadLine().Trim());
        double B = Double.Parse(System.Console.ReadLine().Trim());
        double C = Double.Parse(System.Console.ReadLine().Trim());

        double MEDIA = ((A * 0.2) + (B * 0.3) + (C * 0.5));

        Console.WriteLine("MEDIA = {0:F1}", MEDIA);

    }

}