using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введите стаж работы по специальности (в годах): ");
        double experience = double.Parse(Console.ReadLine());

        int coefficient;

        if (experience < 2)
        {
            coefficient = 11;
        }
        else if (experience >= 2 && experience < 5)
        {
            coefficient = 12;
        }
        else
        {
            coefficient = 13;
        }

        Console.WriteLine($"Коэффициент учета стажа работы по специальности: {coefficient}");
        Console.ReadLine();
    }
}