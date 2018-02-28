namespace ColumbusArmyOrder.ReportPrint
{
    partial class Frm_ReportOrder
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
            this.columbusOrderDataSet1 = new ColumbusArmyOrder.ColumbusOrderDataSet1();
            this.spOrderDetailsSelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sp_OrderDetailsSelTableAdapter = new ColumbusArmyOrder.ColumbusOrderDataSet1TableAdapters.sp_OrderDetailsSelTableAdapter();
            this.sp_OrderDetailsSelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.columbusOrderDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spOrderDetailsSelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sp_OrderDetailsSelBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.sp_OrderDetailsSelBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "ColumbusArmyOrder.ReportPrint.Report2.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(724, 822);
            this.reportViewer1.TabIndex = 0;
            // 
            // columbusOrderDataSet1
            // 
            this.columbusOrderDataSet1.DataSetName = "ColumbusOrderDataSet1";
            this.columbusOrderDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // spOrderDetailsSelBindingSource
            // 
            this.spOrderDetailsSelBindingSource.DataMember = "sp_OrderDetailsSel";
            this.spOrderDetailsSelBindingSource.DataSource = this.columbusOrderDataSet1;
            // 
            // sp_OrderDetailsSelTableAdapter
            // 
            this.sp_OrderDetailsSelTableAdapter.ClearBeforeFill = true;
            // 
            // sp_OrderDetailsSelBindingSource
            // 
            this.sp_OrderDetailsSelBindingSource.DataMember = "sp_OrderDetailsSel";
            this.sp_OrderDetailsSelBindingSource.DataSource = this.columbusOrderDataSet1;
            // 
            // Frm_ReportOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(724, 822);
            this.Controls.Add(this.reportViewer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_ReportOrder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Report Order";
            this.Load += new System.EventHandler(this.Frm_ReportOrder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.columbusOrderDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spOrderDetailsSelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sp_OrderDetailsSelBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        public System.Windows.Forms.BindingSource sp_OrderDetailsSelBindingSource;
        public ColumbusOrderDataSet1 columbusOrderDataSet1;
        public System.Windows.Forms.BindingSource spOrderDetailsSelBindingSource;
        public ColumbusOrderDataSet1TableAdapters.sp_OrderDetailsSelTableAdapter sp_OrderDetailsSelTableAdapter;

    }
}