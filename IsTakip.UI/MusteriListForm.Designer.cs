namespace IsTakip.UI
{
    partial class MusteriListForm
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
            dgvMusteriler = new DataGridView();
            groupBox1 = new GroupBox();
            btnEkle = new Button();
            btnGuncelle = new Button();
            btnSil = new Button();
            txtVergiNo = new TextBox();
            txtAdres = new TextBox();
            txtTelefon = new TextBox();
            label6 = new Label();
            label4 = new Label();
            label2 = new Label();
            txtEmail = new TextBox();
            label5 = new Label();
            txtSoyad = new TextBox();
            label3 = new Label();
            txtAd = new TextBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvMusteriler).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // dgvMusteriler
            // 
            dgvMusteriler.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMusteriler.Dock = DockStyle.Top;
            dgvMusteriler.Location = new Point(0, 0);
            dgvMusteriler.Name = "dgvMusteriler";
            dgvMusteriler.Size = new Size(800, 274);
            dgvMusteriler.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnEkle);
            groupBox1.Controls.Add(btnGuncelle);
            groupBox1.Controls.Add(btnSil);
            groupBox1.Controls.Add(txtVergiNo);
            groupBox1.Controls.Add(txtAdres);
            groupBox1.Controls.Add(txtTelefon);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtEmail);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(txtSoyad);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtAd);
            groupBox1.Controls.Add(label1);
            groupBox1.Dock = DockStyle.Bottom;
            groupBox1.Location = new Point(0, 280);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(800, 170);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Müşteri İşlemleri";
            // 
            // btnEkle
            // 
            btnEkle.Location = new Point(551, 135);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(75, 23);
            btnEkle.TabIndex = 2;
            btnEkle.Text = "Ekle";
            btnEkle.UseVisualStyleBackColor = true;
            btnEkle.Click += btnEkle_Click;
            // 
            // btnGuncelle
            // 
            btnGuncelle.Location = new Point(632, 135);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Size = new Size(75, 23);
            btnGuncelle.TabIndex = 2;
            btnGuncelle.Text = "Güncelle";
            btnGuncelle.UseVisualStyleBackColor = true;
            btnGuncelle.Click += btnGuncelle_Click;
            // 
            // btnSil
            // 
            btnSil.Location = new Point(713, 135);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(75, 23);
            btnSil.TabIndex = 2;
            btnSil.Text = "Sil";
            btnSil.UseVisualStyleBackColor = true;
            btnSil.Click += btnSil_Click;
            // 
            // txtVergiNo
            // 
            txtVergiNo.Location = new Point(394, 102);
            txtVergiNo.Name = "txtVergiNo";
            txtVergiNo.Size = new Size(150, 23);
            txtVergiNo.TabIndex = 1;
            // 
            // txtAdres
            // 
            txtAdres.Location = new Point(198, 102);
            txtAdres.Name = "txtAdres";
            txtAdres.Size = new Size(150, 23);
            txtAdres.TabIndex = 1;
            // 
            // txtTelefon
            // 
            txtTelefon.Location = new Point(12, 102);
            txtTelefon.Name = "txtTelefon";
            txtTelefon.Size = new Size(150, 23);
            txtTelefon.TabIndex = 1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(394, 84);
            label6.Name = "label6";
            label6.Size = new Size(52, 15);
            label6.TabIndex = 0;
            label6.Text = "Vergi No";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(198, 84);
            label4.Name = "label4";
            label4.Size = new Size(37, 15);
            label4.TabIndex = 0;
            label4.Text = "Adres";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 84);
            label2.Name = "label2";
            label2.Size = new Size(46, 15);
            label2.TabIndex = 0;
            label2.Text = "Telefon";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(394, 37);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(150, 23);
            txtEmail.TabIndex = 1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(394, 19);
            label5.Name = "label5";
            label5.Size = new Size(36, 15);
            label5.TabIndex = 0;
            label5.Text = "Email";
            // 
            // txtSoyad
            // 
            txtSoyad.Location = new Point(198, 37);
            txtSoyad.Name = "txtSoyad";
            txtSoyad.Size = new Size(150, 23);
            txtSoyad.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(198, 19);
            label3.Name = "label3";
            label3.Size = new Size(39, 15);
            label3.TabIndex = 0;
            label3.Text = "Soyad";
            // 
            // txtAd
            // 
            txtAd.Location = new Point(12, 37);
            txtAd.Name = "txtAd";
            txtAd.Size = new Size(150, 23);
            txtAd.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 19);
            label1.Name = "label1";
            label1.Size = new Size(22, 15);
            label1.TabIndex = 0;
            label1.Text = "Ad";
            // 
            // MusteriListForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox1);
            Controls.Add(dgvMusteriler);
            Name = "MusteriListForm";
            Text = "Müşteri";
            Load += MusteriListForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvMusteriler).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvMusteriler;
        private GroupBox groupBox1;
        private Button btnEkle;
        private Button btnGuncelle;
        private Button btnSil;
        private TextBox txtVergiNo;
        private TextBox txtAdres;
        private TextBox txtTelefon;
        private Label label6;
        private Label label4;
        private Label label2;
        private TextBox txtEmail;
        private Label label5;
        private TextBox txtSoyad;
        private Label label3;
        private TextBox txtAd;
        private Label label1;
    }
}