using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using XIIRPL1_09_Ticketing.MasterForm;

namespace XIIRPL1_09_Ticketing
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void txtLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmRegister register = new FrmRegister();
            register.Show();
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
        }

        private void label3_Click(object sender, EventArgs e)
        {
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
