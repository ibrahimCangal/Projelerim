using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Threading
{
    public partial class threadfrm : Form
    {
        Thread t1, t2;
        public threadfrm()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
        }

        public void sayac1()
        {
            for (int i = 0; i <= 1000; i++)
            {
                sayac1lbl.Text = i.ToString();
                Thread.Sleep(100);
                if (i == 1000)
                {
                    i = 0;
                }
            }
        }

        public void sayac2()
        {
            for (int i = 0; i <= 1000; i++)
            {
                sayac2lbl.Text = i.ToString();
                Thread.Sleep(100);
                if (i == 1000)
                {
                    i = 0;
                }
            }
        }
        private void baslatbtn_Click(object sender, EventArgs e)
        {
            t1 = new Thread(new ThreadStart(sayac1));
            t2 = new Thread(new ThreadStart(sayac2));
            t1.Start();
            t2.Start();
        }

        private void durbtn_Click(object sender, EventArgs e)
        {
            t1.Abort();
            t2.Abort();
        }
    }
}
