using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPC.DesignPatterns.Structural.Decorator
{
    internal class Client
    {
        public static void Execute()
        {
            while (true)
            {
                var text = Console.ReadLine();
                
                var notification = (INotification)new Notification();


               // if (text.Length < 10)
                    notification = new SMSNotification(notification);
                if(ValidEmail())
                    notification = new EmailNotification(notification);



                notification.Send(text);
            }
        }

        static bool ValidEmail()
        {
            return DateTime.Now.Second % 2 == 0;
        }
    }
}
