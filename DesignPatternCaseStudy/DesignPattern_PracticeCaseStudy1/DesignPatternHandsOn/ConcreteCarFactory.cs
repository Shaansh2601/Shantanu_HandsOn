using DesignPatternHandsOn;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static DesignPatternHandsOn.Program;

namespace PracticeCaseStudy
{


    public class ConcreteCarFactory : CarFactory
    {
        public void MakeMicroCar(Location location, CarType carType)
        {
            new MicroCar(carType, location);
        }

        public void MakeLuxuryCar(Location location, CarType carType)
        {
            new LuxuryCar(carType, location);
        }

        public void MakeMiniCar(Location location, CarType carType)
        {
            new MiniCar(carType, location);
        }
    }
}
