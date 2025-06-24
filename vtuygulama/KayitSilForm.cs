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
    public partial class KayitSilForm : Form
    {
        public KayitSilForm()
        {
            InitializeComponent();
        }
        public void KayitSil()
        {
            try
            {
               Form1.BaglantiAc();
               string sorgu = "Delete from Ogrenci where Kayitno = " + txtKayitno.Text;
               SqlCommand SilKomut = new SqlCommand(sorgu, Form1.Baglanti);
             if (SilKomut.ExecuteNonQuery() == 1)
                MessageBox.Show( txtKayitno.Text +" Numaralı Kayıt Silindi","Uyarı",MessageBoxButtons.OK,MessageBoxIcon.Information);
            Form1.Baglanti.Close();

            }
            catch (Exception Hata)
            {
                MessageBox.Show(Hata.Message, "Kayıt Sil Hata Penceresi");
            }
            

        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            KayitSil();
        }
    }
}
