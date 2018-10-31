using System;

class URI
{

    static void Main(string[] args)
    {
        string NOME = System.Console.ReadLine().Trim();
        double SALARIO = Double.Parse(System.Console.ReadLine().Trim());
        double VENDAS_MES = Double.Parse(System.Console.ReadLine().Trim());

        double TOTAL = (SALARIO + (VENDAS_MES * 0.15));

        Console.WriteLine("TOTAL = R$ {0:F2}", TOTAL);
    }

}