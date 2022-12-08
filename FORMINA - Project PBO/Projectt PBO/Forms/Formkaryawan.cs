using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using Npgsql;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace Projectt_PBO.Forms
{
    public partial class Formkaryawan : Form
    {

        private string id = "";
        private int intRow = 0;
        public string nama = "";



        public Formkaryawan()
        {   
            InitializeComponent();
            resetMe();
            tampilan("");

            JenisKelaminKaryawanComboBoxx.Items.Add("Laki-Laki");
            JenisKelaminKaryawanComboBoxx.Items.Add("Perempuan");


        }

        public string ambil_nama_karyawan
        {

            get { return nama; }


        }


        private void tampilan(string cari)
        {
            NpgsqlConnection connection = new NpgsqlConnection();
            string constr = "Server=localhost;Port=5432;User Id=postgres;Password=aleand16;Database=Project PBO";
            connection.ConnectionString = constr;
            connection.Open();
            NpgsqlCommand cmd = new NpgsqlCommand();
            cmd.Connection = connection;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Select * from karyawan";
            NpgsqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                DataTable dt = new DataTable();
                dt.Load(dr);
                dataGridView2.DataSource = dt;
                dataGridView2.AllowUserToAddRows = false;
                dataGridView2.Refresh();
                
                if (dt.Rows.Count > 0)
                {
                    intRow = Convert.ToInt32(dt.Rows.Count.ToString());
                }
                else
                {
                    intRow = 0;
                }
            }

            jumlah_baris.Text = "Jumlah Baris: " + intRow.ToString();

            string strcari = string.Format("%{0}%", cari);

            CRUD.cmd = new NpgsqlCommand(CRUD.sql, CRUD.con);
            CRUD.cmd.Parameters.Clear();
            CRUD.cmd.Parameters.AddWithValue("cari", strcari);

            cmd.Dispose();
            connection.Close();

        }

        private void resetMe()
        {
            this.id = string.Empty;

            NamaKaryawanTextBox.Texts = "";
            NamaKaryawanTextBox.Text = "";
            AlamatKaryawanTextBox.Texts = "";
            NoTeleponTextBox.Texts = "";
            TanggalLahirDateTimerr.Text = "";

            if (JenisKelaminKaryawanComboBoxx.Items.Count > 0)
            {
                JenisKelaminKaryawanComboBoxx.SelectedIndex = 0;
            }

            ubah_karyawan.Text = "Ubah ()";
            hapus_karyawan.Text = "Hapus ()";

            
            CariKaryawantextBox.ResetText();

            if (CariKaryawantextBox.CanSelect)
            {
                CariKaryawantextBox.Select();
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {
            tampilan("");
        }
        private void execute(string mySQL, string param)
        {
            CRUD.cmd = new NpgsqlCommand(mySQL, CRUD.con);
            addParameters(param);
            CRUD.PerformCRUD(CRUD.cmd);
        }

        private void addParameters(string str)
        {
            CRUD.cmd.Parameters.Clear();
            CRUD.cmd.Parameters.AddWithValue("nama", NamaKaryawanTextBox.Texts.Trim());
            CRUD.cmd.Parameters.AddWithValue("alamat", AlamatKaryawanTextBox.Texts.Trim());
            CRUD.cmd.Parameters.AddWithValue("no_telepon", NoTeleponTextBox.Texts.Trim());
            CRUD.cmd.Parameters.AddWithValue("jenis_kelamin", JenisKelaminKaryawanComboBoxx.SelectedItem.ToString());
            CRUD.cmd.Parameters.AddWithValue("tanggal_lahir", TanggalLahirDateTimerr.Text.ToString());

            if (str == "Ubah" || str == "Hapus" || str == "Cari" && !string.IsNullOrEmpty(this.id))
            {
                CRUD.cmd.Parameters.AddWithValue("id", this.id);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridView dgv1 = dataGridView2;

                this.id = Convert.ToString(dgv1.CurrentRow.Cells[0].Value);
                ubah_karyawan.Text = "Ubah (" + this.id + ")";
                hapus_karyawan.Text = "Hapus (" + this.id + ")";

                NamaKaryawanTextBox.Texts = Convert.ToString(dgv1.CurrentRow.Cells[1].Value);
                AlamatKaryawanTextBox.Texts = Convert.ToString(dgv1.CurrentRow.Cells[2].Value);
                NoTeleponTextBox.Texts = Convert.ToString(dgv1.CurrentRow.Cells[3].Value);
                JenisKelaminKaryawanComboBoxx.SelectedItem = Convert.ToString(dgv1.CurrentRow.Cells[4].Value);
                TanggalLahirDateTimerr.Text = Convert.ToString(dgv1.CurrentRow.Cells[5].Value);

            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridView dgv1 = dataGridView2;

                this.id = Convert.ToString(dgv1.CurrentRow.Cells[0].Value);
                ubah_karyawan.Text = "Ubah (" + this.id + ")";
                hapus_karyawan.Text = "Hapus (" + this.id + ")";

                NamaKaryawanTextBox.Texts = Convert.ToString(dgv1.CurrentRow.Cells[1].Value);
                AlamatKaryawanTextBox.Texts = Convert.ToString(dgv1.CurrentRow.Cells[2].Value);
                NoTeleponTextBox.Texts = Convert.ToString(dgv1.CurrentRow.Cells[3].Value);
                JenisKelaminKaryawanComboBoxx.SelectedItem = Convert.ToString(dgv1.CurrentRow.Cells[4].Value);
                TanggalLahirDateTimerr.Text = Convert.ToString(dgv1.CurrentRow.Cells[5].Value);

                try
                {
                    DataGridViewRow row = this.dataGridView2.Rows[e.RowIndex];
                    nama = row.Cells["nama"].Value.ToString();
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());

                }

            }


        }
     

        

        private void alamat_karyawan_Click(object sender, EventArgs e)
        {

        }


        private void no_telepon_karyawan_Click(object sender, EventArgs e)
        {

        }

        private void jenis_kelamin_karyawan_Click(object sender, EventArgs e)
        {

        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void jumlah_baris_Click(object sender, EventArgs e)
        {

        }


        private void tambah_karyawan_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(NamaKaryawanTextBox.Texts.Trim()) || string.IsNullOrEmpty(AlamatKaryawanTextBox.Texts.Trim()) ||
                string.IsNullOrEmpty(NoTeleponTextBox.Texts.Trim()))
            {
                MessageBox.Show("Harap masukkan data.", "Tambah Data", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            CRUD.sql = "INSERT INTO karyawan(nama, alamat, no_telepon, jenis_kelamin, tanggal_lahir) VALUES(@nama, @alamat, @no_telepon, @jenis_kelamin, @tanggal_lahir) ";

            execute(CRUD.sql, "Insert");

            MessageBox.Show("Data telah disimpan.", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information);

            tampilan("");

            resetMe();
        }

        private void ubah_karyawan_Click_1(object sender, EventArgs e)
        {
            if (dataGridView2.Rows.Count == 0)
            {
                return;
            }

            if (string.IsNullOrEmpty(this.id))
            {
                MessageBox.Show("Harap pilih kolom yang ingin diubah.", "Ubah Data", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (string.IsNullOrEmpty(NamaKaryawanTextBox.Texts.Trim()) || string.IsNullOrEmpty(AlamatKaryawanTextBox.Texts.Trim()) ||
                string.IsNullOrEmpty(NoTeleponTextBox.Texts.Trim()))
            {
                MessageBox.Show("Harap masukkan data.", "Ubah Data", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            CRUD.sql = "UPDATE karyawan SET nama = @nama, alamat = @alamat, no_telepon = @no_telepon, jenis_kelamin = @jenis_kelamin, tanggal_lahir = @tanggal_lahir WHERE id_karyawan = @id::integer";

            execute(CRUD.sql, "Ubah");

            MessageBox.Show("Data telah berhasil diubah.", "Ubah Data", MessageBoxButtons.OK, MessageBoxIcon.Information);

            tampilan("");

            resetMe();
        }

        private void hapus_karyawan_Click_1(object sender, EventArgs e)
        {
            if (dataGridView2.Rows.Count == 0)
            {
                return;
            }

            if (string.IsNullOrEmpty(this.id))
            {
                MessageBox.Show("Harap pilih kolom yang ingin dihapus.", "Hapus Data", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (MessageBox.Show("Apakah anda yakin untuk menghapus data ini?", "Hapus Data", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {

                CRUD.sql = "DELETE FROM karyawan WHERE id_karyawan = @id::integer";

                execute(CRUD.sql, "Hapus");

                MessageBox.Show("Data telah berhasil dihapus.", "Hapus Data", MessageBoxButtons.OK, MessageBoxIcon.Information);

                tampilan("");

                resetMe();

            }

            tampilan("");

            resetMe();
        }

        private void cari_id_karyawan_Click_1(object sender, EventArgs e)
        {
                NpgsqlConnection connection = new NpgsqlConnection();
                string constr = "Server=localhost;Port=5432;User Id=postgres;Password=aleand16;Database=Project PBO";
                connection.ConnectionString = constr;
                connection.Open();
                NpgsqlCommand cmd = new NpgsqlCommand();
                cmd.Connection = connection;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT * FROM karyawan WHERE id_karyawan ='" + CariKaryawantextBox.Texts + "'";
                NpgsqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    DataTable dt = new DataTable();
                    dt.Load(dr);
                    dataGridView2.DataSource = dt;
                }
                
        }


        private void NamaKaryawanTextBox__TextChanged(object sender, EventArgs e)
        {

        }
    }
}
