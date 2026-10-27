namespace HealthPortal.View.MainPage
{
    partial class FrmMainPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMainPage));
            this.cmsDataGrid = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmsDeleteUser = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsReestablishPassword = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsViewUser = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsUpdateUser = new System.Windows.Forms.ToolStripMenuItem();
            this.timerDateTime = new System.Windows.Forms.Timer(this.components);
            this.tlpInventory = new System.Windows.Forms.TableLayoutPanel();
            this.pnlTitle = new System.Windows.Forms.Panel();
            this.tlpTitle = new System.Windows.Forms.TableLayoutPanel();
            this.tlpTitleSub = new System.Windows.Forms.TableLayoutPanel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.tlpControls = new System.Windows.Forms.TableLayoutPanel();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnResize = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.cmsDataGrid.SuspendLayout();
            this.tlpInventory.SuspendLayout();
            this.pnlTitle.SuspendLayout();
            this.tlpTitle.SuspendLayout();
            this.tlpTitleSub.SuspendLayout();
            this.tlpControls.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmsDataGrid
            // 
            this.cmsDataGrid.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmsDataGrid.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmsDataGrid.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmsDeleteUser,
            this.cmsReestablishPassword,
            this.cmsViewUser,
            this.cmsUpdateUser});
            this.cmsDataGrid.Name = "cmsDataGrid";
            this.cmsDataGrid.Size = new System.Drawing.Size(329, 100);
            // 
            // cmsDeleteUser
            // 
            this.cmsDeleteUser.Name = "cmsDeleteUser";
            this.cmsDeleteUser.Size = new System.Drawing.Size(328, 24);
            this.cmsDeleteUser.Text = "Eliminar Usuario";
            // 
            // cmsReestablishPassword
            // 
            this.cmsReestablishPassword.Name = "cmsReestablishPassword";
            this.cmsReestablishPassword.Size = new System.Drawing.Size(328, 24);
            this.cmsReestablishPassword.Text = "Reestablecer Contraseña";
            // 
            // cmsViewUser
            // 
            this.cmsViewUser.Name = "cmsViewUser";
            this.cmsViewUser.Size = new System.Drawing.Size(328, 24);
            this.cmsViewUser.Text = "Ver Información del Usuario";
            // 
            // cmsUpdateUser
            // 
            this.cmsUpdateUser.Name = "cmsUpdateUser";
            this.cmsUpdateUser.Size = new System.Drawing.Size(328, 24);
            this.cmsUpdateUser.Text = "Actualizar Información del Usuario";
            // 
            // timerDateTime
            // 
            this.timerDateTime.Enabled = true;
            // 
            // tlpInventory
            // 
            this.tlpInventory.ColumnCount = 5;
            this.tlpInventory.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2.830345F));
            this.tlpInventory.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 66.49635F));
            this.tlpInventory.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 3.79562F));
            this.tlpInventory.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.94161F));
            this.tlpInventory.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2.830345F));
            this.tlpInventory.Controls.Add(this.pnlTitle, 0, 0);
            this.tlpInventory.Controls.Add(this.tableLayoutPanel1, 1, 2);
            this.tlpInventory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpInventory.Location = new System.Drawing.Point(0, 0);
            this.tlpInventory.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tlpInventory.Name = "tlpInventory";
            this.tlpInventory.RowCount = 4;
            this.tlpInventory.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tlpInventory.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.630542F));
            this.tlpInventory.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 76.4532F));
            this.tlpInventory.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.630542F));
            this.tlpInventory.Size = new System.Drawing.Size(1827, 1015);
            this.tlpInventory.TabIndex = 2;
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
            this.pnlTitle.Size = new System.Drawing.Size(1827, 144);
            this.pnlTitle.TabIndex = 3;
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
            this.tlpTitle.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 144F));
            this.tlpTitle.Size = new System.Drawing.Size(1827, 144);
            this.tlpTitle.TabIndex = 0;
            // 
            // tlpTitleSub
            // 
            this.tlpTitleSub.ColumnCount = 3;
            this.tlpTitleSub.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.002201F));
            this.tlpTitleSub.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 94.2F));
            this.tlpTitleSub.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 0.8F));
            this.tlpTitleSub.Controls.Add(this.lblTitle, 1, 1);
            this.tlpTitleSub.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpTitleSub.Location = new System.Drawing.Point(0, 0);
            this.tlpTitleSub.Margin = new System.Windows.Forms.Padding(0);
            this.tlpTitleSub.Name = "tlpTitleSub";
            this.tlpTitleSub.RowCount = 3;
            this.tlpTitleSub.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tlpTitleSub.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tlpTitleSub.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpTitleSub.Size = new System.Drawing.Size(1333, 144);
            this.tlpTitleSub.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTitle.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(202)))), ((int)(((byte)(230)))));
            this.lblTitle.Location = new System.Drawing.Point(66, 50);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(1255, 57);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "Página Principal";
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
            this.tlpControls.Size = new System.Drawing.Size(494, 144);
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
            this.btnExit.Location = new System.Drawing.Point(349, 47);
            this.btnExit.Margin = new System.Windows.Forms.Padding(0);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(93, 47);
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
            this.btnResize.Location = new System.Drawing.Point(247, 47);
            this.btnResize.Margin = new System.Windows.Forms.Padding(0);
            this.btnResize.Name = "btnResize";
            this.btnResize.Size = new System.Drawing.Size(93, 47);
            this.btnResize.TabIndex = 39;
            this.btnResize.TabStop = false;
            this.btnResize.UseVisualStyleBackColor = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanel1.Controls.Add(this.lblDate, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblTime, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(51, 191);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.174603F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 96.82539F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1216, 776);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(91)))));
            this.lblDate.Location = new System.Drawing.Point(27, 0);
            this.lblDate.Margin = new System.Windows.Forms.Padding(27, 0, 0, 0);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(67, 23);
            this.lblDate.TabIndex = 2;
            this.lblDate.Text = "fecha";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Century Gothic", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(91)))));
            this.lblTime.Location = new System.Drawing.Point(0, 24);
            this.lblTime.Margin = new System.Windows.Forms.Padding(0);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(218, 93);
            this.lblTime.TabIndex = 1;
            this.lblTime.Text = "hora";
            // 
            // FrmMainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(202)))), ((int)(((byte)(230)))));
            this.ClientSize = new System.Drawing.Size(1827, 1015);
            this.Controls.Add(this.tlpInventory);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmMainPage";
            this.Text = "FrmUserAdministration";
            this.cmsDataGrid.ResumeLayout(false);
            this.tlpInventory.ResumeLayout(false);
            this.pnlTitle.ResumeLayout(false);
            this.tlpTitle.ResumeLayout(false);
            this.tlpTitleSub.ResumeLayout(false);
            this.tlpTitleSub.PerformLayout();
            this.tlpControls.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.ContextMenuStrip cmsDataGrid;
        public System.Windows.Forms.ToolStripMenuItem cmsDeleteUser;
        public System.Windows.Forms.ToolStripMenuItem cmsReestablishPassword;
        public System.Windows.Forms.ToolStripMenuItem cmsViewUser;
        public System.Windows.Forms.ToolStripMenuItem cmsUpdateUser;
        public System.Windows.Forms.Timer timerDateTime;
        private System.Windows.Forms.TableLayoutPanel tlpInventory;
        private System.Windows.Forms.Panel pnlTitle;
        private System.Windows.Forms.TableLayoutPanel tlpTitle;
        private System.Windows.Forms.TableLayoutPanel tlpTitleSub;
        private System.Windows.Forms.TableLayoutPanel tlpControls;
        public System.Windows.Forms.Button btnExit;
        public System.Windows.Forms.Button btnResize;
        public System.Windows.Forms.Label lblTime;
        public System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        public System.Windows.Forms.Label lblTitle;
    }
}