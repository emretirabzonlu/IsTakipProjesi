namespace IsTakip.UI
{
    partial class GorevListForm
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
            dgvGorevler = new DataGridView();
            groupBox1 = new GroupBox();
            btnSil = new Button();
            btnGuncelle = new Button();
            btnEkle = new Button();
            cmbDurum = new ComboBox();
            cmbPersonel = new ComboBox();
            txtAciklama = new TextBox();
            txtBaslik = new TextBox();
            label4 = new Label();
            label2 = new Label();
            label3 = new Label();
            label1 = new Label();
            btnYorumlar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvGorevler).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // dgvGorevler
            // 
            dgvGorevler.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvGorevler.Dock = DockStyle.Top;
            dgvGorevler.Location = new Point(0, 0);
            dgvGorevler.Name = "dgvGorevler";
            dgvGorevler.Size = new Size(800, 244);
            dgvGorevler.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnSil);
            groupBox1.Controls.Add(btnGuncelle);
            groupBox1.Controls.Add(btnYorumlar);
            groupBox1.Controls.Add(btnEkle);
            groupBox1.Controls.Add(cmbDurum);
            groupBox1.Controls.Add(cmbPersonel);
            groupBox1.Controls.Add(txtAciklama);
            groupBox1.Controls.Add(txtBaslik);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label1);
            groupBox1.Dock = DockStyle.Bottom;
            groupBox1.Location = new Point(0, 250);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(800, 200);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Görev İşlemleri";
            // 
            // btnSil
            // 
            btnSil.Location = new Point(707, 165);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(75, 23);
            btnSil.TabIndex = 3;
            btnSil.Text = "Sil";
            btnSil.UseVisualStyleBackColor = true;
            btnSil.Click += btnSil_Click;
            // 
            // btnGuncelle
            // 
            btnGuncelle.Location = new Point(626, 165);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Size = new Size(75, 23);
            btnGuncelle.TabIndex = 3;
            btnGuncelle.Text = "Güncelle";
            btnGuncelle.UseVisualStyleBackColor = true;
            btnGuncelle.Click += btnGuncelle_Click;
            // 
            // btnEkle
            // 
            btnEkle.Location = new Point(545, 165);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(75, 23);
            btnEkle.TabIndex = 3;
            btnEkle.Text = "Ekle";
            btnEkle.UseVisualStyleBackColor = true;
            btnEkle.Click += btnEkle_Click;
            // 
            // cmbDurum
            // 
            cmbDurum.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbDurum.FormattingEnabled = true;
            cmbDurum.Location = new Point(300, 111);
            cmbDurum.Name = "cmbDurum";
            cmbDurum.Size = new Size(262, 23);
            cmbDurum.TabIndex = 2;
            // 
            // cmbPersonel
            // 
            cmbPersonel.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPersonel.FormattingEnabled = true;
            cmbPersonel.Location = new Point(300, 57);
            cmbPersonel.Name = "cmbPersonel";
            cmbPersonel.Size = new Size(262, 23);
            cmbPersonel.TabIndex = 2;
            // 
            // txtAciklama
            // 
            txtAciklama.Location = new Point(12, 111);
            txtAciklama.Name = "txtAciklama";
            txtAciklama.Size = new Size(241, 23);
            txtAciklama.TabIndex = 1;
            // 
            // txtBaslik
            // 
            txtBaslik.Location = new Point(12, 57);
            txtBaslik.Name = "txtBaslik";
            txtBaslik.Size = new Size(241, 23);
            txtBaslik.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(300, 93);
            label4.Name = "label4";
            label4.Size = new Size(44, 15);
            label4.TabIndex = 0;
            label4.Text = "Durum";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 93);
            label2.Name = "label2";
            label2.Size = new Size(56, 15);
            label2.TabIndex = 0;
            label2.Text = "Açıklama";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(300, 39);
            label3.Name = "label3";
            label3.Size = new Size(52, 15);
            label3.TabIndex = 0;
            label3.Text = "Personel";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 39);
            label1.Name = "label1";
            label1.Size = new Size(37, 15);
            label1.TabIndex = 0;
            label1.Text = "Başlık";
            // 
            // btnYorumlar
            // 
            btnYorumlar.Location = new Point(464, 165);
            btnYorumlar.Name = "btnYorumlar";
            btnYorumlar.Size = new Size(75, 23);
            btnYorumlar.TabIndex = 3;
            btnYorumlar.Text = "Yorumlar";
            btnYorumlar.UseVisualStyleBackColor = true;
            btnYorumlar.Click += btnEkle_Click;
            // 
            // GorevListForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox1);
            Controls.Add(dgvGorevler);
            Name = "GorevListForm";
            Text = "Görev";
            Load += GorevListForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvGorevler).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvGorevler;
        private GroupBox groupBox1;
        private ComboBox cmbDurum;
        private ComboBox cmbPersonel;
        private TextBox txtAciklama;
        private TextBox txtBaslik;
        private Label label4;
        private Label label2;
        private Label label3;
        private Label label1;
        private Button btnSil;
        private Button btnGuncelle;
        private Button btnEkle;
        private Button btnYorumlar;
    }
}