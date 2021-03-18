using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryHandsOn
{
    class MercedesHeadlight:Headlight
    {
        public MercedesHeadlight()
        {
            Console.WriteLine("Making Mercedes Headlight");
        }
    }
}
