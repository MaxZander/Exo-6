using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exo_6
{
    public partial class MainApp : Form
    {
        AddUser f1 = new AddUser();
        public MainApp()
        {
            InitializeComponent();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            

            if (f1.ShowDialog(this) == DialogResult.OK)
            {
                this.txt_OSIA.Text = f1.txt_OSIA.Text;
                this.txt_lastname.Text = f1.txt_name.Text;
                this.txt_name.Text = f1.txt_name.Text;
                this.txt_adress.Text = f1.txt_adress.Text;
                this.txt_city.Text = f1.txt_city.Text;
                this.txt_postal.Text = f1.txt_postal.Text;

            }
            f1.Dispose();
        }

        private void f1_FormClosed(object sender, FormClosedEventArgs e)
        {
            f1 = null;
        }

        private void MainApp_Load(object sender, EventArgs e)
        {
            this.groupBox1.ForeColor = Color.White;
            this.groupBox2.ForeColor = Color.White;
            this.BackColor = Color.FromArgb(44, 62, 80);
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
