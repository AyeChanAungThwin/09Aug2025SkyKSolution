namespace TestConsole.common
{
    public interface Predicate<T>
    {
        bool isMatched(T item);
    }
}