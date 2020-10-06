using System;

class URI
{

    static void Main(string[] args)
    {
        int NUMBER = Int32.Parse(System.Console.ReadLine().Trim());
        int WORKED_HOURS = Int32.Parse(System.Console.ReadLine().Trim());
        double SALARY_PER_HOUR = Double.Parse(System.Console.ReadLine().Trim());

        double SALARY = (WORKED_HOURS * SALARY_PER_HOUR);

        Console.WriteLine("NUMBER = {0}\n" +
            "SALARY = U$ {1:F2}", NUMBER, SALARY);
    }

}