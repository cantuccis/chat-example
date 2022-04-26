using Frontend.UserControls.InAppNotification;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;

namespace Frontend.UserControls.InAppNotificationPanel
{
    internal class ErrorNotification : Notification
    {
        public ErrorNotification(string text) : base(text)
        {
            this.icon.Image = Properties.Resources.warning;
        }
    }
}
