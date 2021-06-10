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
    public partial class SelectForm : Form
    {

        public SelectForm()
        {
            InitializeComponent();
        }
        Point lastPoint;
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "admin" && textBox2.Text == "0000")
            {
                MainFormAdmin f2 = new MainFormAdmin();
                f2.Show();
                this.Hide();
            }
            else
            {
                if (textBox1.Text == "Boss" && textBox2.Text == "0000")
                {
                    MainBossForm f2 = new MainBossForm();
                    f2.Show();
                    this.Hide();
                }
                else
                {
                    if (textBox1.Text == "Manager" && textBox2.Text == "0000")
                    {
                        MainManagerForm f2 = new MainManagerForm();
                        f2.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Неверный логин или пароль!");
                    }
                }
            }

            }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void SelectForm_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void закрытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void сообщитьОбОшибкеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BugForm f2 = new BugForm();
            this.Hide();
            f2.Show();
        }

        private void выйтиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SelectForm f2 = new SelectForm();
            MainBossForm f1 = new MainBossForm();
            MainManagerForm f3 = new MainManagerForm();
            MainFormAdmin f4 = new MainFormAdmin();
            f4.Close();
            f3.Close();
            f1.Close();
            f2.Show();
            if (f2 != null && f2.Visible)
            {
                выйтиToolStripMenuItem.Enabled = false;
            }

        }
    }
}
