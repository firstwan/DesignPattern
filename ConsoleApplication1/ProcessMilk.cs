using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    public class ProcessMilk : CowFactory
    {
        public override string FinalResult()
        {
            return "Milk Product done";
        }

        public override string process()
        {
            return "collect milk";
        }
    }
}