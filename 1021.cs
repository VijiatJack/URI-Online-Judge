using System;

class URI
{
    static void Main(string[] args)
    {
        //DATA INPUT
        String VALOR_REAL = System.Console.ReadLine().Trim();
        double VALOR_INICIAL = Double.Parse(VALOR_REAL);
        var SEPARADOR = VALOR_REAL.Split('.');
        int VALOR = Int32.Parse(SEPARADOR[0]);
        int CENTAVOS = Int32.Parse(SEPARADOR[1]);

        //BANKNOTES COUNT
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

        //COINS COUNT
        int UM = VALOR;
        int MEIO = CENTAVOS / 50;
        CENTAVOS = CENTAVOS - (50 * MEIO);
        int QUARTO = CENTAVOS / 25;
        CENTAVOS = CENTAVOS - (25 * QUARTO);
        int DECIMO = CENTAVOS / 10;
        CENTAVOS = CENTAVOS - (10 * DECIMO);
        int CINCOC = CENTAVOS / 5;
        CENTAVOS = CENTAVOS - (5 * CINCOC);
        int UMC = CENTAVOS;

        //PRINT
        Console.WriteLine("NOTAS:\n" +
            "{0} nota(s) de R$ 100.00\n" +
            "{1} nota(s) de R$ 50.00\n" +
            "{2} nota(s) de R$ 20.00\n" +
            "{3} nota(s) de R$ 10.00\n" +
            "{4} nota(s) de R$ 5.00\n" +
            "{5} nota(s) de R$ 2.00\n" +
            "MOEDAS:\n" +
            "{6} moeda(s) de R$ 1.00\n" +
            "{7} moeda(s) de R$ 0.50\n" +
            "{8} moeda(s) de R$ 0.25\n" +
            "{9} moeda(s) de R$ 0.10\n" +
            "{10} moeda(s) de R$ 0.05\n" +
            "{11} moeda(s) de R$ 0.01",
            CEM, CINQUENTA, VINTE, DEZ, CINCO, DOIS,
            UM, MEIO, QUARTO, DECIMO, CINCOC, UMC);
    }
}