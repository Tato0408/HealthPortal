namespace HealthPortal.View.Settings
{
    partial class FrmProgramSettings
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
            this.tlpServerSettings = new System.Windows.Forms.TableLayoutPanel();
            this.pnlTitle = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panelCustom1 = new CustomControls.PanelCustom();
            this.tlpSub = new System.Windows.Forms.TableLayoutPanel();
            this.grpSecurityQuestions = new System.Windows.Forms.GroupBox();
            this.tlpSecurityQuestions = new System.Windows.Forms.TableLayoutPanel();
            this.dgvSecurityQuestions = new System.Windows.Forms.DataGridView();
            this.cmsDataGrid = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmsDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsUpdate = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAddSecurityQuestion = new CustomControls.RJButton();
            this.lblInfo = new System.Windows.Forms.Label();
            this.tlpServerSettings.SuspendLayout();
            this.pnlTitle.SuspendLayout();
            this.panelCustom1.SuspendLayout();
            this.tlpSub.SuspendLayout();
            this.grpSecurityQuestions.SuspendLayout();
            this.tlpSecurityQuestions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSecurityQuestions)).BeginInit();
            this.cmsDataGrid.SuspendLayout();
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
            this.pnlTitle.Controls.Add(this.lblTitle);
            this.pnlTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlTitle.Location = new System.Drawing.Point(0, 0);
            this.pnlTitle.Margin = new System.Windows.Forms.Padding(0);
            this.pnlTitle.Name = "pnlTitle";
            this.pnlTitle.Size = new System.Drawing.Size(1090, 119);
            this.pnlTitle.TabIndex = 2;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(41, 39);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(32, 39, 32, 32);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(496, 41);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Configuración del Programa";
            // 
            // panelCustom1
            // 
            this.panelCustom1.BackColor = System.Drawing.Color.White;
            this.panelCustom1.BorderRadius = 30;
            this.panelCustom1.Controls.Add(this.tlpSub);
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
            // tlpSub
            // 
            this.tlpSub.ColumnCount = 3;
            this.tlpSub.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 3F));
            this.tlpSub.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 94F));
            this.tlpSub.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 3F));
            this.tlpSub.Controls.Add(this.grpSecurityQuestions, 1, 1);
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
            this.tlpSub.Size = new System.Drawing.Size(994, 537);
            this.tlpSub.TabIndex = 2;
            // 
            // grpSecurityQuestions
            // 
            this.grpSecurityQuestions.Controls.Add(this.tlpSecurityQuestions);
            this.grpSecurityQuestions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpSecurityQuestions.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpSecurityQuestions.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.grpSecurityQuestions.Location = new System.Drawing.Point(29, 29);
            this.grpSecurityQuestions.Margin = new System.Windows.Forms.Padding(0);
            this.grpSecurityQuestions.Name = "grpSecurityQuestions";
            this.grpSecurityQuestions.Size = new System.Drawing.Size(934, 223);
            this.grpSecurityQuestions.TabIndex = 6;
            this.grpSecurityQuestions.TabStop = false;
            this.grpSecurityQuestions.Text = "Preguntas de seguridad";
            // 
            // tlpSecurityQuestions
            // 
            this.tlpSecurityQuestions.ColumnCount = 5;
            this.tlpSecurityQuestions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 1.081139F));
            this.tlpSecurityQuestions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 66.37931F));
            this.tlpSecurityQuestions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 0.862069F));
            this.tlpSecurityQuestions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.49569F));
            this.tlpSecurityQuestions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 1.078723F));
            this.tlpSecurityQuestions.Controls.Add(this.dgvSecurityQuestions, 1, 3);
            this.tlpSecurityQuestions.Controls.Add(this.btnAddSecurityQuestion, 3, 1);
            this.tlpSecurityQuestions.Controls.Add(this.lblInfo, 1, 1);
            this.tlpSecurityQuestions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpSecurityQuestions.Location = new System.Drawing.Point(3, 19);
            this.tlpSecurityQuestions.Margin = new System.Windows.Forms.Padding(0);
            this.tlpSecurityQuestions.Name = "tlpSecurityQuestions";
            this.tlpSecurityQuestions.RowCount = 5;
            this.tlpSecurityQuestions.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.492183F));
            this.tlpSecurityQuestions.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.454F));
            this.tlpSecurityQuestions.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.492183F));
            this.tlpSecurityQuestions.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 65.06947F));
            this.tlpSecurityQuestions.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.492183F));
            this.tlpSecurityQuestions.Size = new System.Drawing.Size(928, 201);
            this.tlpSecurityQuestions.TabIndex = 0;
            // 
            // dgvSecurityQuestions
            // 
            this.dgvSecurityQuestions.AllowUserToAddRows = false;
            this.dgvSecurityQuestions.AllowUserToDeleteRows = false;
            this.dgvSecurityQuestions.AllowUserToResizeColumns = false;
            this.dgvSecurityQuestions.AllowUserToResizeRows = false;
            this.dgvSecurityQuestions.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSecurityQuestions.BackgroundColor = System.Drawing.Color.White;
            this.dgvSecurityQuestions.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvSecurityQuestions.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvSecurityQuestions.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.dgvSecurityQuestions.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            dataGridViewCellStyle1.NullValue = "-----";
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(202)))), ((int)(((byte)(230)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSecurityQuestions.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvSecurityQuestions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tlpSecurityQuestions.SetColumnSpan(this.dgvSecurityQuestions, 3);
            this.dgvSecurityQuestions.ContextMenuStrip = this.cmsDataGrid;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            dataGridViewCellStyle2.NullValue = "-----";
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(202)))), ((int)(((byte)(230)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSecurityQuestions.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvSecurityQuestions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSecurityQuestions.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.dgvSecurityQuestions.Location = new System.Drawing.Point(10, 57);
            this.dgvSecurityQuestions.Margin = new System.Windows.Forms.Padding(0);
            this.dgvSecurityQuestions.MultiSelect = false;
            this.dgvSecurityQuestions.Name = "dgvSecurityQuestions";
            this.dgvSecurityQuestions.ReadOnly = true;
            this.dgvSecurityQuestions.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            dataGridViewCellStyle3.NullValue = "-----";
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(202)))), ((int)(((byte)(230)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSecurityQuestions.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvSecurityQuestions.RowHeadersVisible = false;
            this.dgvSecurityQuestions.RowHeadersWidth = 51;
            this.dgvSecurityQuestions.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvSecurityQuestions.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvSecurityQuestions.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvSecurityQuestions.Size = new System.Drawing.Size(907, 130);
            this.dgvSecurityQuestions.TabIndex = 7;
            this.dgvSecurityQuestions.TabStop = false;
            // 
            // cmsDataGrid
            // 
            this.cmsDataGrid.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmsDataGrid.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmsDataGrid.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmsDelete,
            this.cmsUpdate});
            this.cmsDataGrid.Name = "cmsDataGrid";
            this.cmsDataGrid.Size = new System.Drawing.Size(280, 56);
            // 
            // cmsDelete
            // 
            this.cmsDelete.Image = global::HealthPortal.Properties.Resources.papelera_xmark;
            this.cmsDelete.Name = "cmsDelete";
            this.cmsDelete.Size = new System.Drawing.Size(279, 26);
            this.cmsDelete.Text = "Eliminar pregunta de seguridad";
            // 
            // cmsUpdate
            // 
            this.cmsUpdate.Image = global::HealthPortal.Properties.Resources.actualizar__1_;
            this.cmsUpdate.Name = "cmsUpdate";
            this.cmsUpdate.Size = new System.Drawing.Size(279, 26);
            this.cmsUpdate.Text = "Actualizar pregunta de seguridad";
            // 
            // btnAddSecurityQuestion
            // 
            this.btnAddSecurityQuestion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(183)))), ((int)(((byte)(3)))));
            this.btnAddSecurityQuestion.BackGroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(183)))), ((int)(((byte)(3)))));
            this.btnAddSecurityQuestion.BorderColor = System.Drawing.Color.CornflowerBlue;
            this.btnAddSecurityQuestion.BorderRadius = 25;
            this.btnAddSecurityQuestion.BorderSize = 0;
            this.btnAddSecurityQuestion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddSecurityQuestion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAddSecurityQuestion.FlatAppearance.BorderSize = 0;
            this.btnAddSecurityQuestion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddSecurityQuestion.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddSecurityQuestion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(91)))));
            this.btnAddSecurityQuestion.Location = new System.Drawing.Point(634, 13);
            this.btnAddSecurityQuestion.Margin = new System.Windows.Forms.Padding(0);
            this.btnAddSecurityQuestion.Name = "btnAddSecurityQuestion";
            this.btnAddSecurityQuestion.Size = new System.Drawing.Size(283, 31);
            this.btnAddSecurityQuestion.TabIndex = 10;
            this.btnAddSecurityQuestion.Text = "Añadir pregunta de seguridad";
            this.btnAddSecurityQuestion.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(91)))));
            this.btnAddSecurityQuestion.UseVisualStyleBackColor = false;
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblInfo.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(202)))), ((int)(((byte)(230)))));
            this.lblInfo.Location = new System.Drawing.Point(13, 13);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(610, 31);
            this.lblInfo.TabIndex = 2;
            this.lblInfo.Text = "Porque de tal manera amó Dios al mundo, que ha dado a su Hijo unigénito, para que" +
    " todo aquel que en él cree, no se pierda, mas tenga vida eterna.";
            // 
            // FrmProgramSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(202)))), ((int)(((byte)(230)))));
            this.ClientSize = new System.Drawing.Size(1090, 705);
            this.Controls.Add(this.tlpServerSettings);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimizeBox = false;
            this.Name = "FrmProgramSettings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Configuración del servidor";
            this.tlpServerSettings.ResumeLayout(false);
            this.pnlTitle.ResumeLayout(false);
            this.pnlTitle.PerformLayout();
            this.panelCustom1.ResumeLayout(false);
            this.tlpSub.ResumeLayout(false);
            this.grpSecurityQuestions.ResumeLayout(false);
            this.tlpSecurityQuestions.ResumeLayout(false);
            this.tlpSecurityQuestions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSecurityQuestions)).EndInit();
            this.cmsDataGrid.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpServerSettings;
        public CustomControls.PanelCustom panelCustom1;
        private System.Windows.Forms.Label lblTitle;
        public System.Windows.Forms.Panel pnlTitle;
        private System.Windows.Forms.TableLayoutPanel tlpSub;
        public System.Windows.Forms.GroupBox grpSecurityQuestions;
        private System.Windows.Forms.TableLayoutPanel tlpSecurityQuestions;
        public CustomControls.RJButton btnAddSecurityQuestion;
        public System.Windows.Forms.DataGridView dgvSecurityQuestions;
        public System.Windows.Forms.Label lblInfo;
        public System.Windows.Forms.ContextMenuStrip cmsDataGrid;
        public System.Windows.Forms.ToolStripMenuItem cmsDelete;
        public System.Windows.Forms.ToolStripMenuItem cmsUpdate;
    }
}