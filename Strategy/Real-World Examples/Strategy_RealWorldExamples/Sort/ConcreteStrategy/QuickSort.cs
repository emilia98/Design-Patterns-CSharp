using Sort.Strategy;
using System;
using System.Collections.Generic;

namespace Sort.ConcreteStrategy
{
    /// <summary>
    /// A 'ConcreteStrategy' class
    /// </summary>
    public class QuickSort : SortStrategy
    {
        public override void Sort(List<string> list)
        {
            list.Sort(); // Default is QuickSort
            Console.WriteLine("QuickSorted list ");
        }
    }
}
