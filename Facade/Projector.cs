namespace Facade;

public class Projector
{
    public string Description;

    public Projector(string description)
    {
        Description = description;
    }

    public void on()
    {
        Console.WriteLine("Turning Projector on");
    }
    
    public void off()
    {
        Console.WriteLine("Turning Projector off");
    }
    
    public void wideScreenMode()
    {
        Console.WriteLine("Turning wideScreenMode on");
    }
}