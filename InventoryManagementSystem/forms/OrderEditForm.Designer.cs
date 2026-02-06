namespace InventoryManagementSystem.Forms
{
    partial class OrderEditForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrderEditForm));
            this.lOId = new System.Windows.Forms.Label();
            this.nudQty = new System.Windows.Forms.NumericUpDown();
            this.bOrderClear = new System.Windows.Forms.Button();
            this.bOrderUpdate = new System.Windows.Forms.Button();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.label13 = new System.Windows.Forms.Label();
            this.tbProductName = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.tbTotalPrice = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tbUnitPrice = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tbProductId = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.ProductDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgProductEdit = new System.Windows.Forms.DataGridView();
            this.ProductCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label5 = new System.Windows.Forms.Label();
            this.pbClose = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.nudQty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgProductEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbClose)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lOId
            // 
            this.lOId.AutoSize = true;
            this.lOId.Location = new System.Drawing.Point(60, 470);
            this.lOId.Name = "lOId";
            this.lOId.Size = new System.Drawing.Size(80, 21);
            this.lOId.TabIndex = 61;
            this.lOId.Text = "Order Id";
            this.lOId.Visible = false;
            // 
            // nudQty
            // 
            this.nudQty.Location = new System.Drawing.Point(730, 313);
            this.nudQty.Name = "nudQty";
            this.nudQty.Size = new System.Drawing.Size(272, 28);
            this.nudQty.TabIndex = 60;
            this.nudQty.ValueChanged += new System.EventHandler(this.nudQty_ValueChanged);
            // 
            // bOrderClear
            // 
            this.bOrderClear.BackColor = System.Drawing.Color.Red;
            this.bOrderClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bOrderClear.FlatAppearance.BorderSize = 0;
            this.bOrderClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bOrderClear.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bOrderClear.ForeColor = System.Drawing.Color.White;
            this.bOrderClear.Location = new System.Drawing.Point(906, 453);
            this.bOrderClear.Name = "bOrderClear";
            this.bOrderClear.Size = new System.Drawing.Size(102, 49);
            this.bOrderClear.TabIndex = 59;
            this.bOrderClear.Text = "Clear";
            this.bOrderClear.UseVisualStyleBackColor = false;
            // 
            // bOrderUpdate
            // 
            this.bOrderUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.bOrderUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bOrderUpdate.FlatAppearance.BorderSize = 0;
            this.bOrderUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bOrderUpdate.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bOrderUpdate.ForeColor = System.Drawing.Color.White;
            this.bOrderUpdate.Location = new System.Drawing.Point(764, 453);
            this.bOrderUpdate.Name = "bOrderUpdate";
            this.bOrderUpdate.Size = new System.Drawing.Size(135, 49);
            this.bOrderUpdate.TabIndex = 58;
            this.bOrderUpdate.Text = "Order Update";
            this.bOrderUpdate.UseVisualStyleBackColor = false;
            this.bOrderUpdate.Click += new System.EventHandler(this.bOrderUpdate_Click);
            // 
            // dtpDate
            // 
            this.dtpDate.CustomFormat = "dd/MM/YYYY HH:MM:ss";
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDate.Location = new System.Drawing.Point(54, 430);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(241, 28);
            this.dtpDate.TabIndex = 56;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(50, 389);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(111, 21);
            this.label13.TabIndex = 55;
            this.label13.Text = "Order Date:";
            // 
            // tbProductName
            // 
            this.tbProductName.Location = new System.Drawing.Point(54, 331);
            this.tbProductName.Name = "tbProductName";
            this.tbProductName.ReadOnly = true;
            this.tbProductName.Size = new System.Drawing.Size(241, 28);
            this.tbProductName.TabIndex = 54;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(50, 297);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(137, 21);
            this.label12.TabIndex = 53;
            this.label12.Text = "Product Name:";
            // 
            // tbTotalPrice
            // 
            this.tbTotalPrice.Location = new System.Drawing.Point(730, 359);
            this.tbTotalPrice.Name = "tbTotalPrice";
            this.tbTotalPrice.ReadOnly = true;
            this.tbTotalPrice.Size = new System.Drawing.Size(272, 28);
            this.tbTotalPrice.TabIndex = 52;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(600, 366);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(101, 21);
            this.label11.TabIndex = 51;
            this.label11.Text = "Total Price:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(614, 313);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(87, 21);
            this.label10.TabIndex = 50;
            this.label10.Text = "Quantity:";
            // 
            // tbUnitPrice
            // 
            this.tbUnitPrice.Location = new System.Drawing.Point(730, 255);
            this.tbUnitPrice.Name = "tbUnitPrice";
            this.tbUnitPrice.ReadOnly = true;
            this.tbUnitPrice.Size = new System.Drawing.Size(272, 28);
            this.tbUnitPrice.TabIndex = 49;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(609, 262);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(92, 21);
            this.label9.TabIndex = 48;
            this.label9.Text = "Unit Price:";
            // 
            // tbProductId
            // 
            this.tbProductId.Location = new System.Drawing.Point(54, 245);
            this.tbProductId.Name = "tbProductId";
            this.tbProductId.ReadOnly = true;
            this.tbProductId.Size = new System.Drawing.Size(241, 28);
            this.tbProductId.TabIndex = 47;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(50, 211);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(104, 21);
            this.label8.TabIndex = 46;
            this.label8.Text = "Product ID:";
            // 
            // ProductDescription
            // 
            this.ProductDescription.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ProductDescription.HeaderText = "Description";
            this.ProductDescription.MinimumWidth = 6;
            this.ProductDescription.Name = "ProductDescription";
            // 
            // ProductPrice
            // 
            this.ProductPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ProductPrice.HeaderText = "Unit Price";
            this.ProductPrice.MinimumWidth = 6;
            this.ProductPrice.Name = "ProductPrice";
            this.ProductPrice.Width = 114;
            // 
            // ProductQty
            // 
            this.ProductQty.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ProductQty.HeaderText = "Quantity";
            this.ProductQty.MinimumWidth = 6;
            this.ProductQty.Name = "ProductQty";
            this.ProductQty.Width = 109;
            // 
            // ProductName
            // 
            this.ProductName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ProductName.HeaderText = "Product Name";
            this.ProductName.MinimumWidth = 6;
            this.ProductName.Name = "ProductName";
            // 
            // ProductId
            // 
            this.ProductId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ProductId.HeaderText = "Product ID";
            this.ProductId.MinimumWidth = 6;
            this.ProductId.Name = "ProductId";
            this.ProductId.Width = 126;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn1.HeaderText = "No";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 61;
            // 
            // dgProductEdit
            // 
            this.dgProductEdit.AllowUserToAddRows = false;
            this.dgProductEdit.BackgroundColor = System.Drawing.Color.White;
            this.dgProductEdit.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(100)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgProductEdit.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgProductEdit.ColumnHeadersHeight = 29;
            this.dgProductEdit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgProductEdit.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.ProductId,
            this.ProductName,
            this.ProductQty,
            this.ProductPrice,
            this.ProductDescription,
            this.ProductCategory});
            this.dgProductEdit.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgProductEdit.EnableHeadersVisualStyles = false;
            this.dgProductEdit.Location = new System.Drawing.Point(0, 82);
            this.dgProductEdit.Name = "dgProductEdit";
            this.dgProductEdit.RowHeadersVisible = false;
            this.dgProductEdit.RowHeadersWidth = 51;
            this.dgProductEdit.RowTemplate.Height = 24;
            this.dgProductEdit.Size = new System.Drawing.Size(1047, 56);
            this.dgProductEdit.TabIndex = 45;
            // 
            // ProductCategory
            // 
            this.ProductCategory.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ProductCategory.HeaderText = "Category";
            this.ProductCategory.MinimumWidth = 6;
            this.ProductCategory.Name = "ProductCategory";
            this.ProductCategory.Width = 116;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Blue;
            this.label5.Location = new System.Drawing.Point(31, 174);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 19);
            this.label5.TabIndex = 43;
            this.label5.Text = "PRODUCT";
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
            this.pbClose.Size = new System.Drawing.Size(27, 31);
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
            this.label1.Size = new System.Drawing.Size(185, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Order Update Module";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Red;
            this.panel1.Controls.Add(this.pbClose);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1047, 82);
            this.panel1.TabIndex = 41;
            // 
            // OrderEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1047, 514);
            this.Controls.Add(this.lOId);
            this.Controls.Add(this.nudQty);
            this.Controls.Add(this.bOrderClear);
            this.Controls.Add(this.bOrderUpdate);
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
            this.Controls.Add(this.dgProductEdit);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "OrderEditForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OrderEditForm";
            ((System.ComponentModel.ISupportInitialize)(this.nudQty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgProductEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbClose)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label lOId;
        public System.Windows.Forms.NumericUpDown nudQty;
        public System.Windows.Forms.Button bOrderClear;
        public System.Windows.Forms.Button bOrderUpdate;
        public System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Label label13;
        public System.Windows.Forms.TextBox tbProductName;
        private System.Windows.Forms.Label label12;
        public System.Windows.Forms.TextBox tbTotalPrice;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        public System.Windows.Forms.TextBox tbUnitPrice;
        private System.Windows.Forms.Label label9;
        public System.Windows.Forms.TextBox tbProductId;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridView dgProductEdit;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductCategory;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pbClose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
    }
}