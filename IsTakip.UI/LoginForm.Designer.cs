namespace IsTakip.UI
{
    partial class LoginForm
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
            lblEmail = new Label();
            txtEmail = new TextBox();
            label2 = new Label();
            txtSifre = new TextBox();
            btnGiris = new Button();
            lblHata = new Label();
            SuspendLayout();
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(12, 21);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(36, 15);
            lblEmail.TabIndex = 0;
            lblEmail.Text = "Email";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(12, 39);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(297, 23);
            txtEmail.TabIndex = 1;
            txtEmail.TextChanged += txtEmail_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 75);
            label2.Name = "label2";
            label2.Size = new Size(30, 15);
            label2.TabIndex = 0;
            label2.Text = "Şifre";
            // 
            // txtSifre
            // 
            txtSifre.Location = new Point(12, 93);
            txtSifre.Name = "txtSifre";
            txtSifre.PasswordChar = '*';
            txtSifre.Size = new Size(297, 23);
            txtSifre.TabIndex = 1;
            // 
            // btnGiris
            // 
            btnGiris.Location = new Point(100, 142);
            btnGiris.Name = "btnGiris";
            btnGiris.Size = new Size(126, 23);
            btnGiris.TabIndex = 2;
            btnGiris.Text = "Giriş Yap";
            btnGiris.UseVisualStyleBackColor = true;
            btnGiris.Click += btnGiris_Click;
            // 
            // lblHata
            // 
            lblHata.AutoSize = true;
            lblHata.ForeColor = Color.Red;
            lblHata.Location = new Point(12, 187);
            lblHata.Name = "lblHata";
            lblHata.Size = new Size(0, 15);
            lblHata.TabIndex = 0;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(334, 211);
            Controls.Add(btnGiris);
            Controls.Add(txtSifre);
            Controls.Add(lblHata);
            Controls.Add(label2);
            Controls.Add(txtEmail);
            Controls.Add(lblEmail);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "İş Takip - Giriş";
            Load += LoginForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblEmail;
        private TextBox txtEmail;
        private Label label2;
        private TextBox txtSifre;
        private Button btnGiris;
        private Label lblHata;
    }
}