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
    public partial class FRM_NewSarayaR : Form
    {
        public FRM_NewSarayaR()
        {
            InitializeComponent();
            fillcombo();
        }
        void fillcombo() 
        {
            DataTable dt = ClassRegiments.sp_allRegiment();
            cmbRegiment.DataSource = dt;
            cmbRegiment.ValueMember = "ID";
            cmbRegiment.DisplayMember = "Name";
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (txtName.Text.Equals(""))
            {
                MessageBox.Show("Please Fill Fields.");
            }
            else 
            {
                int i = ClassRegiments.sp_newSarayaR(txtName.Text, rtxtDescrip.Text, (int)cmbRegiment.SelectedValue);
                MessageBox.Show("Done");
                txtName.Text = rtxtDescrip.Text = "";

            }
        }
    }
}
