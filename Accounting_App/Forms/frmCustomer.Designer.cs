namespace Accounting_App
{
    partial class frmCustomer
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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnAddCustomer = new System.Windows.Forms.ToolStripButton();
            this.btnEditCustomer = new System.Windows.Forms.ToolStripButton();
            this.btnDeleteCustomer = new System.Windows.Forms.ToolStripButton();
            this.btnRefreshCustomer = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.txtFilter = new System.Windows.Forms.ToolStripTextBox();
            this.dgCustomers = new System.Windows.Forms.DataGridView();
            this.Customer_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fullname_customer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mobile_Customer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email_Customer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fathername = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address_Customer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Image_Customer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgCustomers)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAddCustomer,
            this.btnEditCustomer,
            this.btnDeleteCustomer,
            this.btnRefreshCustomer,
            this.toolStripLabel1,
            this.txtFilter});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(534, 68);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnAddCustomer
            // 
            this.btnAddCustomer.Font = new System.Drawing.Font("Dubai", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCustomer.Image = global::Accounting_App.Properties.Resources._1371475930_filenew;
            this.btnAddCustomer.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnAddCustomer.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAddCustomer.Name = "btnAddCustomer";
            this.btnAddCustomer.Size = new System.Drawing.Size(73, 65);
            this.btnAddCustomer.Text = "شخص جدید";
            this.btnAddCustomer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnAddCustomer.Click += new System.EventHandler(this.btnAddCustomer_Click);
            // 
            // btnEditCustomer
            // 
            this.btnEditCustomer.Font = new System.Drawing.Font("Dubai", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditCustomer.Image = global::Accounting_App.Properties.Resources._1371475973_document_edit;
            this.btnEditCustomer.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnEditCustomer.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEditCustomer.Name = "btnEditCustomer";
            this.btnEditCustomer.Size = new System.Drawing.Size(84, 65);
            this.btnEditCustomer.Text = "ویرایش شخص";
            this.btnEditCustomer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnEditCustomer.Click += new System.EventHandler(this.btnEditCustomer_Click);
            // 
            // btnDeleteCustomer
            // 
            this.btnDeleteCustomer.Font = new System.Drawing.Font("Dubai", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteCustomer.Image = global::Accounting_App.Properties.Resources._1371476007_Close_Box_Red;
            this.btnDeleteCustomer.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnDeleteCustomer.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnDeleteCustomer.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDeleteCustomer.Name = "btnDeleteCustomer";
            this.btnDeleteCustomer.Size = new System.Drawing.Size(74, 65);
            this.btnDeleteCustomer.Text = "حذف شخص";
            this.btnDeleteCustomer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnDeleteCustomer.Click += new System.EventHandler(this.btnDeleteCustomer_Click);
            // 
            // btnRefreshCustomer
            // 
            this.btnRefreshCustomer.Font = new System.Drawing.Font("Dubai", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefreshCustomer.Image = global::Accounting_App.Properties.Resources._1371476368_Synchronize;
            this.btnRefreshCustomer.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnRefreshCustomer.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnRefreshCustomer.Name = "btnRefreshCustomer";
            this.btnRefreshCustomer.Size = new System.Drawing.Size(72, 65);
            this.btnRefreshCustomer.Text = "به روز رسانی";
            this.btnRefreshCustomer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnRefreshCustomer.Click += new System.EventHandler(this.btnRefreshCustomer_Click);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Font = new System.Drawing.Font("Dubai", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(44, 65);
            this.toolStripLabel1.Text = "جستجو";
            // 
            // txtFilter
            // 
            this.txtFilter.Font = new System.Drawing.Font("Dubai", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFilter.Name = "txtFilter";
            this.txtFilter.Size = new System.Drawing.Size(100, 68);
            this.txtFilter.TextChanged += new System.EventHandler(this.txtFilter_TextChanged);
            // 
            // dgCustomers
            // 
            this.dgCustomers.AllowUserToAddRows = false;
            this.dgCustomers.AllowUserToDeleteRows = false;
            this.dgCustomers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgCustomers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Customer_id,
            this.Fullname_customer,
            this.Mobile_Customer,
            this.Email_Customer,
            this.Fathername,
            this.Address_Customer,
            this.Image_Customer});
            this.dgCustomers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgCustomers.Location = new System.Drawing.Point(0, 68);
            this.dgCustomers.Name = "dgCustomers";
            this.dgCustomers.ReadOnly = true;
            this.dgCustomers.Size = new System.Drawing.Size(534, 243);
            this.dgCustomers.TabIndex = 1;
            // 
            // Customer_id
            // 
            this.Customer_id.DataPropertyName = "id";
            this.Customer_id.HeaderText = "ID";
            this.Customer_id.Name = "Customer_id";
            this.Customer_id.ReadOnly = true;
            this.Customer_id.Visible = false;
            // 
            // Fullname_customer
            // 
            this.Fullname_customer.DataPropertyName = "fullname";
            this.Fullname_customer.HeaderText = "نام و نام خانوادگی";
            this.Fullname_customer.Name = "Fullname_customer";
            this.Fullname_customer.ReadOnly = true;
            // 
            // Mobile_Customer
            // 
            this.Mobile_Customer.DataPropertyName = "mobile";
            this.Mobile_Customer.HeaderText = "موبایل";
            this.Mobile_Customer.Name = "Mobile_Customer";
            this.Mobile_Customer.ReadOnly = true;
            // 
            // Email_Customer
            // 
            this.Email_Customer.DataPropertyName = "email";
            this.Email_Customer.HeaderText = "ایمیل";
            this.Email_Customer.Name = "Email_Customer";
            this.Email_Customer.ReadOnly = true;
            // 
            // Fathername
            // 
            this.Fathername.DataPropertyName = "fathername";
            this.Fathername.HeaderText = "نام پدر";
            this.Fathername.Name = "Fathername";
            this.Fathername.ReadOnly = true;
            // 
            // Address_Customer
            // 
            this.Address_Customer.DataPropertyName = "address";
            this.Address_Customer.HeaderText = "آدرس";
            this.Address_Customer.Name = "Address_Customer";
            this.Address_Customer.ReadOnly = true;
            // 
            // Image_Customer
            // 
            this.Image_Customer.DataPropertyName = "customer_image";
            this.Image_Customer.HeaderText = "عکس";
            this.Image_Customer.Name = "Image_Customer";
            this.Image_Customer.ReadOnly = true;
            this.Image_Customer.Visible = false;
            // 
            // frmCustomer
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(534, 311);
            this.Controls.Add(this.dgCustomers);
            this.Controls.Add(this.toolStrip1);
            this.Font = new System.Drawing.Font("Dubai", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmCustomer";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "لیست اشخاص";
            this.Activated += new System.EventHandler(this.frmCustomer_Activated);
            this.Load += new System.EventHandler(this.frmCustomer_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgCustomers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnAddCustomer;
        private System.Windows.Forms.ToolStripButton btnEditCustomer;
        private System.Windows.Forms.ToolStripButton btnDeleteCustomer;
        private System.Windows.Forms.ToolStripButton btnRefreshCustomer;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripTextBox txtFilter;
        private System.Windows.Forms.DataGridView dgCustomers;
        private System.Windows.Forms.DataGridViewTextBoxColumn Customer_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fullname_customer;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mobile_Customer;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email_Customer;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fathername;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address_Customer;
        private System.Windows.Forms.DataGridViewTextBoxColumn Image_Customer;
    }
}