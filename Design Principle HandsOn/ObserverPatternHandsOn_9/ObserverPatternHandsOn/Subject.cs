using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPatternHandsOn
{
    interface Subject
    {
        int GetState { get; set; }

        void ChangeState(int val);
        void Attach(Observer o);

        void Detach(Observer o);
    }
}
