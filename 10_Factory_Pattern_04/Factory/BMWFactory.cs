using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _10_Factory_Pattern_04.Autos;
using _10_Factory_Pattern_04.Autos.BMW;

namespace _10_Factory_Pattern_04.Factory
{
    public class BMWFactory : IAutoFactory
    {
        public IAutomobile CreateSportsCar()
        {
            return new BMW3();
        }

        public IAutomobile CreateEconomyCar()
        {
            return new BMW740i();
        }

        public IAutomobile CreateLuxuryCar()
        {
            return new BMW328i();
        }
    }
}
