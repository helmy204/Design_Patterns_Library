using _10_Factory_Pattern_02.Autos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_Factory_Pattern_02
{
    /// <summary>
    /// Simple factory
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            string carName = args[0];

            AutoFactory factory = new AutoFactory();

            IAuto car = factory.CreateInstance(carName);

            car.TurnOn();
            car.TurnOff();
        }
    }
}
