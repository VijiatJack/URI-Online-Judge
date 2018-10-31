using System;

class URI
{

    static void Main(string[] args)
    {
        double n = 3.14159;
        double raio = Double.Parse(System.Console.ReadLine().Trim());

        double area = (Math.Pow(raio,2) * n);

        Console.Write("A={0:F4}\n", area);
    }

}