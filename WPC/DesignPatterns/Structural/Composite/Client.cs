using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPC.DesignPatterns.Structural.Composite
{
    internal class Client
    {
        public static void Execute()
        {
            var warehouse = new Warehouse();
            var shelf1 = new Shelf();
            var shelf2 = new Shelf();
            var box1 = new Box();
            var box2 = new Box();
            var box3 = new Box();

            warehouse.Add(shelf1);
            warehouse.Add(shelf2);


            shelf1.Add(box1);
            shelf2.Add(box3);

            warehouse.Add(box2);

            for (int i = 0; i < 10; i++)
            {
                box1.Add(new Cookie(4.15f));
                box2.Add(new Tea(10f));
                box3.Add(new Toy(30f));
            }
            for (int i = 0; i < 3; i++)
            {
                shelf2.Add(new Toy(10f));
            }
            warehouse.Add(new Cookie(2));

            //warehouse.GetValue();

            //box2.GetValue();
            shelf2.GetValue();
        }
        }
}
