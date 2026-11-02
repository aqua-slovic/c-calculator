using System;

class Program
{
    static void Main()
    {
        Console.WriteLine(" Calculator");

        Console.Write("Enter first number: ");
        double num1 = Convert.ToDouble(Console.ReadLine() ?? "0");

        Console.Write("Enter operator (+, -, *, /): ");
        string op = Console.ReadLine() ?? "";

        Console.Write("Enter second number: ");
        double num2 = Convert.ToDouble(Console.ReadLine() ?? "0");

        double result = 0;
        bool valid = true;

        switch (op)
        {
            case "+":
                result = num1 + num2;
                break;
            case "-":
                result = num1 - num2;
                break;
            case "*":
                result = num1 * num2;
                break;
            case "/":
                if (num2 == 0)
                {
                    Console.WriteLine("Error: Cannot divide by zero.");
                    valid = false;
                }
                else
                {
                    result = num1 / num2;
                }
                break;
            default:
                Console.WriteLine("Error: Invalid operator.");
                valid = false;
                break;
        }

        if (valid)
        {
            Console.WriteLine($"Result: {num1} {op} {num2} = {result}");
        }
    }
}
