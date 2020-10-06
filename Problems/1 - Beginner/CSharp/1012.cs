using System;

class URI
{
    static void Main(string[] args)
    {
        string ENTRADA = System.Console.ReadLine().Trim();

        var DIVISOR = ENTRADA.Split(' ');

        double A = Double.Parse(DIVISOR[0].Trim());
        double B = Double.Parse(DIVISOR[1].Trim());
        double C = Double.Parse(DIVISOR[2].Trim());


        double TRIANGULO = (A * C / 2);
        double CIRCULO = (3.14159 * (C * C));
        double TRAPEZIO = (((A + B) * C) / 2);
        double QUADRADO = (B * B);
        double RETANGULO = (A * B);

        Console.WriteLine("TRIANGULO: {0:F3}\n" +
            "CIRCULO: {1:F3}\n" +
            "TRAPEZIO: {2:F3}\n" +
            "QUADRADO: {3:F3}\n" +
            "RETANGULO: {4:F3}",
            TRIANGULO, CIRCULO, TRAPEZIO, QUADRADO, RETANGULO);
    }
}