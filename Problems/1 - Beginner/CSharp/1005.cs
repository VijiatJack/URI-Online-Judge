using System;

class URI
{

    static void Main(string[] args)
    {

        double A = Double.Parse(System.Console.ReadLine().Trim());
        double B = Double.Parse(System.Console.ReadLine().Trim());

        double MEDIA = ((A * 0.35) + (B * 0.75)) / 1.1;

        Console.WriteLine("MEDIA = {0:F5}", MEDIA);

    }

}