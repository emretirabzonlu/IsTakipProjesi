using System;
using System.Linq;
using System.Windows.Forms;
using IsTakip.Business;
using IsTakip.Entities;

namespace IsTakip.UI
{
    public partial class LoginForm : Form
    {
        public static Personel GirisYapanPersonel { get; set; }

        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text.Trim();
            string sifre = txtSifre.Text.Trim();

            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(sifre))
            {
                lblHata.Text = "Email ve şifre boş bırakılamaz!";
                return;
            }

            using (var context = new IsTakipContext())
            {
                var personel = context.Personeller
                    .FirstOrDefault(p => p.Email == email && p.Sifre == sifre && !p.SilindiMi);

                if (personel != null)
                {
                    GirisYapanPersonel = personel;
                    AnaForm anaForm = new AnaForm();
                    anaForm.Show();
                    this.Hide();
                }
                else
                {
                    lblHata.Text = "Email veya şifre hatalı!";
                }
            }
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
    }
}