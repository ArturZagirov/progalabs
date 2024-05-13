using System;

class Program
{
    static double HyperbolicSine(double x)
    {
        return (Math.Exp(x) - Math.Exp(-x)) / 2;
    }

    static double Tangent(double x)
    {
        return Math.Tan(x);
    }

    static void Main()
    {
        double x = 1.5; // Значение x, для которого нужно вычислить функцию
        double t = 2.0; // Значение t

        double shx = HyperbolicSine(x);
        double shxMinus1 = HyperbolicSine(x - 1);
        double tangentXPlus1 = Tangent(x + 1);
        double tangentSquared = Math.Pow(Tangent(t + shxMinus1), 2);

        double y = shx * (tangentXPlus1 - tangentSquared);

        Console.WriteLine($"Значение функции y(x) при x = {x} и t = {t}: {y}");
    }
}