using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    class TheaterLights
    {
        int light;
        public void dim(int vol)
        {
            this.light = vol;
            Console.WriteLine("Light dim on " + vol);
        }
        public void on()
        {
            Console.WriteLine("Light is on");
        }
    }
}
