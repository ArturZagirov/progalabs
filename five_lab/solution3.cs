using System;

class Program
{
    static void Main()
    {
        // Ввод значения x
        Console.Write("Введите значение x: ");
        double x = Convert.ToDouble(Console.ReadLine());

        // Расчёт значения выражения
        double result = HyperbolicSin(x - 2) * Math.Tan(x + 4) + HyperbolicCos(2 * x + 3) * Math.Sqrt(3) + x * x;

        // Вывод результата
        Console.WriteLine("Значение выражения: " + result);
    }

    // Функция гиперболического синуса
    static double HyperbolicSin(double x)
    {
        return (Math.Exp(x) - Math.Exp(-x)) / 2;
    }

    // Функция гиперболического косинуса
    static double HyperbolicCos(double x)
    {
        return (Math.Exp(x) + Math.Exp(-x)) / 2;
    }
}