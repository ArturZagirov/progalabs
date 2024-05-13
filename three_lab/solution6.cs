using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Квадраты чисел от 11 до 99:");

        for (int i = 11; i <= 99; i++)
        {
            int square = i * i;
            Console.WriteLine($"{i}^2 = {square}");
        }

        Console.ReadLine();
    }
}