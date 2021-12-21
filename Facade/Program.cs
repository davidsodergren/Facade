// See https://aka.ms/new-console-template for more information

namespace Facade
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Amplifier amplifier = new Amplifier("Cool amp");
            Projector projector = new Projector("Old projector");
            Screen screen = new Screen("Regular screen");
            TheaterLights theaterLights = new TheaterLights("Red lights");
            HomeTheaterFacade homeTheaterFacade = new HomeTheaterFacade(amplifier, projector, screen, theaterLights);
            homeTheaterFacade.watchMovie("Heat");
            homeTheaterFacade.endMovie("Heat");
        }
    }    
}

