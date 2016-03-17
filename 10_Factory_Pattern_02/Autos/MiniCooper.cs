using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_Factory_Pattern_02.Autos
{
    public class MiniCooper : IAuto
    {
        public void TurnOff()
        {
            Console.WriteLine("The Mini Cooper has turned off.");
        }

        public void TurnOn()
        {
            Console.WriteLine("The Mini Cooper is on! 1.6 Litres of brutal force is churning.");
        }
    }
}
