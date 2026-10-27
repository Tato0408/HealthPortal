namespace HealthPortal.View.Settings
{
    partial class FrmAddUpdateSecurityQuestion
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
            this.btnUpdateQuestion = new CustomControls.RJButton();
            this.btnAddQuestion = new CustomControls.RJButton();
            this.txtQuestion = new CustomControls.CustomTextBox();
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
            this.lblTitle.Size = new System.Drawing.Size(469, 37);
            this.lblTitle.TabIndex = 7;
            this.lblTitle.Text = "Añadir Pregunta de Seguridad";
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
            // btnUpdateQuestion
            // 
            this.btnUpdateQuestion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(202)))), ((int)(((byte)(230)))));
            this.btnUpdateQuestion.BackGroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(202)))), ((int)(((byte)(230)))));
            this.btnUpdateQuestion.BorderColor = System.Drawing.Color.CornflowerBlue;
            this.btnUpdateQuestion.BorderRadius = 30;
            this.btnUpdateQuestion.BorderSize = 0;
            this.btnUpdateQuestion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdateQuestion.FlatAppearance.BorderSize = 0;
            this.btnUpdateQuestion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateQuestion.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateQuestion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(91)))));
            this.btnUpdateQuestion.Location = new System.Drawing.Point(310, 164);
            this.btnUpdateQuestion.Margin = new System.Windows.Forms.Padding(10);
            this.btnUpdateQuestion.Name = "btnUpdateQuestion";
            this.btnUpdateQuestion.Size = new System.Drawing.Size(176, 41);
            this.btnUpdateQuestion.TabIndex = 18;
            this.btnUpdateQuestion.TabStop = false;
            this.btnUpdateQuestion.Text = "Actualizar Pregunta";
            this.btnUpdateQuestion.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(91)))));
            this.btnUpdateQuestion.UseVisualStyleBackColor = false;
            // 
            // btnAddQuestion
            // 
            this.btnAddQuestion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(202)))), ((int)(((byte)(230)))));
            this.btnAddQuestion.BackGroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(202)))), ((int)(((byte)(230)))));
            this.btnAddQuestion.BorderColor = System.Drawing.Color.CornflowerBlue;
            this.btnAddQuestion.BorderRadius = 30;
            this.btnAddQuestion.BorderSize = 0;
            this.btnAddQuestion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddQuestion.FlatAppearance.BorderSize = 0;
            this.btnAddQuestion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddQuestion.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddQuestion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(91)))));
            this.btnAddQuestion.Location = new System.Drawing.Point(506, 164);
            this.btnAddQuestion.Margin = new System.Windows.Forms.Padding(10);
            this.btnAddQuestion.Name = "btnAddQuestion";
            this.btnAddQuestion.Size = new System.Drawing.Size(176, 41);
            this.btnAddQuestion.TabIndex = 15;
            this.btnAddQuestion.TabStop = false;
            this.btnAddQuestion.Text = "Añadir Pregunta";
            this.btnAddQuestion.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(91)))));
            this.btnAddQuestion.UseVisualStyleBackColor = false;
            // 
            // txtQuestion
            // 
            this.txtQuestion.BackColor = System.Drawing.SystemColors.Window;
            this.txtQuestion.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(202)))), ((int)(((byte)(230)))));
            this.txtQuestion.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtQuestion.BorderRadius = 18;
            this.txtQuestion.BorderSize = 2;
            this.txtQuestion.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuestion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(202)))), ((int)(((byte)(230)))));
            this.txtQuestion.Location = new System.Drawing.Point(29, 86);
            this.txtQuestion.Margin = new System.Windows.Forms.Padding(20);
            this.txtQuestion.MaxLength = 148;
            this.txtQuestion.Multiline = false;
            this.txtQuestion.Name = "txtQuestion";
            this.txtQuestion.Padding = new System.Windows.Forms.Padding(25, 15, 25, 15);
            this.txtQuestion.PasswordChar = false;
            this.txtQuestion.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtQuestion.PlaceholderText = "";
            this.txtQuestion.SelectionLength = 0;
            this.txtQuestion.SelectionStart = 0;
            this.txtQuestion.Size = new System.Drawing.Size(643, 48);
            this.txtQuestion.TabIndex = 9;
            this.txtQuestion.Tag = "name";
            this.txtQuestion.Texts = "Pregunta";
            this.txtQuestion.UnderlinedStyle = false;
            // 
            // FrmAddUpdateSecurityQuestion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(701, 224);
            this.Controls.Add(this.btnUpdateQuestion);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnAddQuestion);
            this.Controls.Add(this.txtQuestion);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmAddUpdateSecurityQuestion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Añadir / Actualizar preguntas de seguridad";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public CustomControls.CustomTextBox txtQuestion;
        public CustomControls.RJButton btnAddQuestion;
        public System.Windows.Forms.Button btnExit;
        public System.Windows.Forms.Label lblTitle;
        public CustomControls.RJButton btnUpdateQuestion;
    }
}