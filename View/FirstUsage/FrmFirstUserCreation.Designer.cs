namespace HealthPortal.View.FirstUsage
{
    partial class FrmFirstUserCreation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmFirstUserCreation));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnHidePassword = new System.Windows.Forms.Button();
            this.btnShowPassword = new System.Windows.Forms.Button();
            this.txtConfirmPassword = new CustomControls.CustomTextBox();
            this.txtPassword = new CustomControls.CustomTextBox();
            this.txtUsername = new CustomControls.CustomTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnRegisterFirstUser = new CustomControls.RJButton();
            this.txtPhoneNumber = new CustomControls.CustomTextBox();
            this.txtEmail = new CustomControls.CustomTextBox();
            this.txtLastName = new CustomControls.CustomTextBox();
            this.txtName = new CustomControls.CustomTextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnHidePassword);
            this.groupBox1.Controls.Add(this.btnShowPassword);
            this.groupBox1.Controls.Add(this.txtConfirmPassword);
            this.groupBox1.Controls.Add(this.txtPassword);
            this.groupBox1.Controls.Add(this.txtUsername);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.groupBox1.Location = new System.Drawing.Point(21, 218);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(20, 20, 20, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(620, 98);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Información de Inicio de Sesión";
            // 
            // btnHidePassword
            // 
            this.btnHidePassword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnHidePassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHidePassword.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnHidePassword.FlatAppearance.BorderSize = 0;
            this.btnHidePassword.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnHidePassword.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnHidePassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHidePassword.ForeColor = System.Drawing.Color.White;
            this.btnHidePassword.Image = ((System.Drawing.Image)(resources.GetObject("btnHidePassword.Image")));
            this.btnHidePassword.Location = new System.Drawing.Point(368, 43);
            this.btnHidePassword.Name = "btnHidePassword";
            this.btnHidePassword.Size = new System.Drawing.Size(25, 25);
            this.btnHidePassword.TabIndex = 7;
            this.btnHidePassword.TabStop = false;
            this.btnHidePassword.Text = " ";
            this.btnHidePassword.UseVisualStyleBackColor = true;
            // 
            // btnShowPassword
            // 
            this.btnShowPassword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnShowPassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnShowPassword.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnShowPassword.FlatAppearance.BorderSize = 0;
            this.btnShowPassword.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnShowPassword.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnShowPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowPassword.ForeColor = System.Drawing.Color.White;
            this.btnShowPassword.Image = global::HealthPortal.Properties.Resources.show;
            this.btnShowPassword.Location = new System.Drawing.Point(368, 43);
            this.btnShowPassword.Name = "btnShowPassword";
            this.btnShowPassword.Size = new System.Drawing.Size(25, 25);
            this.btnShowPassword.TabIndex = 7;
            this.btnShowPassword.TabStop = false;
            this.btnShowPassword.UseVisualStyleBackColor = true;
            // 
            // txtConfirmPassword
            // 
            this.txtConfirmPassword.BackColor = System.Drawing.SystemColors.Window;
            this.txtConfirmPassword.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(202)))), ((int)(((byte)(230)))));
            this.txtConfirmPassword.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtConfirmPassword.BorderRadius = 18;
            this.txtConfirmPassword.BorderSize = 2;
            this.txtConfirmPassword.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConfirmPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(202)))), ((int)(((byte)(230)))));
            this.txtConfirmPassword.Location = new System.Drawing.Point(417, 37);
            this.txtConfirmPassword.Margin = new System.Windows.Forms.Padding(20);
            this.txtConfirmPassword.MaxLength = 256;
            this.txtConfirmPassword.Multiline = false;
            this.txtConfirmPassword.Name = "txtConfirmPassword";
            this.txtConfirmPassword.Padding = new System.Windows.Forms.Padding(15, 10, 10, 10);
            this.txtConfirmPassword.PasswordChar = false;
            this.txtConfirmPassword.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtConfirmPassword.PlaceholderText = "";
            this.txtConfirmPassword.Size = new System.Drawing.Size(180, 38);
            this.txtConfirmPassword.TabIndex = 8;
            this.txtConfirmPassword.Tag = "password";
            this.txtConfirmPassword.Texts = "Confirmar contraseña";
            this.txtConfirmPassword.UnderlinedStyle = false;
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
            this.txtPassword.Location = new System.Drawing.Point(223, 37);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(20, 20, 0, 20);
            this.txtPassword.MaxLength = 256;
            this.txtPassword.Multiline = false;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Padding = new System.Windows.Forms.Padding(15, 10, 10, 10);
            this.txtPassword.PasswordChar = false;
            this.txtPassword.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtPassword.PlaceholderText = "";
            this.txtPassword.Size = new System.Drawing.Size(180, 38);
            this.txtPassword.TabIndex = 6;
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
            this.txtUsername.Location = new System.Drawing.Point(23, 37);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(20, 20, 0, 20);
            this.txtUsername.MaxLength = 50;
            this.txtUsername.Multiline = false;
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Padding = new System.Windows.Forms.Padding(15, 10, 10, 10);
            this.txtUsername.PasswordChar = false;
            this.txtUsername.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtUsername.PlaceholderText = "";
            this.txtUsername.Size = new System.Drawing.Size(180, 38);
            this.txtUsername.TabIndex = 5;
            this.txtUsername.Tag = "username";
            this.txtUsername.Texts = "Usuario";
            this.txtUsername.UnderlinedStyle = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(202)))), ((int)(((byte)(230)))));
            this.label2.Location = new System.Drawing.Point(23, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(606, 16);
            this.label2.TabIndex = 17;
            this.label2.Text = "¡Bienvendi@ a HealthPortal! Ahora, vamos a crear al primer usuario, que será admi" +
    "nistrador por defecto";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 23.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(202)))), ((int)(((byte)(230)))));
            this.label1.Location = new System.Drawing.Point(19, 19);
            this.label1.Margin = new System.Windows.Forms.Padding(10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(427, 37);
            this.label1.TabIndex = 16;
            this.label1.Text = "Creación de Primer Usuario";
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
            // btnRegisterFirstUser
            // 
            this.btnRegisterFirstUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(202)))), ((int)(((byte)(230)))));
            this.btnRegisterFirstUser.BackGroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(202)))), ((int)(((byte)(230)))));
            this.btnRegisterFirstUser.BorderColor = System.Drawing.Color.CornflowerBlue;
            this.btnRegisterFirstUser.BorderRadius = 30;
            this.btnRegisterFirstUser.BorderSize = 0;
            this.btnRegisterFirstUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegisterFirstUser.FlatAppearance.BorderSize = 0;
            this.btnRegisterFirstUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegisterFirstUser.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegisterFirstUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(91)))));
            this.btnRegisterFirstUser.Location = new System.Drawing.Point(21, 331);
            this.btnRegisterFirstUser.Margin = new System.Windows.Forms.Padding(176, 10, 176, 15);
            this.btnRegisterFirstUser.Name = "btnRegisterFirstUser";
            this.btnRegisterFirstUser.Size = new System.Drawing.Size(620, 39);
            this.btnRegisterFirstUser.TabIndex = 9;
            this.btnRegisterFirstUser.TabStop = false;
            this.btnRegisterFirstUser.Tag = "LastButton";
            this.btnRegisterFirstUser.Text = "Registrar Primer Usuario";
            this.btnRegisterFirstUser.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(91)))));
            this.btnRegisterFirstUser.UseVisualStyleBackColor = false;
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
            this.txtPhoneNumber.Location = new System.Drawing.Point(343, 160);
            this.txtPhoneNumber.Margin = new System.Windows.Forms.Padding(20, 20, 20, 0);
            this.txtPhoneNumber.MaxLength = 9;
            this.txtPhoneNumber.Multiline = false;
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Padding = new System.Windows.Forms.Padding(20, 10, 10, 10);
            this.txtPhoneNumber.PasswordChar = false;
            this.txtPhoneNumber.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtPhoneNumber.PlaceholderText = "";
            this.txtPhoneNumber.Size = new System.Drawing.Size(286, 38);
            this.txtPhoneNumber.TabIndex = 4;
            this.txtPhoneNumber.Tag = "phoneNumber";
            this.txtPhoneNumber.Texts = "Número de Teléfono";
            this.txtPhoneNumber.UnderlinedStyle = false;
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
            this.txtEmail.Location = new System.Drawing.Point(29, 160);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.txtEmail.MaxLength = 100;
            this.txtEmail.Multiline = false;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Padding = new System.Windows.Forms.Padding(20, 10, 10, 10);
            this.txtEmail.PasswordChar = false;
            this.txtEmail.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtEmail.PlaceholderText = "";
            this.txtEmail.Size = new System.Drawing.Size(290, 38);
            this.txtEmail.TabIndex = 3;
            this.txtEmail.Tag = "email";
            this.txtEmail.Texts = "Correo Electrónico";
            this.txtEmail.UnderlinedStyle = false;
            // 
            // txtLastName
            // 
            this.txtLastName.BackColor = System.Drawing.SystemColors.Window;
            this.txtLastName.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(202)))), ((int)(((byte)(230)))));
            this.txtLastName.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtLastName.BorderRadius = 18;
            this.txtLastName.BorderSize = 2;
            this.txtLastName.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLastName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(202)))), ((int)(((byte)(230)))));
            this.txtLastName.Location = new System.Drawing.Point(343, 102);
            this.txtLastName.Margin = new System.Windows.Forms.Padding(20);
            this.txtLastName.MaxLength = 60;
            this.txtLastName.Multiline = false;
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Padding = new System.Windows.Forms.Padding(20, 10, 10, 10);
            this.txtLastName.PasswordChar = false;
            this.txtLastName.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtLastName.PlaceholderText = "";
            this.txtLastName.Size = new System.Drawing.Size(286, 38);
            this.txtLastName.TabIndex = 2;
            this.txtLastName.Tag = "name";
            this.txtLastName.Texts = "Apellidos";
            this.txtLastName.UnderlinedStyle = false;
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.SystemColors.Window;
            this.txtName.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(202)))), ((int)(((byte)(230)))));
            this.txtName.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtName.BorderRadius = 18;
            this.txtName.BorderSize = 2;
            this.txtName.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(202)))), ((int)(((byte)(230)))));
            this.txtName.Location = new System.Drawing.Point(29, 102);
            this.txtName.Margin = new System.Windows.Forms.Padding(20, 20, 0, 20);
            this.txtName.MaxLength = 60;
            this.txtName.Multiline = false;
            this.txtName.Name = "txtName";
            this.txtName.Padding = new System.Windows.Forms.Padding(20, 10, 10, 10);
            this.txtName.PasswordChar = false;
            this.txtName.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtName.PlaceholderText = "";
            this.txtName.Size = new System.Drawing.Size(290, 38);
            this.txtName.TabIndex = 1;
            this.txtName.Tag = "name";
            this.txtName.Texts = "Nombres";
            this.txtName.UnderlinedStyle = false;
            // 
            // FrmFirstUserCreation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(668, 394);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnRegisterFirstUser);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtPhoneNumber);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmFirstUserCreation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Creación del primer usuario";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public CustomControls.RJButton btnRegisterFirstUser;
        private System.Windows.Forms.GroupBox groupBox1;
        public CustomControls.CustomTextBox txtConfirmPassword;
        public CustomControls.CustomTextBox txtPassword;
        public CustomControls.CustomTextBox txtUsername;
        public CustomControls.CustomTextBox txtPhoneNumber;
        public CustomControls.CustomTextBox txtEmail;
        public CustomControls.CustomTextBox txtLastName;
        public CustomControls.CustomTextBox txtName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Button btnExit;
        public System.Windows.Forms.Button btnHidePassword;
        public System.Windows.Forms.Button btnShowPassword;
    }
}