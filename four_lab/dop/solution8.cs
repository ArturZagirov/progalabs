using System;

class Program
{
    static void Main(string[] args)
    {
        int[] arr = new int[10];
        int sum = 0;
        int count = 0;

        Console.WriteLine("Введите 10 целых чисел:");

        for (int i = 0; i < 10; i++)
        {
            arr[i] = int.Parse(Console.ReadLine());

            if (arr[i] >= 0)
            {
                sum += arr[i];
                count++;
            }
            else
            {
                break;
            }
        }

        Console.WriteLine($"Сумма элементов до первого отрицательного числа: {sum}");
        Console.WriteLine($"Количество элементов до первого отрицательного числа: {count}");
    }
}