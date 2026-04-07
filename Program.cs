using System;

namespace SimpleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Calculator ===");

            Console.Write("Enter the first number: ");
            string firstInput = Console.ReadLine();

            if (!double.TryParse(firstInput, out double num1))
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
                return;
            }

            Console.Write("Enter an operator (+, -, *, /): ");
            string op = Console.ReadLine();

            Console.Write("Enter the second number: ");
            string secondInput = Console.ReadLine();

            if (!double.TryParse(secondInput, out double num2))
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
                return;
            }

            Console.WriteLine("\n--- Result ---");

            switch (op)
            {
                case "+":
                    Console.WriteLine($"{num1} + {num2} = {num1 + num2}");
                    break;
                case "-":
                    Console.WriteLine($"{num1} - {num2} = {num1 - num2}");
                    break;
                case "*":
                    Console.WriteLine($"{num1} * {num2} = {num1 * num2}");
                    break;
                case "/":
                    if (num2 == 0)
                    {
                        Console.WriteLine("Error: Cannot divide by zero.");
                    }
                    else
                    {
                        Console.WriteLine($"{num1} / {num2} = {num1 / num2}");
                    }
                    break;
                default:
                    Console.WriteLine("Error: Invalid operator selected.");
                    break;
            }

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}