using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введите размер квадратного массива n: ");
        int n = int.Parse(Console.ReadLine());

        int[,] arr = new int[n, n];

        // Заполнение массива случайными числами
        Random rand = new Random();
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                arr[i, j] = rand.Next(1, 11); // Случайные числа от 1 до 10
                Console.Write(arr[i, j] + " ");
            }
            Console.WriteLine();
        }

        int product = 1;
        for (int j = 0; j < n; j++)
        {
            product *= arr[0, j];
        }

        Console.WriteLine("Произведение элементов первой строки: " + product);
    }
}