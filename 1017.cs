using System;

class URI
{
    static void Main(string[] args)
    {
        int TEMPO = Int32.Parse(System.Console.ReadLine().Trim());
        int VEL_MEDIA = Int32.Parse(System.Console.ReadLine().Trim());

        double LITROS = ((TEMPO * VEL_MEDIA) / 12.0);

        Console.WriteLine("{0:F3}", LITROS);
    }
}