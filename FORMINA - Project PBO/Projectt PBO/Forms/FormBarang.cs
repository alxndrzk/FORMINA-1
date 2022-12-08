using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Projectt_PBO.Forms
{
    public partial class FormBarang : Form
    {

        private string id = "";
        private int intRow = 0;
        public string nama, harga = "";


        public FormBarang()
        {
            InitializeComponent();
            resetMe();
            tampilan("");
            //MunculDataBarang();




        }

        public string ambil_nama_barang
        {
            get { return nama; }

        }
        public string ambil_harga_barang
        {
            get { return harga; }
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
            cmd.CommandText = "Select * from barang";
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

            baris_produk.Text = "Jumlah Baris: " + intRow.ToString();

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

            textbox_namabarang.Texts = "";
            textbox_harga.Texts = "";


            ubah_barang.Text = "Ubah()";
            button1.Text = "Hapus()";

            cari_id_barang_box.ResetText();

            if (cari_id_barang_box.CanSelect)
            {
                cari_id_barang_box.Select();
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
            CRUD.cmd.Parameters.AddWithValue("nama", textbox_namabarang.Texts.Trim());
            CRUD.cmd.Parameters.AddWithValue("harga", textbox_harga.Texts.Trim());

            if (str == "Ubah" || str == "Hapus" || str == "Cari" && !string.IsNullOrEmpty(this.id))
            {
                CRUD.cmd.Parameters.AddWithValue("id", this.id);
            }
        }



        private void tambah_barang_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textbox_namabarang.Texts.Trim()) || string.IsNullOrEmpty(textbox_harga.Texts.Trim()))
            {
                MessageBox.Show("Harap masukkan data.", "Tambah Data", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            CRUD.sql = "INSERT INTO barang(nama, harga) VALUES(@nama, @harga) ";

            execute(CRUD.sql, "Insert");

            MessageBox.Show("Data telah disimpan.", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information);

            tampilan("");

            resetMe();
        }

        private void ubah_barang_Click_1(object sender, EventArgs e)
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

            if (string.IsNullOrEmpty(textbox_namabarang.Texts.Trim()) || string.IsNullOrEmpty(textbox_harga.Texts.Trim()))
            {
                MessageBox.Show("Harap masukkan data.", "Ubah Data", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            CRUD.sql = "UPDATE barang SET nama = @nama, harga = @harga WHERE id_barang = @id::integer";

            execute(CRUD.sql, "Ubah");

            MessageBox.Show("Data telah berhasil diubah.", "Ubah Data", MessageBoxButtons.OK, MessageBoxIcon.Information);

            tampilan("");

            resetMe();
        }

        private void button1_Click_1(object sender, EventArgs e)
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

                CRUD.sql = "DELETE FROM barang WHERE id_barang = @id::integer";

                execute(CRUD.sql, "Hapus");

                MessageBox.Show("Data telah berhasil dihapus.", "Hapus Data", MessageBoxButtons.OK, MessageBoxIcon.Information);

                tampilan("");

                resetMe();

            }

            tampilan("");

            resetMe();
        }

        private void cari_kode_barang_Click_1(object sender, EventArgs e)
        {
            NpgsqlConnection connection = new NpgsqlConnection();
            string constr = "Server=localhost;Port=5432;User Id=postgres;Password=aleand16;Database=Project PBO";
            connection.ConnectionString = constr;
            connection.Open();
            NpgsqlCommand cmd = new NpgsqlCommand();
            cmd.Connection = connection;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM barang WHERE id_barang ='" + cari_id_barang_box.Texts + "'";
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
                ubah_barang.Text = "Ubah (" + this.id + ")";
                button1.Text = "Hapus (" + this.id + ")";

                textbox_namabarang.Texts = Convert.ToString(dgv1.CurrentRow.Cells[1].Value);
                textbox_harga.Texts = Convert.ToString(dgv1.CurrentRow.Cells[2].Value);

                try
                {
                    DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                    nama = row.Cells["nama"].Value.ToString();
                    harga = row.Cells["harga"].Value.ToString();
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }


        }

    }
}
