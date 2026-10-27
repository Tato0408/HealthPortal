namespace HealthPortal.View.PatientAdministration
{
    partial class FrmAddUpdatePatient
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAddUpdatePatient));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbRole = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtObservations = new CustomControls.CustomTextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cmbMedicamentoRegistro = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.dtpRegisterTime = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.dtpRegisterDate = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.txtIdPerson = new System.Windows.Forms.ToolStripTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPersona = new CustomControls.CustomTextBox();
            this.txtPatientLastName = new CustomControls.CustomTextBox();
            this.btnAddPatient = new CustomControls.RJButton();
            this.btnUpdate = new CustomControls.RJButton();
            this.txtPatientName = new CustomControls.CustomTextBox();
            this.btnExitE = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.groupStudent.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(202)))), ((int)(((byte)(230)))));
            this.label1.Location = new System.Drawing.Point(12, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(324, 50);
            this.label1.TabIndex = 3;
            this.label1.Text = "Ingreso de visitas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(30, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 28);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nombres";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(518, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 28);
            this.label3.TabIndex = 5;
            this.label3.Text = "Rol";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmbRole
            // 
            this.cmbRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRole.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbRole.FormattingEnabled = true;
            this.cmbRole.Location = new System.Drawing.Point(523, 134);
            this.cmbRole.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbRole.Name = "cmbRole";
            this.cmbRole.Size = new System.Drawing.Size(239, 31);
            this.cmbRole.TabIndex = 2;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtObservations);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.cmbMedicamentoRegistro);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.dtpRegisterTime);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.dtpRegisterDate);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.GrayText;
            this.groupBox2.Location = new System.Drawing.Point(20, 414);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(768, 369);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Visita";
            // 
            // txtObservations
            // 
            this.txtObservations.BackColor = System.Drawing.SystemColors.Window;
            this.txtObservations.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtObservations.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtObservations.BorderRadius = 20;
            this.txtObservations.BorderSize = 1;
            this.txtObservations.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtObservations.Location = new System.Drawing.Point(16, 146);
            this.txtObservations.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtObservations.MaxLength = 100;
            this.txtObservations.Multiline = true;
            this.txtObservations.Name = "txtObservations";
            this.txtObservations.Padding = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtObservations.PasswordChar = false;
            this.txtObservations.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtObservations.PlaceholderText = "";
            this.txtObservations.SelectionLength = 0;
            this.txtObservations.SelectionStart = 0;
            this.txtObservations.Size = new System.Drawing.Size(727, 198);
            this.txtObservations.TabIndex = 12;
            this.txtObservations.Texts = "";
            this.txtObservations.UnderlinedStyle = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label11.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label11.Location = new System.Drawing.Point(11, 106);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(139, 28);
            this.label11.TabIndex = 21;
            this.label11.Text = "Observaciones";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmbMedicamentoRegistro
            // 
            this.cmbMedicamentoRegistro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMedicamentoRegistro.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbMedicamentoRegistro.FormattingEnabled = true;
            this.cmbMedicamentoRegistro.ItemHeight = 23;
            this.cmbMedicamentoRegistro.Location = new System.Drawing.Point(523, 58);
            this.cmbMedicamentoRegistro.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbMedicamentoRegistro.Name = "cmbMedicamentoRegistro";
            this.cmbMedicamentoRegistro.Size = new System.Drawing.Size(224, 31);
            this.cmbMedicamentoRegistro.TabIndex = 18;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label10.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label10.Location = new System.Drawing.Point(517, 28);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(133, 28);
            this.label10.TabIndex = 20;
            this.label10.Text = "Medicamento";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dtpRegisterTime
            // 
            this.dtpRegisterTime.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpRegisterTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpRegisterTime.Location = new System.Drawing.Point(373, 59);
            this.dtpRegisterTime.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpRegisterTime.Name = "dtpRegisterTime";
            this.dtpRegisterTime.Size = new System.Drawing.Size(112, 30);
            this.dtpRegisterTime.TabIndex = 10;
            this.dtpRegisterTime.Value = new System.DateTime(2024, 6, 24, 12, 39, 57, 0);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label9.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label9.Location = new System.Drawing.Point(369, 28);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 28);
            this.label9.TabIndex = 18;
            this.label9.Text = "Hora";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dtpRegisterDate
            // 
            this.dtpRegisterDate.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpRegisterDate.Location = new System.Drawing.Point(16, 59);
            this.dtpRegisterDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpRegisterDate.Name = "dtpRegisterDate";
            this.dtpRegisterDate.Size = new System.Drawing.Size(331, 30);
            this.dtpRegisterDate.TabIndex = 9;
            this.dtpRegisterDate.Value = new System.DateTime(2024, 7, 18, 0, 0, 0, 0);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label8.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label8.Location = new System.Drawing.Point(11, 28);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 28);
            this.label8.TabIndex = 16;
            this.label8.Text = "Fecha";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label12.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label12.Location = new System.Drawing.Point(27, 179);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(94, 28);
            this.label12.TabIndex = 22;
            this.label12.Text = "Apellidos";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.groupStudent.Location = new System.Drawing.Point(21, 278);
            this.groupStudent.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupStudent.Name = "groupStudent";
            this.groupStudent.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupStudent.Size = new System.Drawing.Size(768, 121);
            this.groupStudent.TabIndex = 17;
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
            this.menuStrip1.TabIndex = 24;
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
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label6.Location = new System.Drawing.Point(357, 52);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 20);
            this.label6.TabIndex = 27;
            this.label6.Text = "Atendido Por:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtPersona
            // 
            this.txtPersona.BackColor = System.Drawing.SystemColors.Window;
            this.txtPersona.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtPersona.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtPersona.BorderRadius = 0;
            this.txtPersona.BorderSize = 1;
            this.txtPersona.Enabled = false;
            this.txtPersona.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPersona.Location = new System.Drawing.Point(463, 40);
            this.txtPersona.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPersona.MaxLength = 32767;
            this.txtPersona.Multiline = false;
            this.txtPersona.Name = "txtPersona";
            this.txtPersona.Padding = new System.Windows.Forms.Padding(11, 7, 11, 7);
            this.txtPersona.PasswordChar = false;
            this.txtPersona.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtPersona.PlaceholderText = "";
            this.txtPersona.SelectionLength = 0;
            this.txtPersona.SelectionStart = 0;
            this.txtPersona.Size = new System.Drawing.Size(253, 37);
            this.txtPersona.TabIndex = 25;
            this.txtPersona.Texts = "";
            this.txtPersona.UnderlinedStyle = true;
            // 
            // txtPatientLastName
            // 
            this.txtPatientLastName.BackColor = System.Drawing.SystemColors.Window;
            this.txtPatientLastName.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtPatientLastName.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtPatientLastName.BorderRadius = 20;
            this.txtPatientLastName.BorderSize = 1;
            this.txtPatientLastName.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtPatientLastName.Location = new System.Drawing.Point(32, 210);
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
            this.txtPatientLastName.TabIndex = 3;
            this.txtPatientLastName.Texts = "";
            this.txtPatientLastName.UnderlinedStyle = false;
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
            this.btnAddPatient.Location = new System.Drawing.Point(617, 803);
            this.btnAddPatient.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddPatient.Name = "btnAddPatient";
            this.btnAddPatient.Size = new System.Drawing.Size(148, 44);
            this.btnAddPatient.TabIndex = 19;
            this.btnAddPatient.Text = "Agregar";
            this.btnAddPatient.TextColor = System.Drawing.Color.Black;
            this.btnAddPatient.UseVisualStyleBackColor = false;
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(202)))), ((int)(((byte)(230)))));
            this.btnUpdate.BackGroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(202)))), ((int)(((byte)(230)))));
            this.btnUpdate.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(202)))), ((int)(((byte)(230)))));
            this.btnUpdate.BorderRadius = 40;
            this.btnUpdate.BorderSize = 0;
            this.btnUpdate.Enabled = false;
            this.btnUpdate.FlatAppearance.BorderSize = 0;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.Black;
            this.btnUpdate.Location = new System.Drawing.Point(439, 805);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(156, 42);
            this.btnUpdate.TabIndex = 18;
            this.btnUpdate.Text = "Actualizar";
            this.btnUpdate.TextColor = System.Drawing.Color.Black;
            this.btnUpdate.UseVisualStyleBackColor = false;
            // 
            // txtPatientName
            // 
            this.txtPatientName.BackColor = System.Drawing.SystemColors.Window;
            this.txtPatientName.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtPatientName.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtPatientName.BorderRadius = 20;
            this.txtPatientName.BorderSize = 1;
            this.txtPatientName.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtPatientName.Location = new System.Drawing.Point(36, 128);
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
            this.txtPatientName.TabIndex = 1;
            this.txtPatientName.Texts = "";
            this.txtPatientName.UnderlinedStyle = false;
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
            this.btnExitE.Location = new System.Drawing.Point(742, 13);
            this.btnExitE.Margin = new System.Windows.Forms.Padding(4);
            this.btnExitE.Name = "btnExitE";
            this.btnExitE.Size = new System.Drawing.Size(45, 42);
            this.btnExitE.TabIndex = 54;
            this.btnExitE.TabStop = false;
            this.btnExitE.UseVisualStyleBackColor = false;
            // 
            // FrmAddUpdatePatient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(800, 875);
            this.Controls.Add(this.btnExitE);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtPersona);
            this.Controls.Add(this.groupStudent);
            this.Controls.Add(this.txtPatientLastName);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.btnAddPatient);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.cmbRole);
            this.Controls.Add(this.txtPatientName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmAddUpdatePatient";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Nueva visita";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupStudent.ResumeLayout(false);
            this.groupStudent.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        public System.Windows.Forms.ComboBox cmbRole;
        public System.Windows.Forms.ComboBox CmBGradoRegistro;
        public System.Windows.Forms.ComboBox cmbMedicamentoRegistro;
        public System.Windows.Forms.ComboBox cmbSection;
        public CustomControls.CustomTextBox txtPatientName;
        public System.Windows.Forms.ComboBox cmbRegisterSpecialty;
        public CustomControls.CustomTextBox txtPatientCode;
        public CustomControls.CustomTextBox txtObservations;
        public CustomControls.RJButton btnAddPatient;
        public CustomControls.CustomTextBox txtPatientLastName;
        public System.Windows.Forms.DateTimePicker dtpRegisterDate;
        public System.Windows.Forms.DateTimePicker dtpRegisterTime;
        public CustomControls.CustomTextBox txtGrupo;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.GroupBox groupStudent;
        public CustomControls.RJButton btnUpdate;
        private System.Windows.Forms.MenuStrip menuStrip1;
        public System.Windows.Forms.ToolStripTextBox txtIdPerson;
        public System.Windows.Forms.Label label1;
        public CustomControls.CustomTextBox txtPersona;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        public System.Windows.Forms.Button btnExitE;
    }
}