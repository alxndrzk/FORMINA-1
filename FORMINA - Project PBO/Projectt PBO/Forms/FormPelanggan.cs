using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projectt_PBO.Forms
{
    public partial class FormPelanggan : Form
    {

        private string id = "";
        private int intRow = 0;
        public string nama = "";
        public FormPelanggan()
        {
            InitializeComponent();
            resetMe();
            tampilan("");

            JenisKelaminPelangganComboBoxx.Items.Add("Laki-Laki");
            JenisKelaminPelangganComboBoxx.Items.Add("Perempuan");

        }

        public string ambil_nama_pelanggan
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
            cmd.CommandText = "Select * from pelanggan";
            NpgsqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                DataTable dt = new DataTable();
                dt.Load(dr);
                dataGridView1.DataSource = dt;
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

            NamaPelangganTextBox.Texts = "";
            AlamatPelangganTextBox.Texts = "";
            NoTeleponTextBox.Texts = "";
            TanggalLahirDateTimer.Text = "";
            PekerjaanTextBox.Texts = "";


            ubah_pelanggan.Text = "Ubah ()";
            hapus_pelanggan.Text = "Hapus ()";

            CariPelanggantextBox.ResetText();

            if (CariPelanggantextBox.CanSelect)
            {
                CariPelanggantextBox.Select();
            }
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
            CRUD.cmd.Parameters.AddWithValue("nama", NamaPelangganTextBox.Texts.Trim());
            CRUD.cmd.Parameters.AddWithValue("alamat", AlamatPelangganTextBox.Texts.Trim());
            CRUD.cmd.Parameters.AddWithValue("no_telepon", NoTeleponTextBox.Texts.Trim());
            CRUD.cmd.Parameters.AddWithValue("tanggal_lahir", TanggalLahirDateTimer.Text.ToString());
            CRUD.cmd.Parameters.AddWithValue("pekerjaan", PekerjaanTextBox.Texts.Trim());
            CRUD.cmd.Parameters.AddWithValue("jenis_kelamin", JenisKelaminPelangganComboBoxx.SelectedItem.ToString());


            if (str == "Ubah" || str == "Hapus" || str == "Cari" && !string.IsNullOrEmpty(this.id))
            {
                CRUD.cmd.Parameters.AddWithValue("id", this.id);
            }
        }


        private void JenisKelaminPelangganComboBoxx_OnSelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tambah_pelanggan_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(NamaPelangganTextBox.Texts.Trim()) || string.IsNullOrEmpty(AlamatPelangganTextBox.Texts.Trim()) ||
                string.IsNullOrEmpty(NoTeleponTextBox.Texts.Trim()) || 
                string.IsNullOrEmpty(PekerjaanTextBox.Texts.Trim()))
            {
                MessageBox.Show("Harap masukkan data.", "Tambah Data", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            CRUD.sql = "INSERT INTO pelanggan(nama, alamat, no_telepon, tanggal_lahir, pekerjaan, jenis_kelamin) VALUES(@nama, @alamat, @no_telepon, @tanggal_lahir, @pekerjaan, @jenis_kelamin) ";

            execute(CRUD.sql, "Insert");

            MessageBox.Show("Data telah disimpan.", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information);

            tampilan("");

            resetMe();
        }

        private void cari_id_pelanggan_Click(object sender, EventArgs e)
        {
            NpgsqlConnection connection = new NpgsqlConnection();
            string constr = "Server=localhost;Port=5432;User Id=postgres;Password=aleand16;Database=Project PBO";
            connection.ConnectionString = constr;
            connection.Open();
            NpgsqlCommand cmd = new NpgsqlCommand();
            cmd.Connection = connection;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM pelanggan WHERE id_pelanggan ='" + CariPelanggantextBox.Texts + "'";
            NpgsqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                DataTable dt = new DataTable();
                dt.Load(dr);
                dataGridView1.DataSource = dt;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridView dgv1 = dataGridView1;

                this.id = Convert.ToString(dgv1.CurrentRow.Cells[0].Value);
                ubah_pelanggan.Text = "Ubah (" + this.id + ")";
                hapus_pelanggan.Text = "Hapus (" + this.id + ")";

                NamaPelangganTextBox.Texts = Convert.ToString(dgv1.CurrentRow.Cells[1].Value);
                AlamatPelangganTextBox.Texts = Convert.ToString(dgv1.CurrentRow.Cells[2].Value);
                NoTeleponTextBox.Texts = Convert.ToString(dgv1.CurrentRow.Cells[3].Value);
                TanggalLahirDateTimer.Text = Convert.ToString(dgv1.CurrentRow.Cells[4].Value);
                PekerjaanTextBox.Texts = Convert.ToString(dgv1.CurrentRow.Cells[5].Value);
                JenisKelaminPelangganComboBoxx.SelectedItem = Convert.ToString(dgv1.CurrentRow.Cells[6].Value);

                try
                {
                    DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                    nama = row.Cells["nama"].Value.ToString();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());

                }

            }
        }

        private void ubah_pelanggan_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count == 0)
            {
                return;
            }

            if (string.IsNullOrEmpty(this.id))
            {
                MessageBox.Show("Harap pilih kolom yang ingin diubah.", "Ubah Data", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (string.IsNullOrEmpty(NamaPelangganTextBox.Texts.Trim()) || string.IsNullOrEmpty(AlamatPelangganTextBox.Texts.Trim()) ||
                string.IsNullOrEmpty(NoTeleponTextBox.Texts.Trim()) || 
                string.IsNullOrEmpty(PekerjaanTextBox.Texts.Trim()))
            {
                MessageBox.Show("Harap masukkan data.", "Ubah Data", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            CRUD.sql = "UPDATE pelanggan SET nama = @nama, alamat = @alamat, no_telepon = @no_telepon, tanggal_lahir = @tanggal_lahir, pekerjaan = @pekerjaan WHERE id_pelanggan = @id::integer";

            execute(CRUD.sql, "Ubah");

            MessageBox.Show("Data telah berhasil diubah.", "Ubah Data", MessageBoxButtons.OK, MessageBoxIcon.Information);

            tampilan("");

            resetMe();
        }

        private void hapus_pelanggan_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count == 0)
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

                CRUD.sql = "DELETE FROM pelanggan WHERE id_pelanggan = @id::integer";

                execute(CRUD.sql, "Hapus");

                MessageBox.Show("Data telah berhasil dihapus.", "Hapus Data", MessageBoxButtons.OK, MessageBoxIcon.Information);

                tampilan("");

                resetMe();

            }
        }
    }
}
