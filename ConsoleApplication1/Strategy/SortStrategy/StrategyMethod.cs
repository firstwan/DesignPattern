using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.Strategy.SortStrategy
{
    /// <summary>

    /// A 'ConcreteStrategy' class

    /// </summary>

    class QuickSort : StrategyClass

    {
        public void Sort(List<string> list)
        {
            list.Sort(); // Default is Quicksort

            Console.WriteLine("QuickSorted list ");
        }
    }

    /// <summary>

    /// A 'ConcreteStrategy' class

    /// </summary>

    class ShellSort : StrategyClass

    {
        public void Sort(List<string> list)
        {
            //list.ShellSort(); not-implemented

            Console.WriteLine("ShellSorted list ");
        }
    }

    /// <summary>

    /// A 'ConcreteStrategy' class

    /// </summary>

    class MergeSort : StrategyClass

    {
        public void Sort(List<string> list)
        {
            //list.MergeSort(); not-implemented

            Console.WriteLine("MergeSorted list ");
        }
    }
}
