using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    class Program
    {
        static void Main(string[] args)
        {
            Amplifier amp = new Amplifier();
            DvdPlayer dvd = new DvdPlayer();
            PopcornPopper popper = new PopcornPopper();
            Projector projector = new Projector();
            Screen screen = new Screen();
            TheaterLights lights = new TheaterLights();
            Tuner tuner = new Tuner();
            CdPlayer cd = new CdPlayer();

            HomeTheaterFacade facade = new HomeTheaterFacade(amp, tuner, dvd, cd, projector, screen, lights, popper);
            facade.watchMovie("The Lord of the Rings");
            facade.endMovie();
        }
    }
}
