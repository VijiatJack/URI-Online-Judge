using System;

class URI
{
    static void Main(string[] args)
    {
        var ENTRADA = System.Console.ReadLine().Trim().Split(' ');
        double[] VALORES = new double[3];

        VALORES[0] = double.Parse(ENTRADA[0]);
        VALORES[1] = double.Parse(ENTRADA[1]);
        VALORES[2] = double.Parse(ENTRADA[2]);

        Array.Sort(VALORES);
        Array.Reverse(VALORES);

        //A, B and C are used just to simplify the code visualization.
        double A = VALORES[0];
        double B = VALORES[1];
        double C = VALORES[2];

        if (A >= (B + C))
            Console.WriteLine("NAO FORMA TRIANGULO");
        else
        {
            if ((Math.Pow(A, 2.0)) == ((Math.Pow(B, 2.0)) + (Math.Pow(C, 2.0))))
                Console.WriteLine("TRIANGULO RETANGULO");
            if ((Math.Pow(A, 2.0)) > ((Math.Pow(B, 2.0)) + (Math.Pow(C, 2.0))))
                Console.WriteLine("TRIANGULO OBTUSANGULO");
            if ((Math.Pow(A, 2.0)) < ((Math.Pow(B, 2.0)) + (Math.Pow(C, 2.0))))
                Console.WriteLine("TRIANGULO ACUTANGULO");
            if ((A == B) && (B == C))
                Console.WriteLine("TRIANGULO EQUILATERO");
            if (((A == B) && (A != C)) || ((A == C) && (A != B)) || ((B == C) && (A != B)))
                Console.WriteLine("TRIANGULO ISOSCELES");
        }
    }
}