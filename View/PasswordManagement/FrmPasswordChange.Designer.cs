namespace HealthPortal.View.PasswordManagement
{
    partial class FrmPasswordChange
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPasswordChange));
            this.label1 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.grpPreviousPassword = new System.Windows.Forms.GroupBox();
            this.txtPreviousPassword = new CustomControls.CustomTextBox();
            this.grpNewPassword = new System.Windows.Forms.GroupBox();
            this.txtNewPasswordConfirmation = new CustomControls.CustomTextBox();
            this.txtNewPassword = new CustomControls.CustomTextBox();
            this.btnChangePassword = new CustomControls.RJButton();
            this.grpPreviousPassword.SuspendLayout();
            this.grpNewPassword.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 23.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(202)))), ((int)(((byte)(230)))));
            this.label1.Location = new System.Drawing.Point(19, 19);
            this.label1.Margin = new System.Windows.Forms.Padding(10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(366, 37);
            this.label1.TabIndex = 41;
            this.label1.Text = "Cambio de contraseña";
            // 
            // btnExit
            // 
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.Location = new System.Drawing.Point(413, 12);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(32, 32);
            this.btnExit.TabIndex = 42;
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // grpPreviousPassword
            // 
            this.grpPreviousPassword.Controls.Add(this.txtPreviousPassword);
            this.grpPreviousPassword.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpPreviousPassword.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.grpPreviousPassword.Location = new System.Drawing.Point(26, 69);
            this.grpPreviousPassword.Margin = new System.Windows.Forms.Padding(3, 3, 20, 3);
            this.grpPreviousPassword.Name = "grpPreviousPassword";
            this.grpPreviousPassword.Size = new System.Drawing.Size(402, 100);
            this.grpPreviousPassword.TabIndex = 43;
            this.grpPreviousPassword.TabStop = false;
            this.grpPreviousPassword.Text = "Contraseña previa";
            // 
            // txtPreviousPassword
            // 
            this.txtPreviousPassword.BackColor = System.Drawing.SystemColors.Window;
            this.txtPreviousPassword.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(202)))), ((int)(((byte)(230)))));
            this.txtPreviousPassword.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtPreviousPassword.BorderRadius = 18;
            this.txtPreviousPassword.BorderSize = 2;
            this.txtPreviousPassword.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPreviousPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(202)))), ((int)(((byte)(230)))));
            this.txtPreviousPassword.Location = new System.Drawing.Point(14, 36);
            this.txtPreviousPassword.Margin = new System.Windows.Forms.Padding(11, 17, 11, 11);
            this.txtPreviousPassword.MaxLength = 256;
            this.txtPreviousPassword.Multiline = false;
            this.txtPreviousPassword.Name = "txtPreviousPassword";
            this.txtPreviousPassword.Padding = new System.Windows.Forms.Padding(20, 10, 10, 10);
            this.txtPreviousPassword.PasswordChar = false;
            this.txtPreviousPassword.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtPreviousPassword.PlaceholderText = "";
            this.txtPreviousPassword.SelectionLength = 0;
            this.txtPreviousPassword.SelectionStart = 0;
            this.txtPreviousPassword.Size = new System.Drawing.Size(374, 38);
            this.txtPreviousPassword.TabIndex = 1;
            this.txtPreviousPassword.Tag = "confirmationCode";
            this.txtPreviousPassword.Texts = "Ingrese su contraseña previa";
            this.txtPreviousPassword.UnderlinedStyle = false;
            // 
            // grpNewPassword
            // 
            this.grpNewPassword.Controls.Add(this.txtNewPasswordConfirmation);
            this.grpNewPassword.Controls.Add(this.txtNewPassword);
            this.grpNewPassword.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpNewPassword.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.grpNewPassword.Location = new System.Drawing.Point(26, 184);
            this.grpNewPassword.Margin = new System.Windows.Forms.Padding(3, 3, 15, 3);
            this.grpNewPassword.Name = "grpNewPassword";
            this.grpNewPassword.Size = new System.Drawing.Size(402, 162);
            this.grpNewPassword.TabIndex = 44;
            this.grpNewPassword.TabStop = false;
            this.grpNewPassword.Text = "Contraseña nueva";
            // 
            // txtNewPasswordConfirmation
            // 
            this.txtNewPasswordConfirmation.BackColor = System.Drawing.SystemColors.Window;
            this.txtNewPasswordConfirmation.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(202)))), ((int)(((byte)(230)))));
            this.txtNewPasswordConfirmation.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtNewPasswordConfirmation.BorderRadius = 18;
            this.txtNewPasswordConfirmation.BorderSize = 2;
            this.txtNewPasswordConfirmation.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNewPasswordConfirmation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(202)))), ((int)(((byte)(230)))));
            this.txtNewPasswordConfirmation.Location = new System.Drawing.Point(14, 96);
            this.txtNewPasswordConfirmation.Margin = new System.Windows.Forms.Padding(11);
            this.txtNewPasswordConfirmation.MaxLength = 256;
            this.txtNewPasswordConfirmation.Multiline = false;
            this.txtNewPasswordConfirmation.Name = "txtNewPasswordConfirmation";
            this.txtNewPasswordConfirmation.Padding = new System.Windows.Forms.Padding(20, 10, 10, 10);
            this.txtNewPasswordConfirmation.PasswordChar = false;
            this.txtNewPasswordConfirmation.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtNewPasswordConfirmation.PlaceholderText = "";
            this.txtNewPasswordConfirmation.SelectionLength = 0;
            this.txtNewPasswordConfirmation.SelectionStart = 0;
            this.txtNewPasswordConfirmation.Size = new System.Drawing.Size(374, 38);
            this.txtNewPasswordConfirmation.TabIndex = 3;
            this.txtNewPasswordConfirmation.Tag = "password";
            this.txtNewPasswordConfirmation.Texts = "Confirme su contraseña nueva";
            this.txtNewPasswordConfirmation.UnderlinedStyle = false;
            // 
            // txtNewPassword
            // 
            this.txtNewPassword.BackColor = System.Drawing.SystemColors.Window;
            this.txtNewPassword.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(202)))), ((int)(((byte)(230)))));
            this.txtNewPassword.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtNewPassword.BorderRadius = 18;
            this.txtNewPassword.BorderSize = 2;
            this.txtNewPassword.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNewPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(202)))), ((int)(((byte)(230)))));
            this.txtNewPassword.Location = new System.Drawing.Point(14, 36);
            this.txtNewPassword.Margin = new System.Windows.Forms.Padding(11, 17, 11, 11);
            this.txtNewPassword.MaxLength = 256;
            this.txtNewPassword.Multiline = false;
            this.txtNewPassword.Name = "txtNewPassword";
            this.txtNewPassword.Padding = new System.Windows.Forms.Padding(20, 10, 10, 10);
            this.txtNewPassword.PasswordChar = false;
            this.txtNewPassword.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtNewPassword.PlaceholderText = "";
            this.txtNewPassword.SelectionLength = 0;
            this.txtNewPassword.SelectionStart = 0;
            this.txtNewPassword.Size = new System.Drawing.Size(374, 38);
            this.txtNewPassword.TabIndex = 2;
            this.txtNewPassword.Tag = "password";
            this.txtNewPassword.Texts = "Ingrese su contraseña nueva";
            this.txtNewPassword.UnderlinedStyle = false;
            // 
            // btnChangePassword
            // 
            this.btnChangePassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(202)))), ((int)(((byte)(230)))));
            this.btnChangePassword.BackGroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(202)))), ((int)(((byte)(230)))));
            this.btnChangePassword.BorderColor = System.Drawing.Color.CornflowerBlue;
            this.btnChangePassword.BorderRadius = 30;
            this.btnChangePassword.BorderSize = 0;
            this.btnChangePassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnChangePassword.FlatAppearance.BorderSize = 0;
            this.btnChangePassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChangePassword.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangePassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(91)))));
            this.btnChangePassword.Location = new System.Drawing.Point(110, 364);
            this.btnChangePassword.Margin = new System.Windows.Forms.Padding(20);
            this.btnChangePassword.Name = "btnChangePassword";
            this.btnChangePassword.Size = new System.Drawing.Size(318, 40);
            this.btnChangePassword.TabIndex = 4;
            this.btnChangePassword.Text = "Confirmar cambio de contraseña";
            this.btnChangePassword.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(91)))));
            this.btnChangePassword.UseVisualStyleBackColor = false;
            // 
            // FrmPasswordChange
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(457, 433);
            this.Controls.Add(this.btnChangePassword);
            this.Controls.Add(this.grpNewPassword);
            this.Controls.Add(this.grpPreviousPassword);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmPasswordChange";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmPasswordChange";
            this.grpPreviousPassword.ResumeLayout(false);
            this.grpNewPassword.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.GroupBox grpPreviousPassword;
        public CustomControls.CustomTextBox txtPreviousPassword;
        private System.Windows.Forms.GroupBox grpNewPassword;
        public CustomControls.CustomTextBox txtNewPassword;
        public CustomControls.CustomTextBox txtNewPasswordConfirmation;
        public CustomControls.RJButton btnChangePassword;
    }
}