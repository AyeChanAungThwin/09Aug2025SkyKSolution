using System;
using System.Collections.Generic;
using TestConsole.common;

namespace TestConsole.model
{
    public class Product: Entity
    {
        public Product()
        {
            
        }
        public Product(string name, Color color, Size size)
        {
            Name = name;
            Color = color;
            Size = size;
        }
        
        public string Name { get; set; }
        public Color Color { get; set; }
        public Size Size { get; set; }

        public string ToString()
        {
            return $"Name: {Name}, Color: {Color}, Size: {Size}";
        }

        /*public void filter(List<Product> products, Color color)
        {
            foreach (var product in products)
            {
                if (product.Color == color) Console.Write(product.ToString());
            }
        }
        
        public void filter(List<Product> products,Size size)
        {
            foreach (var product in products)
            {
                if (product.Size == size) Console.WriteLine(product.ToString());
            }
        }
        
        public void filter(List<Product> products, Color color, Size size)
        {
            foreach (var product in products)
            {
                if (product.Color == color && product.Size == size) Console.WriteLine(product.ToString());
            }
        }*/
    }
}