using Frontend.UserControls.InAppNotificationPanel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Transitions;

namespace Frontend.UserControls.InAppNotification
{
    public partial class InAppNotification : UserControl
    {
        private static readonly Lazy<InAppNotification> lazy =
            new Lazy<InAppNotification>(() => new InAppNotification());
        public static InAppNotification Instance { get { return lazy.Value; } }

        public InAppNotification()
        {
            InitializeComponent();
        }

        public void ShowError(string text)
        {
            var notification = new ErrorNotification(text);
            this.Controls.Add(notification);
            notification.Left = (this.ClientSize.Width - notification.Width) / 2;
            notification.Top = (this.ClientSize.Height - notification.Height) / 2;
            notification.ShowUp();
        }

        public void ShowMessage(string text)
        {
            var notification = new Notification(text);
            this.Controls.Add(notification);
            notification.Left = (this.ClientSize.Width - notification.Width) / 2;
            notification.Top = (this.ClientSize.Height - notification.Height) / 2;
            notification.ShowUp();
        }

    }
}
