using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    class Screen
    {
        public void down()
        {
            Console.WriteLine("Screen is down");
        }
        public void up()
        {
            Console.WriteLine("Screen is up");
        }
    }
}
