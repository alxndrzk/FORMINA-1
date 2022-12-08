namespace Projectt_PBO.Forms
{
    partial class Formkaryawan
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
            this.id_karyawan_cari = new System.Windows.Forms.Label();
            this.nama_karyawan = new System.Windows.Forms.Label();
            this.alamat_karyawan = new System.Windows.Forms.Label();
            this.no_telepon_karyawan = new System.Windows.Forms.Label();
            this.jenis_kelamin_karyawan = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.jumlah_baris = new System.Windows.Forms.ToolStripStatusLabel();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.tambah_karyawan = new RJCodeAdvance.RJControls.RJButton();
            this.ubah_karyawan = new RJCodeAdvance.RJControls.RJButton();
            this.hapus_karyawan = new RJCodeAdvance.RJControls.RJButton();
            this.cari_id_karyawan = new RJCodeAdvance.RJControls.RJButton();
            this.NamaKaryawanTextBox = new RJCodeAdvance.RJControls.RJTextBox();
            this.CariKaryawantextBox = new RJCodeAdvance.RJControls.RJTextBox();
            this.AlamatKaryawanTextBox = new RJCodeAdvance.RJControls.RJTextBox();
            this.NoTeleponTextBox = new RJCodeAdvance.RJControls.RJTextBox();
            this.JenisKelaminKaryawanComboBoxx = new RJCodeAdvance.RJControls.RJComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.TanggalLahirDateTimerr = new RJCodeAdvance.RJControls.RJDatePicker();
            this.tanggal_lahir_karyawan = new System.Windows.Forms.Label();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // id_karyawan_cari
            // 
            this.id_karyawan_cari.AutoSize = true;
            this.id_karyawan_cari.Font = new System.Drawing.Font("Poppins", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id_karyawan_cari.Location = new System.Drawing.Point(39, 30);
            this.id_karyawan_cari.Name = "id_karyawan_cari";
            this.id_karyawan_cari.Size = new System.Drawing.Size(170, 40);
            this.id_karyawan_cari.TabIndex = 0;
            this.id_karyawan_cari.Text = "ID Karyawan";
            this.id_karyawan_cari.Click += new System.EventHandler(this.label1_Click);
            // 
            // nama_karyawan
            // 
            this.nama_karyawan.AutoSize = true;
            this.nama_karyawan.Font = new System.Drawing.Font("Poppins", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nama_karyawan.Location = new System.Drawing.Point(21, 169);
            this.nama_karyawan.Name = "nama_karyawan";
            this.nama_karyawan.Size = new System.Drawing.Size(68, 30);
            this.nama_karyawan.TabIndex = 5;
            this.nama_karyawan.Text = "Nama";
            this.nama_karyawan.Click += new System.EventHandler(this.label2_Click);
            // 
            // alamat_karyawan
            // 
            this.alamat_karyawan.AutoSize = true;
            this.alamat_karyawan.Font = new System.Drawing.Font("Poppins", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.alamat_karyawan.Location = new System.Drawing.Point(21, 234);
            this.alamat_karyawan.Name = "alamat_karyawan";
            this.alamat_karyawan.Size = new System.Drawing.Size(80, 30);
            this.alamat_karyawan.TabIndex = 7;
            this.alamat_karyawan.Text = "Alamat";
            this.alamat_karyawan.Click += new System.EventHandler(this.alamat_karyawan_Click);
            // 
            // no_telepon_karyawan
            // 
            this.no_telepon_karyawan.AutoSize = true;
            this.no_telepon_karyawan.Font = new System.Drawing.Font("Poppins", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.no_telepon_karyawan.Location = new System.Drawing.Point(21, 297);
            this.no_telepon_karyawan.Name = "no_telepon_karyawan";
            this.no_telepon_karyawan.Size = new System.Drawing.Size(110, 30);
            this.no_telepon_karyawan.TabIndex = 9;
            this.no_telepon_karyawan.Text = "No Telepon";
            this.no_telepon_karyawan.Click += new System.EventHandler(this.no_telepon_karyawan_Click);
            // 
            // jenis_kelamin_karyawan
            // 
            this.jenis_kelamin_karyawan.AutoSize = true;
            this.jenis_kelamin_karyawan.Font = new System.Drawing.Font("Poppins", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jenis_kelamin_karyawan.Location = new System.Drawing.Point(21, 369);
            this.jenis_kelamin_karyawan.Name = "jenis_kelamin_karyawan";
            this.jenis_kelamin_karyawan.Size = new System.Drawing.Size(135, 30);
            this.jenis_kelamin_karyawan.TabIndex = 11;
            this.jenis_kelamin_karyawan.Text = "Jenis Kelamin";
            this.jenis_kelamin_karyawan.Click += new System.EventHandler(this.jenis_kelamin_karyawan_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.jumlah_baris});
            this.statusStrip1.Location = new System.Drawing.Point(0, 537);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1212, 26);
            this.statusStrip1.TabIndex = 17;
            this.statusStrip1.Text = "statusStrip1";
            this.statusStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.statusStrip1_ItemClicked);
            // 
            // jumlah_baris
            // 
            this.jumlah_baris.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(203)))), ((int)(((byte)(116)))));
            this.jumlah_baris.Name = "jumlah_baris";
            this.jumlah_baris.Size = new System.Drawing.Size(98, 20);
            this.jumlah_baris.Text = "Jumlah Baris :";
            this.jumlah_baris.Click += new System.EventHandler(this.jumlah_baris_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.dataGridView2.Location = new System.Drawing.Point(515, 28);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(685, 424);
            this.dataGridView2.TabIndex = 18;
            this.dataGridView2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // tambah_karyawan
            // 
            this.tambah_karyawan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(203)))), ((int)(((byte)(116)))));
            this.tambah_karyawan.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(203)))), ((int)(((byte)(116)))));
            this.tambah_karyawan.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.tambah_karyawan.BorderRadius = 10;
            this.tambah_karyawan.BorderSize = 0;
            this.tambah_karyawan.FlatAppearance.BorderSize = 0;
            this.tambah_karyawan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tambah_karyawan.Font = new System.Drawing.Font("Poppins", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tambah_karyawan.ForeColor = System.Drawing.Color.White;
            this.tambah_karyawan.Location = new System.Drawing.Point(668, 458);
            this.tambah_karyawan.Name = "tambah_karyawan";
            this.tambah_karyawan.Size = new System.Drawing.Size(122, 62);
            this.tambah_karyawan.TabIndex = 19;
            this.tambah_karyawan.Text = "Tambah";
            this.tambah_karyawan.TextColor = System.Drawing.Color.White;
            this.tambah_karyawan.UseVisualStyleBackColor = false;
            this.tambah_karyawan.Click += new System.EventHandler(this.tambah_karyawan_Click_1);
            // 
            // ubah_karyawan
            // 
            this.ubah_karyawan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(203)))), ((int)(((byte)(116)))));
            this.ubah_karyawan.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(203)))), ((int)(((byte)(116)))));
            this.ubah_karyawan.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.ubah_karyawan.BorderRadius = 10;
            this.ubah_karyawan.BorderSize = 0;
            this.ubah_karyawan.FlatAppearance.BorderSize = 0;
            this.ubah_karyawan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ubah_karyawan.Font = new System.Drawing.Font("Poppins", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ubah_karyawan.ForeColor = System.Drawing.Color.White;
            this.ubah_karyawan.Location = new System.Drawing.Point(812, 458);
            this.ubah_karyawan.Name = "ubah_karyawan";
            this.ubah_karyawan.Size = new System.Drawing.Size(122, 62);
            this.ubah_karyawan.TabIndex = 20;
            this.ubah_karyawan.Text = "Ubah";
            this.ubah_karyawan.TextColor = System.Drawing.Color.White;
            this.ubah_karyawan.UseVisualStyleBackColor = false;
            this.ubah_karyawan.Click += new System.EventHandler(this.ubah_karyawan_Click_1);
            // 
            // hapus_karyawan
            // 
            this.hapus_karyawan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(203)))), ((int)(((byte)(116)))));
            this.hapus_karyawan.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(203)))), ((int)(((byte)(116)))));
            this.hapus_karyawan.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.hapus_karyawan.BorderRadius = 10;
            this.hapus_karyawan.BorderSize = 0;
            this.hapus_karyawan.FlatAppearance.BorderSize = 0;
            this.hapus_karyawan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hapus_karyawan.Font = new System.Drawing.Font("Poppins", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hapus_karyawan.ForeColor = System.Drawing.Color.White;
            this.hapus_karyawan.Location = new System.Drawing.Point(954, 458);
            this.hapus_karyawan.Name = "hapus_karyawan";
            this.hapus_karyawan.Size = new System.Drawing.Size(122, 62);
            this.hapus_karyawan.TabIndex = 21;
            this.hapus_karyawan.Text = "Hapus";
            this.hapus_karyawan.TextColor = System.Drawing.Color.White;
            this.hapus_karyawan.UseVisualStyleBackColor = false;
            this.hapus_karyawan.Click += new System.EventHandler(this.hapus_karyawan_Click_1);
            // 
            // cari_id_karyawan
            // 
            this.cari_id_karyawan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(203)))), ((int)(((byte)(116)))));
            this.cari_id_karyawan.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(203)))), ((int)(((byte)(116)))));
            this.cari_id_karyawan.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.cari_id_karyawan.BorderRadius = 10;
            this.cari_id_karyawan.BorderSize = 0;
            this.cari_id_karyawan.FlatAppearance.BorderSize = 0;
            this.cari_id_karyawan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cari_id_karyawan.Font = new System.Drawing.Font("Poppins", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cari_id_karyawan.ForeColor = System.Drawing.Color.White;
            this.cari_id_karyawan.Location = new System.Drawing.Point(284, 77);
            this.cari_id_karyawan.Name = "cari_id_karyawan";
            this.cari_id_karyawan.Size = new System.Drawing.Size(88, 35);
            this.cari_id_karyawan.TabIndex = 22;
            this.cari_id_karyawan.Text = "Cari";
            this.cari_id_karyawan.TextColor = System.Drawing.Color.White;
            this.cari_id_karyawan.UseVisualStyleBackColor = false;
            this.cari_id_karyawan.Click += new System.EventHandler(this.cari_id_karyawan_Click_1);
            // 
            // NamaKaryawanTextBox
            // 
            this.NamaKaryawanTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.NamaKaryawanTextBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.NamaKaryawanTextBox.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(203)))), ((int)(((byte)(116)))));
            this.NamaKaryawanTextBox.BorderRadius = 10;
            this.NamaKaryawanTextBox.BorderSize = 2;
            this.NamaKaryawanTextBox.Font = new System.Drawing.Font("Poppins SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NamaKaryawanTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.NamaKaryawanTextBox.Location = new System.Drawing.Point(177, 160);
            this.NamaKaryawanTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.NamaKaryawanTextBox.Multiline = false;
            this.NamaKaryawanTextBox.Name = "NamaKaryawanTextBox";
            this.NamaKaryawanTextBox.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.NamaKaryawanTextBox.PasswordChar = false;
            this.NamaKaryawanTextBox.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.NamaKaryawanTextBox.PlaceholderText = "";
            this.NamaKaryawanTextBox.Size = new System.Drawing.Size(282, 45);
            this.NamaKaryawanTextBox.TabIndex = 23;
            this.NamaKaryawanTextBox.Texts = "";
            this.NamaKaryawanTextBox.UnderlinedStyle = false;
            this.NamaKaryawanTextBox._TextChanged += new System.EventHandler(this.NamaKaryawanTextBox__TextChanged);
            // 
            // CariKaryawantextBox
            // 
            this.CariKaryawantextBox.BackColor = System.Drawing.SystemColors.Window;
            this.CariKaryawantextBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.CariKaryawantextBox.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(203)))), ((int)(((byte)(116)))));
            this.CariKaryawantextBox.BorderRadius = 10;
            this.CariKaryawantextBox.BorderSize = 2;
            this.CariKaryawantextBox.Font = new System.Drawing.Font("Poppins SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CariKaryawantextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.CariKaryawantextBox.Location = new System.Drawing.Point(229, 25);
            this.CariKaryawantextBox.Margin = new System.Windows.Forms.Padding(4);
            this.CariKaryawantextBox.Multiline = false;
            this.CariKaryawantextBox.Name = "CariKaryawantextBox";
            this.CariKaryawantextBox.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.CariKaryawantextBox.PasswordChar = false;
            this.CariKaryawantextBox.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.CariKaryawantextBox.PlaceholderText = "";
            this.CariKaryawantextBox.Size = new System.Drawing.Size(200, 45);
            this.CariKaryawantextBox.TabIndex = 24;
            this.CariKaryawantextBox.Texts = "";
            this.CariKaryawantextBox.UnderlinedStyle = false;
            // 
            // AlamatKaryawanTextBox
            // 
            this.AlamatKaryawanTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.AlamatKaryawanTextBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.AlamatKaryawanTextBox.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(203)))), ((int)(((byte)(116)))));
            this.AlamatKaryawanTextBox.BorderRadius = 10;
            this.AlamatKaryawanTextBox.BorderSize = 2;
            this.AlamatKaryawanTextBox.Font = new System.Drawing.Font("Poppins SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AlamatKaryawanTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.AlamatKaryawanTextBox.Location = new System.Drawing.Point(177, 224);
            this.AlamatKaryawanTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.AlamatKaryawanTextBox.Multiline = false;
            this.AlamatKaryawanTextBox.Name = "AlamatKaryawanTextBox";
            this.AlamatKaryawanTextBox.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.AlamatKaryawanTextBox.PasswordChar = false;
            this.AlamatKaryawanTextBox.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.AlamatKaryawanTextBox.PlaceholderText = "";
            this.AlamatKaryawanTextBox.Size = new System.Drawing.Size(282, 45);
            this.AlamatKaryawanTextBox.TabIndex = 25;
            this.AlamatKaryawanTextBox.Texts = "";
            this.AlamatKaryawanTextBox.UnderlinedStyle = false;
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
            this.NoTeleponTextBox.Location = new System.Drawing.Point(177, 289);
            this.NoTeleponTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.NoTeleponTextBox.Multiline = false;
            this.NoTeleponTextBox.Name = "NoTeleponTextBox";
            this.NoTeleponTextBox.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.NoTeleponTextBox.PasswordChar = false;
            this.NoTeleponTextBox.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.NoTeleponTextBox.PlaceholderText = "";
            this.NoTeleponTextBox.Size = new System.Drawing.Size(282, 45);
            this.NoTeleponTextBox.TabIndex = 26;
            this.NoTeleponTextBox.Texts = "";
            this.NoTeleponTextBox.UnderlinedStyle = false;
            // 
            // JenisKelaminKaryawanComboBoxx
            // 
            this.JenisKelaminKaryawanComboBoxx.BackColor = System.Drawing.Color.WhiteSmoke;
            this.JenisKelaminKaryawanComboBoxx.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.JenisKelaminKaryawanComboBoxx.BorderSize = 1;
            this.JenisKelaminKaryawanComboBoxx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.JenisKelaminKaryawanComboBoxx.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.JenisKelaminKaryawanComboBoxx.ForeColor = System.Drawing.Color.DimGray;
            this.JenisKelaminKaryawanComboBoxx.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.JenisKelaminKaryawanComboBoxx.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.JenisKelaminKaryawanComboBoxx.ListTextColor = System.Drawing.Color.DimGray;
            this.JenisKelaminKaryawanComboBoxx.Location = new System.Drawing.Point(177, 357);
            this.JenisKelaminKaryawanComboBoxx.MinimumSize = new System.Drawing.Size(200, 30);
            this.JenisKelaminKaryawanComboBoxx.Name = "JenisKelaminKaryawanComboBoxx";
            this.JenisKelaminKaryawanComboBoxx.Padding = new System.Windows.Forms.Padding(1);
            this.JenisKelaminKaryawanComboBoxx.Size = new System.Drawing.Size(282, 42);
            this.JenisKelaminKaryawanComboBoxx.TabIndex = 27;
            this.JenisKelaminKaryawanComboBoxx.Texts = "";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::Projectt_PBO.Properties.Resources._1__Login_akun_Owner__2_;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1212, 563);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 28;
            this.pictureBox1.TabStop = false;
            // 
            // TanggalLahirDateTimerr
            // 
            this.TanggalLahirDateTimerr.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.TanggalLahirDateTimerr.BorderSize = 0;
            this.TanggalLahirDateTimerr.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.TanggalLahirDateTimerr.CalendarTrailingForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.TanggalLahirDateTimerr.Font = new System.Drawing.Font("Poppins", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TanggalLahirDateTimerr.Location = new System.Drawing.Point(179, 431);
            this.TanggalLahirDateTimerr.MinimumSize = new System.Drawing.Size(4, 35);
            this.TanggalLahirDateTimerr.Name = "TanggalLahirDateTimerr";
            this.TanggalLahirDateTimerr.Size = new System.Drawing.Size(280, 35);
            this.TanggalLahirDateTimerr.SkinColor = System.Drawing.Color.White;
            this.TanggalLahirDateTimerr.TabIndex = 51;
            this.TanggalLahirDateTimerr.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            // 
            // tanggal_lahir_karyawan
            // 
            this.tanggal_lahir_karyawan.AutoSize = true;
            this.tanggal_lahir_karyawan.Font = new System.Drawing.Font("Poppins", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tanggal_lahir_karyawan.Location = new System.Drawing.Point(23, 434);
            this.tanggal_lahir_karyawan.Name = "tanggal_lahir_karyawan";
            this.tanggal_lahir_karyawan.Size = new System.Drawing.Size(134, 30);
            this.tanggal_lahir_karyawan.TabIndex = 50;
            this.tanggal_lahir_karyawan.Text = "Tanggal Lahir";
            // 
            // Formkaryawan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1212, 563);
            this.Controls.Add(this.TanggalLahirDateTimerr);
            this.Controls.Add(this.tanggal_lahir_karyawan);
            this.Controls.Add(this.JenisKelaminKaryawanComboBoxx);
            this.Controls.Add(this.NoTeleponTextBox);
            this.Controls.Add(this.AlamatKaryawanTextBox);
            this.Controls.Add(this.CariKaryawantextBox);
            this.Controls.Add(this.NamaKaryawanTextBox);
            this.Controls.Add(this.cari_id_karyawan);
            this.Controls.Add(this.hapus_karyawan);
            this.Controls.Add(this.ubah_karyawan);
            this.Controls.Add(this.tambah_karyawan);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.jenis_kelamin_karyawan);
            this.Controls.Add(this.no_telepon_karyawan);
            this.Controls.Add(this.alamat_karyawan);
            this.Controls.Add(this.nama_karyawan);
            this.Controls.Add(this.id_karyawan_cari);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Formkaryawan";
            this.Text = "Karyawan";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label id_karyawan_cari;
        private System.Windows.Forms.Label nama_karyawan;
        private System.Windows.Forms.Label alamat_karyawan;
        private System.Windows.Forms.Label no_telepon_karyawan;
        private System.Windows.Forms.Label jenis_kelamin_karyawan;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel jumlah_baris;
        private System.Windows.Forms.DataGridView dataGridView2;
        private RJCodeAdvance.RJControls.RJButton tambah_karyawan;
        private RJCodeAdvance.RJControls.RJButton ubah_karyawan;
        private RJCodeAdvance.RJControls.RJButton hapus_karyawan;
        private RJCodeAdvance.RJControls.RJButton cari_id_karyawan;
        private RJCodeAdvance.RJControls.RJTextBox NamaKaryawanTextBox;
        private RJCodeAdvance.RJControls.RJTextBox CariKaryawantextBox;
        private RJCodeAdvance.RJControls.RJTextBox AlamatKaryawanTextBox;
        private RJCodeAdvance.RJControls.RJTextBox NoTeleponTextBox;
        private System.Windows.Forms.ComboBox JenisKelaminKaryawanComboBox;
        private RJCodeAdvance.RJControls.RJComboBox JenisKelaminKaryawanComboBoxx;
        private System.Windows.Forms.PictureBox pictureBox1;
        private RJCodeAdvance.RJControls.RJDatePicker TanggalLahirDateTimerr;
        private System.Windows.Forms.Label tanggal_lahir_karyawan;
    }
}