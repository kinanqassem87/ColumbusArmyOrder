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
    public partial class FRM_SararyaManagR : Form
    {
        public FRM_SararyaManagR()
        {
            InitializeComponent();
            display();
        }
        void display() 
        {
            dgvSaraya.DataSource = ClassRegiments.sp_allSarayaR();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            dgvSaraya.DataSource = ClassRegiments.sp_SearchSarayaR(txtSearch.Text);
        }

        private void dgvSaraya_DoubleClick(object sender, EventArgs e)
        {
            txtid.Text = dgvSaraya.CurrentRow.Cells[0].Value.ToString();
            txtname.Text = dgvSaraya.CurrentRow.Cells[1].Value.ToString();
            rtxtDescrip.Text = dgvSaraya.CurrentRow.Cells[2].Value.ToString();
            txtRegName.Text = dgvSaraya.CurrentRow.Cells[3].Value.ToString();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtid.Text.Equals("") || txtname.Text.Equals(""))
            {
                MessageBox.Show("Please Select One.");
            }
            else 
            {
                int i = ClassRegiments.sp_updateSarayaR(int.Parse(txtid.Text), txtname.Text, rtxtDescrip.Text);
                MessageBox.Show("Done");
                txtid.Text = txtname.Text = txtRegName.Text = rtxtDescrip.Text = "";
                display();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtid.Text.Equals(""))
            {
                MessageBox.Show("Select One Please.");
            }
            else 
            {
                int i = ClassRegiments.sp_deleteSarayaR(int.Parse(txtid.Text));
                MessageBox.Show("Done");
                txtid.Text = txtname.Text = txtRegName.Text = rtxtDescrip.Text = "";
                display();
            }
        }
       
    }
}
