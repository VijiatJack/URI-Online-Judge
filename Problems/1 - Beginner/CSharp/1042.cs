using System;

class URI
{
    static void Main(string[] args)
    {
        var ENTRADA = System.Console.ReadLine().Trim().Split(' ');
        int[] VALORES = new int[3];

        for (int i = 0; i < VALORES.Length; i++)
        {
            VALORES[i] = int.Parse(ENTRADA[i]);
        }

        int V1 = VALORES[0];
        int V2 = VALORES[1];
        int V3 = VALORES[2];

        Array.Sort(VALORES);

        for (int i = 0; i < VALORES.Length; i++)
        {
            Console.WriteLine(VALORES[i]);
        }

        Console.WriteLine();
        Console.WriteLine(V1);
        Console.WriteLine(V2);
        Console.WriteLine(V3);
    }
}