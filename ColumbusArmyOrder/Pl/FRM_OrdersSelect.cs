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
    public partial class FRM_OrdersSelect : Form
    {
        public FRM_OrdersSelect()
        {
            InitializeComponent();
            dgvOrder.DataSource = ClassBill.sp_orders(FRM_Bill.code);
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            dgvOrder.DataSource = ClassBill.sp_SearchOrders(txtSearch.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                FRM_OrderDtetails o = new FRM_OrderDtetails(dgvOrder.CurrentRow.Cells[0].Value.ToString());
                o.ShowDialog();
            }
            catch (Exception) { }
        }

        private void dgvOrder_DoubleClick(object sender, EventArgs e)
        {
            Close();
        }
    }
}
