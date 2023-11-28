namespace XIIRPL1_09_Ticketing.MasterForm
{
    partial class FrmMasterJadwalPenerbangan
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnSimpan = new Button();
            button1 = new Button();
            label8 = new Label();
            label6 = new Label();
            txtKodePenerbangan = new TextBox();
            label4 = new Label();
            label3 = new Label();
            dataGridView1 = new DataGridView();
            label2 = new Label();
            label1 = new Label();
            txtDari = new ComboBox();
            txtKe = new ComboBox();
            txtMaskapai = new ComboBox();
            label5 = new Label();
            txtTanggal = new DateTimePicker();
            label7 = new Label();
            label9 = new Label();
            label10 = new Label();
            txtHargaPerTiket = new NumericUpDown();
            txtDurasiPenerbangan = new TextBox();
            id = new TextBox();
            txtWaktuKeberangkatan = new DateTimePicker();
            Edit = new DataGridViewButtonColumn();
            Delete = new DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtHargaPerTiket).BeginInit();
            SuspendLayout();
            // 
            // btnSimpan
            // 
            btnSimpan.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnSimpan.Location = new Point(914, 474);
            btnSimpan.Name = "btnSimpan";
            btnSimpan.Size = new Size(75, 23);
            btnSimpan.TabIndex = 55;
            btnSimpan.Text = "Simpan";
            btnSimpan.UseVisualStyleBackColor = true;
            btnSimpan.Click += btnSimpan_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(834, 474);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 54;
            button1.Text = "Batal";
            button1.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(550, 306);
            label8.Name = "label8";
            label8.Size = new Size(68, 21);
            label8.TabIndex = 52;
            label8.Text = "Tanggal";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(24, 387);
            label6.Name = "label6";
            label6.Size = new Size(31, 21);
            label6.TabIndex = 51;
            label6.Text = "Ke";
            label6.Click += label6_Click;
            // 
            // txtKodePenerbangan
            // 
            txtKodePenerbangan.Location = new Point(180, 304);
            txtKodePenerbangan.Name = "txtKodePenerbangan";
            txtKodePenerbangan.Size = new Size(353, 23);
            txtKodePenerbangan.TabIndex = 49;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(24, 342);
            label4.Name = "label4";
            label4.Size = new Size(41, 21);
            label4.TabIndex = 48;
            label4.Text = "Dari";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(23, 304);
            label3.Name = "label3";
            label3.Size = new Size(151, 21);
            label3.TabIndex = 47;
            label3.Text = "Kode Penerbangan";
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Edit, Delete });
            dataGridView1.Location = new Point(23, 94);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(966, 184);
            dataGridView1.TabIndex = 45;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(23, 57);
            label2.Name = "label2";
            label2.Size = new Size(319, 19);
            label2.TabIndex = 44;
            label2.Text = "Semua jadwal penerbangan akan muncul disini";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 26.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(18, 14);
            label1.Name = "label1";
            label1.Size = new Size(502, 40);
            label1.TabIndex = 43;
            label1.Text = "Master Jadwal Penerbangan";
            label1.Click += label1_Click;
            // 
            // txtDari
            // 
            txtDari.FormattingEnabled = true;
            txtDari.Location = new Point(180, 345);
            txtDari.Name = "txtDari";
            txtDari.Size = new Size(355, 23);
            txtDari.TabIndex = 56;
            // 
            // txtKe
            // 
            txtKe.FormattingEnabled = true;
            txtKe.Location = new Point(180, 387);
            txtKe.Name = "txtKe";
            txtKe.Size = new Size(355, 23);
            txtKe.TabIndex = 57;
            // 
            // txtMaskapai
            // 
            txtMaskapai.FormattingEnabled = true;
            txtMaskapai.Location = new Point(180, 432);
            txtMaskapai.Name = "txtMaskapai";
            txtMaskapai.Size = new Size(355, 23);
            txtMaskapai.TabIndex = 59;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(24, 432);
            label5.Name = "label5";
            label5.Size = new Size(81, 21);
            label5.TabIndex = 58;
            label5.Text = "Maskapai";
            // 
            // txtTanggal
            // 
            txtTanggal.Location = new Point(744, 301);
            txtTanggal.Name = "txtTanggal";
            txtTanggal.Size = new Size(245, 23);
            txtTanggal.TabIndex = 60;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(550, 347);
            label7.Name = "label7";
            label7.Size = new Size(172, 21);
            label7.TabIndex = 61;
            label7.Text = "Waktu Keberangkatan";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(550, 389);
            label9.Name = "label9";
            label9.Size = new Size(158, 21);
            label9.TabIndex = 62;
            label9.Text = "Durasi Penerbangan";
            label9.Click += label9_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(550, 434);
            label10.Name = "label10";
            label10.Size = new Size(126, 21);
            label10.TabIndex = 63;
            label10.Text = "Harga Per Tiket";
            // 
            // txtHargaPerTiket
            // 
            txtHargaPerTiket.Location = new Point(744, 434);
            txtHargaPerTiket.Name = "txtHargaPerTiket";
            txtHargaPerTiket.Size = new Size(245, 23);
            txtHargaPerTiket.TabIndex = 64;
            // 
            // txtDurasiPenerbangan
            // 
            txtDurasiPenerbangan.Location = new Point(744, 389);
            txtDurasiPenerbangan.Name = "txtDurasiPenerbangan";
            txtDurasiPenerbangan.Size = new Size(245, 23);
            txtDurasiPenerbangan.TabIndex = 66;
            // 
            // id
            // 
            id.Location = new Point(180, 474);
            id.Name = "id";
            id.Size = new Size(130, 23);
            id.TabIndex = 67;
            // 
            // txtWaktuKeberangkatan
            // 
            txtWaktuKeberangkatan.CustomFormat = "hh:mm:ss";
            txtWaktuKeberangkatan.Format = DateTimePickerFormat.Time;
            txtWaktuKeberangkatan.Location = new Point(743, 345);
            txtWaktuKeberangkatan.Name = "txtWaktuKeberangkatan";
            txtWaktuKeberangkatan.ShowUpDown = true;
            txtWaktuKeberangkatan.Size = new Size(245, 23);
            txtWaktuKeberangkatan.TabIndex = 68;
            // 
            // Edit
            // 
            Edit.HeaderText = "Edit";
            Edit.Name = "Edit";
            Edit.Text = "Edit";
            Edit.UseColumnTextForButtonValue = true;
            // 
            // Delete
            // 
            Delete.HeaderText = "Delete";
            Delete.Name = "Delete";
            Delete.Text = "Delete";
            Delete.UseColumnTextForButtonValue = true;
            // 
            // FrmMasterJadwalPenerbangan
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1000, 513);
            Controls.Add(txtWaktuKeberangkatan);
            Controls.Add(id);
            Controls.Add(txtDurasiPenerbangan);
            Controls.Add(txtHargaPerTiket);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label7);
            Controls.Add(txtTanggal);
            Controls.Add(txtMaskapai);
            Controls.Add(label5);
            Controls.Add(txtKe);
            Controls.Add(txtDari);
            Controls.Add(btnSimpan);
            Controls.Add(button1);
            Controls.Add(label8);
            Controls.Add(label6);
            Controls.Add(txtKodePenerbangan);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(dataGridView1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FrmMasterJadwalPenerbangan";
            Load += FrmMasterJadwalPenerbangan_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtHargaPerTiket).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSimpan;
        private Button button1;
        private Label label8;
        private Label label6;
        private TextBox txtKodePenerbangan;
        private Label label4;
        private Label label3;
        private DataGridView dataGridView1;
        private Label label2;
        private Label label1;
        private ComboBox txtDari;
        private ComboBox txtKe;
        private ComboBox txtMaskapai;
        private Label label5;
        private DateTimePicker txtTanggal;
        private Label label7;
        private Label label9;
        private Label label10;
        private NumericUpDown txtHargaPerTiket;
        private TextBox txtDurasiPenerbangan;
        private TextBox id;
        private DateTimePicker txtWaktuKeberangkatan;
        private DataGridViewButtonColumn Edit;
        private DataGridViewButtonColumn Delete;
    }
}
