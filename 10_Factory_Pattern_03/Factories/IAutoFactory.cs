using _10_Factory_Pattern_03.Autos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_Factory_Pattern_03.Factories
{
    public interface IAutoFactory
    {
        IAuto CreateAutomobile();
    }
}
