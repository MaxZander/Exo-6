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
        AddUsers f1;
        public MainApp()
        {
            InitializeComponent();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            f1 = new AddUsers();

            if (f1.ShowDialog(this) == DialogResult.OK)
            {
                this.txt_OSIA.Text = f1.txt_OSIA.Text;
            }
            else
            {
                MessageBox.Show("Ajout annulé.", "Annulation", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
