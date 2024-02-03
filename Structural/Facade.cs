namespace DesignPatterns.Structural
{
    /*
     * Amplifier, DvdPlayer, and Projector are subsystems of the home theater system.
     * HomeTheaterFacade is the facade that provides a simplified interface for watching a movie. 
     * It coordinates the subsystems to create an enjoyable movie-watching experience.
     */

    // Subsystem Classes
    public class Amplifier
    {
        public void TurnOn() => Console.WriteLine("Amplifier turned on.");
        public void SetVolume(int level) => Console.WriteLine($"Amplifier volume set to {level}.");
    }

    public class DvdPlayer
    {
        public void TurnOn() => Console.WriteLine("DVD Player turned on.");
        public void PlayMovie(string movie) => Console.WriteLine($"Playing \"{movie}\".");
    }

    public class Projector
    {
        public void TurnOn() => Console.WriteLine("Projector turned on.");
        public void SetInput(DvdPlayer dvd) => Console.WriteLine("Projector input set to DVD Player.");
    }

    // Facade
    public class HomeTheaterFacade
    {
        private Amplifier amplifier;
        private DvdPlayer dvdPlayer;
        private Projector projector;

        public HomeTheaterFacade(Amplifier amplifier, DvdPlayer dvdPlayer, Projector projector)
        {
            this.amplifier = amplifier;
            this.dvdPlayer = dvdPlayer;
            this.projector = projector;
        }

        public void WatchMovie(string movie)
        {
            Console.WriteLine("Get ready to watch a movie...");

            amplifier.TurnOn();
            amplifier.SetVolume(5);

            dvdPlayer.TurnOn();
            dvdPlayer.PlayMovie(movie);

            projector.TurnOn();
            projector.SetInput(dvdPlayer);
        }
    }
}
