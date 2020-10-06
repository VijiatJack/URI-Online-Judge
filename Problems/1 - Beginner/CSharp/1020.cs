using System;

class URI
{
    static void Main(string[] args)
    {
        int N = Int32.Parse(System.Console.ReadLine().Trim());

        int ANOS = (N / 365);
        N = (N - (365 * ANOS));
        int MESES = (N / 30);
        N = (N - (30 * MESES));

        Console.WriteLine("{0} ano(s)\n" +
            "{1} mes(es)\n" +
            "{2} dia(s)", ANOS, MESES, N);
    }
}