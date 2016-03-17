using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_Factory_Pattern_01.Autos
{
    public class BMW335Xi : IAuto
    {
        public void TurnOff()
        {
            Console.WriteLine("The BMW 334Xi is off.");
        }

        public void TurnOn()
        {
            Console.WriteLine("The BMW 334Xi is on and running.");
        }
    }
}
