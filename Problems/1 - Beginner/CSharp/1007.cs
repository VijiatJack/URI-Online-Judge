using System;

class URI
{

    static void Main(string[] args)
    {
        int A = Int32.Parse(System.Console.ReadLine().Trim());
        int B = Int32.Parse(System.Console.ReadLine().Trim());
        int C = Int32.Parse(System.Console.ReadLine().Trim());
        int D = Int32.Parse(System.Console.ReadLine().Trim());

        int DIFERENCA = (A * B - C * D);

        Console.WriteLine("DIFERENCA = {0}", DIFERENCA);
    }

}