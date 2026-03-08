using System;

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.Unicode;
        Console.InputEncoding = System.Text.Encoding.Unicode;
        int n;
        string s;
        do
        {
            Console.WriteLine("Введіть значення n (n > 0): ");
            s = Console.ReadLine();
        }
        while (!Int32.TryParse(s, out n));
        if (n > 0)
        {
            double sum = 0.0;

            for (double i = 1; i <= n; i++)
            {
                sum += i / (i + 1);
            }

            Console.WriteLine($"Результат: {sum}");
        }
        else if (n < 0)
        {
            Console.WriteLine("n має бути більше 0.");
        }
    }
}
