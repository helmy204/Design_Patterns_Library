using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _10_Factory_Pattern_02.Autos;
using System.Reflection;

namespace _10_Factory_Pattern_02
{
    /// <summary>
    /// A simple auto factory that creates various types of automobiles
    /// based on a key for type lookup
    /// </summary>
    public class AutoFactory
    {
        Dictionary<string, Type> autos;

        public AutoFactory()
        {
            LoadTypesICanReturn();
        }

        private void LoadTypesICanReturn()
        {
            autos = new Dictionary<string, Type>();
            // Reflection, get all types in the currently executing assembly
            Type[] typesInThisAssembly = Assembly.GetExecutingAssembly().GetTypes();

            foreach (Type type in typesInThisAssembly)
            {
                if(type.GetInterface(typeof(IAuto).ToString())!=null)
                {
                    autos.Add(type.Name.ToLower(), type);
                }
            }
        }

        internal IAuto CreateInstance(string carName)
        {
            Type t = GetTypeToCreate(carName);

            if (t == null)
                return new NullCar();

            return Activator.CreateInstance(t) as IAuto;
        }

        private Type GetTypeToCreate(string carName)
        {
            foreach (var auto in autos)
            {
                if (auto.Key.Contains(carName))
                {
                    return autos[auto.Key];
                }
            }
            return null;
        }
    }
}
