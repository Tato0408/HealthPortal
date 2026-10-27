namespace HealthPortal.View.Settings
{
    partial class FrmAddUpdateSecurityAnswer
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
            this.btnUpdateAnswer = new CustomControls.RJButton();
            this.btnAddAnswer = new CustomControls.RJButton();
            this.txtAnswer = new CustomControls.CustomTextBox();
            this.cmbQuestions = new System.Windows.Forms.ComboBox();
            this.lblFilter = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Century Gothic", 23.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(202)))), ((int)(((byte)(230)))));
            this.lblTitle.Location = new System.Drawing.Point(19, 19);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(10);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(489, 37);
            this.lblTitle.TabIndex = 7;
            this.lblTitle.Text = "Añadir Respuesta de Seguridad";
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
            this.btnExit.Location = new System.Drawing.Point(655, 12);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(34, 34);
            this.btnExit.TabIndex = 17;
            this.btnExit.TabStop = false;
            this.btnExit.UseVisualStyleBackColor = false;
            // 
            // btnUpdateAnswer
            // 
            this.btnUpdateAnswer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(202)))), ((int)(((byte)(230)))));
            this.btnUpdateAnswer.BackGroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(202)))), ((int)(((byte)(230)))));
            this.btnUpdateAnswer.BorderColor = System.Drawing.Color.CornflowerBlue;
            this.btnUpdateAnswer.BorderRadius = 30;
            this.btnUpdateAnswer.BorderSize = 0;
            this.btnUpdateAnswer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdateAnswer.FlatAppearance.BorderSize = 0;
            this.btnUpdateAnswer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateAnswer.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateAnswer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(91)))));
            this.btnUpdateAnswer.Location = new System.Drawing.Point(310, 164);
            this.btnUpdateAnswer.Margin = new System.Windows.Forms.Padding(10);
            this.btnUpdateAnswer.Name = "btnUpdateAnswer";
            this.btnUpdateAnswer.Size = new System.Drawing.Size(176, 41);
            this.btnUpdateAnswer.TabIndex = 18;
            this.btnUpdateAnswer.TabStop = false;
            this.btnUpdateAnswer.Text = "Actualizar Pregunta";
            this.btnUpdateAnswer.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(91)))));
            this.btnUpdateAnswer.UseVisualStyleBackColor = false;
            // 
            // btnAddAnswer
            // 
            this.btnAddAnswer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(202)))), ((int)(((byte)(230)))));
            this.btnAddAnswer.BackGroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(202)))), ((int)(((byte)(230)))));
            this.btnAddAnswer.BorderColor = System.Drawing.Color.CornflowerBlue;
            this.btnAddAnswer.BorderRadius = 30;
            this.btnAddAnswer.BorderSize = 0;
            this.btnAddAnswer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddAnswer.FlatAppearance.BorderSize = 0;
            this.btnAddAnswer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddAnswer.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddAnswer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(91)))));
            this.btnAddAnswer.Location = new System.Drawing.Point(506, 164);
            this.btnAddAnswer.Margin = new System.Windows.Forms.Padding(10);
            this.btnAddAnswer.Name = "btnAddAnswer";
            this.btnAddAnswer.Size = new System.Drawing.Size(176, 41);
            this.btnAddAnswer.TabIndex = 15;
            this.btnAddAnswer.TabStop = false;
            this.btnAddAnswer.Text = "Añadir Pregunta";
            this.btnAddAnswer.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(91)))));
            this.btnAddAnswer.UseVisualStyleBackColor = false;
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
            this.txtAnswer.Location = new System.Drawing.Point(29, 86);
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
            this.cmbQuestions.Location = new System.Drawing.Point(428, 109);
            this.cmbQuestions.Margin = new System.Windows.Forms.Padding(0);
            this.cmbQuestions.Name = "cmbQuestions";
            this.cmbQuestions.Size = new System.Drawing.Size(244, 25);
            this.cmbQuestions.TabIndex = 30;
            this.cmbQuestions.TabStop = false;
            // 
            // lblFilter
            // 
            this.lblFilter.AutoSize = true;
            this.lblFilter.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFilter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(202)))), ((int)(((byte)(230)))));
            this.lblFilter.Location = new System.Drawing.Point(425, 86);
            this.lblFilter.Margin = new System.Windows.Forms.Padding(0);
            this.lblFilter.Name = "lblFilter";
            this.lblFilter.Size = new System.Drawing.Size(124, 15);
            this.lblFilter.TabIndex = 31;
            this.lblFilter.Text = "Pregunta a responder";
            // 
            // FrmAddUpdateSecurityAnswer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(701, 224);
            this.Controls.Add(this.lblFilter);
            this.Controls.Add(this.cmbQuestions);
            this.Controls.Add(this.btnUpdateAnswer);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnAddAnswer);
            this.Controls.Add(this.txtAnswer);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmAddUpdateSecurityAnswer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Añadir / Actualizar respuestas de seguridad";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public CustomControls.CustomTextBox txtAnswer;
        public CustomControls.RJButton btnAddAnswer;
        public System.Windows.Forms.Button btnExit;
        public System.Windows.Forms.Label lblTitle;
        public CustomControls.RJButton btnUpdateAnswer;
        public System.Windows.Forms.ComboBox cmbQuestions;
        private System.Windows.Forms.Label lblFilter;
    }
}