using System;

class URI
{

    static void Main(string[] args)
    {
        double N = Double.Parse(System.Console.ReadLine().Trim());

        if ((N >= 0) && (N <= 25))
            Console.WriteLine("Intervalo [0,25]");
        else if ((N > 25) && (N <= 50))
            Console.WriteLine("Intervalo (25,50]");
        else if ((N > 50) && (N <= 75))
            Console.WriteLine("Intervalo (50,75]");
        else if ((N > 75) && (N <= 100))
            Console.WriteLine("Intervalo (75,100]");
        else
            Console.WriteLine("Fora de intervalo");
    }
}