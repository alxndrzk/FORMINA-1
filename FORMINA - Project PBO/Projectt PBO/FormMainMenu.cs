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
    public partial class FormMainMenu : Form
    {
        private Form activeForm;
        public FormMainMenu()
        {
            InitializeComponent();
        }

        private void openchildform(Form childform, object btnsender)
        {
            if(activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = childform;
            childform.TopLevel = false;
            childform.FormBorderStyle = FormBorderStyle.None;
            childform.Dock = DockStyle.Fill;
            this.paneldesktop.Controls.Add(childform);
            this.paneldesktop.Tag = childform;
            childform.BringToFront();
            childform.Show();
            labeltitle.Text = childform.Text;


        }

 
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            openchildform(new Forms.Formkaryawan(), sender);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Pegawai_Click(object sender, EventArgs e)
        {
            openchildform(new Forms.Formkaryawan(), sender);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openchildform(new Forms.FormPelanggan(), sender);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            openchildform(new Forms.Formtransaksi(), sender);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            openchildform(new Forms.FormPelanggan(), sender);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            openchildform(new Forms.FormBarang(), sender);
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            openchildform(new Forms.FormBarang(), sender);
        }

        private void label2_Click(object sender, EventArgs e)
        {
            new FormMainMenu().Show();
            this.Hide();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            openchildform(new Forms.Formtransaksi(), sender);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            openchildform(new Forms.FormAboutUs(), sender);
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            openchildform(new Forms.FormAboutUs(), sender);
        }
    }
}
