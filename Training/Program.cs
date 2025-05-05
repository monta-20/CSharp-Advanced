using System;

public class Program
{
    // Déclaration d'un delegate
    public delegate double Operation(double a, double b);

    // Méthodes d'opération
    public static double Add(double x, double y) => x + y;
    public static double Subtract(double x, double y) => x - y;
    public static double Multiply(double x, double y) => x * y;
    public static double Divide(double x, double y) => y != 0 ? x / y : throw new DivideByZeroException();

    // Méthode qui utilise le delegate
    public static void ExecuteOperation(double a, double b, Operation operation, string opName)
    {
        try
        {
            double result = operation(a, b);
            Console.WriteLine($"{opName} of {a} and {b} = {result}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"{opName} failed: {ex.Message}");
        }
    }

    public static void Main()
    {
        double num1 = 10;
        double num2 = 5;

        ExecuteOperation(num1, num2, Add, "Addition");
        ExecuteOperation(num1, num2, Subtract, "Subtraction");
        ExecuteOperation(num1, num2, Multiply, "Multiplication");
        ExecuteOperation(num1, num2, Divide, "Division");
    }
}
