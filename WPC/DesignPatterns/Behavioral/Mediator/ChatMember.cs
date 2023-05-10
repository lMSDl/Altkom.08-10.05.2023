using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPC.DesignPatterns.Behavioral.Mediator
{
    public abstract class ChatMember
    {
        protected IMediator mediator;
        public string Nick { get; }

        public ChatMember(IMediator mediator, string nick)
        {
            this.mediator = mediator;
            Nick = nick;
            mediator.Join(this);
        }

        public abstract void Receive(string from, string message, bool isPrivate); 

    }
}
