namespace HealthPortal.View.Reports.User
{
    partial class FrmViewGeneralUsers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmViewGeneralUsers));
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dataSetInfoUsers = new HealthPortal.View.Reports.User.DataSetInfoUsers();
            this.tbUsersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbUsersTableAdapter = new HealthPortal.View.Reports.User.DataSetInfoUsersTableAdapters.tbUsersTableAdapter();
            this.dataSetInfoInstitution = new HealthPortal.View.Reports.Inventory.DataSetInfoInstitution();
            this.tbInstitutionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbInstitutionTableAdapter = new HealthPortal.View.Reports.Inventory.DataSetInfoInstitutionTableAdapters.tbInstitutionTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetInfoUsers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbUsersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetInfoInstitution)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbInstitutionBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet2";
            reportDataSource1.Value = this.tbInstitutionBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "HealthPortal.View.Reports.User.General_Users.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(711, 360);
            this.reportViewer1.TabIndex = 0;
            // 
            // dataSetInfoUsers
            // 
            this.dataSetInfoUsers.DataSetName = "DataSetInfoUsers";
            this.dataSetInfoUsers.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbUsersBindingSource
            // 
            this.tbUsersBindingSource.DataMember = "tbUsers";
            this.tbUsersBindingSource.DataSource = this.dataSetInfoUsers;
            // 
            // tbUsersTableAdapter
            // 
            this.tbUsersTableAdapter.ClearBeforeFill = true;
            // 
            // dataSetInfoInstitution
            // 
            this.dataSetInfoInstitution.DataSetName = "DataSetInfoInstitution";
            this.dataSetInfoInstitution.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbInstitutionBindingSource
            // 
            this.tbInstitutionBindingSource.DataMember = "tbInstitution";
            this.tbInstitutionBindingSource.DataSource = this.dataSetInfoInstitution;
            // 
            // tbInstitutionTableAdapter
            // 
            this.tbInstitutionTableAdapter.ClearBeforeFill = true;
            // 
            // FrmViewGeneralUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 360);
            this.Controls.Add(this.reportViewer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmViewGeneralUsers";
            this.Text = "Reporte de Usuarios";
            this.Load += new System.EventHandler(this.FrmViewGeneralUsers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSetInfoUsers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbUsersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetInfoInstitution)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbInstitutionBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private DataSetInfoUsers dataSetInfoUsers;
        private System.Windows.Forms.BindingSource tbUsersBindingSource;
        private DataSetInfoUsersTableAdapters.tbUsersTableAdapter tbUsersTableAdapter;
        private Inventory.DataSetInfoInstitution dataSetInfoInstitution;
        private System.Windows.Forms.BindingSource tbInstitutionBindingSource;
        private Inventory.DataSetInfoInstitutionTableAdapters.tbInstitutionTableAdapter tbInstitutionTableAdapter;
    }
}