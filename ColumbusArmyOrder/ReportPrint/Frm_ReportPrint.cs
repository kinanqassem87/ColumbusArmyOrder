using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ColumbusArmyOrder.ReportPrint
{
    public partial class Frm_ReportPrint : Form
    {
        public Frm_ReportPrint()
        {
            InitializeComponent();
        }

        private void Frm_ReportPrint_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }
    }
}
