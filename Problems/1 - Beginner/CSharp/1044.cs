using System;

class URI
{
    static void Main(string[] args)
    {
        var ENTRADA = System.Console.ReadLine().Trim().Split(' ');
        double a = double.Parse(ENTRADA[0]);
        double b = double.Parse(ENTRADA[1]);

        if (a > b)
        {
            if (a % b == 0)
            {
                Console.WriteLine("Sao Multiplos");
            }
            else
                Console.WriteLine("Nao sao Multiplos");
        }
        else
        {
            if (b % a == 0)
            {
                Console.WriteLine("Sao Multiplos");
            }
            else
                Console.WriteLine("Nao sao Multiplos");
        }
    }
}