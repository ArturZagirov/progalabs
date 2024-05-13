using System;

class Program
{
    static void Main(string[] args)
    {
        // Инициализируем массив вещественных чисел
        double[] Z = { 1.2, 3.4, 5.6, 7.8, 9.0, 2.3, 4.5, 6.7, 8.9, 1.1, 3.3, 5.5, 7.7, 9.9, 2.2, 4.4 };

        // Вычисляем сумму элементов с четными индексами
        double evenIndexSum = 0;
        for (int i = 0; i < Z.Length; i += 2)
        {
            evenIndexSum += Z[i];
        }

        // Вычисляем сумму элементов, индексы которых кратны трем
        double multipleOfThreeIndexSum = 0;
        for (int i = 0; i < Z.Length; i += 3)
        {
            multipleOfThreeIndexSum += Z[i];
        }

        // Вычисляем разность между суммами
        double difference = evenIndexSum - multipleOfThreeIndexSum;

        // Выводим результат
        Console.WriteLine("Разность между суммой элементов с четными индексами и суммой элементов, индексы которых кратны трем: " + difference);
    }
}