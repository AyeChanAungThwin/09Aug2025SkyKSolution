using System.Collections.Generic;

namespace TestConsole.common
{
    public interface Filter<T>
    {
        void filter(List<T> items, Predicate<T> predicate);
    }
}