using System;

class Program
{
    static void Main(string[] args)
    {
        int[] originalArray = new int[30]; // Исходный массив размером 30 элементов
        int[] modulesArray = new int[30]; // Новый массив для хранения модулей

        // Заполнение исходного массива случайными значениями
        Random random = new Random();
        for (int i = 0; i < originalArray.Length; i++)
        {
            originalArray[i] = random.Next(-100, 101); // Случайные числа от -100 до 100
        }

        // Вычисление модулей значений элементов исходного массива и заполнение нового массива
        for (int i = 0; i < originalArray.Length; i++)
        {
            int value = originalArray[i];
            if (value < 0)
            {
                value = -value; // Изменение знака на положительный, если число отрицательное
            }
            modulesArray[i] = value;
        }

        // Вывод исходного и нового массивов
        Console.WriteLine("Исходный массив:");
        PrintArray(originalArray);

        Console.WriteLine("\nНовый массив с модулями значений:");
        PrintArray(modulesArray);
    }

    static void PrintArray(int[] array)
    {
        foreach (int value in array)
        {
            Console.Write(value + " ");
        }
        Console.WriteLine();
    }
}