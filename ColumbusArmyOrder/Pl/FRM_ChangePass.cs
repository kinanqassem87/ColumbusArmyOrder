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
    public partial class FRM_ChangePass : Form
    {
        public FRM_ChangePass()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtCurrent.Text.Equals("") || txtNew.Text.Equals("") || txtConfirm.Text.Equals(""))
            {
                MessageBox.Show("Please Fill All Fields");
            }
            else
            {
                if (txtCurrent.Text == FRM_MainForm.U_Password && txtNew.Text == txtConfirm.Text)
                {
                    int i = ClassUsers.updatePassword(txtNew.Text, int.Parse(FRM_MainForm.u_id));
                    FRM_MainForm.U_Password = txtNew.Text;
                    MessageBox.Show("Done");
                    txtConfirm.Text = txtCurrent.Text = txtNew.Text = "";
                    Close();
                }
                else
                {
                    MessageBox.Show("Wrong Data");
                }
            }
        }
    }
}
