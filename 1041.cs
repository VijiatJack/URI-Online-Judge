using System;

class URI
{
    static void Main(string[] args)
    {
        var ENTRADA1 = System.Console.ReadLine().Trim().Split(' ');
        double X = double.Parse(ENTRADA1[0]);
        double Y = double.Parse(ENTRADA1[1]);

        if ((X > 0) && (Y > 0))
            Console.WriteLine("Q1");
        else if ((X > 0) && (Y < 0))
            Console.WriteLine("Q4");
        else if ((X < 0) && (Y > 0))
            Console.WriteLine("Q2");
        else if ((X < 0) && (Y < 0))
            Console.WriteLine("Q3");
        else if ((X != 0) && (Y == 0))
            Console.WriteLine("Eixo X");
        else if ((X == 0) && (Y != 0))
            Console.WriteLine("Eixo Y");
        else
            Console.WriteLine("Origem");
    }
}