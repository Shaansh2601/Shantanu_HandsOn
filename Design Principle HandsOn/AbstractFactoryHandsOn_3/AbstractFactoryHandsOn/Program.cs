using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryHandsOn
{
    class Program
    {
        static void Main(string[] args)
        {
            Factory audi = Factory.GetFactory("Audi");
            audi.makeHeadlight();
            audi.makeTire();

            Factory mercedes = Factory.GetFactory("Mercedes");
            mercedes.makeHeadlight();
            mercedes.makeTire();

            Console.ReadLine();
        }
    }
}
