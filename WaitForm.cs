using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EALogsViewer
{
    public partial class WaitForm : Form
    {
        public WaitForm()
        {
            InitializeComponent();
            label1.BackColor = Color.Transparent;
        }

        //public void SetIndeterminate()
        //{
        //    if (progressBar1.InvokeRequired)
        //    {
        //        progressBar1.BeginInvoke(new Action(() =>
        //        {
        //            progressBar1.Style = ProgressBarStyle.Marquee;
        //        }
        //        ));
        //    }
        //    else
        //    {
        //        progressBar1.Style = ProgressBarStyle.Marquee;
        //    }
        //}
    }
}
