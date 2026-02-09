namespace IsTakip.UI
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            yÖNETİMToolStripMenuItem = new ToolStripMenuItem();
            personelİşlemleriToolStripMenuItem = new ToolStripMenuItem();
            görevAtamaToolStripMenuItem = new ToolStripMenuItem();
            departmanlarToolStripMenuItem = new ToolStripMenuItem();
            yönetimToolStripMenuItem = new ToolStripMenuItem();
            Personel = new TabControl();
            tabPage1 = new TabPage();
            groupBox2 = new GroupBox();
            cmbDepartman = new ComboBox();
            txtTelefon = new TextBox();
            txtEmail = new TextBox();
            txtSoyad = new TextBox();
            txtAd = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            gridPersonel = new DataGridView();
            btnEkle = new Button();
            tabPage2 = new TabPage();
            groupBox1 = new GroupBox();
            gridGorevler = new DataGridView();
            cmbGorevDurum = new ComboBox();
            label8 = new Label();
            txtGorevAciklama = new TextBox();
            label7 = new Label();
            txtGorevBaslik = new TextBox();
            bslk1 = new Label();
            cmbGorevPersonel = new ComboBox();
            label6 = new Label();
            btnGorevEkle = new Button();
            menuStrip1.SuspendLayout();
            Personel.SuspendLayout();
            tabPage1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gridPersonel).BeginInit();
            tabPage2.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gridGorevler).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { yÖNETİMToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1126, 24);
            menuStrip1.TabIndex = 13;
            menuStrip1.Text = "menuStrip1";
            menuStrip1.ItemClicked += menuStrip1_ItemClicked;
            // 
            // yÖNETİMToolStripMenuItem
            // 
            yÖNETİMToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { personelİşlemleriToolStripMenuItem, görevAtamaToolStripMenuItem, departmanlarToolStripMenuItem, yönetimToolStripMenuItem });
            yÖNETİMToolStripMenuItem.Name = "yÖNETİMToolStripMenuItem";
            yÖNETİMToolStripMenuItem.Size = new Size(71, 20);
            yÖNETİMToolStripMenuItem.Text = "YÖNETİM";
            yÖNETİMToolStripMenuItem.Click += yÖNETİMToolStripMenuItem_Click;
            // 
            // personelİşlemleriToolStripMenuItem
            // 
            personelİşlemleriToolStripMenuItem.Name = "personelİşlemleriToolStripMenuItem";
            personelİşlemleriToolStripMenuItem.Size = new Size(166, 22);
            personelİşlemleriToolStripMenuItem.Text = "Personel İşlemleri";
            personelİşlemleriToolStripMenuItem.Click += personelİşlemleriToolStripMenuItem_Click;
            // 
            // görevAtamaToolStripMenuItem
            // 
            görevAtamaToolStripMenuItem.Name = "görevAtamaToolStripMenuItem";
            görevAtamaToolStripMenuItem.Size = new Size(166, 22);
            görevAtamaToolStripMenuItem.Text = "Görev Atama";
            görevAtamaToolStripMenuItem.Click += görevAtamaToolStripMenuItem_Click;
            // 
            // departmanlarToolStripMenuItem
            // 
            departmanlarToolStripMenuItem.Name = "departmanlarToolStripMenuItem";
            departmanlarToolStripMenuItem.Size = new Size(166, 22);
            departmanlarToolStripMenuItem.Text = "Departmanlar";
            // 
            // yönetimToolStripMenuItem
            // 
            yönetimToolStripMenuItem.Name = "yönetimToolStripMenuItem";
            yönetimToolStripMenuItem.Size = new Size(166, 22);
            yönetimToolStripMenuItem.Text = "Yönetim";
            // 
            // Personel
            // 
            Personel.AccessibleName = "";
            Personel.Controls.Add(tabPage1);
            Personel.Controls.Add(tabPage2);
            Personel.Dock = DockStyle.Fill;
            Personel.Location = new Point(0, 24);
            Personel.Name = "Personel";
            Personel.SelectedIndex = 0;
            Personel.Size = new Size(1126, 593);
            Personel.TabIndex = 14;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(groupBox2);
            tabPage1.Controls.Add(btnEkle);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1118, 565);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Personel";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(cmbDepartman);
            groupBox2.Controls.Add(txtTelefon);
            groupBox2.Controls.Add(txtEmail);
            groupBox2.Controls.Add(txtSoyad);
            groupBox2.Controls.Add(txtAd);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(gridPersonel);
            groupBox2.Location = new Point(25, 26);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1051, 439);
            groupBox2.TabIndex = 25;
            groupBox2.TabStop = false;
            groupBox2.Text = "Yeni Personel Bilgileri";
            // 
            // cmbDepartman
            // 
            cmbDepartman.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbDepartman.Font = new Font("Segoe UI", 9.75F);
            cmbDepartman.FormattingEnabled = true;
            cmbDepartman.Location = new Point(19, 383);
            cmbDepartman.Name = "cmbDepartman";
            cmbDepartman.Size = new Size(369, 25);
            cmbDepartman.TabIndex = 35;
            // 
            // txtTelefon
            // 
            txtTelefon.Font = new Font("Segoe UI", 9.75F);
            txtTelefon.Location = new Point(18, 301);
            txtTelefon.Name = "txtTelefon";
            txtTelefon.Size = new Size(368, 25);
            txtTelefon.TabIndex = 34;
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Segoe UI", 9.75F);
            txtEmail.Location = new Point(17, 212);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(368, 25);
            txtEmail.TabIndex = 33;
            // 
            // txtSoyad
            // 
            txtSoyad.Font = new Font("Segoe UI", 9.75F);
            txtSoyad.Location = new Point(17, 135);
            txtSoyad.Name = "txtSoyad";
            txtSoyad.Size = new Size(368, 25);
            txtSoyad.TabIndex = 32;
            // 
            // txtAd
            // 
            txtAd.Font = new Font("Segoe UI", 9.75F);
            txtAd.Location = new Point(17, 53);
            txtAd.Name = "txtAd";
            txtAd.Size = new Size(368, 25);
            txtAd.TabIndex = 31;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label5.Location = new Point(18, 363);
            label5.Name = "label5";
            label5.Size = new Size(77, 17);
            label5.TabIndex = 30;
            label5.Text = "Departman";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label4.Location = new Point(17, 281);
            label4.Name = "label4";
            label4.Size = new Size(54, 17);
            label4.TabIndex = 29;
            label4.Text = "Telefon";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label3.Location = new Point(17, 192);
            label3.Name = "label3";
            label3.Size = new Size(47, 17);
            label3.TabIndex = 28;
            label3.Text = "E-Mail";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label2.Location = new Point(17, 115);
            label2.Name = "label2";
            label2.Size = new Size(45, 17);
            label2.TabIndex = 27;
            label2.Text = "Soyad";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label1.Location = new Point(17, 33);
            label1.Name = "label1";
            label1.Size = new Size(25, 17);
            label1.TabIndex = 26;
            label1.Text = "Ad";
            // 
            // gridPersonel
            // 
            gridPersonel.BackgroundColor = Color.White;
            gridPersonel.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridPersonel.Location = new Point(413, 35);
            gridPersonel.Name = "gridPersonel";
            gridPersonel.Size = new Size(612, 374);
            gridPersonel.TabIndex = 25;
            // 
            // btnEkle
            // 
            btnEkle.BackColor = Color.SteelBlue;
            btnEkle.Cursor = Cursors.Hand;
            btnEkle.FlatStyle = FlatStyle.Flat;
            btnEkle.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnEkle.ForeColor = Color.White;
            btnEkle.Location = new Point(973, 483);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(103, 34);
            btnEkle.TabIndex = 23;
            btnEkle.Text = "Kaydet";
            btnEkle.UseVisualStyleBackColor = false;
            btnEkle.Click += btnEkle_Click;
            // 
            // tabPage2
            // 
            tabPage2.BackColor = Color.WhiteSmoke;
            tabPage2.Controls.Add(groupBox1);
            tabPage2.Controls.Add(btnGorevEkle);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1118, 565);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Görev Atama";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(gridGorevler);
            groupBox1.Controls.Add(cmbGorevDurum);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(txtGorevAciklama);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(txtGorevBaslik);
            groupBox1.Controls.Add(bslk1);
            groupBox1.Controls.Add(cmbGorevPersonel);
            groupBox1.Controls.Add(label6);
            groupBox1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
            groupBox1.Location = new Point(26, 23);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1060, 434);
            groupBox1.TabIndex = 9;
            groupBox1.TabStop = false;
            groupBox1.Text = "Yeni Görev Bilgileri";
            // 
            // gridGorevler
            // 
            gridGorevler.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridGorevler.Location = new Point(424, 40);
            gridGorevler.Name = "gridGorevler";
            gridGorevler.Size = new Size(615, 365);
            gridGorevler.TabIndex = 16;
            // 
            // cmbGorevDurum
            // 
            cmbGorevDurum.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbGorevDurum.Font = new Font("Segoe UI", 9.75F);
            cmbGorevDurum.FormattingEnabled = true;
            cmbGorevDurum.Location = new Point(16, 381);
            cmbGorevDurum.Name = "cmbGorevDurum";
            cmbGorevDurum.Size = new Size(372, 25);
            cmbGorevDurum.TabIndex = 15;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label8.Location = new Point(16, 361);
            label8.Name = "label8";
            label8.Size = new Size(51, 17);
            label8.TabIndex = 14;
            label8.Text = "Durum";
            // 
            // txtGorevAciklama
            // 
            txtGorevAciklama.Font = new Font("Segoe UI", 9.75F);
            txtGorevAciklama.Location = new Point(16, 223);
            txtGorevAciklama.Multiline = true;
            txtGorevAciklama.Name = "txtGorevAciklama";
            txtGorevAciklama.Size = new Size(372, 92);
            txtGorevAciklama.TabIndex = 13;
            txtGorevAciklama.TextChanged += txtGorevAciklama_TextChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label7.Location = new Point(16, 203);
            label7.Name = "label7";
            label7.Size = new Size(64, 17);
            label7.TabIndex = 12;
            label7.Text = "Açıklama";
            // 
            // txtGorevBaslik
            // 
            txtGorevBaslik.Font = new Font("Segoe UI", 9.75F);
            txtGorevBaslik.Location = new Point(16, 142);
            txtGorevBaslik.Multiline = true;
            txtGorevBaslik.Name = "txtGorevBaslik";
            txtGorevBaslik.Size = new Size(372, 23);
            txtGorevBaslik.TabIndex = 11;
            // 
            // bslk1
            // 
            bslk1.AutoSize = true;
            bslk1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            bslk1.Location = new Point(16, 122);
            bslk1.Name = "bslk1";
            bslk1.Size = new Size(44, 17);
            bslk1.TabIndex = 10;
            bslk1.Text = "Başlık";
            // 
            // cmbGorevPersonel
            // 
            cmbGorevPersonel.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbGorevPersonel.Font = new Font("Segoe UI", 9.75F);
            cmbGorevPersonel.FormattingEnabled = true;
            cmbGorevPersonel.Location = new Point(16, 60);
            cmbGorevPersonel.Name = "cmbGorevPersonel";
            cmbGorevPersonel.Size = new Size(372, 25);
            cmbGorevPersonel.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label6.Location = new Point(16, 40);
            label6.Name = "label6";
            label6.Size = new Size(85, 17);
            label6.TabIndex = 8;
            label6.Text = "Personel Seç";
            // 
            // btnGorevEkle
            // 
            btnGorevEkle.BackColor = Color.SteelBlue;
            btnGorevEkle.Cursor = Cursors.Hand;
            btnGorevEkle.FlatStyle = FlatStyle.Flat;
            btnGorevEkle.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnGorevEkle.ForeColor = Color.White;
            btnGorevEkle.Location = new Point(966, 479);
            btnGorevEkle.Name = "btnGorevEkle";
            btnGorevEkle.Size = new Size(120, 34);
            btnGorevEkle.TabIndex = 8;
            btnGorevEkle.Text = "GÖREVİ ATA";
            btnGorevEkle.UseVisualStyleBackColor = false;
            btnGorevEkle.Click += btnGorevEkle_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1126, 617);
            Controls.Add(Personel);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "İş Takip Otomasyonu";
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            Personel.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)gridPersonel).EndInit();
            tabPage2.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)gridGorevler).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnEkle;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem yÖNETİMToolStripMenuItem;
        private ToolStripMenuItem personelİşlemleriToolStripMenuItem;
        private ToolStripMenuItem görevAtamaToolStripMenuItem;
        private ToolStripMenuItem departmanlarToolStripMenuItem;
        private TabControl Personel;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private ToolStripMenuItem yönetimToolStripMenuItem;
        private Button btnGorevEkle;
        private GroupBox groupBox1;
        private ComboBox cmbGorevDurum;
        private Label label8;
        private TextBox txtGorevAciklama;
        private Label label7;
        private TextBox txtGorevBaslik;
        private Label bslk1;
        private ComboBox cmbGorevPersonel;
        private Label label6;
        private GroupBox groupBox2;
        private ComboBox cmbDepartman;
        private TextBox txtTelefon;
        private TextBox txtEmail;
        private TextBox txtSoyad;
        private TextBox txtAd;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private DataGridView gridPersonel;
        private DataGridView gridGorevler;
    }
}
