using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ColumbusArmyOrder.BL;
using System.Data.SqlClient;

namespace ColumbusArmyOrder.Pl
{
    public partial class FRM_QuotDetails : Form
    {
        public static string con = "Server= 192.168.1.99; Database= ColumbusOrder;User ID=sa ;Password=123;Pooling=false;";
        string id;
        public FRM_QuotDetails(string s)
        {
            InitializeComponent();
            id = s;
            dgvDetails.DataSource = ClassOrder.sp_IDSelectedQuotaionsDet(int.Parse(s));
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            /*try
            {
                ReportPrint.Frm_ReportPrint frm = new ReportPrint.Frm_ReportPrint();
                SqlDataAdapter da = new SqlDataAdapter("select DetNum as 'Number',QoutType as 'Type',QoutBarcode as 'Barcode',QoutQty as 'QTY',QoutPrice as 'Price',QuotSpecification as 'Details'  from QuotationDet where Quotation_ID=" + int.Parse(id) + " ", con);
                da.Fill(frm.columbusOrderDataSet.sp_IDSelectedQuotaionsDet);
                frm.reportViewer1.RefreshReport();
                frm.ShowDialog();
            }
            catch (Exception) { MessageBox.Show("Error ...."); }*/

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
                for (j = 0; j < dgvDetails.Columns.Count; j++)
                {
                    Microsoft.Office.Interop.Excel.Range myRange = (Microsoft.Office.Interop.Excel.Range)sheet1.Cells[StartRow, StartCol + j];
                    myRange.Value2 = dgvDetails.Columns[j].HeaderText;
                }

                StartRow++;

                //Write datagridview content
                for (i = 0; i < dgvDetails.Rows.Count; i++)
                {
                    for (j = 0; j < dgvDetails.Columns.Count; j++)
                    {
                        try
                        {
                            Microsoft.Office.Interop.Excel.Range myRange = (Microsoft.Office.Interop.Excel.Range)sheet1.Cells[StartRow + i, StartCol + j];
                            myRange.Value2 = dgvDetails[j, i].Value == null ? "" : dgvDetails[j, i].Value;
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
                        workbook.SaveAs(path, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing);

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
