namespace Projectt_PBO.Forms
{
    partial class Formtransaksi
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TotalTransaksiTextBox = new System.Windows.Forms.TextBox();
            this.hapus_transaksi = new RJCodeAdvance.RJControls.RJButton();
            this.ubah_transaksi = new RJCodeAdvance.RJControls.RJButton();
            this.tambah_transaksi = new RJCodeAdvance.RJControls.RJButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.PelangganTransaksiTextBox = new RJCodeAdvance.RJControls.RJTextBox();
            this.caritransaksitextbox = new RJCodeAdvance.RJControls.RJTextBox();
            this.KaryawanTransaksiTextBox = new RJCodeAdvance.RJControls.RJTextBox();
            this.cari_id_transaksi = new RJCodeAdvance.RJControls.RJButton();
            this.pelanggan_transaksi = new System.Windows.Forms.Label();
            this.karyawan_transaksi = new System.Windows.Forms.Label();
            this.id_transaksi = new System.Windows.Forms.Label();
            this.HargaTransaksiTextBox = new RJCodeAdvance.RJControls.RJTextBox();
            this.BarangTransaksiTextBox = new RJCodeAdvance.RJControls.RJTextBox();
            this.harga_transaksi = new System.Windows.Forms.Label();
            this.barang_transaksi = new System.Windows.Forms.Label();
            this.JumlahTransaksiTextBox = new RJCodeAdvance.RJControls.RJTextBox();
            this.tanggal_transaksi = new System.Windows.Forms.Label();
            this.jumlah_transaksi = new System.Windows.Forms.Label();
            this.cari_karyawan = new RJCodeAdvance.RJControls.RJButton();
            this.cari_pelanggan = new RJCodeAdvance.RJControls.RJButton();
            this.cari_barang = new RJCodeAdvance.RJControls.RJButton();
            this.TanggalDateTimer = new RJCodeAdvance.RJControls.RJDatePicker();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.jumlah_baris = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TotalTransaksiTextBox
            // 
            this.TotalTransaksiTextBox.Location = new System.Drawing.Point(577, 347);
            this.TotalTransaksiTextBox.Name = "TotalTransaksiTextBox";
            this.TotalTransaksiTextBox.Size = new System.Drawing.Size(140, 22);
            this.TotalTransaksiTextBox.TabIndex = 36;
            this.TotalTransaksiTextBox.TextChanged += new System.EventHandler(this.total_TextChanged);
            // 
            // hapus_transaksi
            // 
            this.hapus_transaksi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(203)))), ((int)(((byte)(116)))));
            this.hapus_transaksi.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(203)))), ((int)(((byte)(116)))));
            this.hapus_transaksi.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.hapus_transaksi.BorderRadius = 10;
            this.hapus_transaksi.BorderSize = 0;
            this.hapus_transaksi.FlatAppearance.BorderSize = 0;
            this.hapus_transaksi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hapus_transaksi.Font = new System.Drawing.Font("Poppins", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hapus_transaksi.ForeColor = System.Drawing.Color.White;
            this.hapus_transaksi.Location = new System.Drawing.Point(1063, 97);
            this.hapus_transaksi.Name = "hapus_transaksi";
            this.hapus_transaksi.Size = new System.Drawing.Size(122, 62);
            this.hapus_transaksi.TabIndex = 41;
            this.hapus_transaksi.Text = "Hapus";
            this.hapus_transaksi.TextColor = System.Drawing.Color.White;
            this.hapus_transaksi.UseVisualStyleBackColor = false;
            this.hapus_transaksi.Click += new System.EventHandler(this.hapus_transaksi_Click);
            // 
            // ubah_transaksi
            // 
            this.ubah_transaksi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(203)))), ((int)(((byte)(116)))));
            this.ubah_transaksi.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(203)))), ((int)(((byte)(116)))));
            this.ubah_transaksi.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.ubah_transaksi.BorderRadius = 10;
            this.ubah_transaksi.BorderSize = 0;
            this.ubah_transaksi.FlatAppearance.BorderSize = 0;
            this.ubah_transaksi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ubah_transaksi.Font = new System.Drawing.Font("Poppins", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ubah_transaksi.ForeColor = System.Drawing.Color.White;
            this.ubah_transaksi.Location = new System.Drawing.Point(931, 97);
            this.ubah_transaksi.Name = "ubah_transaksi";
            this.ubah_transaksi.Size = new System.Drawing.Size(122, 62);
            this.ubah_transaksi.TabIndex = 40;
            this.ubah_transaksi.Text = "Ubah";
            this.ubah_transaksi.TextColor = System.Drawing.Color.White;
            this.ubah_transaksi.UseVisualStyleBackColor = false;
            this.ubah_transaksi.Click += new System.EventHandler(this.ubah_transaksi_Click);
            // 
            // tambah_transaksi
            // 
            this.tambah_transaksi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(203)))), ((int)(((byte)(116)))));
            this.tambah_transaksi.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(203)))), ((int)(((byte)(116)))));
            this.tambah_transaksi.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.tambah_transaksi.BorderRadius = 10;
            this.tambah_transaksi.BorderSize = 0;
            this.tambah_transaksi.FlatAppearance.BorderSize = 0;
            this.tambah_transaksi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tambah_transaksi.Font = new System.Drawing.Font("Poppins", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tambah_transaksi.ForeColor = System.Drawing.Color.White;
            this.tambah_transaksi.Location = new System.Drawing.Point(790, 97);
            this.tambah_transaksi.Name = "tambah_transaksi";
            this.tambah_transaksi.Size = new System.Drawing.Size(122, 62);
            this.tambah_transaksi.TabIndex = 39;
            this.tambah_transaksi.Text = "Tambah";
            this.tambah_transaksi.TextColor = System.Drawing.Color.White;
            this.tambah_transaksi.UseVisualStyleBackColor = false;
            this.tambah_transaksi.Click += new System.EventHandler(this.tambah_transaksi_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.dataGridView1.Location = new System.Drawing.Point(31, 296);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1154, 223);
            this.dataGridView1.TabIndex = 38;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // PelangganTransaksiTextBox
            // 
            this.PelangganTransaksiTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.PelangganTransaksiTextBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.PelangganTransaksiTextBox.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(203)))), ((int)(((byte)(116)))));
            this.PelangganTransaksiTextBox.BorderRadius = 10;
            this.PelangganTransaksiTextBox.BorderSize = 2;
            this.PelangganTransaksiTextBox.Font = new System.Drawing.Font("Poppins SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PelangganTransaksiTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.PelangganTransaksiTextBox.Location = new System.Drawing.Point(175, 76);
            this.PelangganTransaksiTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.PelangganTransaksiTextBox.Multiline = false;
            this.PelangganTransaksiTextBox.Name = "PelangganTransaksiTextBox";
            this.PelangganTransaksiTextBox.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.PelangganTransaksiTextBox.PasswordChar = false;
            this.PelangganTransaksiTextBox.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.PelangganTransaksiTextBox.PlaceholderText = "";
            this.PelangganTransaksiTextBox.Size = new System.Drawing.Size(200, 45);
            this.PelangganTransaksiTextBox.TabIndex = 48;
            this.PelangganTransaksiTextBox.Texts = "";
            this.PelangganTransaksiTextBox.UnderlinedStyle = false;
            // 
            // caritransaksitextbox
            // 
            this.caritransaksitextbox.BackColor = System.Drawing.SystemColors.Window;
            this.caritransaksitextbox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.caritransaksitextbox.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(203)))), ((int)(((byte)(116)))));
            this.caritransaksitextbox.BorderRadius = 10;
            this.caritransaksitextbox.BorderSize = 2;
            this.caritransaksitextbox.Font = new System.Drawing.Font("Poppins SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.caritransaksitextbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.caritransaksitextbox.Location = new System.Drawing.Point(905, 13);
            this.caritransaksitextbox.Margin = new System.Windows.Forms.Padding(4);
            this.caritransaksitextbox.Multiline = false;
            this.caritransaksitextbox.Name = "caritransaksitextbox";
            this.caritransaksitextbox.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.caritransaksitextbox.PasswordChar = false;
            this.caritransaksitextbox.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.caritransaksitextbox.PlaceholderText = "";
            this.caritransaksitextbox.Size = new System.Drawing.Size(200, 45);
            this.caritransaksitextbox.TabIndex = 47;
            this.caritransaksitextbox.Texts = "";
            this.caritransaksitextbox.UnderlinedStyle = false;
            // 
            // KaryawanTransaksiTextBox
            // 
            this.KaryawanTransaksiTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.KaryawanTransaksiTextBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.KaryawanTransaksiTextBox.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(203)))), ((int)(((byte)(116)))));
            this.KaryawanTransaksiTextBox.BorderRadius = 10;
            this.KaryawanTransaksiTextBox.BorderSize = 2;
            this.KaryawanTransaksiTextBox.Font = new System.Drawing.Font("Poppins SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KaryawanTransaksiTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.KaryawanTransaksiTextBox.Location = new System.Drawing.Point(175, 12);
            this.KaryawanTransaksiTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.KaryawanTransaksiTextBox.Multiline = false;
            this.KaryawanTransaksiTextBox.Name = "KaryawanTransaksiTextBox";
            this.KaryawanTransaksiTextBox.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.KaryawanTransaksiTextBox.PasswordChar = false;
            this.KaryawanTransaksiTextBox.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.KaryawanTransaksiTextBox.PlaceholderText = "";
            this.KaryawanTransaksiTextBox.Size = new System.Drawing.Size(200, 45);
            this.KaryawanTransaksiTextBox.TabIndex = 46;
            this.KaryawanTransaksiTextBox.Texts = "";
            this.KaryawanTransaksiTextBox.UnderlinedStyle = false;
            // 
            // cari_id_transaksi
            // 
            this.cari_id_transaksi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(203)))), ((int)(((byte)(116)))));
            this.cari_id_transaksi.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(203)))), ((int)(((byte)(116)))));
            this.cari_id_transaksi.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.cari_id_transaksi.BorderRadius = 10;
            this.cari_id_transaksi.BorderSize = 0;
            this.cari_id_transaksi.FlatAppearance.BorderSize = 0;
            this.cari_id_transaksi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cari_id_transaksi.Font = new System.Drawing.Font("Poppins", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cari_id_transaksi.ForeColor = System.Drawing.Color.White;
            this.cari_id_transaksi.Location = new System.Drawing.Point(1112, 22);
            this.cari_id_transaksi.Name = "cari_id_transaksi";
            this.cari_id_transaksi.Size = new System.Drawing.Size(88, 35);
            this.cari_id_transaksi.TabIndex = 45;
            this.cari_id_transaksi.Text = "Cari";
            this.cari_id_transaksi.TextColor = System.Drawing.Color.White;
            this.cari_id_transaksi.UseVisualStyleBackColor = false;
            this.cari_id_transaksi.Click += new System.EventHandler(this.cari_id_transaksi_Click);
            // 
            // pelanggan_transaksi
            // 
            this.pelanggan_transaksi.AutoSize = true;
            this.pelanggan_transaksi.Font = new System.Drawing.Font("Poppins", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pelanggan_transaksi.Location = new System.Drawing.Point(19, 86);
            this.pelanggan_transaksi.Name = "pelanggan_transaksi";
            this.pelanggan_transaksi.Size = new System.Drawing.Size(109, 30);
            this.pelanggan_transaksi.TabIndex = 44;
            this.pelanggan_transaksi.Text = "Pelanggan";
            // 
            // karyawan_transaksi
            // 
            this.karyawan_transaksi.AutoSize = true;
            this.karyawan_transaksi.Font = new System.Drawing.Font("Poppins", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.karyawan_transaksi.Location = new System.Drawing.Point(19, 21);
            this.karyawan_transaksi.Name = "karyawan_transaksi";
            this.karyawan_transaksi.Size = new System.Drawing.Size(105, 30);
            this.karyawan_transaksi.TabIndex = 43;
            this.karyawan_transaksi.Text = "Karyawan";
            // 
            // id_transaksi
            // 
            this.id_transaksi.AutoSize = true;
            this.id_transaksi.Font = new System.Drawing.Font("Poppins", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id_transaksi.Location = new System.Drawing.Point(734, 17);
            this.id_transaksi.Name = "id_transaksi";
            this.id_transaksi.Size = new System.Drawing.Size(164, 40);
            this.id_transaksi.TabIndex = 42;
            this.id_transaksi.Text = "ID Transaksi";
            // 
            // HargaTransaksiTextBox
            // 
            this.HargaTransaksiTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.HargaTransaksiTextBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.HargaTransaksiTextBox.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(203)))), ((int)(((byte)(116)))));
            this.HargaTransaksiTextBox.BorderRadius = 10;
            this.HargaTransaksiTextBox.BorderSize = 2;
            this.HargaTransaksiTextBox.Font = new System.Drawing.Font("Poppins SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HargaTransaksiTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.HargaTransaksiTextBox.Location = new System.Drawing.Point(175, 206);
            this.HargaTransaksiTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.HargaTransaksiTextBox.Multiline = false;
            this.HargaTransaksiTextBox.Name = "HargaTransaksiTextBox";
            this.HargaTransaksiTextBox.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.HargaTransaksiTextBox.PasswordChar = false;
            this.HargaTransaksiTextBox.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.HargaTransaksiTextBox.PlaceholderText = "";
            this.HargaTransaksiTextBox.Size = new System.Drawing.Size(200, 45);
            this.HargaTransaksiTextBox.TabIndex = 52;
            this.HargaTransaksiTextBox.Texts = "";
            this.HargaTransaksiTextBox.UnderlinedStyle = false;
            // 
            // BarangTransaksiTextBox
            // 
            this.BarangTransaksiTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.BarangTransaksiTextBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.BarangTransaksiTextBox.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(203)))), ((int)(((byte)(116)))));
            this.BarangTransaksiTextBox.BorderRadius = 10;
            this.BarangTransaksiTextBox.BorderSize = 2;
            this.BarangTransaksiTextBox.Font = new System.Drawing.Font("Poppins SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BarangTransaksiTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BarangTransaksiTextBox.Location = new System.Drawing.Point(175, 142);
            this.BarangTransaksiTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.BarangTransaksiTextBox.Multiline = false;
            this.BarangTransaksiTextBox.Name = "BarangTransaksiTextBox";
            this.BarangTransaksiTextBox.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.BarangTransaksiTextBox.PasswordChar = false;
            this.BarangTransaksiTextBox.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.BarangTransaksiTextBox.PlaceholderText = "";
            this.BarangTransaksiTextBox.Size = new System.Drawing.Size(200, 45);
            this.BarangTransaksiTextBox.TabIndex = 51;
            this.BarangTransaksiTextBox.Texts = "";
            this.BarangTransaksiTextBox.UnderlinedStyle = false;
            // 
            // harga_transaksi
            // 
            this.harga_transaksi.AutoSize = true;
            this.harga_transaksi.Font = new System.Drawing.Font("Poppins", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.harga_transaksi.Location = new System.Drawing.Point(38, 216);
            this.harga_transaksi.Name = "harga_transaksi";
            this.harga_transaksi.Size = new System.Drawing.Size(68, 30);
            this.harga_transaksi.TabIndex = 50;
            this.harga_transaksi.Text = "Harga";
            // 
            // barang_transaksi
            // 
            this.barang_transaksi.AutoSize = true;
            this.barang_transaksi.Font = new System.Drawing.Font("Poppins", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barang_transaksi.Location = new System.Drawing.Point(33, 151);
            this.barang_transaksi.Name = "barang_transaksi";
            this.barang_transaksi.Size = new System.Drawing.Size(78, 30);
            this.barang_transaksi.TabIndex = 49;
            this.barang_transaksi.Text = "Barang";
            // 
            // JumlahTransaksiTextBox
            // 
            this.JumlahTransaksiTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.JumlahTransaksiTextBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.JumlahTransaksiTextBox.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(203)))), ((int)(((byte)(116)))));
            this.JumlahTransaksiTextBox.BorderRadius = 10;
            this.JumlahTransaksiTextBox.BorderSize = 2;
            this.JumlahTransaksiTextBox.Font = new System.Drawing.Font("Poppins SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.JumlahTransaksiTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.JumlahTransaksiTextBox.Location = new System.Drawing.Point(490, 206);
            this.JumlahTransaksiTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.JumlahTransaksiTextBox.Multiline = false;
            this.JumlahTransaksiTextBox.Name = "JumlahTransaksiTextBox";
            this.JumlahTransaksiTextBox.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.JumlahTransaksiTextBox.PasswordChar = false;
            this.JumlahTransaksiTextBox.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.JumlahTransaksiTextBox.PlaceholderText = "";
            this.JumlahTransaksiTextBox.Size = new System.Drawing.Size(200, 45);
            this.JumlahTransaksiTextBox.TabIndex = 55;
            this.JumlahTransaksiTextBox.Texts = "";
            this.JumlahTransaksiTextBox.UnderlinedStyle = false;
            // 
            // tanggal_transaksi
            // 
            this.tanggal_transaksi.AutoSize = true;
            this.tanggal_transaksi.Font = new System.Drawing.Font("Poppins", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tanggal_transaksi.Location = new System.Drawing.Point(732, 216);
            this.tanggal_transaksi.Name = "tanggal_transaksi";
            this.tanggal_transaksi.Size = new System.Drawing.Size(87, 30);
            this.tanggal_transaksi.TabIndex = 54;
            this.tanggal_transaksi.Text = "Tanggal";
            // 
            // jumlah_transaksi
            // 
            this.jumlah_transaksi.AutoSize = true;
            this.jumlah_transaksi.Font = new System.Drawing.Font("Poppins", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jumlah_transaksi.Location = new System.Drawing.Point(403, 216);
            this.jumlah_transaksi.Name = "jumlah_transaksi";
            this.jumlah_transaksi.Size = new System.Drawing.Size(80, 30);
            this.jumlah_transaksi.TabIndex = 53;
            this.jumlah_transaksi.Text = "Jumlah";
            // 
            // cari_karyawan
            // 
            this.cari_karyawan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(203)))), ((int)(((byte)(116)))));
            this.cari_karyawan.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(203)))), ((int)(((byte)(116)))));
            this.cari_karyawan.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.cari_karyawan.BorderRadius = 10;
            this.cari_karyawan.BorderSize = 0;
            this.cari_karyawan.FlatAppearance.BorderSize = 0;
            this.cari_karyawan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cari_karyawan.Font = new System.Drawing.Font("Poppins", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cari_karyawan.ForeColor = System.Drawing.Color.White;
            this.cari_karyawan.Location = new System.Drawing.Point(399, 17);
            this.cari_karyawan.Name = "cari_karyawan";
            this.cari_karyawan.Size = new System.Drawing.Size(88, 35);
            this.cari_karyawan.TabIndex = 57;
            this.cari_karyawan.Text = "Cari";
            this.cari_karyawan.TextColor = System.Drawing.Color.White;
            this.cari_karyawan.UseVisualStyleBackColor = false;
            this.cari_karyawan.Click += new System.EventHandler(this.cari_karyawan_Click);
            // 
            // cari_pelanggan
            // 
            this.cari_pelanggan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(203)))), ((int)(((byte)(116)))));
            this.cari_pelanggan.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(203)))), ((int)(((byte)(116)))));
            this.cari_pelanggan.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.cari_pelanggan.BorderRadius = 10;
            this.cari_pelanggan.BorderSize = 0;
            this.cari_pelanggan.FlatAppearance.BorderSize = 0;
            this.cari_pelanggan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cari_pelanggan.Font = new System.Drawing.Font("Poppins", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cari_pelanggan.ForeColor = System.Drawing.Color.White;
            this.cari_pelanggan.Location = new System.Drawing.Point(399, 80);
            this.cari_pelanggan.Name = "cari_pelanggan";
            this.cari_pelanggan.Size = new System.Drawing.Size(88, 35);
            this.cari_pelanggan.TabIndex = 58;
            this.cari_pelanggan.Text = "Cari";
            this.cari_pelanggan.TextColor = System.Drawing.Color.White;
            this.cari_pelanggan.UseVisualStyleBackColor = false;
            this.cari_pelanggan.Click += new System.EventHandler(this.cari_pelanggan_Click);
            // 
            // cari_barang
            // 
            this.cari_barang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(203)))), ((int)(((byte)(116)))));
            this.cari_barang.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(203)))), ((int)(((byte)(116)))));
            this.cari_barang.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.cari_barang.BorderRadius = 10;
            this.cari_barang.BorderSize = 0;
            this.cari_barang.FlatAppearance.BorderSize = 0;
            this.cari_barang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cari_barang.Font = new System.Drawing.Font("Poppins", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cari_barang.ForeColor = System.Drawing.Color.White;
            this.cari_barang.Location = new System.Drawing.Point(399, 144);
            this.cari_barang.Name = "cari_barang";
            this.cari_barang.Size = new System.Drawing.Size(88, 35);
            this.cari_barang.TabIndex = 59;
            this.cari_barang.Text = "Cari";
            this.cari_barang.TextColor = System.Drawing.Color.White;
            this.cari_barang.UseVisualStyleBackColor = false;
            this.cari_barang.Click += new System.EventHandler(this.cari_barang_Click);
            // 
            // TanggalDateTimer
            // 
            this.TanggalDateTimer.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.TanggalDateTimer.BorderSize = 0;
            this.TanggalDateTimer.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.TanggalDateTimer.CalendarTrailingForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.TanggalDateTimer.Font = new System.Drawing.Font("Poppins", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TanggalDateTimer.Location = new System.Drawing.Point(825, 212);
            this.TanggalDateTimer.MinimumSize = new System.Drawing.Size(4, 35);
            this.TanggalDateTimer.Name = "TanggalDateTimer";
            this.TanggalDateTimer.Size = new System.Drawing.Size(360, 35);
            this.TanggalDateTimer.SkinColor = System.Drawing.Color.White;
            this.TanggalDateTimer.TabIndex = 60;
            this.TanggalDateTimer.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::Projectt_PBO.Properties.Resources._1__Login_akun_Owner__2_;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1212, 563);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 37;
            this.pictureBox1.TabStop = false;
            // 
            // jumlah_baris
            // 
            this.jumlah_baris.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(203)))), ((int)(((byte)(116)))));
            this.jumlah_baris.Name = "jumlah_baris";
            this.jumlah_baris.Size = new System.Drawing.Size(98, 20);
            this.jumlah_baris.Text = "Jumlah Baris :";
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.jumlah_baris});
            this.statusStrip1.Location = new System.Drawing.Point(0, 537);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1212, 26);
            this.statusStrip1.TabIndex = 34;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // Formtransaksi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1212, 563);
            this.Controls.Add(this.TanggalDateTimer);
            this.Controls.Add(this.cari_barang);
            this.Controls.Add(this.cari_pelanggan);
            this.Controls.Add(this.cari_karyawan);
            this.Controls.Add(this.JumlahTransaksiTextBox);
            this.Controls.Add(this.tanggal_transaksi);
            this.Controls.Add(this.jumlah_transaksi);
            this.Controls.Add(this.HargaTransaksiTextBox);
            this.Controls.Add(this.BarangTransaksiTextBox);
            this.Controls.Add(this.harga_transaksi);
            this.Controls.Add(this.barang_transaksi);
            this.Controls.Add(this.PelangganTransaksiTextBox);
            this.Controls.Add(this.caritransaksitextbox);
            this.Controls.Add(this.KaryawanTransaksiTextBox);
            this.Controls.Add(this.cari_id_transaksi);
            this.Controls.Add(this.pelanggan_transaksi);
            this.Controls.Add(this.karyawan_transaksi);
            this.Controls.Add(this.id_transaksi);
            this.Controls.Add(this.hapus_transaksi);
            this.Controls.Add(this.ubah_transaksi);
            this.Controls.Add(this.tambah_transaksi);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.TotalTransaksiTextBox);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Formtransaksi";
            this.Text = "Transaksi";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox TotalTransaksiTextBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private RJCodeAdvance.RJControls.RJButton hapus_transaksi;
        private RJCodeAdvance.RJControls.RJButton ubah_transaksi;
        private RJCodeAdvance.RJControls.RJButton tambah_transaksi;
        private System.Windows.Forms.DataGridView dataGridView1;
        private RJCodeAdvance.RJControls.RJTextBox PelangganTransaksiTextBox;
        private RJCodeAdvance.RJControls.RJTextBox caritransaksitextbox;
        private RJCodeAdvance.RJControls.RJTextBox KaryawanTransaksiTextBox;
        private RJCodeAdvance.RJControls.RJButton cari_id_transaksi;
        private System.Windows.Forms.Label pelanggan_transaksi;
        private System.Windows.Forms.Label karyawan_transaksi;
        private System.Windows.Forms.Label id_transaksi;
        private RJCodeAdvance.RJControls.RJTextBox HargaTransaksiTextBox;
        private RJCodeAdvance.RJControls.RJTextBox BarangTransaksiTextBox;
        private System.Windows.Forms.Label harga_transaksi;
        private System.Windows.Forms.Label barang_transaksi;
        private RJCodeAdvance.RJControls.RJTextBox JumlahTransaksiTextBox;
        private System.Windows.Forms.Label tanggal_transaksi;
        private System.Windows.Forms.Label jumlah_transaksi;
        private RJCodeAdvance.RJControls.RJButton cari_karyawan;
        private RJCodeAdvance.RJControls.RJButton cari_pelanggan;
        private RJCodeAdvance.RJControls.RJButton cari_barang;
        private RJCodeAdvance.RJControls.RJDatePicker TanggalDateTimer;
        private System.Windows.Forms.ToolStripStatusLabel jumlah_baris;
        private System.Windows.Forms.StatusStrip statusStrip1;
    }
}