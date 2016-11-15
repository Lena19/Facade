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
        public void on()
        {
            Console.WriteLine("Amp is on");
        }
        public void setDvd(string dvd)
        {
            this.dvd = dvd;
            Console.WriteLine("Dvd is set. " + dvd);
        }
        public void setSurroundSound()
        {
            Console.WriteLine("Surround sound is set");
        }
        public void setVolume(int vol)
        {
            volume = vol;
            Console.WriteLine("Volume is set on " + volume);
        }
        public void off()
        {
            Console.WriteLine("Amp is off");
        }
    }
}
