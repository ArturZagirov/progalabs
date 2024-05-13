class Program
{
    static void Main(string[] args)
    {
        int sumEven = 0, sumOdd = 0, sumPositive = 0, sumNegative = 0;

        for (int i = -99; i <= 99; i++)
        {
            int absValue = Math.Abs(i);

            if (i % 2 == 0)
            {
                sumEven += absValue;
            }
            else
            {
                sumOdd += absValue;
            }

            if (i >= 0)
            {
                sumPositive += absValue;
            }
            else
            {
                sumNegative += absValue;
            }
        }

        Console.WriteLine($"Сумма модулей четных чисел: {sumEven}");
        Console.WriteLine($"Сумма модулей нечетных чисел: {sumOdd}");
        Console.WriteLine($"Сумма модулей положительных чисел: {sumPositive}");
        Console.WriteLine($"Сумма модулей отрицательных чисел: {sumNegative}");
    }
}