Console.WriteLine("Enter the operation (+/-)");
char operationMark = Char.Parse(Console.ReadLine());

Console.WriteLine("Enter a:");
int firstNum = Int32.Parse(Console.ReadLine());
Console.WriteLine("Enter b:");
int secondNum = Int32.Parse(Console.ReadLine());

switch (operationMark)
{
    case '+':
        Addition(firstNum, secondNum);
        break;
    case '-':
        Substraction(firstNum, secondNum);
        break;
    default:
        Console.WriteLine("invalid Operator");
        break;
}

static void Addition(int a, int b)
{
    Console.WriteLine($"{a} + {b} = {a + b}");
}

static void Substraction(int a, int b)
{
    Console.WriteLine($"{a} - {b} = {a - b}");
}