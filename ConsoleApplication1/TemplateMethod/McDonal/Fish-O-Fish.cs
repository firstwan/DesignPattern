using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.TemplateMethod.McDonal
{
    public class Fish_O_Fish : TemplateClass
    {
        public Fish_O_Fish()
        {
            productName = "Fish_O_Fish";
        }

        public override string addMainIngredient()
        {
            return "Fish Bugger";
        }

        public override string addSencondIngredient()
        {
            return "Nugget";
        }
    }
}
