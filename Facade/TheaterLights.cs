namespace Facade;

public class TheaterLights
{
    public string Description;

    public TheaterLights(string description)
    {
        Description = description;
    }

    public void on()
    {
        Console.WriteLine("Turning Theater Lights on");
    }
    
    public void off()
    {
        Console.WriteLine("Turning Theater Lights off");
    }

    public void dim()
    {
        Console.WriteLine("Dimming Theater Lights");
    }
}