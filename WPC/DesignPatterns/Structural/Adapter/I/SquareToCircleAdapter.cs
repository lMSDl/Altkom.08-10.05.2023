using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPC.DesignPatterns.Structural.Adapter.I
{
    internal class SquareToCircleAdapter : ICircle
    {
        private Square square;

        public SquareToCircleAdapter(Square square)
        {
            this.square = square;
        }
        public double R { get => square.A * Math.Sqrt(2) / 2.0; }
    }
}
