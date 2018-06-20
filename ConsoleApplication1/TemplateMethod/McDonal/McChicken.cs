using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.TemplateMethod.McDonal
{
    public class McChicken : TemplateClass
    {
        public McChicken()
        {
            productName = "McChicken";
        }

        public override string addMainIngredient()
        {
            return "McChicken Bugger";
        }

        public override string addSencondIngredient()
        {
            return "French fries";
        }
    }
}
