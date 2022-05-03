using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Frontend.UserControls.ChatPanel
{
    public partial class MessageBubble : UserControl
    {
        public MessageBubble(BusinessLogic.Message message)
        {
            InitializeComponent();
            lblName.Text = message.User.Username;
            messageLbl.Text = message.MessageBody;
            profilePicImg.Image = message.User.ProfileImage ?? Properties.Resources.user;
        }
    }
}
