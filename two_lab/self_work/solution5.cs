using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите время разговора (от 0 до 24 часов):");
        int t = int.Parse(Console.ReadLine());

        Console.WriteLine("Введите продолжительность разговора в минутах:");
        int dt = int.Parse(Console.ReadLine());

        Console.WriteLine("Введите стоимость минуты разговора:");
        double s = double.Parse(Console.ReadLine());

        Console.WriteLine("Введите день недели (0 - воскресенье, 1 - понедельник, ..., 6 - суббота):");
        int d = int.Parse(Console.ReadLine());

        double cost = CalculateCallCost(t, dt, s, d);
        Console.WriteLine($"Стоимость переговоров: {cost:F2} руб.");
    }

    static double CalculateCallCost(int t, int dt, double s, int d)
    {
        double discount = 1.0;

        // Скидка 10% с 22 часов до 8 часов
        if (t >= 22 || t < 8)
        {
            discount *= 0.9;
        }

        // Дополнительная скидка 5% в субботу и воскресенье
        if (d == 0 || d == 6)
        {
            discount *= 0.95;
        }

        double cost = dt * s * discount;
        return cost;
    }
}