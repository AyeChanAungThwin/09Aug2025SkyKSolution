using TestConsole.common;

namespace TestConsole.model
{
    public class ColorPredicate: Predicate<Product>
    {
        private Color _color;
        
        public ColorPredicate(Color color)
        {
            _color = color;
        }
        
        public bool isMatched(Product item)
        {
            return item.Color == _color;
        }
    }
}