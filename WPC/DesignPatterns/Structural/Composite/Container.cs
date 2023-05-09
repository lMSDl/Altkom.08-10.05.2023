using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPC.DesignPatterns.Structural.Composite
{
    public abstract class Container : IProduct
    {
        private ICollection<IProduct> _products = new List<IProduct>();
        public void Add(IProduct product)
        {
            _products.Add(product);
        }
        public abstract string Name { get; }

        public float GetValue()
        {
            var value = _products.Sum(x => x.GetValue());
            Console.WriteLine($"Wartość {Name} to {value}");
            return value;
        }
    }
}
