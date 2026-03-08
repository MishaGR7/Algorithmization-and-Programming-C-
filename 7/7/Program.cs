using System;

class Program
{
    static void Main(string[] args)
    {
        for (int i = 1; i <= 10; i++)
        {
            int p = i - 1;
            int n = i + 1;

            Console.WriteLine($"number: {i}");
            Console.WriteLine($"next number: {p}");
            Console.WriteLine($"previous number: {n}");
            Console.WriteLine();
        }
    }
}
