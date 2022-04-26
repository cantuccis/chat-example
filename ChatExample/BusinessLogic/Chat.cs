using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class Chat
    {
        private List<Message> _messages;
        public List<Message> Messages
        {
            get => new List<Message>(_messages);
            private set => _messages = value;
        }

        public void AddMessage(Message message)
        {
            _messages.Add(message);
        }

    }
}
