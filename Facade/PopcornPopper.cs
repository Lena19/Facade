using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    class PopcornPopper
    {
        public void on()
        {
            Console.WriteLine("Popper is on");
        }
        public void pop()
        {
            Console.WriteLine("Popper is popping");
        }
        public void off()
        {
            Console.WriteLine("Popper is off");
        }
    }
}
