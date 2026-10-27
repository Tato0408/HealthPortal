namespace HealthPortal.View.PatientAdministration
{
    partial class FrmViewPatientInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmViewPatientInfo));
            this.groupStudent = new System.Windows.Forms.GroupBox();
            this.txtGrupo = new CustomControls.CustomTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.cmbRegisterSpecialty = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.txtPatientCode = new CustomControls.CustomTextBox();
            this.CmBGradoRegistro = new System.Windows.Forms.ComboBox();
            this.cmbSection = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.cmbRole = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.txtIdPerson = new System.Windows.Forms.ToolStripTextBox();
            this.btnUpdate = new CustomControls.RJButton();
            this.txtPatientLastName = new CustomControls.CustomTextBox();
            this.txtPatientName = new CustomControls.CustomTextBox();
            this.btnAddPatient = new CustomControls.RJButton();
            this.btnInsertRol = new CustomControls.RJButton();
            this.btnExitE = new System.Windows.Forms.Button();
            this.groupStudent.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupStudent
            // 
            this.groupStudent.Controls.Add(this.txtGrupo);
            this.groupStudent.Controls.Add(this.label5);
            this.groupStudent.Controls.Add(this.label13);
            this.groupStudent.Controls.Add(this.cmbRegisterSpecialty);
            this.groupStudent.Controls.Add(this.label14);
            this.groupStudent.Controls.Add(this.label15);
            this.groupStudent.Controls.Add(this.txtPatientCode);
            this.groupStudent.Controls.Add(this.CmBGradoRegistro);
            this.groupStudent.Controls.Add(this.cmbSection);
            this.groupStudent.Controls.Add(this.label16);
            this.groupStudent.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupStudent.ForeColor = System.Drawing.SystemColors.GrayText;
            this.groupStudent.Location = new System.Drawing.Point(16, 254);
            this.groupStudent.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupStudent.Name = "groupStudent";
            this.groupStudent.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupStudent.Size = new System.Drawing.Size(768, 121);
            this.groupStudent.TabIndex = 28;
            this.groupStudent.TabStop = false;
            this.groupStudent.Text = "Datos Académicos";
            // 
            // txtGrupo
            // 
            this.txtGrupo.BackColor = System.Drawing.SystemColors.Window;
            this.txtGrupo.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtGrupo.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtGrupo.BorderRadius = 0;
            this.txtGrupo.BorderSize = 1;
            this.txtGrupo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtGrupo.Location = new System.Drawing.Point(391, 58);
            this.txtGrupo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtGrupo.MaxLength = 7;
            this.txtGrupo.Multiline = false;
            this.txtGrupo.Name = "txtGrupo";
            this.txtGrupo.Padding = new System.Windows.Forms.Padding(11, 7, 11, 7);
            this.txtGrupo.PasswordChar = false;
            this.txtGrupo.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtGrupo.PlaceholderText = "";
            this.txtGrupo.SelectionLength = 0;
            this.txtGrupo.SelectionStart = 0;
            this.txtGrupo.Size = new System.Drawing.Size(105, 44);
            this.txtGrupo.TabIndex = 6;
            this.txtGrupo.Texts = "";
            this.txtGrupo.UnderlinedStyle = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label5.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label5.Location = new System.Drawing.Point(392, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 28);
            this.label5.TabIndex = 16;
            this.label5.Text = "Grupo";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label13.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label13.Location = new System.Drawing.Point(644, 32);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(79, 28);
            this.label13.TabIndex = 10;
            this.label13.Text = "Sección";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmbRegisterSpecialty
            // 
            this.cmbRegisterSpecialty.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRegisterSpecialty.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbRegisterSpecialty.FormattingEnabled = true;
            this.cmbRegisterSpecialty.Location = new System.Drawing.Point(173, 60);
            this.cmbRegisterSpecialty.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbRegisterSpecialty.Name = "cmbRegisterSpecialty";
            this.cmbRegisterSpecialty.Size = new System.Drawing.Size(199, 31);
            this.cmbRegisterSpecialty.TabIndex = 5;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label14.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label14.Location = new System.Drawing.Point(8, 25);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(77, 28);
            this.label14.TabIndex = 8;
            this.label14.Text = "Código";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label15.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label15.Location = new System.Drawing.Point(168, 27);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(120, 28);
            this.label15.TabIndex = 14;
            this.label15.Text = "Especialidad";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtPatientCode
            // 
            this.txtPatientCode.BackColor = System.Drawing.SystemColors.Window;
            this.txtPatientCode.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtPatientCode.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtPatientCode.BorderRadius = 20;
            this.txtPatientCode.BorderSize = 1;
            this.txtPatientCode.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtPatientCode.Location = new System.Drawing.Point(13, 57);
            this.txtPatientCode.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPatientCode.MaxLength = 8;
            this.txtPatientCode.Multiline = false;
            this.txtPatientCode.Name = "txtPatientCode";
            this.txtPatientCode.Padding = new System.Windows.Forms.Padding(11, 7, 11, 7);
            this.txtPatientCode.PasswordChar = false;
            this.txtPatientCode.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtPatientCode.PlaceholderText = "";
            this.txtPatientCode.SelectionLength = 0;
            this.txtPatientCode.SelectionStart = 0;
            this.txtPatientCode.Size = new System.Drawing.Size(139, 44);
            this.txtPatientCode.TabIndex = 4;
            this.txtPatientCode.Texts = "";
            this.txtPatientCode.UnderlinedStyle = false;
            // 
            // CmBGradoRegistro
            // 
            this.CmBGradoRegistro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmBGradoRegistro.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmBGradoRegistro.FormattingEnabled = true;
            this.CmBGradoRegistro.Location = new System.Drawing.Point(523, 63);
            this.CmBGradoRegistro.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CmBGradoRegistro.Name = "CmBGradoRegistro";
            this.CmBGradoRegistro.Size = new System.Drawing.Size(111, 31);
            this.CmBGradoRegistro.TabIndex = 7;
            // 
            // cmbSection
            // 
            this.cmbSection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSection.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSection.FormattingEnabled = true;
            this.cmbSection.Location = new System.Drawing.Point(649, 63);
            this.cmbSection.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbSection.Name = "cmbSection";
            this.cmbSection.Size = new System.Drawing.Size(95, 31);
            this.cmbSection.TabIndex = 8;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label16.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label16.Location = new System.Drawing.Point(520, 30);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(67, 28);
            this.label16.TabIndex = 12;
            this.label16.Text = "Grado";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label12.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label12.Location = new System.Drawing.Point(23, 158);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(94, 28);
            this.label12.TabIndex = 29;
            this.label12.Text = "Apellidos";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmbRole
            // 
            this.cmbRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRole.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbRole.FormattingEnabled = true;
            this.cmbRole.Location = new System.Drawing.Point(528, 111);
            this.cmbRole.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbRole.Name = "cmbRole";
            this.cmbRole.Size = new System.Drawing.Size(156, 31);
            this.cmbRole.TabIndex = 24;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(523, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 28);
            this.label3.TabIndex = 27;
            this.label3.Text = "Rol";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(27, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 28);
            this.label2.TabIndex = 26;
            this.label2.Text = "Nombres";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(202)))), ((int)(((byte)(230)))));
            this.label1.Location = new System.Drawing.Point(23, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 50);
            this.label1.TabIndex = 17;
            this.label1.Text = "Paciente";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripTextBox1,
            this.txtIdPerson});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(800, 31);
            this.menuStrip1.TabIndex = 30;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.Visible = false;
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(132, 27);
            // 
            // txtIdPerson
            // 
            this.txtIdPerson.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtIdPerson.Name = "txtIdPerson";
            this.txtIdPerson.Size = new System.Drawing.Size(132, 27);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(202)))), ((int)(((byte)(230)))));
            this.btnUpdate.BackGroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(202)))), ((int)(((byte)(230)))));
            this.btnUpdate.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(202)))), ((int)(((byte)(230)))));
            this.btnUpdate.BorderRadius = 40;
            this.btnUpdate.BorderSize = 0;
            this.btnUpdate.FlatAppearance.BorderSize = 0;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.Black;
            this.btnUpdate.Location = new System.Drawing.Point(475, 389);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(156, 42);
            this.btnUpdate.TabIndex = 31;
            this.btnUpdate.Text = "Actualizar";
            this.btnUpdate.TextColor = System.Drawing.Color.Black;
            this.btnUpdate.UseVisualStyleBackColor = false;
            // 
            // txtPatientLastName
            // 
            this.txtPatientLastName.BackColor = System.Drawing.SystemColors.Window;
            this.txtPatientLastName.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtPatientLastName.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtPatientLastName.BorderRadius = 20;
            this.txtPatientLastName.BorderSize = 1;
            this.txtPatientLastName.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtPatientLastName.Location = new System.Drawing.Point(28, 190);
            this.txtPatientLastName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPatientLastName.MaxLength = 60;
            this.txtPatientLastName.Multiline = false;
            this.txtPatientLastName.Name = "txtPatientLastName";
            this.txtPatientLastName.Padding = new System.Windows.Forms.Padding(11, 7, 11, 7);
            this.txtPatientLastName.PasswordChar = false;
            this.txtPatientLastName.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtPatientLastName.PlaceholderText = "";
            this.txtPatientLastName.SelectionLength = 0;
            this.txtPatientLastName.SelectionStart = 0;
            this.txtPatientLastName.Size = new System.Drawing.Size(731, 44);
            this.txtPatientLastName.TabIndex = 25;
            this.txtPatientLastName.Texts = "";
            this.txtPatientLastName.UnderlinedStyle = false;
            // 
            // txtPatientName
            // 
            this.txtPatientName.BackColor = System.Drawing.SystemColors.Window;
            this.txtPatientName.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtPatientName.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtPatientName.BorderRadius = 20;
            this.txtPatientName.BorderSize = 1;
            this.txtPatientName.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtPatientName.Location = new System.Drawing.Point(32, 106);
            this.txtPatientName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPatientName.MaxLength = 60;
            this.txtPatientName.Multiline = false;
            this.txtPatientName.Name = "txtPatientName";
            this.txtPatientName.Padding = new System.Windows.Forms.Padding(11, 7, 11, 7);
            this.txtPatientName.PasswordChar = false;
            this.txtPatientName.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtPatientName.PlaceholderText = "";
            this.txtPatientName.SelectionLength = 0;
            this.txtPatientName.SelectionStart = 0;
            this.txtPatientName.Size = new System.Drawing.Size(471, 44);
            this.txtPatientName.TabIndex = 23;
            this.txtPatientName.Texts = "";
            this.txtPatientName.UnderlinedStyle = false;
            // 
            // btnAddPatient
            // 
            this.btnAddPatient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(183)))), ((int)(((byte)(3)))));
            this.btnAddPatient.BackGroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(183)))), ((int)(((byte)(3)))));
            this.btnAddPatient.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(183)))), ((int)(((byte)(3)))));
            this.btnAddPatient.BorderRadius = 40;
            this.btnAddPatient.BorderSize = 0;
            this.btnAddPatient.Enabled = false;
            this.btnAddPatient.FlatAppearance.BorderSize = 0;
            this.btnAddPatient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddPatient.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddPatient.ForeColor = System.Drawing.Color.Black;
            this.btnAddPatient.Location = new System.Drawing.Point(636, 388);
            this.btnAddPatient.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddPatient.Name = "btnAddPatient";
            this.btnAddPatient.Size = new System.Drawing.Size(148, 44);
            this.btnAddPatient.TabIndex = 33;
            this.btnAddPatient.Text = "Agregar";
            this.btnAddPatient.TextColor = System.Drawing.Color.Black;
            this.btnAddPatient.UseVisualStyleBackColor = false;
            // 
            // btnInsertRol
            // 
            this.btnInsertRol.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(202)))), ((int)(((byte)(230)))));
            this.btnInsertRol.BackGroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(202)))), ((int)(((byte)(230)))));
            this.btnInsertRol.BorderColor = System.Drawing.Color.CornflowerBlue;
            this.btnInsertRol.BorderRadius = 40;
            this.btnInsertRol.BorderSize = 0;
            this.btnInsertRol.FlatAppearance.BorderSize = 0;
            this.btnInsertRol.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInsertRol.ForeColor = System.Drawing.Color.Black;
            this.btnInsertRol.Location = new System.Drawing.Point(697, 106);
            this.btnInsertRol.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnInsertRol.Name = "btnInsertRol";
            this.btnInsertRol.Size = new System.Drawing.Size(87, 42);
            this.btnInsertRol.TabIndex = 34;
            this.btnInsertRol.Text = "Añadir";
            this.btnInsertRol.TextColor = System.Drawing.Color.Black;
            this.btnInsertRol.UseVisualStyleBackColor = false;
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
            this.btnExitE.Location = new System.Drawing.Point(739, 13);
            this.btnExitE.Margin = new System.Windows.Forms.Padding(4);
            this.btnExitE.Name = "btnExitE";
            this.btnExitE.Size = new System.Drawing.Size(45, 42);
            this.btnExitE.TabIndex = 54;
            this.btnExitE.TabStop = false;
            this.btnExitE.UseVisualStyleBackColor = false;
            // 
            // FrmViewPatientInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(811, 453);
            this.Controls.Add(this.btnExitE);
            this.Controls.Add(this.btnInsertRol);
            this.Controls.Add(this.btnAddPatient);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupStudent);
            this.Controls.Add(this.txtPatientLastName);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.cmbRole);
            this.Controls.Add(this.txtPatientName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmViewPatientInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro de pacientes";
            this.groupStudent.ResumeLayout(false);
            this.groupStudent.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.GroupBox groupStudent;
        public CustomControls.CustomTextBox txtGrupo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label13;
        public System.Windows.Forms.ComboBox cmbRegisterSpecialty;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        public CustomControls.CustomTextBox txtPatientCode;
        public System.Windows.Forms.ComboBox CmBGradoRegistro;
        public System.Windows.Forms.ComboBox cmbSection;
        private System.Windows.Forms.Label label16;
        public CustomControls.CustomTextBox txtPatientLastName;
        private System.Windows.Forms.Label label12;
        public System.Windows.Forms.ComboBox cmbRole;
        public CustomControls.CustomTextBox txtPatientName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        public System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        public System.Windows.Forms.ToolStripTextBox txtIdPerson;
        public CustomControls.RJButton btnUpdate;
        public CustomControls.RJButton btnAddPatient;
        public CustomControls.RJButton btnInsertRol;
        public System.Windows.Forms.Button btnExitE;
    }
}