using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinLossCounter
{
    public partial class Loading : Form
    {
        public Loading()
        {
            InitializeComponent();
        }

        private async void Loading_Load(object sender, EventArgs e)
        {
            Hide();
            this.TransparencyKey = Color.Black;
            Show();
            this.Size = Screen.FromControl(this).Bounds.Size;
            int screenwidth = Screen.FromControl(this).Bounds.Width;
            int screenheight = Screen.FromControl(this).Bounds.Height;
            label1.Location = new Point(Convert.ToInt32(screenwidth / 2 - 157), Convert.ToInt32(screenheight / 2));
            TopMost = true;
            await Task.Delay(1500);
            Close();
        }
    }
}
