using _10_Factory_Pattern_01.Autos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_Factory_Pattern_01
{
    class Program
    {
        static void Main(string[] args)
        {
            string carName = args[0];

            IAuto car = GetCar(carName);
            car.TurnOn();
            car.TurnOff();
        }

        private static IAuto GetCar(string carName)
        {
            switch (carName)
            {
                case "bmw":
                    return new BMW335Xi();
                case "mini":
                    return new MiniCooper();
                // Modification, agains SOLID Open-Close principal...!!!
                case "audi":
                    return new AudiTTS();
                default:
                    return new NullCar();
            }
        }
    }
}
