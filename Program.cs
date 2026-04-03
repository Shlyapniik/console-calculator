class Program
{
    static void Main()
    {
        Console.WriteLine("This is the simply console calculator\n"+
                        "Write two numbers and choose the operation\n"+
                        "What you can do:\n"+
                        "1. Summation numbers\n"+
                        "2. Subtraction numbers\n"+
                        "3. Multiplication numbers\n"+
                        "4. Division numbers\n"+
                        "0. Exit");

        Console.Write("Write the number of operation: ");
        int userInput;
        while (!int.TryParse(Console.ReadLine(), out userInput))
        {
            Console.Write("Invalid input. Try again: ");
        }

        while (userInput != 0)
        {
            Console.Write("Write the first number: ");
            int firstNumber = int.Parse(Console.ReadLine());
            Console.Write("Write the second number: ");
            int secondNumber = int.Parse(Console.ReadLine());
            Console.WriteLine();
            switch (userInput)
            {
                case 1:
                    Console.WriteLine($"Sum: {SumOperation(firstNumber, secondNumber)}");
                    break;
                case 2:
                    Console.WriteLine($"Sub: {SubOperation(firstNumber, secondNumber)}");
                    break;
                case 3:
                    Console.WriteLine($"Mul: {MulOperation(firstNumber, secondNumber)}");
                    break;
                case 4:
                    Console.WriteLine($"Div: {DivOperation(firstNumber, secondNumber):f2}");
                    break;
                default:
                    Console.WriteLine("Wrong number");
                    break;
            }
            Console.Write("\nWrite the number of operation:");
            while (!int.TryParse(Console.ReadLine(), out userInput))
            {
                Console.Write("Invalid input. Try again: ");
            }
        }
    }

    public static int SumOperation(int firstNumber, int secondNumber)
    {
        int sum = firstNumber + secondNumber;
        return sum;
    }

    public static int SubOperation(int firstNumber, int secondNumber)
    {
        int sub = firstNumber - secondNumber;
        return sub;
    }

    public static int MulOperation(int firstNumber, int secondNumber)
    {
        int mul = firstNumber * secondNumber;
        return mul;
    }

    public static double DivOperation(int firstNumber, int secondNumber)
    {
        if (secondNumber == 0)
        {
            Console.WriteLine("Cannot divide by zero");
            return 0;
        }
        double div = (double)firstNumber / secondNumber;
        return div;
    }
}