using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.Strategy.SortStrategy
{
    /// <summary>

    /// The 'Context' class

    /// </summary>

    class SortedList

    {
        private List<string> _list = new List<string>();
        private StrategyClass _sortstrategy;

        public void SetSortStrategy(StrategyClass sortstrategy)
        {
            this._sortstrategy = sortstrategy;
        }

        public void Add(string name)
        {
            _list.Add(name);
        }

        public void Sort()
        {
            _sortstrategy.Sort(_list);

            // Iterate over list and display results

            foreach (string name in _list)
            {
                Console.WriteLine(" " + name);
            }
            Console.WriteLine();
        }
    }
}
