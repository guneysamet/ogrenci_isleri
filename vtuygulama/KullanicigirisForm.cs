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
    public partial class KullanicigirisForm : Form
    {
        public KullanicigirisForm()
        {
            InitializeComponent();
        }
        public static string Kullaniciad, Kturu;
        public void Kullaniniciara()
        {
            try
            {
                Form1.BaglantiAc();
                string Sorgu = "Select * from Kullanicilar where Kadi='"+txtkadi.Text+"'And Sifre='"+txtsifre.Text+"'";
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

        private void KullanicigirisForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Kullaniniciara(); 
            }
        }

        private void btngiris_Click(object sender, EventArgs e)
        {
            Kullaniniciara();
        }
    }
}
