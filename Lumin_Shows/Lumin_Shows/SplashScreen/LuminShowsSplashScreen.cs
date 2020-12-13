using System;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Lumin_Shows.SplashScreen
{
    public partial class LuminShowsSplashScreen : Form
    {
        public LuminShowsSplashScreen()
        {
            InitializeComponent();
        }

        private void LuminShowsSplashScreen_Load(object sender, EventArgs e)
        {
            Task.Factory.StartNew(() =>
            {
                System.Threading.Thread.Sleep(100);
                for (int i = 0; i <= 100; i++)
                {
                    this.Invoke((MethodInvoker)delegate
                    {
                        progressBar1.Value = i;
                        System.Threading.Thread.Sleep(50);
                        progressBar1.Refresh();
                    });
                }
            }).ContinueWith((x) => {
                this.Invoke((MethodInvoker)delegate
                { this.Close(); });
            });
        }
    }
}
