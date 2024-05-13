using System;

class Program
{
    static double Discriminant(double a, double b, double c)
    {
        return b * b - 4 * a * c;
    }

    static void Main(string[] args)
    {
        Console.WriteLine("Введите коэффициенты квадратного уравнения ax^2 + bx + c = 0:");
        Console.Write("a = ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("b = ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("c = ");
        double c = double.Parse(Console.ReadLine());

        if (a == 0)
        {
            Console.WriteLine("Это не квадратное уравнение, так как a = 0.");
            return;
        }

        double d = Discriminant(a, b, c);
        Console.WriteLine($"Дискриминант (D) = {d}");

        if (d > 0)
        {
            double x1 = (-b + Math.Sqrt(d)) / (2 * a);
            double x2 = (-b - Math.Sqrt(d)) / (2 * a);
            Console.WriteLine($"Уравнение имеет два действительных корня: x1 = {x1}, x2 = {x2}");
        }
        else if (d == 0)
        {
            double x = -b / (2 * a);
            Console.WriteLine($"Уравнение имеет один действительный корень: x = {x}");
        }
        else
        {
            Console.WriteLine("Уравнение не имеет действительных корней.");
        }
    }
}