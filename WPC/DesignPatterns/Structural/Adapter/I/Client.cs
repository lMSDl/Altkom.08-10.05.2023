using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPC.SOLID.O;

namespace WPC.DesignPatterns.Structural.Adapter.I
{
    internal class Client
    {
        public static void Execute()
        {
            ICircle item = new Circle() { R = 5 };
            Square square = new Square() { A = 8 };
            item = new SquareToCircleAdapter(square);


            CheckR(item);
        }


        public static void CheckR(ICircle circle)
        {
            Console.WriteLine(circle.R <= 5);
        }
    }


}
