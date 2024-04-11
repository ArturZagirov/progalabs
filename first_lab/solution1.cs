using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введите объем информации в байтах: ");
        long z = long.Parse(Console.ReadLine());

        string result = ConvertSize(z);
        Console.WriteLine($"Объем информации: {result}");
    }

    static string ConvertSize(long size)
    {
        string[] units = { "Б", "КБ", "МБ", "ГБ", "ТБ", "ПБ", "ЭБ", "ЗБ", "ЙБ" };
        double mod = size;
        int order = 0;

        while (mod >= 1024 && order < units.Length - 1)
        {
            order++;
            mod = mod / 1024;
        }

        return string.Format("{0:0.##} {1}", mod, units[order]);
    }
}