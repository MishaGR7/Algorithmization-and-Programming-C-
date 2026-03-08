using System;
using System.Security.Cryptography;
class Program
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.Unicode;
        Console.InputEncoding = System.Text.Encoding.Unicode;
        int n, m;
        while (true)
        {
            Console.Write("N= ");
            if (int.TryParse(Console.ReadLine(), out n) && n > 0)
            {
                break;
            }
            else
            {
                Console.WriteLine("Введіть коректне значення");
            }
        }
        while (true)
        {
            Console.Write("M= ");
            if (int.TryParse(Console.ReadLine(), out m) && m > 0)
            {
                break;
            }
            else
            {
                Console.WriteLine("Введіть коректне значення");
            }
        }
        int[,] mas = new int[n, m];
        Random r = new Random();
        for (int f = 0; f < n; f++)
        {
            for (int h = 0; h < m; h++)
            {
                mas[f, h] = r.Next(-5, 45);
                Console.Write(mas[f, h] + " ");
            }
            Console.WriteLine();
        }
        int[] arr = new int[m];
        Console.WriteLine();
        for (int i = 0; i < m; i++)
        {
            arr[i] = mas[0, i];
        }
        for (int i = 0; i < m; i++)
        {
            Console.Write(arr[i] + " ");
        }
        Console.WriteLine();
        for (int i = 0; i < m; i++)
        {
            mas[0, i] = mas[2, i];

        }
        for (int i = 0; i < m; i++)
        {
            mas[2, i] = arr[i];

        }
        Console.WriteLine();
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {

                Console.Write(mas[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}
