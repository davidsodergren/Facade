namespace Facade;

public class Amplifier
{
    public string Description;

    public Amplifier(string description)
    {
        Description = description;
    }

    public void on()
    {
        Console.WriteLine("Turning Amplifier on");
    }
    
    public void off()
    {
        Console.WriteLine("Turning Amplifier off");
    }

    public void setSurroundSound()
    {
        Console.WriteLine("Turning surround sound on for amplifier");
    }

    public void setVolume(int volume)
    {
        Console.WriteLine("Turning volume for amplifier to :" + volume);
    }
}