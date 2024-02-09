using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int> { 5, 2, 10, 3, 8 };
        int maxNumber = Max(numbers);
        Console.WriteLine("Det största talet är: " + maxNumber);
    }

    static int Max(List<int> numbers)
    {
        if (numbers == null || numbers.Count == 0)
        {
            throw new ArgumentException("Listan är antingen null eller tom.");
        }

        int max = numbers[0];
        for (int i = 1; i < numbers.Count; i++)
        {
            if (numbers[i] > max)
            {
                max = numbers[i];
            }
        }
        return max;
    }
}