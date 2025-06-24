using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace vtuygulama
{
    public partial class Kullaniciislemform : Form
    {
        public Kullaniciislemform()
        {
            InitializeComponent();
        }
          public static string Kullaniciad, Kturu;

        /* public void Kullaniniciara()
         {
             try
             {
                 Form1.BaglantiAc();
                 string Sorgu = "Select * from Kullanicilar where Kadi='" + txtkadi.Text + "'";
                 SqlCommand YukleKomut = new SqlCommand(Sorgu, Form1.Baglanti);
                 SqlDataReader dr = YukleKomut.ExecuteReader();
                 if (dr.Read())
                 {
                     MessageBox.Show("Doğru bilgiler giriş yapılıyor", "Giriş Başarılı");
                     Kullaniciad = txtkadi.Text;
                     Kturu = dr["Kturu"].ToString();
                     Form1.Baglanti.Close();
                     Form frm1 = new Form1();
                     frm1.Show();
                     this.Hide();

                 }
                 else
                 {

                     MessageBox.Show("Hatalı kullanıcı adı veya şifre girdiniz!", "Giriş Hatası", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                 }
                 Form1.Baglanti.Close();
             }
             catch (Exception Hata)
             {

                 MessageBox.Show(Hata.Message, "Kullanıcı Giris   Hata Penceresi");

             }
         }
        */

        public void SifreDegistir()
        {
            try
            {
                Form1.BaglantiAc();

                string Sorgu = "UPDATE Kullanicilar SET Sifre = @Sifre WHERE Kkod = @Kkod";
                SqlCommand DegistirKomut = new SqlCommand(Sorgu, Form1.Baglanti);
                DegistirKomut.Parameters.AddWithValue("@Sifre", txtsifre.Text);
                DegistirKomut.Parameters.AddWithValue("@Kkod", txtkkod.Text);

                if (DegistirKomut.ExecuteNonQuery() == 1)
                    MessageBox.Show(txtkadi.Text+ " İsimli kullanıcının Şifresi Değiştirildi", "veri girişi");
                else
                    MessageBox.Show("Kayıt bulunamadı veya değiştirilemedi", "veri girişi");

                Form1.Baglanti.Close();
            }
            catch (Exception Hata)
            {
                MessageBox.Show(Hata.Message, "Sifre Değiştir Hata Penceresi");
            }
        }
        public void KullaniciEkle()
        {
            try
            {
                Form1.BaglantiAc();

                string kontrolSorgu = "SELECT * FROM Kullanicilar WHERE Kadi = @Kadi";
                SqlCommand kontrolKomut = new SqlCommand(kontrolSorgu, Form1.Baglanti);
                kontrolKomut.Parameters.AddWithValue("@Kadi", txtkadi.Text);
                SqlDataReader dr = kontrolKomut.ExecuteReader();
                if (dr.Read())
                {
                    MessageBox.Show("Bu kullanıcı adı zaten kayıtlı. Lütfen farklı bir kullanıcı adı girin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    dr.Close(); 
                }
                else
                {
                    dr.Close();
                    string Sorgu = "Insert Into Kullanicilar (Kadi,Sifre,Kturu)Values (@Kadi,@Sifre,@Kturu)";
                    SqlCommand EkleKomut = new SqlCommand(Sorgu, Form1.Baglanti);
                    EkleKomut.Parameters.AddWithValue("@Kadi", txtkadi.Text);
                    EkleKomut.Parameters.AddWithValue("@Sifre", txtsifre.Text);
                    EkleKomut.Parameters.AddWithValue("@Kturu", cmbkturu.Text);
                    if (EkleKomut.ExecuteNonQuery() == 1)
                    MessageBox.Show("Kullanici  Eklendi");
                    Form1.Baglanti.Close();
                }
            }
            catch (Exception Hata)
            {

                MessageBox.Show(Hata.Message, "Kullanıcı Ekle Hata Penceresi");
            }
        }
        public void KullaniciSil()
        {
            try
            {
                Form1.BaglantiAc();
                string sorgu = "Delete from Kullanicilar where Kkod = " + txtkkod.Text;
                SqlCommand SilKomut = new SqlCommand(sorgu, Form1.Baglanti);
                if (SilKomut.ExecuteNonQuery() == 1)
                    MessageBox.Show(txtkkod.Text + " Numaralı Kullanici Silindi", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Form1.Baglanti.Close();

            }
            catch (Exception Hata)
            {
                MessageBox.Show(Hata.Message, "Kullanıcı Sil Hata Penceresi");
            }


        }
        public void KullaniciListele()
        {
            try
            {
                Form1.BaglantiAc();
                DataSet ds = new DataSet();
                string Sorguyonetici = "Select * From Kullanicilar";
                string Sorgukullanici = "Select * From Kullanicilar where Kadi='" + lblkadi.Text + "'";
                if (lblkturu.Text != "Yönetici")
                    Sorguyonetici = Sorgukullanici;
                SqlDataAdapter da = new SqlDataAdapter(Sorguyonetici,Form1.Baglanti);
                da.Fill(ds, "Kullanicilar");
                dataGridView1.DataSource = ds.Tables["Kullanicilar"];
                Form1.Baglanti.Close();
            }
            catch (Exception Hata)
            {
                MessageBox.Show(Hata.Message, "Kullanici Listele Hata Penceresi");
            }
        }

        private void Kullaniciislemform_Load(object sender, EventArgs e)
        {

            lblkadi.Text = KullanicigirisForm.Kullaniciad;
            lblkturu.Text = KullanicigirisForm.Kturu;


            KullaniciListele();
            txtkkod.Enabled = true;
            txtkadi.Enabled = true;
            txtsifre.Enabled = true;
            cmbkturu.Enabled = true;
            if (lblkturu.Text == "Kullanici")
            {
                btnksil.Enabled = false;
                
                btnyenik.Enabled = false;

            }
            else
            {
               
            }
            
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                txtkkod.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                txtkadi.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                txtsifre.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                cmbkturu.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnyenik_Click(object sender, EventArgs e)
        {
            if (txtkkod.Text != "")
            {
                MessageBox.Show("Temizle butonuna basınız.");
                txtkkod.Focus();

            }
            else if (txtkadi.Text == "")
            {
                MessageBox.Show("Kullanici adi boş geçilemez.");
                txtkadi.Focus();

            }
            else if (txtsifre.Text == "")
            {
                MessageBox.Show("Şifre boş geçilemez.");
                txtsifre.Focus();

            }
            else if (cmbkturu.Text == "" || cmbkturu.Text == "Seçiniz")
            {
                MessageBox.Show("Kullanıcı türü boş geçilemez.");
                cmbkturu.Focus();
            }
            else
            {
               KullaniciEkle();
               KullaniciListele();
            }

          
        }

        private void btntemizle_Click(object sender, EventArgs e)
        {
            txtkkod.Text = "";
            txtkadi.Text = "";
            txtsifre.Text = "";
            cmbkturu.Text = "Seçiniz";
        }

        private void btnsdegistir_Click(object sender, EventArgs e)
        {
            if (txtkkod.Text== "")
            {
                MessageBox.Show("Şifresi değiştirilecek kullanıcıyı seçiniz .");
                txtkkod.Focus();

            }
            else if (txtsifre.Text == "")
            {
                MessageBox.Show("Şifre  boş geçilemez.");
                txtsifre.Focus();

            }
            
          
            else
            {
                SifreDegistir();         
                KullaniciListele();
            }
        }

        private void btnksil_Click(object sender, EventArgs e)
        {
            if (txtkadi.Text=="")
            {
                MessageBox.Show("Silinecek Kullanıcıyı seçiniz.");
            }
           else if (txtkadi.Text == "Admin")
           {
               MessageBox.Show("Bu Kayıt silinemez.");
           }
            else
            {
                 KullaniciSil();
                 KullaniciListele();

            }
        }
    }
}
