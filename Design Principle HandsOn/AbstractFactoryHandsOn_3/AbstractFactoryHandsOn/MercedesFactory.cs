using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryHandsOn
{
    class MercedesFactory : Factory
    {
        public override Headlight makeHeadlight()
        {
            return new MercedesHeadlight();
        }

        public override Tire makeTire()
        {
            return new MercedesTire();
        }
    }
}
