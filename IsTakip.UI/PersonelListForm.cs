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