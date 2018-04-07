using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.Decorator
{
    class SmallSize:IPizza
    {
        public double GetCost()
        {
            return 3;
        }

        public string GetDescription()
        {
            return "Small Size";
        }
    }
}
