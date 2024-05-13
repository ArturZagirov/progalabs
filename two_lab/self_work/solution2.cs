using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введите стаж работы в годах: ");
        int experience = int.Parse(Console.ReadLine());

        double bonus;

        if (experience >= 5 && experience < 10)
        {
            bonus = 0.02; // 2% надбавка
        }
        else if (experience >= 10 && experience < 20)
        {
            bonus = 0.10; // 10% надбавка
        }
        else
        {
            bonus = 0; // Нет надбавки
        }

        Console.WriteLine($"Надбавка к зарплате: {bonus * 100}%");
        Console.ReadLine();
    }
}