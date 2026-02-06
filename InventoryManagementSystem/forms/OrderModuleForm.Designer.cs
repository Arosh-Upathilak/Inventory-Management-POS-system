namespace InventoryManagementSystem.Forms
{
    partial class OrderModuleForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrderModuleForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pbClose = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbSearchProduct = new System.Windows.Forms.TextBox();
            this.dgProduct = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label8 = new System.Windows.Forms.Label();
            this.tbProductId = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tbUnitPrice = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tbTotalPrice = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.tbProductName = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.bOrderClear = new System.Windows.Forms.Button();
            this.bOrderSave = new System.Windows.Forms.Button();
            this.nudQty = new System.Windows.Forms.NumericUpDown();
            this.lCId = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudQty)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Red;
            this.panel1.Controls.Add(this.pbClose);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1047, 71);
            this.panel1.TabIndex = 15;
            // 
            // pbClose
            // 
            this.pbClose.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbClose.Image = ((System.Drawing.Image)(resources.GetObject("pbClose.Image")));
            this.pbClose.Location = new System.Drawing.Point(1017, 3);
            this.pbClose.Name = "pbClose";
            this.pbClose.Size = new System.Drawing.Size(27, 20);
            this.pbClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbClose.TabIndex = 40;
            this.pbClose.TabStop = false;
            this.pbClose.Click += new System.EventHandler(this.pbClose_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(31, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Order Module";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(595, 383);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 21);
            this.label3.TabIndex = 20;
            this.label3.Text = "Search Box";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Blue;
            this.label5.Location = new System.Drawing.Point(12, 376);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 19);
            this.label5.TabIndex = 21;
            this.label5.Text = "PRODUCT";
            // 
            // tbSearchProduct
            // 
            this.tbSearchProduct.Location = new System.Drawing.Point(711, 376);
            this.tbSearchProduct.Name = "tbSearchProduct";
            this.tbSearchProduct.Size = new System.Drawing.Size(272, 28);
            this.tbSearchProduct.TabIndex = 22;
            this.tbSearchProduct.TextChanged += new System.EventHandler(this.tbSearchProduct_TextChanged);
            // 
            // dgProduct
            // 
            this.dgProduct.AllowUserToAddRows = false;
            this.dgProduct.BackgroundColor = System.Drawing.Color.White;
            this.dgProduct.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(100)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgProduct.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgProduct.ColumnHeadersHeight = 29;
            this.dgProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgProduct.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.ProductId,
            this.ProductName,
            this.ProductQty,
            this.ProductPrice,
            this.ProductDescription,
            this.ProductCategory});
            this.dgProduct.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgProduct.EnableHeadersVisualStyles = false;
            this.dgProduct.Location = new System.Drawing.Point(0, 71);
            this.dgProduct.Name = "dgProduct";
            this.dgProduct.RowHeadersVisible = false;
            this.dgProduct.RowHeadersWidth = 51;
            this.dgProduct.RowTemplate.Height = 24;
            this.dgProduct.Size = new System.Drawing.Size(1047, 282);
            this.dgProduct.TabIndex = 23;
            this.dgProduct.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgProduct_CellClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn1.HeaderText = "No";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 61;
            // 
            // ProductId
            // 
            this.ProductId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ProductId.HeaderText = "Product ID";
            this.ProductId.MinimumWidth = 6;
            this.ProductId.Name = "ProductId";
            this.ProductId.Width = 126;
            // 
            // ProductName
            // 
            this.ProductName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ProductName.HeaderText = "Product Name";
            this.ProductName.MinimumWidth = 6;
            this.ProductName.Name = "ProductName";
            // 
            // ProductQty
            // 
            this.ProductQty.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ProductQty.HeaderText = "Quantity";
            this.ProductQty.MinimumWidth = 6;
            this.ProductQty.Name = "ProductQty";
            this.ProductQty.Width = 109;
            // 
            // ProductPrice
            // 
            this.ProductPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ProductPrice.HeaderText = "Unit Price";
            this.ProductPrice.MinimumWidth = 6;
            this.ProductPrice.Name = "ProductPrice";
            this.ProductPrice.Width = 114;
            // 
            // ProductDescription
            // 
            this.ProductDescription.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ProductDescription.HeaderText = "Description";
            this.ProductDescription.MinimumWidth = 6;
            this.ProductDescription.Name = "ProductDescription";
            // 
            // ProductCategory
            // 
            this.ProductCategory.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ProductCategory.HeaderText = "Category";
            this.ProductCategory.MinimumWidth = 6;
            this.ProductCategory.Name = "ProductCategory";
            this.ProductCategory.Width = 116;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(31, 413);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(104, 21);
            this.label8.TabIndex = 24;
            this.label8.Text = "Product ID:";
            // 
            // tbProductId
            // 
            this.tbProductId.Location = new System.Drawing.Point(35, 447);
            this.tbProductId.Name = "tbProductId";
            this.tbProductId.ReadOnly = true;
            this.tbProductId.Size = new System.Drawing.Size(241, 28);
            this.tbProductId.TabIndex = 25;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(590, 464);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(92, 21);
            this.label9.TabIndex = 26;
            this.label9.Text = "Unit Price:";
            // 
            // tbUnitPrice
            // 
            this.tbUnitPrice.Location = new System.Drawing.Point(711, 457);
            this.tbUnitPrice.Name = "tbUnitPrice";
            this.tbUnitPrice.ReadOnly = true;
            this.tbUnitPrice.Size = new System.Drawing.Size(272, 28);
            this.tbUnitPrice.TabIndex = 27;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(595, 515);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(87, 21);
            this.label10.TabIndex = 28;
            this.label10.Text = "Quantity:";
            // 
            // tbTotalPrice
            // 
            this.tbTotalPrice.Location = new System.Drawing.Point(711, 561);
            this.tbTotalPrice.Name = "tbTotalPrice";
            this.tbTotalPrice.ReadOnly = true;
            this.tbTotalPrice.Size = new System.Drawing.Size(272, 28);
            this.tbTotalPrice.TabIndex = 31;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(581, 568);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(101, 21);
            this.label11.TabIndex = 30;
            this.label11.Text = "Total Price:";
            // 
            // tbProductName
            // 
            this.tbProductName.Location = new System.Drawing.Point(35, 533);
            this.tbProductName.Name = "tbProductName";
            this.tbProductName.ReadOnly = true;
            this.tbProductName.Size = new System.Drawing.Size(241, 28);
            this.tbProductName.TabIndex = 33;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(31, 499);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(137, 21);
            this.label12.TabIndex = 32;
            this.label12.Text = "Product Name:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(31, 591);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(111, 21);
            this.label13.TabIndex = 34;
            this.label13.Text = "Order Date:";
            // 
            // dtpDate
            // 
            this.dtpDate.CustomFormat = "dd/MM/YYYY HH:MM:ss";
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDate.Location = new System.Drawing.Point(35, 632);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(241, 28);
            this.dtpDate.TabIndex = 35;
            // 
            // bOrderClear
            // 
            this.bOrderClear.BackColor = System.Drawing.Color.Red;
            this.bOrderClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bOrderClear.FlatAppearance.BorderSize = 0;
            this.bOrderClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bOrderClear.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bOrderClear.ForeColor = System.Drawing.Color.White;
            this.bOrderClear.Location = new System.Drawing.Point(887, 655);
            this.bOrderClear.Name = "bOrderClear";
            this.bOrderClear.Size = new System.Drawing.Size(102, 38);
            this.bOrderClear.TabIndex = 38;
            this.bOrderClear.Text = "Clear";
            this.bOrderClear.UseVisualStyleBackColor = false;
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
            this.bOrderSave.Location = new System.Drawing.Point(728, 655);
            this.bOrderSave.Name = "bOrderSave";
            this.bOrderSave.Size = new System.Drawing.Size(143, 38);
            this.bOrderSave.TabIndex = 36;
            this.bOrderSave.Text = "Order Insert";
            this.bOrderSave.UseVisualStyleBackColor = false;
            this.bOrderSave.Click += new System.EventHandler(this.bOrderSave_Click);
            // 
            // nudQty
            // 
            this.nudQty.Location = new System.Drawing.Point(711, 515);
            this.nudQty.Name = "nudQty";
            this.nudQty.Size = new System.Drawing.Size(272, 28);
            this.nudQty.TabIndex = 39;
            this.nudQty.ValueChanged += new System.EventHandler(this.nudQty_ValueChanged);
            // 
            // lCId
            // 
            this.lCId.AutoSize = true;
            this.lCId.Location = new System.Drawing.Point(41, 672);
            this.lCId.Name = "lCId";
            this.lCId.Size = new System.Drawing.Size(112, 21);
            this.lCId.TabIndex = 40;
            this.lCId.Text = "Customer Id";
            this.lCId.Visible = false;
            // 
            // OrderModuleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1047, 719);
            this.Controls.Add(this.lCId);
            this.Controls.Add(this.nudQty);
            this.Controls.Add(this.bOrderClear);
            this.Controls.Add(this.bOrderSave);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.tbProductName);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.tbTotalPrice);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.tbUnitPrice);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.tbProductId);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dgProduct);
            this.Controls.Add(this.tbSearchProduct);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "OrderModuleForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OrderModuleForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudQty)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbSearchProduct;
        private System.Windows.Forms.DataGridView dgProduct;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        public System.Windows.Forms.Button bOrderClear;
        public System.Windows.Forms.Button bOrderSave;
        private System.Windows.Forms.PictureBox pbClose;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductCategory;
        public System.Windows.Forms.Label lCId;
        public System.Windows.Forms.TextBox tbProductId;
        public System.Windows.Forms.TextBox tbProductName;
        public System.Windows.Forms.DateTimePicker dtpDate;
        public System.Windows.Forms.TextBox tbUnitPrice;
        public System.Windows.Forms.TextBox tbTotalPrice;
        public System.Windows.Forms.NumericUpDown nudQty;
    }
}