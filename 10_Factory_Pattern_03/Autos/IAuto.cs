using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_Factory_Pattern_03.Autos
{
    public interface IAuto
    {
        string Name { get; }
        void SetName(string name);
        void TurnOn();
        void TurnOff();
    }
}
