namespace ColumbusArmyOrder.Pl
{
    partial class FRM_NewSaraya
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbBrigade = new System.Windows.Forms.ComboBox();
            this.cmbBattalion = new System.Windows.Forms.ComboBox();
            this.txtname = new System.Windows.Forms.TextBox();
            this.rtxtDescrip = new System.Windows.Forms.RichTextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Description:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Brigade:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Battalion:";
            // 
            // cmbBrigade
            // 
            this.cmbBrigade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBrigade.FormattingEnabled = true;
            this.cmbBrigade.Location = new System.Drawing.Point(82, 10);
            this.cmbBrigade.Name = "cmbBrigade";
            this.cmbBrigade.Size = new System.Drawing.Size(242, 21);
            this.cmbBrigade.TabIndex = 4;
            this.cmbBrigade.SelectedIndexChanged += new System.EventHandler(this.cmbBrigade_SelectedIndexChanged);
            this.cmbBrigade.Click += new System.EventHandler(this.cmbBrigade_Click);
            // 
            // cmbBattalion
            // 
            this.cmbBattalion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBattalion.FormattingEnabled = true;
            this.cmbBattalion.Location = new System.Drawing.Point(82, 37);
            this.cmbBattalion.Name = "cmbBattalion";
            this.cmbBattalion.Size = new System.Drawing.Size(242, 21);
            this.cmbBattalion.TabIndex = 5;
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(82, 64);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(242, 20);
            this.txtname.TabIndex = 6;
            // 
            // rtxtDescrip
            // 
            this.rtxtDescrip.Location = new System.Drawing.Point(82, 90);
            this.rtxtDescrip.Name = "rtxtDescrip";
            this.rtxtDescrip.Size = new System.Drawing.Size(242, 96);
            this.rtxtDescrip.TabIndex = 7;
            this.rtxtDescrip.Text = "";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(82, 192);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(249, 192);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // FRM_NewSaraya
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(328, 220);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.rtxtDescrip);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.cmbBattalion);
            this.Controls.Add(this.cmbBrigade);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FRM_NewSaraya";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "New Saraya";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbBrigade;
        private System.Windows.Forms.ComboBox cmbBattalion;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.RichTextBox rtxtDescrip;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
    }
}