using System;

class Program
{
    static void Main(string[] args)
    {
        int[] arr = new int[14];
        int evenCount = 0;

        // Ввод массива
        Console.WriteLine("Введите 14 целых чисел:");
        for (int i = 0; i < 14; i++)
        {
            Console.Write($"Элемент {i + 1}: ");
            arr[i] = int.Parse(Console.ReadLine());
        }

        // Подсчет четных элементов
        foreach (int num in arr)
        {
            if (num % 2 == 0)
            {
                evenCount++;
            }
        }

        Console.WriteLine($"Количество четных элементов в массиве: {evenCount}");
    }
}