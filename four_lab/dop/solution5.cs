using System;

class Program
{
    static void Main()
    {
        int[] arr = new int[17];
        int sumOfDigits = 0;

        Console.WriteLine("Введите 17 двузначных целых чисел:");

        for (int i = 0; i < 17; i++)
        {
            Console.Write($"Элемент {i + 1}: ");
            arr[i] = int.Parse(Console.ReadLine());

            // Проверка, что число двузначное
            if (arr[i] < 10 || arr[i] > 99)
            {
                Console.WriteLine("Ошибка: введенное число должно быть двузначным.");
                i--;
                continue;
            }

            // Вычисление суммы цифр числа
            sumOfDigits += arr[i] / 10 + arr[i] % 10;
        }

        Console.WriteLine($"Сумма цифр массива: {sumOfDigits}");
    }
}