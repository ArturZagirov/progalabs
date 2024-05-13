using System;

class Program
{
    static void Main(string[] args)
    {
        const int n = 5; // Размер матрицы
        double[,] matrix = new double[n, n]; // Создаем матрицу

        // Ввод элементов матрицы
        Console.WriteLine("Введите элементы матрицы:");
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write($"matrix[{i},{j}] = ");
                matrix[i, j] = double.Parse(Console.ReadLine());
            }
        }

        // Находим наименьший элемент на побочной диагонали
        double minElement = matrix[0, n - 1];
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (i + j == n - 1)
                {
                    if (matrix[i, j] < minElement)
                    {
                        minElement = matrix[i, j];
                    }
                }
            }
        }

        Console.WriteLine($"Наименьший элемент на побочной диагонали: {minElement}");
    }
}