using System;
using System.Windows.Forms;
using IsTakip.Business;

namespace IsTakip.UI
{
    public partial class AnaForm : Form
    {
        public AnaForm()
        {
            InitializeComponent();
        }

        private void AnaForm_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(45, 45, 48);
            var personel = LoginForm.GirisYapanPersonel;
            if (personel != null)
            {
                lblKullanici.Text = "Kullanıcı: " + personel.Ad + " " + personel.Soyad;
                lblTarih.Text = "Tarih: " + DateTime.Now.ToShortDateString();

                using (var context = new IsTakipContext())
                {
                    var rol = context.Roller.Find(personel.RolId);
                    lblRol.Text = "Rol: " + (rol != null ? rol.Ad : "-");
                }
            }

            this.BackColor = Color.FromArgb(45, 45, 48);
            // Dashboard'ı otomatik aç
            ChildFormAc(new DashboardForm());
        }

        private void ChildFormAc(Form childForm)
        {
            // Aynı form zaten açıksa tekrar açma
            foreach (Form form in this.MdiChildren)
            {
                if (form.GetType() == childForm.GetType())
                {
                    form.Activate();
                    return;
                }
            }
            childForm.MdiParent = this;
            childForm.Show();
        }

        private void görevlerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChildFormAc(new GorevListForm());
        }

        private void personelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChildFormAc(new PersonelListForm());
        }

        private void müşterilerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChildFormAc(new MusteriListForm());
        }

        private void departmanlarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChildFormAc(new DepartmanListForm());
        }

        private void projelerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChildFormAc(new ProjeListForm());
        }

        private void AnaForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void AnaForm_Load_1(object sender, EventArgs e)
        {

        }

        private void dashboardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChildFormAc(new DashboardForm());
        }

    }
}