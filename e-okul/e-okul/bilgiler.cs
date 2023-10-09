using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Windows.Forms;
using System.ComponentModel;
using System.Data;
using System.Drawing;

namespace e_okul
{
    class bilgiler
    {
       
        void baglantilar()
        {
            OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=data.accdb");
            OleDbCommand komut = new OleDbCommand();
            OleDbDataAdapter datr = new OleDbDataAdapter();
            DataSet ds = new DataSet();
        }
      
    }
}
