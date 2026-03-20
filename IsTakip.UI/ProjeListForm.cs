using System;
using System.Linq;
using System.Windows.Forms;
using IsTakip.Business;
using IsTakip.Entities;
using Microsoft.EntityFrameworkCore;

namespace IsTakip.UI
{
    public partial class ProjeListForm : Form
    {
        public ProjeListForm()
        {
            InitializeComponent();
        }

        private void ProjeListForm_Load(object sender, EventArgs e)
        {
            Listele();
            ComboBoxlariDoldur();
        }

        private void Listele()
        {
            using (var context = new IsTakipContext())
            {
                var liste = context.Projeler
                    .Include(p => p.Musteri)
                    .Where(p => !p.SilindiMi)
                    .Select(p => new
                    {
                        p.Id,
                        p.ProjeAdi,
                        p.Aciklama,
                        Musteri = p.Musteri.Ad + " " + p.Musteri.Soyad,
                        p.Durum,
                        p.BaslangicTarihi,
                        p.BitisTarihi
                    }).ToList();

                dgvProjeler.DataSource = liste;
            }
        }

        private void ComboBoxlariDoldur()
        {
            using (var context = new IsTakipContext())
            {
                var musteriler = context.Musteriler
                    .Where(m => !m.SilindiMi)
                    .Select(m => new { m.Id, AdSoyad = m.Ad + " " + m.Soyad })
                    .ToList();

                cmbMusteri.DataSource = musteriler;
                cmbMusteri.DisplayMember = "AdSoyad";
                cmbMusteri.ValueMember = "Id";
            }

            // Durum ComboBox - elle doldur
            cmbDurum.Items.Clear();
            cmbDurum.Items.Add("Devam Ediyor");
            cmbDurum.Items.Add("Tamamlandı");
            cmbDurum.Items.Add("İptal");
            cmbDurum.SelectedIndex = 0;
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtProjeAdi.Text))
            {
                MessageBox.Show("Proje adı boş bırakılamaz!");
                return;
            }

            using (var context = new IsTakipContext())
            {
                var proje = new Proje
                {
                    ProjeAdi = txtProjeAdi.Text,
                    Aciklama = txtAciklama.Text,
                    MusteriId = Convert.ToInt32(cmbMusteri.SelectedValue),
                    Durum = cmbDurum.SelectedItem.ToString(),
                    BaslangicTarihi = dtpBaslangic.Value,
                    OlusturmaTarihi = DateTime.Now
                };
                context.Projeler.Add(proje);
                context.SaveChanges();
            }

            Listele();
            Temizle();
            MessageBox.Show("Proje eklendi!");
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (dgvProjeler.CurrentRow == null) return;
            int id = Convert.ToInt32(dgvProjeler.CurrentRow.Cells["Id"].Value);

            using (var context = new IsTakipContext())
            {
                var proje = context.Projeler.Find(id);
                if (proje != null)
                {
                    proje.ProjeAdi = txtProjeAdi.Text;
                    proje.Aciklama = txtAciklama.Text;
                    proje.MusteriId = Convert.ToInt32(cmbMusteri.SelectedValue);
                    proje.Durum = cmbDurum.SelectedItem.ToString();
                    proje.BaslangicTarihi = dtpBaslangic.Value;
                    context.SaveChanges();
                }
            }

            Listele();
            Temizle();
            MessageBox.Show("Proje güncellendi!");
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (dgvProjeler.CurrentRow == null) return;

            var result = MessageBox.Show("Silmek istediğinize emin misiniz?", "Uyarı",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                int id = Convert.ToInt32(dgvProjeler.CurrentRow.Cells["Id"].Value);
                using (var context = new IsTakipContext())
                {
                    var proje = context.Projeler.Find(id);
                    if (proje != null)
                    {
                        proje.SilindiMi = true;
                        context.SaveChanges();
                    }
                }
                Listele();
                Temizle();
                MessageBox.Show("Proje silindi!");
            }
        }

        private void dgvProjeler_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            var row = dgvProjeler.Rows[e.RowIndex];
            txtProjeAdi.Text = row.Cells["ProjeAdi"].Value.ToString();
            txtAciklama.Text = row.Cells["Aciklama"].Value?.ToString();
            cmbDurum.SelectedItem = row.Cells["Durum"].Value.ToString();
            dtpBaslangic.Value = Convert.ToDateTime(row.Cells["BaslangicTarihi"].Value);
        }

        private void Temizle()
        {
            txtProjeAdi.Text = "";
            txtAciklama.Text = "";
            cmbDurum.SelectedIndex = 0;
            dtpBaslangic.Value = DateTime.Now;
        }
    }
}