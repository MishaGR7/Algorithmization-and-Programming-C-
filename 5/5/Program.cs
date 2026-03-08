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
            Console.WriteLine("Введiть номер трамваю");
            s = (Console.ReadLine());
        }
        while (!Int32.TryParse(s, out d));
        Console.WriteLine("Введений номер трамваю: " + d.ToString());
        switch (d)
        {
            case 1:
                Console.WriteLine("Перший трамвай");
                Console.WriteLine("Кінцева зупинка - Михайлівська Борщагівка ");
                break;
            case 2:
                Console.WriteLine("Другий трамвай");
                Console.WriteLine("Кінцева зупинка - Пр. Академіка Корольова");
                break;
            case 3:
                Console.WriteLine("Третій трамвай");
                Console.WriteLine("Кінцева зупинка - Станція Ромена Роллана");
                break;
            case 4:
                Console.WriteLine("Четвертий трамвай");
                Console.WriteLine("Кінцева зупинка - Cтанція Троєщина-2");
                break;
        }
    }
}
