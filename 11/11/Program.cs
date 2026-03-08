using System;
class Program
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.Unicode;
        Console.InputEncoding = System.Text.Encoding.Unicode;
        Console.Write("Введіть розмірність масиву: ");
        int n;
        n = Convert.ToInt32(Console.ReadLine());
        int[] arr = new int[n];
        int i;
        Random r = new Random();
        for (i = 0; i < n; i++)
        {
            arr[i] = r.Next(-39, 50);
        }
        for (i = 0; i < n; i++)
        {
            Console.Write(arr[i] + " ");
        }
        Console.WriteLine();
        Array.Sort(arr);
        for (int j = 0; j < n; j++)
        {
            Console.Write(arr[j] + " ");
        }
    }
}
