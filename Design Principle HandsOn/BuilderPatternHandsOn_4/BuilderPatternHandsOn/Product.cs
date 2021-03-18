using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPatternHandsOn
{
     public class Product
    {
        private List<string> _parts = new List<string>();



        public void Add(string part)

        {

            _parts.Add(part);

        }


        public void Show()

        {

            foreach (string part in _parts)

                Console.Write(part + " ");

            Console.WriteLine();
        }
    }
}
