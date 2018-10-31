using System;

class URI
{

    static void Main(string[] args)
    {
        int DISTANCIA = Int32.Parse(System.Console.ReadLine().Trim());

        int TEMPO = (DISTANCIA * 2);

        Console.WriteLine("{0} minutos", TEMPO);
    }
}