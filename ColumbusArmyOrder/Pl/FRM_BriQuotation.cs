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
    public partial class FRM_BriQuotation : Form
    {
        string code = "";
        int k = 1;
        public FRM_BriQuotation(string q)
        {
            InitializeComponent();
            if (q == "B")
            {
                fillBriComb();
                code = "B";
            }
            if (q == "R")
            {
                fillRegiment();
                code = "R";
                chkActSar.Enabled = false;
            }
            if (q == "M")
            {
                MilitaryPieces();
                code = "M";
                chkActBat.Enabled = chkActSar.Enabled = false;
            }
            txtDate.Text = DateTime.Now.Date.ToShortDateString();
        }
        void fillBriComb()
        {
            //Brigade..
            DataTable dt = ClassBrigade.allBrigade();
            cmbBrigade.DataSource = dt;
            cmbBrigade.DisplayMember = "Name";
            cmbBrigade.ValueMember = "ID";

        }

        //Regiments
        void fillRegiment() 
        {
            DataTable dt = ClassRegiments.sp_allRegiment();
            cmbBrigade.DataSource = dt;
            cmbBrigade.DisplayMember = "Name";
            cmbBrigade.ValueMember = "ID";
        }
        //Military Pieces
        void MilitaryPieces() 
        {
            DataTable dt = ClassMilitaryPieces.sp_allMilitaryPieces();
            cmbBrigade.DataSource = dt;
            cmbBrigade.DisplayMember = "Name";
            cmbBrigade.ValueMember = "ID";
        }

        private void chkActBat_CheckedChanged(object sender, EventArgs e)
        {
            
            if (chkActBat.Checked)
            {
                cmbBattalion.Enabled = true;
                if (code == "B")
                {
                    DataTable dt = ClassQuotation.sp_fillBattQout((int)cmbBrigade.SelectedValue);
                    cmbBattalion.DataSource = dt;
                    cmbBattalion.DisplayMember = "Battalions_name";
                    cmbBattalion.ValueMember = "Battalions_id";
                }
                if (code == "R")
                {
                    DataTable dt = ClassRegiments.sp_FillSecondLRegQ((int)cmbBrigade.SelectedValue);
                    cmbBattalion.DataSource = dt;
                    cmbBattalion.DisplayMember = "Name";
                    cmbBattalion.ValueMember = "ID";
                }
                
            }
            else 
            {
                cmbBattalion.Enabled = false;
            }
        }

        private void chkActSar_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (chkActSar.Checked)
                {
                    cmbSaraya.Enabled = true;
                    if (code == "B")
                    {
                        DataTable dt = ClassQuotation.sp_fillSaraQout((int)cmbBrigade.SelectedValue, (int)cmbBattalion.SelectedValue);
                        cmbSaraya.DataSource = dt;
                        cmbSaraya.DisplayMember = "Saraya_name";
                        cmbSaraya.ValueMember = "Saraya_id";
                    }
                   
                  
                }
                else
                {
                    cmbSaraya.Enabled = false;
                }
            }
            catch (Exception ex) 
            {
                chkActSar.Checked = false;
                MessageBox.Show("Select Battalion First");
            }
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            if (txtType.Text.Equals("") || txtunitPrice.Text.Equals("") || txtqty.Text.Equals("") || txtBarcode.Text.Equals(""))
            {
                MessageBox.Show("Please Fill Fields.");
            }
            else 
            {
                dgvQuotation.Rows.Add(k.ToString(),txtType.Text.ToString(),txtBarcode.Text.ToString(),txtqty.Text.ToString(),txtunitPrice.Text.ToString(),rtxtspecification.Text.ToString());
                k++;
                txtunitPrice.Text = txtType.Text = txtqty.Text = txtBarcode.Text = rtxtspecification.Text = "";
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                dgvQuotation.Rows.Remove(dgvQuotation.CurrentRow);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Please Select One.");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try 
            {
                txtType.Text = dgvQuotation.CurrentRow.Cells[1].Value.ToString();
                txtBarcode.Text = dgvQuotation.CurrentRow.Cells[2].Value.ToString();
                txtqty.Text = dgvQuotation.CurrentRow.Cells[3].Value.ToString();
                txtunitPrice.Text = dgvQuotation.CurrentRow.Cells[4].Value.ToString();
                rtxtspecification.Text = dgvQuotation.CurrentRow.Cells[5].Value.ToString();
                dgvQuotation.Rows.Remove(dgvQuotation.CurrentRow);
                k--;
            }
            catch (Exception ex) 
            {
                MessageBox.Show("Please Select One.");
            }
        }

        private void txtunitPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            char d = char.Parse(System.Globalization.CultureInfo.CurrentCulture.NumberFormat.CurrencyDecimalSeparator);
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != d)
            {
                e.Handled = true;

            }
        }

        private void txtqty_KeyPress(object sender, KeyPressEventArgs e)
        {
            //&& e.KeyChar != d
            char d = char.Parse(System.Globalization.CultureInfo.CurrentCulture.NumberFormat.CurrencyDecimalSeparator);
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 )
            {
                e.Handled = true;

            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            String FirstL="0";
            String SecondL="0";
            String ThirdL = "0";
            string legal = "False";
            if (dgvQuotation.Rows.Count == 0)
            {
                MessageBox.Show("Did not Find Any Item Was Inserted.");
            }
            else 
            {

                if (!chkActBat.Checked && !chkActSar.Checked) 
                {
                    FirstL = cmbBrigade.Text;
                }
                else if (chkActBat.Checked && !chkActSar.Checked) 
                {
                    FirstL = cmbBrigade.Text;
                    SecondL = cmbBattalion.Text;
                }
                else if (chkActSar.Checked) 
                {
                    FirstL = cmbBrigade.Text;
                    SecondL = cmbBattalion.Text;
                    ThirdL = cmbSaraya.Text;
                }
                if (rdTrue.Checked) 
                {
                    legal = "True";
                }
                int i = ClassQuotation.sp_AddNewQuotation(DateTime.Now.Date, txtContactName.Text, FirstL, SecondL, ThirdL, legal, "0",code);
                for (int num = 0; num < dgvQuotation.Rows.Count; num++) 
                {
                    int x = ClassQuotation.sp_isertDetails(dgvQuotation.Rows[num].Cells[0].Value.ToString(), dgvQuotation.Rows[num].Cells[1].Value.ToString(), dgvQuotation.Rows[num].Cells[2].Value.ToString(), dgvQuotation.Rows[num].Cells[3].Value.ToString(), dgvQuotation.Rows[num].Cells[4].Value.ToString(), dgvQuotation.Rows[num].Cells[5].Value.ToString());
                }
                btnDelete.Enabled = btnUpdate.Enabled = btnSave.Enabled = btnInsert.Enabled = txtContactName.Enabled = rdFalse.Enabled = rdTrue.Enabled = false;
                chkActBat.Enabled = chkActSar.Enabled = cmbBattalion.Enabled = cmbBrigade.Enabled = cmbSaraya.Enabled = btnCancel.Enabled = false;
                MessageBox.Show("Done");
                btnPrint.Enabled = true;
                

            }
        }

        private void cmbBrigade_SelectedIndexChanged(object sender, EventArgs e)
        {
            chkActBat.Checked = chkActSar.Checked = false;
        }

        private void cmbBattalion_SelectedIndexChanged(object sender, EventArgs e)
        {
            chkActSar.Checked = false;
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            //ReportPrint.FRM_ReportPrint frm = new ReportPrint.FRM_ReportPrint();
            
            //create sql Proc for select all needed data from two table or more like (pharmacy (print order))
            //make crystal report and select that proc with its value
            //degsin report
            //make reportviewer in modifier set public
            //then write suitable code in this section
            //like this:
            /*
            RPT.RRM_Reports frm = new RPT.RRM_Reports();
             * // this is item from reporting
            RPT.rpt_print_requset rpr = new RPT.rpt_print_requset();
            rpr.SetParameterValue("@req_id",ClassRequest.max_id() );
            frm.crystalReportViewer1.ReportSource = rpr;
            frm.ShowDialog();
             * */

            //First way
            //*********


            try
            {
                Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
                excel.Visible = true;
                Microsoft.Office.Interop.Excel.Workbook workbook = excel.Workbooks.Add(System.Reflection.Missing.Value);
                Microsoft.Office.Interop.Excel.Worksheet sheet1 = (Microsoft.Office.Interop.Excel.Worksheet)workbook.Sheets[1];
                int StartCol = 1;
                int StartRow = 1;
                int j = 0, i = 0;

                //Write Headers
                for (j = 0; j < dgvQuotation.Columns.Count; j++)
                {
                    Microsoft.Office.Interop.Excel.Range myRange = (Microsoft.Office.Interop.Excel.Range)sheet1.Cells[StartRow, StartCol + j];
                    myRange.Value2 = dgvQuotation.Columns[j].HeaderText;
                }

                StartRow++;

                //Write datagridview content
                for (i = 0; i < dgvQuotation.Rows.Count; i++)
                {
                    for (j = 0; j < dgvQuotation.Columns.Count; j++)
                    {
                        try
                        {
                            Microsoft.Office.Interop.Excel.Range myRange = (Microsoft.Office.Interop.Excel.Range)sheet1.Cells[StartRow + i, StartCol + j];
                            myRange.Value2 = dgvQuotation[j, i].Value == null ? "" : dgvQuotation[j, i].Value;
                        }
                        catch
                        {

                        }
                    }
                }
                try
                {

                    System.Windows.Forms.SaveFileDialog saveDlg = new System.Windows.Forms.SaveFileDialog();
                    saveDlg.InitialDirectory = @"C:\";
                    saveDlg.Filter = "Excel files (*.xls)|*.xls";
                    saveDlg.FilterIndex = 0;
                    saveDlg.RestoreDirectory = true;
                    saveDlg.Title = "Export Excel File To";
                    if (saveDlg.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    {
                        string path = saveDlg.FileName;
                        workbook.SaveAs(path);

                        // Exit from the application

                        excel.Quit();
                    }

                    //"d:\\output.xls"

                    MessageBox.Show("File Saved ...");
                }
                catch (Exception)
                {
                    MessageBox.Show("Can't Find The Path Please .. select File >> SaveAs >> For Save");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
      
    }
}
