namespace Facade;

public class Screen
{
    public string Description;

    public Screen(string description)
    {
        Description = description;
    }

    public void up()
    {
        Console.WriteLine("Screen is up");
    }
    
    public void down()
    {
        Console.WriteLine("Screen is down");
    }
}