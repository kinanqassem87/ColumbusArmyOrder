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
    public partial class FRM_NewRegiment : Form
    {
        public FRM_NewRegiment()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtNameR.Text.Equals(""))
            {
                MessageBox.Show("Please Fill Fields");
            }
            else 
            {
                int i = ClassRegiments.sp_addnewRegiment(txtNameR.Text, rtxtDesc.Text);
                MessageBox.Show("Done");
                txtNameR.Text = rtxtDesc.Text = "";
            }
        }
    }
}
