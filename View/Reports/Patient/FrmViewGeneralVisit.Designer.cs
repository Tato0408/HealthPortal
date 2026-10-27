namespace HealthPortal.View.Reports.Patient
{
    partial class FrmViewGeneralVisit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmViewGeneralVisit));
            this.tbVisitasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetInfoVisit = new HealthPortal.View.Reports.Patient.DataSetInfoVisit();
            this.tbInstitutionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetInfoInstitution = new HealthPortal.View.Reports.Inventory.DataSetInfoInstitution();
            this.tbInstitutionTableAdapter = new HealthPortal.View.Reports.Inventory.DataSetInfoInstitutionTableAdapters.tbInstitutionTableAdapter();
            this.panelTop = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSearchPatient = new System.Windows.Forms.TextBox();
            this.btnNew = new CustomControls.RJButton();
            this.rjButton1 = new CustomControls.RJButton();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpDesde = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpHasta = new System.Windows.Forms.DateTimePicker();
            this.btnFiltrar = new CustomControls.RJButton();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tbVisitasTableAdapter = new HealthPortal.View.Reports.Patient.DataSetInfoVisitTableAdapters.tbVisitasTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.tbVisitasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetInfoVisit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbInstitutionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetInfoInstitution)).BeginInit();
            this.panelTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbVisitasBindingSource
            // 
            this.tbVisitasBindingSource.DataMember = "tbVisitas";
            this.tbVisitasBindingSource.DataSource = this.dataSetInfoVisit;
            // 
            // dataSetInfoVisit
            // 
            this.dataSetInfoVisit.DataSetName = "DataSetInfoVisit";
            this.dataSetInfoVisit.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbInstitutionBindingSource
            // 
            this.tbInstitutionBindingSource.DataMember = "tbInstitution";
            this.tbInstitutionBindingSource.DataSource = this.dataSetInfoInstitution;
            // 
            // dataSetInfoInstitution
            // 
            this.dataSetInfoInstitution.DataSetName = "DataSetInfoInstitution";
            this.dataSetInfoInstitution.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbInstitutionTableAdapter
            // 
            this.tbInstitutionTableAdapter.ClearBeforeFill = true;
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(202)))), ((int)(((byte)(230)))));
            this.panelTop.Controls.Add(this.label1);
            this.panelTop.Controls.Add(this.txtSearchPatient);
            this.panelTop.Controls.Add(this.btnNew);
            this.panelTop.Controls.Add(this.rjButton1);
            this.panelTop.Controls.Add(this.label3);
            this.panelTop.Controls.Add(this.dtpDesde);
            this.panelTop.Controls.Add(this.label2);
            this.panelTop.Controls.Add(this.dtpHasta);
            this.panelTop.Controls.Add(this.btnFiltrar);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1278, 68);
            this.panelTop.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label1.Location = new System.Drawing.Point(10, 17);
            this.label1.Margin = new System.Windows.Forms.Padding(10, 17, 3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 23);
            this.label1.TabIndex = 12;
            this.label1.Text = "Buscar paciente:";
            // 
            // txtSearchPatient
            // 
            this.txtSearchPatient.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchPatient.Location = new System.Drawing.Point(157, 17);
            this.txtSearchPatient.Margin = new System.Windows.Forms.Padding(10, 17, 3, 3);
            this.txtSearchPatient.Name = "txtSearchPatient";
            this.txtSearchPatient.Size = new System.Drawing.Size(276, 30);
            this.txtSearchPatient.TabIndex = 17;
            // 
            // btnNew
            // 
            this.btnNew.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(183)))), ((int)(((byte)(3)))));
            this.btnNew.BackGroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(183)))), ((int)(((byte)(3)))));
            this.btnNew.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(183)))), ((int)(((byte)(3)))));
            this.btnNew.BorderRadius = 40;
            this.btnNew.BorderSize = 0;
            this.btnNew.FlatAppearance.BorderSize = 0;
            this.btnNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNew.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnNew.ForeColor = System.Drawing.Color.Black;
            this.btnNew.Location = new System.Drawing.Point(446, 8);
            this.btnNew.Margin = new System.Windows.Forms.Padding(10, 8, 3, 3);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(150, 46);
            this.btnNew.TabIndex = 18;
            this.btnNew.Text = "Generar Reporte";
            this.btnNew.TextColor = System.Drawing.Color.Black;
            this.btnNew.UseVisualStyleBackColor = false;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click_1);
            // 
            // rjButton1
            // 
            this.rjButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(183)))), ((int)(((byte)(3)))));
            this.rjButton1.BackGroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(183)))), ((int)(((byte)(3)))));
            this.rjButton1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(183)))), ((int)(((byte)(3)))));
            this.rjButton1.BorderRadius = 40;
            this.rjButton1.BorderSize = 0;
            this.rjButton1.FlatAppearance.BorderSize = 0;
            this.rjButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.rjButton1.ForeColor = System.Drawing.Color.Black;
            this.rjButton1.Location = new System.Drawing.Point(609, 8);
            this.rjButton1.Margin = new System.Windows.Forms.Padding(10, 8, 3, 3);
            this.rjButton1.Name = "rjButton1";
            this.rjButton1.Size = new System.Drawing.Size(150, 46);
            this.rjButton1.TabIndex = 19;
            this.rjButton1.Text = "Mostrar todo";
            this.rjButton1.TextColor = System.Drawing.Color.Black;
            this.rjButton1.UseVisualStyleBackColor = false;
            this.rjButton1.Click += new System.EventHandler(this.rjButton1_Click_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(765, 17);
            this.label3.Margin = new System.Windows.Forms.Padding(3, 17, 3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 23);
            this.label3.TabIndex = 14;
            this.label3.Text = "Hasta:";
            // 
            // dtpDesde
            // 
            this.dtpDesde.CalendarForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dtpDesde.CustomFormat = "yyyy-MM-dd";
            this.dtpDesde.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dtpDesde.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDesde.Location = new System.Drawing.Point(828, 15);
            this.dtpDesde.Margin = new System.Windows.Forms.Padding(3, 15, 3, 3);
            this.dtpDesde.Name = "dtpDesde";
            this.dtpDesde.Size = new System.Drawing.Size(132, 30);
            this.dtpDesde.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(966, 17);
            this.label2.Margin = new System.Windows.Forms.Padding(3, 17, 3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 23);
            this.label2.TabIndex = 13;
            this.label2.Text = "Desde:";
            // 
            // dtpHasta
            // 
            this.dtpHasta.CalendarForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dtpHasta.CustomFormat = "yyyy-MM-dd";
            this.dtpHasta.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dtpHasta.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpHasta.Location = new System.Drawing.Point(1033, 15);
            this.dtpHasta.Margin = new System.Windows.Forms.Padding(3, 15, 3, 3);
            this.dtpHasta.Name = "dtpHasta";
            this.dtpHasta.Size = new System.Drawing.Size(132, 30);
            this.dtpHasta.TabIndex = 16;
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(183)))), ((int)(((byte)(3)))));
            this.btnFiltrar.BackGroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(183)))), ((int)(((byte)(3)))));
            this.btnFiltrar.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(183)))), ((int)(((byte)(3)))));
            this.btnFiltrar.BorderRadius = 40;
            this.btnFiltrar.BorderSize = 0;
            this.btnFiltrar.FlatAppearance.BorderSize = 0;
            this.btnFiltrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFiltrar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnFiltrar.ForeColor = System.Drawing.Color.Black;
            this.btnFiltrar.Location = new System.Drawing.Point(1178, 8);
            this.btnFiltrar.Margin = new System.Windows.Forms.Padding(10, 8, 3, 3);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(87, 46);
            this.btnFiltrar.TabIndex = 20;
            this.btnFiltrar.Text = "Filtrar";
            this.btnFiltrar.TextColor = System.Drawing.Color.Black;
            this.btnFiltrar.UseVisualStyleBackColor = false;
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click_1);
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.tbVisitasBindingSource;
            reportDataSource2.Name = "DataSet2";
            reportDataSource2.Value = this.tbInstitutionBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "HealthPortal.View.Reports.Patient.General_Visit.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 68);
            this.reportViewer1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1278, 292);
            this.reportViewer1.TabIndex = 2;
            // 
            // tbVisitasTableAdapter
            // 
            this.tbVisitasTableAdapter.ClearBeforeFill = true;
            // 
            // FrmViewGeneralVisit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1278, 360);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.panelTop);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmViewGeneralVisit";
            this.Text = "Reporte de Visitas";
            this.Load += new System.EventHandler(this.FrmViewGeneralVisit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tbVisitasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetInfoVisit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbInstitutionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetInfoInstitution)).EndInit();
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private DataSetInfoVisit dataSetInfoVisit;
        private System.Windows.Forms.BindingSource tbVisitasBindingSource;
        private DataSetInfoVisitTableAdapters.tbVisitasTableAdapter tbVisitasTableAdapter;
        private Inventory.DataSetInfoInstitution dataSetInfoInstitution;
        private System.Windows.Forms.BindingSource tbInstitutionBindingSource;
        private Inventory.DataSetInfoInstitutionTableAdapters.tbInstitutionTableAdapter tbInstitutionTableAdapter;
        private System.Windows.Forms.FlowLayoutPanel panelTop;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txtSearchPatient;
        public CustomControls.RJButton btnNew;
        public CustomControls.RJButton rjButton1;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.DateTimePicker dtpDesde;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.DateTimePicker dtpHasta;
        public CustomControls.RJButton btnFiltrar;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
    }
}