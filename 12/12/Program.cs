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
                mas[f, h] = r.Next(-10, 15);
                Console.Write(mas[f, h] + " ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
        int sum = 0;
        for (int i = 0; i < mas.GetLength(0); i++)
        {
            for (int j = 0; j < mas.GetLength(1); j++)
            {
                if (mas[i, j] < 0)
                {
                    sum += mas[i, j];
                }

            }
        }
        Console.WriteLine($"Сума всіх від'ємних чисел масиву: {sum}");
    }
}
