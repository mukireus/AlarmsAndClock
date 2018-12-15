using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Alarm
{
    public partial class Form_Clock : Form
    {
        public Form_Clock()
        {
            InitializeComponent();
        }

        private void Form_Clock_Load(object sender, EventArgs e)
        {
            timer.Start();
            lblClock.Font = new Font("futura", 50, FontStyle.Bold);
            lblClock.Text = DateTime.Now.ToString("hh:mm");
            lblSecond.Font = new Font("futura", 15, FontStyle.Regular);
            lblSecond.Text = DateTime.Now.ToString("ss");
            
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            timer.Start();
            lblClock.Text = DateTime.Now.ToString("hh:mm");
            lblSecond.Text = DateTime.Now.ToString("ss");

            try
            {
                circularProgressBar.Value = Convert.ToInt32(lblSecond.Text);
            }
            catch (Exception)
            {
                return;
            }
        }
    }
}
