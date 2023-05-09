using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPC.DesignPatterns.Structural.Bridge.I
{
    internal class Client
    {
        public static void Execute()
        {
            Color color1 = new Blue();
            Color color2 = new Red();

            Shape shape = new Square();
            Console.WriteLine(shape);

            shape.Color = color1;
            Console.WriteLine(shape);

            shape.Color = color2;
            Console.WriteLine(shape);



            shape = new Circle();
            Console.WriteLine(shape);
            shape.Color = color1;
            Console.WriteLine(shape);

            shape.Color = color2;
            Console.WriteLine(shape);
        }
    }
}
