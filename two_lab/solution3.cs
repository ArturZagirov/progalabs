using System;

namespace StrawberryPicking
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите общее количество собранных килограммов клубники (A):");
            int totalStrawberries = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите количество килограммов клубники, собранных Верой (B):");
            int veraStrawberries = int.Parse(Console.ReadLine());

            if (veraStrawberries >= totalStrawberries)
            {
                Console.WriteLine("Ошибка: количество клубники, собранной Верой, не может быть больше или равно общему количеству собранной клубники.");
                return;
            }

            int valyaStrawberries = totalStrawberries - veraStrawberries;

            if (valyaStrawberries > veraStrawberries)
            {
                int difference = valyaStrawberries - veraStrawberries;
                Console.WriteLine($"Валя собрала клубники больше, чем Вера, на {difference} кг.");
            }
            else
            {
                int difference = veraStrawberries - valyaStrawberries;
                Console.WriteLine($"Вера собрала клубники больше, чем Валя, на {difference} кг.");
            }

            Console.ReadLine();
        }
    }
}