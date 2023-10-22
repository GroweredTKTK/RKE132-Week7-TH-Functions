//total < 10 - 1%
//total >= 10 && < 20 - 5%
//total >= 20 - 10%

Console.WriteLine("What is your total?");
int userInput = int.Parse(Console.ReadLine());//int.Parse acts same as the Int32.Parse

double discount = CalculateDicount(userInput);

Console.WriteLine($"Your discount is: {discount}%");

double newTotal = CalculateNewTotal(userInput, discount);

Console.WriteLine($"Your updated total with {discount}%: {newTotal}");


static double CalculateDicount(int total)
{
    if (total > 10)
    {
        return 1;
    }
    else if (total >= 1 && total < 20)
    {
        return 5;
    }
    else
    {
        return 10;
    }
}

static double CalculateNewTotal(double total, double discount)
{
    double result = total - (total * discount) / 100;
    return result;
}
