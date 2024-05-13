using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введите цену 1 кг конфет: ");
        double pricePerKg = double.Parse(Console.ReadLine());

        Console.Write("Введите максимальное количество кг: ");
        int maxKg = int.Parse(Console.ReadLine());

        Console.WriteLine("Стоимость конфет:");

        for (int kg = 1; kg <= maxKg; kg++)
        {
            double cost = pricePerKg * kg;
            Console.WriteLine($"{kg} кг: {cost:F2}");
        }

        Console.ReadLine();
    }
}