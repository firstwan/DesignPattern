using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.Decorator
{
    class Main
    {
        static void Main1()
        {
            IPizza pizza = new Cheese(new LargeSize());
            Console.Write(pizza.GetDescription() + "\n");
            Console.Write(pizza.GetCost());

            IPizza pizza2 = new Cheese(new TomatoSource(new LargeSize()));
            Console.Write("\n\n" + pizza2.GetDescription() + "\n");
            Console.Write(pizza2.GetCost());
            Console.Read();
        }
    }
}
