using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    public abstract class ToppingDecorator
    {
        public IPizza pizza;

        public ToppingDecorator (IPizza newPizza)
        {
            pizza = newPizza;
        }

        public abstract string getDescription();

        public abstract string getPrice();

    }
}