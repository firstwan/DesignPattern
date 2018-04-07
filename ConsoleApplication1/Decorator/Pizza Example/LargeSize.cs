using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.Decorator
{
    class LargeSize:IPizza
    {
        public double GetCost()
        {
            return 5;
        }

        public string GetDescription()
        {
            return "Large Size";
        }
    }
}
