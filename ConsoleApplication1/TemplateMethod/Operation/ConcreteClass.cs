using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.TemplateMethod.Operation
{
    /// <summary>

    /// A 'ConcreteClass' class

    /// </summary>

    public class ConcreteClassA : TemplateMethodAbstractClass

    {
        public override void PrimitiveOperation1()
        {
            Console.WriteLine("ConcreteClassA.PrimitiveOperation1()");
        }
        public override void PrimitiveOperation2()
        {
            Console.WriteLine("ConcreteClassA.PrimitiveOperation2()");
        }
    }

    /// <summary>

    /// A 'ConcreteClass' class

    /// </summary>

    public class ConcreteClassB : TemplateMethodAbstractClass

    {
        public override void PrimitiveOperation1()
        {
            Console.WriteLine("ConcreteClassB.PrimitiveOperation1()");
        }
        public override void PrimitiveOperation2()
        {
            Console.WriteLine("ConcreteClassB.PrimitiveOperation2()");
        }
    }

}
