using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.Factory
{
    class TestProgram
    {
        static void Main1()
        {
            CarFactory factory = new CarFactory();

            Vehicle newVehicle = null;


            var choose = 0;
            do
            {
                Console.WriteLine("1. Create Car");
                Console.WriteLine("2. Change Car Color");
                Console.WriteLine("3. Exit");
                Console.Write(">>>");
                choose = int.Parse(Console.ReadLine());

                if (choose == 1)
                {
                    Console.WriteLine("What vehicle ? (B / C)");
                    Console.Write(">>>");
                    var typeOfCar = Console.ReadLine();
                    newVehicle = factory.MakeVehicle(typeOfCar);
                    Console.WriteLine("\n\n------------------------");
                    newVehicle.display();
                    Console.WriteLine("\n\n");
                }
                else if (choose == 2)
                {
                    Console.WriteLine("What color ?");
                    Console.Write(">>>");
                    var colour = Console.ReadLine();
                    factory.ChangeColour(newVehicle,colour);
                    Console.WriteLine("\n\n------------------------");
                    newVehicle.display();
                    Console.WriteLine("\n\n");

                }
                else
                {
                    Console.WriteLine("\n");
                }
            } while (choose != 3);
        }
    }
}
