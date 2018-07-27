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
        AddUser f1;
        public MainApp()
        {
            InitializeComponent();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            f1 = new AddUser();
            if (f1.ShowDialog(this) == DialogResult.OK)
            {
                MSstagiaire sstagiaire = new MSstagiaire();
                sstagiaire.Nom = f1.txt_lastname.Text;
                sstagiaire.NumOsia = Int32.Parse(f1.txt_OSIA.Text);
                sstagiaire.Prenom = f1.txt_name.Text;
                sstagiaire.Rue = f1.txt_adress.Text;
                sstagiaire.Ville = f1.txt_city.Text;
                sstagiaire.CodePostal = f1.txt_postal.Text;
                this.txt_OSIA.Text = sstagiaire.NumOsia.ToString();
                this.txt_lastname.Text = sstagiaire.Nom;
                this.txt_name.Text = sstagiaire.Prenom;
                this.txt_adress.Text = sstagiaire.Rue;
                this.txt_city.Text = sstagiaire.Ville;
                this.txt_postal.Text = sstagiaire.CodePostal;

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
