using Sort.Strategy;
using System;
using System.Collections.Generic;

namespace Sort.ConcreteStrategy
{
    /// <summary>
    /// A 'ConcreteStrategy' class
    /// </summary>
    public class ShellSort : SortStrategy
    {
        public override void Sort(List<string> list)
        {
            // list.ShellSort(); // not implemented
            Console.WriteLine("ShellSorted list");
        }
    }
}
