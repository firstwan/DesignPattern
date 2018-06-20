using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    public class GoatFactory
    {
        GoatProduct product;
        public void MakeProduct(string productName)
        {
            switch(productName)
            {
                case "Milk":
                    product = new Milk();
                    break;
                case "Meat":
                    product = new Meat();
                    break;
            }
        }

        public string getDiscription()
        {
            return product.getDescription();
        }

        public string getCost()
        {
            return product.getCost();
        }
    }
}