namespace IsTakip.UI
{
    partial class ProjeListForm
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
            groupBox1 = new GroupBox();
            dtpBaslangic = new DateTimePicker();
            label5 = new Label();
            cmbDurum = new ComboBox();
            cmbMusteri = new ComboBox();
            btnEkle = new Button();
            btnGuncelle = new Button();
            btnSil = new Button();
            label4 = new Label();
            label2 = new Label();
            txtAciklama = new TextBox();
            label3 = new Label();
            txtProjeAdi = new TextBox();
            label1 = new Label();
            dgvProjeler = new DataGridView();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProjeler).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dtpBaslangic);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(cmbDurum);
            groupBox1.Controls.Add(cmbMusteri);
            groupBox1.Controls.Add(btnEkle);
            groupBox1.Controls.Add(btnGuncelle);
            groupBox1.Controls.Add(btnSil);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtAciklama);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtProjeAdi);
            groupBox1.Controls.Add(label1);
            groupBox1.Dock = DockStyle.Bottom;
            groupBox1.Location = new Point(0, 280);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(800, 170);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Proje İşlemleri";
            // 
            // dtpBaslangic
            // 
            dtpBaslangic.Location = new Point(551, 37);
            dtpBaslangic.Name = "dtpBaslangic";
            dtpBaslangic.Size = new Size(237, 23);
            dtpBaslangic.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(551, 19);
            label5.Name = "label5";
            label5.Size = new Size(33, 15);
            label5.TabIndex = 5;
            label5.Text = "Tarih";
            // 
            // cmbDurum
            // 
            cmbDurum.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbDurum.FormattingEnabled = true;
            cmbDurum.Items.AddRange(new object[] { "Devam Ediyor", "Tamamlandı", "İptal" });
            cmbDurum.Location = new Point(286, 102);
            cmbDurum.Name = "cmbDurum";
            cmbDurum.Size = new Size(236, 23);
            cmbDurum.TabIndex = 4;
            // 
            // cmbMusteri
            // 
            cmbMusteri.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbMusteri.FormattingEnabled = true;
            cmbMusteri.Location = new Point(12, 102);
            cmbMusteri.Name = "cmbMusteri";
            cmbMusteri.Size = new Size(236, 23);
            cmbMusteri.TabIndex = 3;
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
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(286, 84);
            label4.Name = "label4";
            label4.Size = new Size(44, 15);
            label4.TabIndex = 0;
            label4.Text = "Durum";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 84);
            label2.Name = "label2";
            label2.Size = new Size(47, 15);
            label2.TabIndex = 0;
            label2.Text = "Müşteri";
            // 
            // txtAciklama
            // 
            txtAciklama.Location = new Point(286, 37);
            txtAciklama.Name = "txtAciklama";
            txtAciklama.Size = new Size(236, 23);
            txtAciklama.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(286, 19);
            label3.Name = "label3";
            label3.Size = new Size(56, 15);
            label3.TabIndex = 0;
            label3.Text = "Açıklama";
            // 
            // txtProjeAdi
            // 
            txtProjeAdi.Location = new Point(12, 37);
            txtProjeAdi.Name = "txtProjeAdi";
            txtProjeAdi.Size = new Size(236, 23);
            txtProjeAdi.TabIndex = 1;
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
            // dgvProjeler
            // 
            dgvProjeler.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProjeler.Dock = DockStyle.Top;
            dgvProjeler.Location = new Point(0, 0);
            dgvProjeler.Name = "dgvProjeler";
            dgvProjeler.Size = new Size(800, 274);
            dgvProjeler.TabIndex = 2;
            // 
            // ProjeListForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox1);
            Controls.Add(dgvProjeler);
            Name = "ProjeListForm";
            Text = "Proje";
            Load += ProjeListForm_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProjeler).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button btnEkle;
        private Button btnGuncelle;
        private Button btnSil;
        private Label label4;
        private Label label2;
        private TextBox txtAciklama;
        private Label label3;
        private TextBox txtProjeAdi;
        private Label label1;
        private DataGridView dgvProjeler;
        private ComboBox cmbDurum;
        private ComboBox cmbMusteri;
        private DateTimePicker dtpBaslangic;
        private Label label5;
    }
}