using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projectt_PBO
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void ubah_karyawan_Click(object sender, EventArgs e)
        {
            if (username.Texts == "admin" && password.Texts == "admin")
            {
                new FormMainMenu().Show();
                this.Hide();

            }

            else
            {
                MessageBox.Show("Username atau Password yang Anda masukkan salah!");
                username.ResetText();
                password.ResetText();
                username.Focus();
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void NamaPelangganTextBox__TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtLihatPassword_CheckedChanged(object sender, EventArgs e)
        {
         
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void rjTextBox1__TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}


