using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_Factory_Pattern_01.Autos
{
    public class AudiTTS : IAuto
    {
        public void TurnOff()
        {
            Console.WriteLine("The Audi TTS is off, but the dashboard is still smoking.");
        }

        public void TurnOn()
        {
            Console.WriteLine("The Audi TTS is running, but there is an electrical fire.");
        }
    }
}
