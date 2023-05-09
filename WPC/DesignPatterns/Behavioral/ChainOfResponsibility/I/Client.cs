using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPC.DesignPatterns.Behavioral.ChainOfResponsibility.I
{
    internal class Client
    {
        public static void Execute()
        {
            var handler4 = new DiscountHandler(1000, 6000, "Kierownik sklepu");
            var handler3 = new DiscountHandler(1000, 7000, "Kierownik sali", handler4);
            //var handler2 = new DiscountHandler(500, 9000, "Kierownik kas", handler3);
            var handler1 = new DiscountHandler(100, 10000, "Kasjer", handler3);


            var result = handler1.Discount(500, 15000);
            if(!result)
                Console.WriteLine("Nie otrzymano rabatu");



            result = handler3.Discount(600, 8000);
            if (!result)
                Console.WriteLine("Nie otrzymano rabatu");
        }
        }
}
