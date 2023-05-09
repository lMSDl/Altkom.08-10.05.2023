using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPC.DesignPatterns.Structural.Proxy
{
    internal class Client
    {
        public static void Execute()
        {
            IDatabase database = new Database();
            database = new DatabaseProxy(database , () => new Database());


            for (var i = 1; i < 11; i++)
            {
                _ = database.RequestAsync(i);
            }

            Console.ReadLine();

            for (var i = 1; i < 11; i++)
            {
                _ = database.RequestAsync(i);
            }


            Console.ReadLine();
        }
    }
}
