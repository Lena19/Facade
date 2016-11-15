using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    class DvdPlayer
    {
        public void on()
        {
            Console.WriteLine("DVD is on");
        }
        public void play(string movie)
        {
            Console.WriteLine("DVD is playing " + movie);
        }
        public void stop()
        {
            Console.WriteLine("Dvd is stopped");
        }
        public void eject()
        {
            Console.WriteLine("Dvd is ejected");
        }
        public void off()
        {
            Console.WriteLine("Dvd is off");
        }
    }
}
