using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.Strategy.SortStrategy
{
    /// <summary>

    /// The 'Strategy' interface

    /// </summary>
    public interface StrategyClass
    {
        void Sort(List<string> list);
    }
}
