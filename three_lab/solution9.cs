using System;

namespace EvenNumbersMultiplesOfFive
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Четные числа, кратные пяти, в интервале от 2 до 100 включительно:");

            for (int i = 2; i <= 100; i++)
            {
                if (i % 2 == 0 && i % 5 == 0)
                {
                    Console.WriteLine(i);
                }
            }

            Console.WriteLine("Нажмите любую клавишу для выхода...");
            Console.ReadKey();
        }
    }
}