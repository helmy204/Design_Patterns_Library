using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_Factory_Pattern_03.Autos
{
    public class BMW : IAuto
    {
        public BMW()
        {

        }

        public BMW(string name)
        {
            Name = name;
        }

        public string Name
        {
            get;
            private set;
        }

        public void SetName(string name)
        {
            if (name == null) throw new ArgumentNullException("name");

            Name = name;
        }

        public void TurnOff()
        {
            Console.WriteLine("The " + Name + " is shutting down");
        }

        public void TurnOn()
        {
            Console.WriteLine("The " + Name + " is up and running with a mighty whiiiiiiirrrrrr sound");
        }
    }
}
