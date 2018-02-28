using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ColumbusArmyOrder.Pl
{
    public partial class Frm_Backup : Form
    {
        public Frm_Backup()
        {
            InitializeComponent();
        }

        private void btnPath_Click(object sender, EventArgs e)
        {
            try
            {
                FolderBrowserDialog fd = new FolderBrowserDialog();
                fd.ShowDialog();
                txtPath.Text = fd.SelectedPath;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBackup_Click(object sender, EventArgs e)
        {
            try
            {
                if (!txtPath.Text.Equals(""))
                {
                    string path = string.Format("{0}\\ColumbusMilitary-{1}{2}.bak", txtPath.Text, DateTime.Now.ToShortDateString().Replace('/', '-'),
                        DateTime.Now.ToShortTimeString().Replace(':', '-'));
                    SqlConnection con = new SqlConnection("Server= 192.168.1.99; Database= ColumbusOrder;User ID=sa ;Password=123;");
                    string Query = string.Format("Backup Database ColumbusOrder to Disk = '{0}'", path);
                    SqlCommand cmd = new SqlCommand(Query, con);
                    cmd.CommandType = CommandType.Text;
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("تم اخذ نسخة احتياطية");
                    txtPath.Text = "";
                }
                else { MessageBox.Show("يرجى تحديد مسار للتخزين"); }


            }
            catch (Exception ex)
            {
                MessageBox.Show("يرجى التخزين على قرص اخر مختلف عن قرص النظام ");
            }
        }
    }
}
