using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.TemplateMethod.McDonal
{
    public class TestProgram
    {
        static void Main()
        {
            int choose;
            TemplateClass seelctedMenu;
            do
            {
                Console.WriteLine("1. McChicken");
                Console.WriteLine("2. Fish-O-Fish");
                Console.WriteLine("3. Exit");
                Console.Write(">>>");
                choose = int.Parse(Console.ReadLine());

                switch(choose)
                {
                    case 1:
                    case 2:
                        if (choose == 1)
                        {
                            seelctedMenu = new McChicken();
                        }
                        else
                        {
                            seelctedMenu = new Fish_O_Fish();
                        }

                        Console.WriteLine("1. Coke");
                        Console.WriteLine("2. Sprite");
                        Console.Write(">>>");
                        var drink = int.Parse(Console.ReadLine());

                        seelctedMenu.MakeBugger(drink);

                        Console.ReadLine();
                        Console.Clear();
                        break;
                    default:
                        Console.Clear();
                        break;
                }

                
            } while (choose != 3);
        }
    }
}
