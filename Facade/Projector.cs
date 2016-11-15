using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    class Projector
    {
        void on()
        {
            Console.WriteLine("Projector is on");
        }
        void wideScreenMode()
        {
            Console.WriteLine("Widescreen mode is on");
        }
        void off()
        {
            Console.WriteLine("Projector is off");
        }
    }
}
