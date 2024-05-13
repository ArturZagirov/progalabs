using System;

class Program
{
    static void Main(string[] args)
    {
        int dt, d;
        double s, cost;

        Console.Write("Введите продолжительность разговора в минутах: ");
        dt = int.Parse(Console.ReadLine());

        Console.Write("Введите день недели (1-7): ");
        d = int.Parse(Console.ReadLine());

        // Определение стоимости минуты разговора
        if (d >= 6) // Если суббота или воскресенье
        {
            Console.Write("Введите стоимость минуты разговора (РФ - 0.35, ЕАЭС - 0.90, ЕС - 1.5): ");
            s = double.Parse(Console.ReadLine());
            s *= 0.9; // Применение скидки 10%
        }
        else
        {
            Console.Write("Введите стоимость минуты разговора (РФ - 0.35, ЕАЭС - 0.90, ЕС - 1.5): ");
            s = double.Parse(Console.ReadLine());
        }

        // Расчет стоимости переговоров
        cost = dt * s;

        Console.WriteLine($"Стоимость переговоров: {cost:F2} руб.");
    }
}