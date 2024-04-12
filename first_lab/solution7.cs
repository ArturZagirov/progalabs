using System;

class Program
{
    static void Main(string[] args)
    {
        double radius;
        const double PI = 3.14; // Присваиваем значение числа Пи

        // Запрашиваем у пользователя радиус круга
        Console.Write("Введите радиус круга: ");
        if (double.TryParse(Console.ReadLine(), out radius))
        {
            // Вычисляем длину окружности
            double circumference = 2 * PI * radius;

            // Вычисляем площадь круга
            double area = PI * radius * radius;

            // Выводим результаты
            Console.WriteLine("Длина окружности: " + circumference);
            Console.WriteLine("Площадь круга: " + area);
        }
        else
        {
            Console.WriteLine("Некорректный ввод радиуса.");
        }

        Console.ReadLine(); // Ожидаем нажатия клавиши для закрытия консоли
    }
}