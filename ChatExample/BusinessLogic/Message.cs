using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public struct Message
    {
        public Message(User user, string message)
        {
            User = user;
            MessageBody = message;
            Date = DateTimeProvider.Now;
        }

        public User User { get; private set; }
        public string MessageBody { get; private set; }
        public DateTime Date { get; private set; }
        
    }
}
