using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPC.DesignPatterns.Structural.Composite
{
    public class Cookie : Leaf
    {
        public Cookie(float price) : base(price)
        {
        }

        public override string Name => "Ciastko";

    }
}
