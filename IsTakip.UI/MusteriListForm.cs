using System;
using System.Linq;
using System.Windows.Forms;
using IsTakip.Business;
using IsTakip.Entities;

namespace IsTakip.UI
{
    public partial class MusteriListForm : Form
    {
        public MusteriListForm()
        {
            InitializeComponent();
        }

        private void MusteriListForm_Load(object sender, EventArgs e)
        {
            Listele();
        }

        private void Listele()
        {
            using (var context = new IsTakipContext())
            {
                var liste = context.Musteriler
                    .Where(m => !m.SilindiMi)
                    .Select(m => new
                    {
                        m.Id,
                        m.Ad,
                        m.Soyad,
                        m.Email,
                        m.Telefon,
                        m.Adres,
                        m.VergiNo
                    }).ToList();

                dgvMusteriler.DataSource = liste;
            }
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtAd.Text))
            {
                MessageBox.Show("Ad boş bırakılamaz!");
                return;
            }

            using (var context = new IsTakipContext())
            {
                var musteri = new Musteri
                {
                    Ad = txtAd.Text,
                    Soyad = txtSoyad.Text,
                    Email = txtEmail.Text,
                    Telefon = txtTelefon.Text,
                    Adres = txtAdres.Text,
                    VergiNo = txtVergiNo.Text,
                    OlusturmaTarihi = DateTime.Now
                };
                context.Musteriler.Add(musteri);
                context.SaveChanges();
            }

            Listele();
            Temizle();
            MessageBox.Show("Müşteri eklendi!");
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (dgvMusteriler.CurrentRow == null) return;
            int id = Convert.ToInt32(dgvMusteriler.CurrentRow.Cells["Id"].Value);

            using (var context = new IsTakipContext())
            {
                var musteri = context.Musteriler.Find(id);
                if (musteri != null)
                {
                    musteri.Ad = txtAd.Text;
                    musteri.Soyad = txtSoyad.Text;
                    musteri.Email = txtEmail.Text;
                    musteri.Telefon = txtTelefon.Text;
                    musteri.Adres = txtAdres.Text;
                    musteri.VergiNo = txtVergiNo.Text;
                    context.SaveChanges();
                }
            }

            Listele();
            Temizle();
            MessageBox.Show("Müşteri güncellendi!");
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (dgvMusteriler.CurrentRow == null) return;

            var result = MessageBox.Show("Silmek istediğinize emin misiniz?", "Uyarı",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                int id = Convert.ToInt32(dgvMusteriler.CurrentRow.Cells["Id"].Value);
                using (var context = new IsTakipContext())
                {
                    var musteri = context.Musteriler.Find(id);
                    if (musteri != null)
                    {
                        musteri.SilindiMi = true;
                        context.SaveChanges();
                    }
                }
                Listele();
                Temizle();
                MessageBox.Show("Müşteri silindi!");
            }
        }

        private void dgvMusteriler_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            var row = dgvMusteriler.Rows[e.RowIndex];
            txtAd.Text = row.Cells["Ad"].Value.ToString();
            txtSoyad.Text = row.Cells["Soyad"].Value.ToString();
            txtEmail.Text = row.Cells["Email"].Value?.ToString();
            txtTelefon.Text = row.Cells["Telefon"].Value?.ToString();
            txtAdres.Text = row.Cells["Adres"].Value?.ToString();
            txtVergiNo.Text = row.Cells["VergiNo"].Value?.ToString();
        }

        private void Temizle()
        {
            txtAd.Text = "";
            txtSoyad.Text = "";
            txtEmail.Text = "";
            txtTelefon.Text = "";
            txtAdres.Text = "";
            txtVergiNo.Text = "";
        }
    }
}