namespace HealthPortal.View.Settings
{
    partial class FrmServerSettings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmServerSettings));
            this.tlpServerSettings = new System.Windows.Forms.TableLayoutPanel();
            this.pnlTitle = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panelCustom1 = new CustomControls.PanelCustom();
            this.tlpBigSub = new System.Windows.Forms.TableLayoutPanel();
            this.tlpSub = new System.Windows.Forms.TableLayoutPanel();
            this.grpLocalConfig = new System.Windows.Forms.GroupBox();
            this.tlpLocalConfig = new System.Windows.Forms.TableLayoutPanel();
            this.tlpSQLAuth = new System.Windows.Forms.TableLayoutPanel();
            this.txtSQLAuth = new CustomControls.CustomTextBox();
            this.txtPassword = new CustomControls.CustomTextBox();
            this.tlpIntegratedWinSecurity = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.rdoTrue = new System.Windows.Forms.RadioButton();
            this.rdoFalse = new System.Windows.Forms.RadioButton();
            this.grpDatabaseConnection = new System.Windows.Forms.GroupBox();
            this.tlpDBConnection = new System.Windows.Forms.TableLayoutPanel();
            this.txtServerURL = new CustomControls.CustomTextBox();
            this.txtDataBase = new CustomControls.CustomTextBox();
            this.btnSaveConfig = new CustomControls.RJButton();
            this.tlpServerSettings.SuspendLayout();
            this.pnlTitle.SuspendLayout();
            this.panelCustom1.SuspendLayout();
            this.tlpBigSub.SuspendLayout();
            this.tlpSub.SuspendLayout();
            this.grpLocalConfig.SuspendLayout();
            this.tlpLocalConfig.SuspendLayout();
            this.tlpSQLAuth.SuspendLayout();
            this.tlpIntegratedWinSecurity.SuspendLayout();
            this.grpDatabaseConnection.SuspendLayout();
            this.tlpDBConnection.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpServerSettings
            // 
            this.tlpServerSettings.ColumnCount = 3;
            this.tlpServerSettings.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 4.4F));
            this.tlpServerSettings.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 91.2F));
            this.tlpServerSettings.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 4.4F));
            this.tlpServerSettings.Controls.Add(this.pnlTitle, 0, 0);
            this.tlpServerSettings.Controls.Add(this.panelCustom1, 1, 1);
            this.tlpServerSettings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpServerSettings.Location = new System.Drawing.Point(0, 0);
            this.tlpServerSettings.Margin = new System.Windows.Forms.Padding(0);
            this.tlpServerSettings.Name = "tlpServerSettings";
            this.tlpServerSettings.RowCount = 3;
            this.tlpServerSettings.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.02F));
            this.tlpServerSettings.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 76.18F));
            this.tlpServerSettings.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.8F));
            this.tlpServerSettings.Size = new System.Drawing.Size(1090, 705);
            this.tlpServerSettings.TabIndex = 0;
            // 
            // pnlTitle
            // 
            this.pnlTitle.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnlTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(202)))), ((int)(((byte)(230)))));
            this.tlpServerSettings.SetColumnSpan(this.pnlTitle, 3);
            this.pnlTitle.Controls.Add(this.btnExit);
            this.pnlTitle.Controls.Add(this.lblTitle);
            this.pnlTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlTitle.Location = new System.Drawing.Point(0, 0);
            this.pnlTitle.Margin = new System.Windows.Forms.Padding(0);
            this.pnlTitle.Name = "pnlTitle";
            this.pnlTitle.Size = new System.Drawing.Size(1090, 119);
            this.pnlTitle.TabIndex = 2;
            // 
            // btnExit
            // 
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(202)))), ((int)(((byte)(230)))));
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Image = global::HealthPortal.Properties.Resources.gquit;
            this.btnExit.Location = new System.Drawing.Point(1044, 12);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(34, 34);
            this.btnExit.TabIndex = 38;
            this.btnExit.TabStop = false;
            this.btnExit.UseVisualStyleBackColor = false;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(41, 39);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(32, 39, 32, 32);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(465, 41);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Configuración del Servidor";
            // 
            // panelCustom1
            // 
            this.panelCustom1.BackColor = System.Drawing.Color.White;
            this.panelCustom1.BorderRadius = 30;
            this.panelCustom1.Controls.Add(this.tlpBigSub);
            this.panelCustom1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCustom1.ForeColor = System.Drawing.Color.Black;
            this.panelCustom1.GradientAngle = 90F;
            this.panelCustom1.GradientBottomColor = System.Drawing.Color.White;
            this.panelCustom1.GradientTopColor = System.Drawing.Color.White;
            this.panelCustom1.Location = new System.Drawing.Point(47, 119);
            this.panelCustom1.Margin = new System.Windows.Forms.Padding(0);
            this.panelCustom1.Name = "panelCustom1";
            this.panelCustom1.Size = new System.Drawing.Size(994, 537);
            this.panelCustom1.TabIndex = 7;
            // 
            // tlpBigSub
            // 
            this.tlpBigSub.ColumnCount = 4;
            this.tlpBigSub.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32.33182F));
            this.tlpBigSub.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32.33181F));
            this.tlpBigSub.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32.33181F));
            this.tlpBigSub.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 3.004554F));
            this.tlpBigSub.Controls.Add(this.tlpSub, 0, 0);
            this.tlpBigSub.Controls.Add(this.btnSaveConfig, 2, 1);
            this.tlpBigSub.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpBigSub.Location = new System.Drawing.Point(0, 0);
            this.tlpBigSub.Margin = new System.Windows.Forms.Padding(0);
            this.tlpBigSub.Name = "tlpBigSub";
            this.tlpBigSub.RowCount = 4;
            this.tlpBigSub.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 88.45438F));
            this.tlpBigSub.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.538175F));
            this.tlpBigSub.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.096834F));
            this.tlpBigSub.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.400373F));
            this.tlpBigSub.Size = new System.Drawing.Size(994, 537);
            this.tlpBigSub.TabIndex = 0;
            // 
            // tlpSub
            // 
            this.tlpSub.ColumnCount = 3;
            this.tlpBigSub.SetColumnSpan(this.tlpSub, 4);
            this.tlpSub.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 3F));
            this.tlpSub.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 94F));
            this.tlpSub.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 3F));
            this.tlpSub.Controls.Add(this.grpLocalConfig, 1, 3);
            this.tlpSub.Controls.Add(this.grpDatabaseConnection, 1, 1);
            this.tlpSub.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpSub.Location = new System.Drawing.Point(0, 0);
            this.tlpSub.Margin = new System.Windows.Forms.Padding(0);
            this.tlpSub.Name = "tlpSub";
            this.tlpSub.RowCount = 5;
            this.tlpSub.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.58F));
            this.tlpSub.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 41.63F));
            this.tlpSub.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.58F));
            this.tlpSub.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 41.63F));
            this.tlpSub.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.58F));
            this.tlpSub.Size = new System.Drawing.Size(994, 468);
            this.tlpSub.TabIndex = 1;
            // 
            // grpLocalConfig
            // 
            this.grpLocalConfig.Controls.Add(this.tlpLocalConfig);
            this.grpLocalConfig.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpLocalConfig.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpLocalConfig.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.grpLocalConfig.Location = new System.Drawing.Point(29, 246);
            this.grpLocalConfig.Margin = new System.Windows.Forms.Padding(0);
            this.grpLocalConfig.Name = "grpLocalConfig";
            this.grpLocalConfig.Size = new System.Drawing.Size(934, 194);
            this.grpLocalConfig.TabIndex = 7;
            this.grpLocalConfig.TabStop = false;
            this.grpLocalConfig.Text = "Configuración local";
            // 
            // tlpLocalConfig
            // 
            this.tlpLocalConfig.ColumnCount = 2;
            this.tlpLocalConfig.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpLocalConfig.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpLocalConfig.Controls.Add(this.tlpSQLAuth, 0, 0);
            this.tlpLocalConfig.Controls.Add(this.tlpIntegratedWinSecurity, 0, 0);
            this.tlpLocalConfig.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpLocalConfig.Location = new System.Drawing.Point(3, 19);
            this.tlpLocalConfig.Margin = new System.Windows.Forms.Padding(0);
            this.tlpLocalConfig.Name = "tlpLocalConfig";
            this.tlpLocalConfig.RowCount = 1;
            this.tlpLocalConfig.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpLocalConfig.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 172F));
            this.tlpLocalConfig.Size = new System.Drawing.Size(928, 172);
            this.tlpLocalConfig.TabIndex = 0;
            // 
            // tlpSQLAuth
            // 
            this.tlpSQLAuth.ColumnCount = 3;
            this.tlpSQLAuth.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2.16F));
            this.tlpSQLAuth.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 95.67999F));
            this.tlpSQLAuth.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2.16F));
            this.tlpSQLAuth.Controls.Add(this.txtSQLAuth, 1, 1);
            this.tlpSQLAuth.Controls.Add(this.txtPassword, 1, 3);
            this.tlpSQLAuth.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpSQLAuth.Location = new System.Drawing.Point(464, 0);
            this.tlpSQLAuth.Margin = new System.Windows.Forms.Padding(0);
            this.tlpSQLAuth.Name = "tlpSQLAuth";
            this.tlpSQLAuth.RowCount = 5;
            this.tlpSQLAuth.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.98786F));
            this.tlpSQLAuth.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30.51821F));
            this.tlpSQLAuth.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.98786F));
            this.tlpSQLAuth.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30.51821F));
            this.tlpSQLAuth.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.98786F));
            this.tlpSQLAuth.Size = new System.Drawing.Size(464, 172);
            this.tlpSQLAuth.TabIndex = 3;
            // 
            // txtSQLAuth
            // 
            this.txtSQLAuth.BackColor = System.Drawing.SystemColors.Window;
            this.txtSQLAuth.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(202)))), ((int)(((byte)(230)))));
            this.txtSQLAuth.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtSQLAuth.BorderRadius = 18;
            this.txtSQLAuth.BorderSize = 2;
            this.txtSQLAuth.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSQLAuth.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSQLAuth.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(202)))), ((int)(((byte)(230)))));
            this.txtSQLAuth.Location = new System.Drawing.Point(10, 22);
            this.txtSQLAuth.Margin = new System.Windows.Forms.Padding(0);
            this.txtSQLAuth.MaxLength = 50;
            this.txtSQLAuth.Multiline = false;
            this.txtSQLAuth.Name = "txtSQLAuth";
            this.txtSQLAuth.Padding = new System.Windows.Forms.Padding(25, 17, 25, 18);
            this.txtSQLAuth.PasswordChar = false;
            this.txtSQLAuth.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtSQLAuth.PlaceholderText = "";
            this.txtSQLAuth.SelectionLength = 0;
            this.txtSQLAuth.SelectionStart = 0;
            this.txtSQLAuth.Size = new System.Drawing.Size(443, 52);
            this.txtSQLAuth.TabIndex = 7;
            this.txtSQLAuth.Tag = "sql";
            this.txtSQLAuth.Texts = "Autenticación de SQL";
            this.txtSQLAuth.UnderlinedStyle = false;
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.SystemColors.Window;
            this.txtPassword.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(202)))), ((int)(((byte)(230)))));
            this.txtPassword.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtPassword.BorderRadius = 18;
            this.txtPassword.BorderSize = 2;
            this.txtPassword.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtPassword.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(202)))), ((int)(((byte)(230)))));
            this.txtPassword.Location = new System.Drawing.Point(10, 96);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(0);
            this.txtPassword.MaxLength = 50;
            this.txtPassword.Multiline = false;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Padding = new System.Windows.Forms.Padding(25, 17, 25, 18);
            this.txtPassword.PasswordChar = false;
            this.txtPassword.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtPassword.PlaceholderText = "";
            this.txtPassword.SelectionLength = 0;
            this.txtPassword.SelectionStart = 0;
            this.txtPassword.Size = new System.Drawing.Size(443, 52);
            this.txtPassword.TabIndex = 8;
            this.txtPassword.Tag = "sql";
            this.txtPassword.Texts = "Contraseña de SQL";
            this.txtPassword.UnderlinedStyle = false;
            // 
            // tlpIntegratedWinSecurity
            // 
            this.tlpIntegratedWinSecurity.ColumnCount = 3;
            this.tlpIntegratedWinSecurity.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.974138F));
            this.tlpIntegratedWinSecurity.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 87.5F));
            this.tlpIntegratedWinSecurity.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 4.31F));
            this.tlpIntegratedWinSecurity.Controls.Add(this.label1, 1, 1);
            this.tlpIntegratedWinSecurity.Controls.Add(this.rdoTrue, 1, 3);
            this.tlpIntegratedWinSecurity.Controls.Add(this.rdoFalse, 1, 5);
            this.tlpIntegratedWinSecurity.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpIntegratedWinSecurity.Location = new System.Drawing.Point(0, 0);
            this.tlpIntegratedWinSecurity.Margin = new System.Windows.Forms.Padding(0);
            this.tlpIntegratedWinSecurity.Name = "tlpIntegratedWinSecurity";
            this.tlpIntegratedWinSecurity.RowCount = 7;
            this.tlpIntegratedWinSecurity.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.8506F));
            this.tlpIntegratedWinSecurity.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.64558F));
            this.tlpIntegratedWinSecurity.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.8506F));
            this.tlpIntegratedWinSecurity.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 23.68593F));
            this.tlpIntegratedWinSecurity.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.430753F));
            this.tlpIntegratedWinSecurity.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 23.68593F));
            this.tlpIntegratedWinSecurity.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.8506F));
            this.tlpIntegratedWinSecurity.Size = new System.Drawing.Size(464, 172);
            this.tlpIntegratedWinSecurity.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(202)))), ((int)(((byte)(230)))));
            this.label1.Location = new System.Drawing.Point(40, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(400, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Seguridad integrada de Windows";
            // 
            // rdoTrue
            // 
            this.rdoTrue.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.rdoTrue.AutoSize = true;
            this.rdoTrue.Checked = true;
            this.rdoTrue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rdoTrue.Location = new System.Drawing.Point(40, 64);
            this.rdoTrue.Name = "rdoTrue";
            this.rdoTrue.Size = new System.Drawing.Size(400, 34);
            this.rdoTrue.TabIndex = 2;
            this.rdoTrue.TabStop = true;
            this.rdoTrue.Text = "Habilitar autenticación de Windows";
            this.rdoTrue.UseVisualStyleBackColor = true;
            // 
            // rdoFalse
            // 
            this.rdoFalse.AutoSize = true;
            this.rdoFalse.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rdoFalse.Location = new System.Drawing.Point(40, 113);
            this.rdoFalse.Name = "rdoFalse";
            this.rdoFalse.Size = new System.Drawing.Size(400, 34);
            this.rdoFalse.TabIndex = 3;
            this.rdoFalse.Text = "Deshabilitar autenticación de Windows";
            this.rdoFalse.UseVisualStyleBackColor = true;
            // 
            // grpDatabaseConnection
            // 
            this.grpDatabaseConnection.Controls.Add(this.tlpDBConnection);
            this.grpDatabaseConnection.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpDatabaseConnection.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpDatabaseConnection.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.grpDatabaseConnection.Location = new System.Drawing.Point(29, 26);
            this.grpDatabaseConnection.Margin = new System.Windows.Forms.Padding(0);
            this.grpDatabaseConnection.Name = "grpDatabaseConnection";
            this.grpDatabaseConnection.Size = new System.Drawing.Size(934, 194);
            this.grpDatabaseConnection.TabIndex = 6;
            this.grpDatabaseConnection.TabStop = false;
            this.grpDatabaseConnection.Text = "Conexión con la base de datos";
            // 
            // tlpDBConnection
            // 
            this.tlpDBConnection.ColumnCount = 3;
            this.tlpDBConnection.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2.16F));
            this.tlpDBConnection.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 95.67999F));
            this.tlpDBConnection.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2.16F));
            this.tlpDBConnection.Controls.Add(this.txtServerURL, 1, 1);
            this.tlpDBConnection.Controls.Add(this.txtDataBase, 1, 3);
            this.tlpDBConnection.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpDBConnection.Location = new System.Drawing.Point(3, 19);
            this.tlpDBConnection.Margin = new System.Windows.Forms.Padding(0);
            this.tlpDBConnection.Name = "tlpDBConnection";
            this.tlpDBConnection.RowCount = 5;
            this.tlpDBConnection.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.98786F));
            this.tlpDBConnection.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30.51821F));
            this.tlpDBConnection.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.98786F));
            this.tlpDBConnection.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30.51821F));
            this.tlpDBConnection.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.98786F));
            this.tlpDBConnection.Size = new System.Drawing.Size(928, 172);
            this.tlpDBConnection.TabIndex = 0;
            // 
            // txtServerURL
            // 
            this.txtServerURL.BackColor = System.Drawing.SystemColors.Window;
            this.txtServerURL.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(202)))), ((int)(((byte)(230)))));
            this.txtServerURL.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtServerURL.BorderRadius = 18;
            this.txtServerURL.BorderSize = 2;
            this.txtServerURL.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtServerURL.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtServerURL.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(202)))), ((int)(((byte)(230)))));
            this.txtServerURL.Location = new System.Drawing.Point(20, 22);
            this.txtServerURL.Margin = new System.Windows.Forms.Padding(0);
            this.txtServerURL.MaxLength = 50;
            this.txtServerURL.Multiline = false;
            this.txtServerURL.Name = "txtServerURL";
            this.txtServerURL.Padding = new System.Windows.Forms.Padding(25, 17, 25, 18);
            this.txtServerURL.PasswordChar = false;
            this.txtServerURL.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtServerURL.PlaceholderText = "";
            this.txtServerURL.SelectionLength = 0;
            this.txtServerURL.SelectionStart = 0;
            this.txtServerURL.Size = new System.Drawing.Size(887, 52);
            this.txtServerURL.TabIndex = 7;
            this.txtServerURL.Tag = "sql";
            this.txtServerURL.Texts = "URL del servidor";
            this.txtServerURL.UnderlinedStyle = false;
            // 
            // txtDataBase
            // 
            this.txtDataBase.BackColor = System.Drawing.SystemColors.Window;
            this.txtDataBase.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(202)))), ((int)(((byte)(230)))));
            this.txtDataBase.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtDataBase.BorderRadius = 18;
            this.txtDataBase.BorderSize = 2;
            this.txtDataBase.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtDataBase.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDataBase.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(202)))), ((int)(((byte)(230)))));
            this.txtDataBase.Location = new System.Drawing.Point(20, 96);
            this.txtDataBase.Margin = new System.Windows.Forms.Padding(0);
            this.txtDataBase.MaxLength = 50;
            this.txtDataBase.Multiline = false;
            this.txtDataBase.Name = "txtDataBase";
            this.txtDataBase.Padding = new System.Windows.Forms.Padding(25, 17, 25, 18);
            this.txtDataBase.PasswordChar = false;
            this.txtDataBase.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtDataBase.PlaceholderText = "";
            this.txtDataBase.SelectionLength = 0;
            this.txtDataBase.SelectionStart = 0;
            this.txtDataBase.Size = new System.Drawing.Size(887, 52);
            this.txtDataBase.TabIndex = 8;
            this.txtDataBase.Tag = "sql";
            this.txtDataBase.Texts = "Nombre de la base de datos";
            this.txtDataBase.UnderlinedStyle = false;
            // 
            // btnSaveConfig
            // 
            this.btnSaveConfig.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(183)))), ((int)(((byte)(3)))));
            this.btnSaveConfig.BackGroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(183)))), ((int)(((byte)(3)))));
            this.btnSaveConfig.BorderColor = System.Drawing.Color.CornflowerBlue;
            this.btnSaveConfig.BorderRadius = 25;
            this.btnSaveConfig.BorderSize = 0;
            this.btnSaveConfig.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSaveConfig.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSaveConfig.FlatAppearance.BorderSize = 0;
            this.btnSaveConfig.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveConfig.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveConfig.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(91)))));
            this.btnSaveConfig.Location = new System.Drawing.Point(642, 468);
            this.btnSaveConfig.Margin = new System.Windows.Forms.Padding(0);
            this.btnSaveConfig.Name = "btnSaveConfig";
            this.tlpBigSub.SetRowSpan(this.btnSaveConfig, 2);
            this.btnSaveConfig.Size = new System.Drawing.Size(321, 39);
            this.btnSaveConfig.TabIndex = 9;
            this.btnSaveConfig.Text = "Guardar configuración del servidor";
            this.btnSaveConfig.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(91)))));
            this.btnSaveConfig.UseVisualStyleBackColor = false;
            // 
            // FrmServerSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(202)))), ((int)(((byte)(230)))));
            this.ClientSize = new System.Drawing.Size(1090, 705);
            this.Controls.Add(this.tlpServerSettings);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimizeBox = false;
            this.Name = "FrmServerSettings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Configuración del servidor";
            this.tlpServerSettings.ResumeLayout(false);
            this.pnlTitle.ResumeLayout(false);
            this.pnlTitle.PerformLayout();
            this.panelCustom1.ResumeLayout(false);
            this.tlpBigSub.ResumeLayout(false);
            this.tlpSub.ResumeLayout(false);
            this.grpLocalConfig.ResumeLayout(false);
            this.tlpLocalConfig.ResumeLayout(false);
            this.tlpSQLAuth.ResumeLayout(false);
            this.tlpIntegratedWinSecurity.ResumeLayout(false);
            this.tlpIntegratedWinSecurity.PerformLayout();
            this.grpDatabaseConnection.ResumeLayout(false);
            this.tlpDBConnection.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpServerSettings;
        public CustomControls.PanelCustom panelCustom1;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TableLayoutPanel tlpBigSub;
        private System.Windows.Forms.TableLayoutPanel tlpSub;
        public System.Windows.Forms.GroupBox grpLocalConfig;
        private System.Windows.Forms.TableLayoutPanel tlpLocalConfig;
        public CustomControls.CustomTextBox txtSQLAuth;
        public CustomControls.CustomTextBox txtPassword;
        private System.Windows.Forms.TableLayoutPanel tlpIntegratedWinSecurity;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.GroupBox grpDatabaseConnection;
        private System.Windows.Forms.TableLayoutPanel tlpDBConnection;
        public CustomControls.CustomTextBox txtServerURL;
        public CustomControls.CustomTextBox txtDataBase;
        public System.Windows.Forms.TableLayoutPanel tlpSQLAuth;
        public System.Windows.Forms.RadioButton rdoTrue;
        public System.Windows.Forms.RadioButton rdoFalse;
        public System.Windows.Forms.Panel pnlTitle;
        public CustomControls.RJButton btnSaveConfig;
        public System.Windows.Forms.Button btnExit;
    }
}