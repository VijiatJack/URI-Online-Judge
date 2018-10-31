using System;

class URI
{
    static void Main(string[] args)
    {
        var ENTRADA = System.Console.ReadLine().Trim().Split(' ');
        double A = double.Parse(ENTRADA[0]);
        double B = double.Parse(ENTRADA[1]);
        double C = double.Parse(ENTRADA[2]);
        double D = double.Parse(ENTRADA[3]);

        if ((A == C))
        {
            if (B == D)
                Console.WriteLine("O JOGO DUROU 24 HORA(S) E 0 MINUTO(S)");
            else if (B < D)
                Console.WriteLine("O JOGO DUROU 0 HORA(S) E {0} MINUTO(S)", (D - B));
            else
                Console.WriteLine("O JOGO DUROU 23 HORA(S) E {0} MINUTO(S)", 60 - (B - D));
        }
        else if (A < C)
        {
            if (B < D)
                Console.WriteLine("O JOGO DUROU {0} HORA(S) E {1} MINUTO(S)", (C - A), (D - B));
            else
                Console.WriteLine("O JOGO DUROU {0} HORA(S) E {1} MINUTO(S)", (C - A) - 1, 60 - (B - D));
        }
        else
        {
            if (B < D)
                Console.WriteLine("O JOGO DUROU {0} HORA(S) E {1} MINUTO(S)", 24 - (A - C), (D - B));
            else
                Console.WriteLine("O JOGO DUROU {0} HORA(S) E {1} MINUTO(S)", 23 - (A - C), 60 - (B - D));
        }
    }
}