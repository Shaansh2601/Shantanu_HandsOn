using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryHandsOn
{
    abstract class Factory
    {
        public abstract Headlight makeHeadlight();
        public abstract Tire makeTire();
        public static Factory GetFactory(string type)
        {
            if(type.Equals("Audi"))
            {
                return new AudiFactory();
            }
            else
            {
                return new MercedesFactory();
            }
        }
    }
}
