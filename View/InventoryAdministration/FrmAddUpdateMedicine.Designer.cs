namespace HealthPortal.View.InventoryAdministration
{
    partial class FrmAddUpdateMedicine
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
            this.label12 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.dtpExpirationDate = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblCategory = new System.Windows.Forms.Label();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.txtID = new System.Windows.Forms.MenuStrip();
            this.dtpEntryTime = new System.Windows.Forms.DateTimePicker();
            this.dtpEntryDate = new System.Windows.Forms.DateTimePicker();
            this.numStock = new System.Windows.Forms.NumericUpDown();
            this.picImage = new System.Windows.Forms.PictureBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.numStockPack = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddCategory = new CustomControls.RJButton();
            this.btnUpdateInventory = new CustomControls.RJButton();
            this.btnAddImage = new CustomControls.RJButton();
            this.btnAddInventory = new CustomControls.RJButton();
            this.txtDescription = new CustomControls.CustomTextBox();
            this.txtMedicineName = new CustomControls.CustomTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numStock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numStockPack)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(158)))), ((int)(((byte)(188)))));
            this.lblTitle.Location = new System.Drawing.Point(14, 9);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(320, 41);
            this.lblTitle.TabIndex = 4;
            this.lblTitle.Text = "Ingreso de Inventario";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label12.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label12.Location = new System.Drawing.Point(433, 273);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(160, 21);
            this.label12.TabIndex = 28;
            this.label12.Text = "Fecha de vencimineto";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(433, 209);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 21);
            this.label3.TabIndex = 25;
            this.label3.Text = "Capsulas por envase";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblName.Location = new System.Drawing.Point(251, 68);
            this.lblName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(192, 21);
            this.lblName.TabIndex = 24;
            this.lblName.Text = "Nombre del Medicamento";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dtpExpirationDate
            // 
            this.dtpExpirationDate.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpExpirationDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpExpirationDate.Location = new System.Drawing.Point(437, 297);
            this.dtpExpirationDate.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.dtpExpirationDate.Name = "dtpExpirationDate";
            this.dtpExpirationDate.Size = new System.Drawing.Size(139, 26);
            this.dtpExpirationDate.TabIndex = 6;
            this.dtpExpirationDate.Value = new System.DateTime(2024, 9, 24, 0, 0, 0, 0);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label4.Location = new System.Drawing.Point(250, 337);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 21);
            this.label4.TabIndex = 31;
            this.label4.Text = "Hora de Ingreso";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label5.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label5.Location = new System.Drawing.Point(250, 275);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 21);
            this.label5.TabIndex = 32;
            this.label5.Text = "Fecha de ingreso";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblDescription.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblDescription.Location = new System.Drawing.Point(17, 400);
            this.lblDescription.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(91, 21);
            this.lblDescription.TabIndex = 35;
            this.lblDescription.Text = "Descripción";
            this.lblDescription.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategory.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblCategory.Location = new System.Drawing.Point(250, 145);
            this.lblCategory.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(201, 21);
            this.lblCategory.TabIndex = 41;
            this.lblCategory.Text = "Categoría del Medicamento";
            this.lblCategory.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmbCategory
            // 
            this.cmbCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.Location = new System.Drawing.Point(255, 168);
            this.cmbCategory.Margin = new System.Windows.Forms.Padding(2);
            this.cmbCategory.MaxLength = 50;
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(251, 28);
            this.cmbCategory.TabIndex = 2;
            // 
            // txtID
            // 
            this.txtID.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.txtID.Location = new System.Drawing.Point(0, 0);
            this.txtID.Name = "txtID";
            this.txtID.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.txtID.Size = new System.Drawing.Size(603, 24);
            this.txtID.TabIndex = 45;
            this.txtID.Text = "menuStrip1";
            // 
            // dtpEntryTime
            // 
            this.dtpEntryTime.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpEntryTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpEntryTime.Location = new System.Drawing.Point(254, 360);
            this.dtpEntryTime.Margin = new System.Windows.Forms.Padding(2);
            this.dtpEntryTime.Name = "dtpEntryTime";
            this.dtpEntryTime.Size = new System.Drawing.Size(146, 25);
            this.dtpEntryTime.TabIndex = 7;
            // 
            // dtpEntryDate
            // 
            this.dtpEntryDate.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpEntryDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpEntryDate.Location = new System.Drawing.Point(255, 297);
            this.dtpEntryDate.Margin = new System.Windows.Forms.Padding(2);
            this.dtpEntryDate.Name = "dtpEntryDate";
            this.dtpEntryDate.Size = new System.Drawing.Size(145, 25);
            this.dtpEntryDate.TabIndex = 5;
            // 
            // numStock
            // 
            this.numStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numStock.Location = new System.Drawing.Point(437, 232);
            this.numStock.Margin = new System.Windows.Forms.Padding(2);
            this.numStock.Name = "numStock";
            this.numStock.Size = new System.Drawing.Size(141, 26);
            this.numStock.TabIndex = 4;
            // 
            // picImage
            // 
            this.picImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picImage.Location = new System.Drawing.Point(21, 68);
            this.picImage.Margin = new System.Windows.Forms.Padding(2);
            this.picImage.Name = "picImage";
            this.picImage.Size = new System.Drawing.Size(210, 226);
            this.picImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picImage.TabIndex = 53;
            this.picImage.TabStop = false;
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
            this.btnExit.Location = new System.Drawing.Point(557, 11);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(34, 34);
            this.btnExit.TabIndex = 54;
            this.btnExit.TabStop = false;
            this.btnExit.UseVisualStyleBackColor = false;
            // 
            // numStockPack
            // 
            this.numStockPack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numStockPack.Location = new System.Drawing.Point(255, 232);
            this.numStockPack.Margin = new System.Windows.Forms.Padding(2);
            this.numStockPack.Name = "numStockPack";
            this.numStockPack.Size = new System.Drawing.Size(144, 26);
            this.numStockPack.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(250, 209);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 21);
            this.label1.TabIndex = 55;
            this.label1.Text = "Número de Envases";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnAddCategory
            // 
            this.btnAddCategory.BackColor = System.Drawing.Color.Gainsboro;
            this.btnAddCategory.BackGroundColor = System.Drawing.Color.Gainsboro;
            this.btnAddCategory.BorderColor = System.Drawing.Color.CornflowerBlue;
            this.btnAddCategory.BorderRadius = 30;
            this.btnAddCategory.BorderSize = 0;
            this.btnAddCategory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddCategory.FlatAppearance.BorderSize = 0;
            this.btnAddCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddCategory.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCategory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(91)))));
            this.btnAddCategory.Location = new System.Drawing.Point(509, 165);
            this.btnAddCategory.Margin = new System.Windows.Forms.Padding(10);
            this.btnAddCategory.Name = "btnAddCategory";
            this.btnAddCategory.Size = new System.Drawing.Size(88, 31);
            this.btnAddCategory.TabIndex = 56;
            this.btnAddCategory.TabStop = false;
            this.btnAddCategory.Text = "Añadir";
            this.btnAddCategory.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(91)))));
            this.btnAddCategory.UseVisualStyleBackColor = false;
            // 
            // btnUpdateInventory
            // 
            this.btnUpdateInventory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnUpdateInventory.BackGroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnUpdateInventory.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(202)))), ((int)(((byte)(230)))));
            this.btnUpdateInventory.BorderRadius = 40;
            this.btnUpdateInventory.BorderSize = 0;
            this.btnUpdateInventory.FlatAppearance.BorderSize = 0;
            this.btnUpdateInventory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateInventory.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateInventory.ForeColor = System.Drawing.Color.Black;
            this.btnUpdateInventory.Location = new System.Drawing.Point(348, 601);
            this.btnUpdateInventory.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnUpdateInventory.Name = "btnUpdateInventory";
            this.btnUpdateInventory.Size = new System.Drawing.Size(110, 32);
            this.btnUpdateInventory.TabIndex = 11;
            this.btnUpdateInventory.Text = "Actualizar";
            this.btnUpdateInventory.TextColor = System.Drawing.Color.Black;
            this.btnUpdateInventory.UseVisualStyleBackColor = false;
            // 
            // btnAddImage
            // 
            this.btnAddImage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(183)))), ((int)(((byte)(3)))));
            this.btnAddImage.BackGroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(183)))), ((int)(((byte)(3)))));
            this.btnAddImage.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(183)))), ((int)(((byte)(3)))));
            this.btnAddImage.BorderRadius = 40;
            this.btnAddImage.BorderSize = 0;
            this.btnAddImage.FlatAppearance.BorderSize = 0;
            this.btnAddImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddImage.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddImage.ForeColor = System.Drawing.Color.Black;
            this.btnAddImage.Location = new System.Drawing.Point(21, 297);
            this.btnAddImage.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnAddImage.Name = "btnAddImage";
            this.btnAddImage.Size = new System.Drawing.Size(102, 31);
            this.btnAddImage.TabIndex = 9;
            this.btnAddImage.Text = "Agregar";
            this.btnAddImage.TextColor = System.Drawing.Color.Black;
            this.btnAddImage.UseVisualStyleBackColor = false;
            // 
            // btnAddInventory
            // 
            this.btnAddInventory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(202)))), ((int)(((byte)(230)))));
            this.btnAddInventory.BackGroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(202)))), ((int)(((byte)(230)))));
            this.btnAddInventory.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(202)))), ((int)(((byte)(230)))));
            this.btnAddInventory.BorderRadius = 40;
            this.btnAddInventory.BorderSize = 0;
            this.btnAddInventory.FlatAppearance.BorderSize = 0;
            this.btnAddInventory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddInventory.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddInventory.ForeColor = System.Drawing.Color.Black;
            this.btnAddInventory.Location = new System.Drawing.Point(482, 601);
            this.btnAddInventory.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnAddInventory.Name = "btnAddInventory";
            this.btnAddInventory.Size = new System.Drawing.Size(94, 32);
            this.btnAddInventory.TabIndex = 10;
            this.btnAddInventory.Text = "Agregar";
            this.btnAddInventory.TextColor = System.Drawing.Color.Black;
            this.btnAddInventory.UseVisualStyleBackColor = false;
            // 
            // txtDescription
            // 
            this.txtDescription.BackColor = System.Drawing.SystemColors.Window;
            this.txtDescription.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtDescription.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtDescription.BorderRadius = 20;
            this.txtDescription.BorderSize = 1;
            this.txtDescription.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtDescription.Location = new System.Drawing.Point(17, 424);
            this.txtDescription.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtDescription.MaxLength = 150;
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Padding = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.txtDescription.PasswordChar = false;
            this.txtDescription.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtDescription.PlaceholderText = "";
            this.txtDescription.SelectionLength = 0;
            this.txtDescription.SelectionStart = 0;
            this.txtDescription.Size = new System.Drawing.Size(571, 161);
            this.txtDescription.TabIndex = 8;
            this.txtDescription.Tag = "address";
            this.txtDescription.Texts = "";
            this.txtDescription.UnderlinedStyle = false;
            // 
            // txtMedicineName
            // 
            this.txtMedicineName.BackColor = System.Drawing.SystemColors.Window;
            this.txtMedicineName.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtMedicineName.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtMedicineName.BorderRadius = 15;
            this.txtMedicineName.BorderSize = 1;
            this.txtMedicineName.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtMedicineName.Location = new System.Drawing.Point(254, 92);
            this.txtMedicineName.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtMedicineName.MaxLength = 60;
            this.txtMedicineName.Multiline = false;
            this.txtMedicineName.Name = "txtMedicineName";
            this.txtMedicineName.Padding = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.txtMedicineName.PasswordChar = false;
            this.txtMedicineName.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtMedicineName.PlaceholderText = "";
            this.txtMedicineName.SelectionLength = 0;
            this.txtMedicineName.SelectionStart = 0;
            this.txtMedicineName.Size = new System.Drawing.Size(343, 32);
            this.txtMedicineName.TabIndex = 1;
            this.txtMedicineName.Tag = "name";
            this.txtMedicineName.Texts = "";
            this.txtMedicineName.UnderlinedStyle = false;
            // 
            // FrmAddUpdateMedicine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(603, 658);
            this.Controls.Add(this.btnAddCategory);
            this.Controls.Add(this.numStockPack);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.picImage);
            this.Controls.Add(this.numStock);
            this.Controls.Add(this.dtpEntryTime);
            this.Controls.Add(this.dtpEntryDate);
            this.Controls.Add(this.btnUpdateInventory);
            this.Controls.Add(this.cmbCategory);
            this.Controls.Add(this.lblCategory);
            this.Controls.Add(this.btnAddImage);
            this.Controls.Add(this.btnAddInventory);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtpExpirationDate);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtMedicineName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.txtID);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.txtID;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmAddUpdateMedicine";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FrmAddUpdateMedicine";
            ((System.ComponentModel.ISupportInitialize)(this.numStock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numStockPack)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label12;
        public CustomControls.CustomTextBox txtMedicineName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        public CustomControls.CustomTextBox txtDescription;
        public CustomControls.RJButton btnAddImage;
        public CustomControls.RJButton btnAddInventory;
        public CustomControls.RJButton btnUpdateInventory;
        public System.Windows.Forms.DateTimePicker dtpExpirationDate;
        public System.Windows.Forms.ComboBox cmbCategory;
        public System.Windows.Forms.MenuStrip txtID;
        public System.Windows.Forms.DateTimePicker dtpEntryTime;
        public System.Windows.Forms.DateTimePicker dtpEntryDate;
        public System.Windows.Forms.NumericUpDown numStock;
        public System.Windows.Forms.Label lblTitle;
        public System.Windows.Forms.PictureBox picImage;
        public System.Windows.Forms.Label lblName;
        public System.Windows.Forms.Label lblCategory;
        public System.Windows.Forms.Label lblDescription;
        public System.Windows.Forms.Button btnExit;
        public System.Windows.Forms.NumericUpDown numStockPack;
        private System.Windows.Forms.Label label1;
        public CustomControls.RJButton btnAddCategory;
    }
}