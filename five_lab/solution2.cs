using System;

class TriangleAreaCalculator
{
    // Определить точку с координатами
    struct Point
    {
        public int x;
        public int y;

        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
    }

    static void Main()
    {
        // Координаты вершин треугольника ABC
        Point A = new Point(1, 3);
        Point B = new Point(4, 7);
        Point C = new Point(1, 7);

        // Вычисление длины сторон
        double AB = Length(A, B);
        double AC = Length(A, C);
        double BC = Length(B, C);

        // Определение которые из сторон являются катетами
        double[] sides = { AB, AC, BC };
        Array.Sort(sides);  // Сортировка длин сторон

        // Вычисление площади
        double area = 0.5 * sides[0] * sides[1];
        Console.WriteLine($"Площадь прямоугольного треугольника: {area}");
    }

    // Функция для вычисления длины стороны между двумя точками
    static double Length(Point p1, Point p2)
    {
        return Math.Sqrt(Math.Pow((p2.x - p1.x), 2) + Math.Pow((p2.y - p1.y), 2));
    }
}