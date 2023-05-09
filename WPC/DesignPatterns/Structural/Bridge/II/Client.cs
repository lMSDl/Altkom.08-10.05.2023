using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPC.DesignPatterns.Structural.Bridge.II
{
    internal class Client
    {
        public static void Execute()
        {
            var abstraction = new MessageAbstraction(new SmsSender());

            abstraction.Send(Console.ReadLine());

            abstraction = new MessageAbstraction(new EmailSender());

            abstraction.Send(Console.ReadLine());
        }
    }
}
