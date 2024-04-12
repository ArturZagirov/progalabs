using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введите первое число (a): ");
        double a = double.Parse(Console.ReadLine());

        Console.Write("Введите второе число (b): ");
        double b = double.Parse(Console.ReadLine());

        Console.Write("Введите третье число (c): ");
        double c = double.Parse(Console.ReadLine());

        double averageOfSquares = (Math.Pow(a, 2) + Math.Pow(b, 2) + Math.Pow(c, 2)) / 3;

        Console.WriteLine($"Среднее арифметическое квадратов чисел {a}, {b} и {c} равно {averageOfSquares}");
    }
}