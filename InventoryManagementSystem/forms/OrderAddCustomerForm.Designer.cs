namespace InventoryManagementSystem.Forms
{
    partial class OrderAddCustomerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrderAddCustomerForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pbClose = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dgCustomer = new System.Windows.Forms.DataGridView();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbCustomerName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbCustomerId = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbSearchCustomer = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.bOrderClear = new System.Windows.Forms.Button();
            this.bOrderSave = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgCustomer)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Red;
            this.panel1.Controls.Add(this.pbClose);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(567, 68);
            this.panel1.TabIndex = 15;
            // 
            // pbClose
            // 
            this.pbClose.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbClose.Image = ((System.Drawing.Image)(resources.GetObject("pbClose.Image")));
            this.pbClose.Location = new System.Drawing.Point(541, 3);
            this.pbClose.Name = "pbClose";
            this.pbClose.Size = new System.Drawing.Size(20, 20);
            this.pbClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbClose.TabIndex = 10;
            this.pbClose.TabStop = false;
            this.pbClose.Click += new System.EventHandler(this.pbClose_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(171, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(237, 34);
            this.label2.TabIndex = 20;
            this.label2.Text = "Select Customer";
            // 
            // dgCustomer
            // 
            this.dgCustomer.AllowUserToAddRows = false;
            this.dgCustomer.BackgroundColor = System.Drawing.Color.White;
            this.dgCustomer.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(100)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgCustomer.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgCustomer.ColumnHeadersHeight = 29;
            this.dgCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgCustomer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column7,
            this.CustomerId,
            this.CustomerName,
            this.CustomerPhone});
            this.dgCustomer.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgCustomer.EnableHeadersVisualStyles = false;
            this.dgCustomer.Location = new System.Drawing.Point(0, 68);
            this.dgCustomer.Name = "dgCustomer";
            this.dgCustomer.RowHeadersVisible = false;
            this.dgCustomer.RowHeadersWidth = 51;
            this.dgCustomer.RowTemplate.Height = 24;
            this.dgCustomer.Size = new System.Drawing.Size(567, 216);
            this.dgCustomer.TabIndex = 19;
            this.dgCustomer.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgCustomer_CellClick);
            // 
            // Column7
            // 
            this.Column7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column7.HeaderText = "No";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            this.Column7.Width = 61;
            // 
            // CustomerId
            // 
            this.CustomerId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.CustomerId.HeaderText = "Customer ID";
            this.CustomerId.MinimumWidth = 6;
            this.CustomerId.Name = "CustomerId";
            this.CustomerId.Width = 140;
            // 
            // CustomerName
            // 
            this.CustomerName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CustomerName.HeaderText = "Customer Name";
            this.CustomerName.MinimumWidth = 6;
            this.CustomerName.Name = "CustomerName";
            // 
            // CustomerPhone
            // 
            this.CustomerPhone.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.CustomerPhone.HeaderText = "Customer Phone";
            this.CustomerPhone.MinimumWidth = 6;
            this.CustomerPhone.Name = "CustomerPhone";
            this.CustomerPhone.Width = 174;
            // 
            // tbCustomerName
            // 
            this.tbCustomerName.Location = new System.Drawing.Point(25, 460);
            this.tbCustomerName.Name = "tbCustomerName";
            this.tbCustomerName.ReadOnly = true;
            this.tbCustomerName.Size = new System.Drawing.Size(243, 28);
            this.tbCustomerName.TabIndex = 32;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(21, 426);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(151, 21);
            this.label7.TabIndex = 31;
            this.label7.Text = "Customer Name:";
            // 
            // tbCustomerId
            // 
            this.tbCustomerId.Location = new System.Drawing.Point(25, 377);
            this.tbCustomerId.Name = "tbCustomerId";
            this.tbCustomerId.ReadOnly = true;
            this.tbCustomerId.Size = new System.Drawing.Size(243, 28);
            this.tbCustomerId.TabIndex = 30;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 343);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 21);
            this.label6.TabIndex = 29;
            this.label6.Text = "Customer ID:";
            // 
            // tbSearchCustomer
            // 
            this.tbSearchCustomer.Location = new System.Drawing.Point(400, 306);
            this.tbSearchCustomer.Name = "tbSearchCustomer";
            this.tbSearchCustomer.Size = new System.Drawing.Size(140, 28);
            this.tbSearchCustomer.TabIndex = 28;
            this.tbSearchCustomer.TextChanged += new System.EventHandler(this.tbSearchCustomer_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Blue;
            this.label4.Location = new System.Drawing.Point(12, 306);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 19);
            this.label4.TabIndex = 27;
            this.label4.Text = "CUSTOMER";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(293, 309);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 21);
            this.label3.TabIndex = 26;
            this.label3.Text = "Search Box";
            // 
            // bOrderClear
            // 
            this.bOrderClear.BackColor = System.Drawing.Color.Red;
            this.bOrderClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bOrderClear.FlatAppearance.BorderSize = 0;
            this.bOrderClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bOrderClear.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bOrderClear.ForeColor = System.Drawing.Color.White;
            this.bOrderClear.Location = new System.Drawing.Point(439, 515);
            this.bOrderClear.Name = "bOrderClear";
            this.bOrderClear.Size = new System.Drawing.Size(102, 38);
            this.bOrderClear.TabIndex = 41;
            this.bOrderClear.Text = "Clear";
            this.bOrderClear.UseVisualStyleBackColor = false;
            this.bOrderClear.Click += new System.EventHandler(this.bOrderClear_Click);
            // 
            // bOrderSave
            // 
            this.bOrderSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.bOrderSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bOrderSave.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
            this.bOrderSave.FlatAppearance.BorderSize = 0;
            this.bOrderSave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.bOrderSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bOrderSave.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bOrderSave.ForeColor = System.Drawing.Color.White;
            this.bOrderSave.Location = new System.Drawing.Point(257, 515);
            this.bOrderSave.Name = "bOrderSave";
            this.bOrderSave.Size = new System.Drawing.Size(176, 38);
            this.bOrderSave.TabIndex = 39;
            this.bOrderSave.Text = "Customer Select";
            this.bOrderSave.UseVisualStyleBackColor = false;
            this.bOrderSave.Click += new System.EventHandler(this.bOrderSave_Click);
            // 
            // OrderAddCustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 565);
            this.Controls.Add(this.bOrderClear);
            this.Controls.Add(this.bOrderSave);
            this.Controls.Add(this.tbCustomerName);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbCustomerId);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbSearchCustomer);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgCustomer);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "OrderAddCustomerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OrderAddCustomerForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgCustomer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pbClose;
        private System.Windows.Forms.DataGridView dgCustomer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbCustomerName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbCustomerId;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbSearchCustomer;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerId;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerPhone;
        public System.Windows.Forms.Button bOrderClear;
        public System.Windows.Forms.Button bOrderSave;
    }
}