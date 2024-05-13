using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введите год: ");
        int year = int.Parse(Console.ReadLine());

        bool isLeapYear = IsLeapYear(year);

        if (isLeapYear)
            Console.WriteLine($"Год {year} является високосным.");
        else
            Console.WriteLine($"Год {year} не является високосным.");
    }

    static bool IsLeapYear(int year)
    {
        if (year == 0)
            return false; // Согласно современным представлениям нулевого года не было

        if (year < -45)
            return year % 4 == 0; // Для годов до введения юлианского календаря (-45) условно каждый четвертый год считается високосным

        if (year >= -45 && year <= 9)
            return false; // По приказу римского императора Октавиана Августа с 9 г. до н.э. по 9 г. н.э. были только невисокосные года

        return (year % 4 == 0 && year % 100 != 0) || year % 400 == 0; // Обычное правило для определения високосного года
    }
}