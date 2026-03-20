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