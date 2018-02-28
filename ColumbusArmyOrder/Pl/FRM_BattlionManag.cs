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
    public partial class FRM_BattlionManag : Form
    {
        
        public FRM_BattlionManag()
        {
            InitializeComponent();
            display();
        }
        void display() 
        {
            dgvBattalion.DataSource = ClassBrigade.sp_allBattalion();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            dgvBattalion.DataSource = ClassBrigade.sp_searchBattalion(txtSearch.Text);
        }

        private void dgvBattalion_DoubleClick(object sender, EventArgs e)
        {
            txtid.Text = dgvBattalion.CurrentRow.Cells[0].Value.ToString();
            txtname.Text = dgvBattalion.CurrentRow.Cells[1].Value.ToString();
            rtxtDescrip.Text = dgvBattalion.CurrentRow.Cells[2].Value.ToString();
            txtBriName.Text = dgvBattalion.CurrentRow.Cells[3].Value.ToString();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtid.Text.Equals("") || txtname.Text.Equals(""))
            {
                MessageBox.Show("Please Fill Fields");
            }
            else 
            {
                int i=ClassBrigade.sp_addbattalion(int.Parse(txtid.Text),txtname.Text,rtxtDescrip.Text);
                MessageBox.Show("Done");
                txtid.Text = txtname.Text = rtxtDescrip.Text = txtBriName.Text = "";
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
                int i = ClassBrigade.sp_delbattalion(int.Parse(txtid.Text));
                MessageBox.Show("Done");
                txtid.Text = txtname.Text = rtxtDescrip.Text =txtBriName.Text= "";
                display();
            }
        }

    }
}
