namespace XIIRPL1_09_Ticketing.MasterForm
{
    partial class FrmMasterKodePromo
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
            label5 = new Label();
            label6 = new Label();
            txtKodePromo = new TextBox();
            label4 = new Label();
            label3 = new Label();
            dataGridView1 = new DataGridView();
            label2 = new Label();
            label1 = new Label();
            txtBerlakuSampai = new DateTimePicker();
            txtPersentaseDiskon = new NumericUpDown();
            txtMaksimumDiskon = new NumericUpDown();
            txtDeskripsi = new RichTextBox();
            label8 = new Label();
            id = new TextBox();
            Edit = new DataGridViewButtonColumn();
            Delete = new DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtPersentaseDiskon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtMaksimumDiskon).BeginInit();
            SuspendLayout();
            // 
            // btnSimpan
            // 
            btnSimpan.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnSimpan.Location = new Point(917, 459);
            btnSimpan.Name = "btnSimpan";
            btnSimpan.Size = new Size(75, 23);
            btnSimpan.TabIndex = 57;
            btnSimpan.Text = "Simpan";
            btnSimpan.UseVisualStyleBackColor = true;
            btnSimpan.Click += btnSimpan_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(837, 459);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 56;
            button1.Text = "Batal";
            button1.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(27, 419);
            label5.Name = "label5";
            label5.Size = new Size(150, 21);
            label5.TabIndex = 50;
            label5.Text = "Maksimum Diskon";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(27, 377);
            label6.Name = "label6";
            label6.Size = new Size(147, 21);
            label6.TabIndex = 49;
            label6.Text = "Persentase Diskon";
            // 
            // txtKodePromo
            // 
            txtKodePromo.Location = new Point(183, 289);
            txtKodePromo.Name = "txtKodePromo";
            txtKodePromo.Size = new Size(357, 23);
            txtKodePromo.TabIndex = 48;
            txtKodePromo.TextChanged += txtUsername_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(27, 332);
            label4.Name = "label4";
            label4.Size = new Size(126, 21);
            label4.TabIndex = 46;
            label4.Text = "Berlaku Sampai";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(27, 290);
            label3.Name = "label3";
            label3.Size = new Size(107, 21);
            label3.TabIndex = 45;
            label3.Text = "Kode Promo";
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Edit, Delete });
            dataGridView1.Location = new Point(26, 97);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(966, 175);
            dataGridView1.TabIndex = 43;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(26, 60);
            label2.Name = "label2";
            label2.Size = new Size(367, 19);
            label2.TabIndex = 42;
            label2.Text = "Semua kode promo yang terdaftar akan muncul disini";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 26.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(21, 17);
            label1.Name = "label1";
            label1.Size = new Size(353, 40);
            label1.TabIndex = 41;
            label1.Text = "Master Kode Promo";
            // 
            // txtBerlakuSampai
            // 
            txtBerlakuSampai.Location = new Point(183, 332);
            txtBerlakuSampai.Name = "txtBerlakuSampai";
            txtBerlakuSampai.Size = new Size(357, 23);
            txtBerlakuSampai.TabIndex = 58;
            // 
            // txtPersentaseDiskon
            // 
            txtPersentaseDiskon.Location = new Point(180, 379);
            txtPersentaseDiskon.Name = "txtPersentaseDiskon";
            txtPersentaseDiskon.Size = new Size(360, 23);
            txtPersentaseDiskon.TabIndex = 59;
            // 
            // txtMaksimumDiskon
            // 
            txtMaksimumDiskon.Location = new Point(183, 421);
            txtMaksimumDiskon.Name = "txtMaksimumDiskon";
            txtMaksimumDiskon.Size = new Size(357, 23);
            txtMaksimumDiskon.TabIndex = 60;
            // 
            // txtDeskripsi
            // 
            txtDeskripsi.Location = new Point(647, 289);
            txtDeskripsi.Name = "txtDeskripsi";
            txtDeskripsi.Size = new Size(345, 155);
            txtDeskripsi.TabIndex = 62;
            txtDeskripsi.Text = "";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(561, 291);
            label8.Name = "label8";
            label8.Size = new Size(80, 21);
            label8.TabIndex = 61;
            label8.Text = "Deskripsi";
            // 
            // id
            // 
            id.Location = new Point(180, 460);
            id.Name = "id";
            id.Size = new Size(130, 23);
            id.TabIndex = 63;
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
            // FrmMasterKodePromo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1003, 531);
            Controls.Add(id);
            Controls.Add(txtDeskripsi);
            Controls.Add(label8);
            Controls.Add(txtMaksimumDiskon);
            Controls.Add(txtPersentaseDiskon);
            Controls.Add(txtBerlakuSampai);
            Controls.Add(btnSimpan);
            Controls.Add(button1);
            Controls.Add(label5);
            Controls.Add(label6);
            Controls.Add(txtKodePromo);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(dataGridView1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FrmMasterKodePromo";
            Load += FrmMasterKodePromo_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtPersentaseDiskon).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtMaksimumDiskon).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSimpan;
        private Button button1;
        private Label label5;
        private Label label6;
        private TextBox txtKodePromo;
        private Label label4;
        private Label label3;
        private DataGridView dataGridView1;
        private Label label2;
        private Label label1;
        private DateTimePicker txtBerlakuSampai;
        private NumericUpDown txtPersentaseDiskon;
        private NumericUpDown txtMaksimumDiskon;
        private RichTextBox txtDeskripsi;
        private Label label8;
        private TextBox id;
        private DataGridViewButtonColumn Edit;
        private DataGridViewButtonColumn Delete;
    }
}
