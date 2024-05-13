using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введите N: ");
        int N = int.Parse(Console.ReadLine());

        Console.WriteLine("Нечетные числа, кратные 5, от 10 до " + N + ":");

        for (int i = 10; i <= N; i++)
        {
            if (i % 5 == 0 && i % 2 != 0)
            {
                Console.WriteLine(i);
            }
        }

        Console.ReadLine();
    }
}