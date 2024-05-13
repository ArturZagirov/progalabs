using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введите число: ");
        int number = int.Parse(Console.ReadLine());

        List<int> divisors = FindDivisors(number);

        Console.WriteLine($"Делители числа {number}:");
        foreach (int divisor in divisors)
        {
            Console.Write(divisor + " ");
        }
        Console.WriteLine();
    }

    static List<int> FindDivisors(int number)
    {
        List<int> divisors = new List<int>();

        for (int i = 1; i <= Math.Abs(number); i++)
        {
            if (number % i == 0)
            {
                divisors.Add(i);
            }
        }

        return divisors;
    }
}