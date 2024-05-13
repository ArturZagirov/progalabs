using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введите скорость ветра (м/с): ");
        double windSpeed = double.Parse(Console.ReadLine());

        string windDescription;

        if (windSpeed >= 1 && windSpeed <= 4)
        {
            windDescription = "слабый";
        }
        else if (windSpeed >= 5 && windSpeed <= 10)
        {
            windDescription = "умеренный";
        }
        else if (windSpeed >= 9 && windSpeed <= 18)
        {
            windDescription = "сильный";
        }
        else if (windSpeed > 19)
        {
            windDescription = "ураганный";
        }
        else
        {
            windDescription = "штиль";
        }

        Console.WriteLine($"При скорости ветра {windSpeed} м/с, ветер считается {windDescription}.");
        Console.ReadLine();
    }
}