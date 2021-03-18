using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPatternHandsOn
{
    class Director
    {
        public void Construct(Builder builder)
        {
            builder.BuildSweet();
            builder.BuildSavories();

        }
    }
}
