using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    public class Toyota : Car
    {
        public Toyota()
        {
            setStartUpStyle(new Style1());
        }
    }

    public class NewCar1 : Car
    {
        public NewCar1() {
            setStartUpStyle(new Style1());
        }
    }

    public class NewCar2 : Car
    {
        public NewCar2()
        {
            setStartUpStyle(new Style2());
        }
        
    }
}