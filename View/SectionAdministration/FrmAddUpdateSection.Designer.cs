namespace HealthPortal.View.SectionAdministration
{
    partial class FrmAddUpdateSection
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
            this.tabPageGrade = new System.Windows.Forms.TabPage();
            this.btnExitG = new System.Windows.Forms.Button();
            this.grpGrade = new System.Windows.Forms.GroupBox();
            this.txtGrade = new CustomControls.CustomTextBox();
            this.lblGrade = new System.Windows.Forms.Label();
            this.btnUpdateGrade = new CustomControls.RJButton();
            this.btnAddGrade = new CustomControls.RJButton();
            this.tabPageAcademicSection = new System.Windows.Forms.TabPage();
            this.btnExitSA = new System.Windows.Forms.Button();
            this.grpAcademicSection = new System.Windows.Forms.GroupBox();
            this.txtAcademicSection = new CustomControls.CustomTextBox();
            this.lblAcademicSection = new System.Windows.Forms.Label();
            this.btnUpdateAcademicSection = new CustomControls.RJButton();
            this.btnAddAcademicSection = new CustomControls.RJButton();
            this.tabPageSpecialty = new System.Windows.Forms.TabPage();
            this.btnExitE = new System.Windows.Forms.Button();
            this.grpSpecialty = new System.Windows.Forms.GroupBox();
            this.txtSpecialty = new CustomControls.CustomTextBox();
            this.lblSpecialty = new System.Windows.Forms.Label();
            this.btnUpdateSpecialty = new CustomControls.RJButton();
            this.btnAddSpecialty = new CustomControls.RJButton();
            this.tabPageSection = new System.Windows.Forms.TabPage();
            this.btnExitS = new System.Windows.Forms.Button();
            this.btnUpdateSection = new CustomControls.RJButton();
            this.btnAddSection = new CustomControls.RJButton();
            this.grpSection = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbAcademicSection = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbSpecialty = new System.Windows.Forms.ComboBox();
            this.cmbGrade = new System.Windows.Forms.ComboBox();
            this.txtTechnicalGroup = new CustomControls.CustomTextBox();
            this.lblSection = new System.Windows.Forms.Label();
            this.tabAcademicLevel = new System.Windows.Forms.TabControl();
            this.tabPageGrade.SuspendLayout();
            this.grpGrade.SuspendLayout();
            this.tabPageAcademicSection.SuspendLayout();
            this.grpAcademicSection.SuspendLayout();
            this.tabPageSpecialty.SuspendLayout();
            this.grpSpecialty.SuspendLayout();
            this.tabPageSection.SuspendLayout();
            this.grpSection.SuspendLayout();
            this.tabAcademicLevel.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPageGrade
            // 
            this.tabPageGrade.BackColor = System.Drawing.Color.White;
            this.tabPageGrade.Controls.Add(this.btnExitG);
            this.tabPageGrade.Controls.Add(this.grpGrade);
            this.tabPageGrade.Controls.Add(this.lblGrade);
            this.tabPageGrade.Controls.Add(this.btnUpdateGrade);
            this.tabPageGrade.Controls.Add(this.btnAddGrade);
            this.tabPageGrade.Cursor = System.Windows.Forms.Cursors.Default;
            this.tabPageGrade.ForeColor = System.Drawing.Color.Black;
            this.tabPageGrade.Location = new System.Drawing.Point(4, 39);
            this.tabPageGrade.Name = "tabPageGrade";
            this.tabPageGrade.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageGrade.Size = new System.Drawing.Size(612, 317);
            this.tabPageGrade.TabIndex = 3;
            this.tabPageGrade.Text = "Grados";
            // 
            // btnExitG
            // 
            this.btnExitG.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnExitG.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExitG.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnExitG.FlatAppearance.BorderSize = 0;
            this.btnExitG.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnExitG.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnExitG.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExitG.ForeColor = System.Drawing.Color.White;
            this.btnExitG.Image = global::HealthPortal.Properties.Resources.quit;
            this.btnExitG.Location = new System.Drawing.Point(572, 6);
            this.btnExitG.Name = "btnExitG";
            this.btnExitG.Size = new System.Drawing.Size(34, 34);
            this.btnExitG.TabIndex = 48;
            this.btnExitG.TabStop = false;
            this.btnExitG.UseVisualStyleBackColor = false;
            // 
            // grpGrade
            // 
            this.grpGrade.Controls.Add(this.txtGrade);
            this.grpGrade.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpGrade.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.grpGrade.Location = new System.Drawing.Point(17, 70);
            this.grpGrade.Margin = new System.Windows.Forms.Padding(10, 10, 20, 10);
            this.grpGrade.Name = "grpGrade";
            this.grpGrade.Size = new System.Drawing.Size(568, 170);
            this.grpGrade.TabIndex = 36;
            this.grpGrade.TabStop = false;
            this.grpGrade.Text = "Información de nuevo grado";
            // 
            // txtGrade
            // 
            this.txtGrade.BackColor = System.Drawing.SystemColors.Window;
            this.txtGrade.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(202)))), ((int)(((byte)(230)))));
            this.txtGrade.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtGrade.BorderRadius = 18;
            this.txtGrade.BorderSize = 2;
            this.txtGrade.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGrade.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(202)))), ((int)(((byte)(230)))));
            this.txtGrade.Location = new System.Drawing.Point(23, 58);
            this.txtGrade.Margin = new System.Windows.Forms.Padding(20, 10, 20, 20);
            this.txtGrade.MaxLength = 60;
            this.txtGrade.Multiline = false;
            this.txtGrade.Name = "txtGrade";
            this.txtGrade.Padding = new System.Windows.Forms.Padding(30, 20, 30, 20);
            this.txtGrade.PasswordChar = false;
            this.txtGrade.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtGrade.PlaceholderText = "";
            this.txtGrade.Size = new System.Drawing.Size(522, 58);
            this.txtGrade.TabIndex = 19;
            this.txtGrade.Texts = "Grado";
            this.txtGrade.UnderlinedStyle = false;
            // 
            // lblGrade
            // 
            this.lblGrade.AutoSize = true;
            this.lblGrade.Font = new System.Drawing.Font("Century Gothic", 23.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGrade.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(202)))), ((int)(((byte)(230)))));
            this.lblGrade.Location = new System.Drawing.Point(10, 13);
            this.lblGrade.Margin = new System.Windows.Forms.Padding(10);
            this.lblGrade.Name = "lblGrade";
            this.lblGrade.Size = new System.Drawing.Size(245, 37);
            this.lblGrade.TabIndex = 35;
            this.lblGrade.Text = "Agregar Grado";
            // 
            // btnUpdateGrade
            // 
            this.btnUpdateGrade.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(202)))), ((int)(((byte)(230)))));
            this.btnUpdateGrade.BackGroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(202)))), ((int)(((byte)(230)))));
            this.btnUpdateGrade.BorderColor = System.Drawing.Color.CornflowerBlue;
            this.btnUpdateGrade.BorderRadius = 30;
            this.btnUpdateGrade.BorderSize = 0;
            this.btnUpdateGrade.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdateGrade.FlatAppearance.BorderSize = 0;
            this.btnUpdateGrade.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateGrade.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateGrade.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(91)))));
            this.btnUpdateGrade.Location = new System.Drawing.Point(283, 260);
            this.btnUpdateGrade.Margin = new System.Windows.Forms.Padding(10);
            this.btnUpdateGrade.Name = "btnUpdateGrade";
            this.btnUpdateGrade.Size = new System.Drawing.Size(141, 39);
            this.btnUpdateGrade.TabIndex = 38;
            this.btnUpdateGrade.TabStop = false;
            this.btnUpdateGrade.Text = "Actualizar";
            this.btnUpdateGrade.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(91)))));
            this.btnUpdateGrade.UseVisualStyleBackColor = false;
            // 
            // btnAddGrade
            // 
            this.btnAddGrade.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(202)))), ((int)(((byte)(230)))));
            this.btnAddGrade.BackGroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(202)))), ((int)(((byte)(230)))));
            this.btnAddGrade.BorderColor = System.Drawing.Color.CornflowerBlue;
            this.btnAddGrade.BorderRadius = 30;
            this.btnAddGrade.BorderSize = 0;
            this.btnAddGrade.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddGrade.FlatAppearance.BorderSize = 0;
            this.btnAddGrade.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddGrade.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddGrade.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(91)))));
            this.btnAddGrade.Location = new System.Drawing.Point(444, 260);
            this.btnAddGrade.Margin = new System.Windows.Forms.Padding(10);
            this.btnAddGrade.Name = "btnAddGrade";
            this.btnAddGrade.Size = new System.Drawing.Size(141, 39);
            this.btnAddGrade.TabIndex = 37;
            this.btnAddGrade.TabStop = false;
            this.btnAddGrade.Text = "Agregar";
            this.btnAddGrade.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(91)))));
            this.btnAddGrade.UseVisualStyleBackColor = false;
            // 
            // tabPageAcademicSection
            // 
            this.tabPageAcademicSection.BackColor = System.Drawing.Color.White;
            this.tabPageAcademicSection.Controls.Add(this.btnExitSA);
            this.tabPageAcademicSection.Controls.Add(this.grpAcademicSection);
            this.tabPageAcademicSection.Controls.Add(this.lblAcademicSection);
            this.tabPageAcademicSection.Controls.Add(this.btnUpdateAcademicSection);
            this.tabPageAcademicSection.Controls.Add(this.btnAddAcademicSection);
            this.tabPageAcademicSection.Cursor = System.Windows.Forms.Cursors.Default;
            this.tabPageAcademicSection.Location = new System.Drawing.Point(4, 39);
            this.tabPageAcademicSection.Name = "tabPageAcademicSection";
            this.tabPageAcademicSection.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAcademicSection.Size = new System.Drawing.Size(612, 317);
            this.tabPageAcademicSection.TabIndex = 2;
            this.tabPageAcademicSection.Text = "Secciones Académicas";
            // 
            // btnExitSA
            // 
            this.btnExitSA.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnExitSA.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExitSA.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnExitSA.FlatAppearance.BorderSize = 0;
            this.btnExitSA.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnExitSA.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnExitSA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExitSA.ForeColor = System.Drawing.Color.White;
            this.btnExitSA.Image = global::HealthPortal.Properties.Resources.quit;
            this.btnExitSA.Location = new System.Drawing.Point(572, 6);
            this.btnExitSA.Name = "btnExitSA";
            this.btnExitSA.Size = new System.Drawing.Size(34, 34);
            this.btnExitSA.TabIndex = 48;
            this.btnExitSA.TabStop = false;
            this.btnExitSA.UseVisualStyleBackColor = false;
            // 
            // grpAcademicSection
            // 
            this.grpAcademicSection.Controls.Add(this.txtAcademicSection);
            this.grpAcademicSection.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpAcademicSection.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.grpAcademicSection.Location = new System.Drawing.Point(17, 70);
            this.grpAcademicSection.Margin = new System.Windows.Forms.Padding(10, 10, 20, 10);
            this.grpAcademicSection.Name = "grpAcademicSection";
            this.grpAcademicSection.Size = new System.Drawing.Size(568, 170);
            this.grpAcademicSection.TabIndex = 44;
            this.grpAcademicSection.TabStop = false;
            this.grpAcademicSection.Text = "Información de nueva sección académica";
            // 
            // txtAcademicSection
            // 
            this.txtAcademicSection.BackColor = System.Drawing.SystemColors.Window;
            this.txtAcademicSection.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(202)))), ((int)(((byte)(230)))));
            this.txtAcademicSection.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtAcademicSection.BorderRadius = 18;
            this.txtAcademicSection.BorderSize = 2;
            this.txtAcademicSection.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAcademicSection.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(202)))), ((int)(((byte)(230)))));
            this.txtAcademicSection.Location = new System.Drawing.Point(23, 58);
            this.txtAcademicSection.Margin = new System.Windows.Forms.Padding(20, 10, 20, 20);
            this.txtAcademicSection.MaxLength = 10;
            this.txtAcademicSection.Multiline = false;
            this.txtAcademicSection.Name = "txtAcademicSection";
            this.txtAcademicSection.Padding = new System.Windows.Forms.Padding(30, 20, 30, 20);
            this.txtAcademicSection.PasswordChar = false;
            this.txtAcademicSection.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtAcademicSection.PlaceholderText = "";
            this.txtAcademicSection.Size = new System.Drawing.Size(522, 58);
            this.txtAcademicSection.TabIndex = 19;
            this.txtAcademicSection.Texts = "Sección Académica";
            this.txtAcademicSection.UnderlinedStyle = false;
            // 
            // lblAcademicSection
            // 
            this.lblAcademicSection.AutoSize = true;
            this.lblAcademicSection.Font = new System.Drawing.Font("Century Gothic", 23.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAcademicSection.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(202)))), ((int)(((byte)(230)))));
            this.lblAcademicSection.Location = new System.Drawing.Point(10, 13);
            this.lblAcademicSection.Margin = new System.Windows.Forms.Padding(10);
            this.lblAcademicSection.Name = "lblAcademicSection";
            this.lblAcademicSection.Size = new System.Drawing.Size(459, 37);
            this.lblAcademicSection.TabIndex = 43;
            this.lblAcademicSection.Text = "Agregar Sección Académica";
            // 
            // btnUpdateAcademicSection
            // 
            this.btnUpdateAcademicSection.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(202)))), ((int)(((byte)(230)))));
            this.btnUpdateAcademicSection.BackGroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(202)))), ((int)(((byte)(230)))));
            this.btnUpdateAcademicSection.BorderColor = System.Drawing.Color.CornflowerBlue;
            this.btnUpdateAcademicSection.BorderRadius = 30;
            this.btnUpdateAcademicSection.BorderSize = 0;
            this.btnUpdateAcademicSection.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdateAcademicSection.FlatAppearance.BorderSize = 0;
            this.btnUpdateAcademicSection.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateAcademicSection.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateAcademicSection.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(91)))));
            this.btnUpdateAcademicSection.Location = new System.Drawing.Point(283, 260);
            this.btnUpdateAcademicSection.Margin = new System.Windows.Forms.Padding(10);
            this.btnUpdateAcademicSection.Name = "btnUpdateAcademicSection";
            this.btnUpdateAcademicSection.Size = new System.Drawing.Size(141, 39);
            this.btnUpdateAcademicSection.TabIndex = 46;
            this.btnUpdateAcademicSection.TabStop = false;
            this.btnUpdateAcademicSection.Text = "Actualizar";
            this.btnUpdateAcademicSection.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(91)))));
            this.btnUpdateAcademicSection.UseVisualStyleBackColor = false;
            // 
            // btnAddAcademicSection
            // 
            this.btnAddAcademicSection.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(202)))), ((int)(((byte)(230)))));
            this.btnAddAcademicSection.BackGroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(202)))), ((int)(((byte)(230)))));
            this.btnAddAcademicSection.BorderColor = System.Drawing.Color.CornflowerBlue;
            this.btnAddAcademicSection.BorderRadius = 30;
            this.btnAddAcademicSection.BorderSize = 0;
            this.btnAddAcademicSection.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddAcademicSection.FlatAppearance.BorderSize = 0;
            this.btnAddAcademicSection.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddAcademicSection.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddAcademicSection.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(91)))));
            this.btnAddAcademicSection.Location = new System.Drawing.Point(444, 260);
            this.btnAddAcademicSection.Margin = new System.Windows.Forms.Padding(10);
            this.btnAddAcademicSection.Name = "btnAddAcademicSection";
            this.btnAddAcademicSection.Size = new System.Drawing.Size(141, 39);
            this.btnAddAcademicSection.TabIndex = 45;
            this.btnAddAcademicSection.TabStop = false;
            this.btnAddAcademicSection.Text = "Agregar";
            this.btnAddAcademicSection.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(91)))));
            this.btnAddAcademicSection.UseVisualStyleBackColor = false;
            // 
            // tabPageSpecialty
            // 
            this.tabPageSpecialty.BackColor = System.Drawing.Color.White;
            this.tabPageSpecialty.Controls.Add(this.btnExitE);
            this.tabPageSpecialty.Controls.Add(this.grpSpecialty);
            this.tabPageSpecialty.Controls.Add(this.lblSpecialty);
            this.tabPageSpecialty.Controls.Add(this.btnUpdateSpecialty);
            this.tabPageSpecialty.Controls.Add(this.btnAddSpecialty);
            this.tabPageSpecialty.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(91)))));
            this.tabPageSpecialty.Location = new System.Drawing.Point(4, 39);
            this.tabPageSpecialty.Name = "tabPageSpecialty";
            this.tabPageSpecialty.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSpecialty.Size = new System.Drawing.Size(612, 317);
            this.tabPageSpecialty.TabIndex = 1;
            this.tabPageSpecialty.Text = "Especialidades";
            // 
            // btnExitE
            // 
            this.btnExitE.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnExitE.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExitE.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnExitE.FlatAppearance.BorderSize = 0;
            this.btnExitE.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnExitE.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnExitE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExitE.ForeColor = System.Drawing.Color.White;
            this.btnExitE.Image = global::HealthPortal.Properties.Resources.quit;
            this.btnExitE.Location = new System.Drawing.Point(572, 6);
            this.btnExitE.Name = "btnExitE";
            this.btnExitE.Size = new System.Drawing.Size(34, 34);
            this.btnExitE.TabIndex = 48;
            this.btnExitE.TabStop = false;
            this.btnExitE.UseVisualStyleBackColor = false;
            // 
            // grpSpecialty
            // 
            this.grpSpecialty.Controls.Add(this.txtSpecialty);
            this.grpSpecialty.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpSpecialty.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.grpSpecialty.Location = new System.Drawing.Point(17, 70);
            this.grpSpecialty.Margin = new System.Windows.Forms.Padding(10, 10, 20, 10);
            this.grpSpecialty.Name = "grpSpecialty";
            this.grpSpecialty.Size = new System.Drawing.Size(568, 170);
            this.grpSpecialty.TabIndex = 40;
            this.grpSpecialty.TabStop = false;
            this.grpSpecialty.Text = "Información de nueva especialidad";
            // 
            // txtSpecialty
            // 
            this.txtSpecialty.BackColor = System.Drawing.SystemColors.Window;
            this.txtSpecialty.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(202)))), ((int)(((byte)(230)))));
            this.txtSpecialty.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtSpecialty.BorderRadius = 18;
            this.txtSpecialty.BorderSize = 2;
            this.txtSpecialty.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSpecialty.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(202)))), ((int)(((byte)(230)))));
            this.txtSpecialty.Location = new System.Drawing.Point(23, 58);
            this.txtSpecialty.Margin = new System.Windows.Forms.Padding(20, 10, 20, 20);
            this.txtSpecialty.MaxLength = 60;
            this.txtSpecialty.Multiline = false;
            this.txtSpecialty.Name = "txtSpecialty";
            this.txtSpecialty.Padding = new System.Windows.Forms.Padding(30, 20, 30, 20);
            this.txtSpecialty.PasswordChar = false;
            this.txtSpecialty.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtSpecialty.PlaceholderText = "";
            this.txtSpecialty.Size = new System.Drawing.Size(522, 58);
            this.txtSpecialty.TabIndex = 19;
            this.txtSpecialty.Texts = "Especialidad";
            this.txtSpecialty.UnderlinedStyle = false;
            // 
            // lblSpecialty
            // 
            this.lblSpecialty.AutoSize = true;
            this.lblSpecialty.Font = new System.Drawing.Font("Century Gothic", 23.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSpecialty.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(202)))), ((int)(((byte)(230)))));
            this.lblSpecialty.Location = new System.Drawing.Point(10, 13);
            this.lblSpecialty.Margin = new System.Windows.Forms.Padding(10);
            this.lblSpecialty.Name = "lblSpecialty";
            this.lblSpecialty.Size = new System.Drawing.Size(340, 37);
            this.lblSpecialty.TabIndex = 39;
            this.lblSpecialty.Text = "Agregar Especialidad";
            // 
            // btnUpdateSpecialty
            // 
            this.btnUpdateSpecialty.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(202)))), ((int)(((byte)(230)))));
            this.btnUpdateSpecialty.BackGroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(202)))), ((int)(((byte)(230)))));
            this.btnUpdateSpecialty.BorderColor = System.Drawing.Color.CornflowerBlue;
            this.btnUpdateSpecialty.BorderRadius = 30;
            this.btnUpdateSpecialty.BorderSize = 0;
            this.btnUpdateSpecialty.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdateSpecialty.FlatAppearance.BorderSize = 0;
            this.btnUpdateSpecialty.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateSpecialty.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateSpecialty.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(91)))));
            this.btnUpdateSpecialty.Location = new System.Drawing.Point(283, 260);
            this.btnUpdateSpecialty.Margin = new System.Windows.Forms.Padding(10);
            this.btnUpdateSpecialty.Name = "btnUpdateSpecialty";
            this.btnUpdateSpecialty.Size = new System.Drawing.Size(141, 39);
            this.btnUpdateSpecialty.TabIndex = 42;
            this.btnUpdateSpecialty.TabStop = false;
            this.btnUpdateSpecialty.Text = "Actualizar";
            this.btnUpdateSpecialty.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(91)))));
            this.btnUpdateSpecialty.UseVisualStyleBackColor = false;
            // 
            // btnAddSpecialty
            // 
            this.btnAddSpecialty.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(202)))), ((int)(((byte)(230)))));
            this.btnAddSpecialty.BackGroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(202)))), ((int)(((byte)(230)))));
            this.btnAddSpecialty.BorderColor = System.Drawing.Color.CornflowerBlue;
            this.btnAddSpecialty.BorderRadius = 30;
            this.btnAddSpecialty.BorderSize = 0;
            this.btnAddSpecialty.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddSpecialty.FlatAppearance.BorderSize = 0;
            this.btnAddSpecialty.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddSpecialty.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddSpecialty.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(91)))));
            this.btnAddSpecialty.Location = new System.Drawing.Point(444, 260);
            this.btnAddSpecialty.Margin = new System.Windows.Forms.Padding(10);
            this.btnAddSpecialty.Name = "btnAddSpecialty";
            this.btnAddSpecialty.Size = new System.Drawing.Size(141, 39);
            this.btnAddSpecialty.TabIndex = 41;
            this.btnAddSpecialty.TabStop = false;
            this.btnAddSpecialty.Text = "Agregar";
            this.btnAddSpecialty.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(91)))));
            this.btnAddSpecialty.UseVisualStyleBackColor = false;
            // 
            // tabPageSection
            // 
            this.tabPageSection.BackColor = System.Drawing.Color.White;
            this.tabPageSection.Controls.Add(this.btnExitS);
            this.tabPageSection.Controls.Add(this.btnUpdateSection);
            this.tabPageSection.Controls.Add(this.btnAddSection);
            this.tabPageSection.Controls.Add(this.grpSection);
            this.tabPageSection.Controls.Add(this.lblSection);
            this.tabPageSection.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPageSection.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(91)))));
            this.tabPageSection.Location = new System.Drawing.Point(4, 40);
            this.tabPageSection.Name = "tabPageSection";
            this.tabPageSection.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSection.Size = new System.Drawing.Size(612, 316);
            this.tabPageSection.TabIndex = 0;
            this.tabPageSection.Text = "Secciones";
            // 
            // btnExitS
            // 
            this.btnExitS.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnExitS.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExitS.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnExitS.FlatAppearance.BorderSize = 0;
            this.btnExitS.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnExitS.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnExitS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExitS.ForeColor = System.Drawing.Color.White;
            this.btnExitS.Image = global::HealthPortal.Properties.Resources.quit;
            this.btnExitS.Location = new System.Drawing.Point(572, 6);
            this.btnExitS.Name = "btnExitS";
            this.btnExitS.Size = new System.Drawing.Size(34, 34);
            this.btnExitS.TabIndex = 47;
            this.btnExitS.TabStop = false;
            this.btnExitS.UseVisualStyleBackColor = false;
            // 
            // btnUpdateSection
            // 
            this.btnUpdateSection.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(202)))), ((int)(((byte)(230)))));
            this.btnUpdateSection.BackGroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(202)))), ((int)(((byte)(230)))));
            this.btnUpdateSection.BorderColor = System.Drawing.Color.CornflowerBlue;
            this.btnUpdateSection.BorderRadius = 30;
            this.btnUpdateSection.BorderSize = 0;
            this.btnUpdateSection.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdateSection.FlatAppearance.BorderSize = 0;
            this.btnUpdateSection.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateSection.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateSection.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(91)))));
            this.btnUpdateSection.Location = new System.Drawing.Point(283, 260);
            this.btnUpdateSection.Margin = new System.Windows.Forms.Padding(10);
            this.btnUpdateSection.Name = "btnUpdateSection";
            this.btnUpdateSection.Size = new System.Drawing.Size(141, 39);
            this.btnUpdateSection.TabIndex = 46;
            this.btnUpdateSection.TabStop = false;
            this.btnUpdateSection.Text = "Actualizar";
            this.btnUpdateSection.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(91)))));
            this.btnUpdateSection.UseVisualStyleBackColor = false;
            // 
            // btnAddSection
            // 
            this.btnAddSection.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(202)))), ((int)(((byte)(230)))));
            this.btnAddSection.BackGroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(202)))), ((int)(((byte)(230)))));
            this.btnAddSection.BorderColor = System.Drawing.Color.CornflowerBlue;
            this.btnAddSection.BorderRadius = 30;
            this.btnAddSection.BorderSize = 0;
            this.btnAddSection.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddSection.FlatAppearance.BorderSize = 0;
            this.btnAddSection.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddSection.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddSection.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(91)))));
            this.btnAddSection.Location = new System.Drawing.Point(444, 260);
            this.btnAddSection.Margin = new System.Windows.Forms.Padding(10);
            this.btnAddSection.Name = "btnAddSection";
            this.btnAddSection.Size = new System.Drawing.Size(141, 39);
            this.btnAddSection.TabIndex = 45;
            this.btnAddSection.TabStop = false;
            this.btnAddSection.Text = "Agregar";
            this.btnAddSection.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(91)))));
            this.btnAddSection.UseVisualStyleBackColor = false;
            // 
            // grpSection
            // 
            this.grpSection.Controls.Add(this.label7);
            this.grpSection.Controls.Add(this.cmbAcademicSection);
            this.grpSection.Controls.Add(this.label5);
            this.grpSection.Controls.Add(this.label6);
            this.grpSection.Controls.Add(this.cmbSpecialty);
            this.grpSection.Controls.Add(this.cmbGrade);
            this.grpSection.Controls.Add(this.txtTechnicalGroup);
            this.grpSection.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpSection.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.grpSection.Location = new System.Drawing.Point(17, 70);
            this.grpSection.Margin = new System.Windows.Forms.Padding(10, 10, 20, 10);
            this.grpSection.Name = "grpSection";
            this.grpSection.Size = new System.Drawing.Size(568, 170);
            this.grpSection.TabIndex = 44;
            this.grpSection.TabStop = false;
            this.grpSection.Text = "Información de nueva sección";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(202)))), ((int)(((byte)(230)))));
            this.label7.Location = new System.Drawing.Point(311, 93);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(131, 17);
            this.label7.TabIndex = 27;
            this.label7.Text = "Sección Académica";
            // 
            // cmbAcademicSection
            // 
            this.cmbAcademicSection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAcademicSection.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(91)))));
            this.cmbAcademicSection.FormattingEnabled = true;
            this.cmbAcademicSection.ItemHeight = 17;
            this.cmbAcademicSection.Location = new System.Drawing.Point(314, 112);
            this.cmbAcademicSection.Margin = new System.Windows.Forms.Padding(20);
            this.cmbAcademicSection.Name = "cmbAcademicSection";
            this.cmbAcademicSection.Size = new System.Drawing.Size(231, 25);
            this.cmbAcademicSection.TabIndex = 26;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(202)))), ((int)(((byte)(230)))));
            this.label5.Location = new System.Drawing.Point(311, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 17);
            this.label5.TabIndex = 25;
            this.label5.Text = "Especialidad";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(202)))), ((int)(((byte)(230)))));
            this.label6.Location = new System.Drawing.Point(20, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 17);
            this.label6.TabIndex = 24;
            this.label6.Text = "Grado";
            // 
            // cmbSpecialty
            // 
            this.cmbSpecialty.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSpecialty.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(91)))));
            this.cmbSpecialty.FormattingEnabled = true;
            this.cmbSpecialty.ItemHeight = 17;
            this.cmbSpecialty.Location = new System.Drawing.Point(314, 47);
            this.cmbSpecialty.Margin = new System.Windows.Forms.Padding(20);
            this.cmbSpecialty.Name = "cmbSpecialty";
            this.cmbSpecialty.Size = new System.Drawing.Size(231, 25);
            this.cmbSpecialty.TabIndex = 22;
            // 
            // cmbGrade
            // 
            this.cmbGrade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGrade.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(91)))));
            this.cmbGrade.FormattingEnabled = true;
            this.cmbGrade.ItemHeight = 17;
            this.cmbGrade.Location = new System.Drawing.Point(23, 47);
            this.cmbGrade.Margin = new System.Windows.Forms.Padding(11);
            this.cmbGrade.Name = "cmbGrade";
            this.cmbGrade.Size = new System.Drawing.Size(260, 25);
            this.cmbGrade.TabIndex = 20;
            // 
            // txtTechnicalGroup
            // 
            this.txtTechnicalGroup.BackColor = System.Drawing.SystemColors.Window;
            this.txtTechnicalGroup.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(202)))), ((int)(((byte)(230)))));
            this.txtTechnicalGroup.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtTechnicalGroup.BorderRadius = 18;
            this.txtTechnicalGroup.BorderSize = 2;
            this.txtTechnicalGroup.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTechnicalGroup.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(202)))), ((int)(((byte)(230)))));
            this.txtTechnicalGroup.Location = new System.Drawing.Point(23, 93);
            this.txtTechnicalGroup.Margin = new System.Windows.Forms.Padding(20, 10, 20, 20);
            this.txtTechnicalGroup.MaxLength = 12;
            this.txtTechnicalGroup.Multiline = false;
            this.txtTechnicalGroup.Name = "txtTechnicalGroup";
            this.txtTechnicalGroup.Padding = new System.Windows.Forms.Padding(20, 13, 15, 15);
            this.txtTechnicalGroup.PasswordChar = false;
            this.txtTechnicalGroup.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtTechnicalGroup.PlaceholderText = "";
            this.txtTechnicalGroup.Size = new System.Drawing.Size(260, 46);
            this.txtTechnicalGroup.TabIndex = 19;
            this.txtTechnicalGroup.Texts = "Grupo técnico";
            this.txtTechnicalGroup.UnderlinedStyle = false;
            // 
            // lblSection
            // 
            this.lblSection.AutoSize = true;
            this.lblSection.Font = new System.Drawing.Font("Century Gothic", 23.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSection.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(202)))), ((int)(((byte)(230)))));
            this.lblSection.Location = new System.Drawing.Point(10, 13);
            this.lblSection.Margin = new System.Windows.Forms.Padding(10);
            this.lblSection.Name = "lblSection";
            this.lblSection.Size = new System.Drawing.Size(271, 37);
            this.lblSection.TabIndex = 43;
            this.lblSection.Text = "Agregar Sección";
            // 
            // tabAcademicLevel
            // 
            this.tabAcademicLevel.Controls.Add(this.tabPageSection);
            this.tabAcademicLevel.Controls.Add(this.tabPageSpecialty);
            this.tabAcademicLevel.Controls.Add(this.tabPageAcademicSection);
            this.tabAcademicLevel.Controls.Add(this.tabPageGrade);
            this.tabAcademicLevel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabAcademicLevel.Location = new System.Drawing.Point(0, 0);
            this.tabAcademicLevel.Margin = new System.Windows.Forms.Padding(0);
            this.tabAcademicLevel.Name = "tabAcademicLevel";
            this.tabAcademicLevel.Padding = new System.Drawing.Point(20, 10);
            this.tabAcademicLevel.SelectedIndex = 0;
            this.tabAcademicLevel.Size = new System.Drawing.Size(620, 360);
            this.tabAcademicLevel.TabIndex = 3;
            this.tabAcademicLevel.Tag = "";
            // 
            // FrmAddUpdateSection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(618, 357);
            this.Controls.Add(this.tabAcademicLevel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmAddUpdateSection";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.tabPageGrade.ResumeLayout(false);
            this.tabPageGrade.PerformLayout();
            this.grpGrade.ResumeLayout(false);
            this.tabPageAcademicSection.ResumeLayout(false);
            this.tabPageAcademicSection.PerformLayout();
            this.grpAcademicSection.ResumeLayout(false);
            this.tabPageSpecialty.ResumeLayout(false);
            this.tabPageSpecialty.PerformLayout();
            this.grpSpecialty.ResumeLayout(false);
            this.tabPageSection.ResumeLayout(false);
            this.tabPageSection.PerformLayout();
            this.grpSection.ResumeLayout(false);
            this.grpSection.PerformLayout();
            this.tabAcademicLevel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.TabPage tabPageSection;
        public System.Windows.Forms.TabControl tabAcademicLevel;
        public CustomControls.RJButton btnUpdateGrade;
        public CustomControls.RJButton btnAddGrade;
        private System.Windows.Forms.GroupBox grpGrade;
        public CustomControls.CustomTextBox txtGrade;
        public CustomControls.RJButton btnUpdateSpecialty;
        public CustomControls.RJButton btnAddSpecialty;
        private System.Windows.Forms.GroupBox grpSpecialty;
        public CustomControls.CustomTextBox txtSpecialty;
        public CustomControls.RJButton btnUpdateAcademicSection;
        public CustomControls.RJButton btnAddAcademicSection;
        private System.Windows.Forms.GroupBox grpAcademicSection;
        public CustomControls.CustomTextBox txtAcademicSection;
        public CustomControls.RJButton btnUpdateSection;
        public CustomControls.RJButton btnAddSection;
        private System.Windows.Forms.GroupBox grpSection;
        public CustomControls.CustomTextBox txtTechnicalGroup;
        public System.Windows.Forms.ComboBox cmbGrade;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.ComboBox cmbSpecialty;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.ComboBox cmbAcademicSection;
        public System.Windows.Forms.TabPage tabPageGrade;
        public System.Windows.Forms.TabPage tabPageSpecialty;
        public System.Windows.Forms.TabPage tabPageAcademicSection;
        public System.Windows.Forms.Label lblGrade;
        public System.Windows.Forms.Label lblAcademicSection;
        public System.Windows.Forms.Label lblSpecialty;
        public System.Windows.Forms.Label lblSection;
        public System.Windows.Forms.Button btnExitE;
        public System.Windows.Forms.Button btnExitS;
        public System.Windows.Forms.Button btnExitG;
        public System.Windows.Forms.Button btnExitSA;
    }
}