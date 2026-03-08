using System;
class Program
{
    static void Main(string[] args)
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
        Console.WriteLine("\nЗвичайна матриця:");
        for (int f = 0; f < n; f++)
        {
            for (int h = 0; h < m; h++)
            {
                mas[f, h] = r.Next(-5, 45);
                Console.Write(mas[f, h] + " ");
            }
            Console.WriteLine();
        }
        int maxel = 0;
        int minel = 0;
        int max = mas[0, 0];
        int min = mas[0, 0];

        for (int i = 0; i < n; i++)
        {
            if (mas[i, i] > max)
            {
                max = mas[i, i];
                maxel = i;
            }

            if (mas[i, i] < min)
            {
                min = mas[i, i];
                minel = i;
            }
        }
        mas[minel, minel] = max;
        mas[maxel, maxel] = min;
        Console.WriteLine("\nМатриця з зміненими значеннями:");
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
