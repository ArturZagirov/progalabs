using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите длины трех сторон треугольника:");

        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double c = double.Parse(Console.ReadLine());

        double p = (a + b + c) / 2; // Полупериметр
        double area = Math.Sqrt(p * (p - a) * (p - b) * (p - c)); // Формула Герона

        Console.WriteLine($"Площадь треугольника со сторонами {a}, {b} и {c} равна {area}");
    }
}