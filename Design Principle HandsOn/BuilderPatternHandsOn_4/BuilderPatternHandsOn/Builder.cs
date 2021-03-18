using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPatternHandsOn
{
    public interface Builder
    {
        void BuildSweet();
        void BuildSavories();

        Product GetResults();

    }
}
