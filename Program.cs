class Assignment5
{
    public static void Main(string[] args)
    {
        int num1, num2, sum, sub, div, mul;

        Console.WriteLine("Calculator Program");

        Console.Write("Enter Your First Number: ");
        num1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter Your Second Number: ");
        num2 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Couch Operation (+, -, *, /): ");
        char operation = Convert.ToChar(Console.ReadLine() ?? "");

        Console.WriteLine("Switch Case");
        // Using switch
        switch (operation)
        {
            case '+':
                sum = num1 + num2;
                Console.WriteLine($"Sum: {sum}");
                break;
            case '-':
                sub = num1 - num2;
                Console.WriteLine($"Subtraction: {sub}");
                break;
            case '*':
                mul = num1 * num2;
                Console.WriteLine($"Multiplication: {mul}");
                break;
            case '/':
                div = num1 / num2;
                Console.WriteLine($"Division: {div}");
                break;
            default:
                Console.WriteLine("Invalid Operation");
                break;
        }

        Console.WriteLine("If-Else");
        // Using if-else
        if (operation == '+')
        {
            sum = num1 + num2;
            Console.WriteLine($"Sum: {sum}");
        } else if (operation == '-')
        {
            sub = num1 - num2;
            Console.WriteLine($"Subtraction: {sub}");
        } else if (operation == '*')
        {
            mul = num1 * num2;
            Console.WriteLine($"Multiplication: {mul}");
        } else if (operation == '/')
        {
            div = num1 / num2;
            Console.WriteLine($"Division: {div}");
        } else
        {
            Console.WriteLine("Invalid Operation");
        }
    }
}
