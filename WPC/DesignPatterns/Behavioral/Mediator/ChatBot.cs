using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPC.DesignPatterns.Behavioral.Mediator
{
    public class ChatBot : ChatMember
    {
        public ChatBot(IMediator mediator, string nick) : base(mediator, nick)
        {
        }

        public override void Receive(string from, string message, bool isPrivate)
        {
            if(isPrivate)
            {
                mediator.Send(Nick, from, message);
            }
            else
            {
                mediator.Send(Nick, message);
            }
        }
    }
}
