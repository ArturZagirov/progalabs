using System;

class Program
{
    static void Main(string[] args)
    {
        const double G = 6.67e-11; // Гравитационная постоянная

        Console.Write("Введите массу первого тела (m1) в кг: ");
        double m1 = double.Parse(Console.ReadLine());

        Console.Write("Введите массу второго тела (m2) в кг: ");
        double m2 = double.Parse(Console.ReadLine());

        Console.Write("Введите расстояние между телами (r) в км: ");
        double r = double.Parse(Console.ReadLine());

        double r2 = r * 1000; // Переводим километры в метры
        double force = G * m1 * m2 / (r2 * r2); // Вычисляем силу притяжения

        Console.WriteLine($"Сила притяжения между телами: {force:F2} Н");
    }
}