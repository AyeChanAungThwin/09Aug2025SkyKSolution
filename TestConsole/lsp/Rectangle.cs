namespace TestConsole.lsp
{
    public class Rectangle: Shape
    {
        public double Width { get; set; }
        public double Length { get; set; }
        
        public double Area()
        {
            return Width * Length;
        }
    }
}