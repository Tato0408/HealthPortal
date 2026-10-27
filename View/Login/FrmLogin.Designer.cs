using System.Drawing;
using System.Drawing.Text;
using HealthPortal.Helper;

namespace HealthPortal.View.Login
{
    partial class FrmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            this.label1 = new System.Windows.Forms.Label();
            this.rdoRememberMe = new System.Windows.Forms.RadioButton();
            this.llbForgotPassword = new System.Windows.Forms.LinkLabel();
            this.btnShowPassword = new System.Windows.Forms.Button();
            this.btnHidePassword = new System.Windows.Forms.Button();
            this.btnLogin = new CustomControls.RJButton();
            this.txtPassword = new CustomControls.CustomTextBox();
            this.txtUsername = new CustomControls.CustomTextBox();
            this.btnTestConnection = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
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
            this.label1.Size = new System.Drawing.Size(253, 37);
            this.label1.TabIndex = 17;
            this.label1.Text = "Inicio de Sesión";
            // 
            // rdoRememberMe
            // 
            this.rdoRememberMe.AutoSize = true;
            this.rdoRememberMe.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdoRememberMe.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.rdoRememberMe.FlatAppearance.BorderSize = 0;
            this.rdoRememberMe.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoRememberMe.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.rdoRememberMe.Location = new System.Drawing.Point(26, 196);
            this.rdoRememberMe.Name = "rdoRememberMe";
            this.rdoRememberMe.Size = new System.Drawing.Size(241, 20);
            this.rdoRememberMe.TabIndex = 30;
            this.rdoRememberMe.Text = "Recordar información de inicio de sesión";
            this.rdoRememberMe.UseVisualStyleBackColor = true;
            // 
            // llbForgotPassword
            // 
            this.llbForgotPassword.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(91)))));
            this.llbForgotPassword.AutoSize = true;
            this.llbForgotPassword.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llbForgotPassword.LinkColor = System.Drawing.SystemColors.AppWorkspace;
            this.llbForgotPassword.Location = new System.Drawing.Point(23, 219);
            this.llbForgotPassword.Name = "llbForgotPassword";
            this.llbForgotPassword.Size = new System.Drawing.Size(124, 16);
            this.llbForgotPassword.TabIndex = 31;
            this.llbForgotPassword.TabStop = true;
            this.llbForgotPassword.Text = "Olvidé mi contraseña";
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
            this.btnShowPassword.Location = new System.Drawing.Point(310, 152);
            this.btnShowPassword.Name = "btnShowPassword";
            this.btnShowPassword.Size = new System.Drawing.Size(25, 25);
            this.btnShowPassword.TabIndex = 34;
            this.btnShowPassword.TabStop = false;
            this.btnShowPassword.UseVisualStyleBackColor = true;
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
            this.btnHidePassword.Image = ((System.Drawing.Image)(resources.GetObject("btnHidePassword.Image")));
            this.btnHidePassword.Location = new System.Drawing.Point(310, 152);
            this.btnHidePassword.Name = "btnHidePassword";
            this.btnHidePassword.Size = new System.Drawing.Size(25, 25);
            this.btnHidePassword.TabIndex = 35;
            this.btnHidePassword.TabStop = false;
            this.btnHidePassword.Text = " ";
            this.btnHidePassword.UseVisualStyleBackColor = true;
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(202)))), ((int)(((byte)(230)))));
            this.btnLogin.BackGroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(202)))), ((int)(((byte)(230)))));
            this.btnLogin.BorderColor = System.Drawing.Color.CornflowerBlue;
            this.btnLogin.BorderRadius = 30;
            this.btnLogin.BorderSize = 0;
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(91)))));
            this.btnLogin.Location = new System.Drawing.Point(235, 251);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(10);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(141, 39);
            this.btnLogin.TabIndex = 32;
            this.btnLogin.TabStop = false;
            this.btnLogin.Text = "Iniciar Sesión";
            this.btnLogin.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(91)))));
            this.btnLogin.UseVisualStyleBackColor = false;
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
            this.txtPassword.Location = new System.Drawing.Point(19, 145);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(10);
            this.txtPassword.MaxLength = 256;
            this.txtPassword.Multiline = false;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Padding = new System.Windows.Forms.Padding(20, 10, 10, 10);
            this.txtPassword.PasswordChar = false;
            this.txtPassword.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtPassword.PlaceholderText = "";
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
            this.txtUsername.Location = new System.Drawing.Point(19, 87);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(10);
            this.txtUsername.MaxLength = 50;
            this.txtUsername.Multiline = false;
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Padding = new System.Windows.Forms.Padding(20, 10, 10, 10);
            this.txtUsername.PasswordChar = false;
            this.txtUsername.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtUsername.PlaceholderText = "";
            this.txtUsername.Size = new System.Drawing.Size(326, 38);
            this.txtUsername.TabIndex = 1;
            this.txtUsername.Tag = "username";
            this.txtUsername.Texts = "Usuario";
            this.txtUsername.UnderlinedStyle = false;
            // 
            // btnTestConnection
            // 
            this.btnTestConnection.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnTestConnection.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTestConnection.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnTestConnection.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnTestConnection.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnTestConnection.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTestConnection.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTestConnection.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(202)))), ((int)(((byte)(230)))));
            this.btnTestConnection.Image = global::HealthPortal.Properties.Resources.wifi;
            this.btnTestConnection.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTestConnection.Location = new System.Drawing.Point(12, 264);
            this.btnTestConnection.Name = "btnTestConnection";
            this.btnTestConnection.Size = new System.Drawing.Size(145, 33);
            this.btnTestConnection.TabIndex = 36;
            this.btnTestConnection.TabStop = false;
            this.btnTestConnection.Text = "Probar Conexión";
            this.btnTestConnection.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTestConnection.UseVisualStyleBackColor = true;
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
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(395, 309);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnTestConnection);
            this.Controls.Add(this.btnHidePassword);
            this.Controls.Add(this.btnShowPassword);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.llbForgotPassword);
            this.Controls.Add(this.rdoRememberMe);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inicio de sesión";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        public CustomControls.CustomTextBox txtUsername;
        public CustomControls.CustomTextBox txtPassword;
        public CustomControls.RJButton btnLogin;
        public System.Windows.Forms.Button btnShowPassword;
        public System.Windows.Forms.Button btnHidePassword;
        public System.Windows.Forms.RadioButton rdoRememberMe;
        public System.Windows.Forms.LinkLabel llbForgotPassword;
        public System.Windows.Forms.Button btnTestConnection;
        public System.Windows.Forms.Button btnExit;
    }
}