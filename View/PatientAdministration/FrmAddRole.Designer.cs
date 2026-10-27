namespace HealthPortal.View.PatientAdministration
{
    partial class FrmAddRole
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
            this.btnExitE = new System.Windows.Forms.Button();
            this.lblRole = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtRole = new CustomControls.CustomTextBox();
            this.btnUpdateRole = new CustomControls.RJButton();
            this.btnAddRole = new CustomControls.RJButton();
            this.SuspendLayout();
            // 
            // btnExitE
            // 
            this.btnExitE.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnExitE.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExitE.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnExitE.FlatAppearance.BorderSize = 0;
            this.btnExitE.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnExitE.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnExitE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExitE.ForeColor = System.Drawing.Color.White;
            this.btnExitE.Image = global::HealthPortal.Properties.Resources.quit;
            this.btnExitE.Location = new System.Drawing.Point(545, 22);
            this.btnExitE.Name = "btnExitE";
            this.btnExitE.Size = new System.Drawing.Size(34, 34);
            this.btnExitE.TabIndex = 53;
            this.btnExitE.TabStop = false;
            this.btnExitE.UseVisualStyleBackColor = false;
            // 
            // lblRole
            // 
            this.lblRole.AutoSize = true;
            this.lblRole.Font = new System.Drawing.Font("Century Gothic", 23.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRole.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(202)))), ((int)(((byte)(230)))));
            this.lblRole.Location = new System.Drawing.Point(19, 19);
            this.lblRole.Margin = new System.Windows.Forms.Padding(10);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(214, 37);
            this.lblRole.TabIndex = 49;
            this.lblRole.Text = "Agregar Role";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(202)))), ((int)(((byte)(230)))));
            this.label6.Location = new System.Drawing.Point(59, 79);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 21);
            this.label6.TabIndex = 54;
            this.label6.Text = "Role";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(0, 0);
            this.txtID.Margin = new System.Windows.Forms.Padding(2);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(68, 20);
            this.txtID.TabIndex = 64;
            this.txtID.Visible = false;
            // 
            // txtRole
            // 
            this.txtRole.BackColor = System.Drawing.SystemColors.Window;
            this.txtRole.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(202)))), ((int)(((byte)(230)))));
            this.txtRole.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtRole.BorderRadius = 18;
            this.txtRole.BorderSize = 2;
            this.txtRole.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRole.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(202)))), ((int)(((byte)(230)))));
            this.txtRole.Location = new System.Drawing.Point(45, 100);
            this.txtRole.Margin = new System.Windows.Forms.Padding(20, 10, 20, 20);
            this.txtRole.MaxLength = 60;
            this.txtRole.Multiline = false;
            this.txtRole.Name = "txtRole";
            this.txtRole.Padding = new System.Windows.Forms.Padding(30, 20, 30, 20);
            this.txtRole.PasswordChar = false;
            this.txtRole.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtRole.PlaceholderText = "";
            this.txtRole.SelectionLength = 0;
            this.txtRole.SelectionStart = 0;
            this.txtRole.Size = new System.Drawing.Size(522, 58);
            this.txtRole.TabIndex = 19;
            this.txtRole.Texts = "";
            this.txtRole.UnderlinedStyle = false;
            // 
            // btnUpdateRole
            // 
            this.btnUpdateRole.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(202)))), ((int)(((byte)(230)))));
            this.btnUpdateRole.BackGroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(202)))), ((int)(((byte)(230)))));
            this.btnUpdateRole.BorderColor = System.Drawing.Color.CornflowerBlue;
            this.btnUpdateRole.BorderRadius = 30;
            this.btnUpdateRole.BorderSize = 0;
            this.btnUpdateRole.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdateRole.FlatAppearance.BorderSize = 0;
            this.btnUpdateRole.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateRole.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateRole.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(91)))));
            this.btnUpdateRole.Location = new System.Drawing.Point(277, 178);
            this.btnUpdateRole.Margin = new System.Windows.Forms.Padding(10);
            this.btnUpdateRole.Name = "btnUpdateRole";
            this.btnUpdateRole.Size = new System.Drawing.Size(141, 39);
            this.btnUpdateRole.TabIndex = 52;
            this.btnUpdateRole.TabStop = false;
            this.btnUpdateRole.Text = "Actualizar";
            this.btnUpdateRole.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(91)))));
            this.btnUpdateRole.UseVisualStyleBackColor = false;
            // 
            // btnAddRole
            // 
            this.btnAddRole.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(202)))), ((int)(((byte)(230)))));
            this.btnAddRole.BackGroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(202)))), ((int)(((byte)(230)))));
            this.btnAddRole.BorderColor = System.Drawing.Color.CornflowerBlue;
            this.btnAddRole.BorderRadius = 30;
            this.btnAddRole.BorderSize = 0;
            this.btnAddRole.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddRole.FlatAppearance.BorderSize = 0;
            this.btnAddRole.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddRole.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddRole.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(91)))));
            this.btnAddRole.Location = new System.Drawing.Point(438, 178);
            this.btnAddRole.Margin = new System.Windows.Forms.Padding(10);
            this.btnAddRole.Name = "btnAddRole";
            this.btnAddRole.Size = new System.Drawing.Size(141, 39);
            this.btnAddRole.TabIndex = 51;
            this.btnAddRole.TabStop = false;
            this.btnAddRole.Text = "Agregar";
            this.btnAddRole.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(91)))));
            this.btnAddRole.UseVisualStyleBackColor = false;
            // 
            // FrmAddRole
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(612, 263);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtRole);
            this.Controls.Add(this.btnExitE);
            this.Controls.Add(this.lblRole);
            this.Controls.Add(this.btnUpdateRole);
            this.Controls.Add(this.btnAddRole);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmAddRole";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmAddRole";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button btnExitE;
        public CustomControls.CustomTextBox txtRole;
        public System.Windows.Forms.Label lblRole;
        public CustomControls.RJButton btnUpdateRole;
        public CustomControls.RJButton btnAddRole;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox txtID;
    }
}