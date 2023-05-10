using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPC.DesignPatterns.Behavioral.TemplateMethod
{
    public class EmailLogger : Logger<string, IDisposable>
    {


        private void SendLogToEmail(string message)
        {
            Console.WriteLine("Sending Email with Log Message : " + message);
        }

        protected override void Save(string? item, IDisposable service)
        {
            Console.WriteLine("Sending Email with Log Message : " + item);
        }

        protected override string CreateItem(string message)
        {
            return message;
        }

        protected override IDisposable GetService()
        {
            return null;
        }
    }
}
