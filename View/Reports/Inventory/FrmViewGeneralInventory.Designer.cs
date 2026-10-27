namespace HealthPortal.View.Reports.Inventory
{
    partial class FrmViewGeneralInventory
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmViewGeneralInventory));
            this.tbInventoryBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetInfoInventory1 = new HealthPortal.View.Reports.Inventory.DataSetInfoInventory();
            this.tbInstitutionBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetInfoInstitution = new HealthPortal.View.Reports.Inventory.DataSetInfoInstitution();
            this.tbInventoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetInfoInventory = new HealthPortal.View.Reports.Inventory.DataSetInfoInventory();
            this.tbInstitutionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbInventoryTableAdapter = new HealthPortal.View.Reports.Inventory.DataSetInfoInventoryTableAdapters.tbInventoryTableAdapter();
            this.tbInstitutionTableAdapter = new HealthPortal.View.Reports.Inventory.DataSetInfoInstitutionTableAdapters.tbInstitutionTableAdapter();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tbInventoryBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tbInventoryBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.tbInstitutionBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.tbInventoryBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetInfoInventory1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbInstitutionBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetInfoInstitution)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbInventoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetInfoInventory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbInstitutionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbInventoryBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbInventoryBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbInstitutionBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // tbInventoryBindingSource3
            // 
            this.tbInventoryBindingSource3.DataMember = "tbInventory";
            this.tbInventoryBindingSource3.DataSource = this.dataSetInfoInventory1;
            // 
            // dataSetInfoInventory1
            // 
            this.dataSetInfoInventory1.DataSetName = "DataSetInfoInventory";
            this.dataSetInfoInventory1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbInstitutionBindingSource2
            // 
            this.tbInstitutionBindingSource2.DataMember = "tbInstitution";
            this.tbInstitutionBindingSource2.DataSource = this.dataSetInfoInstitution;
            // 
            // dataSetInfoInstitution
            // 
            this.dataSetInfoInstitution.DataSetName = "DataSetInfoInstitution";
            this.dataSetInfoInstitution.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbInventoryBindingSource
            // 
            this.tbInventoryBindingSource.DataMember = "tbInventory";
            this.tbInventoryBindingSource.DataSource = this.dataSetInfoInventory;
            // 
            // dataSetInfoInventory
            // 
            this.dataSetInfoInventory.DataSetName = "DataSetInfoInventory";
            this.dataSetInfoInventory.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbInstitutionBindingSource
            // 
            this.tbInstitutionBindingSource.DataMember = "tbInstitution";
            this.tbInstitutionBindingSource.DataSource = this.dataSetInfoInstitution;
            // 
            // tbInventoryTableAdapter
            // 
            this.tbInventoryTableAdapter.ClearBeforeFill = true;
            // 
            // tbInstitutionTableAdapter
            // 
            this.tbInstitutionTableAdapter.ClearBeforeFill = true;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSetNewInventory";
            reportDataSource1.Value = this.tbInventoryBindingSource3;
            reportDataSource2.Name = "DataSetInstitution";
            reportDataSource2.Value = this.tbInstitutionBindingSource2;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "HealthPortal.View.Reports.Inventory.General_Inventory.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(717, 657);
            this.reportViewer1.TabIndex = 0;
            // 
            // tbInventoryBindingSource1
            // 
            this.tbInventoryBindingSource1.DataMember = "tbInventory";
            this.tbInventoryBindingSource1.DataSource = this.dataSetInfoInventory;
            // 
            // tbInventoryBindingSource2
            // 
            this.tbInventoryBindingSource2.DataMember = "tbInventory";
            this.tbInventoryBindingSource2.DataSource = this.dataSetInfoInventory1;
            // 
            // tbInstitutionBindingSource1
            // 
            this.tbInstitutionBindingSource1.DataMember = "tbInstitution";
            this.tbInstitutionBindingSource1.DataSource = this.dataSetInfoInstitution;
            // 
            // FrmViewGeneralInventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(717, 657);
            this.Controls.Add(this.reportViewer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmViewGeneralInventory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reporte de Inventario";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmViewGeneralInventory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tbInventoryBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetInfoInventory1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbInstitutionBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetInfoInstitution)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbInventoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetInfoInventory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbInstitutionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbInventoryBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbInventoryBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbInstitutionBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DataSetInfoInventory dataSetInfoInventory;
        private System.Windows.Forms.BindingSource tbInventoryBindingSource;
        private DataSetInfoInventoryTableAdapters.tbInventoryTableAdapter tbInventoryTableAdapter;
        private DataSetInfoInstitution dataSetInfoInstitution;
        private System.Windows.Forms.BindingSource tbInstitutionBindingSource;
        private DataSetInfoInstitutionTableAdapters.tbInstitutionTableAdapter tbInstitutionTableAdapter;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource tbInventoryBindingSource1;
        private DataSetInfoInventory dataSetInfoInventory1;
        private System.Windows.Forms.BindingSource tbInventoryBindingSource2;
        private System.Windows.Forms.BindingSource tbInventoryBindingSource3;
        private System.Windows.Forms.BindingSource tbInstitutionBindingSource2;
        private System.Windows.Forms.BindingSource tbInstitutionBindingSource1;
    }
}