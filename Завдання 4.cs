using System;

public class InfiniteSeries
{
    public static double CalculateSum(Func<int, double> nextTerm, double tolerance)
    {
        double sum = 0.0;
        double term = nextTerm(0);
        int n = 0;

        while (Math.Abs(term) > tolerance)
        {
            sum += term;
            n++;
            term = nextTerm(n);
        }

        return sum;
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Обчислюємо суму ряду 1 + 1/2 + 1/4 + 1/8 + 1/16 + ...
        double sum1 = InfiniteSeries.CalculateSum(n => 1.0 / Math.Pow(2, n), 0.01);
        Console.WriteLine($"Сума першого ряду: {sum1:F2}");

        // Обчислюємо суму ряду 1 + 1/2! + 1/3! + 1/4! + 1/5! + ...
        double sum2 = InfiniteSeries.CalculateSum(n => 1.0 / Factorial(n), 0.01);
        Console.WriteLine($"Сума другого ряду: {sum2:F2}");

        // Обчислюємо суму ряду -1 + 1/2 - 1/4 + 1/8 - 1/16 + ...
        double sum3 = InfiniteSeries.CalculateSum(n => Math.Pow(-1, n) * 1.0 / Math.Pow(2, n), 0.01);
        Console.WriteLine($"Сума третього ряду: {sum3:F2}");
    }

    static double Factorial(int n)
    {
        double result = 1.0;

        for (int i = 1; i <= n; i++)
        {
            result *= i;
        }

        return result;
    }
}