namespace XIIRPL1_09_Ticketing
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            btnLogin = new Button();
            txtLinkLabel = new LinkLabel();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnLogin
            // 
            btnLogin.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnLogin.Location = new Point(536, 336);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(75, 23);
            btnLogin.TabIndex = 15;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // txtLinkLabel
            // 
            txtLinkLabel.AutoSize = true;
            txtLinkLabel.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtLinkLabel.Location = new Point(399, 379);
            txtLinkLabel.Name = "txtLinkLabel";
            txtLinkLabel.Size = new Size(140, 21);
            txtLinkLabel.TabIndex = 14;
            txtLinkLabel.TabStop = true;
            txtLinkLabel.Text = "Daftar Sekarang !";
            txtLinkLabel.LinkClicked += txtLinkLabel_LinkClicked;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(239, 379);
            label3.Name = "label3";
            label3.Size = new Size(160, 21);
            label3.TabIndex = 13;
            label3.Text = "Belum punya akun ?";
            label3.Click += label3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(205, 291);
            label2.Name = "label2";
            label2.Size = new Size(84, 21);
            label2.TabIndex = 12;
            label2.Text = "Password";
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(202, 239);
            label1.Name = "label1";
            label1.Size = new Size(84, 21);
            label1.TabIndex = 11;
            label1.Text = "Username";
            label1.Click += label1_Click;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(295, 242);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(316, 23);
            txtUsername.TabIndex = 10;
            txtUsername.TextChanged += txtUsername_TextChanged;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(295, 289);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(316, 23);
            txtPassword.TabIndex = 9;
            txtPassword.TextChanged += txtPassword_TextChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(150, 50);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(500, 157);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 450);
            Controls.Add(btnLogin);
            Controls.Add(txtLinkLabel);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtUsername);
            Controls.Add(txtPassword);
            Controls.Add(pictureBox1);
            Name = "Login";
            Text = "Login";
            Load += Login_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnLogin;
        private LinkLabel txtLinkLabel;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private PictureBox pictureBox1;
    }
}