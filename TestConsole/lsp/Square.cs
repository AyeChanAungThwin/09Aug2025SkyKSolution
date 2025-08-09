namespace TestConsole.lsp
{
    public class Square: Shape
    {
        public double Side { get; set; }
        
        public double Area()
        {
            return Side * Side;
        }
    }
}