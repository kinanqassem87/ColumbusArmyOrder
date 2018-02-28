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
    public partial class FRM_PhoneNumber : Form
    {
        int id=0;
        public FRM_PhoneNumber()
        {
            InitializeComponent();
            display();
        }
        void display() 
        {
            dgvPhoneNumber.DataSource = ClassReports.allphone();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            txtfax.Enabled = txtfname.Enabled = txtland.Enabled = txtret.Enabled = txtwaz.Enabled = rtxtmob.Enabled=txtT.Enabled = true;
            txtfax.Text = txtfname.Text = txtland.Text = txtret.Text = txtT.Text = txtwaz.Text = rtxtmob.Text = "";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int found = 0;
            if (txtfname.Text.Equals("") || rtxtmob.Text.Equals(""))
            {
                MessageBox.Show("Insert Data Please");
            }
            else 
            {
                DataTable dt = ClassReports.allphone();
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    if (txtfname.Text.Equals(dt.Rows[i][1].ToString()) || rtxtmob.Text.Equals(dt.Rows[i][5].ToString()))
                    {
                        if (!rtxtmob.Text.Equals("0"))
                        {
                            found = 1;
                        }
                    }
                }
                if (found == 0)
                {
                    int i = ClassReports.sp_addphonenum(txtret.Text, txtfname.Text, txtwaz.Text, rtxtmob.Text, txtland.Text, txtfax.Text, txtT.Text);
                    display();
                    txtfax.Text = txtfname.Text = txtland.Text = txtret.Text = txtwaz.Text = rtxtmob.Text = txtT.Text = "";
                    txtfax.Enabled = txtfname.Enabled = txtland.Enabled = txtret.Enabled = txtwaz.Enabled = rtxtmob.Enabled = txtT.Enabled = false;
                    MessageBox.Show("Done");
                }
                else
                {
                    MessageBox.Show("الاسم او رقم الخليوي موجود مسبقا ..");
                }
                
            }
        }

        private void txtsearch_TextChanged(object sender, EventArgs e)
        {
            dgvPhoneNumber.DataSource = ClassReports.searchphone(txtsearch.Text);
        }

        private void dgvPhoneNumber_DoubleClick(object sender, EventArgs e)
        {
            
            txtfax.Enabled = txtfname.Enabled = txtland.Enabled = txtret.Enabled = txtwaz.Enabled = rtxtmob.Enabled=txtT.Enabled = true;
            id = int.Parse(dgvPhoneNumber.CurrentRow.Cells[0].Value.ToString());
            txtret.Text = dgvPhoneNumber.CurrentRow.Cells[3].Value.ToString();
            txtfname.Text = dgvPhoneNumber.CurrentRow.Cells[1].Value.ToString();
            txtwaz.Text = dgvPhoneNumber.CurrentRow.Cells[4].Value.ToString();
            rtxtmob.Text = dgvPhoneNumber.CurrentRow.Cells[5].Value.ToString();
            txtland.Text = dgvPhoneNumber.CurrentRow.Cells[6].Value.ToString();
            txtfax.Text = dgvPhoneNumber.CurrentRow.Cells[2].Value.ToString();
            txtT.Text = dgvPhoneNumber.CurrentRow.Cells[7].Value.ToString();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtfname.Text.Equals("") || rtxtmob.Text.Equals("")||id==0)
            {
                MessageBox.Show("Selected One");
            }
            else 
            {
                txtfax.Enabled = txtfname.Enabled = txtland.Enabled = txtret.Enabled = txtwaz.Enabled = rtxtmob.Enabled = txtT.Enabled = true;
                int i = ClassReports.UpdatePhone(id, txtret.Text, txtfname.Text, txtwaz.Text, rtxtmob.Text, txtland.Text, txtfax.Text, txtT.Text);
                display();
                txtfax.Text = txtfname.Text = txtland.Text = txtret.Text = txtwaz.Text = rtxtmob.Text = txtT.Text = "";
                txtfax.Enabled = txtfname.Enabled = txtland.Enabled = txtret.Enabled = txtwaz.Enabled = rtxtmob.Enabled = txtT.Enabled = false;
                MessageBox.Show("Done");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtfname.Text.Equals("") || id == 0)
            {
                MessageBox.Show("Selected One");
            }
            else 
            {
                txtfax.Enabled = txtfname.Enabled = txtland.Enabled = txtret.Enabled = txtwaz.Enabled = rtxtmob.Enabled = txtT.Enabled = true;
                int i = ClassReports.DeletePhone(id);
                display();
                txtfax.Text = txtfname.Text = txtland.Text = txtret.Text = txtwaz.Text = rtxtmob.Text = txtT.Text = "";
                txtfax.Enabled = txtfname.Enabled = txtland.Enabled = txtret.Enabled = txtwaz.Enabled = rtxtmob.Enabled = txtT.Enabled = false;
                MessageBox.Show("Done");
            }
        }
    }
}
