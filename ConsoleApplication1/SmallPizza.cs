using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    public class SmallPizza : IPizza
    {

        public string GetPrice()
        {
            throw new NotImplementedException();
        }

        public string GetSize()
        {
            throw new NotImplementedException();
        }
    }

    public class LargePizza : IPizza
    {

        public string GetPrice()
        {
            throw new NotImplementedException();
        }

        public string GetSize()
        {
            throw new NotImplementedException();
        }
    }
}