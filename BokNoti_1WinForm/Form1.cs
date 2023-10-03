using BOKNoti_2Service.Webapi;

namespace BokNoti_1WinForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnListen_Click(object sender, EventArgs e)
        {
            string dt = DateTime.Now.ToLocalTime().ToString();

            String? appendlog = $"hijoejfowifjowef {dt} {Environment.NewLine}";

            txtBoxLog.Text += appendlog;
        }

        private async void btnStopListen_Click(object sender, EventArgs e)
        {
            Task<string> rval = CMRApi.Listening();

            string r = await rval;

            txtBoxLog.Text +=  $"{r}   {Environment.NewLine}";
        }
    }
}