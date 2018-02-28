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
    public partial class FRM_Bill : Form
    {
        string id = "";
        int k = 1;
        public static string code = "";
        public FRM_Bill(string B)
        {
            InitializeComponent();
            txtDate.Text = DateTime.Now.Date.ToShortDateString();
            if (B == "B") { code = "B"; }
            if (B == "R") { code = "R"; }
            if (B == "M") { code = "M"; }
        }

        private void btnSelectOrder_Click(object sender, EventArgs e)
        {
            FRM_OrdersSelect o = new FRM_OrdersSelect();
            o.ShowDialog();
            try
            {
                txtBriName.Text = o.dgvOrder.CurrentRow.Cells[3].Value.ToString();
                txtBatName.Text = o.dgvOrder.CurrentRow.Cells[4].Value.ToString();
                txtSarName.Text = o.dgvOrder.CurrentRow.Cells[5].Value.ToString();
                txtContactName.Text = o.dgvOrder.CurrentRow.Cells[2].Value.ToString();
                txtLegal.Text = o.dgvOrder.CurrentRow.Cells[6].Value.ToString();
                id = o.dgvOrder.CurrentRow.Cells[0].Value.ToString();
            }
            catch (Exception ex) 
            {

            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtQty_KeyPress(object sender, KeyPressEventArgs e)
        {
            char d = char.Parse(System.Globalization.CultureInfo.CurrentCulture.NumberFormat.CurrencyDecimalSeparator);
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;

            }
        }

        private void txtUprice_KeyPress(object sender, KeyPressEventArgs e)
        {
            char d = char.Parse(System.Globalization.CultureInfo.CurrentCulture.NumberFormat.CurrencyDecimalSeparator);
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;

            }
        }

        private void txtTPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            char d = char.Parse(System.Globalization.CultureInfo.CurrentCulture.NumberFormat.CurrencyDecimalSeparator);
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;

            }
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            if (txtType.Text.Equals("") || txtQty.Text.Equals("") || txtBarcode.Text.Equals("")||txtUprice.Text.Equals(""))
            {
                MessageBox.Show("Please Fill Fields.");
            }
            else
            {
                dgvQuotation.Rows.Add(k.ToString(), txtType.Text.ToString(), txtBarcode.Text.ToString(), txtQty.Text.ToString(), Decimal.Parse(txtUprice.Text).ToString("N"), (Decimal.Parse(txtQty.Text) * Decimal.Parse(txtUprice.Text)).ToString("N"));
                k++;
                txtType.Text = txtQty.Text = txtBarcode.Text =txtUprice.Text= "";
            }
            txtAmount.Text= calAmount().ToString("N");
            txtTva.Text = CalTVA().ToString("N");
            txtTotal.Text = CalTotal().ToString("N");
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                txtType.Text = dgvQuotation.CurrentRow.Cells[1].Value.ToString();
                txtBarcode.Text = dgvQuotation.CurrentRow.Cells[2].Value.ToString();
                txtQty.Text = dgvQuotation.CurrentRow.Cells[3].Value.ToString();
                txtUprice.Text = dgvQuotation.CurrentRow.Cells[4].Value.ToString();
                dgvQuotation.Rows.Remove(dgvQuotation.CurrentRow);
                k--;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please Select One.");
            }
            txtAmount.Text = calAmount().ToString("N");
            txtTva.Text = CalTVA().ToString("N");
            txtTotal.Text = CalTotal().ToString("N");
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
            txtAmount.Text = calAmount().ToString("N");
            txtTva.Text = CalTVA().ToString("N");
            txtTotal.Text = CalTotal().ToString("N");
        }
          Decimal calAmount() 
        {
            Decimal x =0;
            if (txtLegal.Text.Equals("")) { MessageBox.Show("Please select Order"); }
            else
            {
                    for (int i = 0; i < dgvQuotation.Rows.Count; i++)
                    {
                        x += Decimal.Parse(dgvQuotation.Rows[i].Cells[5].Value.ToString());
                    }
            }
                return x;
        }
          Decimal CalTVA() 
        {
            Decimal x=0;
            if (txtLegal.Text.Equals("")) 
            {
                MessageBox.Show("Please Select Order.");
            }
            if (txtLegal.Text.Equals("True")) 
            {
                x = calAmount() * 10 / 100;

            }
            if (txtLegal.Text.Equals("False")) 
            {
                x = 0;
            }
            return x;
        }
          Decimal CalTotal()
          {
              Decimal x = calAmount() + CalTVA();
              return x;
          }

          private void btnSave_Click(object sender, EventArgs e)
          {
              if (dgvQuotation.Rows.Count <= 0||txtBriName.Text.Equals(""))
              {
                  MessageBox.Show("Fields Empty");
              }
              else 
              {
                  int i = ClassBill.sp_bill(DateTime.Now.Date, txtContactName.Text, txtBriName.Text, txtBatName.Text, txtSarName.Text, txtLegal.Text, txtAmount.Text, txtTva.Text, txtTotal.Text,code);
                  for (int x = 0; x < dgvQuotation.Rows.Count; x++) 
                  {
                      int z = ClassBill.sp_billDet(dgvQuotation.Rows[x].Cells[0].Value.ToString(), dgvQuotation.Rows[x].Cells[1].Value.ToString(), dgvQuotation.Rows[x].Cells[2].Value.ToString(), dgvQuotation.Rows[x].Cells[3].Value.ToString(), dgvQuotation.Rows[x].Cells[4].Value.ToString(), dgvQuotation.Rows[x].Cells[5].Value.ToString());
                  }
                  int y = ClassBill.updExecuteOrder(int.Parse(id));
                  btnSelectOrder.Enabled = btnInsert.Enabled = btnDelete.Enabled = btnUpdate.Enabled = btnSave.Enabled = false;
                  btnPrint.Enabled = true;
                  MessageBox.Show("Done.");
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
