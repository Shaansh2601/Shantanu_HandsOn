using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryHandsOn
{
    class AudiHeadlight : Headlight
    {
        public AudiHeadlight()
        {
            Console.WriteLine("Making Audi HeadLight");
        }
    }
}
