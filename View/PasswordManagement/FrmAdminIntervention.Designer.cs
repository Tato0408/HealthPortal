using HealthPortal.View.Login;

namespace HealthPortal.View.PasswordManagement
{
    partial class FrmAdminIntervention
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnShowPassword = new System.Windows.Forms.Button();
            this.btnConfirmPasswordChange = new CustomControls.RJButton();
            this.txtPassword = new CustomControls.CustomTextBox();
            this.txtUsername = new CustomControls.CustomTextBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnHidePassword = new System.Windows.Forms.Button();
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
            this.label1.Size = new System.Drawing.Size(206, 37);
            this.label1.TabIndex = 17;
            this.label1.Text = "Intervención";
            // 
            // btnShowPassword
            // 
            this.btnShowPassword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnShowPassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnShowPassword.FlatAppearance.BorderSize = 0;
            this.btnShowPassword.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnShowPassword.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnShowPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowPassword.ForeColor = System.Drawing.Color.White;
            this.btnShowPassword.Image = global::HealthPortal.Properties.Resources.show;
            this.btnShowPassword.Location = new System.Drawing.Point(310, 196);
            this.btnShowPassword.Name = "btnShowPassword";
            this.btnShowPassword.Size = new System.Drawing.Size(25, 25);
            this.btnShowPassword.TabIndex = 34;
            this.btnShowPassword.TabStop = false;
            this.btnShowPassword.UseVisualStyleBackColor = true;
            // 
            // btnConfirmPasswordChange
            // 
            this.btnConfirmPasswordChange.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(202)))), ((int)(((byte)(230)))));
            this.btnConfirmPasswordChange.BackGroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(202)))), ((int)(((byte)(230)))));
            this.btnConfirmPasswordChange.BorderColor = System.Drawing.Color.CornflowerBlue;
            this.btnConfirmPasswordChange.BorderRadius = 30;
            this.btnConfirmPasswordChange.BorderSize = 0;
            this.btnConfirmPasswordChange.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConfirmPasswordChange.FlatAppearance.BorderSize = 0;
            this.btnConfirmPasswordChange.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirmPasswordChange.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmPasswordChange.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(91)))));
            this.btnConfirmPasswordChange.Location = new System.Drawing.Point(81, 260);
            this.btnConfirmPasswordChange.Margin = new System.Windows.Forms.Padding(10);
            this.btnConfirmPasswordChange.Name = "btnConfirmPasswordChange";
            this.btnConfirmPasswordChange.Size = new System.Drawing.Size(295, 39);
            this.btnConfirmPasswordChange.TabIndex = 32;
            this.btnConfirmPasswordChange.TabStop = false;
            this.btnConfirmPasswordChange.Text = "Confirmar cambio de contraseña";
            this.btnConfirmPasswordChange.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(91)))));
            this.btnConfirmPasswordChange.UseVisualStyleBackColor = false;
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.SystemColors.Window;
            this.txtPassword.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(202)))), ((int)(((byte)(230)))));
            this.txtPassword.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtPassword.BorderRadius = 18;
            this.txtPassword.BorderSize = 2;
            this.txtPassword.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(202)))), ((int)(((byte)(230)))));
            this.txtPassword.Location = new System.Drawing.Point(19, 190);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(10);
            this.txtPassword.MaxLength = 256;
            this.txtPassword.Multiline = false;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Padding = new System.Windows.Forms.Padding(20, 10, 10, 10);
            this.txtPassword.PasswordChar = false;
            this.txtPassword.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtPassword.PlaceholderText = "";
            this.txtPassword.SelectionLength = 0;
            this.txtPassword.SelectionStart = 0;
            this.txtPassword.Size = new System.Drawing.Size(326, 38);
            this.txtPassword.TabIndex = 2;
            this.txtPassword.Tag = "password";
            this.txtPassword.Texts = "Contraseña";
            this.txtPassword.UnderlinedStyle = false;
            // 
            // txtUsername
            // 
            this.txtUsername.BackColor = System.Drawing.SystemColors.Window;
            this.txtUsername.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(202)))), ((int)(((byte)(230)))));
            this.txtUsername.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtUsername.BorderRadius = 18;
            this.txtUsername.BorderSize = 2;
            this.txtUsername.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(202)))), ((int)(((byte)(230)))));
            this.txtUsername.Location = new System.Drawing.Point(19, 132);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(10);
            this.txtUsername.MaxLength = 50;
            this.txtUsername.Multiline = false;
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Padding = new System.Windows.Forms.Padding(20, 10, 10, 10);
            this.txtUsername.PasswordChar = false;
            this.txtUsername.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtUsername.PlaceholderText = "";
            this.txtUsername.SelectionLength = 0;
            this.txtUsername.SelectionStart = 0;
            this.txtUsername.Size = new System.Drawing.Size(326, 38);
            this.txtUsername.TabIndex = 1;
            this.txtUsername.Tag = "username";
            this.txtUsername.Texts = "Usuario";
            this.txtUsername.UnderlinedStyle = false;
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
            this.btnExit.Location = new System.Drawing.Point(349, 12);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(34, 34);
            this.btnExit.TabIndex = 37;
            this.btnExit.TabStop = false;
            this.btnExit.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 23.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(202)))), ((int)(((byte)(230)))));
            this.label2.Location = new System.Drawing.Point(19, 66);
            this.label2.Margin = new System.Windows.Forms.Padding(10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(274, 37);
            this.label2.TabIndex = 38;
            this.label2.Text = "de Administrador";
            // 
            // btnHidePassword
            // 
            this.btnHidePassword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnHidePassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHidePassword.FlatAppearance.BorderSize = 0;
            this.btnHidePassword.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnHidePassword.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnHidePassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHidePassword.ForeColor = System.Drawing.Color.White;
            this.btnHidePassword.Image = global::HealthPortal.Properties.Resources.hide;
            this.btnHidePassword.Location = new System.Drawing.Point(310, 196);
            this.btnHidePassword.Name = "btnHidePassword";
            this.btnHidePassword.Size = new System.Drawing.Size(25, 25);
            this.btnHidePassword.TabIndex = 35;
            this.btnHidePassword.TabStop = false;
            this.btnHidePassword.Text = " ";
            this.btnHidePassword.UseVisualStyleBackColor = true;
            // 
            // FrmAdminIntervention
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(395, 318);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnHidePassword);
            this.Controls.Add(this.btnShowPassword);
            this.Controls.Add(this.btnConfirmPasswordChange);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmAdminIntervention";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inicio de sesión";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        public CustomControls.CustomTextBox txtUsername;
        public CustomControls.CustomTextBox txtPassword;
        public CustomControls.RJButton btnConfirmPasswordChange;
        public System.Windows.Forms.Button btnShowPassword;
        public System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.Button btnHidePassword;
    }
}