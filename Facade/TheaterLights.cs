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
        void dim(int vol)
        {
            this.light = vol;
            Console.WriteLine("Light dim on " + vol);
        }
        void on()
        {
            Console.WriteLine("Light is on");
        }
    }
}
