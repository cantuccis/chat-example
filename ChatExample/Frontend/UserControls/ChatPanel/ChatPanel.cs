using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLogic;
using Frontend.Controllers;

namespace Frontend.UserControls.ChatPanel
{
    public partial class ChatPanel : UserControl
    {
        private Chat chat;
        public ChatPanel()
        {
            InitializeComponent();
            chat = new Chat();
        }

        private void sendBtn_Click(object sender, EventArgs e)
        {
            var user = AuthController.Instance.UserSignedIn;
            var message = new BusinessLogic.Message(user: user, message: txtMessage.Text);
            chat.AddMessage(message);
            txtMessage.Text ="";
            ShowChat();
        }

        private void ShowChat() 
        {
            chatList.Controls.Clear();
           foreach(var message in chat.Messages)
            {
                var messageBubble = new MessageBubble(message);
                chatList.Controls.Add(messageBubble);
                chatList.AutoScrollPosition = new Point(messageBubble.Left, messageBubble.Top);
            }
        }

        private void txtMessage_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                sendBtn.PerformClick();
        }
    }
}
