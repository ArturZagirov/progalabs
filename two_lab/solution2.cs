using System;

class Program
{
    static void Main(string[] args)
    {
        // Ввод данных
        Console.Write("Введите удельное сопротивление r1: ");
        double r1 = double.Parse(Console.ReadLine());

        Console.Write("Введите площадь сечения s1: ");
        double s1 = double.Parse(Console.ReadLine());

        Console.Write("Введите удельное сопротивление r2: ");
        double r2 = double.Parse(Console.ReadLine());

        Console.Write("Введите площадь сечения s2: ");
        double s2 = double.Parse(Console.ReadLine());

        Console.Write("Введите удельное сопротивление r3: ");
        double r3 = double.Parse(Console.ReadLine());

        Console.Write("Введите площадь сечения s3: ");
        double s3 = double.Parse(Console.ReadLine());

        // Вычисление сопротивлений
        double resistance1 = r1 / s1;
        double resistance2 = r2 / s2;
        double resistance3 = r3 / s3;

        // Определение проводника с максимальным сопротивлением
        double maxResistance = resistance1;
        int maxResistanceIndex = 1;

        if (resistance2 > maxResistance)
        {
            maxResistance = resistance2;
            maxResistanceIndex = 2;
        }

        if (resistance3 > maxResistance)
        {
            maxResistance = resistance3;
            maxResistanceIndex = 3;
        }

        // Вывод результата
        Console.WriteLine($"Проводник {maxResistanceIndex} имеет максимальное сопротивление: {maxResistance}");
    }
}