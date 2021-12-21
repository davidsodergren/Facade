namespace Facade;

public class HomeTheaterFacade
{
    public Amplifier Amplifier;
    public Projector Projector;
    public Screen Screen;
    public TheaterLights TheaterLights;

    public HomeTheaterFacade(Amplifier amplifier, Projector projector, Screen screen, TheaterLights theaterLights)
    {
        Amplifier = amplifier;
        Projector = projector;
        Screen = screen;
        TheaterLights = theaterLights;
    }

    public void watchMovie(string movie)
    {
        Console.WriteLine("Setting up theater for movie " + movie);
        Amplifier.on();
        Amplifier.setVolume(14);
        Amplifier.setSurroundSound();
        Projector.on();
        Projector.wideScreenMode();
        Screen.down();
        TheaterLights.on();
        TheaterLights.dim();
        Console.WriteLine("Starting movie " + movie);
    }
    
    public void endMovie(string movie)
    {
        Console.WriteLine("Shutting down theater for movie " + movie);
        Amplifier.setVolume(0);
        Amplifier.off();
        Projector.off();
        Screen.up();
        TheaterLights.off();
        Console.WriteLine("Turned off theater for movie " + movie);

    }
}