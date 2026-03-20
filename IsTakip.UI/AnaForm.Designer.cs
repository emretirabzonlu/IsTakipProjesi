namespace IsTakip.UI
{
    partial class AnaForm
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
            menuStrip1 = new MenuStrip();
            görevlerToolStripMenuItem = new ToolStripMenuItem();
            personelToolStripMenuItem = new ToolStripMenuItem();
            müşterilerToolStripMenuItem = new ToolStripMenuItem();
            departmanlarToolStripMenuItem = new ToolStripMenuItem();
            projelerToolStripMenuItem = new ToolStripMenuItem();
            statusStrip1 = new StatusStrip();
            lblKullanici = new ToolStripStatusLabel();
            lblTarih = new ToolStripStatusLabel();
            lblRol = new ToolStripStatusLabel();
            dashboardToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { görevlerToolStripMenuItem, personelToolStripMenuItem, müşterilerToolStripMenuItem, departmanlarToolStripMenuItem, projelerToolStripMenuItem, dashboardToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // görevlerToolStripMenuItem
            // 
            görevlerToolStripMenuItem.Name = "görevlerToolStripMenuItem";
            görevlerToolStripMenuItem.Size = new Size(63, 20);
            görevlerToolStripMenuItem.Text = "Görevler";
            görevlerToolStripMenuItem.Click += görevlerToolStripMenuItem_Click;
            // 
            // personelToolStripMenuItem
            // 
            personelToolStripMenuItem.Name = "personelToolStripMenuItem";
            personelToolStripMenuItem.Size = new Size(64, 20);
            personelToolStripMenuItem.Text = "Personel";
            personelToolStripMenuItem.Click += personelToolStripMenuItem_Click;
            // 
            // müşterilerToolStripMenuItem
            // 
            müşterilerToolStripMenuItem.Name = "müşterilerToolStripMenuItem";
            müşterilerToolStripMenuItem.Size = new Size(72, 20);
            müşterilerToolStripMenuItem.Text = "Müşteriler";
            müşterilerToolStripMenuItem.Click += müşterilerToolStripMenuItem_Click;
            // 
            // departmanlarToolStripMenuItem
            // 
            departmanlarToolStripMenuItem.Name = "departmanlarToolStripMenuItem";
            departmanlarToolStripMenuItem.Size = new Size(91, 20);
            departmanlarToolStripMenuItem.Text = "Departmanlar";
            departmanlarToolStripMenuItem.Click += departmanlarToolStripMenuItem_Click;
            // 
            // projelerToolStripMenuItem
            // 
            projelerToolStripMenuItem.Name = "projelerToolStripMenuItem";
            projelerToolStripMenuItem.Size = new Size(59, 20);
            projelerToolStripMenuItem.Text = "Projeler";
            projelerToolStripMenuItem.Click += projelerToolStripMenuItem_Click;
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { lblKullanici, lblTarih, lblRol });
            statusStrip1.Location = new Point(0, 428);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(800, 22);
            statusStrip1.TabIndex = 2;
            statusStrip1.Text = "statusStrip1";
            // 
            // lblKullanici
            // 
            lblKullanici.Name = "lblKullanici";
            lblKullanici.Size = new Size(12, 17);
            lblKullanici.Text = "-";
            // 
            // lblTarih
            // 
            lblTarih.Name = "lblTarih";
            lblTarih.Size = new Size(12, 17);
            lblTarih.Text = "-";
            // 
            // lblRol
            // 
            lblRol.Name = "lblRol";
            lblRol.Size = new Size(12, 17);
            lblRol.Text = "-";
            // 
            // dashboardToolStripMenuItem
            // 
            dashboardToolStripMenuItem.Name = "dashboardToolStripMenuItem";
            dashboardToolStripMenuItem.Size = new Size(76, 20);
            dashboardToolStripMenuItem.Text = "Dashboard";
            dashboardToolStripMenuItem.Click += dashboardToolStripMenuItem_Click;
            // 
            // AnaForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(statusStrip1);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "AnaForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "İş Takip Otomasyonu";
            WindowState = FormWindowState.Maximized;
            Load += AnaForm_Load_1;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem görevlerToolStripMenuItem;
        private ToolStripMenuItem personelToolStripMenuItem;
        private ToolStripMenuItem müşterilerToolStripMenuItem;
        private ToolStripMenuItem departmanlarToolStripMenuItem;
        private ToolStripMenuItem projelerToolStripMenuItem;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel lblKullanici;
        private ToolStripStatusLabel lblTarih;
        private ToolStripStatusLabel lblRol;
        private ToolStripMenuItem dashboardToolStripMenuItem;
    }
}