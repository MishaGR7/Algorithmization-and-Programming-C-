using System;

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.Unicode;
        Console.InputEncoding = System.Text.Encoding.Unicode;
        int d;
        string s;
        do
        {
            Console.WriteLine("Введiть номер квартири");
            s = (Console.ReadLine());
        }
        while (!Int32.TryParse(s, out d));
        Console.WriteLine("Введений номер квартири: " + d.ToString());
        switch (d)
        {
            case 1:
                Console.WriteLine("Дві кімнати");
                Console.WriteLine("Троє мешканців");
                break;
            case 2:
                Console.WriteLine("Одна кімната");
                Console.WriteLine("Троє мешканців");
                break;
            case 3:
                Console.WriteLine("Три кімнати");
                Console.WriteLine("Троє мешканців");
                break;
            case 4:
                Console.WriteLine("Дві кімнати");
                Console.WriteLine("Один мешканець");
                break;
            case 5:
                Console.WriteLine("Три кімнати");
                Console.WriteLine("П'ятеро мешканців");
                break;
            case 6:
                Console.WriteLine("Дві кімнати");
                Console.WriteLine("Четверо мешканців");
                break;
            case 7:
                Console.WriteLine("Одна кімната");
                Console.WriteLine("Двоє мешканців");
                break;
            case 8:
                Console.WriteLine("Чотири кімнати");
                Console.WriteLine("Двоє мешканців");
                break;
        }
    }
}
