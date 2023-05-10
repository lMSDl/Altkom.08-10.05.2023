using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPC.DesignPatterns.Behavioral.Mediator
{
    public class ChatMediator : IMediator
    {
        private readonly ICollection<ChatMember> _chatMembers = new List<ChatMember>();

        public void Join(ChatMember chatMember)
        {
            _chatMembers.Add(chatMember);
        }

        public void Send(string from, string message)
        {
            var sender = _chatMembers.Where(x => x.Nick == from);
            if (sender.Single() is ChatBot)
                sender = _chatMembers.Where(x => x is ChatBot);

            foreach (var chatMember in _chatMembers.Except(sender))
            {
                chatMember.Receive(from, message, false);
            }
        }

        public void Send(string from, string to, string message)
        {
            _chatMembers.SingleOrDefault(x => x.Nick == to)?.Receive(from, message, true);
        }
    }
}
