class Program
{
    static void Main(string[] args)
    {
        int[,] arr = new int[7, 7];
        Random rand = new Random();

        // Заполняем массив случайными числами от -20 до 20
        for (int i = 0; i < 7; i++)
        {
            for (int j = 0; j < 7; j++)
            {
                arr[i, j] = rand.Next(-20, 21);
            }
        }

        // Выводим массив на консоль
        Console.WriteLine("Исходный массив:");
        PrintArray(arr);

        int sum = 0;

        // Находим сумму модулей отрицательных нечетных элементов
        for (int i = 0; i < 7; i++)
        {
            for (int j = 0; j < 7; j++)
            {
                if (arr[i, j] < 0 && Math.Abs(arr[i, j]) % 2 == 1)
                {
                    sum += Math.Abs(arr[i, j]);
                }
            }
        }

        Console.WriteLine($"Сумма модулей отрицательных нечетных элементов: {sum}");
    }

    static void PrintArray(int[,] arr)
    {
        for (int i = 0; i < 7; i++)
        {
            for (int j = 0; j < 7; j++)
            {
                Console.Write("{0,4}", arr[i, j]);
            }
            Console.WriteLine();
        }
    }
}