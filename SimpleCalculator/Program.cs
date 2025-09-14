using System;

namespace SimpleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            var calc = new Calculator();

            Console.WriteLine("Simple Calculator");
            Console.Write("Enter first number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter operator (+, -, *, /): ");
            char op = Convert.ToChar(Console.ReadLine());

            Console.Write("Enter second number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            try
            {
                double result = op switch
                {
                    '+' => calc.Add(num1, num2),
                    '-' => calc.Subtract(num1, num2),
                    '*' => calc.Multiply(num1, num2),
                    '/' => calc.Divide(num1, num2),
                    _ => throw new InvalidOperationException("Invalid operator.")
                };

                Console.WriteLine($"Result: {result}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
