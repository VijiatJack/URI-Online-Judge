using System;

class URI
{
    static void Main(string[] args)
    {
        var ENTRADA = System.Console.ReadLine().Trim().Split(' ');
        double A = double.Parse(ENTRADA[0]);
        double B = double.Parse(ENTRADA[1]);

        if (A < B)
            Console.WriteLine("O JOGO DUROU {0} HORA(S)", (B - A));
        else if (A == B)
            Console.WriteLine("O JOGO DUROU 24 HORA(S)");
        else
        {
            B = B + 24;
            Console.WriteLine("O JOGO DUROU {0} HORA(S)", (B - A));
        }
    }
}