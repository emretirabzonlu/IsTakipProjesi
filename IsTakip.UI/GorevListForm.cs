using System;
using System.Linq;
using System.Windows.Forms;
using IsTakip.Business;
using IsTakip.Entities;
using Microsoft.EntityFrameworkCore;

namespace IsTakip.UI
{
    public partial class GorevListForm : Form
    {
        public GorevListForm()
        {
            InitializeComponent();
        }

        private void GorevListForm_Load(object sender, EventArgs e)
        {
            GorevleriListele();
            ComboBoxlariDoldur();
            // ===== GÜZELLEŞTİRME =====
            this.BackColor = Color.FromArgb(240, 240, 245);
            this.Font = new Font("Segoe UI", 9);

            // DataGridView
            dgvGorevler.BackgroundColor = Color.White;
            dgvGorevler.BorderStyle = BorderStyle.None;
            dgvGorevler.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dgvGorevler.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvGorevler.DefaultCellStyle.SelectionBackColor = Color.FromArgb(0, 120, 215);
            dgvGorevler.DefaultCellStyle.SelectionForeColor = Color.White;
            dgvGorevler.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(0, 120, 215);
            dgvGorevler.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvGorevler.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 9, FontStyle.Bold);
            dgvGorevler.EnableHeadersVisualStyles = false;
            dgvGorevler.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvGorevler.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvGorevler.ReadOnly = true;


            // Butonlar
            btnEkle.BackColor = Color.FromArgb(0, 120, 215);
            btnEkle.ForeColor = Color.White;
            btnEkle.FlatStyle = FlatStyle.Flat;
            btnEkle.FlatAppearance.BorderSize = 0;

            btnGuncelle.BackColor = Color.FromArgb(255, 165, 0);
            btnGuncelle.ForeColor = Color.White;
            btnGuncelle.FlatStyle = FlatStyle.Flat;
            btnGuncelle.FlatAppearance.BorderSize = 0;

            btnSil.BackColor = Color.FromArgb(220, 53, 69);
            btnSil.ForeColor = Color.White;
            btnSil.FlatStyle = FlatStyle.Flat;
            btnSil.FlatAppearance.BorderSize = 0;
            btnYorumlar.BackColor = Color.FromArgb(111, 66, 193);
            btnYorumlar.ForeColor = Color.White;
            btnYorumlar.FlatStyle = FlatStyle.Flat;
            btnYorumlar.FlatAppearance.BorderSize = 0;
        }

        private void GorevleriListele()
        {
            using (var context = new IsTakipContext())
            {
                var gorevler = context.Gorevler
                    .Include(g => g.Personel)
                    .Include(g => g.GorevDurum)
                    .Where(g => !g.SilindiMi)
                    .Select(g => new
                    {
                        g.Id,
                        g.Baslik,
                        g.Aciklama,
                        Personel = g.Personel.Ad + " " + g.Personel.Soyad,
                        Durum = g.GorevDurum.Ad,
                        g.OlusturmaTarihi
                    }).ToList();

                dgvGorevler.DataSource = gorevler;
            }
        }

        private void ComboBoxlariDoldur()
        {
            using (var context = new IsTakipContext())
            {
                // Personel ComboBox
                var personeller = context.Personeller
                    .Where(p => !p.SilindiMi)
                    .Select(p => new { p.Id, AdSoyad = p.Ad + " " + p.Soyad })
                    .ToList();
                cmbPersonel.DataSource = personeller;
                cmbPersonel.DisplayMember = "AdSoyad";
                cmbPersonel.ValueMember = "Id";

                // Durum ComboBox
                var durumlar = context.GorevDurumlar
                    .Where(d => !d.SilindiMi)
                    .ToList();
                cmbDurum.DataSource = durumlar;
                cmbDurum.DisplayMember = "Ad";
                cmbDurum.ValueMember = "Id";
            }
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBaslik.Text))
            {
                MessageBox.Show("Başlık boş bırakılamaz!");
                return;
            }

            using (var context = new IsTakipContext())
            {
                var gorev = new Gorev
                {
                    Baslik = txtBaslik.Text,
                    Aciklama = txtAciklama.Text,
                    PersonelId = Convert.ToInt32(cmbPersonel.SelectedValue),
                    GorevDurumId = Convert.ToInt32(cmbDurum.SelectedValue),
                    OlusturmaTarihi = DateTime.Now
                };
                context.Gorevler.Add(gorev);
                context.SaveChanges();
            }

            GorevleriListele();
            Temizle();
            MessageBox.Show("Görev eklendi!");
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (dgvGorevler.CurrentRow == null) return;

            int id = Convert.ToInt32(dgvGorevler.CurrentRow.Cells["Id"].Value);

            using (var context = new IsTakipContext())
            {
                var gorev = context.Gorevler.Find(id);
                if (gorev != null)
                {
                    gorev.Baslik = txtBaslik.Text;
                    gorev.Aciklama = txtAciklama.Text;
                    gorev.PersonelId = Convert.ToInt32(cmbPersonel.SelectedValue);
                    gorev.GorevDurumId = Convert.ToInt32(cmbDurum.SelectedValue);
                    context.SaveChanges();
                }
            }

            GorevleriListele();
            Temizle();
            MessageBox.Show("Görev güncellendi!");
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (dgvGorevler.CurrentRow == null) return;

            var result = MessageBox.Show("Silmek istediğinize emin misiniz?", "Uyarı",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                int id = Convert.ToInt32(dgvGorevler.CurrentRow.Cells["Id"].Value);

                using (var context = new IsTakipContext())
                {
                    var gorev = context.Gorevler.Find(id);
                    if (gorev != null)
                    {
                        gorev.SilindiMi = true; // Soft delete
                        context.SaveChanges();
                    }
                }

                GorevleriListele();
                Temizle();
                MessageBox.Show("Görev silindi!");
            }
        }

        private void btnYorumlar_Click(object sender, EventArgs e)
        {
            if (dgvGorevler.CurrentRow == null)
            {
                MessageBox.Show("Lütfen bir görev seçin!");
                return;
            }

            int gorevId = Convert.ToInt32(dgvGorevler.CurrentRow.Cells["Id"].Value);
            string baslik = dgvGorevler.CurrentRow.Cells["Baslik"].Value.ToString();

            GorevYorumForm yorumForm = new GorevYorumForm(gorevId, baslik);
            yorumForm.ShowDialog();
        }

        private void dgvGorevler_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var row = dgvGorevler.Rows[e.RowIndex];
            txtBaslik.Text = row.Cells["Baslik"].Value.ToString();
            txtAciklama.Text = row.Cells["Aciklama"].Value?.ToString();

            // Personel ve Durum combobox'larını seç
            // İsme göre bulalım
            for (int i = 0; i < cmbPersonel.Items.Count; i++)
            {
                dynamic item = cmbPersonel.Items[i];
                if (item.AdSoyad == row.Cells["Personel"].Value.ToString())
                {
                    cmbPersonel.SelectedIndex = i;
                    break;
                }
            }

            for (int i = 0; i < cmbDurum.Items.Count; i++)
            {
                dynamic item = cmbDurum.Items[i];
                if (item.Ad == row.Cells["Durum"].Value.ToString())
                {
                    cmbDurum.SelectedIndex = i;
                    break;
                }
            }
        }

        private void Temizle()
        {
            txtBaslik.Text = "";
            txtAciklama.Text = "";
            cmbPersonel.SelectedIndex = 0;
            cmbDurum.SelectedIndex = 0;
        }
    }
}