using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPC.DesignPatterns.Behavioral.Mediator
{
    public class Client
    {
        public static void Execute()
        {
            var chat = new ChatMediator();

            var user = new ChatUser(chat, "Paul");
            var bot1 = new ChatBot(chat, "Alexa");
            var bot2 = new ChatBot(chat, "Siri");


            while (true)
            {
                var message = Console.ReadLine();
                user.Send(message);
            }

        }
    }
}
