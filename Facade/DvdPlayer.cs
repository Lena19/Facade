using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    class DvdPlayer
    {
        void on()
        {
            Console.WriteLine("DVD is on");
        }
        void play(string movie)
        {
            Console.WriteLine("DVD is playing " + movie);
        }
        void stop()
        {
            Console.WriteLine("Dvd is stopped");
        }
        void eject()
        {
            Console.WriteLine("Dvd is ejected");
        }
        void off()
        {
            Console.WriteLine("Dvd is off");
        }
    }
}
