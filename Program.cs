int guess = AskForNumberInRange("user 1, type a number between 0 to 100", 0, 100);

Console.Clear();

while (true)
{
    int userguess = AskForNumber("whats your next guess?");
    if (userguess < guess)
    {
        Console.WriteLine("seriously?");
    }
    else if (userguess > guess)
    {
        Console.WriteLine("too much");
    }
    else break;
}
Console.WriteLine("nice");

int AskForNumber(string text)
{
    Console.WriteLine(text);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

int AskForNumberInRange(string text, int min, int max)
{
    while (true)
    {
        int ask = AskForNumber(text);
        if (ask < min || ask > max)
                Console.WriteLine("try again");
        else return ask;
    }
}