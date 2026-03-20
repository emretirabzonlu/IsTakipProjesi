namespace IsTakip.UI
{
    partial class DashboardForm
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
            pnlGorev = new Panel();
            lblGorevText = new Label();
            lblGorevSayisi = new Label();
            lblPersonelText = new Label();
            lblPersonelSayisi = new Label();
            pnlPersonel = new Panel();
            lblMusteriText = new Label();
            lblMusteriSayisi = new Label();
            pnlMusteri = new Panel();
            lblProjeText = new Label();
            lblProjeSayisi = new Label();
            pnlProje = new Panel();
            dgvSonGorevler = new DataGridView();
            pnlGorev.SuspendLayout();
            pnlPersonel.SuspendLayout();
            pnlMusteri.SuspendLayout();
            pnlProje.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSonGorevler).BeginInit();
            SuspendLayout();
            // 
            // pnlGorev
            // 
            pnlGorev.Controls.Add(lblGorevText);
            pnlGorev.Controls.Add(lblGorevSayisi);
            pnlGorev.Location = new Point(0, 0);
            pnlGorev.Name = "pnlGorev";
            pnlGorev.Size = new Size(200, 120);
            pnlGorev.TabIndex = 0;
            // 
            // lblGorevText
            // 
            lblGorevText.AutoSize = true;
            lblGorevText.Font = new Font("Segoe UI", 12F);
            lblGorevText.Location = new Point(46, 70);
            lblGorevText.Name = "lblGorevText";
            lblGorevText.Size = new Size(106, 21);
            lblGorevText.TabIndex = 1;
            lblGorevText.Text = "Toplam Görev";
            // 
            // lblGorevSayisi
            // 
            lblGorevSayisi.AutoSize = true;
            lblGorevSayisi.Font = new Font("Segoe UI", 16F);
            lblGorevSayisi.Location = new Point(60, 28);
            lblGorevSayisi.Name = "lblGorevSayisi";
            lblGorevSayisi.Size = new Size(71, 30);
            lblGorevSayisi.TabIndex = 0;
            lblGorevSayisi.Text = "label1";
            // 
            // lblPersonelText
            // 
            lblPersonelText.AutoSize = true;
            lblPersonelText.Font = new Font("Segoe UI", 12F);
            lblPersonelText.Location = new Point(36, 70);
            lblPersonelText.Name = "lblPersonelText";
            lblPersonelText.Size = new Size(123, 21);
            lblPersonelText.TabIndex = 1;
            lblPersonelText.Text = "Toplam Personel";
            // 
            // lblPersonelSayisi
            // 
            lblPersonelSayisi.AutoSize = true;
            lblPersonelSayisi.Font = new Font("Segoe UI", 16F);
            lblPersonelSayisi.Location = new Point(60, 28);
            lblPersonelSayisi.Name = "lblPersonelSayisi";
            lblPersonelSayisi.Size = new Size(71, 30);
            lblPersonelSayisi.TabIndex = 0;
            lblPersonelSayisi.Text = "label4";
            // 
            // pnlPersonel
            // 
            pnlPersonel.Controls.Add(lblPersonelText);
            pnlPersonel.Controls.Add(lblPersonelSayisi);
            pnlPersonel.Location = new Point(206, 0);
            pnlPersonel.Name = "pnlPersonel";
            pnlPersonel.Size = new Size(200, 120);
            pnlPersonel.TabIndex = 1;
            // 
            // lblMusteriText
            // 
            lblMusteriText.AutoSize = true;
            lblMusteriText.Font = new Font("Segoe UI", 12F);
            lblMusteriText.Location = new Point(37, 70);
            lblMusteriText.Name = "lblMusteriText";
            lblMusteriText.Size = new Size(117, 21);
            lblMusteriText.TabIndex = 1;
            lblMusteriText.Text = "Toplam Müşteri";
            // 
            // lblMusteriSayisi
            // 
            lblMusteriSayisi.AutoSize = true;
            lblMusteriSayisi.Font = new Font("Segoe UI", 16F);
            lblMusteriSayisi.Location = new Point(60, 28);
            lblMusteriSayisi.Name = "lblMusteriSayisi";
            lblMusteriSayisi.Size = new Size(71, 30);
            lblMusteriSayisi.TabIndex = 0;
            lblMusteriSayisi.Text = "label6";
            // 
            // pnlMusteri
            // 
            pnlMusteri.Controls.Add(lblMusteriText);
            pnlMusteri.Controls.Add(lblMusteriSayisi);
            pnlMusteri.Location = new Point(412, 0);
            pnlMusteri.Name = "pnlMusteri";
            pnlMusteri.Size = new Size(200, 120);
            pnlMusteri.TabIndex = 2;
            // 
            // lblProjeText
            // 
            lblProjeText.AutoSize = true;
            lblProjeText.Font = new Font("Segoe UI", 12F);
            lblProjeText.Location = new Point(47, 70);
            lblProjeText.Name = "lblProjeText";
            lblProjeText.Size = new Size(100, 21);
            lblProjeText.TabIndex = 1;
            lblProjeText.Text = "Toplam Proje";
            lblProjeText.Click += lblProjeText_Click;
            // 
            // lblProjeSayisi
            // 
            lblProjeSayisi.AutoSize = true;
            lblProjeSayisi.Font = new Font("Segoe UI", 16F);
            lblProjeSayisi.Location = new Point(60, 28);
            lblProjeSayisi.Name = "lblProjeSayisi";
            lblProjeSayisi.Size = new Size(71, 30);
            lblProjeSayisi.TabIndex = 0;
            lblProjeSayisi.Text = "label8";
            // 
            // pnlProje
            // 
            pnlProje.Controls.Add(lblProjeText);
            pnlProje.Controls.Add(lblProjeSayisi);
            pnlProje.Location = new Point(618, 0);
            pnlProje.Name = "pnlProje";
            pnlProje.Size = new Size(200, 120);
            pnlProje.TabIndex = 3;
            // 
            // dgvSonGorevler
            // 
            dgvSonGorevler.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSonGorevler.Dock = DockStyle.Bottom;
            dgvSonGorevler.Location = new Point(0, 126);
            dgvSonGorevler.Name = "dgvSonGorevler";
            dgvSonGorevler.Size = new Size(820, 324);
            dgvSonGorevler.TabIndex = 4;
            // 
            // DashboardForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(820, 450);
            Controls.Add(dgvSonGorevler);
            Controls.Add(pnlProje);
            Controls.Add(pnlMusteri);
            Controls.Add(pnlPersonel);
            Controls.Add(pnlGorev);
            Name = "DashboardForm";
            Text = "DashboardForm";
            Load += DashboardForm_Load;
            pnlGorev.ResumeLayout(false);
            pnlGorev.PerformLayout();
            pnlPersonel.ResumeLayout(false);
            pnlPersonel.PerformLayout();
            pnlMusteri.ResumeLayout(false);
            pnlMusteri.PerformLayout();
            pnlProje.ResumeLayout(false);
            pnlProje.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSonGorevler).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlGorev;
        private Label lblGorevText;
        private Label lblGorevSayisi;
        private Label lblPersonelText;
        private Label lblPersonelSayisi;
        private Panel pnlPersonel;
        private Label lblMusteriText;
        private Label lblMusteriSayisi;
        private Panel pnlMusteri;
        private Label lblProjeText;
        private Label lblProjeSayisi;
        private Panel pnlProje;
        private DataGridView dgvSonGorevler;
    }
}