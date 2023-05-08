using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPC.DesignPatterns.Creational.Prototype
{
    public class Client
    {
        public static void Execute()
        {
            var p0 = new Person { Name = "Ewa Tomaszewska", Age = 55, Address = new Address { City = "Kraków", Street = "Warszawska" } };

            var p1 = new Person();
            p1.Name = "Karol Tomaszewski";
            p1.Age = 25;
            p1.Address = new Address { City = "Warszawa", Street = "Krakowska" };

            var p2 = (Person)p1.Clone();
            p2.Name = "Tomasz Tomaszewski";

            Console.WriteLine(p0);
            Console.WriteLine(p1);
            Console.WriteLine(p2);

            p2.Address.Street = "Poznańska";

            Console.WriteLine(p0);
            Console.WriteLine(p1);
            Console.WriteLine(p2);
        }
    }
}
