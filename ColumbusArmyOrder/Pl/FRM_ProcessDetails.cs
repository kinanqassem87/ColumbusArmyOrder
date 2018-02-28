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
    public partial class FRM_ProcessDetails : Form
    {
        public static string con = "Server= 192.168.1.99; Database= ColumbusOrder;User ID=sa ;Password=123;Pooling=false;";
        string firstl = "";
        string secondl ="";
        string thirdl = "";
        public FRM_ProcessDetails(string first,string second,string third)
        {
            InitializeComponent();
            firstl = first;
            secondl = second;
            thirdl = third;
            displayQuotExe();
            displayQuotNotExe();
            displayOrder();
        }
        void displayQuotExe() 
        {
            dgvQuotationExE.DataSource = ClassReports.sp_quotexeRep(firstl, secondl, thirdl);
        }
        void displayQuotNotExe()
        {
            dgvQuotationNotExe.DataSource = ClassReports.sp_quotNotexeRep(firstl, secondl, thirdl);
        }
        void displayOrder()
        {
            dgvOrders.DataSource = ClassReports.sp_orderRep(firstl, secondl, thirdl);
        }

        private void dgvQuotationExE_DoubleClick(object sender, EventArgs e)
        {
            FRM_QuotDetails d = new FRM_QuotDetails(dgvQuotationExE.CurrentRow.Cells[0].Value.ToString());
            d.ShowDialog();
        }

        private void dgvQuotationNotExe_DoubleClick(object sender, EventArgs e)
        {
            FRM_QuotDetails d = new FRM_QuotDetails(dgvQuotationNotExe.CurrentRow.Cells[0].Value.ToString());
            d.ShowDialog();
        }

        private void dgvOrders_DoubleClick(object sender, EventArgs e)
        {
            dgvOrderDetails.DataSource = ClassBill.sp_OrderDetailsSel(int.Parse(dgvOrders.CurrentRow.Cells[0].Value.ToString()));
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
           /* try
            {
                ReportPrint.Frm_ReportOrder frm = new ReportPrint.Frm_ReportOrder();
                SqlDataAdapter da = new SqlDataAdapter("select OrderNum as 'Serial Number',OrderType as 'Type',OrderBarcode as 'Barcode',Qty  from Bri_OrderDet where Order_id =" + int.Parse(dgvOrders.CurrentRow.Cells[0].Value.ToString()) + "", con);
                da.Fill(frm.columbusOrderDataSet1.sp_OrderDetailsSel);
                frm.reportViewer1.RefreshReport();
                frm.ShowDialog();
            }
            catch (Exception ex) 
            {
                MessageBox.Show("");
            }*/
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
                for (j = 0; j < dgvOrderDetails.Columns.Count; j++)
                {
                    Microsoft.Office.Interop.Excel.Range myRange = (Microsoft.Office.Interop.Excel.Range)sheet1.Cells[StartRow, StartCol + j];
                    myRange.Value2 = dgvOrderDetails.Columns[j].HeaderText;
                }

                StartRow++;

                //Write datagridview content
                for (i = 0; i < dgvOrderDetails.Rows.Count; i++)
                {
                    for (j = 0; j < dgvOrderDetails.Columns.Count; j++)
                    {
                        try
                        {
                            Microsoft.Office.Interop.Excel.Range myRange = (Microsoft.Office.Interop.Excel.Range)sheet1.Cells[StartRow + i, StartCol + j];
                            myRange.Value2 = dgvOrderDetails[j, i].Value == null ? "" : dgvOrderDetails[j, i].Value;
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
