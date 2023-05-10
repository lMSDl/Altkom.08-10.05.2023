using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPC.DesignPatterns.Behavioral.Mediator
{
    public class ChatUser : ChatMember
    {
        public ChatUser(IMediator mediator, string nick) : base(mediator, nick)
        {
        }

        public override void Receive(string from, string message, bool isPrivate)
        {
            Console.WriteLine($"{from}{(isPrivate ? $"to {Nick}" : "")}: {message}");
        }

        public void Send(string message)
        {
            var splitMessage = message.Split(" $ ");
            if(splitMessage.Length > 1 ) {

                mediator.Send(Nick, splitMessage[0], splitMessage[1]);
            }
            else
                mediator.Send(Nick, message);
        }
    }
}
