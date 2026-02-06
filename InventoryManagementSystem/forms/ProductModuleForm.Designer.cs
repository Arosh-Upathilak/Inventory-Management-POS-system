namespace InventoryManagementSystem.Forms
{
    partial class ProductModuleForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductModuleForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pbClose = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bProductClear = new System.Windows.Forms.Button();
            this.bProductUpdate = new System.Windows.Forms.Button();
            this.bProductSave = new System.Windows.Forms.Button();
            this.tbQuantity = new System.Windows.Forms.TextBox();
            this.Quantity = new System.Windows.Forms.Label();
            this.tbProductName = new System.Windows.Forms.TextBox();
            this.ProductName = new System.Windows.Forms.Label();
            this.tbPrice = new System.Windows.Forms.TextBox();
            this.Price = new System.Windows.Forms.Label();
            this.tbDescription = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbCategory = new System.Windows.Forms.ComboBox();
            this.lproductId = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbClose)).BeginInit();
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
            this.panel1.Size = new System.Drawing.Size(800, 71);
            this.panel1.TabIndex = 26;
            // 
            // pbClose
            // 
            this.pbClose.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbClose.Image = ((System.Drawing.Image)(resources.GetObject("pbClose.Image")));
            this.pbClose.Location = new System.Drawing.Point(768, 3);
            this.pbClose.Name = "pbClose";
            this.pbClose.Size = new System.Drawing.Size(20, 20);
            this.pbClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbClose.TabIndex = 10;
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
            this.label1.Size = new System.Drawing.Size(138, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Product Module";
            // 
            // bProductClear
            // 
            this.bProductClear.BackColor = System.Drawing.Color.Red;
            this.bProductClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bProductClear.FlatAppearance.BorderSize = 0;
            this.bProductClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bProductClear.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bProductClear.ForeColor = System.Drawing.Color.White;
            this.bProductClear.Location = new System.Drawing.Point(602, 475);
            this.bProductClear.Name = "bProductClear";
            this.bProductClear.Size = new System.Drawing.Size(102, 38);
            this.bProductClear.TabIndex = 33;
            this.bProductClear.Text = "Clear";
            this.bProductClear.UseVisualStyleBackColor = false;
            this.bProductClear.Click += new System.EventHandler(this.bCustomerClear_Click);
            // 
            // bProductUpdate
            // 
            this.bProductUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.bProductUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bProductUpdate.FlatAppearance.BorderSize = 0;
            this.bProductUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bProductUpdate.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bProductUpdate.ForeColor = System.Drawing.Color.White;
            this.bProductUpdate.Location = new System.Drawing.Point(493, 475);
            this.bProductUpdate.Name = "bProductUpdate";
            this.bProductUpdate.Size = new System.Drawing.Size(102, 38);
            this.bProductUpdate.TabIndex = 32;
            this.bProductUpdate.Text = "Update";
            this.bProductUpdate.UseVisualStyleBackColor = false;
            this.bProductUpdate.Click += new System.EventHandler(this.bProductUpdate_Click);
            // 
            // bProductSave
            // 
            this.bProductSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.bProductSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bProductSave.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
            this.bProductSave.FlatAppearance.BorderSize = 0;
            this.bProductSave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.bProductSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bProductSave.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bProductSave.ForeColor = System.Drawing.Color.White;
            this.bProductSave.Location = new System.Drawing.Point(385, 475);
            this.bProductSave.Name = "bProductSave";
            this.bProductSave.Size = new System.Drawing.Size(102, 38);
            this.bProductSave.TabIndex = 31;
            this.bProductSave.Text = "Save";
            this.bProductSave.UseVisualStyleBackColor = false;
            this.bProductSave.Click += new System.EventHandler(this.bProductSave_Click);
            // 
            // tbQuantity
            // 
            this.tbQuantity.Location = new System.Drawing.Point(202, 190);
            this.tbQuantity.Name = "tbQuantity";
            this.tbQuantity.Size = new System.Drawing.Size(502, 28);
            this.tbQuantity.TabIndex = 30;
            // 
            // Quantity
            // 
            this.Quantity.AutoSize = true;
            this.Quantity.Location = new System.Drawing.Point(95, 193);
            this.Quantity.Name = "Quantity";
            this.Quantity.Size = new System.Drawing.Size(87, 21);
            this.Quantity.TabIndex = 29;
            this.Quantity.Text = "Quantity:";
            // 
            // tbProductName
            // 
            this.tbProductName.Location = new System.Drawing.Point(202, 123);
            this.tbProductName.Name = "tbProductName";
            this.tbProductName.Size = new System.Drawing.Size(502, 28);
            this.tbProductName.TabIndex = 28;
            // 
            // ProductName
            // 
            this.ProductName.AutoSize = true;
            this.ProductName.Location = new System.Drawing.Point(45, 126);
            this.ProductName.Name = "ProductName";
            this.ProductName.Size = new System.Drawing.Size(137, 21);
            this.ProductName.TabIndex = 27;
            this.ProductName.Text = "Product Name:";
            // 
            // tbPrice
            // 
            this.tbPrice.Location = new System.Drawing.Point(202, 257);
            this.tbPrice.Name = "tbPrice";
            this.tbPrice.Size = new System.Drawing.Size(502, 28);
            this.tbPrice.TabIndex = 35;
            // 
            // Price
            // 
            this.Price.AutoSize = true;
            this.Price.Location = new System.Drawing.Point(78, 257);
            this.Price.Name = "Price";
            this.Price.Size = new System.Drawing.Size(92, 21);
            this.Price.TabIndex = 34;
            this.Price.Text = "Unit Price:";
            // 
            // tbDescription
            // 
            this.tbDescription.Location = new System.Drawing.Point(202, 319);
            this.tbDescription.Name = "tbDescription";
            this.tbDescription.Size = new System.Drawing.Size(502, 28);
            this.tbDescription.TabIndex = 39;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(62, 322);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 21);
            this.label2.TabIndex = 38;
            this.label2.Text = "Description:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(75, 387);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 21);
            this.label3.TabIndex = 40;
            this.label3.Text = "Category:";
            // 
            // cbCategory
            // 
            this.cbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCategory.FormattingEnabled = true;
            this.cbCategory.Location = new System.Drawing.Point(203, 384);
            this.cbCategory.Name = "cbCategory";
            this.cbCategory.Size = new System.Drawing.Size(501, 29);
            this.cbCategory.TabIndex = 41;
            // 
            // lproductId
            // 
            this.lproductId.AutoSize = true;
            this.lproductId.Location = new System.Drawing.Point(72, 467);
            this.lproductId.Name = "lproductId";
            this.lproductId.Size = new System.Drawing.Size(98, 21);
            this.lproductId.TabIndex = 42;
            this.lproductId.Text = "Product Id";
            this.lproductId.Visible = false;
            // 
            // ProductModuleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 540);
            this.Controls.Add(this.lproductId);
            this.Controls.Add(this.cbCategory);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbDescription);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbPrice);
            this.Controls.Add(this.Price);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.bProductClear);
            this.Controls.Add(this.bProductUpdate);
            this.Controls.Add(this.bProductSave);
            this.Controls.Add(this.tbQuantity);
            this.Controls.Add(this.Quantity);
            this.Controls.Add(this.tbProductName);
            this.Controls.Add(this.ProductName);
            this.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ProductModuleForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProductModuleForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbClose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pbClose;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Button bProductClear;
        public System.Windows.Forms.Button bProductUpdate;
        public System.Windows.Forms.Button bProductSave;
        public System.Windows.Forms.TextBox tbQuantity;
        private System.Windows.Forms.Label Quantity;
        public System.Windows.Forms.TextBox tbProductName;
        private System.Windows.Forms.Label ProductName;
        public System.Windows.Forms.TextBox tbPrice;
        private System.Windows.Forms.Label Price;
        public System.Windows.Forms.TextBox tbDescription;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label lproductId;
        public System.Windows.Forms.ComboBox cbCategory;
    }
}