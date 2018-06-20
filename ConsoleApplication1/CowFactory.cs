using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    public abstract class CowFactory
    {
        public void HoldTheCow()
        {

        }

        public abstract string process();

        public abstract string FinalResult();

        public void start()
        {
            HoldTheCow();
            process();
            FinalResult();
        }

    }
}