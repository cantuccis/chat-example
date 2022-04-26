using System.Drawing;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Transitions;

namespace Frontend.UserControls.InAppNotification
{
    public partial class Notification : UserControl
    {
        public Notification(string text)
        {
            InitializeComponent();
            notificationLbl.Text = text;
            icon.Image = Properties.Resources.info;
        }

        public void ShowUp()
        {
            int previousLocationY = this.Location.Y;
            this.Location = new Point(this.Location.X, this.Location.Y + 20);
            Transition.run(this, "Top", previousLocationY, new TransitionType_Linear(250));
            Task.Factory.StartNew(() => Thread.Sleep(5 * 1000))
            .ContinueWith((t) =>
            {
                Transition.run(this, "Top", previousLocationY + 100, new TransitionType_Linear(250));
            }, TaskScheduler.FromCurrentSynchronizationContext());
        }
    }
}
