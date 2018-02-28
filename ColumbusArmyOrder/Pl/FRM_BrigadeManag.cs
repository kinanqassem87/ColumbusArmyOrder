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
    public partial class FRM_BrigadeManag : Form
    {
        public FRM_BrigadeManag()
        {
            InitializeComponent();
            display();
        }
        void display() 
        {
           dgvBrigade.DataSource=ClassBrigade.allBrigade();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            dgvBrigade.DataSource = ClassBrigade.searchBrigade(txtSearch.Text);
        }

        private void dgvBrigade_DoubleClick(object sender, EventArgs e)
        {
            txtid.Text = dgvBrigade.CurrentRow.Cells[0].Value.ToString();
            txtname.Text = dgvBrigade.CurrentRow.Cells[1].Value.ToString();
            rtxtDescrip.Text = dgvBrigade.CurrentRow.Cells[2].Value.ToString();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtid.Text.Equals("") || txtname.Text.Equals(""))
            {
                MessageBox.Show("Please select one.");
            }
            else 
            {
                int i = ClassBrigade.UpdateBrigade(int.Parse(txtid.Text), txtname.Text, rtxtDescrip.Text);
                MessageBox.Show("Done");
                txtid.Text = txtname.Text = rtxtDescrip.Text = "";
                display();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtid.Text.Equals(""))
            {
                MessageBox.Show("Please Select One.");
            }
            else 
            {
                int i = ClassBrigade.DeleteBrigade(int.Parse(txtid.Text));
                MessageBox.Show("Done");
                txtid.Text = txtname.Text = rtxtDescrip.Text = "";
                display();
            }
        }
    }
}
