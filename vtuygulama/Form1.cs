using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient; //Ado.net sql server kütüphanesi tanımı.


namespace vtuygulama
{
    public partial class Form1 : Form
    {
         
        public Form1()
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

        //veritabanı bağlantısı ile bağlantı cümleciği
        public static SqlConnection Baglanti = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=vt2B;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        

        //sql veritabanı bağlantısını kontrollü  şekilde açan metod.
        public static void BaglantiAc()
        {
            try
            {   
                //veritabanı bağlantısını kontrollü olarak aç.
                if (Baglanti.State == ConnectionState.Closed)
                    Baglanti.Open();
            }
            catch (Exception Hata)
            {
                //sistem hata mesajını yakala
                MessageBox.Show(Hata.Message, "Bağlantı Aç Hata Penceresi");
                
            }
        }

        //öğrenci tablosundaki kayıtları listeler
        public void KayitListele()
        {
            try
            {
                BaglantiAc();
                DataSet ds = new DataSet();
                string Sorgu = "Select * From Ogrenci";
                SqlDataAdapter da = new SqlDataAdapter(Sorgu, Baglanti);
                da.Fill(ds, "Ogrenci");
                dataGridView1.DataSource = ds.Tables["Ogrenci"];
                Baglanti.Close();
            }
            catch (Exception Hata)
            {
                MessageBox.Show(Hata.Message, "Kayıt Listele Hata Penceresi");
            }
        }
        //öğrenci tablosunda seçili alana göre birebir arama methodu
        public void KayitAra()
        {
            try
            {
                BaglantiAc();
                DataSet ds = new DataSet();
                string SorguTum = "Select * From Ogrenci";
                string SorguAd = "Select * From Ogrenci where Ad ='" + txtadara.Text+"'";
                string SorguSoyad = "Select * From Ogrenci where Soyad ='" + txtsoyadara.Text+"'";              
                string SorguBirim = "Select * From Ogrenci where Bolum='" + cmbBirim.Text + "'";
                string SorguAdSoyad = "Select * From Ogrenci where Ad ='" + txtadara.Text + "' And Soyad ='" + txtsoyadara.Text + "'";
                string SorguAdBirim = "Select *  From Ogrenci where Ad='" + txtadara.Text + "' And Bolum ='" + cmbBirim.Text + "'";
                string SorguSoyadBirim = "Select *  From Ogrenci where Soyad='" + txtsoyadara.Text + "' And Bolum ='" + cmbBirim.Text + "'";
                string SorguAdSoyadBirim = "Select * From Ogrenci where Ad ='" + txtadara.Text + "' And Soyad ='" + txtsoyadara.Text + "' And Bolum ='" + cmbBirim.Text+"'";

                if (chkad.Checked == true && chksoyad.Checked == true && chkbirim.Checked == true)
                    SorguTum = SorguAdSoyadBirim;
                else if (chkad.Checked == true && chksoyad.Checked == true)
                    SorguTum = SorguAdSoyad;
                else if (chkad.Checked == true && chkbirim.Checked == true)
                    SorguTum = SorguAdBirim;
                else if (chksoyad.Checked == true && chkbirim.Checked == true)
                    SorguTum = SorguSoyadBirim;
                else if (chkad.Checked == true)
                    SorguTum = SorguAd;
                else if (chksoyad.Checked == true)
                    SorguTum = SorguSoyad;
                else if (chkbirim.Checked == true)
                    SorguTum = SorguBirim;
                 
               
                SqlDataAdapter da = new SqlDataAdapter(SorguTum, Baglanti);
                da.Fill(ds, "Ogrenci");
                dataGridView1.DataSource = ds.Tables["Ogrenci"];
                Baglanti.Close();
            }
            catch (Exception Hata)
            {
                MessageBox.Show(Hata.Message, "Kayıt Ara Hata Penceresi");
            }
        }
        //Seçilen ara türü ve alana göre yazarken arama yapan metod.
        public void HizliAra()
        {
            try
            {
                BaglantiAc();
                DataSet ds = new DataSet();
                string SorguTum = "Select * From Ogrenci";
                string Sorgutcnoilebaslayan = "Select * From Ogrenci where Tcno Like '" + txthizliara.Text+"%'";
                string Sorgutcnoilebiten = "Select * From Ogrenci where Tcno Like '%" + txthizliara.Text + "'";
                string Sorgutcnoiceren = "Select * From Ogrenci where Tcno Like '%" + txthizliara.Text + "%'";

                string Sorgubirimilebaslayan = "Select * From Ogrenci where Bolum Like '" + txthizliara.Text + "%'";
                string Sorgubirimilebiten = "Select * From Ogrenci where Bolum Like '%" + txthizliara.Text + "'";
                string Sorgubirimiceren = "Select * From Ogrenci where Bolum Like '%" + txthizliara.Text + "%'";

                string Sorguadilebaslayan = "Select * From Ogrenci where Ad Like '" + txthizliara.Text + "%'";
                string Sorguadilebiten = "Select * From Ogrenci where Ad Like '%" + txthizliara.Text + "'";
                string Sorguadiceren = "Select * From Ogrenci where Ad Like '%" + txthizliara.Text + "%'";

                string Sorgusoyadilebaslayan = "Select * From Ogrenci where Soyad Like '" + txthizliara.Text + "%'";
                string Sorgusoyadilebiten = "Select * From Ogrenci where Soyad Like '%" + txthizliara.Text + "'";
                string Sorgusoyadiceren = "Select * From Ogrenci where Soyad Like '%" + txthizliara.Text + "%'";

                if (radtcno.Checked == true)
                {
                    if (cmbaramaturu.Text == "İle Başlayan")
                        SorguTum = Sorgutcnoilebaslayan;
                    else if (cmbaramaturu.Text == "İle Biten")
                        SorguTum = Sorgutcnoilebiten;
                    else if (cmbaramaturu.Text == "İçeren")
                        SorguTum = Sorgutcnoiceren;
                }

                else if (radbirim.Checked == true)
                {
                    if (cmbaramaturu.Text == "İle Başlayan")
                        SorguTum = Sorgubirimilebaslayan;
                    else if (cmbaramaturu.Text == "İle Biten")
                        SorguTum = Sorgubirimilebiten;
                    else if (cmbaramaturu.Text == "İçeren")
                        SorguTum = Sorgubirimiceren;
                }
                else if (radad.Checked == true)
                {
                    if (cmbaramaturu.Text == "İle Başlayan")
                        SorguTum = Sorguadilebaslayan;
                    else if (cmbaramaturu.Text == "İle Biten")
                        SorguTum = Sorguadilebiten;
                    else if (cmbaramaturu.Text == "İçeren")
                        SorguTum = Sorguadiceren;
                }
                else if (radsoyad.Checked == true)
                {
                    if (cmbaramaturu.Text == "İle Başlayan")
                        SorguTum = Sorgusoyadilebaslayan;
                    else if (cmbaramaturu.Text == "İle Biten")
                        SorguTum = Sorgusoyadilebiten;
                    else if (cmbaramaturu.Text == "İçeren")
                        SorguTum = Sorgusoyadiceren;
                }


                SqlDataAdapter da = new SqlDataAdapter(SorguTum, Baglanti);
                da.Fill(ds, "Ogrenci");
                dataGridView1.DataSource = ds.Tables["Ogrenci"];
                Baglanti.Close();
            }
            catch (Exception Hata)
            {
                MessageBox.Show(Hata.Message, "HIzlı Ara Hata Penceresi");
            }
        }


        //personel tablosunda seçili alana göre birebir arama methodu
        private void Form1_Load(object sender, EventArgs e)
        {
            // MessageBox.Show("Bağlantı Durumu:" + Baglanti.State);
            KayitListele();
            VeriYukle();
        }


        private void btnEkle_Click(object sender, EventArgs e)
        {
            KayitEkleForm kytEkle = new KayitEkleForm();
            kytEkle.ShowDialog();
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            Baglanti.Close();
            KayitListele();
            
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            KayitSilForm kytsil = new KayitSilForm();
            kytsil.txtKayitno.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            kytsil.txtAd.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            kytsil.txtSoyad.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            kytsil.txtTcno.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            kytsil.ShowDialog();
        }

        private void btnDegistir_Click(object sender, EventArgs e)
        {
            KayitDegistirForm frmDegistir = new KayitDegistirForm();
            frmDegistir.txtKayitno.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            frmDegistir.txtAd.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            frmDegistir.txtSoyad.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            frmDegistir.dtTar.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            
            if (dataGridView1.CurrentRow.Cells[4].Value.ToString() == "Kadın")
                frmDegistir.radKadin.Checked = true;
            else if (dataGridView1.CurrentRow.Cells[4].Value.ToString() == "Erkek")
                frmDegistir.radErkek.Checked = true;

            frmDegistir.cmbBirim.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();

            frmDegistir.txtTcno.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();


            frmDegistir.ShowDialog();
        }

        private void chkad_CheckedChanged(object sender, EventArgs e)
        {
            if (chkad.Checked == true)
            {
                txtadara.Enabled = true;
                txtadara.Focus();
            }
            else
            {
                txtadara.Enabled = false;
                txtadara.Text = "";
            }


        }

        private void btnara_Click(object sender, EventArgs e)
        {
            KayitAra();
        }

        private void chksoyad_CheckedChanged(object sender, EventArgs e)
        {
            if (chksoyad.Checked == true)
            {
                txtsoyadara.Enabled = true;
                txtsoyadara.Focus();
            }
            else
            {
                txtsoyadara.Enabled = false; 
                txtsoyadara.Text = "";
            }

        }

        private void chkbirim_CheckedChanged(object sender, EventArgs e)
        {
            if (chkbirim.Checked == true)
            {
                cmbBirim.Enabled = true;
                cmbBirim.Focus();
            }
            else
            {
                cmbBirim.Enabled = false;
                cmbBirim.Text = "Bölüm Seçiniz";
            }
        }

        private void cmbBirim_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void radtcno_CheckedChanged(object sender, EventArgs e)
        {
                lblarananalan.Text = "TC No";
                txthizliara.Focus();
                txthizliara.Text = "";
        }

        private void raddyer_CheckedChanged(object sender, EventArgs e)
        {

            //lblarananalan.Text = "Doğum Yeri";
            //txthizliara.Focus();
            //txthizliara.Text = "";

        }

        private void txthizliara_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void txthizliara_TextChanged_1(object sender, EventArgs e)
        {
            HizliAra();
        }

        private void radtel_CheckedChanged(object sender, EventArgs e)
        {
            lblarananalan.Text = "Telefon";
            txthizliara.Focus();
            txthizliara.Text = "";
        }

        private void radbirim_CheckedChanged(object sender, EventArgs e)
        {
            lblarananalan.Text = "Bölüm";
            txthizliara.Focus();
            txthizliara.Text = "";
        }

        private void radad_CheckedChanged(object sender, EventArgs e)
        {
            lblarananalan.Text = "Ad";
            txthizliara.Focus();
            txthizliara.Text = "";
        }

        private void radsoyad_CheckedChanged(object sender, EventArgs e)
        {
            lblarananalan.Text = "Soyad";
            txthizliara.Focus();
            txthizliara.Text = "";

        }

        private void birimTanımlamaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BirimTanimlama brmtnm = new BirimTanimlama();
            brmtnm.ShowDialog();
                
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void kullanıcıİşlemleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Kullaniciislemform kislem = new Kullaniciislemform();
            kislem.ShowDialog();
        }

        private void personelListesiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //PersonelRaporForm rapor = new PersonelRaporForm();
            //rapor.ShowDialog();
        }

        private void raporlamaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            BirimTanimlama brmtnm = new BirimTanimlama();
            brmtnm.ShowDialog();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            Kullaniciislemform kislem = new Kullaniciislemform();
            kislem.ShowDialog();
        }
    }
}
