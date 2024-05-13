using System;

namespace MonthSeason
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите номер месяца (от 1 до 12): ");
            int monthNumber;
            if (int.TryParse(Console.ReadLine(), out monthNumber) && monthNumber >= 1 && monthNumber <= 12)
            {
                string monthName;
                string season;

                switch (monthNumber)
                {
                    case 12:
                    case 1:
                    case 2:
                        season = "зима";
                        break;
                    case 3:
                    case 4:
                    case 5:
                        season = "весна";
                        break;
                    case 6:
                    case 7:
                    case 8:
                        season = "лето";
                        break;
                    default:
                        season = "осень";
                        break;
                }

                switch (monthNumber)
                {
                    case 1:
                        monthName = "Январь";
                        break;
                    case 2:
                        monthName = "Февраль";
                        break;
                    case 3:
                        monthName = "Март";
                        break;
                    case 4:
                        monthName = "Апрель";
                        break;
                    case 5:
                        monthName = "Май";
                        break;
                    case 6:
                        monthName = "Июнь";
                        break;
                    case 7:
                        monthName = "Июль";
                        break;
                    case 8:
                        monthName = "Август";
                        break;
                    case 9:
                        monthName = "Сентябрь";
                        break;
                    case 10:
                        monthName = "Октябрь";
                        break;
                    case 11:
                        monthName = "Ноябрь";
                        break;
                    case 12:
                        monthName = "Декабрь";
                        break;
                    default:
                        monthName = "";
                        break;
                }

                Console.WriteLine($"Месяц: {monthName}, Время года: {season}");
            }
            else
            {
                Console.WriteLine("Ошибка: введите число от 1 до 12.");
            }

            Console.ReadLine();
        }
    }
}