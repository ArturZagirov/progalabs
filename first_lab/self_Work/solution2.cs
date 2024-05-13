using System;

namespace TriangleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите длину катета:");
            double leg1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите длину гипотенузы:");
            double hypotenuse = double.Parse(Console.ReadLine());

            double leg2 = CalculateOtherLeg(leg1, hypotenuse);
            double area = CalculateArea(leg1, leg2);

            Console.WriteLine($"Длина другого катета: {leg2}");
            Console.WriteLine($"Площадь треугольника: {area}");
        }

        static double CalculateOtherLeg(double leg1, double hypotenuse)
        {
            double leg2 = Math.Sqrt(hypotenuse * hypotenuse - leg1 * leg1);
            return leg2;
        }

        static double CalculateArea(double leg1, double leg2)
        {
            double area = 0.5 * leg1 * leg2;
            return area;
        }
    }
}