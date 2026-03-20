using System;
using System.Linq;
using System.Windows.Forms;
using IsTakip.Business;
using IsTakip.Entities;
using Microsoft.EntityFrameworkCore;

namespace IsTakip.UI
{
    public partial class PersonelListForm : Form
    {
        public PersonelListForm()
        {
            InitializeComponent();
        }

        private void PersonelListForm_Load(object sender, EventArgs e)
        {
            Listele();
            ComboBoxlariDoldur();

            // ===== GÜZELLEŞTİRME =====
            this.BackColor = Color.FromArgb(240, 240, 245);
            this.Font = new Font("Segoe UI", 9);

            // DataGridView
            dgvPersoneller.BackgroundColor = Color.White;
            dgvPersoneller.BorderStyle = BorderStyle.None;
            dgvPersoneller.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dgvPersoneller.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvPersoneller.DefaultCellStyle.SelectionBackColor = Color.FromArgb(0, 120, 215);
            dgvPersoneller.DefaultCellStyle.SelectionForeColor = Color.White;
            dgvPersoneller.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(0, 120, 215);
            dgvPersoneller.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvPersoneller.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 9, FontStyle.Bold);
            dgvPersoneller.EnableHeadersVisualStyles = false;
            dgvPersoneller.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPersoneller.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPersoneller.ReadOnly = true;

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
                var liste = context.Personeller
                    .Include(p => p.Departman)
                    .Include(p => p.Rol)
                    .Where(p => !p.SilindiMi)
                    .Select(p => new
                    {
                        p.Id,
                        p.Ad,
                        p.Soyad,
                        p.Email,
                        p.Telefon,
                        Departman = p.Departman.Ad,
                        Rol = p.Rol.Ad
                    }).ToList();

                dgvPersoneller.DataSource = liste;
            }
        }

        private void ComboBoxlariDoldur()
        {
            using (var context = new IsTakipContext())
            {
                cmbDepartman.DataSource = context.Departmanlar.Where(d => !d.SilindiMi).ToList();
                cmbDepartman.DisplayMember = "Ad";
                cmbDepartman.ValueMember = "Id";

                cmbRol.DataSource = context.Roller.Where(r => !r.SilindiMi).ToList();
                cmbRol.DisplayMember = "Ad";
                cmbRol.ValueMember = "Id";
            }
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtAd.Text) || string.IsNullOrWhiteSpace(txtSoyad.Text))
            {
                MessageBox.Show("Ad ve Soyad boş bırakılamaz!");
                return;
            }

            using (var context = new IsTakipContext())
            {
                var personel = new Personel
                {
                    Ad = txtAd.Text,
                    Soyad = txtSoyad.Text,
                    Email = txtEmail.Text,
                    Telefon = txtTelefon.Text,
                    Sifre = txtSifre.Text,
                    DepartmanId = Convert.ToInt32(cmbDepartman.SelectedValue),
                    RolId = Convert.ToInt32(cmbRol.SelectedValue),
                    OlusturmaTarihi = DateTime.Now
                };
                context.Personeller.Add(personel);
                context.SaveChanges();
            }

            Listele();
            Temizle();
            MessageBox.Show("Personel eklendi!");
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (dgvPersoneller.CurrentRow == null) return;
            int id = Convert.ToInt32(dgvPersoneller.CurrentRow.Cells["Id"].Value);

            using (var context = new IsTakipContext())
            {
                var personel = context.Personeller.Find(id);
                if (personel != null)
                {
                    personel.Ad = txtAd.Text;
                    personel.Soyad = txtSoyad.Text;
                    personel.Email = txtEmail.Text;
                    personel.Telefon = txtTelefon.Text;
                    personel.Sifre = txtSifre.Text;
                    personel.DepartmanId = Convert.ToInt32(cmbDepartman.SelectedValue);
                    personel.RolId = Convert.ToInt32(cmbRol.SelectedValue);
                    context.SaveChanges();
                }
            }

            Listele();
            Temizle();
            MessageBox.Show("Personel güncellendi!");
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (dgvPersoneller.CurrentRow == null) return;

            var result = MessageBox.Show("Silmek istediğinize emin misiniz?", "Uyarı",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                int id = Convert.ToInt32(dgvPersoneller.CurrentRow.Cells["Id"].Value);
                using (var context = new IsTakipContext())
                {
                    var personel = context.Personeller.Find(id);
                    if (personel != null)
                    {
                        personel.SilindiMi = true;
                        context.SaveChanges();
                    }
                }
                Listele();
                Temizle();
                MessageBox.Show("Personel silindi!");
            }
        }

        private void dgvPersoneller_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            var row = dgvPersoneller.Rows[e.RowIndex];
            txtAd.Text = row.Cells["Ad"].Value.ToString();
            txtSoyad.Text = row.Cells["Soyad"].Value.ToString();
            txtEmail.Text = row.Cells["Email"].Value?.ToString();
            txtTelefon.Text = row.Cells["Telefon"].Value?.ToString();
        }

        private void Temizle()
        {
            txtAd.Text = "";
            txtSoyad.Text = "";
            txtEmail.Text = "";
            txtTelefon.Text = "";
            txtSifre.Text = "";
        }
    }
}