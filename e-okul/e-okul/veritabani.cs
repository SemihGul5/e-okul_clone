using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;
using System.Windows.Forms;
using System.Data;

namespace e_okul
{
    public static class veritabani
    {
        public static OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=data.accdb");

        public static void BaglantiKontrol()

        {
            if (baglanti.State == ConnectionState.Closed)
            {
                baglanti.Open();

            }
            else
            {
                baglanti.Close();
            }

        }
    }
}
