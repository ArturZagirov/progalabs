int sum = 0;

for (int i = -99; i <= 99; i++)
{
    if (i % 2 != 0 && i < 0)
    {
        sum += Math.Abs(i);
    }
}

Console.WriteLine($"Сумма модулей всех нечетных, отрицательных чисел от -99 до 99: {sum}");