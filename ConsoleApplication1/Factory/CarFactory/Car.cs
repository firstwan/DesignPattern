using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.Factory
{
    public class Car:Vehicle
    {
        public Car()
        {
            Make = "Produa";
            Model = "Vira";
            EngineSize = "1.3";
            Colour = "Blue";
        }
    }
}
