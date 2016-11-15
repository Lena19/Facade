using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    class Amplifier
    {
        string dvd;
        int volume;
        void setDvd(string dvd)
        {
            this.dvd = dvd;
            Console.WriteLine("Dvd is set. " + dvd);
        }
        void setSurroundSound()
        {
            Console.WriteLine("Surround sound is set");
        }
        void setVolume(int vol)
        {
            volume = vol;
            Console.WriteLine("Volume is set on " + volume);
        }
    }
}
