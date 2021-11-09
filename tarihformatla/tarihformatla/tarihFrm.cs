using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tarihformatla
{
    public partial class tarihFrm : Form
    {
        public tarihFrm()
        {
            InitializeComponent();
        }

        private void ulkecmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            tarihFormat tf = new tarihFormat();
            if(ulkecmb.SelectedIndex==0)
            {
                sonuctxt.Text = tf.tarihTR(tarihdtp.Value, "Long");
            }
            else if (ulkecmb.SelectedIndex == 1)
            {
                sonuctxt.Text = tf.tarihTR(tarihdtp.Value, "Short");
            }
            else if (ulkecmb.SelectedIndex == 2)
            {
                sonuctxt.Text = tf.tarihTR(tarihdtp.Value, "Full");
            }
            else if (ulkecmb.SelectedIndex == 3)
            {
                sonuctxt.Text = tf.tarihUSA(tarihdtp.Value, "Full");
            }
            else if (ulkecmb.SelectedIndex == 4)
            {
                sonuctxt.Text = tf.tarihUSA(tarihdtp.Value, "NumericYF");
            }
            else if (ulkecmb.SelectedIndex == 5)
            {
                sonuctxt.Text = tf.tarihUSA(tarihdtp.Value, "NumericYL");
            }
            else if (ulkecmb.SelectedIndex == 6)
            {
                sonuctxt.Text = tf.tarihAR(tarihdtp.Value, "Numeric");
            }
            else if (ulkecmb.SelectedIndex == 7)
            {
                sonuctxt.Text = tf.tarihAR(tarihdtp.Value, "Short");
            }
            else if (ulkecmb.SelectedIndex == 8)
            {
                sonuctxt.Text = tf.tarihAR(tarihdtp.Value, "Medium");
            }
            else if (ulkecmb.SelectedIndex == 9)
            {
                sonuctxt.Text = tf.tarihAR(tarihdtp.Value, "Long");
            }
            else if (ulkecmb.SelectedIndex == 10)
            {
                sonuctxt.Text = tf.tarihAR(tarihdtp.Value, "Full");
            }
        }
    }
}
