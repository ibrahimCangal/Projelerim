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
using Newtonsoft.Json;
using System.IO;

namespace jsonokuyaz
{
    public partial class jsonfrm : Form
    {
        public jsonfrm()
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
            odcom.CommandText = sorgu;
            odcom.Connection = odcon;
            odcom.ExecuteNonQuery();
            odcon.Close();
        }

        private void jsonyazbtn_Click(object sender, EventArgs e)
        {
            OleDbConnection odcon = new OleDbConnection();
            odcon.ConnectionString = "Provider = Microsoft.ACE.OLEDB.12.0; Data Source = veri.accdb; Persist Security Info = False;";
            odcon.Open();
            String sorgu = "select * from ogrenci";
            OleDbDataAdapter oda = new OleDbDataAdapter(sorgu, odcon);
            DataSet ds = new DataSet();
            oda.Fill(ds);
            string json = JsonConvert.SerializeObject(ds, Formatting.Indented);
            File.WriteAllText("veriler.json", json);

            odcon.Close();
        }

        private void jsonokubtn_Click(object sender, EventArgs e)
        {
            String json = File.ReadAllText("veriler.json");
            DataSet ds = JsonConvert.DeserializeObject<DataSet>(json);
            jsonveridgv.DataSource = ds.Tables[0];
        }
    }
}
