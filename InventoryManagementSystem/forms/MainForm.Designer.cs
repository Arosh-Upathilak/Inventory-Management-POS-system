namespace InventoryManagementSystem.Forms
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.cbShowOrder = new InventoryManagementSystem.Forms.CustomComponents.CustomButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbOrder = new InventoryManagementSystem.Forms.CustomComponents.CustomButton();
            this.cbUser = new InventoryManagementSystem.Forms.CustomComponents.CustomButton();
            this.cbCategories = new InventoryManagementSystem.Forms.CustomComponents.CustomButton();
            this.cbCustomer = new InventoryManagementSystem.Forms.CustomComponents.CustomButton();
            this.cbProduct = new InventoryManagementSystem.Forms.CustomComponents.CustomButton();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panelMain = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbShowOrder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbOrder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbCategories)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbCustomer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbProduct)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.cbShowOrder);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.cbOrder);
            this.panel1.Controls.Add(this.cbUser);
            this.panel1.Controls.Add(this.cbCategories);
            this.panel1.Controls.Add(this.cbCustomer);
            this.panel1.Controls.Add(this.cbProduct);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(982, 131);
            this.panel1.TabIndex = 0;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.Blue;
            this.label9.Location = new System.Drawing.Point(797, 79);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(113, 21);
            this.label9.TabIndex = 21;
            this.label9.Text = "Show Orders";
            // 
            // cbShowOrder
            // 
            this.cbShowOrder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbShowOrder.Image = ((System.Drawing.Image)(resources.GetObject("cbShowOrder.Image")));
            this.cbShowOrder.ImageHover = ((System.Drawing.Image)(resources.GetObject("cbShowOrder.ImageHover")));
            this.cbShowOrder.ImageNormal = ((System.Drawing.Image)(resources.GetObject("cbShowOrder.ImageNormal")));
            this.cbShowOrder.Location = new System.Drawing.Point(834, 26);
            this.cbShowOrder.Name = "cbShowOrder";
            this.cbShowOrder.Size = new System.Drawing.Size(33, 38);
            this.cbShowOrder.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.cbShowOrder.TabIndex = 20;
            this.cbShowOrder.TabStop = false;
            this.cbShowOrder.Click += new System.EventHandler(this.cbShowOrder_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(56, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 19);
            this.label2.TabIndex = 10;
            this.label2.Text = "demy";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(9, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 49);
            this.label1.TabIndex = 9;
            this.label1.Text = "M";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Blue;
            this.label8.Location = new System.Drawing.Point(914, 79);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 21);
            this.label8.TabIndex = 19;
            this.label8.Text = "Orders";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Blue;
            this.label7.Location = new System.Drawing.Point(739, 79);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 21);
            this.label7.TabIndex = 18;
            this.label7.Text = "Users";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Blue;
            this.label6.Location = new System.Drawing.Point(636, 79);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 21);
            this.label6.TabIndex = 17;
            this.label6.Text = "Categories";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Blue;
            this.label5.Location = new System.Drawing.Point(554, 79);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 21);
            this.label5.TabIndex = 16;
            this.label5.Text = "Customs";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(472, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 21);
            this.label3.TabIndex = 15;
            this.label3.Text = "Product";
            // 
            // cbOrder
            // 
            this.cbOrder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbOrder.Image = ((System.Drawing.Image)(resources.GetObject("cbOrder.Image")));
            this.cbOrder.ImageHover = ((System.Drawing.Image)(resources.GetObject("cbOrder.ImageHover")));
            this.cbOrder.ImageNormal = ((System.Drawing.Image)(resources.GetObject("cbOrder.ImageNormal")));
            this.cbOrder.Location = new System.Drawing.Point(918, 26);
            this.cbOrder.Name = "cbOrder";
            this.cbOrder.Size = new System.Drawing.Size(33, 38);
            this.cbOrder.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.cbOrder.TabIndex = 14;
            this.cbOrder.TabStop = false;
            this.cbOrder.Click += new System.EventHandler(this.cbOrder_Click);
            // 
            // cbUser
            // 
            this.cbUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbUser.Image = ((System.Drawing.Image)(resources.GetObject("cbUser.Image")));
            this.cbUser.ImageHover = ((System.Drawing.Image)(resources.GetObject("cbUser.ImageHover")));
            this.cbUser.ImageNormal = ((System.Drawing.Image)(resources.GetObject("cbUser.ImageNormal")));
            this.cbUser.Location = new System.Drawing.Point(743, 26);
            this.cbUser.Name = "cbUser";
            this.cbUser.Size = new System.Drawing.Size(33, 38);
            this.cbUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.cbUser.TabIndex = 13;
            this.cbUser.TabStop = false;
            this.cbUser.Click += new System.EventHandler(this.cbUser_Click);
            // 
            // cbCategories
            // 
            this.cbCategories.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbCategories.Image = ((System.Drawing.Image)(resources.GetObject("cbCategories.Image")));
            this.cbCategories.ImageHover = ((System.Drawing.Image)(resources.GetObject("cbCategories.ImageHover")));
            this.cbCategories.ImageNormal = ((System.Drawing.Image)(resources.GetObject("cbCategories.ImageNormal")));
            this.cbCategories.Location = new System.Drawing.Point(668, 26);
            this.cbCategories.Name = "cbCategories";
            this.cbCategories.Size = new System.Drawing.Size(33, 38);
            this.cbCategories.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.cbCategories.TabIndex = 12;
            this.cbCategories.TabStop = false;
            this.cbCategories.Click += new System.EventHandler(this.cbCategories_Click);
            // 
            // cbCustomer
            // 
            this.cbCustomer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbCustomer.Image = ((System.Drawing.Image)(resources.GetObject("cbCustomer.Image")));
            this.cbCustomer.ImageHover = ((System.Drawing.Image)(resources.GetObject("cbCustomer.ImageHover")));
            this.cbCustomer.ImageNormal = ((System.Drawing.Image)(resources.GetObject("cbCustomer.ImageNormal")));
            this.cbCustomer.Location = new System.Drawing.Point(575, 26);
            this.cbCustomer.Name = "cbCustomer";
            this.cbCustomer.Size = new System.Drawing.Size(33, 38);
            this.cbCustomer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.cbCustomer.TabIndex = 11;
            this.cbCustomer.TabStop = false;
            this.cbCustomer.Click += new System.EventHandler(this.cbCustomer_Click);
            // 
            // cbProduct
            // 
            this.cbProduct.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbProduct.Image = ((System.Drawing.Image)(resources.GetObject("cbProduct.Image")));
            this.cbProduct.ImageHover = ((System.Drawing.Image)(resources.GetObject("cbProduct.ImageHover")));
            this.cbProduct.ImageNormal = ((System.Drawing.Image)(resources.GetObject("cbProduct.ImageNormal")));
            this.cbProduct.Location = new System.Drawing.Point(488, 26);
            this.cbProduct.Name = "cbProduct";
            this.cbProduct.Size = new System.Drawing.Size(33, 38);
            this.cbProduct.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.cbProduct.TabIndex = 0;
            this.cbProduct.TabStop = false;
            this.cbProduct.Click += new System.EventHandler(this.cbProduct_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(12, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(439, 34);
            this.label4.TabIndex = 8;
            this.label4.Text = "Inventory Management System";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Red;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 571);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(982, 32);
            this.panel2.TabIndex = 1;
            // 
            // panelMain
            // 
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 131);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(982, 440);
            this.panelMain.TabIndex = 2;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 603);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbShowOrder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbOrder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbCategories)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbCustomer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbProduct)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private CustomComponents.CustomButton cbProduct;
        private System.Windows.Forms.Label label2;
        private CustomComponents.CustomButton cbOrder;
        private CustomComponents.CustomButton cbUser;
        private CustomComponents.CustomButton cbCategories;
        private CustomComponents.CustomButton cbCustomer;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label9;
        private CustomComponents.CustomButton cbShowOrder;
    }
}