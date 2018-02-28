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
    public partial class FRM_SigIn : Form
    {
        string stateEnter = "";
        public FRM_SigIn()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSignin_Click(object sender, EventArgs e)
        {
            DataTable dt = ClassUsers.SelectAllUser();
            if (txtUserName.Text.Equals("") || txtPassword.Text.Equals(""))
            {
                MessageBox.Show("Please Fill All Fields");
            }
            else 
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    if (dt.Rows[i][0].Equals(txtUserName.Text))
                    {
                        if (dt.Rows[i][1].Equals(txtPassword.Text))
                        {
                            Close();
                            stateEnter = "1";
                            FRM_MainForm.FullName = dt.Rows[i][2].ToString();
                            FRM_MainForm.UserName = dt.Rows[i][0].ToString();
                            FRM_MainForm.U_Password = dt.Rows[i][1].ToString();
                            FRM_MainForm.u_id = dt.Rows[i][4].ToString();

                            if (dt.Rows[i][3].Equals("Admin"))
                            {
                                FRM_MainForm.Per = "Admin";

                            }
                            if (dt.Rows[i][3].Equals("User"))
                            {
                                FRM_MainForm.Per = "User";
                            }
                        }

                    }
                }
                if (!stateEnter.Equals("1"))
                {
                    MessageBox.Show("اسم المستخدم أو كلمة السر غير صحيحة");
                    txtUserName.Text = txtPassword.Text = "";
                }

            }
        }
    }
}
