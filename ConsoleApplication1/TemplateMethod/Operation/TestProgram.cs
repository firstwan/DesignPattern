using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.TemplateMethod.Operation
{
    class TestProgram
    {

        /// <summary>

        /// Entry point into console application.

        /// </summary>

        public static void Main1()
        {
            TemplateMethodAbstractClass aA = new ConcreteClassA();
            aA.TemplateMethod();

            TemplateMethodAbstractClass aB = new ConcreteClassB();
            aB.TemplateMethod();

            // Wait for user

            Console.ReadKey();
        }
    }

}
