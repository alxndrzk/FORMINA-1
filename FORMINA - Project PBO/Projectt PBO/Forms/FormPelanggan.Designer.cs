namespace Projectt_PBO.Forms
{
    partial class FormPelanggan
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
            this.JenisKelaminPelangganComboBoxx = new RJCodeAdvance.RJControls.RJComboBox();
            this.NoTeleponTextBox = new RJCodeAdvance.RJControls.RJTextBox();
            this.AlamatPelangganTextBox = new RJCodeAdvance.RJControls.RJTextBox();
            this.CariPelanggantextBox = new RJCodeAdvance.RJControls.RJTextBox();
            this.NamaPelangganTextBox = new RJCodeAdvance.RJControls.RJTextBox();
            this.cari_id_pelanggan = new RJCodeAdvance.RJControls.RJButton();
            this.hapus_pelanggan = new RJCodeAdvance.RJControls.RJButton();
            this.ubah_pelanggan = new RJCodeAdvance.RJControls.RJButton();
            this.tambah_pelanggan = new RJCodeAdvance.RJControls.RJButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.jumlah_baris = new System.Windows.Forms.ToolStripStatusLabel();
            this.jenis_kelamin_pelanggan = new System.Windows.Forms.Label();
            this.no_telepon_pelanggan = new System.Windows.Forms.Label();
            this.alamat_pelanggan = new System.Windows.Forms.Label();
            this.nama_pelanggan = new System.Windows.Forms.Label();
            this.id_pelanggan_cari = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tanggal_lahir_pelanggan = new System.Windows.Forms.Label();
            this.PekerjaanTextBox = new RJCodeAdvance.RJControls.RJTextBox();
            this.pekerjaan_pelanggan = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.TanggalLahirDateTimer = new RJCodeAdvance.RJControls.RJDatePicker();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // JenisKelaminPelangganComboBoxx
            // 
            this.JenisKelaminPelangganComboBoxx.BackColor = System.Drawing.Color.WhiteSmoke;
            this.JenisKelaminPelangganComboBoxx.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.JenisKelaminPelangganComboBoxx.BorderSize = 1;
            this.JenisKelaminPelangganComboBoxx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.JenisKelaminPelangganComboBoxx.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.JenisKelaminPelangganComboBoxx.ForeColor = System.Drawing.Color.DimGray;
            this.JenisKelaminPelangganComboBoxx.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.JenisKelaminPelangganComboBoxx.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.JenisKelaminPelangganComboBoxx.ListTextColor = System.Drawing.Color.DimGray;
            this.JenisKelaminPelangganComboBoxx.Location = new System.Drawing.Point(191, 466);
            this.JenisKelaminPelangganComboBoxx.MinimumSize = new System.Drawing.Size(200, 30);
            this.JenisKelaminPelangganComboBoxx.Name = "JenisKelaminPelangganComboBoxx";
            this.JenisKelaminPelangganComboBoxx.Padding = new System.Windows.Forms.Padding(1);
            this.JenisKelaminPelangganComboBoxx.Size = new System.Drawing.Size(280, 41);
            this.JenisKelaminPelangganComboBoxx.TabIndex = 43;
            this.JenisKelaminPelangganComboBoxx.Texts = "";
            this.JenisKelaminPelangganComboBoxx.OnSelectedIndexChanged += new System.EventHandler(this.JenisKelaminPelangganComboBoxx_OnSelectedIndexChanged);
            // 
            // NoTeleponTextBox
            // 
            this.NoTeleponTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.NoTeleponTextBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.NoTeleponTextBox.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(203)))), ((int)(((byte)(116)))));
            this.NoTeleponTextBox.BorderRadius = 10;
            this.NoTeleponTextBox.BorderSize = 2;
            this.NoTeleponTextBox.Font = new System.Drawing.Font("Poppins SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NoTeleponTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.NoTeleponTextBox.Location = new System.Drawing.Point(191, 274);
            this.NoTeleponTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.NoTeleponTextBox.Multiline = false;
            this.NoTeleponTextBox.Name = "NoTeleponTextBox";
            this.NoTeleponTextBox.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.NoTeleponTextBox.PasswordChar = false;
            this.NoTeleponTextBox.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.NoTeleponTextBox.PlaceholderText = "";
            this.NoTeleponTextBox.Size = new System.Drawing.Size(280, 45);
            this.NoTeleponTextBox.TabIndex = 42;
            this.NoTeleponTextBox.Texts = "";
            this.NoTeleponTextBox.UnderlinedStyle = false;
            // 
            // AlamatPelangganTextBox
            // 
            this.AlamatPelangganTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.AlamatPelangganTextBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.AlamatPelangganTextBox.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(203)))), ((int)(((byte)(116)))));
            this.AlamatPelangganTextBox.BorderRadius = 10;
            this.AlamatPelangganTextBox.BorderSize = 2;
            this.AlamatPelangganTextBox.Font = new System.Drawing.Font("Poppins SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AlamatPelangganTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.AlamatPelangganTextBox.Location = new System.Drawing.Point(191, 209);
            this.AlamatPelangganTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.AlamatPelangganTextBox.Multiline = false;
            this.AlamatPelangganTextBox.Name = "AlamatPelangganTextBox";
            this.AlamatPelangganTextBox.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.AlamatPelangganTextBox.PasswordChar = false;
            this.AlamatPelangganTextBox.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.AlamatPelangganTextBox.PlaceholderText = "";
            this.AlamatPelangganTextBox.Size = new System.Drawing.Size(280, 45);
            this.AlamatPelangganTextBox.TabIndex = 41;
            this.AlamatPelangganTextBox.Texts = "";
            this.AlamatPelangganTextBox.UnderlinedStyle = false;
            // 
            // CariPelanggantextBox
            // 
            this.CariPelanggantextBox.BackColor = System.Drawing.SystemColors.Window;
            this.CariPelanggantextBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.CariPelanggantextBox.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(203)))), ((int)(((byte)(116)))));
            this.CariPelanggantextBox.BorderRadius = 10;
            this.CariPelanggantextBox.BorderSize = 2;
            this.CariPelanggantextBox.Font = new System.Drawing.Font("Poppins SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CariPelanggantextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.CariPelanggantextBox.Location = new System.Drawing.Point(214, 13);
            this.CariPelanggantextBox.Margin = new System.Windows.Forms.Padding(4);
            this.CariPelanggantextBox.Multiline = false;
            this.CariPelanggantextBox.Name = "CariPelanggantextBox";
            this.CariPelanggantextBox.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.CariPelanggantextBox.PasswordChar = false;
            this.CariPelanggantextBox.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.CariPelanggantextBox.PlaceholderText = "";
            this.CariPelanggantextBox.Size = new System.Drawing.Size(247, 45);
            this.CariPelanggantextBox.TabIndex = 40;
            this.CariPelanggantextBox.Texts = "";
            this.CariPelanggantextBox.UnderlinedStyle = false;
            // 
            // NamaPelangganTextBox
            // 
            this.NamaPelangganTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.NamaPelangganTextBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.NamaPelangganTextBox.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(203)))), ((int)(((byte)(116)))));
            this.NamaPelangganTextBox.BorderRadius = 10;
            this.NamaPelangganTextBox.BorderSize = 2;
            this.NamaPelangganTextBox.Font = new System.Drawing.Font("Poppins SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NamaPelangganTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.NamaPelangganTextBox.Location = new System.Drawing.Point(191, 145);
            this.NamaPelangganTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.NamaPelangganTextBox.Multiline = false;
            this.NamaPelangganTextBox.Name = "NamaPelangganTextBox";
            this.NamaPelangganTextBox.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.NamaPelangganTextBox.PasswordChar = false;
            this.NamaPelangganTextBox.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.NamaPelangganTextBox.PlaceholderText = "";
            this.NamaPelangganTextBox.Size = new System.Drawing.Size(280, 45);
            this.NamaPelangganTextBox.TabIndex = 39;
            this.NamaPelangganTextBox.Texts = "";
            this.NamaPelangganTextBox.UnderlinedStyle = false;
            // 
            // cari_id_pelanggan
            // 
            this.cari_id_pelanggan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(203)))), ((int)(((byte)(116)))));
            this.cari_id_pelanggan.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(203)))), ((int)(((byte)(116)))));
            this.cari_id_pelanggan.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.cari_id_pelanggan.BorderRadius = 10;
            this.cari_id_pelanggan.BorderSize = 0;
            this.cari_id_pelanggan.FlatAppearance.BorderSize = 0;
            this.cari_id_pelanggan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cari_id_pelanggan.Font = new System.Drawing.Font("Poppins", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cari_id_pelanggan.ForeColor = System.Drawing.Color.White;
            this.cari_id_pelanggan.Location = new System.Drawing.Point(269, 65);
            this.cari_id_pelanggan.Name = "cari_id_pelanggan";
            this.cari_id_pelanggan.Size = new System.Drawing.Size(88, 35);
            this.cari_id_pelanggan.TabIndex = 38;
            this.cari_id_pelanggan.Text = "Cari";
            this.cari_id_pelanggan.TextColor = System.Drawing.Color.White;
            this.cari_id_pelanggan.UseVisualStyleBackColor = false;
            this.cari_id_pelanggan.Click += new System.EventHandler(this.cari_id_pelanggan_Click);
            // 
            // hapus_pelanggan
            // 
            this.hapus_pelanggan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(203)))), ((int)(((byte)(116)))));
            this.hapus_pelanggan.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(203)))), ((int)(((byte)(116)))));
            this.hapus_pelanggan.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.hapus_pelanggan.BorderRadius = 10;
            this.hapus_pelanggan.BorderSize = 0;
            this.hapus_pelanggan.FlatAppearance.BorderSize = 0;
            this.hapus_pelanggan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hapus_pelanggan.Font = new System.Drawing.Font("Poppins", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hapus_pelanggan.ForeColor = System.Drawing.Color.White;
            this.hapus_pelanggan.Location = new System.Drawing.Point(925, 445);
            this.hapus_pelanggan.Name = "hapus_pelanggan";
            this.hapus_pelanggan.Size = new System.Drawing.Size(122, 62);
            this.hapus_pelanggan.TabIndex = 37;
            this.hapus_pelanggan.Text = "Hapus";
            this.hapus_pelanggan.TextColor = System.Drawing.Color.White;
            this.hapus_pelanggan.UseVisualStyleBackColor = false;
            this.hapus_pelanggan.Click += new System.EventHandler(this.hapus_pelanggan_Click);
            // 
            // ubah_pelanggan
            // 
            this.ubah_pelanggan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(203)))), ((int)(((byte)(116)))));
            this.ubah_pelanggan.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(203)))), ((int)(((byte)(116)))));
            this.ubah_pelanggan.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.ubah_pelanggan.BorderRadius = 10;
            this.ubah_pelanggan.BorderSize = 0;
            this.ubah_pelanggan.FlatAppearance.BorderSize = 0;
            this.ubah_pelanggan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ubah_pelanggan.Font = new System.Drawing.Font("Poppins", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ubah_pelanggan.ForeColor = System.Drawing.Color.White;
            this.ubah_pelanggan.Location = new System.Drawing.Point(783, 445);
            this.ubah_pelanggan.Name = "ubah_pelanggan";
            this.ubah_pelanggan.Size = new System.Drawing.Size(122, 62);
            this.ubah_pelanggan.TabIndex = 36;
            this.ubah_pelanggan.Text = "Ubah";
            this.ubah_pelanggan.TextColor = System.Drawing.Color.White;
            this.ubah_pelanggan.UseVisualStyleBackColor = false;
            this.ubah_pelanggan.Click += new System.EventHandler(this.ubah_pelanggan_Click);
            // 
            // tambah_pelanggan
            // 
            this.tambah_pelanggan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(203)))), ((int)(((byte)(116)))));
            this.tambah_pelanggan.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(203)))), ((int)(((byte)(116)))));
            this.tambah_pelanggan.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.tambah_pelanggan.BorderRadius = 10;
            this.tambah_pelanggan.BorderSize = 0;
            this.tambah_pelanggan.FlatAppearance.BorderSize = 0;
            this.tambah_pelanggan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tambah_pelanggan.Font = new System.Drawing.Font("Poppins", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tambah_pelanggan.ForeColor = System.Drawing.Color.White;
            this.tambah_pelanggan.Location = new System.Drawing.Point(639, 445);
            this.tambah_pelanggan.Name = "tambah_pelanggan";
            this.tambah_pelanggan.Size = new System.Drawing.Size(122, 62);
            this.tambah_pelanggan.TabIndex = 35;
            this.tambah_pelanggan.Text = "Tambah";
            this.tambah_pelanggan.TextColor = System.Drawing.Color.White;
            this.tambah_pelanggan.UseVisualStyleBackColor = false;
            this.tambah_pelanggan.Click += new System.EventHandler(this.tambah_pelanggan_Click_1);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.jumlah_baris});
            this.statusStrip1.Location = new System.Drawing.Point(0, 537);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1212, 26);
            this.statusStrip1.TabIndex = 33;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // jumlah_baris
            // 
            this.jumlah_baris.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(203)))), ((int)(((byte)(116)))));
            this.jumlah_baris.Name = "jumlah_baris";
            this.jumlah_baris.Size = new System.Drawing.Size(98, 20);
            this.jumlah_baris.Text = "Jumlah Baris :";
            // 
            // jenis_kelamin_pelanggan
            // 
            this.jenis_kelamin_pelanggan.AutoSize = true;
            this.jenis_kelamin_pelanggan.Font = new System.Drawing.Font("Poppins", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jenis_kelamin_pelanggan.Location = new System.Drawing.Point(35, 472);
            this.jenis_kelamin_pelanggan.Name = "jenis_kelamin_pelanggan";
            this.jenis_kelamin_pelanggan.Size = new System.Drawing.Size(135, 30);
            this.jenis_kelamin_pelanggan.TabIndex = 32;
            this.jenis_kelamin_pelanggan.Text = "Jenis Kelamin";
            // 
            // no_telepon_pelanggan
            // 
            this.no_telepon_pelanggan.AutoSize = true;
            this.no_telepon_pelanggan.Font = new System.Drawing.Font("Poppins", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.no_telepon_pelanggan.Location = new System.Drawing.Point(35, 282);
            this.no_telepon_pelanggan.Name = "no_telepon_pelanggan";
            this.no_telepon_pelanggan.Size = new System.Drawing.Size(110, 30);
            this.no_telepon_pelanggan.TabIndex = 31;
            this.no_telepon_pelanggan.Text = "No Telepon";
            // 
            // alamat_pelanggan
            // 
            this.alamat_pelanggan.AutoSize = true;
            this.alamat_pelanggan.Font = new System.Drawing.Font("Poppins", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.alamat_pelanggan.Location = new System.Drawing.Point(35, 219);
            this.alamat_pelanggan.Name = "alamat_pelanggan";
            this.alamat_pelanggan.Size = new System.Drawing.Size(80, 30);
            this.alamat_pelanggan.TabIndex = 30;
            this.alamat_pelanggan.Text = "Alamat";
            // 
            // nama_pelanggan
            // 
            this.nama_pelanggan.AutoSize = true;
            this.nama_pelanggan.Font = new System.Drawing.Font("Poppins", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nama_pelanggan.Location = new System.Drawing.Point(35, 154);
            this.nama_pelanggan.Name = "nama_pelanggan";
            this.nama_pelanggan.Size = new System.Drawing.Size(68, 30);
            this.nama_pelanggan.TabIndex = 29;
            this.nama_pelanggan.Text = "Nama";
            // 
            // id_pelanggan_cari
            // 
            this.id_pelanggan_cari.AutoSize = true;
            this.id_pelanggan_cari.Font = new System.Drawing.Font("Poppins", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id_pelanggan_cari.Location = new System.Drawing.Point(24, 18);
            this.id_pelanggan_cari.Name = "id_pelanggan_cari";
            this.id_pelanggan_cari.Size = new System.Drawing.Size(175, 40);
            this.id_pelanggan_cari.TabIndex = 28;
            this.id_pelanggan_cari.Text = "ID Pelanggan";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.dataGridView1.Location = new System.Drawing.Point(515, 15);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(660, 424);
            this.dataGridView1.TabIndex = 34;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // tanggal_lahir_pelanggan
            // 
            this.tanggal_lahir_pelanggan.AutoSize = true;
            this.tanggal_lahir_pelanggan.Font = new System.Drawing.Font("Poppins", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tanggal_lahir_pelanggan.Location = new System.Drawing.Point(35, 342);
            this.tanggal_lahir_pelanggan.Name = "tanggal_lahir_pelanggan";
            this.tanggal_lahir_pelanggan.Size = new System.Drawing.Size(134, 30);
            this.tanggal_lahir_pelanggan.TabIndex = 44;
            this.tanggal_lahir_pelanggan.Text = "Tanggal Lahir";
            // 
            // PekerjaanTextBox
            // 
            this.PekerjaanTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.PekerjaanTextBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.PekerjaanTextBox.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(203)))), ((int)(((byte)(116)))));
            this.PekerjaanTextBox.BorderRadius = 10;
            this.PekerjaanTextBox.BorderSize = 2;
            this.PekerjaanTextBox.Font = new System.Drawing.Font("Poppins SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PekerjaanTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.PekerjaanTextBox.Location = new System.Drawing.Point(191, 394);
            this.PekerjaanTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.PekerjaanTextBox.Multiline = false;
            this.PekerjaanTextBox.Name = "PekerjaanTextBox";
            this.PekerjaanTextBox.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.PekerjaanTextBox.PasswordChar = false;
            this.PekerjaanTextBox.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.PekerjaanTextBox.PlaceholderText = "";
            this.PekerjaanTextBox.Size = new System.Drawing.Size(280, 45);
            this.PekerjaanTextBox.TabIndex = 47;
            this.PekerjaanTextBox.Texts = "";
            this.PekerjaanTextBox.UnderlinedStyle = false;
            // 
            // pekerjaan_pelanggan
            // 
            this.pekerjaan_pelanggan.AutoSize = true;
            this.pekerjaan_pelanggan.Font = new System.Drawing.Font("Poppins", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pekerjaan_pelanggan.Location = new System.Drawing.Point(35, 404);
            this.pekerjaan_pelanggan.Name = "pekerjaan_pelanggan";
            this.pekerjaan_pelanggan.Size = new System.Drawing.Size(102, 30);
            this.pekerjaan_pelanggan.TabIndex = 46;
            this.pekerjaan_pelanggan.Text = "Pekerjaan";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::Projectt_PBO.Properties.Resources._1__Login_akun_Owner__2_;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1212, 563);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 48;
            this.pictureBox1.TabStop = false;
            // 
            // TanggalLahirDateTimer
            // 
            this.TanggalLahirDateTimer.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.TanggalLahirDateTimer.BorderSize = 0;
            this.TanggalLahirDateTimer.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.TanggalLahirDateTimer.CalendarTrailingForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.TanggalLahirDateTimer.Font = new System.Drawing.Font("Poppins", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TanggalLahirDateTimer.Location = new System.Drawing.Point(191, 339);
            this.TanggalLahirDateTimer.MinimumSize = new System.Drawing.Size(0, 35);
            this.TanggalLahirDateTimer.Name = "TanggalLahirDateTimer";
            this.TanggalLahirDateTimer.Size = new System.Drawing.Size(280, 35);
            this.TanggalLahirDateTimer.SkinColor = System.Drawing.Color.White;
            this.TanggalLahirDateTimer.TabIndex = 49;
            this.TanggalLahirDateTimer.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            // 
            // FormPelanggan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1212, 563);
            this.Controls.Add(this.TanggalLahirDateTimer);
            this.Controls.Add(this.PekerjaanTextBox);
            this.Controls.Add(this.pekerjaan_pelanggan);
            this.Controls.Add(this.tanggal_lahir_pelanggan);
            this.Controls.Add(this.JenisKelaminPelangganComboBoxx);
            this.Controls.Add(this.NoTeleponTextBox);
            this.Controls.Add(this.AlamatPelangganTextBox);
            this.Controls.Add(this.CariPelanggantextBox);
            this.Controls.Add(this.NamaPelangganTextBox);
            this.Controls.Add(this.cari_id_pelanggan);
            this.Controls.Add(this.hapus_pelanggan);
            this.Controls.Add(this.ubah_pelanggan);
            this.Controls.Add(this.tambah_pelanggan);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.jenis_kelamin_pelanggan);
            this.Controls.Add(this.no_telepon_pelanggan);
            this.Controls.Add(this.alamat_pelanggan);
            this.Controls.Add(this.nama_pelanggan);
            this.Controls.Add(this.id_pelanggan_cari);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FormPelanggan";
            this.Text = "Pelanggan";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RJCodeAdvance.RJControls.RJComboBox JenisKelaminPelangganComboBoxx;
        private RJCodeAdvance.RJControls.RJTextBox NoTeleponTextBox;
        private RJCodeAdvance.RJControls.RJTextBox AlamatPelangganTextBox;
        private RJCodeAdvance.RJControls.RJTextBox CariPelanggantextBox;
        private RJCodeAdvance.RJControls.RJTextBox NamaPelangganTextBox;
        private RJCodeAdvance.RJControls.RJButton cari_id_pelanggan;
        private RJCodeAdvance.RJControls.RJButton hapus_pelanggan;
        private RJCodeAdvance.RJControls.RJButton ubah_pelanggan;
        private RJCodeAdvance.RJControls.RJButton tambah_pelanggan;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel jumlah_baris;
        private System.Windows.Forms.Label jenis_kelamin_pelanggan;
        private System.Windows.Forms.Label no_telepon_pelanggan;
        private System.Windows.Forms.Label alamat_pelanggan;
        private System.Windows.Forms.Label nama_pelanggan;
        private System.Windows.Forms.Label id_pelanggan_cari;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label tanggal_lahir_pelanggan;
        private RJCodeAdvance.RJControls.RJTextBox PekerjaanTextBox;
        private System.Windows.Forms.Label pekerjaan_pelanggan;
        private System.Windows.Forms.PictureBox pictureBox1;
        private RJCodeAdvance.RJControls.RJDatePicker TanggalLahirDateTimer;
    }
}