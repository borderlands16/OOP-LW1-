using System;

class Program
{
    delegate bool IntPredicate(int n); // оголошення делегата

    static void Main()
    {
        int[] numbers = { 3, 14, 21, 33, 56, 63, 72, 81, 91, 105 };
        IntPredicate divisibleBy3 = new IntPredicate(IsDivisibleBy3);
        IntPredicate divisibleBy7 = new IntPredicate(IsDivisibleBy7);
        // передаємо делегати як аргументи методу FindNumbers
        int[] divisibleBy3Numbers = FindNumbers(numbers, divisibleBy3);
        int[] divisibleBy7Numbers = FindNumbers(numbers, divisibleBy7);
        Console.WriteLine("Числа, що діляться на 3: {0}", string.Join(", ", divisibleBy3Numbers));
        Console.WriteLine("Числа, що діляться на 7: {0}", string.Join(", ", divisibleBy7Numbers));
    }

    static int[] FindNumbers(int[] numbers, IntPredicate predicate)
    {
        int[] result = new int[numbers.Length];
        int count = 0;
        foreach (int n in numbers)
        {
            if (predicate(n))
            {
                result[count] = n;
                count++;
            }
        }
        Array.Resize(ref result, count); // зменшуємо розмір масиву до кількості знайдених чисел
        return result;
    }

    static bool IsDivisibleBy3(int n)
    {
        return n % 3 == 0;
    }

    static bool IsDivisibleBy7(int n)
    {
        return n % 7 == 0;
    }
}
