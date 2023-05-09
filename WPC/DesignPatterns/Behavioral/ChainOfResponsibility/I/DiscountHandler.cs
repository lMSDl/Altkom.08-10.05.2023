using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPC.DesignPatterns.Behavioral.ChainOfResponsibility.I
{
    public class DiscountHandler : IDiscountHandler
    {
        public float MaxDiscount { get; }
        public float MinPrice { get; }

        private IDiscountHandler _nextHandler;
        public string Name { get; }

        public DiscountHandler(float maxDiscount, float minPrice, string name, IDiscountHandler nextHandler) : this(maxDiscount, minPrice, name)
        {
            _nextHandler = nextHandler;
        }

        public DiscountHandler(float maxDiscount, float minPrice, string name)
        {
            MaxDiscount = maxDiscount;
            MinPrice = minPrice;
            Name = name;
        }

        public bool Discount(float discountValue, float productsPrice)
        {
            if(MinPrice <= productsPrice && discountValue <= MaxDiscount)
            {
                Console.WriteLine($"{Name} udzielił rabatu - {discountValue} zł");
                return true;
            }
            return _nextHandler?.Discount(discountValue, productsPrice) ?? false;
        }
    }
}
