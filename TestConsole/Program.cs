using System;
using System.Collections.Generic;
using System.ComponentModel;
using TestConsole.common;
using TestConsole.dip;
using TestConsole.lsp;
using TestConsole.model;

namespace TestConsole
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            testDip();
        }

        public static void testDip()
        {
            var gas = new GasEngine();
            var diesel = new DieselEngine();
            
            var car = new Car(diesel);
            car.start();
        }

        public static void testLsp()
        {
            var rect = new Rectangle();
            rect.Width = 4;
            rect.Length = 2;
            Console.WriteLine("Rectangle: "+rect.Area());

            var sqr = new Square();
            sqr.Side = 4;
            Console.WriteLine("Square: "+sqr.Area());
        }

        public static void test2SRPOCP()
        {
            var ok = new ProductFilter();
            //ok.filter(getProductList(), new ColorPredicate(Color.Black));
            //ok.filter(getProductList(), new SizePredicate(Size.XL));
            ok.filter(getProductList(), new ColorAndSizePredicate(
                new ColorPredicate(Color.Red),
                new SizePredicate(Size.L)
            ));
        }

        public static void test1ViolationSRP()
        {
            //Product product = new Product();
            
            //product.filter(getProductList(), Color.White);
            //product.filter(getProductList(), Size.L);
            //product.filter(getProductList(), Color.Black, Size.L);
        }

        public static List<Product> getProductList()
        {
            var products = new List<Product>();
            products.Add(new Product("Uniqlo", Color.Black, Size.L));
            products.Add(new Product("Hush Puppy", Color.White, Size.XL));
            products.Add(new Product("LV", Color.Red, Size.L));
            products.Add(new Product("Sports", Color.Red, Size.L));
            
            return products;
        }
    }
}