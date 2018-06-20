using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    public class Cheese : ToppingDecorator
    {
        public Cheese(IPizza newPizza) : base(newPizza)
        {
        }

        public override string getDescription()
        {
            throw new NotImplementedException();
        }

        public override string getPrice()
        {
            throw new NotImplementedException();
        }
    }

    public class Mozzarella : ToppingDecorator
    {
        public Mozzarella(IPizza newPizza) : base(newPizza)
        {
        }

        public override string getDescription()
        {
            throw new NotImplementedException();
        }

        public override string getPrice()
        {
            throw new NotImplementedException();
        }
    }
}