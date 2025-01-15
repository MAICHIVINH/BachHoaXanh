﻿namespace BachHoaXanhNew.Suppliers
{
    partial class FormSuppliers
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
            this.sippliersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2AnimateWindow1 = new Guna.UI2.WinForms.Guna2AnimateWindow(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtNameSearch = new System.Windows.Forms.TextBox();
            this.txtIDSearch = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtgvSuppliers = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnDeleteSippliers = new System.Windows.Forms.Button();
            this.btnUpdateSippliers = new System.Windows.Forms.Button();
            this.btnAddSippliers = new System.Windows.Forms.Button();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.panelBodySupplier = new Guna.UI2.WinForms.Guna2Panel();
            this.PanelBody = new Guna.UI2.WinForms.Guna2Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.sippliersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvSuppliers)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.guna2Panel1.SuspendLayout();
            this.panelBodySupplier.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // sippliersBindingSource
            // 
            this.sippliersBindingSource.DataMember = "Sippliers";
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1693, 74);
            this.label1.TabIndex = 8;
            this.label1.Text = "Quản Lý Nhà Cung Cấp";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.txtNameSearch);
            this.groupBox1.Controls.Add(this.txtIDSearch);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(7, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(642, 177);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm Kiếm";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Location = new System.Drawing.Point(509, 105);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 50);
            this.button1.TabIndex = 4;
            this.button1.Text = "Lọc";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtNameSearch
            // 
            this.txtNameSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNameSearch.Location = new System.Drawing.Point(176, 117);
            this.txtNameSearch.Name = "txtNameSearch";
            this.txtNameSearch.Size = new System.Drawing.Size(316, 34);
            this.txtNameSearch.TabIndex = 3;
            // 
            // txtIDSearch
            // 
            this.txtIDSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIDSearch.Location = new System.Drawing.Point(176, 57);
            this.txtIDSearch.Name = "txtIDSearch";
            this.txtIDSearch.Size = new System.Drawing.Size(316, 34);
            this.txtIDSearch.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(70, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 32);
            this.label3.TabIndex = 1;
            this.label3.Text = "Tên:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(70, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 32);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã:";
            // 
            // dtgvSuppliers
            // 
            this.dtgvSuppliers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvSuppliers.Location = new System.Drawing.Point(7, 221);
            this.dtgvSuppliers.Name = "dtgvSuppliers";
            this.dtgvSuppliers.RowHeadersWidth = 51;
            this.dtgvSuppliers.RowTemplate.Height = 24;
            this.dtgvSuppliers.Size = new System.Drawing.Size(710, 461);
            this.dtgvSuppliers.TabIndex = 3;
            this.dtgvSuppliers.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvSuppliers_CellClick);
            this.dtgvSuppliers.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvSuppliers_CellContentClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnReset);
            this.groupBox2.Controls.Add(this.btnDeleteSippliers);
            this.groupBox2.Controls.Add(this.btnUpdateSippliers);
            this.groupBox2.Controls.Add(this.btnAddSippliers);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(6, 18);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(899, 167);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chức Năng";
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnReset.Location = new System.Drawing.Point(463, 67);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(179, 63);
            this.btnReset.TabIndex = 3;
            this.btnReset.Text = "Tải lại";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset1_Click);
            // 
            // btnDeleteSippliers
            // 
            this.btnDeleteSippliers.BackColor = System.Drawing.Color.Red;
            this.btnDeleteSippliers.Location = new System.Drawing.Point(680, 67);
            this.btnDeleteSippliers.Name = "btnDeleteSippliers";
            this.btnDeleteSippliers.Size = new System.Drawing.Size(179, 63);
            this.btnDeleteSippliers.TabIndex = 2;
            this.btnDeleteSippliers.Text = "Xóa";
            this.btnDeleteSippliers.UseVisualStyleBackColor = false;
            this.btnDeleteSippliers.Click += new System.EventHandler(this.btnDeleteSippliers_Click);
            // 
            // btnUpdateSippliers
            // 
            this.btnUpdateSippliers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnUpdateSippliers.Location = new System.Drawing.Point(254, 67);
            this.btnUpdateSippliers.Name = "btnUpdateSippliers";
            this.btnUpdateSippliers.Size = new System.Drawing.Size(179, 63);
            this.btnUpdateSippliers.TabIndex = 1;
            this.btnUpdateSippliers.Text = "Sửa";
            this.btnUpdateSippliers.UseVisualStyleBackColor = false;
            this.btnUpdateSippliers.Click += new System.EventHandler(this.btnUpdateSippliers_Click);
            // 
            // btnAddSippliers
            // 
            this.btnAddSippliers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnAddSippliers.Location = new System.Drawing.Point(45, 67);
            this.btnAddSippliers.Name = "btnAddSippliers";
            this.btnAddSippliers.Size = new System.Drawing.Size(179, 63);
            this.btnAddSippliers.TabIndex = 0;
            this.btnAddSippliers.Text = "Thêm";
            this.btnAddSippliers.UseVisualStyleBackColor = false;
            this.btnAddSippliers.Click += new System.EventHandler(this.btnAddSippliers_Click);
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Controls.Add(this.dtgvSuppliers);
            this.guna2Panel1.Controls.Add(this.groupBox1);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 74);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(723, 981);
            this.guna2Panel1.TabIndex = 9;
            this.guna2Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.guna2Panel1_Paint);
            // 
            // panelBodySupplier
            // 
            this.panelBodySupplier.Controls.Add(this.PanelBody);
            this.panelBodySupplier.Controls.Add(this.panel1);
            this.panelBodySupplier.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBodySupplier.Location = new System.Drawing.Point(723, 74);
            this.panelBodySupplier.Name = "panelBodySupplier";
            this.panelBodySupplier.Size = new System.Drawing.Size(970, 981);
            this.panelBodySupplier.TabIndex = 10;
            // 
            // PanelBody
            // 
            this.PanelBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelBody.Location = new System.Drawing.Point(0, 222);
            this.PanelBody.Name = "PanelBody";
            this.PanelBody.Size = new System.Drawing.Size(970, 759);
            this.PanelBody.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(970, 222);
            this.panel1.TabIndex = 0;
            // 
            // FormSuppliers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1693, 1055);
            this.Controls.Add(this.panelBodySupplier);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.label1);
            this.Name = "FormSuppliers";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sippliersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvSuppliers)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.guna2Panel1.ResumeLayout(false);
            this.panelBodySupplier.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource sippliersBindingSource;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2AnimateWindow guna2AnimateWindow1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnDeleteSippliers;
        private System.Windows.Forms.Button btnUpdateSippliers;
        private System.Windows.Forms.Button btnAddSippliers;
        private System.Windows.Forms.DataGridView dtgvSuppliers;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtNameSearch;
        private System.Windows.Forms.TextBox txtIDSearch;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2Panel panelBodySupplier;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2Panel PanelBody;
        private System.Windows.Forms.Button btnReset;
    }
}