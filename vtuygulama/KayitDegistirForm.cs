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
    public partial class KayitDegistirForm : Form
    {
        public KayitDegistirForm()
        {
            InitializeComponent();
        }
        //Birimler tablosunun BirimAdi alanından verileri comboboxa yukleyen method
        public void VeriYukle()
        {
            try
            {
                Form1.BaglantiAc();
                string Sorgu = "Select birimAdi from Birimler";
                SqlCommand YukleKomut = new SqlCommand(Sorgu, Form1.Baglanti);
                SqlDataReader dr = YukleKomut.ExecuteReader();
                while (dr.Read())
                {
                    cmbBirim.Items.Add(dr["birimAdi"]);
                }
                Form1.Baglanti.Close();
            }
            catch (Exception Hata)
            {

                MessageBox.Show(Hata.Message, "Birim Yükleme Hata Penceresi");

            }
        }



        //datagridviewden alınan verileri değiitirerek kaydeden method
        public void KayitDegistir()
        {


            try
            {
                Form1.BaglantiAc();

                string Sorgu = "UPDATE Ogrenci set Ad=@Ad,Soyad=@Soyad, Tcno=@Tcno,Cinsiyet=@Cinsiyet,Bolum=@Bolum,Dter=@Dter where Kayitno=@Kayitno";
                SqlCommand DegistirKomut = new SqlCommand(Sorgu, Form1.Baglanti);
                DegistirKomut.Parameters.AddWithValue("@Ad", txtAd.Text);
                DegistirKomut.Parameters.AddWithValue("@Soyad", txtSoyad.Text);
                DegistirKomut.Parameters.AddWithValue("@Tcno", txtTcno.Text);
                if (radErkek.Checked is true)
                    DegistirKomut.Parameters.AddWithValue("@Cinsiyet", "Erkek");
                else if (radKadin.Checked is true)
                    DegistirKomut.Parameters.AddWithValue("@Cinsiyet", "Kadın");
                DegistirKomut.Parameters.AddWithValue("@Bolum", cmbBirim.Text);
                DegistirKomut.Parameters.AddWithValue("@Dter", dtTar.Value);
                DegistirKomut.Parameters.AddWithValue("@Kayitno", txtKayitno.Text);

                if (DegistirKomut.ExecuteNonQuery() == 1)
                    MessageBox.Show("Değiştirildi", "veri girişi");
                Form1.Baglanti.Close();


            }
            catch (Exception Hata)
            {
                MessageBox.Show(Hata.Message, "Kayıt Değiştir Hata Penceresi");
            }
        }



        public bool BoslukKontrol()
        {
            bool bos = false;
            lblYildiz.Visible = false;
            lblYidiz2.Visible = false;
            txtAd.BackColor = Color.White;
            txtSoyad.BackColor = Color.White;
            txtTcno.BackColor = Color.White;
            cmbBirim.BackColor = Color.White;

            if (dtTar.Value.Date == DateTime.Today.Date)
            {
                lblYidiz2.Visible = true;
                dtTar.Focus();
                bos = true;

            }
            if (cmbBirim.Text == "" || cmbBirim.Text == "Bölüm Seçiniz")
            {
                cmbBirim.BackColor = Color.Red;
                cmbBirim.Focus();
                bos = true;

            }
            if (radErkek.Checked == false && radKadin.Checked == false)
            {
                lblYildiz.Visible = true;
                bos = true;

            }
            if (txtTcno.Text.Length < 11)
            {
                txtTcno.BackColor = Color.Red;
                txtTcno.Focus();
                bos = true;
            }


            if (txtSoyad.Text == "")
            {
                txtSoyad.BackColor = Color.Red;
                txtSoyad.Focus();
                bos = true;
            }

            if (txtAd.Text == "")
            {
                txtAd.BackColor = Color.Red;
                txtAd.Focus();
                bos = true;
            }

            return bos;

        }

        /*private void btnDegistir_Click(object sender, EventArgs e)
        {
            if (BoslukKontrol() == true)
                MessageBox.Show("Boş alanları doldurunuz", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else KayitDegistir();



        }
        */
        private void btnDegistir_Click_1(object sender, EventArgs e)
        {
            if (BoslukKontrol() == true)
                MessageBox.Show("Boş alanları doldurunuz", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else KayitDegistir();
        }

        private void KayitDegistirForm_Load(object sender, EventArgs e)
        {
            VeriYukle();
        }
    }
}
