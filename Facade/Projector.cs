using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    class Projector
    {
        public void on()
        {
            Console.WriteLine("Projector is on");
        }
        public void wideScreenMode()
        {
            Console.WriteLine("Widescreen mode is on");
        }
        public void off()
        {
            Console.WriteLine("Projector is off");
        }
    }
}
