using System;

class Program
{
    static void Main(string[] args)
    {
        // Примерные значения. Можете изменить и добавить нужные числа
        int[] numbers = { 5, 7, 8, 9, 4 };

        foreach (int number in numbers)
        {
            Console.WriteLine($"Факториал {number}! = {Fact(number)}");
            Console.WriteLine($"Двойной факториал {number}!! = {Fact2(number)}");
        }
    }

    // Функция для вычисления факториала n!
    static int Fact(int n)
    {
        if (n == 0)
            return 1;
        else
            return n * Fact(n - 1);
    }

    // Функция для вычисления двойного факториала n!!
    static int Fact2(int n)
    {
        if (n == 0 || n == 1)
            return 1;
        else
            return n * Fact2(n - 2);
    }
}