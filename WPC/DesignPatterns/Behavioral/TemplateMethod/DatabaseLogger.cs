using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPC.DesignPatterns.Behavioral.TemplateMethod
{
    public class DatabaseLogger : Logger<object, DatabaseService>
    {
        protected override void Save(object? item, DatabaseService service)
        {
            service.Insert(item);
        }

        protected override object CreateItem(string message)
        {
            return (object)message;
        }

        protected override DatabaseService GetService()
        {
            Console.WriteLine("Connecting to Database.");
            return new DatabaseService();
        }
    }
}
