using System;

class URI
{

    static void Main(string[] args)
    {
        int A = Int32.Parse(System.Console.ReadLine().Trim());
        int B = Int32.Parse(System.Console.ReadLine().Trim());

        int PROD = A * B;

        Console.WriteLine("PROD = {0}", PROD);
    }

}