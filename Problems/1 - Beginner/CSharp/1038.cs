using System;

class URI
{

    static void Main(string[] args)
    {

        double[] PRECOS;

        PRECOS = new double[6];
        PRECOS[1] = 4.00;
        PRECOS[2] = 4.50;
        PRECOS[3] = 5.00;
        PRECOS[4] = 2.00;
        PRECOS[5] = 1.50;

        var ENTRADA = System.Console.ReadLine().Trim().Split(' ');
        int CODIGO = Int32.Parse(ENTRADA[0]);
        int QNT = Int32.Parse(ENTRADA[1]);

        double VALOR = PRECOS[CODIGO];
        double TOTAL = VALOR * QNT;

        Console.WriteLine("Total: R$ {0:F2}", TOTAL);
    }
}