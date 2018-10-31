using System;

class URI
{
    static void Main(string[] args)
    {
        int N = Int32.Parse(System.Console.ReadLine().Trim());

        int HORAS = (N / 3600);
        N = (N - (3600 * HORAS));
        int MINUTOS = (N / 60);
        N = (N - (60 * MINUTOS));

        Console.WriteLine("{0}:{1}:{2}", HORAS, MINUTOS, N);
    }
}