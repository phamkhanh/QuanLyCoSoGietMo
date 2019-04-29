using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace QuanLyCoSoGietMo.AppSupport
{
    public class AppMsg
    {
        private static AppMsg instance; // Ctrl + R + E

        public static AppMsg Instance
        {
            get
            {
                if (instance == null)
                    instance = new AppMsg();
                return AppMsg.instance;
            }
            private set { AppMsg.instance = value; }
        }

        public async void Red(Label label, string msg)
        {
            label.ForeColor = Color.White;
            label.BackColor = Color.Red;
            label.Text = msg;
        }

        public async void Green(Label label, string msg)
        {
            label.ForeColor = Color.White;
            label.BackColor = Color.Green;
            label.Text = msg;
        }
    }
}
