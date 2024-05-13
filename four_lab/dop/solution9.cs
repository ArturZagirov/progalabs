using System;

class Program
{
    static void Main()
    {
        // Ввод исходного массива
        int[] originalArray = new int[10];
        Console.WriteLine("Введите 10 двузначных чисел:");
        for (int i = 0; i < 10; i++)
        {
            originalArray[i] = int.Parse(Console.ReadLine());
        }

        // Вычисление нового массива разностей цифр
        int[] diffArray = new int[10];
        for (int i = 0; i < 10; i++)
        {
            int number = originalArray[i];
            int firstDigit = number / 10;
            int secondDigit = number % 10;
            diffArray[i] = Math.Abs(firstDigit - secondDigit);
        }

        // Вывод результата
        Console.WriteLine("Массив разностей цифр:");
        foreach (int diff in diffArray)
        {
            Console.Write(diff + " ");
        }
        Console.ReadLine();
    }
}