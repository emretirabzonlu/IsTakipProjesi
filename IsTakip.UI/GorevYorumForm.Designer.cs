namespace IsTakip.UI
{
    partial class GorevYorumForm
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
            dgvYorumlar = new DataGridView();
            label1 = new Label();
            lblGorevBaslik = new Label();
            txtYorum = new TextBox();
            btnYorumEkle = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvYorumlar).BeginInit();
            SuspendLayout();
            // 
            // dgvYorumlar
            // 
            dgvYorumlar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvYorumlar.Dock = DockStyle.Top;
            dgvYorumlar.Location = new Point(0, 0);
            dgvYorumlar.Name = "dgvYorumlar";
            dgvYorumlar.Size = new Size(800, 250);
            dgvYorumlar.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 278);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 1;
            label1.Text = "Görev";
            // 
            // lblGorevBaslik
            // 
            lblGorevBaslik.AutoSize = true;
            lblGorevBaslik.Location = new Point(12, 314);
            lblGorevBaslik.Name = "lblGorevBaslik";
            lblGorevBaslik.Size = new Size(0, 15);
            lblGorevBaslik.TabIndex = 1;
            // 
            // txtYorum
            // 
            txtYorum.Location = new Point(12, 344);
            txtYorum.Multiline = true;
            txtYorum.Name = "txtYorum";
            txtYorum.Size = new Size(147, 60);
            txtYorum.TabIndex = 2;
            // 
            // btnYorumEkle
            // 
            btnYorumEkle.Location = new Point(12, 415);
            btnYorumEkle.Name = "btnYorumEkle";
            btnYorumEkle.Size = new Size(75, 23);
            btnYorumEkle.TabIndex = 3;
            btnYorumEkle.Text = "Yorum Ekle";
            btnYorumEkle.UseVisualStyleBackColor = true;
            btnYorumEkle.Click += btnYorumEkle_Click;
            // 
            // GorevYorumForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnYorumEkle);
            Controls.Add(txtYorum);
            Controls.Add(lblGorevBaslik);
            Controls.Add(label1);
            Controls.Add(dgvYorumlar);
            Name = "GorevYorumForm";
            Text = "GorevYorumForm";
            Load += GorevYorumForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvYorumlar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvYorumlar;
        private Label label1;
        private Label lblGorevBaslik;
        private TextBox txtYorum;
        private Button btnYorumEkle;
    }
}