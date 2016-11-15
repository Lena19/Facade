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
    }
}
