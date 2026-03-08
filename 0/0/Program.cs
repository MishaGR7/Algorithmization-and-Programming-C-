using System;
using System.Security.Cryptography.X509Certificates;
using System.Text.RegularExpressions;
using System.Xml.Serialization;
using static System.Runtime.InteropServices.JavaScript.JSType;

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.Write("Введіть довжину сторін a і b: ");
        double sideab = double.Parse(Console.ReadLine());
        Figure figure = new Figure();
        figure.setSideAB(sideab);
        double area = figure.AREA();
        SqFigure sq = new SqFigure();
        sq.setSideAB(sideab);
        double p = sq.P();
        Console.WriteLine($"Площа заданої фігури: {area}");
        Console.WriteLine($"Периметр заданої фігури: {p}");
    }
}
class Figure
{
    private double sideab;
    public double getSideAB()
    {
        return sideab;
    }
    public void setSideAB(double side)
    {
        this.sideab = side;
    }

    public double AREA()
    {
        double p = ((sideab * 3) / 2);
        double Area = 8 * Math.Sqrt(p * (p - sideab) * (p - sideab) * (p - sideab));
        return Area;
    }
}
class SqFigure : Figure
{
    public double P()
    {
        return 8 * getSideAB();
    }
}
