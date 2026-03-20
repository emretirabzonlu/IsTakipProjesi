namespace IsTakip.UI
{
    partial class PersonelListForm
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
            dgvPersoneller = new DataGridView();
            groupBox1 = new GroupBox();
            btnEkle = new Button();
            btnGuncelle = new Button();
            btnSil = new Button();
            cmbRol = new ComboBox();
            cmbDepartman = new ComboBox();
            txtSifre = new TextBox();
            Rol = new Label();
            label6 = new Label();
            txtTelefon = new TextBox();
            label4 = new Label();
            txtEmail = new TextBox();
            label2 = new Label();
            txtSoyad = new TextBox();
            label5 = new Label();
            txtAd = new TextBox();
            label3 = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvPersoneller).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // dgvPersoneller
            // 
            dgvPersoneller.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPersoneller.Dock = DockStyle.Top;
            dgvPersoneller.Location = new Point(0, 0);
            dgvPersoneller.Name = "dgvPersoneller";
            dgvPersoneller.Size = new Size(800, 281);
            dgvPersoneller.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnEkle);
            groupBox1.Controls.Add(btnGuncelle);
            groupBox1.Controls.Add(btnSil);
            groupBox1.Controls.Add(cmbRol);
            groupBox1.Controls.Add(cmbDepartman);
            groupBox1.Controls.Add(txtSifre);
            groupBox1.Controls.Add(Rol);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(txtTelefon);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtEmail);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtSoyad);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(txtAd);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label1);
            groupBox1.Dock = DockStyle.Bottom;
            groupBox1.Location = new Point(0, 287);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(800, 163);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Personel İşlemleri";
            // 
            // btnEkle
            // 
            btnEkle.Location = new Point(543, 128);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(75, 23);
            btnEkle.TabIndex = 3;
            btnEkle.Text = "Ekle";
            btnEkle.UseVisualStyleBackColor = true;
            btnEkle.Click += btnEkle_Click;
            // 
            // btnGuncelle
            // 
            btnGuncelle.Location = new Point(624, 128);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Size = new Size(75, 23);
            btnGuncelle.TabIndex = 3;
            btnGuncelle.Text = "Güncelle";
            btnGuncelle.UseVisualStyleBackColor = true;
            btnGuncelle.Click += btnGuncelle_Click;
            // 
            // btnSil
            // 
            btnSil.Location = new Point(705, 128);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(75, 23);
            btnSil.TabIndex = 3;
            btnSil.Text = "Sil";
            btnSil.UseVisualStyleBackColor = true;
            btnSil.Click += btnSil_Click;
            // 
            // cmbRol
            // 
            cmbRol.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbRol.FormattingEnabled = true;
            cmbRol.Location = new Point(598, 37);
            cmbRol.Name = "cmbRol";
            cmbRol.Size = new Size(164, 23);
            cmbRol.TabIndex = 2;
            // 
            // cmbDepartman
            // 
            cmbDepartman.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbDepartman.FormattingEnabled = true;
            cmbDepartman.Location = new Point(405, 94);
            cmbDepartman.Name = "cmbDepartman";
            cmbDepartman.Size = new Size(164, 23);
            cmbDepartman.TabIndex = 2;
            // 
            // txtSifre
            // 
            txtSifre.Location = new Point(207, 94);
            txtSifre.Name = "txtSifre";
            txtSifre.Size = new Size(164, 23);
            txtSifre.TabIndex = 1;
            // 
            // Rol
            // 
            Rol.AutoSize = true;
            Rol.Location = new Point(595, 19);
            Rol.Name = "Rol";
            Rol.Size = new Size(24, 15);
            Rol.TabIndex = 0;
            Rol.Text = "Rol";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(402, 76);
            label6.Name = "label6";
            label6.Size = new Size(66, 15);
            label6.TabIndex = 0;
            label6.Text = "Departman";
            // 
            // txtTelefon
            // 
            txtTelefon.Location = new Point(12, 94);
            txtTelefon.Name = "txtTelefon";
            txtTelefon.Size = new Size(164, 23);
            txtTelefon.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(204, 76);
            label4.Name = "label4";
            label4.Size = new Size(30, 15);
            label4.TabIndex = 0;
            label4.Text = "Şifre";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(405, 37);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(164, 23);
            txtEmail.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(9, 76);
            label2.Name = "label2";
            label2.Size = new Size(46, 15);
            label2.TabIndex = 0;
            label2.Text = "Telefon";
            // 
            // txtSoyad
            // 
            txtSoyad.Location = new Point(207, 37);
            txtSoyad.Name = "txtSoyad";
            txtSoyad.Size = new Size(164, 23);
            txtSoyad.TabIndex = 1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(402, 19);
            label5.Name = "label5";
            label5.Size = new Size(36, 15);
            label5.TabIndex = 0;
            label5.Text = "Email";
            // 
            // txtAd
            // 
            txtAd.Location = new Point(12, 37);
            txtAd.Name = "txtAd";
            txtAd.Size = new Size(164, 23);
            txtAd.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(204, 19);
            label3.Name = "label3";
            label3.Size = new Size(39, 15);
            label3.TabIndex = 0;
            label3.Text = "Soyad";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(9, 19);
            label1.Name = "label1";
            label1.Size = new Size(22, 15);
            label1.TabIndex = 0;
            label1.Text = "Ad";
            // 
            // PersonelListForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox1);
            Controls.Add(dgvPersoneller);
            Name = "PersonelListForm";
            Text = "Personel";
            Load += PersonelListForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvPersoneller).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvPersoneller;
        private GroupBox groupBox1;
        private ComboBox cmbDepartman;
        private TextBox txtSifre;
        private Label label6;
        private TextBox txtTelefon;
        private Label label4;
        private TextBox txtEmail;
        private Label label2;
        private TextBox txtSoyad;
        private Label label5;
        private TextBox txtAd;
        private Label label3;
        private Label label1;
        private Button btnEkle;
        private Button btnGuncelle;
        private Button btnSil;
        private ComboBox cmbRol;
        private Label Rol;
    }
}