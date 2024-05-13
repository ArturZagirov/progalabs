using System;

class Program
{
    static void Main(string[] args)
    {
        int sum = 0;
        int count = 0;

        Console.WriteLine("Введите последовательность целых чисел, оканчивающуюся нулем:");

        while (true)
        {
            int num = int.Parse(Console.ReadLine());

            if (num == 0)
                break;

            sum += num;
            count++;
        }

        Console.WriteLine($"Сумма всех чисел последовательности: {sum}");
        Console.WriteLine($"Количество всех чисел последовательности: {count}");
    }
}