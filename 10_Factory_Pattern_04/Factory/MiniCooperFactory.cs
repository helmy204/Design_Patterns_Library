using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _10_Factory_Pattern_04.Autos;
using _10_Factory_Pattern_04.Autos.Mini;

namespace _10_Factory_Pattern_04.Factory
{
    public class MiniCooperFactory : IAutoFactory
    {
        public IAutomobile CreateSportsCar()
        {
            var mini = new MiniCooper();
            mini.AddSportPackage();

            return mini;
        }

        public IAutomobile CreateLuxuryCar()
        {
            var mini = new MiniCooper();
            mini.AddLuxuryPackage();

            return mini;
        }

        public IAutomobile CreateEconomyCar()
        {
            var mini = new MiniCooper();

            return mini;
        }
    }
}
