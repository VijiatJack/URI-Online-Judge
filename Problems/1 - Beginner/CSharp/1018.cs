using System;

class URI
{
    static void Main(string[] args)
    {
        int VALOR = Int32.Parse(System.Console.ReadLine().Trim());
        int VALOR_INICIAL = VALOR;

        int CEM = VALOR / 100;
        VALOR = VALOR - (100 * CEM);
        int CINQUENTA = VALOR / 50;
        VALOR = VALOR - (50 * CINQUENTA);
        int VINTE = VALOR / 20;
        VALOR = VALOR - (20 * VINTE);
        int DEZ = VALOR / 10;
        VALOR = VALOR - (10 * DEZ);
        int CINCO = VALOR / 5;
        VALOR = VALOR - (5 * CINCO);
        int DOIS = VALOR / 2;
        VALOR = VALOR - (2 * DOIS);
        int UM = VALOR;

        Console.WriteLine("{0}\n" +
            "{1} nota(s) de R$ 100,00\n" +
            "{2} nota(s) de R$ 50,00\n" +
            "{3} nota(s) de R$ 20,00\n" +
            "{4} nota(s) de R$ 10,00\n" +
            "{5} nota(s) de R$ 5,00\n" +
            "{6} nota(s) de R$ 2,00\n" +
            "{7} nota(s) de R$ 1,00",
            VALOR_INICIAL, CEM, CINQUENTA, VINTE, DEZ, CINCO, DOIS, UM);
    }
}