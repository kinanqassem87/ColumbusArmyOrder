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
    public partial class FRM_SarayaManagmentBri : Form
    {
        public FRM_SarayaManagmentBri()
        {
            InitializeComponent();
            display();
           
        }
        void display() 
        {
            dgvSaraya.DataSource = ClassBrigade.sp_allSaraya();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            dgvSaraya.DataSource = ClassBrigade.sp_searchSaraya(txtSearch.Text);
        }

        private void cmbBrigade_Click(object sender, EventArgs e)
        {
           
        }

        private void cmbBrigade_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void dgvSaraya_DoubleClick(object sender, EventArgs e)
        {
            txtid.Text = dgvSaraya.CurrentRow.Cells[0].Value.ToString();
            txtname.Text = dgvSaraya.CurrentRow.Cells[1].Value.ToString();
            rtxtDescrip.Text = dgvSaraya.CurrentRow.Cells[2].Value.ToString();
            txtBriName.Text = dgvSaraya.CurrentRow.Cells[3].Value.ToString();
            txtBatName.Text = dgvSaraya.CurrentRow.Cells[4].Value.ToString();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtid.Text.Equals("") || txtname.Text.Equals(""))
            {
                MessageBox.Show("Please Fill Fields.");
            }
            else 
            {
                int i = ClassBrigade.sp_updatesarayab(int.Parse(txtid.Text), txtname.Text, rtxtDescrip.Text);
                MessageBox.Show("Done");
                txtname.Text = txtid.Text = rtxtDescrip.Text = txtBatName.Text=txtBriName.Text="";
                display();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtid.Text.Equals(""))
            {
                MessageBox.Show("Please Select One.");
            }
            else 
            {
                int i = ClassBrigade.sp_deletesarayab(int.Parse(txtid.Text));
                MessageBox.Show("Done");
                txtid.Text = txtBatName.Text = txtBriName.Text = txtname.Text = rtxtDescrip.Text = "";
                display();
            }
        }
        
    }
}
