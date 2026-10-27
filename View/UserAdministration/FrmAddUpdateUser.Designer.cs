namespace HealthPortal.View.UserAdministration
{
    partial class FrmAddUpdateUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAddUpdateUser));
            this.grpLoginInfo = new System.Windows.Forms.GroupBox();
            this.lblFilter = new System.Windows.Forms.Label();
            this.cmbUserAdministrationRole = new System.Windows.Forms.ComboBox();
            this.txtUserAdministrationUsername = new CustomControls.CustomTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnAddNewUser = new CustomControls.RJButton();
            this.txtUserAdministrationPhoneNumber = new CustomControls.CustomTextBox();
            this.txtUserAdministrationEmail = new CustomControls.CustomTextBox();
            this.txtUserAdministrationLastName = new CustomControls.CustomTextBox();
            this.txtUserAdministrationName = new CustomControls.CustomTextBox();
            this.btnUpdateUser = new CustomControls.RJButton();
            this.txtUserAdministrationId = new CustomControls.CustomTextBox();
            this.grpLoginInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpLoginInfo
            // 
            this.grpLoginInfo.Controls.Add(this.lblFilter);
            this.grpLoginInfo.Controls.Add(this.cmbUserAdministrationRole);
            this.grpLoginInfo.Controls.Add(this.txtUserAdministrationUsername);
            this.grpLoginInfo.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpLoginInfo.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.grpLoginInfo.Location = new System.Drawing.Point(21, 208);
            this.grpLoginInfo.Margin = new System.Windows.Forms.Padding(15);
            this.grpLoginInfo.Name = "grpLoginInfo";
            this.grpLoginInfo.Size = new System.Drawing.Size(620, 98);
            this.grpLoginInfo.TabIndex = 5;
            this.grpLoginInfo.TabStop = false;
            this.grpLoginInfo.Text = "Información de usuario";
            // 
            // lblFilter
            // 
            this.lblFilter.AutoSize = true;
            this.lblFilter.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFilter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(202)))), ((int)(((byte)(230)))));
            this.lblFilter.Location = new System.Drawing.Point(319, 28);
            this.lblFilter.Margin = new System.Windows.Forms.Padding(0);
            this.lblFilter.Name = "lblFilter";
            this.lblFilter.Size = new System.Drawing.Size(84, 15);
            this.lblFilter.TabIndex = 31;
            this.lblFilter.Text = "Rol de acceso";
            // 
            // cmbUserAdministrationRole
            // 
            this.cmbUserAdministrationRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUserAdministrationRole.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(91)))));
            this.cmbUserAdministrationRole.FormattingEnabled = true;
            this.cmbUserAdministrationRole.Location = new System.Drawing.Point(322, 48);
            this.cmbUserAdministrationRole.Margin = new System.Windows.Forms.Padding(20);
            this.cmbUserAdministrationRole.Name = "cmbUserAdministrationRole";
            this.cmbUserAdministrationRole.Size = new System.Drawing.Size(275, 25);
            this.cmbUserAdministrationRole.TabIndex = 30;
            this.cmbUserAdministrationRole.TabStop = false;
            // 
            // txtUserAdministrationUsername
            // 
            this.txtUserAdministrationUsername.BackColor = System.Drawing.SystemColors.Window;
            this.txtUserAdministrationUsername.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(202)))), ((int)(((byte)(230)))));
            this.txtUserAdministrationUsername.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtUserAdministrationUsername.BorderRadius = 18;
            this.txtUserAdministrationUsername.BorderSize = 2;
            this.txtUserAdministrationUsername.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserAdministrationUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(202)))), ((int)(((byte)(230)))));
            this.txtUserAdministrationUsername.Location = new System.Drawing.Point(23, 37);
            this.txtUserAdministrationUsername.Margin = new System.Windows.Forms.Padding(20, 20, 0, 20);
            this.txtUserAdministrationUsername.MaxLength = 50;
            this.txtUserAdministrationUsername.Multiline = false;
            this.txtUserAdministrationUsername.Name = "txtUserAdministrationUsername";
            this.txtUserAdministrationUsername.Padding = new System.Windows.Forms.Padding(15, 10, 15, 10);
            this.txtUserAdministrationUsername.PasswordChar = false;
            this.txtUserAdministrationUsername.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtUserAdministrationUsername.PlaceholderText = "";
            this.txtUserAdministrationUsername.SelectionLength = 0;
            this.txtUserAdministrationUsername.SelectionStart = 0;
            this.txtUserAdministrationUsername.Size = new System.Drawing.Size(275, 38);
            this.txtUserAdministrationUsername.TabIndex = 5;
            this.txtUserAdministrationUsername.Tag = "username";
            this.txtUserAdministrationUsername.Texts = "Usuario";
            this.txtUserAdministrationUsername.UnderlinedStyle = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 23.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(202)))), ((int)(((byte)(230)))));
            this.label1.Location = new System.Drawing.Point(24, 24);
            this.label1.Margin = new System.Windows.Forms.Padding(15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(235, 37);
            this.label1.TabIndex = 16;
            this.label1.Text = "Añadir Usuario";
            // 
            // btnExit
            // 
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Image = global::HealthPortal.Properties.Resources.quit;
            this.btnExit.Location = new System.Drawing.Point(622, 12);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(34, 34);
            this.btnExit.TabIndex = 10;
            this.btnExit.TabStop = false;
            this.btnExit.UseVisualStyleBackColor = false;
            // 
            // btnAddNewUser
            // 
            this.btnAddNewUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(202)))), ((int)(((byte)(230)))));
            this.btnAddNewUser.BackGroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(202)))), ((int)(((byte)(230)))));
            this.btnAddNewUser.BorderColor = System.Drawing.Color.CornflowerBlue;
            this.btnAddNewUser.BorderRadius = 30;
            this.btnAddNewUser.BorderSize = 0;
            this.btnAddNewUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddNewUser.FlatAppearance.BorderSize = 0;
            this.btnAddNewUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddNewUser.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNewUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(91)))));
            this.btnAddNewUser.Location = new System.Drawing.Point(343, 331);
            this.btnAddNewUser.Margin = new System.Windows.Forms.Padding(176, 10, 176, 15);
            this.btnAddNewUser.Name = "btnAddNewUser";
            this.btnAddNewUser.Size = new System.Drawing.Size(298, 39);
            this.btnAddNewUser.TabIndex = 9;
            this.btnAddNewUser.TabStop = false;
            this.btnAddNewUser.Tag = "";
            this.btnAddNewUser.Text = "Agregar Usuario";
            this.btnAddNewUser.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(91)))));
            this.btnAddNewUser.UseVisualStyleBackColor = false;
            // 
            // txtUserAdministrationPhoneNumber
            // 
            this.txtUserAdministrationPhoneNumber.BackColor = System.Drawing.SystemColors.Window;
            this.txtUserAdministrationPhoneNumber.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(202)))), ((int)(((byte)(230)))));
            this.txtUserAdministrationPhoneNumber.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtUserAdministrationPhoneNumber.BorderRadius = 18;
            this.txtUserAdministrationPhoneNumber.BorderSize = 2;
            this.txtUserAdministrationPhoneNumber.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserAdministrationPhoneNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(202)))), ((int)(((byte)(230)))));
            this.txtUserAdministrationPhoneNumber.Location = new System.Drawing.Point(343, 150);
            this.txtUserAdministrationPhoneNumber.Margin = new System.Windows.Forms.Padding(20, 20, 20, 0);
            this.txtUserAdministrationPhoneNumber.MaxLength = 9;
            this.txtUserAdministrationPhoneNumber.Multiline = false;
            this.txtUserAdministrationPhoneNumber.Name = "txtUserAdministrationPhoneNumber";
            this.txtUserAdministrationPhoneNumber.Padding = new System.Windows.Forms.Padding(20, 10, 20, 10);
            this.txtUserAdministrationPhoneNumber.PasswordChar = false;
            this.txtUserAdministrationPhoneNumber.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtUserAdministrationPhoneNumber.PlaceholderText = "";
            this.txtUserAdministrationPhoneNumber.SelectionLength = 0;
            this.txtUserAdministrationPhoneNumber.SelectionStart = 0;
            this.txtUserAdministrationPhoneNumber.Size = new System.Drawing.Size(286, 38);
            this.txtUserAdministrationPhoneNumber.TabIndex = 4;
            this.txtUserAdministrationPhoneNumber.Tag = "phoneNumber";
            this.txtUserAdministrationPhoneNumber.Texts = "Número de Teléfono";
            this.txtUserAdministrationPhoneNumber.UnderlinedStyle = false;
            // 
            // txtUserAdministrationEmail
            // 
            this.txtUserAdministrationEmail.BackColor = System.Drawing.SystemColors.Window;
            this.txtUserAdministrationEmail.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(202)))), ((int)(((byte)(230)))));
            this.txtUserAdministrationEmail.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtUserAdministrationEmail.BorderRadius = 18;
            this.txtUserAdministrationEmail.BorderSize = 2;
            this.txtUserAdministrationEmail.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserAdministrationEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(202)))), ((int)(((byte)(230)))));
            this.txtUserAdministrationEmail.Location = new System.Drawing.Point(29, 150);
            this.txtUserAdministrationEmail.Margin = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.txtUserAdministrationEmail.MaxLength = 100;
            this.txtUserAdministrationEmail.Multiline = false;
            this.txtUserAdministrationEmail.Name = "txtUserAdministrationEmail";
            this.txtUserAdministrationEmail.Padding = new System.Windows.Forms.Padding(20, 10, 20, 10);
            this.txtUserAdministrationEmail.PasswordChar = false;
            this.txtUserAdministrationEmail.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtUserAdministrationEmail.PlaceholderText = "";
            this.txtUserAdministrationEmail.SelectionLength = 0;
            this.txtUserAdministrationEmail.SelectionStart = 0;
            this.txtUserAdministrationEmail.Size = new System.Drawing.Size(290, 38);
            this.txtUserAdministrationEmail.TabIndex = 3;
            this.txtUserAdministrationEmail.Tag = "email";
            this.txtUserAdministrationEmail.Texts = "Correo Electrónico";
            this.txtUserAdministrationEmail.UnderlinedStyle = false;
            // 
            // txtUserAdministrationLastName
            // 
            this.txtUserAdministrationLastName.BackColor = System.Drawing.SystemColors.Window;
            this.txtUserAdministrationLastName.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(202)))), ((int)(((byte)(230)))));
            this.txtUserAdministrationLastName.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtUserAdministrationLastName.BorderRadius = 18;
            this.txtUserAdministrationLastName.BorderSize = 2;
            this.txtUserAdministrationLastName.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserAdministrationLastName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(202)))), ((int)(((byte)(230)))));
            this.txtUserAdministrationLastName.Location = new System.Drawing.Point(343, 92);
            this.txtUserAdministrationLastName.Margin = new System.Windows.Forms.Padding(20);
            this.txtUserAdministrationLastName.MaxLength = 60;
            this.txtUserAdministrationLastName.Multiline = false;
            this.txtUserAdministrationLastName.Name = "txtUserAdministrationLastName";
            this.txtUserAdministrationLastName.Padding = new System.Windows.Forms.Padding(20, 10, 20, 10);
            this.txtUserAdministrationLastName.PasswordChar = false;
            this.txtUserAdministrationLastName.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtUserAdministrationLastName.PlaceholderText = "";
            this.txtUserAdministrationLastName.SelectionLength = 0;
            this.txtUserAdministrationLastName.SelectionStart = 0;
            this.txtUserAdministrationLastName.Size = new System.Drawing.Size(286, 38);
            this.txtUserAdministrationLastName.TabIndex = 2;
            this.txtUserAdministrationLastName.Tag = "name";
            this.txtUserAdministrationLastName.Texts = "Apellidos";
            this.txtUserAdministrationLastName.UnderlinedStyle = false;
            // 
            // txtUserAdministrationName
            // 
            this.txtUserAdministrationName.BackColor = System.Drawing.SystemColors.Window;
            this.txtUserAdministrationName.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(202)))), ((int)(((byte)(230)))));
            this.txtUserAdministrationName.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtUserAdministrationName.BorderRadius = 18;
            this.txtUserAdministrationName.BorderSize = 2;
            this.txtUserAdministrationName.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserAdministrationName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(202)))), ((int)(((byte)(230)))));
            this.txtUserAdministrationName.Location = new System.Drawing.Point(29, 92);
            this.txtUserAdministrationName.Margin = new System.Windows.Forms.Padding(20, 20, 0, 20);
            this.txtUserAdministrationName.MaxLength = 60;
            this.txtUserAdministrationName.Multiline = false;
            this.txtUserAdministrationName.Name = "txtUserAdministrationName";
            this.txtUserAdministrationName.Padding = new System.Windows.Forms.Padding(20, 10, 20, 10);
            this.txtUserAdministrationName.PasswordChar = false;
            this.txtUserAdministrationName.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtUserAdministrationName.PlaceholderText = "";
            this.txtUserAdministrationName.SelectionLength = 0;
            this.txtUserAdministrationName.SelectionStart = 0;
            this.txtUserAdministrationName.Size = new System.Drawing.Size(290, 38);
            this.txtUserAdministrationName.TabIndex = 1;
            this.txtUserAdministrationName.Tag = "name";
            this.txtUserAdministrationName.Texts = "Nombres";
            this.txtUserAdministrationName.UnderlinedStyle = false;
            // 
            // btnUpdateUser
            // 
            this.btnUpdateUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(202)))), ((int)(((byte)(230)))));
            this.btnUpdateUser.BackGroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(202)))), ((int)(((byte)(230)))));
            this.btnUpdateUser.BorderColor = System.Drawing.Color.CornflowerBlue;
            this.btnUpdateUser.BorderRadius = 30;
            this.btnUpdateUser.BorderSize = 0;
            this.btnUpdateUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdateUser.FlatAppearance.BorderSize = 0;
            this.btnUpdateUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateUser.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(91)))));
            this.btnUpdateUser.Location = new System.Drawing.Point(21, 331);
            this.btnUpdateUser.Margin = new System.Windows.Forms.Padding(176, 10, 176, 15);
            this.btnUpdateUser.Name = "btnUpdateUser";
            this.btnUpdateUser.Size = new System.Drawing.Size(298, 39);
            this.btnUpdateUser.TabIndex = 17;
            this.btnUpdateUser.TabStop = false;
            this.btnUpdateUser.Tag = "";
            this.btnUpdateUser.Text = "Actualizar Usuario";
            this.btnUpdateUser.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(91)))));
            this.btnUpdateUser.UseVisualStyleBackColor = false;
            // 
            // txtUserAdministrationId
            // 
            this.txtUserAdministrationId.BackColor = System.Drawing.Color.White;
            this.txtUserAdministrationId.BorderColor = System.Drawing.Color.White;
            this.txtUserAdministrationId.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtUserAdministrationId.BorderRadius = 18;
            this.txtUserAdministrationId.BorderSize = 2;
            this.txtUserAdministrationId.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserAdministrationId.ForeColor = System.Drawing.Color.White;
            this.txtUserAdministrationId.Location = new System.Drawing.Point(294, 14);
            this.txtUserAdministrationId.Margin = new System.Windows.Forms.Padding(20, 20, 0, 20);
            this.txtUserAdministrationId.MaxLength = 50;
            this.txtUserAdministrationId.Multiline = false;
            this.txtUserAdministrationId.Name = "txtUserAdministrationId";
            this.txtUserAdministrationId.Padding = new System.Windows.Forms.Padding(15, 10, 10, 10);
            this.txtUserAdministrationId.PasswordChar = false;
            this.txtUserAdministrationId.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtUserAdministrationId.PlaceholderText = "";
            this.txtUserAdministrationId.SelectionLength = 0;
            this.txtUserAdministrationId.SelectionStart = 0;
            this.txtUserAdministrationId.Size = new System.Drawing.Size(78, 38);
            this.txtUserAdministrationId.TabIndex = 18;
            this.txtUserAdministrationId.Tag = "username";
            this.txtUserAdministrationId.Texts = "Usuario";
            this.txtUserAdministrationId.UnderlinedStyle = false;
            this.txtUserAdministrationId.Visible = false;
            // 
            // FrmAddUpdateUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(668, 394);
            this.Controls.Add(this.txtUserAdministrationId);
            this.Controls.Add(this.btnUpdateUser);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnAddNewUser);
            this.Controls.Add(this.grpLoginInfo);
            this.Controls.Add(this.txtUserAdministrationPhoneNumber);
            this.Controls.Add(this.txtUserAdministrationEmail);
            this.Controls.Add(this.txtUserAdministrationLastName);
            this.Controls.Add(this.txtUserAdministrationName);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmAddUpdateUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Añadir / Actualizar usuario";
            this.grpLoginInfo.ResumeLayout(false);
            this.grpLoginInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public CustomControls.RJButton btnAddNewUser;
        private System.Windows.Forms.GroupBox grpLoginInfo;
        public CustomControls.CustomTextBox txtUserAdministrationUsername;
        public CustomControls.CustomTextBox txtUserAdministrationPhoneNumber;
        public CustomControls.CustomTextBox txtUserAdministrationEmail;
        public CustomControls.CustomTextBox txtUserAdministrationLastName;
        public CustomControls.CustomTextBox txtUserAdministrationName;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Button btnExit;
        public CustomControls.RJButton btnUpdateUser;
        public System.Windows.Forms.ComboBox cmbUserAdministrationRole;
        private System.Windows.Forms.Label lblFilter;
        public CustomControls.CustomTextBox txtUserAdministrationId;
    }
}