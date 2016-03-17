using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _10_Factory_Pattern_03.Autos;

namespace _10_Factory_Pattern_03.Factories
{
    public class BMWFactory : IAutoFactory
    {
        public IAuto CreateAutomobile()
        {
            var bmw = new BMW();
            bmw.SetName("BMW M5 Cabriolet");

            return bmw;
        }
    }
}
