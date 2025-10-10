namespace Banking;

//a class defined with static keyword can only define static members,
//such a class does not contain an instance constructor
public static class Banker
{
    public static void Greet()
    {
        Console.WriteLine("Welcome to MET Bank!");
    }
}