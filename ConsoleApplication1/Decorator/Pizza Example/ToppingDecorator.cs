using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.Decorator
{
    abstract class ToppingDecorator:IPizza
    {
        protected IPizza BasePizza;

        public ToppingDecorator(IPizza newPizza)
        {
            this.BasePizza = newPizza;
        }
        public abstract double GetCost();
        public abstract string GetDescription();
        
    }

    class Cheese : ToppingDecorator
    {
        public Cheese(IPizza newPizza): base(newPizza)
        {
        }
        public override double GetCost()
        {
            return BasePizza.GetCost() + 1;
        }

        public override string GetDescription()
        {
            return BasePizza.GetDescription() + ", Cheese";
        }
    }

    class TomatoSource : ToppingDecorator
    {
        public TomatoSource(IPizza newPizza) : base(newPizza)
        {
        }
        public override double GetCost()
        {
            return BasePizza.GetCost() + 4;
        }

        public override string GetDescription()
        {
            return BasePizza.GetDescription() + ", Tomato Source";
        }
    }
}
