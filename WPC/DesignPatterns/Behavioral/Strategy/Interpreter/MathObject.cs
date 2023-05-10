using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPC.DesignPatterns.Behavioral.Strategy.Interpreter
{
    internal class MathObject
    {
        public float A { get; set; }
        public float B { get; set; }

        public Func<float, float, float> Func { get; set; }
    }
}
