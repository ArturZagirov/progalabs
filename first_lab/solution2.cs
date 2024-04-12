using System;

namespace ArithmeticOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите первое число a: ");
            double a = double.Parse(Console.ReadLine());

            Console.Write("Введите второе число b: ");
            double b = double.Parse(Console.ReadLine());

            double sum = a + b;
            double difference = a - b;
            double product = a * b;
            double quotient = a / b;

            Console.WriteLine($"Сумма чисел {a} и {b}: {sum}");
            Console.WriteLine($"Разность чисел {a} и {b}: {difference}");
            Console.WriteLine($"Произведение чисел {a} и {b}: {product}");
            Console.WriteLine($"Частное чисел {a} и {b}: {quotient}");

            Console.ReadLine();
        }
    }
}