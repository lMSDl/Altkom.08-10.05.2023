using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPC.DesignPatterns.Structural.Composite
{
    public abstract class Leaf : IProduct
    {
        public abstract string Name { get; }
        public float Price { get; set; }

        public Leaf(float price)
        {
            Price = price;
        }
        public float GetValue()
        {
            Console.WriteLine($"Wartość {Name} to {Price}");
            return Price;
        }
    }
}
