using System;

class URI
{
    static void Main(string[] args)
    {
        double r = Double.Parse(System.Console.ReadLine().Trim());

        double volume = ((4 / 3.0) * 3.14159 * Math.Pow(r, 3));

        Console.WriteLine("VOLUME = {0:F3}", volume);
    }
}