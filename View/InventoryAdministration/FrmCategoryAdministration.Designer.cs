using System.ComponentModel;
using System.Windows.Forms;

namespace HealthPortal.View.InventoryAdministration
{
    partial class FrmCategoryAdministration
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvCategory = new System.Windows.Forms.DataGridView();
            this.cmsCategoryAdministration = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmsUpdateCategory = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAddCategory = new CustomControls.RJButton();
            this.btnExitCategoryAdministration = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategory)).BeginInit();
            this.cmsCategoryAdministration.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 23.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(202)))), ((int)(((byte)(230)))));
            this.label1.Location = new System.Drawing.Point(24, 24);
            this.label1.Margin = new System.Windows.Forms.Padding(15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(498, 45);
            this.label1.TabIndex = 18;
            this.label1.Text = "Categorías del Inventario";
            // 
            // dgvCategory
            // 
            this.dgvCategory.AllowUserToAddRows = false;
            this.dgvCategory.AllowUserToDeleteRows = false;
            this.dgvCategory.AllowUserToResizeColumns = false;
            this.dgvCategory.AllowUserToResizeRows = false;
            this.dgvCategory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCategory.BackgroundColor = System.Drawing.Color.White;
            this.dgvCategory.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvCategory.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvCategory.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.dgvCategory.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            dataGridViewCellStyle1.NullValue = "-----";
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(202)))), ((int)(((byte)(230)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCategory.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCategory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCategory.ContextMenuStrip = this.cmsCategoryAdministration;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.NullValue = "-----";
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(202)))), ((int)(((byte)(230)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCategory.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvCategory.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.dgvCategory.Location = new System.Drawing.Point(34, 107);
            this.dgvCategory.Margin = new System.Windows.Forms.Padding(0);
            this.dgvCategory.MultiSelect = false;
            this.dgvCategory.Name = "dgvCategory";
            this.dgvCategory.ReadOnly = true;
            this.dgvCategory.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            dataGridViewCellStyle3.NullValue = "-----";
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(202)))), ((int)(((byte)(230)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCategory.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvCategory.RowHeadersVisible = false;
            this.dgvCategory.RowHeadersWidth = 62;
            this.dgvCategory.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvCategory.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvCategory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvCategory.Size = new System.Drawing.Size(579, 379);
            this.dgvCategory.TabIndex = 19;
            this.dgvCategory.TabStop = false;
            // 
            // cmsCategoryAdministration
            // 
            this.cmsCategoryAdministration.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.cmsCategoryAdministration.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmsUpdateCategory});
            this.cmsCategoryAdministration.Name = "cmsCategoryAdministration";
            this.cmsCategoryAdministration.Size = new System.Drawing.Size(222, 62);
            // 
            // cmsUpdateCategory
            // 
            this.cmsUpdateCategory.Image = global::HealthPortal.Properties.Resources.actualizar__1_;
            this.cmsUpdateCategory.Name = "cmsUpdateCategory";
            this.cmsUpdateCategory.Size = new System.Drawing.Size(221, 30);
            this.cmsUpdateCategory.Text = "Actualizar Categoría";
            // 
            // btnAddCategory
            // 
            this.btnAddCategory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(202)))), ((int)(((byte)(230)))));
            this.btnAddCategory.BackGroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(202)))), ((int)(((byte)(230)))));
            this.btnAddCategory.BorderColor = System.Drawing.Color.CornflowerBlue;
            this.btnAddCategory.BorderRadius = 30;
            this.btnAddCategory.BorderSize = 0;
            this.btnAddCategory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddCategory.FlatAppearance.BorderSize = 0;
            this.btnAddCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddCategory.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCategory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(91)))));
            this.btnAddCategory.Location = new System.Drawing.Point(34, 511);
            this.btnAddCategory.Margin = new System.Windows.Forms.Padding(0);
            this.btnAddCategory.Name = "btnAddCategory";
            this.btnAddCategory.Size = new System.Drawing.Size(210, 49);
            this.btnAddCategory.TabIndex = 20;
            this.btnAddCategory.TabStop = false;
            this.btnAddCategory.Text = "Añadir Categoria";
            this.btnAddCategory.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(91)))));
            this.btnAddCategory.UseVisualStyleBackColor = false;
            // 
            // btnExitCategoryAdministration
            // 
            this.btnExitCategoryAdministration.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnExitCategoryAdministration.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExitCategoryAdministration.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnExitCategoryAdministration.FlatAppearance.BorderSize = 0;
            this.btnExitCategoryAdministration.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnExitCategoryAdministration.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnExitCategoryAdministration.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExitCategoryAdministration.ForeColor = System.Drawing.Color.White;
            this.btnExitCategoryAdministration.Image = global::HealthPortal.Properties.Resources.quit;
            this.btnExitCategoryAdministration.Location = new System.Drawing.Point(624, 28);
            this.btnExitCategoryAdministration.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnExitCategoryAdministration.Name = "btnExitCategoryAdministration";
            this.btnExitCategoryAdministration.Size = new System.Drawing.Size(51, 52);
            this.btnExitCategoryAdministration.TabIndex = 55;
            this.btnExitCategoryAdministration.TabStop = false;
            this.btnExitCategoryAdministration.UseVisualStyleBackColor = false;
            // 
            // FrmCategoryAdministration
            // 
            this.ClientSize = new System.Drawing.Size(688, 583);
            this.Controls.Add(this.btnExitCategoryAdministration);
            this.Controls.Add(this.btnAddCategory);
            this.Controls.Add(this.dgvCategory);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmCategoryAdministration";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Administración de Categorias";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategory)).EndInit();
            this.cmsCategoryAdministration.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public DataGridView dgvCategory;
        public CustomControls.RJButton btnAddCategory;
        public ContextMenuStrip cmsCategoryAdministration;
        // private IContainer components;
        public ToolStripMenuItem cmsUpdateCategory;
        public Button btnExitCategoryAdministration;
        private Label label1;
    }
}