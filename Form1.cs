using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Splash_Screen
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            string usuario, senha;
            usuario = txtUser.Text;
            senha = txtPaswd.Text;

            if (usuario == "Admin" && senha == "Admin")
            {
                Form2 novo = new Form2();
                novo.Show();
                this.Visible = false;
            }
        }
    }
}
