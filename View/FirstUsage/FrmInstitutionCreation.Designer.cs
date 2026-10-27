namespace HealthPortal.View.FirstUsage
{
    partial class FrmInstitutionCreation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmInstitutionCreation));
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.grpLogo = new System.Windows.Forms.GroupBox();
            this.btnAddLogo = new CustomControls.RJButton();
            this.grpInstitutionInfo = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbInstitutionType = new System.Windows.Forms.ComboBox();
            this.txtEmail = new CustomControls.CustomTextBox();
            this.txtPhoneNumber = new CustomControls.CustomTextBox();
            this.txtInstitutionName = new CustomControls.CustomTextBox();
            this.txtInstitutionAddress = new CustomControls.CustomTextBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnRegisterInstitution = new CustomControls.RJButton();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.grpLogo.SuspendLayout();
            this.grpInstitutionInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(202)))), ((int)(((byte)(230)))));
            this.label2.Location = new System.Drawing.Point(18, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(625, 16);
            this.label2.TabIndex = 17;
            this.label2.Text = "¡Bienvendi@ a HealthPortal! Comenzaremos creando una institución que estará asoci" +
    "ada con el programa";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 23.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(202)))), ((int)(((byte)(230)))));
            this.label1.Location = new System.Drawing.Point(19, 19);
            this.label1.Margin = new System.Windows.Forms.Padding(10, 10, 10, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(367, 37);
            this.label1.TabIndex = 16;
            this.label1.Text = "Creación de Institución";
            // 
            // picLogo
            // 
            this.picLogo.BackColor = System.Drawing.Color.White;
            this.picLogo.Location = new System.Drawing.Point(20, 27);
            this.picLogo.Margin = new System.Windows.Forms.Padding(17);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(258, 258);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLogo.TabIndex = 28;
            this.picLogo.TabStop = false;
            // 
            // grpLogo
            // 
            this.grpLogo.Controls.Add(this.picLogo);
            this.grpLogo.Controls.Add(this.btnAddLogo);
            this.grpLogo.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpLogo.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.grpLogo.Location = new System.Drawing.Point(341, 92);
            this.grpLogo.Name = "grpLogo";
            this.grpLogo.Size = new System.Drawing.Size(298, 330);
            this.grpLogo.TabIndex = 30;
            this.grpLogo.TabStop = false;
            this.grpLogo.Text = "Logotipo de la Institución";
            // 
            // btnAddLogo
            // 
            this.btnAddLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(202)))), ((int)(((byte)(230)))));
            this.btnAddLogo.BackGroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(202)))), ((int)(((byte)(230)))));
            this.btnAddLogo.BorderColor = System.Drawing.Color.CornflowerBlue;
            this.btnAddLogo.BorderRadius = 20;
            this.btnAddLogo.BorderSize = 0;
            this.btnAddLogo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddLogo.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(91)))));
            this.btnAddLogo.FlatAppearance.BorderSize = 0;
            this.btnAddLogo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddLogo.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddLogo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(91)))));
            this.btnAddLogo.Location = new System.Drawing.Point(20, 294);
            this.btnAddLogo.Margin = new System.Windows.Forms.Padding(7);
            this.btnAddLogo.Name = "btnAddLogo";
            this.btnAddLogo.Size = new System.Drawing.Size(258, 26);
            this.btnAddLogo.TabIndex = 6;
            this.btnAddLogo.Text = "Añadir Logo de la Institución";
            this.btnAddLogo.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(91)))));
            this.btnAddLogo.UseVisualStyleBackColor = false;
            // 
            // grpInstitutionInfo
            // 
            this.grpInstitutionInfo.Controls.Add(this.label3);
            this.grpInstitutionInfo.Controls.Add(this.cmbInstitutionType);
            this.grpInstitutionInfo.Controls.Add(this.txtEmail);
            this.grpInstitutionInfo.Controls.Add(this.txtPhoneNumber);
            this.grpInstitutionInfo.Controls.Add(this.txtInstitutionName);
            this.grpInstitutionInfo.Controls.Add(this.txtInstitutionAddress);
            this.grpInstitutionInfo.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpInstitutionInfo.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.grpInstitutionInfo.Location = new System.Drawing.Point(21, 92);
            this.grpInstitutionInfo.Name = "grpInstitutionInfo";
            this.grpInstitutionInfo.Size = new System.Drawing.Size(298, 330);
            this.grpInstitutionInfo.TabIndex = 31;
            this.grpInstitutionInfo.TabStop = false;
            this.grpInstitutionInfo.Text = "Información de la Institución";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(202)))), ((int)(((byte)(230)))));
            this.label3.Location = new System.Drawing.Point(26, 259);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 17);
            this.label3.TabIndex = 18;
            this.label3.Text = "Tipo de Institución";
            // 
            // cmbInstitutionType
            // 
            this.cmbInstitutionType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbInstitutionType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(91)))));
            this.cmbInstitutionType.FormattingEnabled = true;
            this.cmbInstitutionType.ItemHeight = 17;
            this.cmbInstitutionType.Location = new System.Drawing.Point(20, 282);
            this.cmbInstitutionType.Margin = new System.Windows.Forms.Padding(11);
            this.cmbInstitutionType.Name = "cmbInstitutionType";
            this.cmbInstitutionType.Size = new System.Drawing.Size(258, 25);
            this.cmbInstitutionType.TabIndex = 5;
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.SystemColors.Window;
            this.txtEmail.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(202)))), ((int)(((byte)(230)))));
            this.txtEmail.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtEmail.BorderRadius = 18;
            this.txtEmail.BorderSize = 2;
            this.txtEmail.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(202)))), ((int)(((byte)(230)))));
            this.txtEmail.Location = new System.Drawing.Point(20, 210);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(11);
            this.txtEmail.MaxLength = 100;
            this.txtEmail.Multiline = false;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Padding = new System.Windows.Forms.Padding(20, 10, 10, 10);
            this.txtEmail.PasswordChar = false;
            this.txtEmail.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtEmail.PlaceholderText = "";
            this.txtEmail.SelectionLength = 0;
            this.txtEmail.SelectionStart = 0;
            this.txtEmail.Size = new System.Drawing.Size(258, 38);
            this.txtEmail.TabIndex = 4;
            this.txtEmail.Tag = "email";
            this.txtEmail.Texts = "Correo de la Institución";
            this.txtEmail.UnderlinedStyle = false;
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.BackColor = System.Drawing.SystemColors.Window;
            this.txtPhoneNumber.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(202)))), ((int)(((byte)(230)))));
            this.txtPhoneNumber.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtPhoneNumber.BorderRadius = 18;
            this.txtPhoneNumber.BorderSize = 2;
            this.txtPhoneNumber.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhoneNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(202)))), ((int)(((byte)(230)))));
            this.txtPhoneNumber.Location = new System.Drawing.Point(20, 150);
            this.txtPhoneNumber.Margin = new System.Windows.Forms.Padding(11);
            this.txtPhoneNumber.MaxLength = 9;
            this.txtPhoneNumber.Multiline = false;
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Padding = new System.Windows.Forms.Padding(20, 10, 10, 10);
            this.txtPhoneNumber.PasswordChar = false;
            this.txtPhoneNumber.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtPhoneNumber.PlaceholderText = "";
            this.txtPhoneNumber.SelectionLength = 0;
            this.txtPhoneNumber.SelectionStart = 0;
            this.txtPhoneNumber.Size = new System.Drawing.Size(258, 38);
            this.txtPhoneNumber.TabIndex = 3;
            this.txtPhoneNumber.Tag = "phoneNumber";
            this.txtPhoneNumber.Texts = "Teléfono de la Institución";
            this.txtPhoneNumber.UnderlinedStyle = false;
            // 
            // txtInstitutionName
            // 
            this.txtInstitutionName.BackColor = System.Drawing.SystemColors.Window;
            this.txtInstitutionName.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(202)))), ((int)(((byte)(230)))));
            this.txtInstitutionName.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtInstitutionName.BorderRadius = 18;
            this.txtInstitutionName.BorderSize = 2;
            this.txtInstitutionName.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInstitutionName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(202)))), ((int)(((byte)(230)))));
            this.txtInstitutionName.Location = new System.Drawing.Point(20, 30);
            this.txtInstitutionName.Margin = new System.Windows.Forms.Padding(11);
            this.txtInstitutionName.MaxLength = 50;
            this.txtInstitutionName.Multiline = false;
            this.txtInstitutionName.Name = "txtInstitutionName";
            this.txtInstitutionName.Padding = new System.Windows.Forms.Padding(20, 10, 10, 10);
            this.txtInstitutionName.PasswordChar = false;
            this.txtInstitutionName.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtInstitutionName.PlaceholderText = "";
            this.txtInstitutionName.SelectionLength = 0;
            this.txtInstitutionName.SelectionStart = 0;
            this.txtInstitutionName.Size = new System.Drawing.Size(258, 38);
            this.txtInstitutionName.TabIndex = 1;
            this.txtInstitutionName.Tag = "name";
            this.txtInstitutionName.Texts = "Nombre de la Institución";
            this.txtInstitutionName.UnderlinedStyle = false;
            // 
            // txtInstitutionAddress
            // 
            this.txtInstitutionAddress.BackColor = System.Drawing.SystemColors.Window;
            this.txtInstitutionAddress.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(202)))), ((int)(((byte)(230)))));
            this.txtInstitutionAddress.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtInstitutionAddress.BorderRadius = 18;
            this.txtInstitutionAddress.BorderSize = 2;
            this.txtInstitutionAddress.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInstitutionAddress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(202)))), ((int)(((byte)(230)))));
            this.txtInstitutionAddress.Location = new System.Drawing.Point(20, 90);
            this.txtInstitutionAddress.Margin = new System.Windows.Forms.Padding(11);
            this.txtInstitutionAddress.MaxLength = 250;
            this.txtInstitutionAddress.Multiline = false;
            this.txtInstitutionAddress.Name = "txtInstitutionAddress";
            this.txtInstitutionAddress.Padding = new System.Windows.Forms.Padding(20, 10, 10, 10);
            this.txtInstitutionAddress.PasswordChar = false;
            this.txtInstitutionAddress.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtInstitutionAddress.PlaceholderText = "";
            this.txtInstitutionAddress.SelectionLength = 0;
            this.txtInstitutionAddress.SelectionStart = 0;
            this.txtInstitutionAddress.Size = new System.Drawing.Size(258, 38);
            this.txtInstitutionAddress.TabIndex = 2;
            this.txtInstitutionAddress.Tag = "address";
            this.txtInstitutionAddress.Texts = "Dirección de la Institución";
            this.txtInstitutionAddress.UnderlinedStyle = false;
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
            this.btnExit.TabIndex = 19;
            this.btnExit.TabStop = false;
            this.btnExit.UseVisualStyleBackColor = false;
            // 
            // btnRegisterInstitution
            // 
            this.btnRegisterInstitution.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(202)))), ((int)(((byte)(230)))));
            this.btnRegisterInstitution.BackGroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(202)))), ((int)(((byte)(230)))));
            this.btnRegisterInstitution.BorderColor = System.Drawing.Color.CornflowerBlue;
            this.btnRegisterInstitution.BorderRadius = 30;
            this.btnRegisterInstitution.BorderSize = 0;
            this.btnRegisterInstitution.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegisterInstitution.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(91)))));
            this.btnRegisterInstitution.FlatAppearance.BorderSize = 0;
            this.btnRegisterInstitution.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegisterInstitution.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegisterInstitution.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(91)))));
            this.btnRegisterInstitution.Location = new System.Drawing.Point(21, 445);
            this.btnRegisterInstitution.Margin = new System.Windows.Forms.Padding(176, 3, 176, 20);
            this.btnRegisterInstitution.Name = "btnRegisterInstitution";
            this.btnRegisterInstitution.Size = new System.Drawing.Size(620, 40);
            this.btnRegisterInstitution.TabIndex = 7;
            this.btnRegisterInstitution.Text = "Registrar Institución";
            this.btnRegisterInstitution.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(91)))));
            this.btnRegisterInstitution.UseVisualStyleBackColor = false;
            // 
            // FrmInstitutionCreation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(668, 514);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.grpInstitutionInfo);
            this.Controls.Add(this.grpLogo);
            this.Controls.Add(this.btnRegisterInstitution);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmInstitutionCreation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Creación de institución";
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.grpLogo.ResumeLayout(false);
            this.grpInstitutionInfo.ResumeLayout(false);
            this.grpInstitutionInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public CustomControls.RJButton btnRegisterInstitution;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        public CustomControls.CustomTextBox txtInstitutionAddress;
        public CustomControls.RJButton btnAddLogo;
        private System.Windows.Forms.GroupBox grpLogo;
        private System.Windows.Forms.GroupBox grpInstitutionInfo;
        public System.Windows.Forms.PictureBox picLogo;
        public CustomControls.CustomTextBox txtEmail;
        public CustomControls.CustomTextBox txtPhoneNumber;
        public CustomControls.CustomTextBox txtInstitutionName;
        public System.Windows.Forms.ComboBox cmbInstitutionType;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.Button btnExit;
    }
}