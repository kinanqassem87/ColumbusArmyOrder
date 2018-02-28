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
    public partial class Frm_ReportOrder : Form
    {
        public Frm_ReportOrder()
        {
            InitializeComponent();
        }

        private void Frm_ReportOrder_Load(object sender, EventArgs e)
        {
            this.reportViewer1.RefreshReport();
        }
    }
}
