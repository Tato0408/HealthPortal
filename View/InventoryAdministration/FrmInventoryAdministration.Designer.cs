namespace HealthPortal.View.InventoryAdministration
{
    partial class FrmInventoryAdministration
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmInventoryAdministration));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.cmsDataGrid = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmsView = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsUpdate = new System.Windows.Forms.ToolStripMenuItem();
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
            this.grpAddInventory = new System.Windows.Forms.GroupBox();
            this.tlpSub1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnNew = new CustomControls.RJButton();
            this.btnOpenCategoryAdministration = new CustomControls.RJButton();
            this.btnPrintGeneralReport = new CustomControls.RJButton();
            this.grpMedicineInfo = new System.Windows.Forms.GroupBox();
            this.tlpSub2 = new System.Windows.Forms.TableLayoutPanel();
            this.btnSearch = new CustomControls.RJButton();
            this.lblFilter = new System.Windows.Forms.Label();
            this.txtSearch = new CustomControls.CustomTextBox();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.btnFilter = new CustomControls.RJButton();
            this.llbUsageIndex = new System.Windows.Forms.LinkLabel();
            this.pnlMain = new CustomControls.PanelCustom();
            this.dgvInventory = new System.Windows.Forms.DataGridView();
            this.cmsDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsDataGrid.SuspendLayout();
            this.tlpInventory.SuspendLayout();
            this.pnlTitle.SuspendLayout();
            this.tlpTitle.SuspendLayout();
            this.tlpTitleSub.SuspendLayout();
            this.tlpControls.SuspendLayout();
            this.pnlSide.SuspendLayout();
            this.tlpSide.SuspendLayout();
            this.grpAddInventory.SuspendLayout();
            this.tlpSub1.SuspendLayout();
            this.grpMedicineInfo.SuspendLayout();
            this.tlpSub2.SuspendLayout();
            this.pnlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventory)).BeginInit();
            this.SuspendLayout();
            // 
            // cmsDataGrid
            // 
            this.cmsDataGrid.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmsDataGrid.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.cmsDataGrid.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmsDelete,
            this.cmsView,
            this.cmsUpdate});
            this.cmsDataGrid.Name = "cmsDataGrid";
            this.cmsDataGrid.Size = new System.Drawing.Size(329, 116);
            // 
            // cmsView
            // 
            this.cmsView.Image = global::HealthPortal.Properties.Resources.agregar_documento;
            this.cmsView.Name = "cmsView";
            this.cmsView.Size = new System.Drawing.Size(328, 30);
            this.cmsView.Text = "Ver ficha del medicamento";

            // 
            // cmsUpdate
            // 
            this.cmsUpdate.Image = global::HealthPortal.Properties.Resources.actualizar__1_;
            this.cmsUpdate.Name = "cmsUpdate";
            this.cmsUpdate.Size = new System.Drawing.Size(328, 30);
            this.cmsUpdate.Text = "Actualizar información del medicamento";
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
            this.tlpInventory.Controls.Add(this.pnlMain, 3, 2);
            this.tlpInventory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpInventory.Location = new System.Drawing.Point(0, 0);
            this.tlpInventory.Name = "tlpInventory";
            this.tlpInventory.RowCount = 4;
            this.tlpInventory.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tlpInventory.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.630542F));
            this.tlpInventory.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 76.4532F));
            this.tlpInventory.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.630542F));
            this.tlpInventory.Size = new System.Drawing.Size(1370, 715);
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
            this.pnlTitle.Size = new System.Drawing.Size(1370, 102);
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
            this.tlpTitle.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 102F));
            this.tlpTitle.Size = new System.Drawing.Size(1370, 102);
            this.tlpTitle.TabIndex = 0;
            // 
            // tlpTitleSub
            // 
            this.tlpTitleSub.ColumnCount = 3;
            this.tlpTitleSub.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.002201F));
            this.tlpTitleSub.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 89.99561F));
            this.tlpTitleSub.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.002201F));
            this.tlpTitleSub.Controls.Add(this.lblTitle, 1, 1);
            this.tlpTitleSub.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpTitleSub.Location = new System.Drawing.Point(0, 0);
            this.tlpTitleSub.Margin = new System.Windows.Forms.Padding(0);
            this.tlpTitleSub.Name = "tlpTitleSub";
            this.tlpTitleSub.RowCount = 3;
            this.tlpTitleSub.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tlpTitleSub.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tlpTitleSub.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpTitleSub.Size = new System.Drawing.Size(1000, 102);
            this.tlpTitleSub.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTitle.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(202)))), ((int)(((byte)(230)))));
            this.lblTitle.Location = new System.Drawing.Point(50, 35);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(899, 40);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "Inventario";
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
            this.tlpControls.Location = new System.Drawing.Point(1000, 0);
            this.tlpControls.Margin = new System.Windows.Forms.Padding(0);
            this.tlpControls.Name = "tlpControls";
            this.tlpControls.RowCount = 3;
            this.tlpControls.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpControls.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpControls.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpControls.Size = new System.Drawing.Size(370, 102);
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
            this.btnExit.Location = new System.Drawing.Point(260, 34);
            this.btnExit.Margin = new System.Windows.Forms.Padding(0);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(69, 34);
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
            this.btnResize.Location = new System.Drawing.Point(185, 34);
            this.btnResize.Margin = new System.Windows.Forms.Padding(0);
            this.btnResize.Name = "btnResize";
            this.btnResize.Size = new System.Drawing.Size(69, 34);
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
            this.pnlSide.Location = new System.Drawing.Point(38, 135);
            this.pnlSide.Margin = new System.Windows.Forms.Padding(0);
            this.pnlSide.Name = "pnlSide";
            this.pnlSide.Size = new System.Drawing.Size(348, 546);
            this.pnlSide.TabIndex = 2;
            // 
            // tlpSide
            // 
            this.tlpSide.ColumnCount = 3;
            this.tlpSide.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.85F));
            this.tlpSide.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 74.3F));
            this.tlpSide.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.85F));
            this.tlpSide.Controls.Add(this.grpAddInventory, 1, 3);
            this.tlpSide.Controls.Add(this.grpMedicineInfo, 1, 1);
            this.tlpSide.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpSide.Location = new System.Drawing.Point(0, 0);
            this.tlpSide.Name = "tlpSide";
            this.tlpSide.RowCount = 5;
            this.tlpSide.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.007008F));
            this.tlpSide.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 56.59341F));
            this.tlpSide.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2.747253F));
            this.tlpSide.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 26.37363F));
            this.tlpSide.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.007008F));
            this.tlpSide.Size = new System.Drawing.Size(348, 546);
            this.tlpSide.TabIndex = 0;
            // 
            // grpAddInventory
            // 
            this.grpAddInventory.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.grpAddInventory.Controls.Add(this.tlpSub1);
            this.grpAddInventory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpAddInventory.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpAddInventory.ForeColor = System.Drawing.Color.DarkGray;
            this.grpAddInventory.Location = new System.Drawing.Point(44, 362);
            this.grpAddInventory.Margin = new System.Windows.Forms.Padding(0);
            this.grpAddInventory.Name = "grpAddInventory";
            this.grpAddInventory.Size = new System.Drawing.Size(258, 144);
            this.grpAddInventory.TabIndex = 1;
            this.grpAddInventory.TabStop = false;
            this.grpAddInventory.Text = "Añadir Medicamentos";
            // 
            // tlpSub1
            // 
            this.tlpSub1.ColumnCount = 3;
            this.tlpSub1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.33F));
            this.tlpSub1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 83.34F));
            this.tlpSub1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.33F));
            this.tlpSub1.Controls.Add(this.btnNew, 1, 1);
            this.tlpSub1.Controls.Add(this.btnOpenCategoryAdministration, 1, 2);
            this.tlpSub1.Controls.Add(this.btnPrintGeneralReport, 1, 0);
            this.tlpSub1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpSub1.Location = new System.Drawing.Point(3, 17);
            this.tlpSub1.Name = "tlpSub1";
            this.tlpSub1.RowCount = 3;
            this.tlpSub1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 26.92F));
            this.tlpSub1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 46.16F));
            this.tlpSub1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 26.92F));
            this.tlpSub1.Size = new System.Drawing.Size(252, 124);
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
            this.btnNew.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnNew.FlatAppearance.BorderSize = 0;
            this.btnNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNew.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNew.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(91)))));
            this.btnNew.Location = new System.Drawing.Point(25, 38);
            this.btnNew.Margin = new System.Windows.Forms.Padding(5);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(200, 47);
            this.btnNew.TabIndex = 1;
            this.btnNew.TabStop = false;
            this.btnNew.Text = "Agregar Medicamento";
            this.btnNew.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(91)))));
            this.btnNew.UseVisualStyleBackColor = false;
            // 
            // btnOpenCategoryAdministration
            // 
            this.btnOpenCategoryAdministration.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(202)))), ((int)(((byte)(230)))));
            this.btnOpenCategoryAdministration.BackGroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(202)))), ((int)(((byte)(230)))));
            this.btnOpenCategoryAdministration.BorderColor = System.Drawing.Color.CornflowerBlue;
            this.btnOpenCategoryAdministration.BorderRadius = 30;
            this.btnOpenCategoryAdministration.BorderSize = 0;
            this.btnOpenCategoryAdministration.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOpenCategoryAdministration.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnOpenCategoryAdministration.FlatAppearance.BorderSize = 0;
            this.btnOpenCategoryAdministration.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpenCategoryAdministration.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpenCategoryAdministration.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(91)))));
            this.btnOpenCategoryAdministration.Location = new System.Drawing.Point(22, 92);
            this.btnOpenCategoryAdministration.Margin = new System.Windows.Forms.Padding(2);
            this.btnOpenCategoryAdministration.Name = "btnOpenCategoryAdministration";
            this.btnOpenCategoryAdministration.Size = new System.Drawing.Size(206, 30);
            this.btnOpenCategoryAdministration.TabIndex = 3;
            this.btnOpenCategoryAdministration.TabStop = false;
            this.btnOpenCategoryAdministration.Text = "Ver Categorias";
            this.btnOpenCategoryAdministration.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(91)))));
            this.btnOpenCategoryAdministration.UseVisualStyleBackColor = false;
            // 
            // btnPrintGeneralReport
            // 
            this.btnPrintGeneralReport.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnPrintGeneralReport.BackGroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnPrintGeneralReport.BorderColor = System.Drawing.Color.CornflowerBlue;
            this.btnPrintGeneralReport.BorderRadius = 30;
            this.btnPrintGeneralReport.BorderSize = 0;
            this.btnPrintGeneralReport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrintGeneralReport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPrintGeneralReport.FlatAppearance.BorderSize = 0;
            this.btnPrintGeneralReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrintGeneralReport.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrintGeneralReport.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(91)))));
            this.btnPrintGeneralReport.Location = new System.Drawing.Point(22, 2);
            this.btnPrintGeneralReport.Margin = new System.Windows.Forms.Padding(2);
            this.btnPrintGeneralReport.Name = "btnPrintGeneralReport";
            this.btnPrintGeneralReport.Size = new System.Drawing.Size(206, 29);
            this.btnPrintGeneralReport.TabIndex = 4;
            this.btnPrintGeneralReport.TabStop = false;
            this.btnPrintGeneralReport.Text = "Imprimir Ficha General";
            this.btnPrintGeneralReport.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(91)))));
            this.btnPrintGeneralReport.UseVisualStyleBackColor = false;
            // 
            // grpMedicineInfo
            // 
            this.grpMedicineInfo.Controls.Add(this.tlpSub2);
            this.grpMedicineInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpMedicineInfo.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold);
            this.grpMedicineInfo.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.grpMedicineInfo.Location = new System.Drawing.Point(47, 41);
            this.grpMedicineInfo.Name = "grpMedicineInfo";
            this.grpMedicineInfo.Size = new System.Drawing.Size(252, 303);
            this.grpMedicineInfo.TabIndex = 2;
            this.grpMedicineInfo.TabStop = false;
            this.grpMedicineInfo.Text = "Información de inventario";
            // 
            // tlpSub2
            // 
            this.tlpSub2.ColumnCount = 4;
            this.tlpSub2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.331947F));
            this.tlpSub2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 41.66805F));
            this.tlpSub2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 41.66805F));
            this.tlpSub2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.331947F));
            this.tlpSub2.Controls.Add(this.btnSearch, 2, 9);
            this.tlpSub2.Controls.Add(this.lblFilter, 1, 1);
            this.tlpSub2.Controls.Add(this.txtSearch, 1, 7);
            this.tlpSub2.Controls.Add(this.cmbCategory, 1, 2);
            this.tlpSub2.Controls.Add(this.lblSearch, 1, 6);
            this.tlpSub2.Controls.Add(this.btnFilter, 2, 4);
            this.tlpSub2.Controls.Add(this.llbUsageIndex, 1, 12);
            this.tlpSub2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpSub2.Location = new System.Drawing.Point(3, 17);
            this.tlpSub2.Name = "tlpSub2";
            this.tlpSub2.RowCount = 14;
            this.tlpSub2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.989553F));
            this.tlpSub2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.935065F));
            this.tlpSub2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.012987F));
            this.tlpSub2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2.909212F));
            this.tlpSub2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.463162F));
            this.tlpSub2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.173686F));
            this.tlpSub2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.025002F));
            this.tlpSub2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.992111F));
            this.tlpSub2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2.909212F));
            this.tlpSub2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.386872F));
            this.tlpSub2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2.863127F));
            this.tlpSub2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.935065F));
            this.tlpSub2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 28.31169F));
            this.tlpSub2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.989553F));
            this.tlpSub2.Size = new System.Drawing.Size(246, 283);
            this.tlpSub2.TabIndex = 3;
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
            this.btnSearch.Location = new System.Drawing.Point(122, 134);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(0);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(102, 23);
            this.btnSearch.TabIndex = 35;
            this.btnSearch.TabStop = false;
            this.btnSearch.Text = "Buscar";
            this.btnSearch.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(91)))));
            this.btnSearch.UseVisualStyleBackColor = false;
            // 
            // lblFilter
            // 
            this.lblFilter.AutoSize = true;
            this.tlpSub2.SetColumnSpan(this.lblFilter, 2);
            this.lblFilter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblFilter.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFilter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(91)))));
            this.lblFilter.Location = new System.Drawing.Point(20, 16);
            this.lblFilter.Margin = new System.Windows.Forms.Padding(0);
            this.lblFilter.Name = "lblFilter";
            this.lblFilter.Size = new System.Drawing.Size(204, 13);
            this.lblFilter.TabIndex = 28;
            this.lblFilter.Text = "Filtrar inventario por categoría";
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
            this.txtSearch.Location = new System.Drawing.Point(20, 101);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(0);
            this.txtSearch.MaxLength = 32767;
            this.txtSearch.Multiline = false;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Padding = new System.Windows.Forms.Padding(20, 9, 20, 9);
            this.txtSearch.PasswordChar = false;
            this.txtSearch.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtSearch.PlaceholderText = "";
            this.txtSearch.SelectionLength = 0;
            this.txtSearch.SelectionStart = 0;
            this.txtSearch.Size = new System.Drawing.Size(204, 25);
            this.txtSearch.TabIndex = 34;
            this.txtSearch.TabStop = false;
            this.txtSearch.Tag = "name";
            this.txtSearch.Texts = "";
            this.txtSearch.UnderlinedStyle = false;
            // 
            // cmbCategory
            // 
            this.tlpSub2.SetColumnSpan(this.cmbCategory, 2);
            this.cmbCategory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(91)))));
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.Location = new System.Drawing.Point(20, 29);
            this.cmbCategory.Margin = new System.Windows.Forms.Padding(0);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(204, 23);
            this.cmbCategory.TabIndex = 29;
            this.cmbCategory.TabStop = false;
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.tlpSub2.SetColumnSpan(this.lblSearch, 2);
            this.lblSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSearch.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(91)))));
            this.lblSearch.Location = new System.Drawing.Point(23, 87);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(198, 14);
            this.lblSearch.TabIndex = 33;
            this.lblSearch.Text = "Buscar producto";
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
            this.btnFilter.Location = new System.Drawing.Point(122, 56);
            this.btnFilter.Margin = new System.Windows.Forms.Padding(0);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(102, 23);
            this.btnFilter.TabIndex = 30;
            this.btnFilter.TabStop = false;
            this.btnFilter.Text = "Filtrar";
            this.btnFilter.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(91)))));
            this.btnFilter.UseVisualStyleBackColor = false;
            // 
            // llbUsageIndex
            // 
            this.llbUsageIndex.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(183)))), ((int)(((byte)(3)))));
            this.llbUsageIndex.AutoSize = true;
            this.tlpSub2.SetColumnSpan(this.llbUsageIndex, 2);
            this.llbUsageIndex.Dock = System.Windows.Forms.DockStyle.Fill;
            this.llbUsageIndex.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llbUsageIndex.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(91)))));
            this.llbUsageIndex.Location = new System.Drawing.Point(23, 178);
            this.llbUsageIndex.Name = "llbUsageIndex";
            this.llbUsageIndex.Size = new System.Drawing.Size(198, 80);
            this.llbUsageIndex.TabIndex = 36;
            this.llbUsageIndex.TabStop = true;
            this.llbUsageIndex.Text = "Índice de Uso";
            this.llbUsageIndex.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(91)))));
            // 
            // pnlMain
            // 
            this.pnlMain.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnlMain.BackColor = System.Drawing.Color.White;
            this.pnlMain.BorderRadius = 30;
            this.pnlMain.Controls.Add(this.dgvInventory);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.ForeColor = System.Drawing.Color.Black;
            this.pnlMain.GradientAngle = 90F;
            this.pnlMain.GradientBottomColor = System.Drawing.Color.White;
            this.pnlMain.GradientTopColor = System.Drawing.Color.White;
            this.pnlMain.Location = new System.Drawing.Point(424, 135);
            this.pnlMain.Margin = new System.Windows.Forms.Padding(0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(904, 546);
            this.pnlMain.TabIndex = 3;
            // 
            // dgvInventory
            // 
            this.dgvInventory.AllowUserToAddRows = false;
            this.dgvInventory.AllowUserToDeleteRows = false;
            this.dgvInventory.AllowUserToResizeColumns = false;
            this.dgvInventory.AllowUserToResizeRows = false;
            this.dgvInventory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvInventory.BackgroundColor = System.Drawing.Color.White;
            this.dgvInventory.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvInventory.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvInventory.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.dgvInventory.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            dataGridViewCellStyle1.NullValue = "-----";
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(202)))), ((int)(((byte)(230)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvInventory.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvInventory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInventory.ContextMenuStrip = this.cmsDataGrid;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.NullValue = "-----";
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(202)))), ((int)(((byte)(230)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvInventory.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvInventory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvInventory.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.dgvInventory.Location = new System.Drawing.Point(0, 0);
            this.dgvInventory.Margin = new System.Windows.Forms.Padding(0);
            this.dgvInventory.MultiSelect = false;
            this.dgvInventory.Name = "dgvInventory";
            this.dgvInventory.ReadOnly = true;
            this.dgvInventory.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            dataGridViewCellStyle3.NullValue = "-----";
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(202)))), ((int)(((byte)(230)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvInventory.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvInventory.RowHeadersVisible = false;
            this.dgvInventory.RowHeadersWidth = 62;
            this.dgvInventory.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvInventory.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvInventory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvInventory.Size = new System.Drawing.Size(904, 546);
            this.dgvInventory.TabIndex = 0;
            this.dgvInventory.TabStop = false;
            // 
            // cmsDelete
            // 
            this.cmsDelete.Image = global::HealthPortal.Properties.Resources.papelera_xmark;
            this.cmsDelete.Name = "cmsDelete";
            this.cmsDelete.Size = new System.Drawing.Size(328, 30);
            this.cmsDelete.Text = "Eliminar medicamento";
            // 
            // FrmInventoryAdministration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(202)))), ((int)(((byte)(230)))));
            this.ClientSize = new System.Drawing.Size(1370, 715);
            this.Controls.Add(this.tlpInventory);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmInventoryAdministration";
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
            this.grpAddInventory.ResumeLayout(false);
            this.tlpSub1.ResumeLayout(false);
            this.grpMedicineInfo.ResumeLayout(false);
            this.tlpSub2.ResumeLayout(false);
            this.tlpSub2.PerformLayout();
            this.pnlMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventory)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.ContextMenuStrip cmsDataGrid;
        public System.Windows.Forms.ToolStripMenuItem cmsView;
        public System.Windows.Forms.ToolStripMenuItem cmsUpdate;
        private System.Windows.Forms.TableLayoutPanel tlpInventory;
        private System.Windows.Forms.Panel pnlTitle;
        public CustomControls.PanelCustom pnlSide;
        private System.Windows.Forms.GroupBox grpAddInventory;
        public CustomControls.PanelCustom pnlMain;
        public System.Windows.Forms.DataGridView dgvInventory;
        private System.Windows.Forms.TableLayoutPanel tlpSide;
        private System.Windows.Forms.TableLayoutPanel tlpSub1;
        public CustomControls.RJButton btnNew;
        private System.Windows.Forms.GroupBox grpMedicineInfo;
        private System.Windows.Forms.TableLayoutPanel tlpSub2;
        public CustomControls.RJButton btnSearch;
        private System.Windows.Forms.Label lblFilter;
        public CustomControls.CustomTextBox txtSearch;
        public System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.Label lblSearch;
        public CustomControls.RJButton btnFilter;
        private System.Windows.Forms.TableLayoutPanel tlpTitle;
        private System.Windows.Forms.TableLayoutPanel tlpTitleSub;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TableLayoutPanel tlpControls;
        public System.Windows.Forms.Button btnExit;
        public System.Windows.Forms.Button btnResize;
        public CustomControls.RJButton btnOpenCategoryAdministration;
        public CustomControls.RJButton btnPrintGeneralReport;
        public System.Windows.Forms.LinkLabel llbUsageIndex;
        public System.Windows.Forms.ToolStripMenuItem cmsDelete;
    }
}