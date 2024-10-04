int AskForNumber(string text)
{
    Console.WriteLine(text);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}
Console.WriteLine("give me a number between 1 and 40");
int input = Convert.ToInt32(Console.ReadLine());
AskForNumberInRange(input, 1, 40);
int AskForNumberInRange(int Number, int min, int max)
{
   while (true)
    {
        if (Number > min & Number < max)
            return Number;

        else
        {
            Console.WriteLine("Try again");
        }
    }
}
Console.WriteLine("nice");
