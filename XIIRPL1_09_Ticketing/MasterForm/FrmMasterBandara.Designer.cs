namespace XIIRPL1_09_Ticketing.MasterForm
{
    partial class FrmMasterBandara
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
            label2 = new Label();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            Edit = new DataGridViewButtonColumn();
            Delete = new DataGridViewButtonColumn();
            txtJumlahTerminal = new NumericUpDown();
            txtNama = new TextBox();
            txtKodeIATA = new TextBox();
            label4 = new Label();
            label3 = new Label();
            txtKota = new TextBox();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            txtAlamat = new RichTextBox();
            txtNegara = new ComboBox();
            button1 = new Button();
            btnSimpan = new Button();
            id = new TextBox();
            btnEdit = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtJumlahTerminal).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(25, 59);
            label2.Name = "label2";
            label2.Size = new Size(336, 19);
            label2.TabIndex = 3;
            label2.Text = "Semua bandara yang terdaftar akan muncul disini";
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 26.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(20, 16);
            label1.Name = "label1";
            label1.Size = new Size(289, 40);
            label1.TabIndex = 2;
            label1.Text = "Master Bandara";
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Edit, Delete });
            dataGridView1.Location = new Point(25, 96);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(966, 175);
            dataGridView1.TabIndex = 4;
            dataGridView1.CellClick += dataGridView1_CellClick;
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
            // txtJumlahTerminal
            // 
            txtJumlahTerminal.Location = new Point(686, 289);
            txtJumlahTerminal.Name = "txtJumlahTerminal";
            txtJumlahTerminal.Size = new Size(304, 23);
            txtJumlahTerminal.TabIndex = 5;
            // 
            // txtNama
            // 
            txtNama.Location = new Point(128, 288);
            txtNama.Name = "txtNama";
            txtNama.Size = new Size(411, 23);
            txtNama.TabIndex = 13;
            // 
            // txtKodeIATA
            // 
            txtKodeIATA.Location = new Point(128, 329);
            txtKodeIATA.Name = "txtKodeIATA";
            txtKodeIATA.Size = new Size(411, 23);
            txtKodeIATA.TabIndex = 12;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(26, 331);
            label4.Name = "label4";
            label4.Size = new Size(96, 21);
            label4.TabIndex = 11;
            label4.Text = "Kode IATA";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(26, 289);
            label3.Name = "label3";
            label3.Size = new Size(53, 21);
            label3.TabIndex = 10;
            label3.Text = "Nama";
            // 
            // txtKota
            // 
            txtKota.Location = new Point(128, 375);
            txtKota.Name = "txtKota";
            txtKota.Size = new Size(411, 23);
            txtKota.TabIndex = 17;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(26, 418);
            label5.Name = "label5";
            label5.Size = new Size(62, 21);
            label5.TabIndex = 15;
            label5.Text = "Negara";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(26, 376);
            label6.Name = "label6";
            label6.Size = new Size(46, 21);
            label6.TabIndex = 14;
            label6.Text = "Kota";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(550, 289);
            label7.Name = "label7";
            label7.Size = new Size(130, 21);
            label7.TabIndex = 18;
            label7.Text = "Jumlah Terminal";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(550, 331);
            label8.Name = "label8";
            label8.Size = new Size(62, 21);
            label8.TabIndex = 19;
            label8.Text = "Alamat";
            // 
            // txtAlamat
            // 
            txtAlamat.Location = new Point(686, 329);
            txtAlamat.Name = "txtAlamat";
            txtAlamat.Size = new Size(304, 113);
            txtAlamat.TabIndex = 21;
            txtAlamat.Text = "";
            // 
            // txtNegara
            // 
            txtNegara.FormattingEnabled = true;
            txtNegara.Location = new Point(128, 419);
            txtNegara.Name = "txtNegara";
            txtNegara.Size = new Size(411, 23);
            txtNegara.TabIndex = 38;
            // 
            // button1
            // 
            button1.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(916, 457);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 39;
            button1.Text = "Batal";
            button1.UseVisualStyleBackColor = true;
            // 
            // btnSimpan
            // 
            btnSimpan.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnSimpan.Location = new Point(754, 458);
            btnSimpan.Name = "btnSimpan";
            btnSimpan.Size = new Size(75, 23);
            btnSimpan.TabIndex = 40;
            btnSimpan.Text = "Simpan";
            btnSimpan.UseVisualStyleBackColor = true;
            btnSimpan.Click += btnSimpan_Click;
            // 
            // id
            // 
            id.Location = new Point(128, 459);
            id.Name = "id";
            id.Size = new Size(130, 23);
            id.TabIndex = 41;
            // 
            // btnEdit
            // 
            btnEdit.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnEdit.Location = new Point(835, 458);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(75, 23);
            btnEdit.TabIndex = 42;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // FrmMasterBandara
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1026, 492);
            Controls.Add(btnEdit);
            Controls.Add(id);
            Controls.Add(btnSimpan);
            Controls.Add(button1);
            Controls.Add(txtNegara);
            Controls.Add(txtAlamat);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(txtKota);
            Controls.Add(label5);
            Controls.Add(label6);
            Controls.Add(txtNama);
            Controls.Add(txtKodeIATA);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txtJumlahTerminal);
            Controls.Add(dataGridView1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FrmMasterBandara";
            Load += FrmMasterBandara_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtJumlahTerminal).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Label label1;
        private DataGridView dataGridView1;
        private NumericUpDown txtJumlahTerminal;
        private TextBox txtNama;
        private TextBox txtKodeIATA;
        private Label label4;
        private Label label3;
        private TextBox txtKota;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private RichTextBox txtAlamat;
        private ComboBox txtNegara;
        private Button button1;
        private Button btnSimpan;
        private TextBox id;
        private DataGridViewButtonColumn Edit;
        private DataGridViewButtonColumn Delete;
        private Button btnEdit;
    }
}
