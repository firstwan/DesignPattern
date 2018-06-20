using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    public class ProcessMeat : CowFactory
    {
        public override string FinalResult()
        {
            return "meat come out";
        }

        public override string process()
        {
            return "kill the cow";
        }
    }
}