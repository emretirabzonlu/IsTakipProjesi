using System;
using System.Linq;
using System.Windows.Forms;
using IsTakip.Business;
using Microsoft.EntityFrameworkCore;

namespace IsTakip.UI
{
    public partial class DashboardForm : Form
    {
        public DashboardForm()
        {
            InitializeComponent();
        }

        private void DashboardForm_Load(object sender, EventArgs e)
        {

            using (var context = new IsTakipContext())
            {
                // Sayılar
                lblGorevSayisi.Text = context.Gorevler.Count(g => !g.SilindiMi).ToString();
                lblPersonelSayisi.Text = context.Personeller.Count(p => !p.SilindiMi).ToString();
                lblMusteriSayisi.Text = context.Musteriler.Count(m => !m.SilindiMi).ToString();
                lblProjeSayisi.Text = context.Projeler.Count(p => !p.SilindiMi).ToString();

                // Son 10 görev
                var sonGorevler = context.Gorevler
                    .Include(g => g.Personel)
                    .Include(g => g.GorevDurum)
                    .Where(g => !g.SilindiMi)
                    .OrderByDescending(g => g.OlusturmaTarihi)
                    .Take(10)
                    .Select(g => new
                    {
                        g.Baslik,
                        Personel = g.Personel.Ad + " " + g.Personel.Soyad,
                        Durum = g.GorevDurum.Ad,
                        Tarih = g.OlusturmaTarihi
                    }).ToList();

                dgvSonGorevler.DataSource = sonGorevler;
            }

            // Panel renkleri
            pnlGorev.BackColor = Color.FromArgb(0, 120, 215);
            pnlPersonel.BackColor = Color.FromArgb(40, 167, 69);
            pnlMusteri.BackColor = Color.FromArgb(255, 165, 0);
            pnlProje.BackColor = Color.FromArgb(111, 66, 193);

            lblGorevSayisi.ForeColor = Color.White;
            lblGorevSayisi.Font = new Font("Segoe UI", 28, FontStyle.Bold);
            lblPersonelSayisi.ForeColor = Color.White;
            lblPersonelSayisi.Font = new Font("Segoe UI", 28, FontStyle.Bold);
            lblMusteriSayisi.ForeColor = Color.White;
            lblMusteriSayisi.Font = new Font("Segoe UI", 28, FontStyle.Bold);
            lblProjeSayisi.ForeColor = Color.White;
            lblProjeSayisi.Font = new Font("Segoe UI", 28, FontStyle.Bold);

            lblGorevText.ForeColor = Color.White;
            lblPersonelText.ForeColor = Color.White;
            lblMusteriText.ForeColor = Color.White;
            lblProjeText.ForeColor = Color.White;

            // Panelleri üste düzgün yerleştir
            int panelWidth = (this.ClientSize.Width - 50) / 4;
            int panelHeight = 120;
            int gap = 10;

            pnlGorev.SetBounds(gap, gap, panelWidth, panelHeight);
            pnlPersonel.SetBounds(gap + panelWidth + gap, gap, panelWidth, panelHeight);
            pnlMusteri.SetBounds(gap + (panelWidth + gap) * 2, gap, panelWidth, panelHeight);
            pnlProje.SetBounds(gap + (panelWidth + gap) * 3, gap, panelWidth, panelHeight);

            // DataGridView pozisyonu
            dgvSonGorevler.SetBounds(gap, panelHeight + gap * 3, this.ClientSize.Width - gap * 2, this.ClientSize.Height - panelHeight - gap * 5);

            dgvSonGorevler.BackgroundColor = Color.White;
            dgvSonGorevler.BorderStyle = BorderStyle.None;
            dgvSonGorevler.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dgvSonGorevler.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvSonGorevler.DefaultCellStyle.SelectionBackColor = Color.FromArgb(0, 120, 215);
            dgvSonGorevler.DefaultCellStyle.SelectionForeColor = Color.White;
            dgvSonGorevler.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(0, 120, 215);
            dgvSonGorevler.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvSonGorevler.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 9, FontStyle.Bold);
            dgvSonGorevler.EnableHeadersVisualStyles = false;
            dgvSonGorevler.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvSonGorevler.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvSonGorevler.ReadOnly = true;
        }

        private void lblProjeText_Click(object sender, EventArgs e)
        {

        }
    }
}