using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Трехзначные числа с четными сотнями в диапазоне от -500 до 500:");

        for (int i = -500; i <= 500; i++)
        {
            if (i >= 100 && i <= 999)
            {
                int hundreds = i / 100;
                if (hundreds % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }
            else if (i >= -999 && i <= -100)
            {
                int hundreds = Math.Abs(i / 100);
                if (hundreds % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }

        Console.ReadLine();
    }
}