using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Collections;

namespace e_okul
{
    public partial class sifreunuttum : Form
    {
        public sifreunuttum()
        {
            InitializeComponent();
        }
        int sayac = 0;
        ArrayList sifredizi = new ArrayList();
        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=data.accdb");
        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            OleDbCommand komut = new OleDbCommand("select * from guvenliksoru", baglanti);
            OleDbDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                sifredizi.Add(oku["cevap"].ToString());
                label1.Text = oku["gizlisoru"].ToString();
                label4.Text = oku["cevap"].ToString();
            }
            var cevap = txtbox1.Text;
            baglanti.Close();
            if (sifredizi.IndexOf(cevap) != -1)
            {
                int sira = sifredizi.IndexOf(cevap);
                label4.Text = sifredizi[sira].ToString();
                
                if (cevap == label4.Text)
                {
                    baglanti.Open();
                    OleDbCommand komut1 = new OleDbCommand("select * from ogrt_giris", baglanti);
                    OleDbDataReader oku1 = komut1.ExecuteReader();
                    while (oku1.Read())
                    {
                        label6.Text = oku1["sifre"].ToString();
                    }
                    MessageBox.Show("Şifreniz: "+label6.Text.ToString());
                    baglanti.Close();

                }
                
                
            }
            else
            {
                sayac++;
                MessageBox.Show("Girilen veriler yanlış");
            }
            if (sayac==5)
            {
                MessageBox.Show("Çok fazla yanlış cevap girdiniz çıkış yapılıyor!!!","UYARI",MessageBoxButtons.OK,MessageBoxIcon.Stop);
                Application.Exit();
            }
        }



        private void sifreunuttum_Load(object sender, EventArgs e)
        {
            label1.Visible = false;
            label5.Visible = false;
            label4.Visible = false;
            label6.Visible = false;
            label7.Visible = false;
            baglanti.Open();
            OleDbCommand komu1 = new OleDbCommand("select * from guvenliksoru", baglanti);
            OleDbDataReader oku1 = komu1.ExecuteReader();
            while (oku1.Read())
            {
                comboBox1.Items.Add(oku1["gizlisoru"].ToString());
            }
            baglanti.Close();

        }
    }
}