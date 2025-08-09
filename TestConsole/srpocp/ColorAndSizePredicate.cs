using TestConsole.common;

namespace TestConsole.model
{
    public class ColorAndSizePredicate: Predicate<Product>
    {
        private Predicate<Product> _pred1, _pred2;
        
        public ColorAndSizePredicate(Predicate<Product> pred1, Predicate<Product> pred2)
        {
            _pred1 = pred1;
            _pred2 = pred2;
        }
        
        public bool isMatched(Product item)
        {
            return _pred1.isMatched(item) && _pred2.isMatched(item);
        }
    }
}