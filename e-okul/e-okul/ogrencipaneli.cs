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

namespace e_okul
{
    public partial class ogrencipaneli : Form
    {
        public ogrencipaneli()
        {
            InitializeComponent();
        }
        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=data.accdb");
        OleDbCommand komut = new OleDbCommand();
        OleDbDataAdapter adtr = new OleDbDataAdapter();
        DataSet ds = new DataSet();
        void listelsinav()
        {
            dataGridView3.Refresh();
            veritabani.BaglantiKontrol();
            OleDbDataAdapter adtr = new OleDbDataAdapter("select * from Sinavtarih",veritabani.baglanti);
            adtr.Fill(ds, "Sinavtarih");
            dataGridView3.DataSource = ds.Tables["Sinavtarih"];
            adtr.Dispose();
            veritabani.BaglantiKontrol();
          
        }
        bilgiler a = new bilgiler();
        private void ogrencipaneli_Load(object sender, EventArgs e)
        {
            listelsinav();
            veritabani.BaglantiKontrol();
            OleDbCommand komut1 = new OleDbCommand("select * from ogrenci where ogr_tc='"+giris.tc+"'",veritabani.baglanti);
            OleDbDataReader oku1 = komut1.ExecuteReader();
            while (oku1.Read())
            {
                label6.Text = oku1["ogr_ad"].ToString()+" "+oku1["ogr_soyad"].ToString();
                
            }
            veritabani.BaglantiKontrol();
            veritabani.BaglantiKontrol();
            OleDbCommand komut2 = new OleDbCommand("select * from ogrenci where ogr_tc='" + giris.tc + "'",veritabani.baglanti);
            OleDbDataReader oku2 = komut2.ExecuteReader();
            while (oku2.Read())
            {
                pictureBox1.ImageLocation = oku2["ogr_resim"].ToString();
            }
            veritabani.BaglantiKontrol();
            veritabani.BaglantiKontrol();
            OleDbCommand komut3 = new OleDbCommand("select * from duyuru",veritabani.baglanti);
            OleDbDataReader oku3 = komut3.ExecuteReader();
            while (oku3.Read())
            {
                richTextBox1.Text = oku3["duyurular"].ToString();
            }
            veritabani.BaglantiKontrol();

            veritabani.BaglantiKontrol();
            OleDbCommand komut4 = new OleDbCommand("select * from devamsizlik where ogr_no="+Convert.ToInt32(giris.ogr_no)+"", veritabani.baglanti);
            OleDbDataReader oku4 = komut4.ExecuteReader();
            while (oku4.Read())
            {
                int sira = listView1.Items.Count;
                listView1.Items.Add(oku4["devamsizlik_tur"].ToString());
                listView1.Items[sira].SubItems.Add(oku4["devamsizlik"].ToString());

            }
            veritabani.BaglantiKontrol();

            veritabani.BaglantiKontrol();
            OleDbCommand komut5 = new OleDbCommand("select * from belgeler where ogr_no=" + Convert.ToInt32(giris.ogr_no) + "", veritabani.baglanti);
            OleDbDataReader oku5 = komut5.ExecuteReader();
            while (oku5.Read())
            {
                int sira2 = listView2.Items.Count;
                listView2.Items.Add(oku5["belge_tur"].ToString());
                listView2.Items[sira2].SubItems.Add(oku5["yıl"].ToString());

            }
            veritabani.BaglantiKontrol();

            veritabani.BaglantiKontrol();
            OleDbCommand komut6 = new OleDbCommand("select * from odev", veritabani.baglanti);
            OleDbDataReader oku6 = komut6.ExecuteReader();
            while (oku6.Read())
            {
                int sira3 = listView3.Items.Count;
                listView3.Items.Add(oku6["ödevler"].ToString());
                listView3.Items[sira3].SubItems.Add(oku6["son_tarih"].ToString());

            }
            veritabani.BaglantiKontrol();


            veritabani.BaglantiKontrol();
            OleDbCommand komut7 = new OleDbCommand("select * from notlar where ogr_no=" +Convert.ToInt32(giris.ogr_no) + "", veritabani.baglanti);
            OleDbDataReader oku7 = komut7.ExecuteReader();
            while (oku7.Read())
            {
                int sira4 = listView4.Items.Count;
                listView4.Items.Add(oku7["ders_ad"].ToString());
                listView4.Items[sira4].SubItems.Add(oku7["yazili_1"].ToString());
                listView4.Items[sira4].SubItems.Add(oku7["yazili_2"].ToString());
                listView4.Items[sira4].SubItems.Add(oku7["sozlu_1"].ToString());
                listView4.Items[sira4].SubItems.Add(oku7["sozlu_2"].ToString());
                listView4.Items[sira4].SubItems.Add(oku7["ort"].ToString());
            }
            veritabani.BaglantiKontrol();

            veritabani.BaglantiKontrol();
            OleDbCommand komut8 = new OleDbCommand("select * from dersprogrami", veritabani.baglanti);
            OleDbDataReader oku8 = komut8.ExecuteReader();
            while (oku8.Read())
            {
                int sira5 = listView5.Items.Count;
                listView5.Items.Add(oku8["Gün"].ToString());
                listView5.Items[sira5].SubItems.Add(oku8["Ders1"].ToString());
                listView5.Items[sira5].SubItems.Add(oku8["Ders2"].ToString());
                listView5.Items[sira5].SubItems.Add(oku8["Ders3"].ToString());
                listView5.Items[sira5].SubItems.Add(oku8["Ders4"].ToString());
                listView5.Items[sira5].SubItems.Add(oku8["Ders5"].ToString());
                listView5.Items[sira5].SubItems.Add(oku8["Ders6"].ToString());
                listView5.Items[sira5].SubItems.Add(oku8["Ders7"].ToString());
                listView5.Items[sira5].SubItems.Add(oku8["Ders8"].ToString());

            }
            veritabani.BaglantiKontrol();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            giris a = new giris();
            a.Show();
            this.Hide();
        }
    }
}
