using System;

namespace EquationSolver
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите значение a: ");
            double a = double.Parse(Console.ReadLine());

            Console.Write("Введите значение b: ");
            double b = double.Parse(Console.ReadLine());

            double x = SolveEquation(a, b);
            Console.WriteLine($"Корень уравнения x/a+b-12=0 при a={a} и b={b} равен {x}");
        }

        static double SolveEquation(double a, double b)
        {
            if (a == 0)
            {
                throw new DivideByZeroException("Значение a не может быть равно нулю.");
            }

            return (12 - b) * a;
        }
    }
}