using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace raporlama2
{
    public partial class raporfrm : Form
    {
        public raporfrm()
        {
            InitializeComponent();
        }

        private void raporlabtn_Click(object sender, EventArgs e)
        {
            rapor r1 = new rapor();
            CrystalDecisions.Shared.ParameterValues pv = new CrystalDecisions.Shared.ParameterValues();
            CrystalDecisions.Shared.ParameterDiscreteValue pd = new CrystalDecisions.Shared.ParameterDiscreteValue();
            pd.Value = urunaditxt.Text;
            pv.Add(pd);
            r1.DataDefinition.ParameterFields["urunAdi"].ApplyCurrentValues(pv);
            crystalReportViewer1.ReportSource = r1;

        }
    }
}
