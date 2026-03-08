using System;
using System.Security.Cryptography;
class Program
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.Unicode;
        Console.InputEncoding = System.Text.Encoding.Unicode;

        int[,] mas = new int[5, 5];
        Random r = new Random();
        for (int f = 0; f < mas.GetLength(0); f++)
        {
            for (int h = 0; h < mas.GetLength(1); h++)
            {
                mas[f, h] = r.Next(0, 15);
                Console.Write(mas[f, h] + " ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
        for (int i = 0; i < mas.GetLength(0); i++)
        {
            for (int j = 0; j < mas.GetLength(1); j++)
            {
                if (mas[i, j] == 0)
                {
                    mas[i, j] = i + 2 + j;
                }
                Console.Write(mas[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}
