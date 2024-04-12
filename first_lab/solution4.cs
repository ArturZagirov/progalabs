using System;

namespace TriangleAreaCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите длину стороны a:");
            double a = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите длину стороны b:");
            double b = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите высоту h:");
            double h = double.Parse(Console.ReadLine());

            double area = CalculateTriangleArea(a, b, h);
            Console.WriteLine("Площадь треугольника: " + area);

            Console.ReadLine();
        }

        static double CalculateTriangleArea(double a, double b, double h)
        {
            return ((a + b) / 2) * h;
        }
    }
}