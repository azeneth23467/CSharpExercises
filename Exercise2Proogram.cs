using System;

class Program
{
    static void Main(string[] args)
    {
        // 1. Ask for the grade percentage
        Console.Write("Enter your grade percentage: ");
        int percentage = int.Parse(Console.ReadLine());

        string letter = "";

        // 2. Determine the letter grade
        if (percentage >= 90)
        {
            letter = "A";
        }
        else if (percentage >= 80)
        {
            letter = "B";
        }
        else if (percentage >= 70)
        {
            letter = "C";
                  }
        else if (percentage >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        // 3. Display the letter grade
        Console.WriteLine($"Your grade is: {letter}");

        // 4. Check if the student passed
        if (percentage >= 70)
        {
            Console.WriteLine("Congratulations! You passed the course.");
        }
        else
        {
            Console.WriteLine("You did not pass this time. Keep trying!");
        }

        // 🌟 Stretch challenge (optional)
        int lastDigit = percentage % 10;
        string sign = "";
             if (letter != "A" && letter != "F") // exceptions
        {
            if (lastDigit >= 7)
            {
                sign = "+";
            }
            else if (lastDigit < 3)
            {
                sign = "-";
            }
        }
        else if (letter == "A" && lastDigit < 3)
        {
            sign = "-";
        }

        Console.WriteLine($"Your final grade is: {letter}{sign}");
    }
}