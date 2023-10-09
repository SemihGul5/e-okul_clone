using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Collections;

namespace e_okul
{
    public partial class giris : Form
    {
        public giris()
        {
            InitializeComponent();
        }
        public static string tc;
        public static int ogr_no;
        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=data.accdb");
        OleDbDataAdapter datr = new OleDbDataAdapter();
        DataSet ds = new DataSet();
        Random p_numb = new Random();
        int numb;
        ArrayList k_dizi = new ArrayList();
        ArrayList sifredizi = new ArrayList();
        ArrayList k_dizi1 = new ArrayList();
        ArrayList sifredizi1 = new ArrayList();
        bilgiler a = new bilgiler();
        
        private void ogrencigiris_Click(object sender, EventArgs e)
        {
            //try
            //{
                baglanti.Open();
                OleDbCommand komut = new OleDbCommand("select * from ogrenci",baglanti);
                OleDbDataReader oku = komut.ExecuteReader();
                while (oku.Read())
                {
                    k_dizi.Add(oku["ogr_tc"].ToString());
                    sifredizi.Add(oku["ogr_no"].ToString());
                }
                   var kullaniciadi =ogrenci_tc.Text;
                   var sifre = ogrenci_no.Text;
                   tc = ogrenci_tc.Text;
                   ogr_no =Convert.ToInt32(ogrenci_no.Text);
                   int rakamlar = Convert.ToInt32(ogr_r_R.Text);
               if (k_dizi.IndexOf(kullaniciadi) != -1)
                {
                    int sira = k_dizi.IndexOf(kullaniciadi);
                    label10.Text = k_dizi[sira].ToString();
                    label11.Text = sifredizi[sira].ToString();
                    if (kullaniciadi == label10.Text && sifre == label11.Text&&rakamlar==numb)
                    {
                        ogrencipaneli ogr = new ogrencipaneli();
                        ogr.Show();
                        this.Hide();
                   
                }

                    else
                    {
                      MessageBox.Show("TC KİMLİK, NUMARA VEYA RESİMDEKİ RAKAMLARI HATALI GİRDİNİZ","GİRİŞ BAŞARISIZ" , MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
               }
            
             else
               {
                   MessageBox.Show("TC KİMLİK VEYA NUMARA HATALI", "GİRİŞ BAŞARISIZ", MessageBoxButtons.OK, MessageBoxIcon.Error);
               }
            baglanti.Close();
            //}
            //catch (Exception)
            //{
            //    MessageBox.Show("GİRİŞ BAŞARISIZ", "TC KİMLİK VEYA NUMARA HATALI", MessageBoxButtons.OK, MessageBoxIcon.Error);

            //}

        }

        private void giris_Load(object sender, EventArgs e)
        {
           
            label10.Visible = true;
            label11.Visible = true;
            label12.Visible = true;
            label13.Visible = true;
            numb = p_numb.Next(1000, 9999);
            label8.Text = numb.ToString();

 
 
        }

        private void y_r_R_TextChanged(object sender, EventArgs e)
        {
            if (y_r_R.Text == numb.ToString())
            {
                pictureBox2.Image = ımageList1.Images["true.png"];
            }
            else
            {
                pictureBox2.Image = ımageList1.Images["false.png"];
            }
            if (y_r_R.Text == "")
            {
                pictureBox2.Image = null;
            }
            AcceptButton = yonetim_giris;
        }

        private void ogr_r_R_TextChanged(object sender, EventArgs e)
        {
            if (ogr_r_R.Text == numb.ToString())
            {
                pictureBox1.Image = ımageList1.Images["true.png"];
            }
            else
            {
                pictureBox1.Image = ımageList1.Images["false.png"];
            }
            if (ogr_r_R.Text=="")
            {
                pictureBox1.Image = null;
            }
            AcceptButton = ogrencigiris;
        }

        private void ogrenci_tc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (ogrenci_tc.TextLength == 11)
            {
                e.Handled = true;
            }
            if (char.IsLetter(e.KeyChar))
            {
                MessageBox.Show("Harf girişi yasaktır! Lütfen 11 haneli T.C kimlik numaranızı giriniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Handled = true;
            }
            else
            {
                e.Handled = false;
            }
        }

        private void ogrenci_no_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                MessageBox.Show("Harf girişi yasaktır! Lütfen okul numaranızı giriniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Handled = true;
            }
            else
            {
                e.Handled = false;
            }
        }

        private void ogr_r_R_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (ogrenci_tc.TextLength == 4)
            {
                e.Handled = true;
            }
            if (char.IsLetter(e.KeyChar))
            {
                MessageBox.Show("Harf girişi yasaktır! Lütfen üst tarafta bulunan 4 sayıyı giriniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Handled = true;
            }
            else
            {
                e.Handled = false;
            }
        }

        private void y_r_R_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (char.IsLetter(e.KeyChar))
            {
                MessageBox.Show("Harf girişi yasaktır! Lütfen üst tarafta bulunan 4 sayıyı giriniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Handled = true;
            }
            else
            {
                e.Handled = false;
            }
        }

        private void yonetim_giris_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();
                OleDbCommand komut = new OleDbCommand("select * from ogrt_giris", baglanti);
                OleDbDataReader oku = komut.ExecuteReader();
                while (oku.Read())
                {
                    k_dizi1.Add(oku["k_adi"].ToString());
                    sifredizi1.Add(oku["sifre"].ToString());
                }
                var kullaniciadi = ogretmen_id.Text;
                var sifre = ogretmen_pw.Text;
                int rrakamlar = Convert.ToInt32(y_r_R.Text);
                if (k_dizi1.IndexOf(kullaniciadi) != -1)
                {
                    int sira = k_dizi1.IndexOf(kullaniciadi);
                    label12.Text = k_dizi1[sira].ToString();
                    label13.Text = sifredizi1[sira].ToString();
                    if (kullaniciadi == label12.Text && sifre == label13.Text && rrakamlar == numb)
                    {
                        ogretmenpaneli ogrt = new ogretmenpaneli();
                        ogrt.Show();
                        this.Hide();

                    }
                    else
                    {
                        MessageBox.Show("KULLANICI ADI,ŞİFRE HATALI VEYA RESİMDEKİ RAKAMLARI HATALI GİRDİNİZ", "GİRİŞ BAŞARISIZ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
                else
                {
                    MessageBox.Show("KULLANICI ADI VEYA ŞİFRE HATALI", "GİRİŞ BAŞARISIZ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                baglanti.Close();
            }
            catch (Exception)
            {

                MessageBox.Show("GİRİŞ BAŞARISIZ", "BEKLENMEDİK BİR HATA OLUŞTU", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            

        }

        private void ogrenci_tc_TextChanged(object sender, EventArgs e)
        {
            if (ogrenci_tc.TextLength>11)
            {
                MessageBox.Show("11 Haneli TC kimlik no girin","UYARI",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }

        private void ogrenci_no_TextChanged(object sender, EventArgs e)
        {

        }

        private void ogretmen_id_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            sifreunuttum sf = new sifreunuttum();
            sf.Show();
        }

        private void ogretmen_pw_TextChanged(object sender, EventArgs e)
        {
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (ogretmen_pw.PasswordChar == '*')
            {
                ogretmen_pw.PasswordChar = '\0';
            }
            else
            {
                ogretmen_pw.PasswordChar = '*';
            }
        }

        private void ogretmen_id_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Char.IsWhiteSpace(e.KeyChar);
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
