namespace ColumbusArmyOrder.ReportPrint
{
    partial class Frm_ReportPrint
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.columbusOrderDataSet = new ColumbusArmyOrder.ColumbusOrderDataSet();
            this.columbusOrderDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.spIDSelectedQuotaionsDetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sp_IDSelectedQuotaionsDetTableAdapter = new ColumbusArmyOrder.ColumbusOrderDataSetTableAdapters.sp_IDSelectedQuotaionsDetTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.columbusOrderDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.columbusOrderDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spIDSelectedQuotaionsDetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.spIDSelectedQuotaionsDetBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "ColumbusArmyOrder.ReportPrint.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(746, 814);
            this.reportViewer1.TabIndex = 0;
            // 
            // columbusOrderDataSet
            // 
            this.columbusOrderDataSet.DataSetName = "ColumbusOrderDataSet";
            this.columbusOrderDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // columbusOrderDataSetBindingSource
            // 
            this.columbusOrderDataSetBindingSource.DataSource = this.columbusOrderDataSet;
            this.columbusOrderDataSetBindingSource.Position = 0;
            // 
            // spIDSelectedQuotaionsDetBindingSource
            // 
            this.spIDSelectedQuotaionsDetBindingSource.DataMember = "sp_IDSelectedQuotaionsDet";
            this.spIDSelectedQuotaionsDetBindingSource.DataSource = this.columbusOrderDataSet;
            // 
            // sp_IDSelectedQuotaionsDetTableAdapter
            // 
            this.sp_IDSelectedQuotaionsDetTableAdapter.ClearBeforeFill = true;
            // 
            // Frm_ReportPrint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(746, 814);
            this.Controls.Add(this.reportViewer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_ReportPrint";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Report Print";
            this.Load += new System.EventHandler(this.Frm_ReportPrint_Load);
            ((System.ComponentModel.ISupportInitialize)(this.columbusOrderDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.columbusOrderDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spIDSelectedQuotaionsDetBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource spIDSelectedQuotaionsDetBindingSource;
        public ColumbusOrderDataSet columbusOrderDataSet;
        private System.Windows.Forms.BindingSource columbusOrderDataSetBindingSource;
        private ColumbusOrderDataSetTableAdapters.sp_IDSelectedQuotaionsDetTableAdapter sp_IDSelectedQuotaionsDetTableAdapter;

    }
}