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
    public partial class AddUsers : Form
    {
        public AddUsers()
        {
            InitializeComponent();
        }

        private void AddUsers_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(44, 62, 80);
            this.groupBox1.ForeColor = Color.White;
        }

    }
}
