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