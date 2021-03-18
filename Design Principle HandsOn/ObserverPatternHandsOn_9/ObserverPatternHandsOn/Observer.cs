using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPatternHandsOn
{
    interface Observer
    {
        void Update(Message m);
    }
}
