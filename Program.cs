class Program
{
    static void Main()
    {
        ShowMenu();
        Console.Write("Write the number of operation: ");
        int userInput = ReadOperation();

        while (userInput != 0)
        {
            int firstNumber = ReadInt("Write the first number: ");
            int secondNumber = ReadInt("Write the second number: ");
            Console.WriteLine();
            
            double result = Calculate(userInput, firstNumber, secondNumber);

            if (double.IsNaN(result))
            {
                Console.WriteLine("Cannot divide by zero\n");
            }
            else
            {
                Console.WriteLine($"Result: {result:f2}\n");
            }
            ShowMenu();

            Console.Write("\nWrite the number of operation: ");
            while (!int.TryParse(Console.ReadLine(), out userInput))
            {
                Console.Write("Invalid input. Try again: ");
            }
        }
    }

    public static double Calculate(int operationNumber, int firstNumber, int secondNumber)
    {
        switch (operationNumber)
        {
            case 1:
                return firstNumber+secondNumber;
            case 2:
                return firstNumber-secondNumber;
            case 3:
                return firstNumber*secondNumber;
            case 4:
                if (secondNumber == 0)
                {
                    return double.NaN;
                }
                return (double)firstNumber/secondNumber;
            default:
                return 0;
        }
    }

    public static int ReadInt(string message)
    {
        int number;
        Console.Write(message);
        while (!int.TryParse(Console.ReadLine(), out number))
        {
            Console.Write("Invalid input. Try again: ");
        }
        return number;
    }

    public static int ReadOperation()
    {
        int userInput;

        while (true)
        {
            if (int.TryParse(Console.ReadLine(), out userInput) &&
                userInput >= 0 && userInput <= 4)
            {
                return userInput;
            }

            Console.Write("Invalid operation. Try again: ");
        }
    }

    public static void ShowMenu()
    {
        Console.WriteLine("This is the simply console calculator\n"+
                        "Write two numbers and choose the operation\n"+
                        "What you can do:\n"+
                        "1. Summation numbers\n"+
                        "2. Subtraction numbers\n"+
                        "3. Multiplication numbers\n"+
                        "4. Division numbers\n"+
                        "0. Exit");
    }
}