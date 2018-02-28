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
    public partial class FRM_OrderDtetails : Form
    {
        public FRM_OrderDtetails(string ss)
        {
            InitializeComponent();
            try
            {
                dgvDetails.DataSource = ClassBill.sp_OrderDetailsSel(int.Parse(ss));
            }
            catch (Exception ex) { }
        }
    }
}
