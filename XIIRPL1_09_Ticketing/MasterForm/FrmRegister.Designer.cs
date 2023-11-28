namespace XIIRPL1_09_Ticketing.MasterForm
{
    partial class FrmRegister
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRegister));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            txtTglLahir = new DateTimePicker();
            txtNama = new TextBox();
            txtUsername = new TextBox();
            txtNomorTlp = new TextBox();
            txtPassword = new TextBox();
            btnDaftar = new Button();
            txtLinkLabel = new LinkLabel();
            label8 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 26.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(34, 33);
            label1.Name = "label1";
            label1.Size = new Size(220, 40);
            label1.TabIndex = 0;
            label1.Text = "Daftar Akun";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(39, 81);
            label2.Name = "label2";
            label2.Size = new Size(305, 15);
            label2.TabIndex = 1;
            label2.Text = "Daftarkan diri Anda untuk menggunakan Bromo Airlines";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(39, 120);
            label3.Name = "label3";
            label3.Size = new Size(84, 21);
            label3.TabIndex = 2;
            label3.Text = "Username";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(39, 162);
            label4.Name = "label4";
            label4.Size = new Size(53, 21);
            label4.TabIndex = 3;
            label4.Text = "Nama";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(39, 204);
            label5.Name = "label5";
            label5.Size = new Size(111, 21);
            label5.TabIndex = 4;
            label5.Text = "Tanggal Lahir";
            label5.Click += label5_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(39, 247);
            label6.Name = "label6";
            label6.Size = new Size(128, 21);
            label6.TabIndex = 5;
            label6.Text = "Nomor Telepon";
            label6.Click += label6_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(39, 292);
            label7.Name = "label7";
            label7.Size = new Size(84, 21);
            label7.TabIndex = 6;
            label7.Text = "Password";
            label7.Click += label7_Click;
            // 
            // txtTglLahir
            // 
            txtTglLahir.Location = new Point(211, 203);
            txtTglLahir.Name = "txtTglLahir";
            txtTglLahir.Size = new Size(236, 23);
            txtTglLahir.TabIndex = 7;
            txtTglLahir.ValueChanged += txtTglLahir_ValueChanged;
            // 
            // txtNama
            // 
            txtNama.Location = new Point(211, 160);
            txtNama.Name = "txtNama";
            txtNama.Size = new Size(236, 23);
            txtNama.TabIndex = 8;
            txtNama.TextChanged += textBox1_TextChanged;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(211, 119);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(236, 23);
            txtUsername.TabIndex = 9;
            txtUsername.TextChanged += txtUsername_TextChanged;
            // 
            // txtNomorTlp
            // 
            txtNomorTlp.Location = new Point(211, 245);
            txtNomorTlp.Name = "txtNomorTlp";
            txtNomorTlp.Size = new Size(236, 23);
            txtNomorTlp.TabIndex = 10;
            txtNomorTlp.TextChanged += txtNomorTlp_TextChanged;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(211, 288);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(236, 23);
            txtPassword.TabIndex = 11;
            txtPassword.TextChanged += txtPassword_TextChanged;
            // 
            // btnDaftar
            // 
            btnDaftar.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnDaftar.Location = new Point(372, 331);
            btnDaftar.Name = "btnDaftar";
            btnDaftar.Size = new Size(75, 23);
            btnDaftar.TabIndex = 12;
            btnDaftar.Text = "Daftar";
            btnDaftar.UseVisualStyleBackColor = true;
            btnDaftar.Click += btnDaftar_Click;
            // 
            // txtLinkLabel
            // 
            txtLinkLabel.AutoSize = true;
            txtLinkLabel.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtLinkLabel.Location = new Point(201, 386);
            txtLinkLabel.Name = "txtLinkLabel";
            txtLinkLabel.Size = new Size(53, 21);
            txtLinkLabel.TabIndex = 14;
            txtLinkLabel.TabStop = true;
            txtLinkLabel.Text = "Login";
            txtLinkLabel.LinkClicked += txtLinkLabel_LinkClicked;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(39, 386);
            label8.Name = "label8";
            label8.Size = new Size(160, 21);
            label8.TabIndex = 13;
            label8.Text = "Sudah punya akun ?";
            label8.Click += label8_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(465, 108);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(300, 220);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 15;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // FrmRegister
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox1);
            Controls.Add(txtLinkLabel);
            Controls.Add(label8);
            Controls.Add(btnDaftar);
            Controls.Add(txtPassword);
            Controls.Add(txtNomorTlp);
            Controls.Add(txtUsername);
            Controls.Add(txtNama);
            Controls.Add(txtTglLahir);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FrmRegister";
            Text = "FrmRegister";
            Load += FrmRegister_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private DateTimePicker txtTglLahir;
        private TextBox txtNama;
        private TextBox txtUsername;
        private TextBox txtNomorTlp;
        private TextBox txtPassword;
        private Button btnDaftar;
        private LinkLabel txtLinkLabel;
        private Label label8;
        private PictureBox pictureBox1;
    }
}