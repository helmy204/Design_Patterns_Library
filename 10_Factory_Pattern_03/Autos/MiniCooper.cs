using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_Factory_Pattern_03.Autos
{
    public class MiniCooper : IAuto
    {
        public string Name
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public void SetName(string name)
        {
            throw new NotImplementedException();
        }

        public void TurnOff()
        {
            Console.WriteLine("The Mini Cooper S is turned off.");
        }

        public void TurnOn()
        {
            Console.WriteLine("The Mini Cooper S is up and running with a mighty roar.");
        }
    }
}
