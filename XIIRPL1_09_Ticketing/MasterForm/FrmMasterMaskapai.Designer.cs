namespace XIIRPL1_09_Ticketing.MasterForm
{
    partial class FrmMasterMaskapai
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
            txtDeskripsi = new RichTextBox();
            label8 = new Label();
            label6 = new Label();
            txtNama = new TextBox();
            txtPerusahaan = new TextBox();
            label4 = new Label();
            label3 = new Label();
            txtJumlahKru = new NumericUpDown();
            dataGridView1 = new DataGridView();
            Edit = new DataGridViewButtonColumn();
            Delete = new DataGridViewButtonColumn();
            label2 = new Label();
            label1 = new Label();
            btnSimpan = new Button();
            button1 = new Button();
            id = new TextBox();
            btnEdit = new Button();
            ((System.ComponentModel.ISupportInitialize)txtJumlahKru).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // txtDeskripsi
            // 
            txtDeskripsi.Location = new Point(576, 301);
            txtDeskripsi.Name = "txtDeskripsi";
            txtDeskripsi.Size = new Size(412, 108);
            txtDeskripsi.TabIndex = 36;
            txtDeskripsi.Text = "";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(490, 302);
            label8.Name = "label8";
            label8.Size = new Size(80, 21);
            label8.TabIndex = 35;
            label8.Text = "Deskripsi";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(24, 388);
            label6.Name = "label6";
            label6.Size = new Size(94, 21);
            label6.TabIndex = 30;
            label6.Text = "Jumlah Kru";
            // 
            // txtNama
            // 
            txtNama.Location = new Point(126, 300);
            txtNama.Name = "txtNama";
            txtNama.Size = new Size(353, 23);
            txtNama.TabIndex = 29;
            // 
            // txtPerusahaan
            // 
            txtPerusahaan.Location = new Point(126, 341);
            txtPerusahaan.Name = "txtPerusahaan";
            txtPerusahaan.Size = new Size(353, 23);
            txtPerusahaan.TabIndex = 28;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(24, 343);
            label4.Name = "label4";
            label4.Size = new Size(94, 21);
            label4.TabIndex = 27;
            label4.Text = "Perusahaan";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(24, 301);
            label3.Name = "label3";
            label3.Size = new Size(53, 21);
            label3.TabIndex = 26;
            label3.Text = "Nama";
            // 
            // txtJumlahKru
            // 
            txtJumlahKru.Location = new Point(126, 386);
            txtJumlahKru.Name = "txtJumlahKru";
            txtJumlahKru.Size = new Size(353, 23);
            txtJumlahKru.TabIndex = 25;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Edit, Delete });
            dataGridView1.Location = new Point(23, 95);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(966, 184);
            dataGridView1.TabIndex = 24;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick_1;
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
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(23, 58);
            label2.Name = "label2";
            label2.Size = new Size(347, 19);
            label2.TabIndex = 23;
            label2.Text = "Semua maskapai yang terdaftar akan muncul disini";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 26.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(18, 15);
            label1.Name = "label1";
            label1.Size = new Size(305, 40);
            label1.TabIndex = 22;
            label1.Text = "Master Maskapai";
            // 
            // btnSimpan
            // 
            btnSimpan.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnSimpan.Location = new Point(752, 430);
            btnSimpan.Name = "btnSimpan";
            btnSimpan.Size = new Size(75, 23);
            btnSimpan.TabIndex = 42;
            btnSimpan.Text = "Simpan";
            btnSimpan.UseVisualStyleBackColor = true;
            btnSimpan.Click += btnSimpan_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(914, 431);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 41;
            button1.Text = "Batal";
            button1.UseVisualStyleBackColor = true;
            // 
            // id
            // 
            id.Location = new Point(126, 431);
            id.Name = "id";
            id.Size = new Size(130, 23);
            id.TabIndex = 43;
            // 
            // btnEdit
            // 
            btnEdit.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnEdit.Location = new Point(833, 430);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(75, 23);
            btnEdit.TabIndex = 44;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // FrmMasterMaskapai
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1000, 469);
            Controls.Add(btnEdit);
            Controls.Add(id);
            Controls.Add(btnSimpan);
            Controls.Add(button1);
            Controls.Add(txtDeskripsi);
            Controls.Add(label8);
            Controls.Add(label6);
            Controls.Add(txtNama);
            Controls.Add(txtPerusahaan);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txtJumlahKru);
            Controls.Add(dataGridView1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FrmMasterMaskapai";
            Load += FrmMasterMaskapai_Load;
            ((System.ComponentModel.ISupportInitialize)txtJumlahKru).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox txtDeskripsi;
        private Label label8;
        private Label label6;
        private TextBox txtNama;
        private TextBox txtPerusahaan;
        private Label label4;
        private Label label3;
        private NumericUpDown txtJumlahKru;
        private DataGridView dataGridView1;
        private Label label2;
        private Label label1;
        private Button btnSimpan;
        private Button button1;
        private TextBox id;
        private DataGridViewButtonColumn Edit;
        private DataGridViewButtonColumn Delete;
        private Button btnEdit;
    }
}
