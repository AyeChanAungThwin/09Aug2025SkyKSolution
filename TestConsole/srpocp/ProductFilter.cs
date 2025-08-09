using System;
using System.Collections.Generic;
using TestConsole.common;

namespace TestConsole.model
{
    public class ProductFilter: Filter<Product>
    {
        public void filter(List<Product> items, common.Predicate<Product> predicate)
        {
            foreach (var product in items)
            {
                if (predicate.isMatched(product)) Console.WriteLine(product.ToString());
            }
        }
    }
}