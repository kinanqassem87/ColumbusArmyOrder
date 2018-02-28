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
    public partial class FRM_NewMilitaryP : Form
    {
        public FRM_NewMilitaryP()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtName.Text.Equals(""))
            {
                MessageBox.Show("Please Fill Fields.");
            }
            else 
            {
                int i = ClassMilitaryPieces.sp_addMilitaryP(txtName.Text, rtxtDesc.Text);
                MessageBox.Show("Done");
                txtName.Text = rtxtDesc.Text = "";
            }
        }
    }
}
