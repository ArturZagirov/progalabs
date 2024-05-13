using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введите размерность квадратного массива: ");
        int n = int.Parse(Console.ReadLine());

        int[,] arr = new int[n, n];

        // Заполнение массива случайными числами
        Random rand = new Random();
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                arr[i, j] = rand.Next(1, 10);
                Console.Write(arr[i, j] + " ");
            }
            Console.WriteLine();
        }

        int sum = 0;
        for (int i = 0; i < n; i++)
        {
            sum += arr[i, n - 1];
        }

        Console.WriteLine("Сумма элементов последнего столбца: " + sum);
    }
}