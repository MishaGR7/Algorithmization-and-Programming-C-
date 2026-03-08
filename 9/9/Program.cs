using System;
class Program
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.Unicode;
        Console.InputEncoding = System.Text.Encoding.Unicode;
        int n;
        while (true)
        {
            Console.Write("Введіть розмірність масиву: ");
            if (int.TryParse(Console.ReadLine(), out n) && n > 0)
            {
                break;
            }
            else
            {
                Console.WriteLine("Введіть коректне значення");
            }

        }
        int[] arr = new int[n];
        int i;
        Random r = new Random();
        for (i = 0; i < n; i++)
        {
            arr[i] = r.Next(1, 15);
        }
        for (i = 0; i < n; i++)
        {
            Console.Write(arr[i] + " ");
        }
        Console.WriteLine();
        for (int j = 0; j < n; j++)
        {
            if (arr[j] < 5)
            {
                arr[j] = 0;
            }
        }
        for (int k = 0; k < n; k++)
        {
            {
                Console.Write(arr[k] + " ");
            }
        }
    }
}
