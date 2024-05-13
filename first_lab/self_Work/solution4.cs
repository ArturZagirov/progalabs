using System;

namespace TriangleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите длину первого катета: ");
            double side1 = double.Parse(Console.ReadLine());

            Console.Write("Введите длину гипотенузы: ");
            double hypotenuse = double.Parse(Console.ReadLine());

            double side2 = CalculateOtherSide(side1, hypotenuse);
            double area = CalculateArea(side1, side2);

            Console.WriteLine($"Второй катет: {side2}");
            Console.WriteLine($"Площадь треугольника: {area}");
        }

        static double CalculateOtherSide(double side1, double hypotenuse)
        {
            double side2 = Math.Sqrt(hypotenuse * hypotenuse - side1 * side1);
            return side2;
        }

        static double CalculateArea(double side1, double side2)
        {
            double area = 0.5 * side1 * side2;
            return area;
        }
    }
}