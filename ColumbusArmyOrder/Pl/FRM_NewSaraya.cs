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
    public partial class FRM_NewSaraya : Form
    {
        public FRM_NewSaraya()
        {
            InitializeComponent();
            DataTable dt1=ClassBrigade.fillBrigade();
            cmbBrigade.DataSource = dt1;
            cmbBrigade.DisplayMember = "Brigades_name";
            cmbBrigade.ValueMember = "Brigades_id";

            DataTable dt = ClassBrigade.sp_fillBattalion(cmbBrigade.Text);
            cmbBattalion.DataSource = dt;
            cmbBattalion.DisplayMember = "Battalions_name";
            cmbBattalion.ValueMember = "Battalions_id";
            
        }

        

        private void cmbBrigade_Click(object sender, EventArgs e)
        {
            DataTable dt = ClassBrigade.sp_fillBattalion(cmbBrigade.Text);
            cmbBattalion.DataSource = dt;
            cmbBattalion.DisplayMember = "Battalions_name";
            cmbBattalion.ValueMember = "Battalions_id";
        }

        private void cmbBrigade_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = ClassBrigade.sp_fillBattalion(cmbBrigade.Text);
            cmbBattalion.DataSource = dt;
            cmbBattalion.DisplayMember = "Battalions_name";
            cmbBattalion.ValueMember = "Battalions_id";
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtname.Text.Equals("") || cmbBrigade.Text.Equals("") || cmbBattalion.Text.Equals(""))
            {
                MessageBox.Show("Fill Fields Please.");
            }
            else 
            {
                int i = ClassBrigade.sp_addsaraya(txtname.Text, rtxtDescrip.Text, (int)cmbBrigade.SelectedValue, (int)cmbBattalion.SelectedValue);
                MessageBox.Show("Done");
                txtname.Text = rtxtDescrip.Text = "";
            }
        }
    }
}
