using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPatternHandsOn
{
    class MovableAdapterImpl : MovableAdapter
    {
        private Movable luxuryCars;
        public MovableAdapterImpl(Movable movable)
        {
            luxuryCars = movable;
        }
        public double getSpeed()
        {
            return convertMPHtoKMPH(luxuryCars.getSpeed());
        }
        private double convertMPHtoKMPH(double mph) { return mph * 1.60934; }
    }
}
