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

            // ===== GÜZELLEŞTİRME =====
            this.BackColor = Color.FromArgb(240, 240, 245);
            this.Font = new Font("Segoe UI", 9);

            // DataGridView
            dgvMusteriler.BackgroundColor = Color.White;
            dgvMusteriler.BorderStyle = BorderStyle.None;
            dgvMusteriler.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dgvMusteriler.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvMusteriler.DefaultCellStyle.SelectionBackColor = Color.FromArgb(0, 120, 215);
            dgvMusteriler.DefaultCellStyle.SelectionForeColor = Color.White;
            dgvMusteriler.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(0, 120, 215);
            dgvMusteriler.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvMusteriler.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 9, FontStyle.Bold);
            dgvMusteriler.EnableHeadersVisualStyles = false;
            dgvMusteriler.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvMusteriler.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvMusteriler.ReadOnly = true;

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