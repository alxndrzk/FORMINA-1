using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace Projectt_PBO.Forms
{
    public partial class Formtransaksi : Form
    {

        private string id = "";
        private int intRow = 0;
        double harga = 0;
        double jumlah = 0;

        public Formtransaksi()
        {
            InitializeComponent();
            tampilan("");
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
            cmd.CommandText = "Select * from transaksi";
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

            KaryawanTransaksiTextBox.Texts = "";
            PelangganTransaksiTextBox.Texts = "";
            BarangTransaksiTextBox.Texts = "";
            HargaTransaksiTextBox.Texts = "";
            JumlahTransaksiTextBox.Texts = "";
            TanggalDateTimer.Text = "";

            ubah_transaksi.Text = "Ubah ()";
            hapus_transaksi.Text = "Hapus ()";


            caritransaksitextbox.ResetText();

            if (caritransaksitextbox.CanSelect)
            {
                caritransaksitextbox.Select();
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

            HargaTransaksiTextBox.Text = harga.ToString();
            JumlahTransaksiTextBox.Text = jumlah.ToString();

            CRUD.cmd.Parameters.Clear();
            CRUD.cmd.Parameters.AddWithValue("karyawan", KaryawanTransaksiTextBox.Texts.Trim());
            CRUD.cmd.Parameters.AddWithValue("pelanggan", PelangganTransaksiTextBox.Texts.Trim());
            CRUD.cmd.Parameters.AddWithValue("barang", BarangTransaksiTextBox.Texts.Trim());
            CRUD.cmd.Parameters.AddWithValue("harga", HargaTransaksiTextBox.Texts.Trim());
            CRUD.cmd.Parameters.AddWithValue("jumlah", JumlahTransaksiTextBox.Texts.Trim());
            CRUD.cmd.Parameters.AddWithValue("tanggal", TanggalDateTimer.Text.ToString());
            CRUD.cmd.Parameters.AddWithValue("total", TotalTransaksiTextBox.Text.Trim());

            if (str == "Ubah" || str == "Hapus" || str == "Cari" && !string.IsNullOrEmpty(this.id))
            {
                CRUD.cmd.Parameters.AddWithValue("id", this.id);
            }
        }

        private void total_TextChanged(object sender, EventArgs e)
        {

        }

        

        private void cari_karyawan_Click(object sender, EventArgs e)
        {
            Formkaryawan kry = new Formkaryawan();
            kry.ShowDialog();
            KaryawanTransaksiTextBox.Texts = kry.ambil_nama_karyawan;
        }

        private void cari_barang_Click(object sender, EventArgs e)
        {
            FormBarang brg = new FormBarang();
            brg.ShowDialog();
            BarangTransaksiTextBox.Texts = brg.ambil_nama_barang;
            HargaTransaksiTextBox.Texts = brg.ambil_harga_barang;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridView dgv1 = dataGridView1;

                this.id = Convert.ToString(dgv1.CurrentRow.Cells[0].Value);
                ubah_transaksi.Text = "Ubah (" + this.id + ")";
                hapus_transaksi.Text = "Hapus (" + this.id + ")";

                TanggalDateTimer.Text = Convert.ToString(dgv1.CurrentRow.Cells[1].Value);
                KaryawanTransaksiTextBox.Texts = Convert.ToString(dgv1.CurrentRow.Cells[2].Value);
                PelangganTransaksiTextBox.Texts = Convert.ToString(dgv1.CurrentRow.Cells[3].Value);
                BarangTransaksiTextBox.Texts = Convert.ToString(dgv1.CurrentRow.Cells[4].Value);
                HargaTransaksiTextBox.Texts = Convert.ToString(dgv1.CurrentRow.Cells[5].Value);
                JumlahTransaksiTextBox.Texts = Convert.ToString(dgv1.CurrentRow.Cells[6].Value);
                TotalTransaksiTextBox.Text = Convert.ToString(dgv1.CurrentRow.Cells[7].Value);

            }
        }

        private void cari_pelanggan_Click(object sender, EventArgs e)
        {
            FormPelanggan plg = new FormPelanggan();
            plg.ShowDialog();
            PelangganTransaksiTextBox.Texts = plg.ambil_nama_pelanggan;
        }

        private void tambah_transaksi_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(KaryawanTransaksiTextBox.Texts.Trim()) || string.IsNullOrEmpty(PelangganTransaksiTextBox.Texts.Trim()) ||
                string.IsNullOrEmpty(BarangTransaksiTextBox.Texts.Trim()) || string.IsNullOrEmpty(HargaTransaksiTextBox.Texts.Trim()) || string.IsNullOrEmpty(JumlahTransaksiTextBox.Texts.Trim()))
            {
                MessageBox.Show("Harap masukkan data.", "Tambah Data", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            double jumlah = double.Parse(JumlahTransaksiTextBox.Texts.Trim());
            double harga = double.Parse(HargaTransaksiTextBox.Texts.Trim());

            var totall = harga * jumlah;
            TotalTransaksiTextBox.Text = totall.ToString();

            CRUD.sql = "INSERT INTO transaksi(karyawan, pelanggan, barang, harga, jumlah, tanggal, total) VALUES(@karyawan, @pelanggan, @barang, @harga, @jumlah, @tanggal, @total)";

            execute(CRUD.sql, "Insert");

            MessageBox.Show("Data telah disimpan.", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information);

            tampilan("");

            resetMe();
        }

        private void ubah_transaksi_Click(object sender, EventArgs e)
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

            if (string.IsNullOrEmpty(KaryawanTransaksiTextBox.Texts.Trim()) || string.IsNullOrEmpty(PelangganTransaksiTextBox.Texts.Trim()) ||
                string.IsNullOrEmpty(BarangTransaksiTextBox.Texts.Trim()) || string.IsNullOrEmpty(HargaTransaksiTextBox.Texts.Trim()) || string.IsNullOrEmpty(JumlahTransaksiTextBox.Texts.Trim()))
            {
                MessageBox.Show("Harap masukkan data.", "Ubah Data", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            double jumlah = double.Parse(JumlahTransaksiTextBox.Texts.Trim());
            double harga = double.Parse(HargaTransaksiTextBox.Texts.Trim());

            var totall = harga * jumlah;
            TotalTransaksiTextBox.Text = totall.ToString();

            CRUD.sql = "UPDATE transaksi SET karyawan = @karyawan, pelanggan = @pelanggan, barang = @barang, harga = @harga, jumlah = @jumlah, tanggal = @tanggal, total = @total WHERE id_transaksi = @id::integer";

            execute(CRUD.sql, "Ubah");

            MessageBox.Show("Data telah berhasil diubah.", "Ubah Data", MessageBoxButtons.OK, MessageBoxIcon.Information);

            tampilan("");

            resetMe();
        }

        private void hapus_transaksi_Click(object sender, EventArgs e)
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

                CRUD.sql = "DELETE FROM transaksi WHERE id_transaksi = @id::integer";

                execute(CRUD.sql, "Hapus");

                MessageBox.Show("Data telah berhasil dihapus.", "Hapus Data", MessageBoxButtons.OK, MessageBoxIcon.Information);

                tampilan("");

                resetMe();
            }

        }

        private void cari_id_transaksi_Click(object sender, EventArgs e)
        {
            NpgsqlConnection connection = new NpgsqlConnection();
            string constr = "Server=localhost;Port=5432;User Id=postgres;Password=aleand16;Database=Project PBO";
            connection.ConnectionString = constr;
            connection.Open();
            NpgsqlCommand cmd = new NpgsqlCommand();
            cmd.Connection = connection;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM transaksi WHERE id_transaksi ='" + caritransaksitextbox.Texts + "'";
            NpgsqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                DataTable dt = new DataTable();
                dt.Load(dr);
                dataGridView1.DataSource = dt;
            }
        }
    }
}
