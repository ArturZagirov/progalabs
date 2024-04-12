using System;

namespace TriangleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите длину катета треугольника:");
            double cathetus1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите длину гипотенузы треугольника:");
            double hypotenuse = double.Parse(Console.ReadLine());

            double cathetus2 = CalculateSecondCathetus(cathetus1, hypotenuse);
            double area = CalculateTriangleArea(cathetus1, cathetus2);

            Console.WriteLine($"Второй катет: {cathetus2}");
            Console.WriteLine($"Площадь треугольника: {area}");
        }

        static double CalculateSecondCathetus(double cathetus1, double hypotenuse)
        {
            double cathetus2 = Math.Sqrt(hypotenuse * hypotenuse - cathetus1 * cathetus1);
            return cathetus2;
        }

        static double CalculateTriangleArea(double cathetus1, double cathetus2)
        {
            double area = 0.5 * cathetus1 * cathetus2;
            return area;
        }
    }
}