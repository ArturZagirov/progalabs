using System;

class Program
{
    static void Main(string[] args)
    {
        // Ввести исходный массив из 9 элементов
        int[] originalArray = new int[9];
        Console.WriteLine("Введите 9 двузначных чисел:");
        for (int i = 0; i < 9; i++)
        {
            int number = int.Parse(Console.ReadLine());
            if (number < 10 || number > 99)
            {
                Console.WriteLine("Неверный ввод. Число должно быть двузначным.");
                i--;
                continue;
            }
            originalArray[i] = number;
        }

        // Получить новый массив, состоящий из сумм цифр элементов исходного массива
        int[] sumArray = new int[9];
        for (int i = 0; i < 9; i++)
        {
            int number = originalArray[i];
            int sum = number / 10 + number % 10;
            sumArray[i] = sum;
        }

        // Вывести результат
        Console.WriteLine("Исходный массив:");
        foreach (int number in originalArray)
        {
            Console.Write(number + " ");
        }
        Console.WriteLine("\nМассив сумм цифр:");
        foreach (int sum in sumArray)
        {
            Console.Write(sum + " ");
        }
    }
}