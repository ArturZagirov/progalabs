using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введите текущую зарплату: ");
        double salary = double.Parse(Console.ReadLine());

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

        double bonusAmount = salary * bonus;
        double newSalary = salary + bonusAmount;

        Console.WriteLine($"Надбавка к зарплате: {bonus * 100}%");
        Console.WriteLine($"Новая зарплата с учетом надбавки: {newSalary}");
        Console.ReadLine();
    }
}