using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace vtuygulama
{
    public partial class BirimTanimlama : Form
    {
        public BirimTanimlama()
        {
            InitializeComponent();
        }
        public void BirimEkle()
        {
            try
            {
                Form1.BaglantiAc();
                string Sorgu = "Insert Into Birimler (BirimAdi)Values (@BirimAdi)";
                SqlCommand EkleKomut = new SqlCommand(Sorgu, Form1.Baglanti);
                EkleKomut.Parameters.AddWithValue("@BirimAdi", txtbirimadi.Text);
                if (EkleKomut.ExecuteNonQuery() == 1)
                    MessageBox.Show("Kayıt Eklendi");
                Form1.Baglanti.Close();
            }
            catch (Exception Hata)
            {

                MessageBox.Show(Hata.Message, "Birim Ekle Hata Penceresi");
            }
        }

        public void KayitSil()
        {
            try
            {
                Form1.BaglantiAc();
                string sorgu = "Delete from Birimler where BirimKodu = " + txtbirimkodu.Text;
                SqlCommand SilKomut = new SqlCommand(sorgu, Form1.Baglanti);
                if (SilKomut.ExecuteNonQuery() == 1)
                    MessageBox.Show(txtbirimkodu.Text + " Numaralı Birim Silindi", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Form1.Baglanti.Close();

            }
            catch (Exception Hata)
            {
                MessageBox.Show(Hata.Message, "Birim Sil Hata Penceresi");
            }


        }
        public void KayitDegistir()
        {
            try
            {
                Form1.BaglantiAc();

                string Sorgu = "UPDATE Birimler SET BirimAdi = @BirimAdi WHERE BirimKodu = @BirimKodu";
                SqlCommand DegistirKomut = new SqlCommand(Sorgu, Form1.Baglanti);
                DegistirKomut.Parameters.AddWithValue("@BirimAdi", txtbirimadi.Text);
                DegistirKomut.Parameters.AddWithValue("@BirimKodu", txtbirimkodu.Text); 

                if (DegistirKomut.ExecuteNonQuery() == 1)
                    MessageBox.Show("Değiştirildi", "veri girişi");
                else
                    MessageBox.Show("Kayıt bulunamadı veya değiştirilemedi", "veri girişi");

                Form1.Baglanti.Close();
            }
            catch (Exception Hata)
            {
                MessageBox.Show(Hata.Message, "Kayıt Değiştir Hata Penceresi");
            }
        }





        public void KayitListele()
        {
            try
            {
               Form1.BaglantiAc();
                DataSet ds = new DataSet();
                string Sorgu = "Select * From Birimler";
                SqlDataAdapter da = new SqlDataAdapter(Sorgu, Form1.Baglanti);
                da.Fill(ds, "Birimler");
                dataGridView1.DataSource = ds.Tables["Birimler"];
               Form1.Baglanti.Close();
            }
            catch (Exception Hata)
            {
                MessageBox.Show(Hata.Message, "Birim Listele Hata Penceresi");
            }
        }
        

        private void BirimTanimlama_Load(object sender, EventArgs e)
        {
            txtbirimadi.Enabled = false;
            txtbirimkodu.Enabled = false;
            KayitListele();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                txtbirimkodu.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                txtbirimadi.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            }
        }

        private void btntemizle_Click(object sender, EventArgs e)
        {
            txtbirimadi.Enabled = true;
            txtbirimkodu.Enabled = true;
            txtbirimkodu.Text = "";
            txtbirimadi.Text = "";
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            KayitSil();
        }

        private void btnekle_Click(object sender, EventArgs e)
        {
            txtbirimadi.Enabled = true;
            txtbirimkodu.Enabled = true;
            if (txtbirimkodu.Text != "")
                MessageBox.Show("Temizle butonuna basınız.");
            else if (txtbirimadi.Text=="")
            {
                MessageBox.Show("Birim Adı boş bırakılamaz.");
                txtbirimadi.Focus();
            }
            else
            {
                BirimEkle();
                KayitListele();
            }
                
        }

        private void btndegistir_Click(object sender, EventArgs e)
        {
            KayitDegistir();
        }
    }
}
