namespace HealthPortal.View.PatientAdministration
{
    partial class FrmPatientAdministration
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPatientAdministration));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.cmsDataGrid = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmsDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsView = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsUpdate = new System.Windows.Forms.ToolStripMenuItem();
            this.reporteDeVisitaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tlpInventory = new System.Windows.Forms.TableLayoutPanel();
            this.pnlTitle = new System.Windows.Forms.Panel();
            this.tlpTitle = new System.Windows.Forms.TableLayoutPanel();
            this.tlpTitleSub = new System.Windows.Forms.TableLayoutPanel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.tlpControls = new System.Windows.Forms.TableLayoutPanel();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnResize = new System.Windows.Forms.Button();
            this.pnlSide = new CustomControls.PanelCustom();
            this.tlpSide = new System.Windows.Forms.TableLayoutPanel();
            this.grpAddVisit = new System.Windows.Forms.GroupBox();
            this.tlpSub1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnNew = new CustomControls.RJButton();
            this.grpPatientInfo = new System.Windows.Forms.GroupBox();
            this.tlpSub2 = new System.Windows.Forms.TableLayoutPanel();
            this.llbPatientsTreated = new System.Windows.Forms.LinkLabel();
            this.btnSearch = new CustomControls.RJButton();
            this.txtSearch = new CustomControls.CustomTextBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.btnVisitReport = new CustomControls.RJButton();
            this.btnReport = new CustomControls.RJButton();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dgvVisitInfo = new System.Windows.Forms.DataGridView();
            this.tlpMainSub1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnShowAll = new CustomControls.RJButton();
            this.cmbRole = new System.Windows.Forms.ComboBox();
            this.lblPersonType = new System.Windows.Forms.Label();
            this.cmbGrade = new System.Windows.Forms.ComboBox();
            this.lblGrade = new System.Windows.Forms.Label();
            this.cmbSpecialty = new System.Windows.Forms.ComboBox();
            this.lblSpecialty = new System.Windows.Forms.Label();
            this.btnFilter = new CustomControls.RJButton();
            this.lblFilterByDate = new System.Windows.Forms.Label();
            this.dtpVisitDate = new System.Windows.Forms.DateTimePicker();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dgvPacientInfo = new System.Windows.Forms.DataGridView();
            this.cmsDataGridPatient = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmsInsertPatient = new System.Windows.Forms.ToolStripMenuItem();
            this.PatientDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.ViewPatient = new System.Windows.Forms.ToolStripMenuItem();
            this.UpdatePatient = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnRefreshPatient = new CustomControls.RJButton();
            this.txtSearchPatientInfo = new CustomControls.CustomTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSearchPatientInfo = new CustomControls.RJButton();
            this.cmsDataGrid.SuspendLayout();
            this.tlpInventory.SuspendLayout();
            this.pnlTitle.SuspendLayout();
            this.tlpTitle.SuspendLayout();
            this.tlpTitleSub.SuspendLayout();
            this.tlpControls.SuspendLayout();
            this.pnlSide.SuspendLayout();
            this.tlpSide.SuspendLayout();
            this.grpAddVisit.SuspendLayout();
            this.tlpSub1.SuspendLayout();
            this.grpPatientInfo.SuspendLayout();
            this.tlpSub2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVisitInfo)).BeginInit();
            this.tlpMainSub1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPacientInfo)).BeginInit();
            this.cmsDataGridPatient.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmsDataGrid
            // 
            this.cmsDataGrid.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmsDataGrid.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmsDataGrid.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmsDelete,
            this.cmsView,
            this.cmsUpdate,
            this.reporteDeVisitaToolStripMenuItem});
            this.cmsDataGrid.Name = "cmsDataGrid";
            this.cmsDataGrid.Size = new System.Drawing.Size(328, 108);
            // 
            // cmsDelete
            // 
            this.cmsDelete.Image = global::HealthPortal.Properties.Resources.papelera_xmark;
            this.cmsDelete.Name = "cmsDelete";
            this.cmsDelete.Size = new System.Drawing.Size(327, 26);
            this.cmsDelete.Text = "Eliminar visita";
            // 
            // cmsView
            // 
            this.cmsView.Image = global::HealthPortal.Properties.Resources.descripcion_general;
            this.cmsView.Name = "cmsView";
            this.cmsView.Size = new System.Drawing.Size(327, 26);
            this.cmsView.Text = "Ver Información de la visita";
            // 
            // cmsUpdate
            // 
            this.cmsUpdate.Image = global::HealthPortal.Properties.Resources.actualizar__1_;
            this.cmsUpdate.Name = "cmsUpdate";
            this.cmsUpdate.Size = new System.Drawing.Size(327, 26);
            this.cmsUpdate.Text = "Actualizar información de la visita";
            // 
            // reporteDeVisitaToolStripMenuItem
            // 
            this.reporteDeVisitaToolStripMenuItem.Name = "reporteDeVisitaToolStripMenuItem";
            this.reporteDeVisitaToolStripMenuItem.Size = new System.Drawing.Size(327, 26);
            this.reporteDeVisitaToolStripMenuItem.Text = "Reporte de visita";
            // 
            // tlpInventory
            // 
            this.tlpInventory.ColumnCount = 5;
            this.tlpInventory.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2.830345F));
            this.tlpInventory.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.45971F));
            this.tlpInventory.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2.830345F));
            this.tlpInventory.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 66.04926F));
            this.tlpInventory.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2.830345F));
            this.tlpInventory.Controls.Add(this.pnlTitle, 0, 0);
            this.tlpInventory.Controls.Add(this.pnlSide, 1, 2);
            this.tlpInventory.Controls.Add(this.tabControl1, 3, 2);
            this.tlpInventory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpInventory.Location = new System.Drawing.Point(0, 0);
            this.tlpInventory.Margin = new System.Windows.Forms.Padding(4);
            this.tlpInventory.Name = "tlpInventory";
            this.tlpInventory.RowCount = 4;
            this.tlpInventory.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tlpInventory.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.630542F));
            this.tlpInventory.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 76.4532F));
            this.tlpInventory.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.630542F));
            this.tlpInventory.Size = new System.Drawing.Size(1827, 880);
            this.tlpInventory.TabIndex = 1;
            // 
            // pnlTitle
            // 
            this.pnlTitle.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnlTitle.BackColor = System.Drawing.Color.White;
            this.tlpInventory.SetColumnSpan(this.pnlTitle, 5);
            this.pnlTitle.Controls.Add(this.tlpTitle);
            this.pnlTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlTitle.Location = new System.Drawing.Point(0, 0);
            this.pnlTitle.Margin = new System.Windows.Forms.Padding(0);
            this.pnlTitle.Name = "pnlTitle";
            this.pnlTitle.Size = new System.Drawing.Size(1827, 125);
            this.pnlTitle.TabIndex = 1;
            // 
            // tlpTitle
            // 
            this.tlpTitle.ColumnCount = 2;
            this.tlpTitle.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 72.9927F));
            this.tlpTitle.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27.0073F));
            this.tlpTitle.Controls.Add(this.tlpTitleSub, 0, 0);
            this.tlpTitle.Controls.Add(this.tlpControls, 1, 0);
            this.tlpTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpTitle.Location = new System.Drawing.Point(0, 0);
            this.tlpTitle.Margin = new System.Windows.Forms.Padding(0);
            this.tlpTitle.Name = "tlpTitle";
            this.tlpTitle.RowCount = 1;
            this.tlpTitle.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpTitle.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 125F));
            this.tlpTitle.Size = new System.Drawing.Size(1827, 125);
            this.tlpTitle.TabIndex = 1;
            // 
            // tlpTitleSub
            // 
            this.tlpTitleSub.ColumnCount = 3;
            this.tlpTitleSub.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.0022F));
            this.tlpTitleSub.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 89.9956F));
            this.tlpTitleSub.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.0022F));
            this.tlpTitleSub.Controls.Add(this.lblTitle, 1, 1);
            this.tlpTitleSub.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpTitleSub.Location = new System.Drawing.Point(0, 0);
            this.tlpTitleSub.Margin = new System.Windows.Forms.Padding(0);
            this.tlpTitleSub.Name = "tlpTitleSub";
            this.tlpTitleSub.RowCount = 3;
            this.tlpTitleSub.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tlpTitleSub.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tlpTitleSub.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpTitleSub.Size = new System.Drawing.Size(1333, 125);
            this.tlpTitleSub.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTitle.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(202)))), ((int)(((byte)(230)))));
            this.lblTitle.Location = new System.Drawing.Point(66, 43);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(1199, 50);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "Visitas";
            // 
            // tlpControls
            // 
            this.tlpControls.ColumnCount = 5;
            this.tlpControls.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpControls.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.86792F));
            this.tlpControls.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 1.886792F));
            this.tlpControls.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.86792F));
            this.tlpControls.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.37736F));
            this.tlpControls.Controls.Add(this.btnExit, 3, 1);
            this.tlpControls.Controls.Add(this.btnResize, 1, 1);
            this.tlpControls.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpControls.Location = new System.Drawing.Point(1333, 0);
            this.tlpControls.Margin = new System.Windows.Forms.Padding(0);
            this.tlpControls.Name = "tlpControls";
            this.tlpControls.RowCount = 3;
            this.tlpControls.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpControls.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpControls.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpControls.Size = new System.Drawing.Size(494, 125);
            this.tlpControls.TabIndex = 1;
            // 
            // btnExit
            // 
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnExit.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Image = global::HealthPortal.Properties.Resources.quit;
            this.btnExit.Location = new System.Drawing.Point(349, 41);
            this.btnExit.Margin = new System.Windows.Forms.Padding(0);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(93, 41);
            this.btnExit.TabIndex = 38;
            this.btnExit.TabStop = false;
            this.btnExit.UseVisualStyleBackColor = false;
            // 
            // btnResize
            // 
            this.btnResize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnResize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnResize.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnResize.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnResize.FlatAppearance.BorderSize = 0;
            this.btnResize.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnResize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnResize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResize.ForeColor = System.Drawing.Color.White;
            this.btnResize.Image = ((System.Drawing.Image)(resources.GetObject("btnResize.Image")));
            this.btnResize.Location = new System.Drawing.Point(247, 41);
            this.btnResize.Margin = new System.Windows.Forms.Padding(0);
            this.btnResize.Name = "btnResize";
            this.btnResize.Size = new System.Drawing.Size(93, 41);
            this.btnResize.TabIndex = 39;
            this.btnResize.TabStop = false;
            this.btnResize.UseVisualStyleBackColor = false;
            // 
            // pnlSide
            // 
            this.pnlSide.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnlSide.BackColor = System.Drawing.Color.White;
            this.pnlSide.BorderRadius = 30;
            this.pnlSide.Controls.Add(this.tlpSide);
            this.pnlSide.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlSide.ForeColor = System.Drawing.Color.Black;
            this.pnlSide.GradientAngle = 90F;
            this.pnlSide.GradientBottomColor = System.Drawing.Color.White;
            this.pnlSide.GradientTopColor = System.Drawing.Color.White;
            this.pnlSide.Location = new System.Drawing.Point(51, 165);
            this.pnlSide.Margin = new System.Windows.Forms.Padding(0);
            this.pnlSide.Name = "pnlSide";
            this.pnlSide.Size = new System.Drawing.Size(465, 672);
            this.pnlSide.TabIndex = 2;
            // 
            // tlpSide
            // 
            this.tlpSide.ColumnCount = 3;
            this.tlpSide.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.85F));
            this.tlpSide.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 74.3F));
            this.tlpSide.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.85F));
            this.tlpSide.Controls.Add(this.grpAddVisit, 1, 3);
            this.tlpSide.Controls.Add(this.grpPatientInfo, 1, 1);
            this.tlpSide.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpSide.Location = new System.Drawing.Point(0, 0);
            this.tlpSide.Margin = new System.Windows.Forms.Padding(4);
            this.tlpSide.Name = "tlpSide";
            this.tlpSide.RowCount = 5;
            this.tlpSide.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.007008F));
            this.tlpSide.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 65.26527F));
            this.tlpSide.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.105105F));
            this.tlpSide.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.61562F));
            this.tlpSide.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.007008F));
            this.tlpSide.Size = new System.Drawing.Size(465, 672);
            this.tlpSide.TabIndex = 0;
            // 
            // grpAddVisit
            // 
            this.grpAddVisit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.grpAddVisit.Controls.Add(this.tlpSub1);
            this.grpAddVisit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpAddVisit.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpAddVisit.ForeColor = System.Drawing.Color.DarkGray;
            this.grpAddVisit.Location = new System.Drawing.Point(59, 519);
            this.grpAddVisit.Margin = new System.Windows.Forms.Padding(0);
            this.grpAddVisit.Name = "grpAddVisit";
            this.grpAddVisit.Padding = new System.Windows.Forms.Padding(4);
            this.grpAddVisit.Size = new System.Drawing.Size(345, 104);
            this.grpAddVisit.TabIndex = 1;
            this.grpAddVisit.TabStop = false;
            this.grpAddVisit.Text = "Añadir visitas";
            // 
            // tlpSub1
            // 
            this.tlpSub1.ColumnCount = 3;
            this.tlpSub1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.33F));
            this.tlpSub1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 83.34F));
            this.tlpSub1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.33F));
            this.tlpSub1.Controls.Add(this.btnNew, 1, 1);
            this.tlpSub1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpSub1.Location = new System.Drawing.Point(4, 21);
            this.tlpSub1.Margin = new System.Windows.Forms.Padding(4);
            this.tlpSub1.Name = "tlpSub1";
            this.tlpSub1.RowCount = 3;
            this.tlpSub1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 26.92F));
            this.tlpSub1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 46.16F));
            this.tlpSub1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 26.92F));
            this.tlpSub1.Size = new System.Drawing.Size(337, 79);
            this.tlpSub1.TabIndex = 0;
            // 
            // btnNew
            // 
            this.btnNew.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(183)))), ((int)(((byte)(3)))));
            this.btnNew.BackGroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(183)))), ((int)(((byte)(3)))));
            this.btnNew.BorderColor = System.Drawing.Color.CornflowerBlue;
            this.btnNew.BorderRadius = 30;
            this.btnNew.BorderSize = 0;
            this.btnNew.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNew.FlatAppearance.BorderSize = 0;
            this.btnNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNew.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNew.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(91)))));
            this.btnNew.Location = new System.Drawing.Point(28, 21);
            this.btnNew.Margin = new System.Windows.Forms.Padding(0);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(280, 34);
            this.btnNew.TabIndex = 1;
            this.btnNew.TabStop = false;
            this.btnNew.Text = "Nueva Visita";
            this.btnNew.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(91)))));
            this.btnNew.UseVisualStyleBackColor = false;
            // 
            // grpPatientInfo
            // 
            this.grpPatientInfo.Controls.Add(this.tlpSub2);
            this.grpPatientInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpPatientInfo.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold);
            this.grpPatientInfo.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.grpPatientInfo.Location = new System.Drawing.Point(63, 51);
            this.grpPatientInfo.Margin = new System.Windows.Forms.Padding(4);
            this.grpPatientInfo.Name = "grpPatientInfo";
            this.grpPatientInfo.Padding = new System.Windows.Forms.Padding(4);
            this.grpPatientInfo.Size = new System.Drawing.Size(337, 430);
            this.grpPatientInfo.TabIndex = 2;
            this.grpPatientInfo.TabStop = false;
            this.grpPatientInfo.Text = "Información de pacientes";
            // 
            // tlpSub2
            // 
            this.tlpSub2.ColumnCount = 4;
            this.tlpSub2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.331947F));
            this.tlpSub2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 41.66805F));
            this.tlpSub2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 41.66805F));
            this.tlpSub2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.331947F));
            this.tlpSub2.Controls.Add(this.llbPatientsTreated, 1, 7);
            this.tlpSub2.Controls.Add(this.btnSearch, 2, 4);
            this.tlpSub2.Controls.Add(this.txtSearch, 1, 2);
            this.tlpSub2.Controls.Add(this.lblSearch, 1, 1);
            this.tlpSub2.Controls.Add(this.btnVisitReport, 1, 11);
            this.tlpSub2.Controls.Add(this.btnReport, 1, 12);
            this.tlpSub2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpSub2.Location = new System.Drawing.Point(4, 21);
            this.tlpSub2.Margin = new System.Windows.Forms.Padding(4);
            this.tlpSub2.Name = "tlpSub2";
            this.tlpSub2.RowCount = 15;
            this.tlpSub2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.989553F));
            this.tlpSub2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.935065F));
            this.tlpSub2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.831169F));
            this.tlpSub2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2.597403F));
            this.tlpSub2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.311688F));
            this.tlpSub2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.116883F));
            this.tlpSub2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.935065F));
            this.tlpSub2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.272727F));
            this.tlpSub2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2.909212F));
            this.tlpSub2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.386872F));
            this.tlpSub2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2.863127F));
            this.tlpSub2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.35802F));
            this.tlpSub2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.87013F));
            this.tlpSub2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.7013F));
            this.tlpSub2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 17F));
            this.tlpSub2.Size = new System.Drawing.Size(329, 405);
            this.tlpSub2.TabIndex = 3;
            // 
            // llbPatientsTreated
            // 
            this.llbPatientsTreated.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(183)))), ((int)(((byte)(3)))));
            this.llbPatientsTreated.AutoSize = true;
            this.tlpSub2.SetColumnSpan(this.llbPatientsTreated, 2);
            this.llbPatientsTreated.Dock = System.Windows.Forms.DockStyle.Fill;
            this.llbPatientsTreated.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llbPatientsTreated.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(91)))));
            this.llbPatientsTreated.Location = new System.Drawing.Point(31, 149);
            this.llbPatientsTreated.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.llbPatientsTreated.Name = "llbPatientsTreated";
            this.tlpSub2.SetRowSpan(this.llbPatientsTreated, 2);
            this.llbPatientsTreated.Size = new System.Drawing.Size(266, 39);
            this.llbPatientsTreated.TabIndex = 37;
            this.llbPatientsTreated.TabStop = true;
            this.llbPatientsTreated.Text = "Pacientes Atendidos";
            this.llbPatientsTreated.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(91)))));
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(183)))), ((int)(((byte)(3)))));
            this.btnSearch.BackGroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(183)))), ((int)(((byte)(3)))));
            this.btnSearch.BorderColor = System.Drawing.Color.CornflowerBlue;
            this.btnSearch.BorderRadius = 30;
            this.btnSearch.BorderSize = 0;
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(91)))));
            this.btnSearch.Location = new System.Drawing.Point(164, 86);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(0);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(137, 32);
            this.btnSearch.TabIndex = 35;
            this.btnSearch.TabStop = false;
            this.btnSearch.Text = "Buscar";
            this.btnSearch.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(91)))));
            this.btnSearch.UseVisualStyleBackColor = false;
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.Color.White;
            this.txtSearch.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(202)))), ((int)(((byte)(230)))));
            this.txtSearch.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtSearch.BorderRadius = 15;
            this.txtSearch.BorderSize = 2;
            this.tlpSub2.SetColumnSpan(this.txtSearch, 2);
            this.txtSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(91)))));
            this.txtSearch.Location = new System.Drawing.Point(27, 42);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(0);
            this.txtSearch.MaxLength = 60;
            this.txtSearch.Multiline = false;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Padding = new System.Windows.Forms.Padding(27, 11, 27, 11);
            this.txtSearch.PasswordChar = false;
            this.txtSearch.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtSearch.PlaceholderText = "";
            this.txtSearch.SelectionLength = 0;
            this.txtSearch.SelectionStart = 0;
            this.txtSearch.Size = new System.Drawing.Size(274, 34);
            this.txtSearch.TabIndex = 34;
            this.txtSearch.TabStop = false;
            this.txtSearch.Tag = "name";
            this.txtSearch.Texts = "";
            this.txtSearch.UnderlinedStyle = false;
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.tlpSub2.SetColumnSpan(this.lblSearch, 2);
            this.lblSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSearch.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(91)))));
            this.lblSearch.Location = new System.Drawing.Point(31, 23);
            this.lblSearch.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(266, 19);
            this.lblSearch.TabIndex = 33;
            this.lblSearch.Text = "Buscar visita de paciente";
            // 
            // btnVisitReport
            // 
            this.btnVisitReport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(183)))), ((int)(((byte)(3)))));
            this.btnVisitReport.BackGroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(183)))), ((int)(((byte)(3)))));
            this.btnVisitReport.BorderColor = System.Drawing.Color.CornflowerBlue;
            this.btnVisitReport.BorderRadius = 40;
            this.btnVisitReport.BorderSize = 0;
            this.tlpSub2.SetColumnSpan(this.btnVisitReport, 2);
            this.btnVisitReport.FlatAppearance.BorderSize = 0;
            this.btnVisitReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVisitReport.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(91)))));
            this.btnVisitReport.Location = new System.Drawing.Point(30, 233);
            this.btnVisitReport.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnVisitReport.Name = "btnVisitReport";
            this.btnVisitReport.Size = new System.Drawing.Size(267, 34);
            this.btnVisitReport.TabIndex = 41;
            this.btnVisitReport.Text = "Generar Reporte Visitas";
            this.btnVisitReport.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(91)))));
            this.btnVisitReport.UseVisualStyleBackColor = false;
            // 
            // btnReport
            // 
            this.btnReport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(183)))), ((int)(((byte)(3)))));
            this.btnReport.BackGroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(183)))), ((int)(((byte)(3)))));
            this.btnReport.BorderColor = System.Drawing.Color.CornflowerBlue;
            this.btnReport.BorderRadius = 40;
            this.btnReport.BorderSize = 0;
            this.tlpSub2.SetColumnSpan(this.btnReport, 2);
            this.btnReport.FlatAppearance.BorderSize = 0;
            this.btnReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReport.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(91)))));
            this.btnReport.Location = new System.Drawing.Point(30, 277);
            this.btnReport.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(267, 32);
            this.btnReport.TabIndex = 42;
            this.btnReport.Text = "Generar Reporte Paciente";
            this.btnReport.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(91)))));
            this.btnReport.UseVisualStyleBackColor = false;
            // 
            // tabControl1
            // 
            this.tabControl1.ContextMenuStrip = this.cmsDataGrid;
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.tabControl1.Location = new System.Drawing.Point(570, 167);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1200, 668);
            this.tabControl1.TabIndex = 4;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dgvVisitInfo);
            this.tabPage1.Controls.Add(this.tlpMainSub1);
            this.tabPage1.Location = new System.Drawing.Point(4, 30);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Size = new System.Drawing.Size(1192, 634);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Visitas";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dgvVisitInfo
            // 
            this.dgvVisitInfo.AllowUserToAddRows = false;
            this.dgvVisitInfo.AllowUserToDeleteRows = false;
            this.dgvVisitInfo.AllowUserToResizeColumns = false;
            this.dgvVisitInfo.AllowUserToResizeRows = false;
            this.dgvVisitInfo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvVisitInfo.BackgroundColor = System.Drawing.Color.White;
            this.dgvVisitInfo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvVisitInfo.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvVisitInfo.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.dgvVisitInfo.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            dataGridViewCellStyle1.NullValue = "-----";
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(202)))), ((int)(((byte)(230)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvVisitInfo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvVisitInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVisitInfo.ContextMenuStrip = this.cmsDataGrid;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.NullValue = "-----";
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(202)))), ((int)(((byte)(230)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvVisitInfo.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvVisitInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvVisitInfo.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.dgvVisitInfo.Location = new System.Drawing.Point(3, 125);
            this.dgvVisitInfo.Margin = new System.Windows.Forms.Padding(0);
            this.dgvVisitInfo.MultiSelect = false;
            this.dgvVisitInfo.Name = "dgvVisitInfo";
            this.dgvVisitInfo.ReadOnly = true;
            this.dgvVisitInfo.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            dataGridViewCellStyle3.NullValue = "-----";
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(202)))), ((int)(((byte)(230)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvVisitInfo.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvVisitInfo.RowHeadersVisible = false;
            this.dgvVisitInfo.RowHeadersWidth = 62;
            this.dgvVisitInfo.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvVisitInfo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvVisitInfo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvVisitInfo.Size = new System.Drawing.Size(1186, 507);
            this.dgvVisitInfo.TabIndex = 41;
            this.dgvVisitInfo.TabStop = false;
            // 
            // tlpMainSub1
            // 
            this.tlpMainSub1.ColumnCount = 13;
            this.tlpMainSub1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2.880883F));
            this.tlpMainSub1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.30904F));
            this.tlpMainSub1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2.880883F));
            this.tlpMainSub1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.30408F));
            this.tlpMainSub1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2.880883F));
            this.tlpMainSub1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.30408F));
            this.tlpMainSub1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2.880883F));
            this.tlpMainSub1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.30408F));
            this.tlpMainSub1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2.880883F));
            this.tlpMainSub1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.30408F));
            this.tlpMainSub1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2.880883F));
            this.tlpMainSub1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.30848F));
            this.tlpMainSub1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2.880883F));
            this.tlpMainSub1.Controls.Add(this.btnShowAll, 11, 1);
            this.tlpMainSub1.Controls.Add(this.cmbRole, 9, 2);
            this.tlpMainSub1.Controls.Add(this.lblPersonType, 9, 1);
            this.tlpMainSub1.Controls.Add(this.cmbGrade, 7, 2);
            this.tlpMainSub1.Controls.Add(this.lblGrade, 7, 1);
            this.tlpMainSub1.Controls.Add(this.cmbSpecialty, 5, 2);
            this.tlpMainSub1.Controls.Add(this.lblSpecialty, 5, 1);
            this.tlpMainSub1.Controls.Add(this.btnFilter, 1, 1);
            this.tlpMainSub1.Controls.Add(this.lblFilterByDate, 3, 1);
            this.tlpMainSub1.Controls.Add(this.dtpVisitDate, 3, 2);
            this.tlpMainSub1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tlpMainSub1.Location = new System.Drawing.Point(3, 2);
            this.tlpMainSub1.Margin = new System.Windows.Forms.Padding(0);
            this.tlpMainSub1.Name = "tlpMainSub1";
            this.tlpMainSub1.RowCount = 4;
            this.tlpMainSub1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpMainSub1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 19F));
            this.tlpMainSub1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 31F));
            this.tlpMainSub1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpMainSub1.Size = new System.Drawing.Size(1186, 123);
            this.tlpMainSub1.TabIndex = 1;
            // 
            // btnShowAll
            // 
            this.btnShowAll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(183)))), ((int)(((byte)(3)))));
            this.btnShowAll.BackGroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(183)))), ((int)(((byte)(3)))));
            this.btnShowAll.BorderColor = System.Drawing.Color.CornflowerBlue;
            this.btnShowAll.BorderRadius = 30;
            this.btnShowAll.BorderSize = 0;
            this.btnShowAll.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnShowAll.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnShowAll.FlatAppearance.BorderSize = 0;
            this.btnShowAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowAll.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowAll.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(91)))));
            this.btnShowAll.Location = new System.Drawing.Point(954, 30);
            this.btnShowAll.Margin = new System.Windows.Forms.Padding(0);
            this.btnShowAll.Name = "btnShowAll";
            this.tlpMainSub1.SetRowSpan(this.btnShowAll, 2);
            this.btnShowAll.Size = new System.Drawing.Size(193, 61);
            this.btnShowAll.TabIndex = 40;
            this.btnShowAll.TabStop = false;
            this.btnShowAll.Text = "Mostrar todos";
            this.btnShowAll.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(91)))));
            this.btnShowAll.UseVisualStyleBackColor = false;
            // 
            // cmbRole
            // 
            this.cmbRole.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.cmbRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRole.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(91)))));
            this.cmbRole.FormattingEnabled = true;
            this.cmbRole.Location = new System.Drawing.Point(763, 68);
            this.cmbRole.Margin = new System.Windows.Forms.Padding(0);
            this.cmbRole.Name = "cmbRole";
            this.cmbRole.Size = new System.Drawing.Size(157, 29);
            this.cmbRole.TabIndex = 39;
            this.cmbRole.TabStop = false;
            // 
            // lblPersonType
            // 
            this.lblPersonType.AutoSize = true;
            this.lblPersonType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPersonType.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPersonType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(91)))));
            this.lblPersonType.Location = new System.Drawing.Point(763, 30);
            this.lblPersonType.Margin = new System.Windows.Forms.Padding(0);
            this.lblPersonType.Name = "lblPersonType";
            this.lblPersonType.Size = new System.Drawing.Size(157, 23);
            this.lblPersonType.TabIndex = 38;
            this.lblPersonType.Text = "Tipo de persona";
            // 
            // cmbGrade
            // 
            this.cmbGrade.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.cmbGrade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGrade.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(91)))));
            this.cmbGrade.FormattingEnabled = true;
            this.cmbGrade.Location = new System.Drawing.Point(572, 68);
            this.cmbGrade.Margin = new System.Windows.Forms.Padding(0);
            this.cmbGrade.Name = "cmbGrade";
            this.cmbGrade.Size = new System.Drawing.Size(157, 29);
            this.cmbGrade.TabIndex = 37;
            this.cmbGrade.TabStop = false;
            // 
            // lblGrade
            // 
            this.lblGrade.AutoSize = true;
            this.lblGrade.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblGrade.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGrade.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(91)))));
            this.lblGrade.Location = new System.Drawing.Point(572, 30);
            this.lblGrade.Margin = new System.Windows.Forms.Padding(0);
            this.lblGrade.Name = "lblGrade";
            this.lblGrade.Size = new System.Drawing.Size(157, 23);
            this.lblGrade.TabIndex = 36;
            this.lblGrade.Text = "Grado";
            // 
            // cmbSpecialty
            // 
            this.cmbSpecialty.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.cmbSpecialty.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSpecialty.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(91)))));
            this.cmbSpecialty.FormattingEnabled = true;
            this.cmbSpecialty.Location = new System.Drawing.Point(381, 68);
            this.cmbSpecialty.Margin = new System.Windows.Forms.Padding(0);
            this.cmbSpecialty.Name = "cmbSpecialty";
            this.cmbSpecialty.Size = new System.Drawing.Size(157, 29);
            this.cmbSpecialty.TabIndex = 35;
            this.cmbSpecialty.TabStop = false;
            // 
            // lblSpecialty
            // 
            this.lblSpecialty.AutoSize = true;
            this.lblSpecialty.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSpecialty.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSpecialty.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(91)))));
            this.lblSpecialty.Location = new System.Drawing.Point(381, 30);
            this.lblSpecialty.Margin = new System.Windows.Forms.Padding(0);
            this.lblSpecialty.Name = "lblSpecialty";
            this.lblSpecialty.Size = new System.Drawing.Size(157, 23);
            this.lblSpecialty.TabIndex = 34;
            this.lblSpecialty.Text = "Especialidad";
            // 
            // btnFilter
            // 
            this.btnFilter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(183)))), ((int)(((byte)(3)))));
            this.btnFilter.BackGroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(183)))), ((int)(((byte)(3)))));
            this.btnFilter.BorderColor = System.Drawing.Color.CornflowerBlue;
            this.btnFilter.BorderRadius = 30;
            this.btnFilter.BorderSize = 0;
            this.btnFilter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFilter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnFilter.FlatAppearance.BorderSize = 0;
            this.btnFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFilter.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFilter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(91)))));
            this.btnFilter.Location = new System.Drawing.Point(34, 30);
            this.btnFilter.Margin = new System.Windows.Forms.Padding(0);
            this.btnFilter.Name = "btnFilter";
            this.tlpMainSub1.SetRowSpan(this.btnFilter, 2);
            this.btnFilter.Size = new System.Drawing.Size(122, 61);
            this.btnFilter.TabIndex = 2;
            this.btnFilter.TabStop = false;
            this.btnFilter.Text = "Filtrar";
            this.btnFilter.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(91)))));
            this.btnFilter.UseVisualStyleBackColor = false;
            // 
            // lblFilterByDate
            // 
            this.lblFilterByDate.AutoSize = true;
            this.lblFilterByDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblFilterByDate.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFilterByDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(91)))));
            this.lblFilterByDate.Location = new System.Drawing.Point(190, 30);
            this.lblFilterByDate.Margin = new System.Windows.Forms.Padding(0);
            this.lblFilterByDate.Name = "lblFilterByDate";
            this.lblFilterByDate.Size = new System.Drawing.Size(157, 23);
            this.lblFilterByDate.TabIndex = 32;
            this.lblFilterByDate.Text = "Fecha de la visita";
            // 
            // dtpVisitDate
            // 
            this.dtpVisitDate.CalendarFont = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpVisitDate.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dtpVisitDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpVisitDate.Location = new System.Drawing.Point(190, 64);
            this.dtpVisitDate.Margin = new System.Windows.Forms.Padding(0);
            this.dtpVisitDate.Name = "dtpVisitDate";
            this.dtpVisitDate.Size = new System.Drawing.Size(157, 27);
            this.dtpVisitDate.TabIndex = 33;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dgvPacientInfo);
            this.tabPage2.Controls.Add(this.tableLayoutPanel1);
            this.tabPage2.Location = new System.Drawing.Point(4, 30);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage2.Size = new System.Drawing.Size(1192, 634);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Pacientes";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dgvPacientInfo
            // 
            this.dgvPacientInfo.AllowUserToAddRows = false;
            this.dgvPacientInfo.AllowUserToDeleteRows = false;
            this.dgvPacientInfo.AllowUserToResizeColumns = false;
            this.dgvPacientInfo.AllowUserToResizeRows = false;
            this.dgvPacientInfo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPacientInfo.BackgroundColor = System.Drawing.Color.White;
            this.dgvPacientInfo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvPacientInfo.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvPacientInfo.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.dgvPacientInfo.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            dataGridViewCellStyle4.NullValue = "-----";
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(202)))), ((int)(((byte)(230)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPacientInfo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvPacientInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPacientInfo.ContextMenuStrip = this.cmsDataGridPatient;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.NullValue = "-----";
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(202)))), ((int)(((byte)(230)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPacientInfo.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvPacientInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPacientInfo.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.dgvPacientInfo.Location = new System.Drawing.Point(3, 125);
            this.dgvPacientInfo.Margin = new System.Windows.Forms.Padding(0);
            this.dgvPacientInfo.MultiSelect = false;
            this.dgvPacientInfo.Name = "dgvPacientInfo";
            this.dgvPacientInfo.ReadOnly = true;
            this.dgvPacientInfo.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            dataGridViewCellStyle6.NullValue = "-----";
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(202)))), ((int)(((byte)(230)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPacientInfo.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvPacientInfo.RowHeadersVisible = false;
            this.dgvPacientInfo.RowHeadersWidth = 62;
            this.dgvPacientInfo.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvPacientInfo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvPacientInfo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvPacientInfo.Size = new System.Drawing.Size(1186, 507);
            this.dgvPacientInfo.TabIndex = 44;
            this.dgvPacientInfo.TabStop = false;
            // 
            // cmsDataGridPatient
            // 
            this.cmsDataGridPatient.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmsDataGridPatient.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmsDataGridPatient.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmsInsertPatient,
            this.PatientDelete,
            this.ViewPatient,
            this.UpdatePatient});
            this.cmsDataGridPatient.Name = "cmsDataGrid";
            this.cmsDataGridPatient.Size = new System.Drawing.Size(344, 108);
            // 
            // cmsInsertPatient
            // 
            this.cmsInsertPatient.Image = global::HealthPortal.Properties.Resources.agregar_usuario__1_;
            this.cmsInsertPatient.Name = "cmsInsertPatient";
            this.cmsInsertPatient.Size = new System.Drawing.Size(343, 26);
            this.cmsInsertPatient.Text = "Agregar Paciente";
            // 
            // PatientDelete
            // 
            this.PatientDelete.Image = global::HealthPortal.Properties.Resources.borrar_usuario;
            this.PatientDelete.Name = "PatientDelete";
            this.PatientDelete.Size = new System.Drawing.Size(343, 26);
            this.PatientDelete.Text = "Eliminar paciente";
            // 
            // ViewPatient
            // 
            this.ViewPatient.Image = global::HealthPortal.Properties.Resources.agregar_documento;
            this.ViewPatient.Name = "ViewPatient";
            this.ViewPatient.Size = new System.Drawing.Size(343, 26);
            this.ViewPatient.Text = "Ver Información del paciente";
            // 
            // UpdatePatient
            // 
            this.UpdatePatient.Image = global::HealthPortal.Properties.Resources.actualizar__1_;
            this.UpdatePatient.Name = "UpdatePatient";
            this.UpdatePatient.Size = new System.Drawing.Size(343, 26);
            this.UpdatePatient.Text = "Actualizar información del paciente";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 13;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2.880883F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 43.92917F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2.27656F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 3.456998F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.47892F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2.360877F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2.529511F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2.613828F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2.613828F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2.613828F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2.880883F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.30848F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2.880883F));
            this.tableLayoutPanel1.Controls.Add(this.btnRefreshPatient, 11, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtSearchPatientInfo, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label1, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnSearchPatientInfo, 4, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 2);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 19F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 31F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1186, 123);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // btnRefreshPatient
            // 
            this.btnRefreshPatient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(183)))), ((int)(((byte)(3)))));
            this.btnRefreshPatient.BackGroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(183)))), ((int)(((byte)(3)))));
            this.btnRefreshPatient.BorderColor = System.Drawing.Color.CornflowerBlue;
            this.btnRefreshPatient.BorderRadius = 30;
            this.btnRefreshPatient.BorderSize = 0;
            this.btnRefreshPatient.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRefreshPatient.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnRefreshPatient.FlatAppearance.BorderSize = 0;
            this.btnRefreshPatient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefreshPatient.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefreshPatient.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(91)))));
            this.btnRefreshPatient.Location = new System.Drawing.Point(956, 30);
            this.btnRefreshPatient.Margin = new System.Windows.Forms.Padding(0);
            this.btnRefreshPatient.Name = "btnRefreshPatient";
            this.tableLayoutPanel1.SetRowSpan(this.btnRefreshPatient, 2);
            this.btnRefreshPatient.Size = new System.Drawing.Size(193, 61);
            this.btnRefreshPatient.TabIndex = 40;
            this.btnRefreshPatient.TabStop = false;
            this.btnRefreshPatient.Text = "Mostrar todos";
            this.btnRefreshPatient.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(91)))));
            this.btnRefreshPatient.UseVisualStyleBackColor = false;
            // 
            // txtSearchPatientInfo
            // 
            this.txtSearchPatientInfo.BackColor = System.Drawing.Color.White;
            this.txtSearchPatientInfo.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(202)))), ((int)(((byte)(230)))));
            this.txtSearchPatientInfo.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtSearchPatientInfo.BorderRadius = 15;
            this.txtSearchPatientInfo.BorderSize = 2;
            this.tableLayoutPanel1.SetColumnSpan(this.txtSearchPatientInfo, 2);
            this.txtSearchPatientInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSearchPatientInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(91)))));
            this.txtSearchPatientInfo.Location = new System.Drawing.Point(34, 53);
            this.txtSearchPatientInfo.Margin = new System.Windows.Forms.Padding(0);
            this.txtSearchPatientInfo.MaxLength = 60;
            this.txtSearchPatientInfo.Multiline = false;
            this.txtSearchPatientInfo.Name = "txtSearchPatientInfo";
            this.txtSearchPatientInfo.Padding = new System.Windows.Forms.Padding(27, 11, 27, 11);
            this.txtSearchPatientInfo.PasswordChar = false;
            this.txtSearchPatientInfo.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtSearchPatientInfo.PlaceholderText = "";
            this.txtSearchPatientInfo.SelectionLength = 0;
            this.txtSearchPatientInfo.SelectionStart = 0;
            this.txtSearchPatientInfo.Size = new System.Drawing.Size(548, 38);
            this.txtSearchPatientInfo.TabIndex = 41;
            this.txtSearchPatientInfo.TabStop = false;
            this.txtSearchPatientInfo.Tag = "name";
            this.txtSearchPatientInfo.Texts = "";
            this.txtSearchPatientInfo.UnderlinedStyle = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.label1, 2);
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(91)))));
            this.label1.Location = new System.Drawing.Point(38, 30);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(540, 23);
            this.label1.TabIndex = 43;
            this.label1.Text = "Buscar pacientes";
            // 
            // btnSearchPatientInfo
            // 
            this.btnSearchPatientInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(183)))), ((int)(((byte)(3)))));
            this.btnSearchPatientInfo.BackGroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(183)))), ((int)(((byte)(3)))));
            this.btnSearchPatientInfo.BorderColor = System.Drawing.Color.CornflowerBlue;
            this.btnSearchPatientInfo.BorderRadius = 30;
            this.btnSearchPatientInfo.BorderSize = 0;
            this.btnSearchPatientInfo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearchPatientInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSearchPatientInfo.FlatAppearance.BorderSize = 0;
            this.btnSearchPatientInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchPatientInfo.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchPatientInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(91)))));
            this.btnSearchPatientInfo.Location = new System.Drawing.Point(623, 53);
            this.btnSearchPatientInfo.Margin = new System.Windows.Forms.Padding(0);
            this.btnSearchPatientInfo.Name = "btnSearchPatientInfo";
            this.btnSearchPatientInfo.Size = new System.Drawing.Size(148, 38);
            this.btnSearchPatientInfo.TabIndex = 42;
            this.btnSearchPatientInfo.TabStop = false;
            this.btnSearchPatientInfo.Text = "Buscar";
            this.btnSearchPatientInfo.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(91)))));
            this.btnSearchPatientInfo.UseVisualStyleBackColor = false;
            // 
            // FrmPatientAdministration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(202)))), ((int)(((byte)(230)))));
            this.ClientSize = new System.Drawing.Size(1827, 880);
            this.Controls.Add(this.tlpInventory);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmPatientAdministration";
            this.Text = "HealthPortal | Inventario";
            this.cmsDataGrid.ResumeLayout(false);
            this.tlpInventory.ResumeLayout(false);
            this.pnlTitle.ResumeLayout(false);
            this.tlpTitle.ResumeLayout(false);
            this.tlpTitleSub.ResumeLayout(false);
            this.tlpTitleSub.PerformLayout();
            this.tlpControls.ResumeLayout(false);
            this.pnlSide.ResumeLayout(false);
            this.tlpSide.ResumeLayout(false);
            this.grpAddVisit.ResumeLayout(false);
            this.tlpSub1.ResumeLayout(false);
            this.grpPatientInfo.ResumeLayout(false);
            this.tlpSub2.ResumeLayout(false);
            this.tlpSub2.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVisitInfo)).EndInit();
            this.tlpMainSub1.ResumeLayout(false);
            this.tlpMainSub1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPacientInfo)).EndInit();
            this.cmsDataGridPatient.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.ContextMenuStrip cmsDataGrid;
        public System.Windows.Forms.ToolStripMenuItem cmsDelete;
        public System.Windows.Forms.ToolStripMenuItem cmsView;
        public System.Windows.Forms.ToolStripMenuItem cmsUpdate;
        private System.Windows.Forms.TableLayoutPanel tlpInventory;
        private System.Windows.Forms.Panel pnlTitle;
        public CustomControls.PanelCustom pnlSide;
        private System.Windows.Forms.TableLayoutPanel tlpSide;
        private System.Windows.Forms.TableLayoutPanel tlpSub1;
        private System.Windows.Forms.GroupBox grpPatientInfo;
        private System.Windows.Forms.TableLayoutPanel tlpSub2;
        public CustomControls.CustomTextBox txtSearch;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TableLayoutPanel tlpTitle;
        private System.Windows.Forms.TableLayoutPanel tlpTitleSub;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TableLayoutPanel tlpControls;
        public System.Windows.Forms.Button btnExit;
        public System.Windows.Forms.Button btnResize;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TableLayoutPanel tlpMainSub1;
        public CustomControls.RJButton btnShowAll;
        public System.Windows.Forms.ComboBox cmbRole;
        private System.Windows.Forms.Label lblPersonType;
        public System.Windows.Forms.ComboBox cmbGrade;
        private System.Windows.Forms.Label lblGrade;
        public System.Windows.Forms.ComboBox cmbSpecialty;
        private System.Windows.Forms.Label lblSpecialty;
        public CustomControls.RJButton btnFilter;
        private System.Windows.Forms.Label lblFilterByDate;
        public System.Windows.Forms.DateTimePicker dtpVisitDate;
        private System.Windows.Forms.TabPage tabPage2;
        public System.Windows.Forms.ContextMenuStrip cmsDataGridPatient;
        public System.Windows.Forms.ToolStripMenuItem PatientDelete;
        public System.Windows.Forms.ToolStripMenuItem ViewPatient;
        public System.Windows.Forms.ToolStripMenuItem UpdatePatient;
        public System.Windows.Forms.ToolStripMenuItem cmsInsertPatient;
        public System.Windows.Forms.TabControl tabControl1;
        public System.Windows.Forms.GroupBox grpAddVisit;
        public CustomControls.RJButton btnNew;
        public CustomControls.RJButton btnSearch;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        public CustomControls.RJButton btnRefreshPatient;
        public CustomControls.RJButton btnSearchPatientInfo;
        public CustomControls.CustomTextBox txtSearchPatientInfo;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.DataGridView dgvVisitInfo;
        public System.Windows.Forms.DataGridView dgvPacientInfo;
        public CustomControls.RJButton btnVisitReport;
        public System.Windows.Forms.LinkLabel llbPatientsTreated;
        public CustomControls.RJButton btnReport;
        private System.Windows.Forms.ToolStripMenuItem reporteDeVisitaToolStripMenuItem;
    }
}