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
                        "4. Division numbers\n");

        Console.Write("Write the number of operation:");
        int userInput = int.Parse(Console.ReadLine());

        while (userInput != 0)
        {
            Console.Write("Write the first number:");
            int firstNumber = int.Parse(Console.ReadLine());
            Console.Write("Write the second number:");
            int secondNumber = int.Parse(Console.ReadLine());
            Console.WriteLine();
            int sum = 0;
            int sub = 0;
            int mul = 0;
            double div = 0;
            switch (userInput)
            {
                case 1:
                    sum = SumOperation(firstNumber, secondNumber);
                    Console.WriteLine($"Sum: {sum}");
                    break;
                case 2:
                    sub = SubOperation(firstNumber, secondNumber);
                    Console.WriteLine($"Sub: {sub}");
                    break;
                case 3:
                    mul = MulOperation(firstNumber, secondNumber);
                    Console.WriteLine($"Mul: {mul}");
                    break;
                case 4:
                    div = DivOperation(firstNumber, secondNumber);
                    Console.WriteLine($"Div: {div:f2}");
                    break;
                default:
                    Console.WriteLine("Wrong number");
                    break;
            }
            Console.Write("\nWrite the number of operation:");
            userInput = int.Parse(Console.ReadLine());
        }
    }

    public static int SumOperation(int firstNumber, int secondNumber)
    {
        ErrorCheck(firstNumber, secondNumber);
        int sum = firstNumber + secondNumber;
        return sum;
    }

    public static int SubOperation(int firstNumber, int secondNumber)
    {
        ErrorCheck(firstNumber, secondNumber);
        int sub = firstNumber - secondNumber;
        return sub;
    }

    public static int MulOperation(int firstNumber, int secondNumber)
    {
        ErrorCheck(firstNumber, secondNumber);
        int mul = firstNumber * secondNumber;
        return mul;
    }

    public static double DivOperation(int firstNumber, int secondNumber)
    {
        ErrorCheck(firstNumber, secondNumber);
        double div = (double)firstNumber / secondNumber;
        return div;
    }

    public static void ErrorCheck(int firstNumber, int secondNumber)
    {
        if (firstNumber == null || secondNumber == null) Console.WriteLine("The one or two numbers were null. Check your input");
    }
}