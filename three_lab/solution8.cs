using System;

class Program
{
    static void Main(string[] args)
    {
        const double inchToCmRatio = 2.54; // 1 дюйм = 2.54 см

        Console.WriteLine("Таблица перевода расстояний из дюймов в сантиметры:");
        Console.WriteLine("{0,-10} {1,-10}", "Дюймы", "Сантиметры");

        for (int inches = 1; inches <= 20; inches++)
        {
            double centimeters = inches * inchToCmRatio;
            Console.WriteLine("{0,-10} {1,-10:F2}", inches, centimeters);
        }

        Console.ReadLine();
    }
}