using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введите количество учащихся: ");
        int n = int.Parse(Console.ReadLine());

        double sum = 0;
        for (int i = 0; i < n; i++)
        {
            Console.Write($"Введите рост учащегося {i + 1}: ");
            double height = double.Parse(Console.ReadLine());
            sum += height;
        }

        double averageHeight = sum / n;
        Console.WriteLine($"Средний рост учащихся в классе: {averageHeight:F2} см");
    }
}