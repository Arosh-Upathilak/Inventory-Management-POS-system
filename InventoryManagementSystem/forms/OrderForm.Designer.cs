namespace InventoryManagementSystem.Forms
{
    partial class OrderForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrderForm));
            this.dgOrder = new System.Windows.Forms.DataGridView();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TOID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrderId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrderDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrderQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UnitPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edit = new System.Windows.Forms.DataGridViewImageColumn();
            this.Delete = new System.Windows.Forms.DataGridViewImageColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bFinish = new System.Windows.Forms.Button();
            this.tbCustomerMoney = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.lQuantity = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lTotalAmount = new System.Windows.Forms.Label();
            this.cbAddProduct = new InventoryManagementSystem.Forms.CustomComponents.CustomButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbCasherName = new System.Windows.Forms.TextBox();
            this.tbCustomer = new System.Windows.Forms.TextBox();
            this.pAddCustomer = new System.Windows.Forms.PictureBox();
            this.lCustomerID = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgOrder)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbAddProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pAddCustomer)).BeginInit();
            this.SuspendLayout();
            // 
            // dgOrder
            // 
            this.dgOrder.AllowUserToAddRows = false;
            this.dgOrder.BackgroundColor = System.Drawing.Color.White;
            this.dgOrder.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(100)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgOrder.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgOrder.ColumnHeadersHeight = 29;
            this.dgOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgOrder.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column7,
            this.TOID,
            this.OrderId,
            this.OrderDate,
            this.ProductName,
            this.OrderQty,
            this.UnitPrice,
            this.TotalAmount,
            this.Edit,
            this.Delete});
            this.dgOrder.EnableHeadersVisualStyles = false;
            this.dgOrder.Location = new System.Drawing.Point(0, 87);
            this.dgOrder.Name = "dgOrder";
            this.dgOrder.RowHeadersWidth = 51;
            this.dgOrder.RowTemplate.Height = 24;
            this.dgOrder.Size = new System.Drawing.Size(982, 252);
            this.dgOrder.TabIndex = 9;
            this.dgOrder.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgProduct_CellContentClick);
            // 
            // Column7
            // 
            this.Column7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column7.HeaderText = "No";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            this.Column7.Width = 61;
            // 
            // TOID
            // 
            this.TOID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.TOID.HeaderText = "T OID";
            this.TOID.MinimumWidth = 6;
            this.TOID.Name = "TOID";
            this.TOID.Visible = false;
            this.TOID.Width = 125;
            // 
            // OrderId
            // 
            this.OrderId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.OrderId.HeaderText = "Order ID";
            this.OrderId.MinimumWidth = 6;
            this.OrderId.Name = "OrderId";
            this.OrderId.Visible = false;
            this.OrderId.Width = 125;
            // 
            // OrderDate
            // 
            this.OrderDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.OrderDate.HeaderText = "Order Date";
            this.OrderDate.MinimumWidth = 6;
            this.OrderDate.Name = "OrderDate";
            // 
            // ProductName
            // 
            this.ProductName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ProductName.HeaderText = "Product Name";
            this.ProductName.MinimumWidth = 6;
            this.ProductName.Name = "ProductName";
            this.ProductName.Width = 159;
            // 
            // OrderQty
            // 
            this.OrderQty.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.OrderQty.HeaderText = "Quantity";
            this.OrderQty.MinimumWidth = 6;
            this.OrderQty.Name = "OrderQty";
            // 
            // UnitPrice
            // 
            this.UnitPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.UnitPrice.HeaderText = "Unit Price";
            this.UnitPrice.MinimumWidth = 6;
            this.UnitPrice.Name = "UnitPrice";
            this.UnitPrice.Width = 114;
            // 
            // TotalAmount
            // 
            this.TotalAmount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.TotalAmount.HeaderText = "Total Amount";
            this.TotalAmount.MinimumWidth = 6;
            this.TotalAmount.Name = "TotalAmount";
            this.TotalAmount.Width = 149;
            // 
            // Edit
            // 
            this.Edit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Edit.HeaderText = "";
            this.Edit.Image = ((System.Drawing.Image)(resources.GetObject("Edit.Image")));
            this.Edit.MinimumWidth = 6;
            this.Edit.Name = "Edit";
            this.Edit.Width = 6;
            // 
            // Delete
            // 
            this.Delete.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Delete.HeaderText = "";
            this.Delete.Image = ((System.Drawing.Image)(resources.GetObject("Delete.Image")));
            this.Delete.MinimumWidth = 6;
            this.Delete.Name = "Delete";
            this.Delete.Width = 6;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Navy;
            this.panel1.Controls.Add(this.bFinish);
            this.panel1.Controls.Add(this.tbCustomerMoney);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.lQuantity);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.lTotalAmount);
            this.panel1.Controls.Add(this.cbAddProduct);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 340);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(982, 100);
            this.panel1.TabIndex = 8;
            // 
            // bFinish
            // 
            this.bFinish.Location = new System.Drawing.Point(802, 25);
            this.bFinish.Name = "bFinish";
            this.bFinish.Size = new System.Drawing.Size(168, 46);
            this.bFinish.TabIndex = 10;
            this.bFinish.Text = "Finish Transaction";
            this.bFinish.UseVisualStyleBackColor = true;
            this.bFinish.Click += new System.EventHandler(this.bFinish_Click);
            // 
            // tbCustomerMoney
            // 
            this.tbCustomerMoney.Location = new System.Drawing.Point(598, 57);
            this.tbCustomerMoney.Name = "tbCustomerMoney";
            this.tbCustomerMoney.Size = new System.Drawing.Size(148, 28);
            this.tbCustomerMoney.TabIndex = 9;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(597, 21);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(149, 19);
            this.label8.TabIndex = 8;
            this.label8.Text = "Customer Money";
            // 
            // lQuantity
            // 
            this.lQuantity.AutoSize = true;
            this.lQuantity.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lQuantity.ForeColor = System.Drawing.Color.White;
            this.lQuantity.Location = new System.Drawing.Point(337, 60);
            this.lQuantity.Name = "lQuantity";
            this.lQuantity.Size = new System.Drawing.Size(0, 23);
            this.lQuantity.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(461, 21);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(115, 19);
            this.label7.TabIndex = 6;
            this.label7.Text = "Total Amount";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(317, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 19);
            this.label6.TabIndex = 5;
            this.label6.Text = "Quantity";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(221, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 27);
            this.label5.TabIndex = 4;
            this.label5.Text = "Order:";
            // 
            // lTotalAmount
            // 
            this.lTotalAmount.AutoSize = true;
            this.lTotalAmount.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lTotalAmount.ForeColor = System.Drawing.Color.White;
            this.lTotalAmount.Location = new System.Drawing.Point(461, 60);
            this.lTotalAmount.Name = "lTotalAmount";
            this.lTotalAmount.Size = new System.Drawing.Size(0, 23);
            this.lTotalAmount.TabIndex = 3;
            // 
            // cbAddProduct
            // 
            this.cbAddProduct.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbAddProduct.Image = ((System.Drawing.Image)(resources.GetObject("cbAddProduct.Image")));
            this.cbAddProduct.ImageHover = ((System.Drawing.Image)(resources.GetObject("cbAddProduct.ImageHover")));
            this.cbAddProduct.ImageNormal = ((System.Drawing.Image)(resources.GetObject("cbAddProduct.ImageNormal")));
            this.cbAddProduct.Location = new System.Drawing.Point(143, 21);
            this.cbAddProduct.Name = "cbAddProduct";
            this.cbAddProduct.Size = new System.Drawing.Size(30, 30);
            this.cbAddProduct.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.cbAddProduct.TabIndex = 1;
            this.cbAddProduct.TabStop = false;
            this.cbAddProduct.Click += new System.EventHandler(this.cbAddProduct_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(19, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add Order:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(445, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 27);
            this.label2.TabIndex = 10;
            this.label2.Text = "New Order";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 21);
            this.label3.TabIndex = 11;
            this.label3.Text = "Casher Name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(151, 21);
            this.label4.TabIndex = 12;
            this.label4.Text = "Customer Name:";
            // 
            // tbCasherName
            // 
            this.tbCasherName.Location = new System.Drawing.Point(169, 15);
            this.tbCasherName.Name = "tbCasherName";
            this.tbCasherName.ReadOnly = true;
            this.tbCasherName.Size = new System.Drawing.Size(166, 28);
            this.tbCasherName.TabIndex = 13;
            // 
            // tbCustomer
            // 
            this.tbCustomer.Location = new System.Drawing.Point(169, 49);
            this.tbCustomer.Name = "tbCustomer";
            this.tbCustomer.ReadOnly = true;
            this.tbCustomer.Size = new System.Drawing.Size(166, 28);
            this.tbCustomer.TabIndex = 14;
            // 
            // pAddCustomer
            // 
            this.pAddCustomer.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pAddCustomer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pAddCustomer.Image = ((System.Drawing.Image)(resources.GetObject("pAddCustomer.Image")));
            this.pAddCustomer.Location = new System.Drawing.Point(341, 49);
            this.pAddCustomer.Name = "pAddCustomer";
            this.pAddCustomer.Size = new System.Drawing.Size(30, 30);
            this.pAddCustomer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pAddCustomer.TabIndex = 15;
            this.pAddCustomer.TabStop = false;
            this.pAddCustomer.Click += new System.EventHandler(this.pAddCustomer_Click);
            // 
            // lCustomerID
            // 
            this.lCustomerID.AutoSize = true;
            this.lCustomerID.Location = new System.Drawing.Point(398, 50);
            this.lCustomerID.Name = "lCustomerID";
            this.lCustomerID.Size = new System.Drawing.Size(108, 21);
            this.lCustomerID.TabIndex = 16;
            this.lCustomerID.Text = "CustomerID";
            this.lCustomerID.Visible = false;
            // 
            // OrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 440);
            this.Controls.Add(this.lCustomerID);
            this.Controls.Add(this.pAddCustomer);
            this.Controls.Add(this.tbCustomer);
            this.Controls.Add(this.tbCasherName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgOrder);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "OrderForm";
            this.Text = "OrderForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgOrder)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbAddProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pAddCustomer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgOrder;
        private System.Windows.Forms.Panel panel1;
        private CustomComponents.CustomButton cbAddProduct;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox tbCustomer;
        public System.Windows.Forms.PictureBox pAddCustomer;
        public System.Windows.Forms.Label lCustomerID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lTotalAmount;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lQuantity;
        public System.Windows.Forms.TextBox tbCasherName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button bFinish;
        private System.Windows.Forms.TextBox tbCustomerMoney;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn TOID;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderId;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn UnitPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalAmount;
        private System.Windows.Forms.DataGridViewImageColumn Edit;
        private System.Windows.Forms.DataGridViewImageColumn Delete;
    }
}