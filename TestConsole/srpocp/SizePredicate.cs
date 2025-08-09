using TestConsole.common;

namespace TestConsole.model
{
    public class SizePredicate: Predicate<Product>
    {
        private Size _size;

        public SizePredicate(Size size)
        {
            _size = size;
        }
        
        public bool isMatched(Product item)
        {
            return item.Size == _size;
        }
    }
}