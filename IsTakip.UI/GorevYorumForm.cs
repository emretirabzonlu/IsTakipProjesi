using System;
using System.Linq;
using System.Windows.Forms;
using IsTakip.Business;
using IsTakip.Entities;
using Microsoft.EntityFrameworkCore;

namespace IsTakip.UI
{
    public partial class GorevYorumForm : Form
    {
        private int _gorevId;

        public GorevYorumForm(int gorevId, string gorevBaslik)
        {
            InitializeComponent();
            _gorevId = gorevId;
            lblGorevBaslik.Text = gorevBaslik;
        }

        private void GorevYorumForm_Load(object sender, EventArgs e)
        {
            YorumlariListele();
        }

        private void YorumlariListele()
        {
            using (var context = new IsTakipContext())
            {
                var yorumlar = context.GorevYorumlar
                    .Include(y => y.Personel)
                    .Where(y => y.GorevId == _gorevId && !y.SilindiMi)
                    .OrderByDescending(y => y.OlusturmaTarihi)
                    .Select(y => new
                    {
                        y.Id,
                        Yazan = y.Personel.Ad + " " + y.Personel.Soyad,
                        y.Icerik,
                        Tarih = y.OlusturmaTarihi
                    }).ToList();

                dgvYorumlar.DataSource = yorumlar;
            }
        }

        private void btnYorumEkle_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtYorum.Text))
            {
                MessageBox.Show("Yorum boş bırakılamaz!");
                return;
            }

            using (var context = new IsTakipContext())
            {
                var yorum = new GorevYorum
                {
                    GorevId = _gorevId,
                    PersonelId = LoginForm.GirisYapanPersonel.Id,
                    Icerik = txtYorum.Text,
                    OlusturmaTarihi = DateTime.Now
                };
                context.GorevYorumlar.Add(yorum);
                context.SaveChanges();
            }

            YorumlariListele();
            txtYorum.Text = "";
            MessageBox.Show("Yorum eklendi!");
        }
    }
}