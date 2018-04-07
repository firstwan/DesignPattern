using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.Factory
{
    public abstract class Vehicle
    {
        public String Make { get; set; }
        public String Model { get; set; }
        public String EngineSize { get; set; }
        public String Colour { get; set; }



        public void display()
        {
            Console.WriteLine("Make: " + Make);
            Console.WriteLine("Model: " + Model);
            Console.WriteLine("Engine Size: " + EngineSize);
            Console.WriteLine("Colour: " + Colour);
        }


    }
}
