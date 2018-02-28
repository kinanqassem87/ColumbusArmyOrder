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
    public partial class FRM_MilitaryPManagment : Form
    {
        public FRM_MilitaryPManagment()
        {
            InitializeComponent();
            display();
        }
        void display() 
        {
            dgvMilitaryP.DataSource = ClassMilitaryPieces.sp_allMilitaryPieces();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            dgvMilitaryP.DataSource = ClassMilitaryPieces.sp_searchMilitaryPieces(txtSearch.Text);
        }

        private void dgvMilitaryP_DoubleClick(object sender, EventArgs e)
        {
            txtid.Text = dgvMilitaryP.CurrentRow.Cells[0].Value.ToString();
            txtname.Text = dgvMilitaryP.CurrentRow.Cells[1].Value.ToString();
            rtxtDescrip.Text = dgvMilitaryP.CurrentRow.Cells[2].Value.ToString();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtid.Text.Equals("") || txtname.Text.Equals(""))
            {
                MessageBox.Show("Please Select One.");
            }
            else 
            {
                int i = ClassMilitaryPieces.sp_UpdateMilitaryPieces(int.Parse(txtid.Text), txtname.Text, rtxtDescrip.Text);
                MessageBox.Show("Done");
                txtid.Text = txtname.Text = rtxtDescrip.Text = "";
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
                int i = ClassMilitaryPieces.sp_DeleteMilitaryPieces(int.Parse(txtid.Text));
                MessageBox.Show("Done");
                txtid.Text = txtname.Text = rtxtDescrip.Text = "";
                display();
            }
        }
    }
}
