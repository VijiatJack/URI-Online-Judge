using System;

class URI
{

    static void Main(string[] args)
    {
        string ENTRADA1 = System.Console.ReadLine().Trim();

        var DIVISOR1 = ENTRADA1.Split(' ');

        int A = Int32.Parse(DIVISOR1[0].Trim());
        int B = Int32.Parse(DIVISOR1[1].Trim());
        int C = Int32.Parse(DIVISOR1[2].Trim());

        int MAIORAB = ((A + B + Math.Abs(A - B)) / 2);
        int MAIORMC = ((MAIORAB + C + Math.Abs(MAIORAB - C)) / 2);

        Console.WriteLine("{0} eh o maior", MAIORMC);
    }
}