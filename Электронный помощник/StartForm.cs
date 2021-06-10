using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Электронный_помощник
{
    public partial class StartForm : Form
    {
        public StartForm()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            SelectForm f2 = new SelectForm();
            f2.Show();
            this.Hide();
            timer1.Enabled = false;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
