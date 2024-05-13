using System;

class Program
{
    static void Main(string[] args)
    {
        int[] array1 = new int[10];
        int[] array2 = new int[10];
        int[] resultArray = new int[20];

        // Ввод элементов первого массива
        Console.WriteLine("Введите 10 элементов первого массива:");
        for (int i = 0; i < 10; i++)
        {
            Console.Write($"Элемент {i + 1}: ");
            array1[i] = int.Parse(Console.ReadLine());
        }

        // Ввод элементов второго массива
        Console.WriteLine("\nВведите 10 элементов второго массива:");
        for (int i = 0; i < 10; i++)
        {
            Console.Write($"Элемент {i + 1}: ");
            array2[i] = int.Parse(Console.ReadLine());
        }

        // Формирование нового массива
        for (int i = 0; i < 20; i++)
        {
            if (i % 2 == 0)
            {
                resultArray[i] = array1[i / 2 * 2 + 1]; // Элементы с нечетными индексами из первого массива
            }
            else
            {
                resultArray[i] = array2[(i - 1) / 2]; // Элементы с четными индексами из второго массива
            }
        }

        // Вывод результирующего массива
        Console.WriteLine("\nРезультирующий массив:");
        for (int i = 0; i < 20; i++)
        {
            Console.Write(resultArray[i] + " ");
        }
        Console.ReadLine();
    }
}