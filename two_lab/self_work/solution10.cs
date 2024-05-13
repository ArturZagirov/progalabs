using System;

namespace CoinNamingProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число от 1 до 99: ");
            int number = int.Parse(Console.ReadLine());

            if (number >= 1 && number <= 99)
            {
                string coinName = GetCoinName(number);
                Console.WriteLine($"{number} {coinName}");
            }
            else
            {
                Console.WriteLine("Число должно быть в диапазоне от 1 до 99.");
            }

            Console.ReadLine();
        }

        static string GetCoinName(int number)
        {
            int lastDigit = number % 10;
            int secondToLastDigit = (number / 10) % 10;

            if (secondToLastDigit == 1)
                return "копеек";

            switch (lastDigit)
            {
                case 1:
                    return "копейка";
                case 2:
                case 3:
                case 4:
                    return "копейки";
                default:
                    return "копеек";
            }
        }
    }
}