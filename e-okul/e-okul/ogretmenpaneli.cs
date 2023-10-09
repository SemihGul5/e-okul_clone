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
    public partial class ogretmenpaneli : Form
    {
        public ogretmenpaneli()
        {
            InitializeComponent();
        }
        ArrayList ara = new ArrayList();
        ArrayList belgedizi = new ArrayList();
        ArrayList sifredizi = new ArrayList();
        ArrayList dersdizi = new ArrayList();
        ArrayList ogrsizi = new ArrayList();
        ArrayList ograradizi = new ArrayList();
        ArrayList ogrsildizi = new ArrayList();
        ArrayList belgeara = new ArrayList();
        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=data.accdb");
        OleDbCommand komut = new OleDbCommand();
        OleDbDataAdapter adtr = new OleDbDataAdapter();
        DataSet ds = new DataSet();
        double y1, y2, s1, s2, ort=0;
        int s = 0;
        int sayac = 0;
       
            void listele()
        {
            dataGridView1.Refresh();
            dataGridView2.Refresh();
            veritabani.BaglantiKontrol();
            OleDbDataAdapter adtr = new OleDbDataAdapter("select * from ogrenci",veritabani.baglanti);
            adtr.Fill(ds, "ogrenci");
            dataGridView1.DataSource = ds.Tables["ogrenci"];
            dataGridView2.DataSource = ds.Tables["ogrenci"];
            adtr.Dispose();
            veritabani.BaglantiKontrol();

        }
        void listele3()
        {
            dataGridView3.Refresh();
            veritabani.BaglantiKontrol();
            OleDbDataAdapter adtr = new OleDbDataAdapter("select * from notlar",veritabani.baglanti);
            adtr.Fill(ds, "notlar");
            dataGridView3.DataSource = ds.Tables["notlar"];
            adtr.Dispose();
            veritabani.BaglantiKontrol();


        }
        void listele4()
        {
            dataGridView4.Refresh();
            veritabani.BaglantiKontrol();
            OleDbDataAdapter adtr = new OleDbDataAdapter("select * from Sinavtarih", veritabani.baglanti);
            adtr.Fill(ds, "Sinavtarih");
            dataGridView4.DataSource = ds.Tables["Sinavtarih"];
            adtr.Dispose();
            veritabani.BaglantiKontrol();
           

        }
        void listele5()
        {
            dataGridView5.Refresh();
            veritabani.BaglantiKontrol();
            OleDbDataAdapter adtr = new OleDbDataAdapter("select * from duyuru",veritabani.baglanti);
            adtr.Fill(ds, "duyuru");
            dataGridView5.DataSource = ds.Tables["duyuru"];
            adtr.Dispose();
            veritabani.BaglantiKontrol();


        }
        void listele6()
        {
            dataGridView8.Refresh();
            veritabani.BaglantiKontrol();
            OleDbDataAdapter adtr = new OleDbDataAdapter("select * from ogrt_giris", veritabani.baglanti);
            adtr.Fill(ds, "ogrt_giris");
            dataGridView8.DataSource = ds.Tables["ogrt_giris"];
            adtr.Dispose();
            veritabani.BaglantiKontrol();


        }
        void listeledersprogrami()
        {
            dataGridView9.Refresh();
            veritabani.BaglantiKontrol();
            OleDbDataAdapter adtr = new OleDbDataAdapter("select * from dersprogrami", veritabani.baglanti);
            adtr.Fill(ds, "dersprogrami");
            dataGridView9.DataSource = ds.Tables["dersprogrami"];
            adtr.Dispose();
            veritabani.BaglantiKontrol();
        }
        void listele9()
        {
            dataGridView6.Refresh();
            veritabani.BaglantiKontrol();
            OleDbDataAdapter adtr = new OleDbDataAdapter("select * from belgeler", veritabani.baglanti);
            adtr.Fill(ds, "belgeler");
            dataGridView6.DataSource = ds.Tables["belgeler"];
            adtr.Dispose();
            veritabani.BaglantiKontrol();


        }
        void listele10()
        {
            dataGridView7.Refresh();
            veritabani.BaglantiKontrol();
            OleDbDataAdapter adtr = new OleDbDataAdapter("select * from devamsizlik",veritabani.baglanti);
            adtr.Fill(ds, "devamsizlik");
            dataGridView7.DataSource = ds.Tables["devamsizlik"];
            adtr.Dispose();
            veritabani.BaglantiKontrol();

        }
        void listeleodev()
        {
            dataGridView11.Refresh();
            veritabani.BaglantiKontrol();
            OleDbDataAdapter adtr = new OleDbDataAdapter("select * from odev",veritabani.baglanti);
            adtr.Fill(ds, "odev");
            dataGridView11.DataSource = ds.Tables["odev"];
            adtr.Dispose();
            veritabani.BaglantiKontrol();

        }
        void listeleders()
        {
            dataGridViewdersler.Refresh();
            veritabani.BaglantiKontrol();
            OleDbDataAdapter adtr = new OleDbDataAdapter("select * from dersler",veritabani.baglanti);
            adtr.Fill(ds, "dersler");
            dataGridViewdersler.DataSource = ds.Tables["dersler"];
            adtr.Dispose();
            veritabani.BaglantiKontrol();

        }
        void comboders()
        {
            veritabani.BaglantiKontrol();
            OleDbCommand komut5 = new OleDbCommand("select * from dersler",veritabani.baglanti);
            OleDbDataReader oku5 = komut5.ExecuteReader();
            while (oku5.Read())
            {
                comboBox3.Items.Add(oku5["ders_ad"].ToString());
                combosinavtarih.Items.Add(oku5["ders_ad"].ToString());
                comboBox14.Items.Add(oku5["ders_ad"].ToString());
                comboBox13.Items.Add(oku5["ders_ad"].ToString());
                comboBox12.Items.Add(oku5["ders_ad"].ToString());
                comboBox11.Items.Add(oku5["ders_ad"].ToString());
                comboBox10.Items.Add(oku5["ders_ad"].ToString());
                comboBox9.Items.Add(oku5["ders_ad"].ToString());
                comboBox8.Items.Add(oku5["ders_ad"].ToString());
                comboBox7.Items.Add(oku5["ders_ad"].ToString());
            }
            veritabani.BaglantiKontrol();

        }
        void kayitliogr()
        {
            veritabani.BaglantiKontrol();
            OleDbCommand komut2 = new OleDbCommand("select * from ogrenci",veritabani.baglanti);
            OleDbDataReader oku2 = komut2.ExecuteReader();
            while (oku2.Read())
            {
                listBox1.Items.Add(oku2["ogr_no"]);
                listBox2.Items.Add(oku2["ogr_no"]);
                listBox1.Sorted = true;
                listBox2.Sorted = true;
            }
            veritabani.BaglantiKontrol();
        }


        private void buttonkaydet_Click(object sender, EventArgs e)
        {
            double tc = Convert.ToDouble(textBoxTc.Text);
            //öğrenci kaydet
            try
            {
                if (textBoxAd.Text != "" && textBoxSoyad.Text != "" && textBoxTc.Text != "" && textBoxOkulno.Text != "" && textBoxSinif.Text != "" && textBoxResim.Text != "")
                {
                    if (textBoxTc.TextLength == 11)
                    {
                        if (tc%2==0)
                        {
                            textBoxResim.Text = pictureBox4.ImageLocation;
                            baglanti.Open();
                            komut.Connection = baglanti;
                            komut.CommandText = "insert into ogrenci(ogr_ad,ogr_soyad,ogr_tc,ogr_no,ogr_sinif,ogr_resim)values('" + textBoxAd.Text + "','" + textBoxSoyad.Text + "','" + textBoxTc.Text + "'," + Convert.ToInt32(textBoxOkulno.Text) + ",'" + textBoxSinif.Text + "','" + textBoxResim.Text + "')";
                            komut.ExecuteNonQuery();
                            MessageBox.Show("KAYIT BAŞARILI");
                            baglanti.Close();
                            textBoxAd.Clear();
                            textBoxSoyad.Clear();
                            textBoxTc.Clear();
                            textBoxOkulno.Clear();
                            textBoxSinif.Clear();
                            textBoxResim.Clear();
                            pictureBox4.Image = null;
                            ds.Clear();
                            listele();
                            listele3();
                            listele4();
                            listele5();
                            listele6();
                            listele9();
                            listele10();
                            listeleodev();
                            listeleders();
                            listBox1.Items.Clear();
                            listBox2.Items.Clear();
                            kayitliogr();
                            listeledersprogrami();
                        }
                        else
                        {
                            MessageBox.Show("TC Kimlik NO HATALI Girdiniz!", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }   
                    }
                    else
                    {
                        MessageBox.Show("11 Haneli TC kimlik no girin", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }             
                }
                else
                {
                    MessageBox.Show("BOŞ ALAN GEÇMEYİN!", "BOŞ ALAN GEÇMEYİN!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception)
            {

                MessageBox.Show("BİR HATA OLUŞTU SİSTEM YÖNETİCİSE BAŞVURUN", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {//resim ekle
            try
            {
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    pictureBox4.ImageLocation = openFileDialog1.FileName;
                    textBoxResim.Text = openFileDialog1.FileName;
                }
            }
            catch (Exception)
            {

                MessageBox.Show("BİR HATA OLUŞTU SİSTEM YÖNETİCİSE BAŞVURUN", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void buttontemizle_Click(object sender, EventArgs e)
        {
            try
            {
                textBoxAd.Clear();
                textBoxSoyad.Clear();
                textBoxTc.Clear();
                textBoxOkulno.Clear();
                textBoxSinif.Clear();
                textBoxResim.Clear();
                pictureBox4.Image = null;
            }
            catch (Exception)
            {

                MessageBox.Show("BİR HATA OLUŞTU SİSTEM YÖNETİCİSE BAŞVURUN", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void buttoncikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ogretmenpaneli_Load(object sender, EventArgs e)
        {//giriş ekran
         //try
         //{

           
                timer1.Start();
                textBox5.Visible = false;
                label46.Visible = false;
                combosinavtarih.Items.Add("Nesne Tabanlı Programlama");
                combosinavtarih.Items.Add("Veri Tabanı");
                combosinavtarih.Items.Add("Açık Kaynak İşletim Sistemi");
                comboBox3.Items.Add("Nesne Tabanlı Programlama");
                comboBox3.Items.Add("Veri Tabanı");
                comboBox3.Items.Add("Açık Kaynak İşletim Sistemi");
                comboBox1.Items.Add("Annenizin doğum yeri");
                comboBox1.Items.Add("En sevdiğiniz arkadaşınızın adı");
                comboBox1.Items.Add("Tuttuğunuz takımın adı");
                comboBox6.Items.Add("Annenizin doğum yeri");
                comboBox6.Items.Add("En sevdiğiniz arkadaşınızın adı");
                comboBox6.Items.Add("Tuttuğunuz takımın adı");
                comboBox4.Items.Add("Özürlü Devamsızlık");
                comboBox4.Items.Add("Özürsüz Devamsızlık");
                comboBox2.Items.Add("Takdir Belgesi");
                comboBox2.Items.Add("Teşekkür Belgesi");
                comboBox5.Items.Add("9.Sınıf 1.Dönem");
                comboBox5.Items.Add("9.Sınıf 2.Dönem");
                comboBox5.Items.Add("10.Sınıf 1.Dönem");
                comboBox5.Items.Add("10.Sınıf 2.Dönem");
                comboBox5.Items.Add("11.Sınıf 1.Dönem");
                comboBox5.Items.Add("11.Sınıf 2.Dönem");
                comboBox5.Items.Add("12.Sınıf 1.Dönem");
                comboBox5.Items.Add("12.Sınıf 2.Dönem");
                ds.Clear();
                kayitliogr();
                listele();                
                listele3();
                listele4();
                listele5();
                listele6();
                listele9();
                listele10();
                listeleodev();
                listeleders();
                comboders();
                listeledersprogrami();
            //}
            //    catch (Exception)
            //    {

            //        MessageBox.Show("Beklenmedik bir hata oluştu", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    }

        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            pictureBox7.ImageLocation = dataGridView1.CurrentRow.Cells[5].Value.ToString();
        }

        private void dataGridView2_CellEnter(object sender, DataGridViewCellEventArgs e)
        {//datagriddeki verileri textbox a at
            try
            {
                textdad.Text = dataGridView2.CurrentRow.Cells[0].Value.ToString();
                textdsoyad.Text = dataGridView2.CurrentRow.Cells[1].Value.ToString();
                textdtc.Text = dataGridView2.CurrentRow.Cells[2].Value.ToString();
                textdokul.Text = dataGridView2.CurrentRow.Cells[3].Value.ToString();
                textdsinif.Text = dataGridView2.CurrentRow.Cells[4].Value.ToString();
                textdresim.Text = dataGridView2.CurrentRow.Cells[5].Value.ToString();
                pictureBox5.ImageLocation = dataGridView2.CurrentRow.Cells[5].Value.ToString();
            }
            catch (Exception)
            {

                MessageBox.Show("BİR HATA OLUŞTU SİSTEM YÖNETİCİSE BAŞVURUN", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }

        private void buttonguncelle_Click(object sender, EventArgs e)
        {//güncelle
            try
            {
                textdresim.Text = pictureBox5.ImageLocation;
                baglanti.Open();
                komut.Connection = baglanti;
                komut.CommandText = "update ogrenci set ogr_ad='" + textdad.Text + "',ogr_soyad='" + textdsoyad.Text + "',ogr_tc='" + textdtc.Text + "',ogr_sinif='" + textdsinif.Text + "',ogr_resim='" + textdresim.Text + "' where ogr_no=" + Convert.ToInt32(textdokul.Text) + "";
                komut.ExecuteNonQuery();
                MessageBox.Show("BAŞARILI", "KAYIT BAŞARIYLA GÜNCELLENDİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                baglanti.Close();
                ds.Clear();
                listele();
                listele3();
                listele4();
                listele5();
                listele6();
                listele9();
                listele10();
                listeleodev();
                listeleders();
                listeledersprogrami();
            }
            catch (Exception)
            {
                MessageBox.Show("BİR HATA OLUŞTU SİSTEM YÖNETİCİSE BAŞVURUN", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void buttonara_Click(object sender, EventArgs e)
        {//ara
            try
            {
                if (textara.Text != "")
                {
                    veritabani.BaglantiKontrol();
                    OleDbCommand komut11 = new OleDbCommand("select * from ogrenci", veritabani.baglanti);
                    OleDbDataReader oku11 = komut11.ExecuteReader();
                    while (oku11.Read())
                    {
                        ograradizi.Add(oku11["ogr_no"].ToString());
                    }
                    var aranan2 = textara.Text;
                    if (ograradizi.IndexOf(aranan2) != -1)
                    {
                        int sira3 = ograradizi.IndexOf(aranan2);
                        label61.Text = ograradizi[sira3].ToString();
                        if (aranan2 == label61.Text)
                        {
                            adtr = new OleDbDataAdapter("Select *from ogrenci where ogr_no like '" + textara.Text + "%'", baglanti);
                            ds = new DataSet();
                            adtr.Fill(ds, "ogrenci");
                            dataGridView2.DataSource = ds.Tables["ogrenci"];
                            textara.Clear();
                        }

                    }
                    else
                    {
                        MessageBox.Show("Öğrenci Bulunamadı");
                    }
                    veritabani.BaglantiKontrol();
                }
                else
                {
                    MessageBox.Show("Öğrenci No Boş Geçilemez!");
                }
            }
            catch (Exception)
            {

                MessageBox.Show("BİR HATA OLUŞTU SİSTEM YÖNETİCİSE BAŞVURUN", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void buttonsil_Click(object sender, EventArgs e)
        {//sil
            try
            {
                if (textBoxsil.Text != "")
                {
                    veritabani.BaglantiKontrol();
                    OleDbCommand komut12 = new OleDbCommand("select * from ogrenci", veritabani.baglanti);
                    OleDbDataReader oku12 = komut12.ExecuteReader();
                    while (oku12.Read())
                    {
                        ogrsildizi.Add(oku12["ogr_no"].ToString());
                    }
                    var aranan3 = textBoxsil.Text;
                    if (ogrsildizi.IndexOf(aranan3) != -1)
                    {
                        int sira4 = ogrsildizi.IndexOf(aranan3);
                        label63.Text = ogrsildizi[sira4].ToString();
                        if (aranan3 == label63.Text)
                        {
                            DialogResult c;
                            c = MessageBox.Show("Silmek istediğinizden emin misiniz?", "Uyarı!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                            if (c == DialogResult.Yes)
                            {
                                komut.Connection = veritabani.baglanti;
                                komut.CommandText = "Delete from ogrenci where ogr_no=" + textBoxsil.Text + "";
                                komut.ExecuteNonQuery();
                                MessageBox.Show("KAYIT SİLİNDİ");
                                komut.Dispose();
                                ds.Clear();
                                listele();
                                listele3();
                                listele4();
                                listele5();
                                listele6();
                                listele9();
                                listele10();
                                listeleodev();
                                listeleders();
                                listeledersprogrami();
                                textBoxsil.Clear();
                            }
                        }
                           

                    }
                    else
                    {
                        MessageBox.Show("Öğrenci Bulunamadı");
                    }
                    veritabani.BaglantiKontrol();
                }
                else
                {
                    MessageBox.Show("Öğrenci No Boş Geçilemez!");
                }
           }
            catch (Exception)
            {

                MessageBox.Show("BİR HATA OLUŞTU SİSTEM YÖNETİCİSE BAŞVURUN", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {//öğrenci düzenle resim ekle
            try
            {
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    pictureBox5.ImageLocation = openFileDialog1.FileName;
                    textdresim.Text = openFileDialog1.FileName;
                }
            }
            catch (Exception)
            {

                MessageBox.Show("BİR HATA OLUŞTU SİSTEM YÖNETİCİSE BAŞVURUN", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }

        private void button5kaydet_Click(object sender, EventArgs e)
        {//Sınav tarihi ekle
            try
            {
                baglanti.Open();
                komut.Connection = baglanti;
                komut.CommandText = "insert into Sinavtarih(Tarih,Sinav)values('" + dateTimePicker1.Text + "','" + combosinavtarih.Text + "')";
                komut.ExecuteNonQuery();
                MessageBox.Show("KAYIT BAŞARILI");
                baglanti.Close();
                komut.Dispose();
                ds.Clear();
                listele();
                listele3();
                listele4();
                listele5();
                listele6();
                listele9();
                listele10();
                listeleodev();
                listeleders();
                listeledersprogrami();
            }
            catch (Exception)
            {

                MessageBox.Show("BİR HATA OLUŞTU SİSTEM YÖNETİCİSE BAŞVURUN", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void button8_Click(object sender, EventArgs e)
        {
           
        }

        private void button5sil_Click(object sender, EventArgs e)
        {//sınav tarih sil
            try
            {
                DialogResult a;
                a = MessageBox.Show("Silmek istediğinizden emin misiniz?", "Uyarı!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (a == DialogResult.Yes)
                {
                    baglanti.Open();
                    komut.Connection = baglanti;
                    komut.CommandText = "Delete from Sinavtarih where ID=" + textBoxID.Text + "";
                    komut.ExecuteNonQuery();
                    MessageBox.Show("KAYIT SİLİNDİ");
                    komut.Dispose();
                    baglanti.Close();
                    ds.Clear();
                    listele();
                    listele3();
                    listele4();
                    listele5();
                    listele6();
                    listele9();
                    listele10();
                    listeleodev();
                    listeleders();
                    listeledersprogrami();
                    textBoxID.Clear();
                }
            }
            catch (Exception)
            {

                MessageBox.Show("BİR HATA OLUŞTU SİSTEM YÖNETİCİSE BAŞVURUN", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
         
        }

        private void buttonanasayfa_Click(object sender, EventArgs e)
        {
            giris anasayfa = new giris();
            anasayfa.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            giris anasayfa = new giris();
            anasayfa.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            giris anasayfa = new giris();
            anasayfa.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            giris anasayfa = new giris();
            anasayfa.Show();
            this.Hide();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();
                komut.Connection = baglanti;
                komut.CommandText = "insert into duyuru(duyurular)values('" + richTextBox1.Text + "')";
                komut.ExecuteNonQuery();
                MessageBox.Show("KAYIT BAŞARILI");
                baglanti.Close();
                komut.Dispose();
                ds.Clear();
                listele();
                listele3();
                listele4();
                listele5();
                listele6();
                listele9();
                listele10();
                listeleodev();
                listeleders();
            }
            catch (Exception)
            {

                MessageBox.Show("BİR HATA OLUŞTU SİSTEM YÖNETİCİSE BAŞVURUN", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void button10_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult a;
                a = MessageBox.Show("Silmek istediğinizden emin misiniz?", "Uyarı!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (a == DialogResult.Yes)
                {
                    baglanti.Open();
                    komut.Connection = baglanti;
                    komut.CommandText = "Delete from duyuru where id=" + textBox1.Text + "";
                    komut.ExecuteNonQuery();
                    MessageBox.Show("KAYIT SİLİNDİ");
                    komut.Dispose();
                    baglanti.Close();
                    ds.Clear();
                    listele();
                    listele3();
                    listele4();
                    listele5();
                    listele6();
                    listele9();
                    listele10();
                    listeleodev();
                    listeleders();
                    listeledersprogrami();
                    textBoxID.Clear();
                }
            }
            catch (Exception)
            {

                MessageBox.Show("BİR HATA OLUŞTU SİSTEM YÖNETİCİSE BAŞVURUN", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }

        private void dataGridView3_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void buttonnkaydet_Click(object sender, EventArgs e)
        {
            
            //try
            //{
            if (textBox11.Text != "")
            {
                veritabani.BaglantiKontrol();
                OleDbCommand komut22 = new OleDbCommand("select * from ogrenci", veritabani.baglanti);
                OleDbDataReader oku22 = komut22.ExecuteReader();
                while (oku22.Read())
                {
                    ogrsizi.Add(oku22["ogr_no"].ToString());
                }
                var ara2 = textBox11.Text;
                if (ogrsizi.IndexOf(ara2) != -1)
                {
                    int sira = ogrsizi.IndexOf(ara2);
                    label25.Text = ogrsizi[sira].ToString();
                    veritabani.BaglantiKontrol();
                    if (ara2 == label25.Text)
                    {
                        if (textyazili1.Text == "")//sadece yazılı 1 boşsa
                        {
                            ort = ((int.Parse(textyazili2.Text) + int.Parse(textsozlu1.Text) + int.Parse(textsozlu2.Text)) / 3);
                            label39.Text = ort.ToString();
                            veritabani.BaglantiKontrol();
                            komut.Connection = veritabani.baglanti;
                            komut.CommandText = "insert into notlar(ogr_no,ders_ad,yazili_2,sozlu_1,sozlu_2,ort)values(" + Convert.ToInt32(textBox11.Text) + ",'" + comboBox3.SelectedItem + "'," + Convert.ToInt32(textyazili2.Text) + "," + Convert.ToInt32(textsozlu1.Text) + "," + Convert.ToInt32(textsozlu2.Text) + ",'" + ort.ToString() + "')";
                            komut.ExecuteNonQuery();
                            MessageBox.Show("Başarıyla kaydedildi");
                            veritabani.BaglantiKontrol();
                            komut.Dispose();
                            ds.Clear();
                            listele();
                            listele3();
                            listele4();
                            listele5();
                            listele6();
                            listele9();
                            listele10();
                            listeleodev();
                            listeleders();
                            comboders();
                            listeledersprogrami();
                            if (textyazili2.Text == "")//sadece yazili 2 boşsa
                            {
                                ort = ((int.Parse(textyazili1.Text) + int.Parse(textsozlu1.Text) + int.Parse(textsozlu2.Text)) / 3);
                                label39.Text = ort.ToString();
                                veritabani.BaglantiKontrol();
                                komut.Connection = veritabani.baglanti;
                                komut.CommandText = "insert into notlar(ogr_no,ders_ad,yazili_1,sozlu_1,sozlu_2,ort)values(" + Convert.ToInt32(textBox11.Text) + ",'" + comboBox3.SelectedItem + "'," + Convert.ToInt32(textyazili1.Text) + "," + Convert.ToInt32(textsozlu1.Text) + "," + Convert.ToInt32(textsozlu2.Text) + ",'" + ort.ToString() + "')";
                                komut.ExecuteNonQuery();
                                MessageBox.Show("Başarıyla kaydedildi");
                                veritabani.BaglantiKontrol();
                                komut.Dispose();
                                ds.Clear();
                                listele();
                                listele3();
                                listele4();
                                listele5();
                                listele6();
                                listele9();
                                listele10();
                                listeleodev();
                                listeleders();
                                comboders();
                                listeledersprogrami();
                            }
                            if (textsozlu1.Text == "")//sadece sozlu 1 boşsa
                            {
                                ort = ((int.Parse(textyazili1.Text) + int.Parse(textyazili2.Text) + int.Parse(textsozlu2.Text)) / 3);
                                label39.Text = ort.ToString();
                                veritabani.BaglantiKontrol();
                                komut.Connection = veritabani.baglanti;
                                komut.CommandText = "insert into notlar(ogr_no,ders_ad,yazili_1,yazili_2,sozlu_2,ort)values(" + Convert.ToInt32(textBox11.Text) + ",'" + comboBox3.SelectedItem + "'," + Convert.ToInt32(textyazili1.Text) + "," + Convert.ToInt32(textyazili2.Text) + "," + Convert.ToInt32(textsozlu2.Text) + ",'" + ort.ToString() + "')";
                                komut.ExecuteNonQuery();
                                MessageBox.Show("Başarıyla kaydedildi");
                                veritabani.BaglantiKontrol();
                                komut.Dispose();
                                ds.Clear();
                                listele();
                                listele3();
                                listele4();
                                listele5();
                                listele6();
                                listele9();
                                listele10();
                                listeleodev();
                                listeleders();
                                comboders();
                                listeledersprogrami();
                            }
                            if (textsozlu2.Text == "")//sadece sözlü 2 boşsa
                            {
                                ort = ((int.Parse(textyazili1.Text) + int.Parse(textyazili2.Text) + int.Parse(textsozlu1.Text)) / 3);
                                label39.Text = ort.ToString();
                                veritabani.BaglantiKontrol();
                                komut.Connection = veritabani.baglanti;
                                komut.CommandText = "insert into notlar(ogr_no,ders_ad,yazili_1,yazili_2,sozlu_1,ort)values(" + Convert.ToInt32(textBox11.Text) + ",'" + comboBox3.SelectedItem + "'," + Convert.ToInt32(textyazili1.Text) + "," + Convert.ToInt32(textyazili2.Text) + "," + Convert.ToInt32(textsozlu1.Text) + ",'" + ort.ToString() + "')";
                                komut.ExecuteNonQuery();
                                MessageBox.Show("Başarıyla kaydedildi");
                                veritabani.BaglantiKontrol();
                                komut.Dispose();
                                ds.Clear();
                                listele();
                                listele3();
                                listele4();
                                listele5();
                                listele6();
                                listele9();
                                listele10();
                                listeleodev();
                                listeleders();
                                comboders();
                                listeledersprogrami();
                            }
                        }
                        
                       
                        if (textyazili2.Text == ""&&textsozlu1.Text==""&&textsozlu2.Text=="")//sadece yazılı 1 doluysa
                        {
                            ort = ((int.Parse(textyazili1.Text)) / 1);
                            label39.Text = ort.ToString();
                            veritabani.BaglantiKontrol();
                            komut.Connection = veritabani.baglanti;
                            komut.CommandText = "insert into notlar(ogr_no,ders_ad,yazili_1,ort)values(" + Convert.ToInt32(textBox11.Text) + ",'" + comboBox3.SelectedItem + "'," + Convert.ToInt32(textyazili1.Text) + ",'" + ort.ToString() + "')";
                            komut.ExecuteNonQuery();
                            MessageBox.Show("Başarıyla kaydedildi");
                            veritabani.BaglantiKontrol();
                            komut.Dispose();
                            ds.Clear();
                            listele();
                            listele3();
                            listele4();
                            listele5();
                            listele6();
                            listele9();
                            listele10();
                            listeleodev();
                            listeleders();
                            comboders();
                            listeledersprogrami();
                        }

                        if (textsozlu1.Text == "" && textsozlu2.Text == "")//sadece yazılı 1 ve yazılı 2 doluysa
                        {
                            ort = ((int.Parse(textyazili1.Text) + int.Parse(textyazili2.Text)) / 2);
                            label39.Text = ort.ToString();
                            veritabani.BaglantiKontrol();
                            komut.Connection = veritabani.baglanti;
                            komut.CommandText = "insert into notlar(ogr_no,ders_ad,yazili_1,yazili_2,ort)values(" + Convert.ToInt32(textBox11.Text) + ",'" + comboBox3.SelectedItem + "'," + Convert.ToInt32(textyazili1.Text) + "," + Convert.ToInt32(textyazili2.Text) + ",'" + ort.ToString() + "')";
                            komut.ExecuteNonQuery();
                            MessageBox.Show("Başarıyla kaydedildi");
                            veritabani.BaglantiKontrol();
                            komut.Dispose();
                            ds.Clear();
                            listele();
                            listele3();
                            listele4();
                            listele5();
                            listele6();
                            listele9();
                            listele10();
                            listeleodev();
                            listeleders();
                            comboders();
                            listeledersprogrami();
                        }
                        if (textsozlu1.Text == "" && textsozlu2.Text == "")//sadece yazılı 1 ve sözlü 1 doluysa
                        {
                            ort = ((int.Parse(textyazili1.Text) + int.Parse(textsozlu1.Text)) / 2);
                            label39.Text = ort.ToString();
                            veritabani.BaglantiKontrol();
                            komut.Connection = veritabani.baglanti;
                            komut.CommandText = "insert into notlar(ogr_no,ders_ad,yazili_1,sozlu_1,ort)values(" + Convert.ToInt32(textBox11.Text) + ",'" + comboBox3.SelectedItem + "'," + Convert.ToInt32(textyazili1.Text) + "," + Convert.ToInt32(textsozlu1.Text) + ",'" + ort.ToString() + "')";
                            komut.ExecuteNonQuery();
                            MessageBox.Show("Başarıyla kaydedildi");
                            veritabani.BaglantiKontrol();
                            komut.Dispose();
                            ds.Clear();
                            listele();
                            listele3();
                            listele4();
                            listele5();
                            listele6();
                            listele9();
                            listele10();
                            listeleodev();
                            listeleders();
                            comboders();
                            listeledersprogrami();
                        }
                        if (textsozlu1.Text == "" && textsozlu2.Text == "")//sadece yazılı 1 yazılı 2 ve sözlü 1 doluysa
                        {
                            ort = ((int.Parse(textyazili1.Text) + int.Parse(textyazili2.Text)+int.Parse(textsozlu1.Text)) / 3);
                            label39.Text = ort.ToString();
                            veritabani.BaglantiKontrol();
                            komut.Connection = veritabani.baglanti;
                            komut.CommandText = "insert into notlar(ogr_no,ders_ad,yazili_1,yazili_2,sozlu_1,ort)values(" + Convert.ToInt32(textBox11.Text) + ",'" + comboBox3.SelectedItem + "'," + Convert.ToInt32(textyazili1.Text) + "," + Convert.ToInt32(textyazili2.Text) + "," + Convert.ToInt32(textsozlu1.Text) + ",'" + ort.ToString() + "')";
                            komut.ExecuteNonQuery();
                            MessageBox.Show("Başarıyla kaydedildi");
                            veritabani.BaglantiKontrol();
                            komut.Dispose();
                            ds.Clear();
                            listele();
                            listele3();
                            listele4();
                            listele5();
                            listele6();
                            listele9();
                            listele10();
                            listeleodev();
                            listeleders();
                            comboders();
                            listeledersprogrami();
                        }
                        else
                        {
                            ort = ((int.Parse(textyazili1.Text) + int.Parse(textyazili2.Text) + int.Parse(textsozlu1.Text)+int.Parse(textsozlu2.Text)) / 4);
                            label39.Text = ort.ToString();
                            veritabani.BaglantiKontrol();
                            komut.Connection = veritabani.baglanti;
                            komut.CommandText = "insert into notlar(ogr_no,ders_ad,yazili_1,yazili_2,sozlu_1,sozlu_2,ort)values(" + Convert.ToInt32(textBox11.Text) + ",'" + comboBox3.SelectedItem + "'," + Convert.ToInt32(textyazili1.Text) + "," + Convert.ToInt32(textyazili2.Text) + "," + Convert.ToInt32(textsozlu1.Text) + "," + Convert.ToInt32(textsozlu2.Text) + ",'" + ort.ToString() + "')";
                            komut.ExecuteNonQuery();
                            MessageBox.Show("Başarıyla kaydedildi");
                            veritabani.BaglantiKontrol();
                            komut.Dispose();
                            ds.Clear();
                            listele();
                            listele3();
                            listele4();
                            listele5();
                            listele6();
                            listele9();
                            listele10();
                            listeleodev();
                            listeleders();
                            comboders();
                            listeledersprogrami();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Öğrenci Bulunamadı");
                }         
            }
            else
            {
                MessageBox.Show("Öğrenci NO boş geçilemez!");
            }
            //}
            //catch (Exception)
            //{

            //    MessageBox.Show("BİR HATA OLUŞTU SİSTEM YÖNETİCİSE BAŞVURUN", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}


        }

        private void textyazili1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                MessageBox.Show("Harf girişi yasaktır!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Handled = true;
            }
            else
            {

                e.Handled = false;
            }
        }

        private void textyazili2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                MessageBox.Show("Harf girişi yasaktır!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Handled = true;
            }
            else
            {

                e.Handled = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            try
            {
                if (comboBox1.Text!=""&&textgizlicevap.Text!="")
                {
                    baglanti.Open();
                    komut.Connection = baglanti;
                    komut.CommandText = "insert into guvenliksoru(gizlisoru,cevap)values('" + comboBox1.SelectedItem.ToString() + "','" + textgizlicevap.Text + "')";
                    komut.ExecuteNonQuery();
                    MessageBox.Show("Başarıyla kaydedildi");
                    baglanti.Close();
                    komut.Dispose();
                    sayac++;
                }
                else
                {
                    MessageBox.Show("Boş alan geçmeyin!");
                }
                if (sayac==1)
                {
                    MessageBox.Show("Zaten Gizli soru seçmişsiniz!");
                }

        }
            catch (Exception)
            {

                MessageBox.Show("BİR HATA OLUŞTU SİSTEM YÖNETİCİSE BAŞVURUN", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (texteskisifre.Text != "" && texteskisifre2.Text != "" && textyenisifre.Text != "")
                {
                     if (texteskisifre2.TextLength > 8 && textyenisifre.TextLength > 8)
                    {
                         if(textyenisifre.Text==texteskisifre2.Text)
                        {
                            baglanti.Open();
                            OleDbCommand komut1 = new OleDbCommand("select * from ogrt_giris", baglanti);
                            OleDbDataReader oku1 = komut1.ExecuteReader();
                            while (oku1.Read())
                            {
                                sifredizi.Add(oku1["sifre"].ToString());
                                textBox5.Text = (oku1["k_adi"].ToString());
                            }
                            var sifre = texteskisifre.Text;
                            var ysifre = textyenisifre.Text;
                            if (sifredizi.IndexOf(sifre) != -1)
                            {
                                int sira = sifredizi.IndexOf(sifre);
                                label46.Text = sifredizi[sira].ToString();
                                baglanti.Close();
                                if (sifre == label46.Text)
                                {
                                    baglanti.Open();
                                    OleDbCommand kmt = new OleDbCommand();
                                    kmt.Connection = baglanti;
                                    kmt.CommandText = "update ogrt_giris set sifre='" + ysifre.ToString() + "'";
                                    kmt.ExecuteNonQuery();
                                    MessageBox.Show("Şifren başarıyla güncellendi");
                                    baglanti.Close();
                                    ds.Clear();
                                    listele6();
                                    komut.Dispose();

                                }
                            }
                            else
                            {
                                MessageBox.Show("Eski şifreni yanlış girdin");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Şifreleri aynı girmedin!");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Şifre 8 Karakterden büyük olmalıdır!");
                    }
                }
                else
                {
                    MessageBox.Show("Boş alan geçmeyin!");
                }
        }
            catch (Exception)
            {

                MessageBox.Show("BİR HATA OLUŞTU SİSTEM YÖNETİCİSE BAŞVURUN", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
}
        private void texteskisifre2_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (texteskisifre2.TextLength >= 8)
                {
                    pictureBox2.Image = ımageList1.Images["true.png"];
                    label47.Text = "";
                }
                else
                {
                    pictureBox2.Image = ımageList1.Images["false.png"];
                    label47.Text = "Şifre 8 karakterden uzun olmalıdır";
                }
            }
            catch (Exception)
            {

                MessageBox.Show("BİR HATA OLUŞTU SİSTEM YÖNETİCİSE BAŞVURUN", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           

        }

        private void textyenisifre_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (texteskisifre2.Text == textyenisifre.Text)
                {
                    pictureBox3.Image = ımageList1.Images["true.png"];

                }
                else
                {
                    pictureBox3.Image = ımageList1.Images["false.png"];
                }
                if (textyenisifre.Text=="")
                {
                    pictureBox3.Image = null;
                }
            }
            catch (Exception)
            {

                MessageBox.Show("BİR HATA OLUŞTU SİSTEM YÖNETİCİSE BAŞVURUN", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Start();
            s++;
            if (s==5)
            {
                timer1.Stop();
                label48.Visible = false;
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult a;
                a = MessageBox.Show("Silmek istediğinizden emin misiniz?", "Uyarı!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (a == DialogResult.Yes)
                {
                    if (textBox10.Text != "")
                    {
                        veritabani.BaglantiKontrol();
                        komut.Connection = veritabani.baglanti;
                        komut.CommandText = "Delete from devamsizlik where id=" + textBox10.Text + "";
                        komut.ExecuteNonQuery();
                        MessageBox.Show("KAYIT SİLİNDİ");
                        veritabani.BaglantiKontrol();
                        komut.Dispose();
                        ds.Clear();
                        listeleders();
                        listele();
                        listele3();
                        listele4();
                        listele5();
                        listele6();
                        listele9();
                        listele10();
                        listeleodev();
                        listeleders();
                        listeledersprogrami();
                        textBox10.Clear();
                    }
                    else
                    {
                        MessageBox.Show("ID alanı boş geçilemez");
                    }
                }


           }
            catch (Exception)
            {

                MessageBox.Show("BİR HATA OLUŞTU SİSTEM YÖNETİCİSE BAŞVURUN", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

       }

        private void button15_Click(object sender, EventArgs e)
        {//devamsızlık ekle
            //try
            //{
                if (textBox4.Text!="")
                {
                    veritabani.BaglantiKontrol();
                    OleDbCommand komut9 = new OleDbCommand("select * from ogrenci", veritabani.baglanti);
                    OleDbDataReader oku9 = komut9.ExecuteReader();
                    while (oku9.Read())
                    {
                        ara.Add(oku9["ogr_no"].ToString());
                    }
                    var aranan = textBox4.Text;
                    if (ara.IndexOf(aranan) != -1)
                    {
                        int sira2 = ara.IndexOf(aranan);
                        label52.Text = ara[sira2].ToString();
                        if (aranan == label52.Text)
                        {
                            OleDbCommand cmd = new OleDbCommand();
                            cmd.Connection =veritabani.baglanti;
                            cmd.CommandText = "insert into devamsizlik(ogr_no,devamsizlik_tur,devamsizlik)values('" + textBox4.Text + "','" + comboBox4.SelectedItem + "','" + dateTimePicker2.Text + "')";
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("KAYIT BAŞARILI");
                            cmd.Dispose();
                            ds.Clear();
                            listele10();
                            listele();
                            listele3();
                            listele4();
                            listele5();
                            listele6();
                            listele9();
                            listeleodev();
                            listeleders();
                        listeledersprogrami();
                    }

                    }
                    else
                    {
                        MessageBox.Show("Öğrenci Bulunamadı");
                    }
                veritabani.BaglantiKontrol();
                }
                else
                {
                    MessageBox.Show("Boş Alan Geçmeyin");
                }

            //}   
            // catch (Exception)
            // {

            //     MessageBox.Show("BİR HATA OLUŞTU SİSTEM YÖNETİCİSE BAŞVURUN", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            // }
        }

        private void button12_Click(object sender, EventArgs e)
        {//belge ekle
            //try
            //{
                if (textBox2.Text!="")
                {
                    veritabani.BaglantiKontrol();
                    OleDbCommand komut10 = new OleDbCommand("select * from ogrenci", veritabani.baglanti);
                    OleDbDataReader oku10 = komut10.ExecuteReader();
                    while (oku10.Read())
                    {
                        belgedizi.Add(oku10["ogr_no"].ToString());
                    }
                    var aranan1 = textBox2.Text;
                    if (belgedizi.IndexOf(aranan1) != -1)
                    {
                        int sira2 = belgedizi.IndexOf(aranan1);
                        label54.Text = belgedizi[sira2].ToString();
                        if (aranan1 == label54.Text)
                        {
                            komut.Connection = veritabani.baglanti;
                            komut.CommandText = "insert into belgeler(ogr_no,belge_tur,yıl)values('" + Convert.ToInt32(textBox2.Text) + "','" + comboBox2.SelectedItem + "','" + comboBox5.SelectedItem + "')";
                            komut.ExecuteNonQuery();
                            MessageBox.Show("KAYIT BAŞARILI");
                            komut.Dispose();
                            ds.Clear();
                            listele();
                            listele3();
                            listele4();
                            listele5();
                            listele6();
                            listele9();
                            listele10();
                            listeleodev();
                            listeleders();
                        listeledersprogrami();
                        textBox2.Clear();
                        }

                    }
                    else
                    {
                        MessageBox.Show("Öğrenci Bulunamadı");
                    }
                    veritabani.BaglantiKontrol();
                }

            //}
            //catch (Exception)
            //{

            //    MessageBox.Show("BİR HATA OLUŞTU SİSTEM YÖNETİCİSE BAŞVURUN", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }

        private void button13_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult a;
                a = MessageBox.Show("Silmek istediğinizden emin misiniz?", "Uyarı!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (a == DialogResult.Yes)
                {
                    if (textBox3.Text != "")
                    {
                        baglanti.Open();
                        komut.Connection = baglanti;
                        komut.CommandText = "Delete from belgeler where ID=" + textBox3.Text + "";
                        komut.ExecuteNonQuery();
                        MessageBox.Show("KAYIT SİLİNDİ");
                        baglanti.Close();
                        komut.Dispose();
                        ds.Clear();
                        listele();
                        listele3();
                        listele4();
                        listele5();
                        listele6();
                        listele9();
                        listele10();
                        listeleodev();
                        listeleders();
                        listeledersprogrami();
                    }
                    else
                    {
                        MessageBox.Show("ID girin");
                    }
                }
                
               
            }
            catch (Exception)
            {

                MessageBox.Show("BİR HATA OLUŞTU SİSTEM YÖNETİCİSE BAŞVURUN", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void listView1_Click(object sender, EventArgs e)
        {

        }

        private void listView1_DoubleClick(object sender, EventArgs e)
        {
        }

        private void button19_Click(object sender, EventArgs e)
        {
            listele();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox4.Text = listBox1.SelectedItem.ToString();
        }

        private void button18_Click(object sender, EventArgs e)
        {//Ödev ekle
            //try
            //{
                if (richTextBox2.Text!="")
                {
                    veritabani.BaglantiKontrol();
                    komut.Connection = veritabani.baglanti;
                    komut.CommandText = "insert into odev(ödevler,son_tarih)values('" + richTextBox2.Text + "','" + dateTimePicker3.Text + "')";
                    komut.ExecuteNonQuery();
                    MessageBox.Show("KAYIT BAŞARILI");
                    veritabani.BaglantiKontrol();
                    komut.Dispose();
                    ds.Clear();
                    listele();
                    listele3();
                    listele4();
                    listele5();
                    listele6();
                    listele9();
                    listele10();
                    listeleodev();
                    listeleders();
                listeledersprogrami();
            }
                else
                {
                    MessageBox.Show("Ödev alanı boş geçilemez");
                }
            //}
            //catch (Exception)
            //{

            //    MessageBox.Show("BİR HATA OLUŞTU SİSTEM YÖNETİCİSE BAŞVURUN", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }

        private void button17_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult a;
                a = MessageBox.Show("Silmek istediğinizden emin misiniz?", "Uyarı!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (a == DialogResult.Yes)
                {
                    if (textBox7.Text != "")
                    {
                        baglanti.Open();
                        komut.Connection = baglanti;
                        komut.CommandText = "Delete from odev where id=" + textBox7.Text + "";
                        komut.ExecuteNonQuery();
                        MessageBox.Show("KAYIT SİLİNDİ");
                        baglanti.Close();
                        komut.Dispose();
                        ds.Clear();
                        listele();
                        listele3();
                        listele4();
                        listele5();
                        listele6();
                        listele9();
                        listele10();
                        listeleodev();
                        listeleders();
                        listeledersprogrami();
                    }
                    else
                    {
                        MessageBox.Show("Ödev alanı boş geçilemez");
                    }
                }
                

            }
            catch (Exception)
            {

                MessageBox.Show("BİR HATA OLUŞTU SİSTEM YÖNETİCİSE BAŞVURUN", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label24_Click(object sender, EventArgs e)
        {

        }

        private void button20_Click(object sender, EventArgs e)
        {
            //try
            //{

            if (textBox12.Text != "")
            {
                veritabani.BaglantiKontrol();
                OleDbCommand komut23 = new OleDbCommand("select * from dersler",veritabani.baglanti);
                OleDbDataReader oku23 = komut23.ExecuteReader();
                while (oku23.Read())
                {
                    dersdizi.Add(oku23["ders_ad"].ToString());
                }
                var ara = textBox12.Text.ToUpper();
                if (dersdizi.IndexOf(ara) != -1)
                {
                    int sira = dersdizi.IndexOf(ara);
                    label46.Text = dersdizi[sira].ToString();
                    veritabani.BaglantiKontrol();

                    if (ara == label46.Text)
                    {
                        MessageBox.Show("Bu ders zaten kayıtlı");
                    }
                }
                else
                {

                    komut.Connection = veritabani.baglanti;
                    komut.CommandText = "insert into dersler(ders_ad)values('" + textBox12.Text.ToUpper() + "')";
                    komut.ExecuteNonQuery();
                    MessageBox.Show("KAYIT EKLENDİ");
                    ds.Clear();
                    listeleders();
                    listele();
                    listele3();
                    listele4();
                    listele5();
                    listele6();
                    listele9();
                    listele10();
                    listeleodev();
                    listeleders();
                    listeledersprogrami();
                    veritabani.BaglantiKontrol();
                }
            }
            //}
            //catch (Exception)
            //{

            //    MessageBox.Show("BİR HATA OLUŞTU SİSTEM YÖNETİCİSE BAŞVURUN", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }

        private void button21_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult a;
                a = MessageBox.Show("Silmek istediğinizden emin misiniz?", "Uyarı!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (a == DialogResult.Yes)
                {
                    if (textBox8.Text != "")
                    {
                        baglanti.Open();
                        komut.Connection = baglanti;
                        komut.CommandText = "Delete from dersler where ders_id=" +textBox8.Text + "";
                        komut.ExecuteNonQuery();
                        MessageBox.Show("KAYIT SİLİNDİ");
                        baglanti.Close();
                        komut.Dispose();
                        ds.Clear();
                        listeleders();
                        listele();
                        listele3();
                        listele4();
                        listele5();
                        listele6();
                        listele9();
                        listele10();
                        listeleodev();
                        listeleders();
                        listeledersprogrami();
                    }
                    else
                    {
                        MessageBox.Show("ID alanı boş geçilemez");
                    }
                }
                

            }
            catch (Exception)
            {

                MessageBox.Show("BİR HATA OLUŞTU SİSTEM YÖNETİCİSE BAŞVURUN", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void texteskisifre2_TextChanged(object sender, EventArgs e)
        {
            if (texteskisifre2.Text=="")
            {
                pictureBox2.Image=null;
            }
        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {
            textBox12.Text = textBox12.Text.ToUpper();
        }

        private void button23_Click(object sender, EventArgs e)
        {
            veritabani.BaglantiKontrol();
            adtr = new OleDbDataAdapter("Select *from devamsizlik where ogr_no like '" + textBox13.Text + "%'", veritabani.baglanti);
            ds = new DataSet();
            adtr.Fill(ds, "devamsizlik");
            dataGridView7.DataSource = ds.Tables["devamsizlik"];
            veritabani.BaglantiKontrol();
        }

        private void button22_Click(object sender, EventArgs e)
        {
            ds.Clear();
            listele();
            listele3();
            listele4();
            listele5();
            listele6();
            listele9();
            listele10();
            listeleodev();
            listeleders();
        }

        private void textBoxTc_TextChanged(object sender, EventArgs e)
        {
            if (textBoxTc.TextLength > 11)
            {
                MessageBox.Show("11 Haneli TC kimlik no girin", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            if (textBox9.Text!="")
            {
                veritabani.BaglantiKontrol();
                komut.Connection = veritabani.baglanti;
                komut.CommandText = "update guvenliksoru set cevap='" + textBox9.Text + "'";
                komut.ExecuteNonQuery();
                MessageBox.Show("BAŞARILI", "KAYIT BAŞARIYLA GÜNCELLENDİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                veritabani.BaglantiKontrol();
                ds.Clear();
                listele();
                listele3();
                listele4();
                listele5();
                listele6();
                listele9();
                listele10();
                listeleodev();
                listeleders();
                listeledersprogrami();
            }
            else
            {
                MessageBox.Show("Boş alan geçmeyin");
            }
            
        }

        private void sİLToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void button14_Click(object sender, EventArgs e)
        {

        }

        private void button24_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox14.Text != "")
                {
                    veritabani.BaglantiKontrol();
                    OleDbCommand komut12 = new OleDbCommand("select * from belgeler", veritabani.baglanti);
                    OleDbDataReader oku12 = komut12.ExecuteReader();
                    while (oku12.Read())
                    {
                        belgeara.Add(oku12["ogr_no"].ToString());
                    }
                    var aranan3 = textBox14.Text;
                    if (belgeara.IndexOf(aranan3) != -1)
                    {
                        int sira4 = belgeara.IndexOf(aranan3);
                        label64.Text = belgeara[sira4].ToString();
                        if (aranan3 == label64.Text)
                        {
                            adtr = new OleDbDataAdapter("Select *from belgeler where ogr_no like '" + textBox14.Text + "%'",veritabani.baglanti);
                            ds = new DataSet();
                            adtr.Fill(ds, "belgeler");
                            dataGridView6.DataSource = ds.Tables["belgeler"];
                            textBox14.Clear();
                        }

                    }
                    else
                    {
                        MessageBox.Show("Öğrenci Bulunamadı");
                    }
                    veritabani.BaglantiKontrol();
                }
                else
                {
                    MessageBox.Show("Öğrenci No Boş Geçilemez!");
                }
            }
            catch (Exception)
            {

                MessageBox.Show("BİR HATA OLUŞTU SİSTEM YÖNETİCİSE BAŞVURUN", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button25_Click(object sender, EventArgs e)
        {
            ds.Clear();
            listele();
            listele3();
            listele4();
            listele5();
            listele6();
            listele9();
            listele10();
            listeleodev();
            listeleders();
            listeledersprogrami();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar>=47&&(int)e.KeyChar<=57)
            {
                e.Handled = false;
            }
            else if((int)e.KeyChar==8)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                MessageBox.Show("Harf girişi yasaktır!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBoxAd_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsSeparator(e.KeyChar);
            MessageBox.Show("Sayı girişi yasaktır!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void textBoxSoyad_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsSeparator(e.KeyChar);
            MessageBox.Show("Sayı girişi yasaktır!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void textBoxTc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar >= 47 && (int)e.KeyChar <= 57)
            {
                e.Handled = false;
            }
            else if ((int)e.KeyChar == 8)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                MessageBox.Show("Harf girişi yasaktır!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBoxOkulno_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar >= 47 && (int)e.KeyChar <= 57)
            {
                e.Handled = false;
            }
            else if ((int)e.KeyChar == 8)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                MessageBox.Show("Harf girişi yasaktır!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textara_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar >= 47 && (int)e.KeyChar <= 57)
            {
                e.Handled = false;
            }
            else if ((int)e.KeyChar == 8)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                MessageBox.Show("Harf girişi yasaktır!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBoxsil_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar >= 47 && (int)e.KeyChar <= 57)
            {
                e.Handled = false;
            }
            else if ((int)e.KeyChar == 8)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                MessageBox.Show("Harf girişi yasaktır!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBox11_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar >= 47 && (int)e.KeyChar <= 57)
            {
                e.Handled = false;
            }
            else if ((int)e.KeyChar == 8)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                MessageBox.Show("Harf girişi yasaktır!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textsozlu1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar >= 47 && (int)e.KeyChar <= 57)
            {
                e.Handled = false;
            }
            else if ((int)e.KeyChar == 8)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                MessageBox.Show("Harf girişi yasaktır!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textsozlu2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar >= 47 && (int)e.KeyChar <= 57)
            {
                e.Handled = false;
            }
            else if ((int)e.KeyChar == 8)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                MessageBox.Show("Harf girişi yasaktır!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBox12_KeyPress(object sender, KeyPressEventArgs e)
        {
            //e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsSeparator(e.KeyChar);
            //MessageBox.Show("Sayı girişi yasaktır!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void textBox8_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar >= 47 && (int)e.KeyChar <= 57)
            {
                e.Handled = false;
            }
            else if ((int)e.KeyChar == 8)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                MessageBox.Show("Harf girişi yasaktır!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar >= 47 && (int)e.KeyChar <= 57)
            {
                e.Handled = false;
            }
            else if ((int)e.KeyChar == 8)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                MessageBox.Show("Harf girişi yasaktır!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBox13_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar >= 47 && (int)e.KeyChar <= 57)
            {
                e.Handled = false;
            }
            else if ((int)e.KeyChar == 8)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                MessageBox.Show("Harf girişi yasaktır!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBox10_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar >= 47 && (int)e.KeyChar <= 57)
            {
                e.Handled = false;
            }
            else if ((int)e.KeyChar == 8)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                MessageBox.Show("Harf girişi yasaktır!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBoxID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar >= 47 && (int)e.KeyChar <= 57)
            {
                e.Handled = false;
            }
            else if ((int)e.KeyChar == 8)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                MessageBox.Show("Harf girişi yasaktır!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar >= 47 && (int)e.KeyChar <= 57)
            {
                e.Handled = false;
            }
            else if ((int)e.KeyChar == 8)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                MessageBox.Show("Harf girişi yasaktır!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBox14_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar >= 47 && (int)e.KeyChar <= 57)
            {
                e.Handled = false;
            }
            else if ((int)e.KeyChar == 8)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                MessageBox.Show("Harf girişi yasaktır!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar >= 47 && (int)e.KeyChar <= 57)
            {
                e.Handled = false;
            }
            else if ((int)e.KeyChar == 8)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                MessageBox.Show("Harf girişi yasaktır!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBox7_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar >= 47 && (int)e.KeyChar <= 57)
            {
                e.Handled = false;
            }
            else if ((int)e.KeyChar == 8)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                MessageBox.Show("Harf girişi yasaktır!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox2.Text = listBox2.SelectedItem.ToString();
        }

        private void listBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox3.Text == "PAZARTESİ")
            {
               
                comboBox14.Text = dataGridView9.Rows[0].Cells[1].Value.ToString();
                comboBox13.Text = dataGridView9.Rows[0].Cells[2].Value.ToString();
                comboBox12.Text = dataGridView9.Rows[0].Cells[3].Value.ToString();
                comboBox11.Text = dataGridView9.Rows[0].Cells[4].Value.ToString();
                comboBox10.Text = dataGridView9.Rows[0].Cells[5].Value.ToString();
                comboBox9.Text = dataGridView9.Rows[0].Cells[6].Value.ToString();
                comboBox7.Text = dataGridView9.Rows[0].Cells[7].Value.ToString();
                comboBox8.Text = dataGridView9.Rows[0].Cells[8].Value.ToString();
            }

            if (listBox3.Text == "SALI")
            {
                
                comboBox14.Text = dataGridView9.Rows[2].Cells[1].Value.ToString();
                comboBox13.Text = dataGridView9.Rows[2].Cells[2].Value.ToString();
                comboBox12.Text = dataGridView9.Rows[2].Cells[3].Value.ToString();
                comboBox11.Text = dataGridView9.Rows[2].Cells[4].Value.ToString();
                comboBox10.Text = dataGridView9.Rows[2].Cells[5].Value.ToString();
                comboBox9.Text = dataGridView9.Rows[2].Cells[6].Value.ToString();
                comboBox7.Text = dataGridView9.Rows[2].Cells[7].Value.ToString();
                comboBox8.Text = dataGridView9.Rows[2].Cells[8].Value.ToString();

            }
            if (listBox3.Text == "CARSAMBA")
            {
              
                comboBox14.Text = dataGridView9.Rows[4].Cells[1].Value.ToString();
                comboBox13.Text = dataGridView9.Rows[4].Cells[2].Value.ToString();
                comboBox12.Text = dataGridView9.Rows[4].Cells[3].Value.ToString();
                comboBox11.Text = dataGridView9.Rows[4].Cells[4].Value.ToString();
                comboBox10.Text = dataGridView9.Rows[4].Cells[5].Value.ToString();
                comboBox9.Text = dataGridView9.Rows[4].Cells[6].Value.ToString();
                comboBox7.Text = dataGridView9.Rows[4].Cells[7].Value.ToString();
                comboBox8.Text = dataGridView9.Rows[4].Cells[8].Value.ToString();

            }
            if (listBox3.Text == "PERSEMBE")
            {
           
                comboBox14.Text = dataGridView9.Rows[6].Cells[1].Value.ToString();
                comboBox13.Text = dataGridView9.Rows[6].Cells[2].Value.ToString();
                comboBox12.Text = dataGridView9.Rows[6].Cells[3].Value.ToString();
                comboBox11.Text = dataGridView9.Rows[6].Cells[4].Value.ToString();
                comboBox10.Text = dataGridView9.Rows[6].Cells[5].Value.ToString();
                comboBox9.Text = dataGridView9.Rows[6].Cells[6].Value.ToString();
                comboBox7.Text = dataGridView9.Rows[6].Cells[7].Value.ToString();
                comboBox8.Text = dataGridView9.Rows[6].Cells[8].Value.ToString();
            }

            if (listBox3.Text == "CUMA")
            {
          
                comboBox14.Text = dataGridView9.Rows[8].Cells[1].Value.ToString();
                comboBox13.Text = dataGridView9.Rows[8].Cells[2].Value.ToString();
                comboBox12.Text = dataGridView9.Rows[8].Cells[3].Value.ToString();
                comboBox11.Text = dataGridView9.Rows[8].Cells[4].Value.ToString();
                comboBox10.Text = dataGridView9.Rows[8].Cells[5].Value.ToString();
                comboBox9.Text = dataGridView9.Rows[8].Cells[6].Value.ToString();
                comboBox7.Text = dataGridView9.Rows[8].Cells[7].Value.ToString();
                comboBox8.Text = dataGridView9.Rows[8].Cells[8].Value.ToString();


            }
            if (listBox3.Text == "")
            {
               
                comboBox14.Text = "";
                comboBox13.Text = "";
                comboBox12.Text = "";
                comboBox11.Text = "";
                comboBox10.Text = "";
                comboBox9.Text = "";
                comboBox7.Text = "";
                comboBox8.Text = "";
            }
        }

        private void button26_Click(object sender, EventArgs e)
        {
            veritabani.BaglantiKontrol();
            if (checkBox1.Checked == true)
            {
                OleDbCommand güncelle = new OleDbCommand("update dersprogrami set Ders1='" + comboBox14.Text + "' where Gün ='" + listBox3.Text + "'", veritabani.baglanti);
                güncelle.ExecuteNonQuery();
                ds.Clear();
                listele();
                listele3();
                listele4();
                listele5();
                listele6();
                listele9();
                listele10();
                listeleodev();
                listeleders();
                listeledersprogrami();

            }
            if (checkBox2.Checked == true)
            {
                OleDbCommand güncelle = new OleDbCommand("update dersprogrami set Ders2='" + comboBox13.Text + "' where Gün ='" + listBox3.Text + "'", veritabani.baglanti);
                güncelle.ExecuteNonQuery();
                ds.Clear();
                listele();
                listele3();
                listele4();
                listele5();
                listele6();
                listele9();
                listele10();
                listeleodev();
                listeleders();
                listeledersprogrami();
            }
            if (checkBox3.Checked == true)
            {
                OleDbCommand güncelle = new OleDbCommand("update dersprogrami set Ders3='" + comboBox12.Text + "' where Gün ='" + listBox3.Text + "'", veritabani.baglanti);
                güncelle.ExecuteNonQuery();
                ds.Clear();
                listele();
                listele3();
                listele4();
                listele5();
                listele6();
                listele9();
                listele10();
                listeleodev();
                listeleders();
                listeledersprogrami();
            }
            if (checkBox4.Checked == true)
            {
                OleDbCommand güncelle = new OleDbCommand("update dersprogrami set Ders4='" + comboBox11.Text + "' where Gün ='" + listBox3.Text + "'", veritabani.baglanti);
                güncelle.ExecuteNonQuery();
                ds.Clear();
                listele();
                listele3();
                listele4();
                listele5();
                listele6();
                listele9();
                listele10();
                listeleodev();
                listeleders();
                listeledersprogrami();
            }
            if (checkBox5.Checked == true)
            {
                OleDbCommand güncelle = new OleDbCommand("update dersprogrami set Ders5='" + comboBox10.Text + "' where Gün ='" + listBox3.Text + "'", veritabani.baglanti);
                güncelle.ExecuteNonQuery();
                ds.Clear();
                listele();
                listele3();
                listele4();
                listele5();
                listele6();
                listele9();
                listele10();
                listeleodev();
                listeleders();
                listeledersprogrami();
            }
            if (checkBox6.Checked == true)
            {
                OleDbCommand güncelle = new OleDbCommand("update dersprogrami set Ders6='" + comboBox9.Text + "' where Gün ='" + listBox3.Text + "'", veritabani.baglanti);
                güncelle.ExecuteNonQuery();
                ds.Clear();
                listele();
                listele3();
                listele4();
                listele5();
                listele6();
                listele9();
                listele10();
                listeleodev();
                listeleders();
                listeledersprogrami();
            }
            if (checkBox7.Checked == true)
            {
                OleDbCommand güncelle = new OleDbCommand("update dersprogrami set Ders7='" + comboBox7.Text + "' where Gün ='" + listBox3.Text + "'", veritabani.baglanti);
                güncelle.ExecuteNonQuery();
                ds.Clear();
                listele();
                listele3();
                listele4();
                listele5();
                listele6();
                listele9();
                listele10();
                listeleodev();
                listeleders();
                listeledersprogrami();
            }
            if (checkBox8.Checked == true)
            {
                OleDbCommand güncelle = new OleDbCommand("update dersprogrami set Ders8='" + comboBox8.Text + "' where gün ='" + listBox3.Text + "'", veritabani.baglanti);
                güncelle.ExecuteNonQuery();
                ds.Clear();
                listele();
                listele3();
                listele4();
                listele5();
                listele6();
                listele9();
                listele10();
                listeleodev();
                listeleders();
                listeledersprogrami();
            }
            veritabani.BaglantiKontrol();

        }

        private void checkBox11_CheckedChanged(object sender, EventArgs e)
        {
            try
            {

                //checkBox12.Checked = false;
                checkBox1.Checked = true;
                checkBox2.Checked = true;
                checkBox3.Checked = true;
                checkBox4.Checked = true;
                checkBox5.Checked = true;
                checkBox6.Checked = true;
                checkBox7.Checked = true;
                checkBox8.Checked = true;


            }

            catch
            {
                MessageBox.Show("Mantıksız Bira Hata Oluştu");
            }
        }

        private void checkBox12_CheckedChanged(object sender, EventArgs e)
        {

            try
            {
                checkBox11.Checked = false;
                checkBox1.Checked = false;
                checkBox2.Checked = false;
                checkBox3.Checked = false;
                checkBox4.Checked = false;
                checkBox5.Checked = false;
                checkBox6.Checked = false;
                checkBox7.Checked = false;
                checkBox8.Checked = false;

            }
            catch
            {
                MessageBox.Show("Mantıksız Bira Hata Oluştu");
            }
        }

        private void textyazili1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (textyazili2.Text == string.Empty || textsozlu1.Text == string.Empty || textsozlu2.Text == string.Empty)
                {
                    return;
                }

                y1 = Convert.ToDouble(textyazili1.Text);
                y2 = Convert.ToDouble(textyazili2.Text);
                s1 = Convert.ToDouble(textsozlu1.Text);
                s2 = Convert.ToDouble(textsozlu2.Text);
                ort = (y1 + y2 + s1 + s2) / 4;
                label39.Text = ort.ToString();
            }
            catch (Exception)
            {

                MessageBox.Show("BİR HATA OLUŞTU SİSTEM YÖNETİCİSE BAŞVURUN", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void textyazili2_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (textyazili1.Text == string.Empty || textsozlu1.Text == string.Empty || textsozlu2.Text == string.Empty)
                {
                    return;
                }

                y1 = Convert.ToDouble(textyazili1.Text);
                y2 = Convert.ToDouble(textyazili2.Text);
                s1 = Convert.ToDouble(textsozlu1.Text);
                s2 = Convert.ToDouble(textsozlu2.Text);
                ort = (y1 + y2 + s1 + s2) / 4;
                label39.Text = ort.ToString();
            }
            catch (Exception)
            {


                MessageBox.Show("BİR HATA OLUŞTU SİSTEM YÖNETİCİSE BAŞVURUN", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }

        private void textsozlu1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (textyazili2.Text == string.Empty || textyazili1.Text == string.Empty || textsozlu2.Text == string.Empty)
                {
                    return;
                }

                y1 = Convert.ToDouble(textyazili1.Text);
                y2 = Convert.ToDouble(textyazili2.Text);
                s1 = Convert.ToDouble(textsozlu1.Text);
                s2 = Convert.ToDouble(textsozlu2.Text);
                ort = (y1 + y2 + s1 + s2) / 4;
                label39.Text = ort.ToString();
            }
            catch (Exception)
            {

                MessageBox.Show("BİR HATA OLUŞTU SİSTEM YÖNETİCİSE BAŞVURUN", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void textsozlu2_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (textyazili2.Text == string.Empty || textsozlu1.Text == string.Empty || textyazili1.Text == string.Empty)
                {
                    return;
                }

                y1 = Convert.ToDouble(textyazili1.Text);
                y2 = Convert.ToDouble(textyazili2.Text);
                s1 = Convert.ToDouble(textsozlu1.Text);
                s2 = Convert.ToDouble(textsozlu2.Text);
                ort = (y1 + y2 + s1 + s2) / 4;
                label39.Text = ort.ToString();
            }
            catch (Exception)
            {

                MessageBox.Show("BİR HATA OLUŞTU SİSTEM YÖNETİCİSE BAŞVURUN", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
    }
}
