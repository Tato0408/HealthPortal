namespace HealthPortal.View.Reports.Patient
{
    partial class FrmViewGeneralPatient
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource4 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmViewGeneralPatient));
            this.tbPatientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetInfoPatient = new HealthPortal.View.Reports.Patient.DataSetInfoPatient();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tbPatientTableAdapter = new HealthPortal.View.Reports.Patient.DataSetInfoPatientTableAdapters.tbPatientTableAdapter();
            this.dataSetInfoInstitution = new HealthPortal.View.Reports.Inventory.DataSetInfoInstitution();
            this.tbInstitutionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbInstitutionTableAdapter = new HealthPortal.View.Reports.Inventory.DataSetInfoInstitutionTableAdapters.tbInstitutionTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.tbPatientBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetInfoPatient)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetInfoInstitution)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbInstitutionBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tbPatientBindingSource
            // 
            this.tbPatientBindingSource.DataMember = "tbPatient";
            this.tbPatientBindingSource.DataSource = this.dataSetInfoPatient;
            // 
            // dataSetInfoPatient
            // 
            this.dataSetInfoPatient.DataSetName = "DataSetInfoPatient";
            this.dataSetInfoPatient.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource3.Name = "DataSetPatient";
            reportDataSource3.Value = this.tbPatientBindingSource;
            reportDataSource4.Name = "DataSetInstitution";
            reportDataSource4.Value = this.tbInstitutionBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource4);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "HealthPortal.View.Reports.Patient.General_Patient.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(711, 360);
            this.reportViewer1.TabIndex = 0;
            // 
            // tbPatientTableAdapter
            // 
            this.tbPatientTableAdapter.ClearBeforeFill = true;
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
            // FrmViewGeneralPatient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 360);
            this.Controls.Add(this.reportViewer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmViewGeneralPatient";
            this.Text = "Registro de pacientes";
            this.Load += new System.EventHandler(this.FrmViewGeneralPatient_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tbPatientBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetInfoPatient)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetInfoInstitution)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbInstitutionBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private DataSetInfoPatient dataSetInfoPatient;
        private System.Windows.Forms.BindingSource tbPatientBindingSource;
        private DataSetInfoPatientTableAdapters.tbPatientTableAdapter tbPatientTableAdapter;
        private Inventory.DataSetInfoInstitution dataSetInfoInstitution;
        private System.Windows.Forms.BindingSource tbInstitutionBindingSource;
        private Inventory.DataSetInfoInstitutionTableAdapters.tbInstitutionTableAdapter tbInstitutionTableAdapter;
    }
}