using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPC.DesignPatterns.Structural.Decorator
{
    internal class SMSNotification : BaseDecorator
    {
        public SMSNotification(INotification notification) : base(notification)
        {
        }

        protected override void ExtraSend(string message)
        {
            if(message.Length < 10)
            Console.WriteLine($"SMS: {message}");
        }
    }
}
