using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ColumbusArmyOrder.BL;

namespace ColumbusArmyOrder.Pl
{
    public partial class FRM_QuotationSelected : Form
    {
        public FRM_QuotationSelected()
        {
            InitializeComponent();
            dgvQuotations.DataSource = ClassOrder.sp_selectQuotaions(FRM_BriOrder.code);
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            dgvQuotations.DataSource = ClassOrder.sp_searchSelectedQuotaions(txtSearch.Text);
        }

        private void dgvQuotations_DoubleClick(object sender, EventArgs e)
        {
            Close();
        }

       
    }
}
