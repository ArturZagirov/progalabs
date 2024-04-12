using System;

namespace OhmsLawCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            double resistance, voltage, current;

            Console.Write("Введите значение электрического сопротивления (R) в Омах: ");
            resistance = double.Parse(Console.ReadLine());

            Console.Write("Введите значение напряжения (U) в Вольтах: ");
            voltage = double.Parse(Console.ReadLine());

            if (resistance == 0)
            {
                Console.WriteLine("Сопротивление не может быть равно нулю. Повторите ввод.");
            }
            else
            {
                current = voltage / resistance;
                Console.WriteLine($"Сила тока (I) равна: {current} Ампер");
            }

            Console.ReadLine();
        }
    }
}