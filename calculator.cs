using System;

namespace CalculatorApp
{
    class Calculator
    {
        static void Main(string[] args)
        {
            double num1, num2;
            char operation;

            Console.WriteLine("Enter first number:");
            num1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter second number:");
            num2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter operation (+, -, *, /): ");
            operation = Convert.ToChar(Console.ReadLine());

            switch (operation)
            {
                case '+':
                    Console.WriteLine("Result: " + (num1 + num2));
                    break;

                case '-':
                    Console.WriteLine("Result: " + (num1 - num2));
                    break;

                case '*':
                    Console.WriteLine("Result: " + (num1 * num2));
                    break;

                case '/':
                    if (num2 != 0)
                    {
                        Console.WriteLine("Result: " + (num1 / num2));
                    }
                    else
                    {
                        Console.WriteLine("Cannot divide by zero");
                    }
                    break;

                default:
                    Console.WriteLine("Invalid operator");
                    break;
            }
            Console.ReadLine();
        }
    }
}