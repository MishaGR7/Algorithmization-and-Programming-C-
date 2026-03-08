using System;

class MainClass
{
    static void Main(string[] args)
    {
        double x, y = 0;
        x = 1.4;
        double a = (3.5 * x);
        double gama = a + x;
        if (x <= 2)
        {
            y = (4 * (x * x * x) + gama);
        }
        else
        {
            y = (x + (3 * gama)) * x;
        }
        Console.WriteLine("y=" + y);
    }
}
