using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ColumbusArmyOrder.Pl
{
    public partial class FRM_MainForm : Form
    {
        public static string UserName = "";
        public static string FullName = "";
        public static string Per = "";
        public static string U_Password = "";
        public static string u_id = "";
        public FRM_MainForm()
        {
            InitializeComponent();
        }

        private void txtamount_KeyPress(object sender, KeyPressEventArgs e)
        {
            char d = char.Parse(System.Globalization.CultureInfo.CurrentCulture.NumberFormat.CurrencyDecimalSeparator);
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != d)
            {
                e.Handled = true;

            }
        }

        private void txtprice_KeyPress(object sender, KeyPressEventArgs e)
        {
            char d = char.Parse(System.Globalization.CultureInfo.CurrentCulture.NumberFormat.CurrencyDecimalSeparator);
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != d)
            {
                e.Handled = true;

            }
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtamount.Text.Equals("") || txtprice.Text.Equals(""))
                {
                    MessageBox.Show("Please Fill All Fields");
                }
                else
                {
                    if (rbIllegal.Checked == true)
                    {
                        txttotal.Text = ((double.Parse(txtamount.Text)) / (double.Parse(txtprice.Text))).ToString();
                    }
                    else if (rbLegal.Checked == true)
                    {
                        txttotal.Text = ((double.Parse(txtamount.Text) * 100 / 110) / (double.Parse(txtprice.Text))).ToString();
                    }
                }
            }
            catch (Exception ex) 
            {
                MessageBox.Show("Wronge Data");
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtamount.Text =txtprice.Text =txttotal.Text = "";
        }

        private void btnNewBri_Click(object sender, EventArgs e)
        {
            FRM_NewBrigade nb = new FRM_NewBrigade();
            nb.ShowDialog();
        }

        private void btnBriManag_Click(object sender, EventArgs e)
        {
            FRM_BrigadeManag bm = new FRM_BrigadeManag();
            bm.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FRM_NewBattalion nb = new FRM_NewBattalion();
            nb.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FRM_BattlionManag bm = new FRM_BattlionManag();
            bm.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FRM_NewSaraya ns = new FRM_NewSaraya();
            ns.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FRM_SarayaManagmentBri sb = new FRM_SarayaManagmentBri();
            sb.ShowDialog();
        }

        private void btnNReg_Click(object sender, EventArgs e)
        {
            FRM_NewRegiment nr = new FRM_NewRegiment();
            nr.ShowDialog();
        }

        private void btnRegManag_Click(object sender, EventArgs e)
        {
            FRM_RegimentManagment rr = new FRM_RegimentManagment();
            rr.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            FRM_NewSarayaR sr = new FRM_NewSarayaR();
            sr.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FRM_SararyaManagR rr = new FRM_SararyaManagR();
            rr.ShowDialog();
        }

        private void btnNewMilitary_Click(object sender, EventArgs e)
        {
            FRM_NewMilitaryP pp = new FRM_NewMilitaryP();
            pp.ShowDialog();
        }

        private void btnMilitrymang_Click(object sender, EventArgs e)
        {
            FRM_MilitaryPManagment mm = new FRM_MilitaryPManagment();
            mm.ShowDialog();
        }

        private void btnBriQuotation_Click(object sender, EventArgs e)
        {
            FRM_BriQuotation q = new FRM_BriQuotation("B");
            q.ShowDialog();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            FRM_BriOrder o = new FRM_BriOrder("B");
            o.ShowDialog();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            FRM_Bill b = new FRM_Bill("B");
            b.ShowDialog();
        }

        private void btnRegQuotation_Click(object sender, EventArgs e)
        {
            FRM_BriQuotation q = new FRM_BriQuotation("R");
            q.ShowDialog();
        }

        private void btnMilitaryQuota_Click(object sender, EventArgs e)
        {
            FRM_BriQuotation q = new FRM_BriQuotation("M");
            q.ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            FRM_BriOrder o = new FRM_BriOrder("R");
            o.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            FRM_BriOrder o = new FRM_BriOrder("M");
            o.ShowDialog();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            FRM_Bill b = new FRM_Bill("R");
            b.ShowDialog();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            FRM_Bill b = new FRM_Bill("M");
            b.ShowDialog();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            FRM_Report_Details fd = new FRM_Report_Details();
            fd.ShowDialog();
        }

        private void tsNewBri_Click(object sender, EventArgs e)
        {
            FRM_NewBrigade nb = new FRM_NewBrigade();
            nb.ShowDialog();
        }

        private void tsBrimanag_Click(object sender, EventArgs e)
        {
            FRM_BrigadeManag bm = new FRM_BrigadeManag();
            bm.ShowDialog();
        }

        private void tsBriNewBat_Click(object sender, EventArgs e)
        {
            FRM_NewBattalion nb = new FRM_NewBattalion();
            nb.ShowDialog();
        }

        private void tsBriBatManag_Click(object sender, EventArgs e)
        {
            FRM_BattlionManag bm = new FRM_BattlionManag();
            bm.ShowDialog();
        }

        private void tsBriNewSaraya_Click(object sender, EventArgs e)
        {
            FRM_NewSaraya ns = new FRM_NewSaraya();
            ns.ShowDialog();
        }

        private void tsBriSarayaManag_Click(object sender, EventArgs e)
        {
            FRM_SarayaManagmentBri sb = new FRM_SarayaManagmentBri();
            sb.ShowDialog();
        }

        private void tsNewReg_Click(object sender, EventArgs e)
        {
            FRM_NewRegiment nr = new FRM_NewRegiment();
            nr.ShowDialog();
        }

        private void tsRegManag_Click(object sender, EventArgs e)
        {
            FRM_RegimentManagment rr = new FRM_RegimentManagment();
            rr.ShowDialog();
        }

        private void tsRegNewSaraya_Click(object sender, EventArgs e)
        {
            FRM_NewSarayaR sr = new FRM_NewSarayaR();
            sr.ShowDialog();
        }

        private void tsRegSarayaManag_Click(object sender, EventArgs e)
        {
            FRM_SararyaManagR rr = new FRM_SararyaManagR();
            rr.ShowDialog();
        }

        private void tsNewPiece_Click(object sender, EventArgs e)
        {
            FRM_NewMilitaryP pp = new FRM_NewMilitaryP();
            pp.ShowDialog();
        }

        private void tsPieceManag_Click(object sender, EventArgs e)
        {
            FRM_MilitaryPManagment mm = new FRM_MilitaryPManagment();
            mm.ShowDialog();
        }

        private void tsQuotBri_Click(object sender, EventArgs e)
        {
            FRM_BriQuotation q = new FRM_BriQuotation("B");
            q.ShowDialog();
        }

        private void tsQuotReg_Click(object sender, EventArgs e)
        {
            FRM_BriQuotation q = new FRM_BriQuotation("R");
            q.ShowDialog();
        }

        private void tsQuotPiece_Click(object sender, EventArgs e)
        {
            FRM_BriQuotation q = new FRM_BriQuotation("M");
            q.ShowDialog();
        }

        private void tsOrderBri_Click(object sender, EventArgs e)
        {
            FRM_BriOrder o = new FRM_BriOrder("B");
            o.ShowDialog();
        }

        private void tsOrderReg_Click(object sender, EventArgs e)
        {
            FRM_BriOrder o = new FRM_BriOrder("R");
            o.ShowDialog();
        }

        private void tsOrderMilitary_Click(object sender, EventArgs e)
        {
            FRM_BriOrder o = new FRM_BriOrder("M");
            o.ShowDialog();
        }

        private void tsBillBri_Click(object sender, EventArgs e)
        {
            FRM_Bill b = new FRM_Bill("B");
            b.ShowDialog();
        }

        private void tsBillReg_Click(object sender, EventArgs e)
        {
            FRM_Bill b = new FRM_Bill("R");
            b.ShowDialog();
        }

        private void tsBillMilitary_Click(object sender, EventArgs e)
        {
            FRM_Bill b = new FRM_Bill("M");
            b.ShowDialog();
        }

        private void tsReportAllDetails_Click(object sender, EventArgs e)
        {
            FRM_Report_Details fd = new FRM_Report_Details();
            fd.ShowDialog();
        }

        private void tsSignIn_Click(object sender, EventArgs e)
        {
            FRM_SigIn s = new FRM_SigIn();
            s.ShowDialog();
        }

        private void tsChangePass_Click(object sender, EventArgs e)
        {
            FRM_ChangePass f = new FRM_ChangePass();
            f.ShowDialog();
        }

        private void tsSignOut_Click(object sender, EventArgs e)
        {
            Per = "out";
            tsBrigade.Enabled = tsRegiments.Enabled = tsMilitaryPieces.Enabled = tsQuot.Enabled = TsOrder.Enabled = tsBill.Enabled = tsReport.Enabled = tsSetting.Enabled =tsBackupData.Enabled= false;
            tsSignIn.Enabled = true;
            FRM_SigIn s = new FRM_SigIn();
            s.ShowDialog();
        }

        private void FRM_MainForm_Activated(object sender, EventArgs e)
        {
            if(Per.Equals("Admin"))
            {
                tsBrigade.Enabled = tsRegiments.Enabled = tsMilitaryPieces.Enabled =tsBackupData.Enabled= true;
                 tsQuot.Enabled = TsOrder.Enabled = tsBill.Enabled = tsReport.Enabled = tsSetting.Enabled = true;
                tsSignOut.Enabled = tsChangePass.Enabled = true;
                tsSignIn.Enabled = false;
            }
            else if (Per.Equals("out")) 
            {
                tsBrigade.Enabled = tsRegiments.Enabled = tsMilitaryPieces.Enabled = tsQuot.Enabled = TsOrder.Enabled = tsBill.Enabled = tsReport.Enabled = tsSetting.Enabled =tsBackupData.Enabled= false;
                tsSignOut.Enabled = tsChangePass.Enabled = false;
                tsSignIn.Enabled = true;
            }
            else if (Per.Equals("User")) 
            {
                tsQuot.Enabled = TsOrder.Enabled = tsBill.Enabled = true;
                tsSignOut.Enabled = tsChangePass.Enabled = true;
                tsSignIn.Enabled = false;
            }
        }

        private void ts_phoneNmuber_Click(object sender, EventArgs e)
        {
            FRM_PhoneNumber p = new FRM_PhoneNumber();
            p.ShowDialog();
        }

        private void tsBackupData_Click(object sender, EventArgs e)
        {
            Frm_Backup a = new Frm_Backup();
            a.ShowDialog();
        }

       
    }
}
