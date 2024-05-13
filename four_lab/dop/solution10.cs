using System;

class Program
{
    static void Main(string[] args)
    {
        // Генерация массива случайных целых чисел
        int[] arr = new int[20];
        Random rand = new Random();
        for (int i = 0; i < 20; i++)
        {
            arr[i] = rand.Next(-10000, 10001);
        }

        // Вывод массива
        Console.WriteLine("Исходный массив:");
        foreach (int num in arr)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine();

        // Подсчет количества пар элементов с нечетной положительной суммой
        int count = 0;
        for (int i = 0; i < 19; i++)
        {
            int sum = arr[i] + arr[i + 1];
            if (sum > 0 && sum % 2 != 0)
            {
                count++;
            }
        }

        // Вывод результата
        Console.WriteLine("Количество пар элементов с нечетной положительной суммой: " + count);
    }
}