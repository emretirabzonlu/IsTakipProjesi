using IsTakip.Entities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Windows.Forms;

namespace IsTakip.UI
{
    public partial class Form1 : Form
    {
        // API Adresini buraya sabitliyorum.
        // DÝKKAT: Port numaran (7154) deðiþirse burayý düzeltmelisin.
        string baseApiUrl = "https://localhost:7154/api";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TAB Baþlýklarýný Gizleme Ayarlarý
            Personel.Appearance = TabAppearance.FlatButtons;
            Personel.ItemSize = new Size(0, 1);
            Personel.SizeMode = TabSizeMode.Fixed;

            // Form açýlýnca verileri getir
            PersonelleriGetir();      // Tabloyu doldurur
            DepartmanlariGetir();     // Personel Ekleme -> Departman kutusunu doldurur

            // --- YENÝ EKLENENLER ---
            PersonelleriComboboxaDoldur(); // Görev Atama -> Personel kutusunu doldurur

            // Durum Kutusunu Elle Dolduruyoruz
            cmbGorevDurum.Items.Clear();
            cmbGorevDurum.Items.Add("Bekliyor");
            cmbGorevDurum.Items.Add("Yapýlýyor");
            cmbGorevDurum.Items.Add("Tamamlandý");
            cmbGorevDurum.SelectedIndex = 0; // Ýlkini seçili yap
            GorevleriListele();
        }

        // 1. Personelleri Tabloya Getiren Metot
        private async void PersonelleriGetir()
        {
            using (HttpClient client = new HttpClient())
            {
                try
                {
                    var response = await client.GetAsync(baseApiUrl + "/Personel");

                    if (response.IsSuccessStatusCode)
                    {
                        string jsonString = await response.Content.ReadAsStringAsync();
                        var personeller = JsonConvert.DeserializeObject<List<Personel>>(jsonString);
                        gridPersonel.DataSource = personeller;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Personel Listesi Hatasý: " + ex.Message);
                }
            }


        }

        // 2. Departmanlarý Getiren Metot (Personel Ekleme Sayfasý Ýçin)
        private async void DepartmanlariGetir()
        {
            using (HttpClient client = new HttpClient())
            {
                try
                {
                    var response = await client.GetAsync(baseApiUrl + "/Departman");

                    if (response.IsSuccessStatusCode)
                    {
                        string jsonString = await response.Content.ReadAsStringAsync();
                        var departmanlar = JsonConvert.DeserializeObject<List<Departman>>(jsonString);

                        // ComboBox Ayarlarý
                        cmbDepartman.DataSource = departmanlar;
                        cmbDepartman.DisplayMember = "Ad"; // Ekranda görünen (Yazýlým)
                        cmbDepartman.ValueMember = "Id";   // Arkada tutulan (1)
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Departman Listesi Hatasý: " + ex.Message);
                }
            }
        }


        // 3. [YENÝ] Personelleri Görev Sayfasýndaki Kutuya Dolduran Metot
        private async void PersonelleriComboboxaDoldur()
        {
            using (HttpClient client = new HttpClient())
            {
                try
                {
                    var response = await client.GetAsync(baseApiUrl + "/Personel");

                    if (response.IsSuccessStatusCode)
                    {
                        string jsonString = await response.Content.ReadAsStringAsync();
                        var personeller = JsonConvert.DeserializeObject<List<Personel>>(jsonString);

                        // Görev sayfasýndaki Combobox Ayarlarý
                        cmbGorevPersonel.DataSource = personeller;
                        cmbGorevPersonel.DisplayMember = "Ad"; // Ýsim görünsün
                        cmbGorevPersonel.ValueMember = "Id";   // ID saklansýn
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Personel Listesi (Görev) Hatasý: " + ex.Message);
                }
            }
        }

        // 4. Personel Ekleme Butonu
        private async void btnEkle_Click(object sender, EventArgs e)
        {
            Personel yeniPersonel = new Personel(); // Buradaki Personel class olandýr (Entity)
            yeniPersonel.Ad = txtAd.Text;
            yeniPersonel.Soyad = txtSoyad.Text;
            yeniPersonel.Email = txtEmail.Text;
            yeniPersonel.Telefon = txtTelefon.Text;
            yeniPersonel.Sifre = "1234";

            // Departman Seçimi Kontrolü
            if (cmbDepartman.SelectedValue != null)
            {
                yeniPersonel.DepartmanId = Convert.ToInt32(cmbDepartman.SelectedValue);
            }
            else
            {
                MessageBox.Show("Lütfen bir departman seçiniz!");
                return;
            }

            // API'ye Gönderme Ýþlemi
            string jsonVeri = JsonConvert.SerializeObject(yeniPersonel);
            StringContent icerik = new StringContent(jsonVeri, Encoding.UTF8, "application/json");

            using (HttpClient client = new HttpClient())
            {
                try
                {
                    var response = await client.PostAsync(baseApiUrl + "/Personel", icerik);

                    if (response.IsSuccessStatusCode)
                    {
                        MessageBox.Show("Personel Eklendi!");
                        PersonelleriGetir(); // Tabloyu yenile
                        PersonelleriComboboxaDoldur(); // Diðer sayfadaki listeyi de yenile

                        // Kutularý Temizle
                        txtAd.Text = ""; txtSoyad.Text = ""; txtEmail.Text = ""; txtTelefon.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("Hata: " + response.StatusCode);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Baðlantý Hatasý: " + ex.Message);
                }
            }
        }

        // 5. [YENÝ] GÖREV EKLEME BUTONU
        private async void btnGorevEkle_Click(object sender, EventArgs e)
        {
            // Kontrol: Personel seçili mi?
            if (cmbGorevPersonel.SelectedValue == null)
            {
                MessageBox.Show("Lütfen görev atanacak personeli seçin!");
                return;
            }

            // Görev Nesnesi Oluþturuyoruz
            Gorev yeniGorev = new Gorev();
            yeniGorev.Baslik = txtGorevBaslik.Text;
            yeniGorev.Aciklama = txtGorevAciklama.Text;
            yeniGorev.Durum = cmbGorevDurum.Text;

            // HATA VEREN SATIRI SÝLDÝK (yeniGorev.Tarih = ...) 

            yeniGorev.PersonelId = Convert.ToInt32(cmbGorevPersonel.SelectedValue);

            // API'ye Gönderme Paketi Hazýrlýðý
            string jsonVeri = JsonConvert.SerializeObject(yeniGorev);
            StringContent icerik = new StringContent(jsonVeri, Encoding.UTF8, "application/json");

            using (HttpClient client = new HttpClient())
            {
                try
                {
                    var response = await client.PostAsync(baseApiUrl + "/Gorev", icerik);

                    if (response.IsSuccessStatusCode)
                    {
                        MessageBox.Show("Görev Baþarýyla Atandý!");
                        GorevleriListele();

                        // Kutularý temizle
                        txtGorevBaslik.Text = "";
                        txtGorevAciklama.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("Hata oluþtu: " + response.StatusCode);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Baðlantý Hatasý: " + ex.Message);
                }
            }
        }

        // Menü Geçiþleri
        private void personelÝþlemleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // 0 numaralý sayfa (Ýlk sekme)
            Personel.SelectedIndex = 0;
        }

        private void görevAtamaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // 1 numaralý sayfa (Ýkinci sekme)
            Personel.SelectedIndex = 1;
        }

        private async void GorevleriListele()
        {
            using (HttpClient client = new HttpClient())
            {
                try
                {
                    // API'ye git: /api/Gorev
                    var response = await client.GetAsync(baseApiUrl + "/Gorev");

                    if (response.IsSuccessStatusCode)
                    {
                        string jsonString = await response.Content.ReadAsStringAsync();

                        // Gelen veriyi List<Gorev> formatýna çevir
                        var gorevler = JsonConvert.DeserializeObject<List<Gorev>>(jsonString);

                        // --- DÜZELTÝLEN YER BURASI ---
                        // Görevleri, Görev Izgarasýna (gridGorevler) basýyoruz.
                        gridGorevler.DataSource = gorevler;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Görevler Listelenemedi: " + ex.Message);
                }
            }
        }



        // Boþ kalanlar
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
        private void yÖNETÝMToolStripMenuItem_Click(object sender, EventArgs e) { }

        private void txtGorevAciklama_TextChanged(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}