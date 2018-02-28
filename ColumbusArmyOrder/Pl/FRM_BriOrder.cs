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
    public partial class FRM_BriOrder : Form
    {
        string id = "";
        int k = 1;
       public static string code = "";
         
        public FRM_BriOrder(string O)
        {
            InitializeComponent();
            txtDate.Text = DateTime.Now.Date.ToShortDateString();
            if (O == "B") 
            {
                code = "B";
            }
            if (O == "R")
            {
                code = "R";
            }
            if (O == "M")
            {
                code = "M";
            }
        }

        private void btnQuotationSelect_Click(object sender, EventArgs e)
        {
            FRM_QuotationSelected s = new FRM_QuotationSelected();
            s.ShowDialog();
            try
            {
                txtBriName.Text = s.dgvQuotations.CurrentRow.Cells[3].Value.ToString();
                txtBatName.Text = s.dgvQuotations.CurrentRow.Cells[4].Value.ToString();
                txtSarName.Text = s.dgvQuotations.CurrentRow.Cells[5].Value.ToString();
                txtContactName.Text = s.dgvQuotations.CurrentRow.Cells[2].Value.ToString();
                txtLegal.Text = s.dgvQuotations.CurrentRow.Cells[6].Value.ToString();
                id = s.dgvQuotations.CurrentRow.Cells[0].Value.ToString();
                dgvQuotationDet.DataSource = ClassOrder.sp_IDSelectedQuotaionsDet(int.Parse(id));
            }
            catch (Exception ex) 
            {
            }
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            if (txtType.Text.Equals("") || txtqty.Text.Equals("") || txtBarcode.Text.Equals(""))
            {
                MessageBox.Show("Please Fill Fields.");
            }
            else 
            {
                dgvQuotation.Rows.Add(k.ToString(), txtType.Text.ToString(), txtBarcode.Text.ToString(), txtqty.Text.ToString());
                k++;
                 txtType.Text = txtqty.Text = txtBarcode.Text =  "";
            }
        }

        private void txtqty_KeyPress(object sender, KeyPressEventArgs e)
        {
            char d = char.Parse(System.Globalization.CultureInfo.CurrentCulture.NumberFormat.CurrencyDecimalSeparator);
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;

            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                txtType.Text = dgvQuotation.CurrentRow.Cells[1].Value.ToString();
                txtBarcode.Text = dgvQuotation.CurrentRow.Cells[2].Value.ToString();
                txtqty.Text = dgvQuotation.CurrentRow.Cells[3].Value.ToString();
                dgvQuotation.Rows.Remove(dgvQuotation.CurrentRow);
                k--;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please Select One.");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                dgvQuotation.Rows.Remove(dgvQuotation.CurrentRow);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please Select One.");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (dgvQuotation.Rows.Count == 0||txtBriName.Text.Equals(""))
            {
                MessageBox.Show("Data Not Completed.");
            }
            else 
            {
                int i = ClassOrder.sp_broOrder(DateTime.Now.Date, txtContactName.Text, txtBriName.Text, txtBatName.Text, txtSarName.Text, txtLegal.Text,code);
                for (int num = 0; num < dgvQuotation.Rows.Count; num++)
                {
                    int x =ClassOrder.sp_briOrderDet(dgvQuotation.Rows[num].Cells[0].Value.ToString(), dgvQuotation.Rows[num].Cells[1].Value.ToString(), dgvQuotation.Rows[num].Cells[2].Value.ToString(), dgvQuotation.Rows[num].Cells[3].Value.ToString());
                }
                int z = ClassOrder.briUpdateQuotExE(int.Parse(id));
                btnDelete.Enabled = btnUpdate.Enabled = btnSave.Enabled = btnInsert.Enabled = txtContactName.Enabled = btnCancel.Enabled = btnQuotationSelect.Enabled= false;
                btnPrint.Enabled = true;
                MessageBox.Show("Done");
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
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
