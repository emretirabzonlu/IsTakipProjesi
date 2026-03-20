namespace IsTakip.UI
{
    partial class DepartmanListForm
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
            dgvDepartmanlar = new DataGridView();
            groupBox1 = new GroupBox();
            btnEkle = new Button();
            btnGuncelle = new Button();
            btnSil = new Button();
            txtAd = new TextBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvDepartmanlar).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // dgvDepartmanlar
            // 
            dgvDepartmanlar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDepartmanlar.Dock = DockStyle.Top;
            dgvDepartmanlar.Location = new Point(0, 0);
            dgvDepartmanlar.Name = "dgvDepartmanlar";
            dgvDepartmanlar.Size = new Size(800, 274);
            dgvDepartmanlar.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnEkle);
            groupBox1.Controls.Add(btnGuncelle);
            groupBox1.Controls.Add(btnSil);
            groupBox1.Controls.Add(txtAd);
            groupBox1.Controls.Add(label1);
            groupBox1.Dock = DockStyle.Bottom;
            groupBox1.Location = new Point(0, 280);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(800, 170);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Departman İşlemleri";
            // 
            // btnEkle
            // 
            btnEkle.Location = new Point(551, 135);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(75, 23);
            btnEkle.TabIndex = 5;
            btnEkle.Text = "Ekle";
            btnEkle.UseVisualStyleBackColor = true;
            btnEkle.Click += btnEkle_Click;
            // 
            // btnGuncelle
            // 
            btnGuncelle.Location = new Point(632, 135);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Size = new Size(75, 23);
            btnGuncelle.TabIndex = 6;
            btnGuncelle.Text = "Güncelle";
            btnGuncelle.UseVisualStyleBackColor = true;
            btnGuncelle.Click += btnGuncelle_Click;
            // 
            // btnSil
            // 
            btnSil.Location = new Point(713, 135);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(75, 23);
            btnSil.TabIndex = 7;
            btnSil.Text = "Sil";
            btnSil.UseVisualStyleBackColor = true;
            btnSil.Click += btnSil_Click;
            // 
            // txtAd
            // 
            txtAd.Location = new Point(12, 56);
            txtAd.Name = "txtAd";
            txtAd.Size = new Size(303, 23);
            txtAd.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 38);
            label1.Name = "label1";
            label1.Size = new Size(84, 15);
            label1.TabIndex = 3;
            label1.Text = "Departman Ad";
            // 
            // DepartmanListForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox1);
            Controls.Add(dgvDepartmanlar);
            Name = "DepartmanListForm";
            Text = "Departman";
            Load += DepartmanListForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvDepartmanlar).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvDepartmanlar;
        private GroupBox groupBox1;
        private TextBox txtAd;
        private Label label1;
        private Button btnEkle;
        private Button btnGuncelle;
        private Button btnSil;
    }
}