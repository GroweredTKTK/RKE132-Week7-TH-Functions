Console.WriteLine("Are you coming or leaving? (in/out)");
string userChoise = Console.ReadLine();

if (userChoise == "in") 
{
    PrintHello();
}
else if (userChoise == "out")
{
    PrintGoodBye();
}
else
{
    WrongAnswer();
}


static void WrongAnswer()
{
    Console.WriteLine("Wrong answer");
}
static void PrintHello() //function / method
{
    Console.WriteLine("Hello, world!");
}

static void PrintGoodBye()
{
    Console.WriteLine("See you later");
}