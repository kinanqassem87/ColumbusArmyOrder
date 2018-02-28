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
    public partial class FRM_RegimentManagment : Form
    {
        public FRM_RegimentManagment()
        {
            InitializeComponent();
            display();
        }
        void display() 
        {
            dgvRegiment.DataSource = ClassRegiments.sp_allRegiment();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            dgvRegiment.DataSource = ClassRegiments.sp_searchRegiment(txtSearch.Text);
        }

        private void dgvRegiment_DoubleClick(object sender, EventArgs e)
        {
            txtid.Text = dgvRegiment.CurrentRow.Cells[0].Value.ToString();
            txtname.Text = dgvRegiment.CurrentRow.Cells[1].Value.ToString();
            rtxtDescrip.Text = dgvRegiment.CurrentRow.Cells[2].Value.ToString();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtid.Text.Equals("") || txtname.Text.Equals(""))
            {
                MessageBox.Show("Please Select one.");
            }
            else 
            {
                int i = ClassRegiments.sp_updateRegiment(int.Parse(txtid.Text), txtname.Text, rtxtDescrip.Text);
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
                int i = ClassRegiments.sp_deleteRegiment(int.Parse(txtid.Text));
                MessageBox.Show("Done");
                txtid.Text = txtname.Text = rtxtDescrip.Text = "";
                display();
            }
        }
    }
}
