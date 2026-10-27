namespace HealthPortal.View.UserAdministration
{
    partial class FrmUserAdministration
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmUserAdministration));
            this.cmsDataGrid = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmsDeleteUser = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsViewUserInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsUpdateUserInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsReestablishPassword = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlMain = new CustomControls.PanelCustom();
            this.dgvUserDisplay = new System.Windows.Forms.DataGridView();
            this.pnlSide = new CustomControls.PanelCustom();
            this.tlpSide = new System.Windows.Forms.TableLayoutPanel();
            this.grpNewUser = new System.Windows.Forms.GroupBox();
            this.tlpSub1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnAddNewUser = new CustomControls.RJButton();
            this.grpFilterSearchUsers = new System.Windows.Forms.GroupBox();
            this.tlpSub2 = new System.Windows.Forms.TableLayoutPanel();
            this.btnSearchForUser = new CustomControls.RJButton();
            this.txtUserAdministrationSearch = new CustomControls.CustomTextBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.pnlTitle = new System.Windows.Forms.Panel();
            this.tlpTitle = new System.Windows.Forms.TableLayoutPanel();
            this.tlpTitleSub = new System.Windows.Forms.TableLayoutPanel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.tlpControls = new System.Windows.Forms.TableLayoutPanel();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnResize = new System.Windows.Forms.Button();
            this.tlpInventory = new System.Windows.Forms.TableLayoutPanel();
            this.cmsDataGrid.SuspendLayout();
            this.pnlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUserDisplay)).BeginInit();
            this.pnlSide.SuspendLayout();
            this.tlpSide.SuspendLayout();
            this.grpNewUser.SuspendLayout();
            this.tlpSub1.SuspendLayout();
            this.grpFilterSearchUsers.SuspendLayout();
            this.tlpSub2.SuspendLayout();
            this.pnlTitle.SuspendLayout();
            this.tlpTitle.SuspendLayout();
            this.tlpTitleSub.SuspendLayout();
            this.tlpControls.SuspendLayout();
            this.tlpInventory.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmsDataGrid
            // 
            this.cmsDataGrid.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmsDataGrid.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmsDataGrid.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmsDeleteUser,
            this.cmsViewUserInfo,
            this.cmsUpdateUserInfo,
            this.cmsReestablishPassword});
            this.cmsDataGrid.Name = "cmsDataGrid";
            this.cmsDataGrid.Size = new System.Drawing.Size(329, 108);
            // 
            // cmsDeleteUser
            // 
            this.cmsDeleteUser.Image = global::HealthPortal.Properties.Resources.borrar_usuario;
            this.cmsDeleteUser.Name = "cmsDeleteUser";
            this.cmsDeleteUser.Size = new System.Drawing.Size(328, 26);
            this.cmsDeleteUser.Text = "Eliminar usuario";
            // 
            // cmsViewUserInfo
            // 
            this.cmsViewUserInfo.Image = global::HealthPortal.Properties.Resources.agregar_documento;
            this.cmsViewUserInfo.Name = "cmsViewUserInfo";
            this.cmsViewUserInfo.Size = new System.Drawing.Size(328, 26);
            this.cmsViewUserInfo.Text = "Ver información del usuario";
            // 
            // cmsUpdateUserInfo
            // 
            this.cmsUpdateUserInfo.Image = global::HealthPortal.Properties.Resources.actualizar__1_;
            this.cmsUpdateUserInfo.Name = "cmsUpdateUserInfo";
            this.cmsUpdateUserInfo.Size = new System.Drawing.Size(328, 26);
            this.cmsUpdateUserInfo.Text = "Actualizar información del usuario";
            // 
            // cmsReestablishPassword
            // 
            this.cmsReestablishPassword.Image = global::HealthPortal.Properties.Resources.clave;
            this.cmsReestablishPassword.Name = "cmsReestablishPassword";
            this.cmsReestablishPassword.Size = new System.Drawing.Size(328, 26);
            this.cmsReestablishPassword.Text = "Reestablecer contraseña";
            // 
            // pnlMain
            // 
            this.pnlMain.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnlMain.BackColor = System.Drawing.Color.White;
            this.pnlMain.BorderRadius = 30;
            this.pnlMain.Controls.Add(this.dgvUserDisplay);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.ForeColor = System.Drawing.Color.Black;
            this.pnlMain.GradientAngle = 90F;
            this.pnlMain.GradientBottomColor = System.Drawing.Color.White;
            this.pnlMain.GradientTopColor = System.Drawing.Color.White;
            this.pnlMain.Location = new System.Drawing.Point(535, 165);
            this.pnlMain.Margin = new System.Windows.Forms.Padding(0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(1140, 674);
            this.pnlMain.TabIndex = 3;
            // 
            // dgvUserDisplay
            // 
            this.dgvUserDisplay.AllowUserToAddRows = false;
            this.dgvUserDisplay.AllowUserToDeleteRows = false;
            this.dgvUserDisplay.AllowUserToResizeColumns = false;
            this.dgvUserDisplay.AllowUserToResizeRows = false;
            this.dgvUserDisplay.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUserDisplay.BackgroundColor = System.Drawing.Color.White;
            this.dgvUserDisplay.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvUserDisplay.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvUserDisplay.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.dgvUserDisplay.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            dataGridViewCellStyle1.NullValue = "-----";
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(202)))), ((int)(((byte)(230)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvUserDisplay.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvUserDisplay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUserDisplay.ContextMenuStrip = this.cmsDataGrid;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.NullValue = "-----";
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(202)))), ((int)(((byte)(230)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvUserDisplay.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvUserDisplay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvUserDisplay.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.dgvUserDisplay.Location = new System.Drawing.Point(0, 0);
            this.dgvUserDisplay.Margin = new System.Windows.Forms.Padding(0);
            this.dgvUserDisplay.MultiSelect = false;
            this.dgvUserDisplay.Name = "dgvUserDisplay";
            this.dgvUserDisplay.ReadOnly = true;
            this.dgvUserDisplay.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            dataGridViewCellStyle3.NullValue = "-----";
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(202)))), ((int)(((byte)(230)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvUserDisplay.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvUserDisplay.RowHeadersVisible = false;
            this.dgvUserDisplay.RowHeadersWidth = 51;
            this.dgvUserDisplay.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvUserDisplay.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvUserDisplay.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvUserDisplay.Size = new System.Drawing.Size(1140, 674);
            this.dgvUserDisplay.TabIndex = 0;
            this.dgvUserDisplay.TabStop = false;
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
            this.pnlSide.Location = new System.Drawing.Point(48, 165);
            this.pnlSide.Margin = new System.Windows.Forms.Padding(0);
            this.pnlSide.Name = "pnlSide";
            this.pnlSide.Size = new System.Drawing.Size(439, 674);
            this.pnlSide.TabIndex = 2;
            // 
            // tlpSide
            // 
            this.tlpSide.ColumnCount = 3;
            this.tlpSide.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.85F));
            this.tlpSide.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 74.3F));
            this.tlpSide.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.85F));
            this.tlpSide.Controls.Add(this.grpNewUser, 1, 3);
            this.tlpSide.Controls.Add(this.grpFilterSearchUsers, 1, 1);
            this.tlpSide.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpSide.Location = new System.Drawing.Point(0, 0);
            this.tlpSide.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tlpSide.Name = "tlpSide";
            this.tlpSide.RowCount = 5;
            this.tlpSide.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.007008F));
            this.tlpSide.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 65.26527F));
            this.tlpSide.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.105105F));
            this.tlpSide.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.61562F));
            this.tlpSide.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.007008F));
            this.tlpSide.Size = new System.Drawing.Size(439, 674);
            this.tlpSide.TabIndex = 0;
            // 
            // grpNewUser
            // 
            this.grpNewUser.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.grpNewUser.Controls.Add(this.tlpSub1);
            this.grpNewUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpNewUser.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpNewUser.ForeColor = System.Drawing.Color.DarkGray;
            this.grpNewUser.Location = new System.Drawing.Point(56, 520);
            this.grpNewUser.Margin = new System.Windows.Forms.Padding(0);
            this.grpNewUser.Name = "grpNewUser";
            this.grpNewUser.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpNewUser.Size = new System.Drawing.Size(326, 105);
            this.grpNewUser.TabIndex = 1;
            this.grpNewUser.TabStop = false;
            this.grpNewUser.Text = "Añadir usuarios";
            // 
            // tlpSub1
            // 
            this.tlpSub1.ColumnCount = 3;
            this.tlpSub1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.33F));
            this.tlpSub1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 83.34F));
            this.tlpSub1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.33F));
            this.tlpSub1.Controls.Add(this.btnAddNewUser, 1, 1);
            this.tlpSub1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpSub1.Location = new System.Drawing.Point(4, 21);
            this.tlpSub1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tlpSub1.Name = "tlpSub1";
            this.tlpSub1.RowCount = 3;
            this.tlpSub1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 26.92F));
            this.tlpSub1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 46.16F));
            this.tlpSub1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 26.92F));
            this.tlpSub1.Size = new System.Drawing.Size(318, 80);
            this.tlpSub1.TabIndex = 0;
            // 
            // btnAddNewUser
            // 
            this.btnAddNewUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(183)))), ((int)(((byte)(3)))));
            this.btnAddNewUser.BackGroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(183)))), ((int)(((byte)(3)))));
            this.btnAddNewUser.BorderColor = System.Drawing.Color.CornflowerBlue;
            this.btnAddNewUser.BorderRadius = 30;
            this.btnAddNewUser.BorderSize = 0;
            this.btnAddNewUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddNewUser.FlatAppearance.BorderSize = 0;
            this.btnAddNewUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddNewUser.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNewUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(91)))));
            this.btnAddNewUser.Location = new System.Drawing.Point(26, 21);
            this.btnAddNewUser.Margin = new System.Windows.Forms.Padding(0);
            this.btnAddNewUser.Name = "btnAddNewUser";
            this.btnAddNewUser.Size = new System.Drawing.Size(265, 36);
            this.btnAddNewUser.TabIndex = 1;
            this.btnAddNewUser.TabStop = false;
            this.btnAddNewUser.Text = "Nuevo Usuario";
            this.btnAddNewUser.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(91)))));
            this.btnAddNewUser.UseVisualStyleBackColor = false;
            // 
            // grpFilterSearchUsers
            // 
            this.grpFilterSearchUsers.Controls.Add(this.tlpSub2);
            this.grpFilterSearchUsers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpFilterSearchUsers.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold);
            this.grpFilterSearchUsers.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.grpFilterSearchUsers.Location = new System.Drawing.Point(60, 51);
            this.grpFilterSearchUsers.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpFilterSearchUsers.Name = "grpFilterSearchUsers";
            this.grpFilterSearchUsers.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpFilterSearchUsers.Size = new System.Drawing.Size(318, 431);
            this.grpFilterSearchUsers.TabIndex = 2;
            this.grpFilterSearchUsers.TabStop = false;
            this.grpFilterSearchUsers.Text = "Filtrar / Buscar usuarios";
            // 
            // tlpSub2
            // 
            this.tlpSub2.ColumnCount = 4;
            this.tlpSub2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.331947F));
            this.tlpSub2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 41.66805F));
            this.tlpSub2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 41.66805F));
            this.tlpSub2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.331947F));
            this.tlpSub2.Controls.Add(this.btnSearchForUser, 2, 5);
            this.tlpSub2.Controls.Add(this.txtUserAdministrationSearch, 1, 3);
            this.tlpSub2.Controls.Add(this.lblSearch, 1, 1);
            this.tlpSub2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpSub2.Location = new System.Drawing.Point(4, 21);
            this.tlpSub2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tlpSub2.Name = "tlpSub2";
            this.tlpSub2.RowCount = 14;
            this.tlpSub2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.989553F));
            this.tlpSub2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.935065F));
            this.tlpSub2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.012987F));
            this.tlpSub2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.831169F));
            this.tlpSub2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2.857143F));
            this.tlpSub2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.311688F));
            this.tlpSub2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.896104F));
            this.tlpSub2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.935065F));
            this.tlpSub2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.155844F));
            this.tlpSub2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.233766F));
            this.tlpSub2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2.863127F));
            this.tlpSub2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.935065F));
            this.tlpSub2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 28.31169F));
            this.tlpSub2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.989553F));
            this.tlpSub2.Size = new System.Drawing.Size(310, 406);
            this.tlpSub2.TabIndex = 3;
            // 
            // btnSearchForUser
            // 
            this.btnSearchForUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(183)))), ((int)(((byte)(3)))));
            this.btnSearchForUser.BackGroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(183)))), ((int)(((byte)(3)))));
            this.btnSearchForUser.BorderColor = System.Drawing.Color.CornflowerBlue;
            this.btnSearchForUser.BorderRadius = 30;
            this.btnSearchForUser.BorderSize = 0;
            this.btnSearchForUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearchForUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSearchForUser.FlatAppearance.BorderSize = 0;
            this.btnSearchForUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchForUser.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchForUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(91)))));
            this.btnSearchForUser.Location = new System.Drawing.Point(154, 119);
            this.btnSearchForUser.Margin = new System.Windows.Forms.Padding(0);
            this.btnSearchForUser.Name = "btnSearchForUser";
            this.btnSearchForUser.Size = new System.Drawing.Size(129, 33);
            this.btnSearchForUser.TabIndex = 35;
            this.btnSearchForUser.TabStop = false;
            this.btnSearchForUser.Text = "Buscar";
            this.btnSearchForUser.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(91)))));
            this.btnSearchForUser.UseVisualStyleBackColor = false;
            // 
            // txtUserAdministrationSearch
            // 
            this.txtUserAdministrationSearch.BackColor = System.Drawing.Color.White;
            this.txtUserAdministrationSearch.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(202)))), ((int)(((byte)(230)))));
            this.txtUserAdministrationSearch.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtUserAdministrationSearch.BorderRadius = 15;
            this.txtUserAdministrationSearch.BorderSize = 2;
            this.tlpSub2.SetColumnSpan(this.txtUserAdministrationSearch, 2);
            this.txtUserAdministrationSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtUserAdministrationSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(91)))));
            this.txtUserAdministrationSearch.Location = new System.Drawing.Point(25, 72);
            this.txtUserAdministrationSearch.Margin = new System.Windows.Forms.Padding(0);
            this.txtUserAdministrationSearch.MaxLength = 60;
            this.txtUserAdministrationSearch.Multiline = false;
            this.txtUserAdministrationSearch.Name = "txtUserAdministrationSearch";
            this.txtUserAdministrationSearch.Padding = new System.Windows.Forms.Padding(27, 11, 27, 11);
            this.txtUserAdministrationSearch.PasswordChar = false;
            this.txtUserAdministrationSearch.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtUserAdministrationSearch.PlaceholderText = "";
            this.txtUserAdministrationSearch.SelectionLength = 0;
            this.txtUserAdministrationSearch.SelectionStart = 0;
            this.txtUserAdministrationSearch.Size = new System.Drawing.Size(258, 36);
            this.txtUserAdministrationSearch.TabIndex = 34;
            this.txtUserAdministrationSearch.TabStop = false;
            this.txtUserAdministrationSearch.Tag = "name";
            this.txtUserAdministrationSearch.Texts = "";
            this.txtUserAdministrationSearch.UnderlinedStyle = false;
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.tlpSub2.SetColumnSpan(this.lblSearch, 2);
            this.lblSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSearch.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(91)))));
            this.lblSearch.Location = new System.Drawing.Point(29, 24);
            this.lblSearch.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(250, 20);
            this.lblSearch.TabIndex = 33;
            this.lblSearch.Text = "Buscar usuarios";
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
            this.pnlTitle.Size = new System.Drawing.Size(1726, 125);
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
            this.tlpTitle.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 145F));
            this.tlpTitle.Size = new System.Drawing.Size(1726, 125);
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
            this.tlpTitleSub.Size = new System.Drawing.Size(1259, 125);
            this.tlpTitleSub.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTitle.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(202)))), ((int)(((byte)(230)))));
            this.lblTitle.Location = new System.Drawing.Point(62, 43);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(1133, 50);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "Administración de Usuarios";
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
            this.tlpControls.Location = new System.Drawing.Point(1259, 0);
            this.tlpControls.Margin = new System.Windows.Forms.Padding(0);
            this.tlpControls.Name = "tlpControls";
            this.tlpControls.RowCount = 3;
            this.tlpControls.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpControls.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpControls.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpControls.Size = new System.Drawing.Size(467, 125);
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
            this.btnExit.Location = new System.Drawing.Point(329, 41);
            this.btnExit.Margin = new System.Windows.Forms.Padding(0);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(88, 41);
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
            this.btnResize.Location = new System.Drawing.Point(233, 41);
            this.btnResize.Margin = new System.Windows.Forms.Padding(0);
            this.btnResize.Name = "btnResize";
            this.btnResize.Size = new System.Drawing.Size(88, 41);
            this.btnResize.TabIndex = 39;
            this.btnResize.TabStop = false;
            this.btnResize.UseVisualStyleBackColor = false;
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
            this.tlpInventory.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tlpInventory.Name = "tlpInventory";
            this.tlpInventory.RowCount = 4;
            this.tlpInventory.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tlpInventory.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.630542F));
            this.tlpInventory.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 76.4532F));
            this.tlpInventory.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.630542F));
            this.tlpInventory.Size = new System.Drawing.Size(1726, 882);
            this.tlpInventory.TabIndex = 1;
            // 
            // FrmUserAdministration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(202)))), ((int)(((byte)(230)))));
            this.ClientSize = new System.Drawing.Size(1726, 882);
            this.Controls.Add(this.tlpInventory);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmUserAdministration";
            this.Text = "HealthPortal | Inventario";
            this.cmsDataGrid.ResumeLayout(false);
            this.pnlMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUserDisplay)).EndInit();
            this.pnlSide.ResumeLayout(false);
            this.tlpSide.ResumeLayout(false);
            this.grpNewUser.ResumeLayout(false);
            this.tlpSub1.ResumeLayout(false);
            this.grpFilterSearchUsers.ResumeLayout(false);
            this.tlpSub2.ResumeLayout(false);
            this.tlpSub2.PerformLayout();
            this.pnlTitle.ResumeLayout(false);
            this.tlpTitle.ResumeLayout(false);
            this.tlpTitleSub.ResumeLayout(false);
            this.tlpTitleSub.PerformLayout();
            this.tlpControls.ResumeLayout(false);
            this.tlpInventory.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.ContextMenuStrip cmsDataGrid;
        public System.Windows.Forms.ToolStripMenuItem cmsDeleteUser;
        public System.Windows.Forms.ToolStripMenuItem cmsViewUserInfo;
        public System.Windows.Forms.ToolStripMenuItem cmsUpdateUserInfo;
        public System.Windows.Forms.ToolStripMenuItem cmsReestablishPassword;
        public CustomControls.PanelCustom pnlMain;
        public System.Windows.Forms.DataGridView dgvUserDisplay;
        public CustomControls.PanelCustom pnlSide;
        private System.Windows.Forms.TableLayoutPanel tlpSide;
        private System.Windows.Forms.GroupBox grpNewUser;
        private System.Windows.Forms.TableLayoutPanel tlpSub1;
        public CustomControls.RJButton btnAddNewUser;
        private System.Windows.Forms.GroupBox grpFilterSearchUsers;
        private System.Windows.Forms.TableLayoutPanel tlpSub2;
        public CustomControls.RJButton btnSearchForUser;
        public CustomControls.CustomTextBox txtUserAdministrationSearch;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.Panel pnlTitle;
        private System.Windows.Forms.TableLayoutPanel tlpInventory;
        private System.Windows.Forms.TableLayoutPanel tlpTitle;
        private System.Windows.Forms.TableLayoutPanel tlpTitleSub;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TableLayoutPanel tlpControls;
        public System.Windows.Forms.Button btnExit;
        public System.Windows.Forms.Button btnResize;
    }
}