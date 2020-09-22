using System.Collections.Generic;

namespace Sort.Strategy
{
    /// <summary>
    /// The "Strategy" abstract class
    /// </summary>
    public abstract class SortStrategy
    {
        public abstract void Sort(List<string> list);
    }
}
