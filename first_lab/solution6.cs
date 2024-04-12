using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введите расстояние в сантиметрах: ");
        int L = int.Parse(Console.ReadLine());

        int metry = L / 100; // Деление нацело, так как L и 100 - целые числа

        Console.WriteLine($"Количество полных метров: {metry}");
    }
}