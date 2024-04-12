using System;

namespace FileSizeCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите размер файла в байтах: ");
            long fileSizeInBytes = long.Parse(Console.ReadLine());

            long fileSizeInKilobytes = fileSizeInBytes / 1024;

            Console.WriteLine($"Файл занимает {fileSizeInKilobytes} полных килобайтов.");
        }
    }
}