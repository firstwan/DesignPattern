using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.TemplateMethod.McDonal
{
    public abstract class TemplateClass
    {
        protected string productName = string.Empty;

        public void MakeBugger(int drink)
        {
            Console.WriteLine(welcome());
            Console.WriteLine(addMainIngredient());
            Console.WriteLine(addSencondIngredient());
            Console.WriteLine(addDrink(drink));
            Console.WriteLine(doPayment());

        }

        public string welcome()
        {
            return "Welcome to McDonal";
        }

        public abstract string addMainIngredient();

        public abstract string addSencondIngredient();

        public string addDrink(int drink)
        {
            var selectedDrink = string.Empty;
            switch(drink)
            {
                case 1:
                    selectedDrink = "Coca-cola";
                    break;
                case 2:
                    selectedDrink = "Sprite";
                    break;
                default:
                    selectedDrink = "Drink";
                    break;
            }
            return "Here is ur " + selectedDrink;
        }

        public string doPayment()
        {
            return "The " + productName + " is done, please pay to counter.";
        }
    }
}
