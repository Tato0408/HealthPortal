namespace HealthPortal.View.PasswordManagement
{
    partial class FrmSecurityQuestions
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnConfirmAnswer = new CustomControls.RJButton();
            this.txtAnswer = new CustomControls.CustomTextBox();
            this.cmbQuestions = new System.Windows.Forms.ComboBox();
            this.lblFilter = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Century Gothic", 23.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(202)))), ((int)(((byte)(230)))));
            this.lblTitle.Location = new System.Drawing.Point(19, 19);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(10);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(386, 86);
            this.lblTitle.TabIndex = 7;
            this.lblTitle.Text = "Recuperación por Preguntas de Seguridad";
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
            this.btnExit.Location = new System.Drawing.Point(451, 12);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(34, 34);
            this.btnExit.TabIndex = 17;
            this.btnExit.TabStop = false;
            this.btnExit.UseVisualStyleBackColor = false;
            // 
            // btnConfirmAnswer
            // 
            this.btnConfirmAnswer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(202)))), ((int)(((byte)(230)))));
            this.btnConfirmAnswer.BackGroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(202)))), ((int)(((byte)(230)))));
            this.btnConfirmAnswer.BorderColor = System.Drawing.Color.CornflowerBlue;
            this.btnConfirmAnswer.BorderRadius = 30;
            this.btnConfirmAnswer.BorderSize = 0;
            this.btnConfirmAnswer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConfirmAnswer.FlatAppearance.BorderSize = 0;
            this.btnConfirmAnswer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirmAnswer.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmAnswer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(91)))));
            this.btnConfirmAnswer.Location = new System.Drawing.Point(302, 284);
            this.btnConfirmAnswer.Margin = new System.Windows.Forms.Padding(10);
            this.btnConfirmAnswer.Name = "btnConfirmAnswer";
            this.btnConfirmAnswer.Size = new System.Drawing.Size(176, 41);
            this.btnConfirmAnswer.TabIndex = 15;
            this.btnConfirmAnswer.TabStop = false;
            this.btnConfirmAnswer.Text = "Confirmar Respuesta";
            this.btnConfirmAnswer.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(91)))));
            this.btnConfirmAnswer.UseVisualStyleBackColor = false;
            // 
            // txtAnswer
            // 
            this.txtAnswer.BackColor = System.Drawing.SystemColors.Window;
            this.txtAnswer.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(202)))), ((int)(((byte)(230)))));
            this.txtAnswer.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtAnswer.BorderRadius = 18;
            this.txtAnswer.BorderSize = 2;
            this.txtAnswer.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAnswer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(202)))), ((int)(((byte)(230)))));
            this.txtAnswer.Location = new System.Drawing.Point(26, 200);
            this.txtAnswer.Margin = new System.Windows.Forms.Padding(20);
            this.txtAnswer.MaxLength = 256;
            this.txtAnswer.Multiline = false;
            this.txtAnswer.Name = "txtAnswer";
            this.txtAnswer.Padding = new System.Windows.Forms.Padding(25, 15, 25, 15);
            this.txtAnswer.PasswordChar = false;
            this.txtAnswer.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtAnswer.PlaceholderText = "";
            this.txtAnswer.SelectionLength = 0;
            this.txtAnswer.SelectionStart = 0;
            this.txtAnswer.Size = new System.Drawing.Size(379, 48);
            this.txtAnswer.TabIndex = 9;
            this.txtAnswer.Tag = "securityAnswer";
            this.txtAnswer.Texts = "Respuesta";
            this.txtAnswer.UnderlinedStyle = false;
            // 
            // cmbQuestions
            // 
            this.cmbQuestions.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbQuestions.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbQuestions.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(91)))));
            this.cmbQuestions.FormattingEnabled = true;
            this.cmbQuestions.Location = new System.Drawing.Point(26, 155);
            this.cmbQuestions.Margin = new System.Windows.Forms.Padding(0);
            this.cmbQuestions.Name = "cmbQuestions";
            this.cmbQuestions.Size = new System.Drawing.Size(379, 25);
            this.cmbQuestions.TabIndex = 30;
            this.cmbQuestions.TabStop = false;
            // 
            // lblFilter
            // 
            this.lblFilter.AutoSize = true;
            this.lblFilter.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFilter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(202)))), ((int)(((byte)(230)))));
            this.lblFilter.Location = new System.Drawing.Point(23, 132);
            this.lblFilter.Margin = new System.Windows.Forms.Padding(0);
            this.lblFilter.Name = "lblFilter";
            this.lblFilter.Size = new System.Drawing.Size(124, 15);
            this.lblFilter.TabIndex = 31;
            this.lblFilter.Text = "Pregunta a responder";
            // 
            // FrmSecurityQuestions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(497, 344);
            this.Controls.Add(this.lblFilter);
            this.Controls.Add(this.cmbQuestions);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnConfirmAnswer);
            this.Controls.Add(this.txtAnswer);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmSecurityQuestions";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Añadir / Actualizar respuestas de seguridad";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public CustomControls.CustomTextBox txtAnswer;
        public CustomControls.RJButton btnConfirmAnswer;
        public System.Windows.Forms.Button btnExit;
        public System.Windows.Forms.Label lblTitle;
        public System.Windows.Forms.ComboBox cmbQuestions;
        private System.Windows.Forms.Label lblFilter;
    }
}