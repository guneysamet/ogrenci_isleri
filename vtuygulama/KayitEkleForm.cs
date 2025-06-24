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
    public partial class KayitEkleForm : Form
    {
        public KayitEkleForm()
        {
            InitializeComponent();
        }

        //Birimler tablosunun BirimAdi alanından verileri comboboxa yukleyen method
        public  void VeriYukle()
        {
            try
            {
                Form1.BaglantiAc();
                string Sorgu = "Select BirimAdi from Birimler";
                SqlCommand YukleKomut = new SqlCommand(Sorgu, Form1.Baglanti);
                SqlDataReader dr = YukleKomut.ExecuteReader();
                while(dr.Read())
                {
                    cmbBirim.Items.Add(dr["BirimAdi"]);
                }
                Form1.Baglanti.Close();
            }
            catch (Exception Hata)
            {

                MessageBox.Show(Hata.Message, "Birim Yükleme Hata Penceresi");

            }
        }








            //Personel tablosuna formdaki kontrollerden veri ekleyen metod
        public void KayitEkle()
        {
            try
            {
                Form1.BaglantiAc();
                string Sorgu = "Insert Into Ogrenci (Ad,Soyad,Tcno,Cinsiyet,Bolum,Dter)Values (@Ad,@Soyad,@Tcno,@Cinsiyet,@Bolum,@Dter)";
                SqlCommand EkleKomut = new SqlCommand(Sorgu, Form1.Baglanti);
                EkleKomut.Parameters.AddWithValue("@Ad", txtAd.Text);
                EkleKomut.Parameters.AddWithValue("@Soyad", txtSoyad.Text);
                EkleKomut.Parameters.AddWithValue("@Tcno", txtTcno.Text);
                if (radErkek.Checked is true)
                    EkleKomut.Parameters.AddWithValue("@Cinsiyet", "Erkek");
                if (radKadin.Checked is true)
                    EkleKomut.Parameters.AddWithValue("@Cinsiyet", "Kadın");
                EkleKomut.Parameters.AddWithValue("@Bolum", cmbBirim.Text);
                EkleKomut.Parameters.AddWithValue("@Dter",dtTar.Value);
                if (EkleKomut.ExecuteNonQuery() == 1)
                    MessageBox.Show("Kayıt Eklendi");
                Form1.Baglanti.Close();

            }
            catch (Exception Hata)
            {
                MessageBox.Show(Hata.Message, "Kayıt Ekle Hata Penceresi");
                                       
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
            if (cmbBirim.Text == "" || cmbBirim.Text == "Birim Seçiniz")
            {
                cmbBirim.BackColor = Color.Red;
                cmbBirim.Focus();
                bos = true;

            }
            if (radErkek.Checked==false && radKadin.Checked == false)
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

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (BoslukKontrol() == true)
                MessageBox.Show("Boş alanları doldurunuz", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
                KayitEkle();



            /*
            if(txtAd.Text == ""|| txtSoyad.Text == ""|| txtTcno.Text == "")
            {
                MessageBox.Show("Boş bırakılamaz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (txtAd.Text == "")
            {
                txtAd.BackColor = Color.Red;
                txtAd.Focus();
            }
            else
            {
                txtAd.BackColor = default;
            }
            if (txtSoyad.Text == "")
            {
                txtSoyad.BackColor = Color.Red;
                txtSoyad.Focus();
            }
            else
            {
                txtSoyad.BackColor = default;
            }
            if (txtTcno.Text == "")
            {
                txtTcno.BackColor = Color.Red;
                txtTcno.Focus();
            }
            else
            {
                txtTcno.BackColor = default;
            }
            */


        }

        private void dtTar_ValueChanged(object sender, EventArgs e)
        {

        }

        private void KayitEkleForm_Load(object sender, EventArgs e)
        {
            VeriYukle();
        }
    }
}
