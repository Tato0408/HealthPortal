namespace HealthPortal.View.FirstUsage
{
    partial class FrmEmailVerification
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
            this.txtConfirmationCode = new CustomControls.CustomTextBox();
            this.btnConfirmEmail = new CustomControls.RJButton();
            this.label2 = new System.Windows.Forms.Label();
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
            this.label1.Size = new System.Drawing.Size(383, 37);
            this.label1.TabIndex = 7;
            this.label1.Text = "Confirmación de Correo";
            // 
            // txtConfirmationCode
            // 
            this.txtConfirmationCode.BackColor = System.Drawing.SystemColors.Window;
            this.txtConfirmationCode.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(202)))), ((int)(((byte)(230)))));
            this.txtConfirmationCode.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtConfirmationCode.BorderRadius = 18;
            this.txtConfirmationCode.BorderSize = 2;
            this.txtConfirmationCode.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConfirmationCode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(202)))), ((int)(((byte)(230)))));
            this.txtConfirmationCode.Location = new System.Drawing.Point(26, 102);
            this.txtConfirmationCode.Margin = new System.Windows.Forms.Padding(20);
            this.txtConfirmationCode.MaxLength = 8;
            this.txtConfirmationCode.Multiline = false;
            this.txtConfirmationCode.Name = "txtConfirmationCode";
            this.txtConfirmationCode.Padding = new System.Windows.Forms.Padding(20, 10, 10, 10);
            this.txtConfirmationCode.PasswordChar = false;
            this.txtConfirmationCode.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtConfirmationCode.PlaceholderText = "";
            this.txtConfirmationCode.SelectionLength = 0;
            this.txtConfirmationCode.SelectionStart = 0;
            this.txtConfirmationCode.Size = new System.Drawing.Size(468, 38);
            this.txtConfirmationCode.TabIndex = 9;
            this.txtConfirmationCode.Tag = "confirmationCode";
            this.txtConfirmationCode.Texts = "Código de Confirmación";
            this.txtConfirmationCode.UnderlinedStyle = false;
            // 
            // btnConfirmEmail
            // 
            this.btnConfirmEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(202)))), ((int)(((byte)(230)))));
            this.btnConfirmEmail.BackGroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(202)))), ((int)(((byte)(230)))));
            this.btnConfirmEmail.BorderColor = System.Drawing.Color.CornflowerBlue;
            this.btnConfirmEmail.BorderRadius = 30;
            this.btnConfirmEmail.BorderSize = 0;
            this.btnConfirmEmail.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConfirmEmail.FlatAppearance.BorderSize = 0;
            this.btnConfirmEmail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirmEmail.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(91)))));
            this.btnConfirmEmail.Location = new System.Drawing.Point(26, 163);
            this.btnConfirmEmail.Margin = new System.Windows.Forms.Padding(176, 3, 20, 20);
            this.btnConfirmEmail.Name = "btnConfirmEmail";
            this.btnConfirmEmail.Size = new System.Drawing.Size(468, 32);
            this.btnConfirmEmail.TabIndex = 15;
            this.btnConfirmEmail.TabStop = false;
            this.btnConfirmEmail.Text = "Confirmar Correo";
            this.btnConfirmEmail.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(91)))));
            this.btnConfirmEmail.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(202)))), ((int)(((byte)(230)))));
            this.label2.Location = new System.Drawing.Point(23, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(447, 16);
            this.label2.TabIndex = 16;
            this.label2.Text = "Ingrese el código de confirmación que ha sido enviado a su correo";
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
            this.btnExit.Location = new System.Drawing.Point(477, 12);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(34, 34);
            this.btnExit.TabIndex = 17;
            this.btnExit.TabStop = false;
            this.btnExit.UseVisualStyleBackColor = false;
            // 
            // FrmEmailVerification
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(523, 224);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnConfirmEmail);
            this.Controls.Add(this.txtConfirmationCode);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmEmailVerification";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmEmailVerification";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        public CustomControls.CustomTextBox txtConfirmationCode;
        public CustomControls.RJButton btnConfirmEmail;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.Button btnExit;
    }
}