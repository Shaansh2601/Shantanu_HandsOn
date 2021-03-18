using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryHandsOn
{
    class AudiFactory : Factory
    {
        public override Headlight makeHeadlight()
        {
            return new AudiHeadlight();
        }

        public override Tire makeTire()
        {
            return new AudiTire();
        }
    }
}
