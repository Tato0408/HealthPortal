namespace HealthPortal.View.PatientAdministration
{
    partial class FrmAdminRol
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
            this.btnExitRoleAdministration = new System.Windows.Forms.Button();
            this.btnAddRol = new CustomControls.RJButton();
            this.dgvRol = new System.Windows.Forms.DataGridView();
            this.cmsRole = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.actualizarRolToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRol)).BeginInit();
            this.cmsRole.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnExitRoleAdministration
            // 
            this.btnExitRoleAdministration.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnExitRoleAdministration.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExitRoleAdministration.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnExitRoleAdministration.FlatAppearance.BorderSize = 0;
            this.btnExitRoleAdministration.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnExitRoleAdministration.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnExitRoleAdministration.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExitRoleAdministration.ForeColor = System.Drawing.Color.White;
            this.btnExitRoleAdministration.Image = global::HealthPortal.Properties.Resources.quit;
            this.btnExitRoleAdministration.Location = new System.Drawing.Point(423, 14);
            this.btnExitRoleAdministration.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnExitRoleAdministration.Name = "btnExitRoleAdministration";
            this.btnExitRoleAdministration.Size = new System.Drawing.Size(51, 52);
            this.btnExitRoleAdministration.TabIndex = 59;
            this.btnExitRoleAdministration.TabStop = false;
            this.btnExitRoleAdministration.UseVisualStyleBackColor = false;
            // 
            // btnAddRol
            // 
            this.btnAddRol.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(202)))), ((int)(((byte)(230)))));
            this.btnAddRol.BackGroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(202)))), ((int)(((byte)(230)))));
            this.btnAddRol.BorderColor = System.Drawing.Color.CornflowerBlue;
            this.btnAddRol.BorderRadius = 30;
            this.btnAddRol.BorderSize = 0;
            this.btnAddRol.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddRol.FlatAppearance.BorderSize = 0;
            this.btnAddRol.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddRol.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddRol.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(91)))));
            this.btnAddRol.Location = new System.Drawing.Point(334, 468);
            this.btnAddRol.Margin = new System.Windows.Forms.Padding(0);
            this.btnAddRol.Name = "btnAddRol";
            this.btnAddRol.Size = new System.Drawing.Size(140, 43);
            this.btnAddRol.TabIndex = 58;
            this.btnAddRol.TabStop = false;
            this.btnAddRol.Text = "Añadir Rol";
            this.btnAddRol.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(91)))));
            this.btnAddRol.UseVisualStyleBackColor = false;
            // 
            // dgvRol
            // 
            this.dgvRol.AllowUserToAddRows = false;
            this.dgvRol.AllowUserToDeleteRows = false;
            this.dgvRol.AllowUserToResizeColumns = false;
            this.dgvRol.AllowUserToResizeRows = false;
            this.dgvRol.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRol.BackgroundColor = System.Drawing.Color.White;
            this.dgvRol.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvRol.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvRol.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.dgvRol.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            dataGridViewCellStyle1.NullValue = "-----";
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(202)))), ((int)(((byte)(230)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRol.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvRol.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRol.ContextMenuStrip = this.cmsRole;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.NullValue = "-----";
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(202)))), ((int)(((byte)(230)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvRol.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvRol.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.dgvRol.Location = new System.Drawing.Point(37, 79);
            this.dgvRol.Margin = new System.Windows.Forms.Padding(0);
            this.dgvRol.MultiSelect = false;
            this.dgvRol.Name = "dgvRol";
            this.dgvRol.ReadOnly = true;
            this.dgvRol.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            dataGridViewCellStyle3.NullValue = "-----";
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(202)))), ((int)(((byte)(230)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRol.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvRol.RowHeadersVisible = false;
            this.dgvRol.RowHeadersWidth = 62;
            this.dgvRol.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvRol.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvRol.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvRol.Size = new System.Drawing.Size(437, 379);
            this.dgvRol.TabIndex = 57;
            this.dgvRol.TabStop = false;
            // 
            // cmsRole
            // 
            this.cmsRole.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.actualizarRolToolStripMenuItem});
            this.cmsRole.Name = "cmsRole";
            this.cmsRole.Size = new System.Drawing.Size(147, 26);
            // 
            // actualizarRolToolStripMenuItem
            // 
            this.actualizarRolToolStripMenuItem.Image = global::HealthPortal.Properties.Resources.actualizar__1_;
            this.actualizarRolToolStripMenuItem.Name = "actualizarRolToolStripMenuItem";
            this.actualizarRolToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.actualizarRolToolStripMenuItem.Text = "Actualizar Rol";
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Font = new System.Drawing.Font("Century Gothic", 23.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(202)))), ((int)(((byte)(230)))));
            this.lbl.Location = new System.Drawing.Point(24, 20);
            this.lbl.Margin = new System.Windows.Forms.Padding(15);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(296, 37);
            this.lbl.TabIndex = 56;
            this.lbl.Text = "Roles del paciente";
            // 
            // FrmAdminRol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(519, 544);
            this.Controls.Add(this.btnExitRoleAdministration);
            this.Controls.Add(this.btnAddRol);
            this.Controls.Add(this.dgvRol);
            this.Controls.Add(this.lbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmAdminRol";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmAdminRol";
            ((System.ComponentModel.ISupportInitialize)(this.dgvRol)).EndInit();
            this.cmsRole.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button btnExitRoleAdministration;
        public CustomControls.RJButton btnAddRol;
        public System.Windows.Forms.DataGridView dgvRol;
        public System.Windows.Forms.ContextMenuStrip cmsRole;
        public System.Windows.Forms.ToolStripMenuItem actualizarRolToolStripMenuItem;
        public System.Windows.Forms.Label lbl;
    }
}