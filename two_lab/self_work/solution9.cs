using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введите первое число: ");
        double num1 = double.Parse(Console.ReadLine());

        Console.Write("Введите второе число: ");
        double num2 = double.Parse(Console.ReadLine());

        Console.Write("Введите третье число: ");
        double num3 = double.Parse(Console.ReadLine());

        double max = num1;

        if (num2 > max)
            max = num2;

        if (num3 > max)
            max = num3;

        Console.WriteLine($"Наибольшее число: {max}");
        Console.ReadKey();
    }
}