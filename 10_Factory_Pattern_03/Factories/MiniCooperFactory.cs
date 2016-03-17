using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _10_Factory_Pattern_03.Autos;

namespace _10_Factory_Pattern_03.Factories
{
    public class MiniCooperFactory : IAutoFactory
    {
        public IAuto CreateAutomobile()
        {
            var mini = new MiniCooper();
            mini.SetName("Mini Cooper S");

            return mini;
        }
    }
}
