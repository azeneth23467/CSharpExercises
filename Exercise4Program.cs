using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        int input = -1;

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        // Loop to ask for numbers
        while (input != 0)
        {
            Console.Write("Enter number: ");
            input = int.Parse(Console.ReadLine());

            if (input != 0)
            {
                numbers.Add(input);
            }
        }

        // Core requirements
        int sum = numbers.Sum();
        double average = numbers.Average();
        int max = numbers.Max();

        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {max}");

        // 🌟 Stretch challenge
        if (numbers.Any(n => n > 0))
        {
            int minPositive = numbers.Where(n => n > 0).Min();
            Console.WriteLine($"The smallest positive number is: {minPositive}");
        }

        numbers.Sort();
        Console.WriteLine("The sorted list is:");
        foreach (int n in numbers)
        {
            Console.WriteLine(n);
        }
    }
}
