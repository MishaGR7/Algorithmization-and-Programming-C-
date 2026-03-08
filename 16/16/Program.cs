using System.Text;

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.Unicode;
        Console.InputEncoding = System.Text.Encoding.Unicode;
        string s1 = "Перше речення яке має бути окличним. Друге теке речення. Третє окличне речення.";
        Console.WriteLine(s1);
        string s2;
        s2 = s1.Replace(".", "!").Replace("?", "!");
        Console.WriteLine(s2);


        Console.WriteLine("Введіть слово:");
        string word = Console.ReadLine();
        string word1 = "";
        for (int i = word.Length - 1; i >= 0; i--)
        {
            word1 += word[i];
        }
        Console.WriteLine($"Обернене слово: {word1}");

        Console.OutputEncoding = System.Text.Encoding.Unicode;
        Console.InputEncoding = System.Text.Encoding.Unicode;
        Console.WriteLine("Введіть речення:");
        string sentence = Console.ReadLine();
        int n = 0;
        for (int i = 0; i < sentence.Length; i++)
        {
            if (sentence[i] == ' ')
                n++;
        }
        Console.WriteLine($"Кількість пробілів у реченні: {n}");


        string s3 = "Jon";
        string s4 = "Snow";
        int n2 = s2.Length;
        Console.WriteLine($"Ім'я: {s1}");
        Console.WriteLine($"Кількість букв в прізвищі: {n}");
        Console.WriteLine("===========================================");

        Console.Write("Введіть прізвище, ім'я, по батькові:");
        string fullname = Console.ReadLine();
        StringBuilder sb = new StringBuilder(fullname);
        Console.WriteLine($"Довжина рядка: {sb.Length}");
        Console.WriteLine($"Ємність рядка: {sb.Capacity}");
        string[] words = fullname.Split(' ');
        string firstname = words[0];
        string lastname = words[1];
        string fathername = words[2];
        int c = -1;
        char secondsym = firstname[1];
        foreach (char e in fullname)
        {
            if (e == secondsym)
            {
                c++;
            }
        }
        Console.WriteLine();

        foreach (char i in firstname)
        {
            StringBuilder strbl = new StringBuilder();
            strbl.Append(i);
            strbl.Append('-');
            Console.Write(strbl.ToString());
        }
        foreach (char i in lastname)
        {
            StringBuilder strbl = new StringBuilder();
            strbl.Append(i);
            strbl.Append('-');
            Console.Write(strbl.ToString());
        }
        StringBuilder stringBuilder = new StringBuilder(fathername);
        char[] letters = { 'а', 'е', 'і', 'ї', 'о', 'и', 'ю', 'я' };
        for (int i = 0; i < stringBuilder.Length; i++)
        {
            char ch = stringBuilder[i];
            bool letter = letters.Contains(ch);
            if (letter)
            {
                stringBuilder[i] = (char)(ch - 'а' + 'А');
            }
        }
        Console.Write(stringBuilder.ToString());
        Console.WriteLine();


        string sentence2 = Console.ReadLine();
        string sentenceLoc = "";
        Console.Write("Введіть ключ:");
        string sentenceUnloc = "";
        int key;
        if (int.TryParse(Console.ReadLine(), out key) && key == 123)
        {
            foreach (char a in sentence)
            {
                sentenceLoc += (char)(a + key);
            }
            Console.WriteLine($"Зашифроване речення: {sentenceLoc}");
            foreach (char a in sentenceLoc)
            {
                sentenceUnloc += (char)(a - key);
            }
            Console.WriteLine($"Розшофровне речення: {sentenceUnloc}");
        }
        else
        {
            Console.WriteLine("Введіть коректний ключ");
        }

    }
}
