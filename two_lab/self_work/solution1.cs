using System;

namespace DepositCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите сумму вклада: ");
            double depositAmount = double.Parse(Console.ReadLine());

            double interestRate;
            if (depositAmount < 50000)
            {
                interestRate = 0.2; // 20% годовых
            }
            else if (depositAmount < 100000)
            {
                interestRate = 0.22; // 22% годовых
            }
            else
            {
                interestRate = 0.22; // Для суммы 100000 руб. и более ставка 22%
            }

            Console.Write("Введите срок вклада (в годах): ");
            int depositTerm = int.Parse(Console.ReadLine());

            double totalPayment = CalculateTotalPayment(depositAmount, interestRate, depositTerm);
            Console.WriteLine($"Общая сумма выплаты по вкладу составит: {totalPayment:F2} руб.");
        }

        static double CalculateTotalPayment(double depositAmount, double interestRate, int depositTerm)
        {
            double totalPayment = depositAmount;
            for (int i = 0; i < depositTerm; i++)
            {
                totalPayment += totalPayment * interestRate;
            }
            return totalPayment;
        }
    }
}