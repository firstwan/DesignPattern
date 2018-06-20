using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.TemplateMethod.Operation
{
    /// <summary>

    /// The 'AbstractClass' abstract class

    /// </summary>
    public abstract class TemplateMethodAbstractClass
    {
        public abstract void PrimitiveOperation1();
        public abstract void PrimitiveOperation2();

        // The "Template method"

        public void TemplateMethod()
        {
            Console.WriteLine("Job Started");
            PrimitiveOperation1();
            PrimitiveOperation2();
            Console.WriteLine("Job Done");
        }
    }
}
