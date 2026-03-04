using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a positive integer: ");
        string input = Console.ReadLine(); // Input is stored as a string
        string input2 = Console.ReadLine(); // Input is stored as a string
        int number1;
        int number2;
        if (int.TryParse(input, out number1) && number1 > 0 && int.TryParse(input2, out number2) && number2 > 0)
        {
            Console.WriteLine($"You entered the positive integers: {number1} and {number2}");
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a positive integer.");
        }

        int combined = number1 + number2;

        int recursiveSum = RecursiveSum(number1, number2);
        Console.WriteLine($"The result is {recursiveSum}");
    }

    static int RecursiveSum(int a, int b)
    {
        int n = a+b;
        if(n <= 9)
        {
            return n;
        }
        else
        {
            return RecursiveSum((n % 10), (n / 10));
        }
    }
}
