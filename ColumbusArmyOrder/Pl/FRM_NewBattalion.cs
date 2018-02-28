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
    public partial class FRM_NewBattalion : Form
    {
        public FRM_NewBattalion()
        {
            InitializeComponent();
            fillcmb();
        }
        void fillcmb() 
        {
            DataTable dt = ClassBrigade.fillBrigade();
            for (int i = 0; i < dt.Rows.Count; i++) 
            {
                cmbBrigade.Items.Add(dt.Rows[i][1].ToString());
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmbBrigade_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = ClassBrigade.cmbchangeBrigades(cmbBrigade.Text);
            txtID.Text = dt.Rows[0][0].ToString();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (txtID.Text.Equals("") || txtName.Text.Equals(""))
            {
                MessageBox.Show("Please Fill Fields");
            }
            else 
            {
                int i = ClassBrigade.AddNewBattlion(int.Parse(txtID.Text), txtName.Text, rtxtDescrip.Text);
                txtName.Text = rtxtDescrip.Text = "";
                MessageBox.Show("Done");
            }
        }

      
    }
}
