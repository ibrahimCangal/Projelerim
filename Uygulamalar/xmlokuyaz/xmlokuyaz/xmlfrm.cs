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

namespace xmlokuyaz
{
    public partial class xmlfrm : Form
    {
        public xmlfrm()
        {
            InitializeComponent();
        }

        private void kaydetbtn_Click(object sender, EventArgs e)
        {
            OleDbConnection odcon = new OleDbConnection();
            odcon.ConnectionString = "Provider = Microsoft.ACE.OLEDB.12.0; Data Source = veri.accdb; Persist Security Info = False;";
            odcon.Open();

            String sorgu = "insert into ogrenci values('" + numaratxt.Text + "','" + adsoyadtxt.Text + "','" + bolumtxt.Text + "')";
            OleDbCommand odcom = new OleDbCommand();
            odcom.Connection = odcon;
            odcom.CommandText = sorgu;
            odcom.ExecuteNonQuery();
            odcon.Close();
        }

        private void xmlyazbtn_Click(object sender, EventArgs e)
        {
            OleDbConnection odcon = new OleDbConnection();
            odcon.ConnectionString = "Provider = Microsoft.ACE.OLEDB.12.0; Data Source = veri.accdb; Persist Security Info = False;";
            odcon.Open();

            String sorgu = "select * from ogrenci";
            OleDbDataAdapter oda = new OleDbDataAdapter(sorgu, odcon);
            DataSet ds = new DataSet();
            oda.Fill(ds);
            ds.WriteXml("veriler.xml");
            
            odcon.Close();
        }

        private void okubtn_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            ds.ReadXml("veriler.xml");
            xmlverdgv.DataSource = ds.Tables[0];
        }
    }
}
