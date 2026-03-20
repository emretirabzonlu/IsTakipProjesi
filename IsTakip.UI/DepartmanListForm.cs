using System;
using System.Linq;
using System.Windows.Forms;
using IsTakip.Business;
using IsTakip.Entities;

namespace IsTakip.UI
{
    public partial class DepartmanListForm : Form
    {
        public DepartmanListForm()
        {
            InitializeComponent();
        }

        private void DepartmanListForm_Load(object sender, EventArgs e)
        {
            Listele();
        }

        private void Listele()
        {
            using (var context = new IsTakipContext())
            {
                var liste = context.Departmanlar
                    .Where(d => !d.SilindiMi)
                    .Select(d => new
                    {
                        d.Id,
                        d.Ad,
                        d.OlusturmaTarihi
                    }).ToList();

                dgvDepartmanlar.DataSource = liste;
            }
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtAd.Text))
            {
                MessageBox.Show("Departman adı boş bırakılamaz!");
                return;
            }

            using (var context = new IsTakipContext())
            {
                var departman = new Departman
                {
                    Ad = txtAd.Text,
                    OlusturmaTarihi = DateTime.Now
                };
                context.Departmanlar.Add(departman);
                context.SaveChanges();
            }

            Listele();
            txtAd.Text = "";
            MessageBox.Show("Departman eklendi!");
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (dgvDepartmanlar.CurrentRow == null) return;
            int id = Convert.ToInt32(dgvDepartmanlar.CurrentRow.Cells["Id"].Value);

            using (var context = new IsTakipContext())
            {
                var departman = context.Departmanlar.Find(id);
                if (departman != null)
                {
                    departman.Ad = txtAd.Text;
                    context.SaveChanges();
                }
            }

            Listele();
            txtAd.Text = "";
            MessageBox.Show("Departman güncellendi!");
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (dgvDepartmanlar.CurrentRow == null) return;

            var result = MessageBox.Show("Silmek istediğinize emin misiniz?", "Uyarı",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                int id = Convert.ToInt32(dgvDepartmanlar.CurrentRow.Cells["Id"].Value);
                using (var context = new IsTakipContext())
                {
                    var departman = context.Departmanlar.Find(id);
                    if (departman != null)
                    {
                        departman.SilindiMi = true;
                        context.SaveChanges();
                    }
                }
                Listele();
                txtAd.Text = "";
                MessageBox.Show("Departman silindi!");
            }
        }

        private void dgvDepartmanlar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            txtAd.Text = dgvDepartmanlar.Rows[e.RowIndex].Cells["Ad"].Value.ToString();
        }
    }
}