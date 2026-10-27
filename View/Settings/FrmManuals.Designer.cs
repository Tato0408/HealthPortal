namespace HealthPortal.View.Settings
{
    partial class FrmManuals
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmManuals));
            this.label1 = new System.Windows.Forms.Label();
            this.btnDowland2 = new CustomControls.RJButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 22);
            this.label1.TabIndex = 13;
            this.label1.Text = "Manuales";
            // 
            // btnDowland2
            // 
            this.btnDowland2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDowland2.BackColor = System.Drawing.Color.LightBlue;
            this.btnDowland2.BackGroundColor = System.Drawing.Color.LightBlue;
            this.btnDowland2.BorderColor = System.Drawing.Color.CornflowerBlue;
            this.btnDowland2.BorderRadius = 40;
            this.btnDowland2.BorderSize = 0;
            this.btnDowland2.FlatAppearance.BorderSize = 0;
            this.btnDowland2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDowland2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnDowland2.ForeColor = System.Drawing.Color.Black;
            this.btnDowland2.Location = new System.Drawing.Point(68, 33);
            this.btnDowland2.Name = "btnDowland2";
            this.btnDowland2.Size = new System.Drawing.Size(175, 40);
            this.btnDowland2.TabIndex = 16;
            this.btnDowland2.Text = "Descarga";
            this.btnDowland2.TextColor = System.Drawing.Color.Black;
            this.btnDowland2.UseVisualStyleBackColor = false;
            // 
            // FrmManuals
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(302, 101);
            this.Controls.Add(this.btnDowland2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmManuals";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manuales del sistema";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public CustomControls.RJButton btnDowland2;
        private System.Windows.Forms.Label label1;
    }
}