namespace InventoryManagementSystem.Forms
{
    partial class CustomerModuleForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerModuleForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pbClose = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bCustomerClear = new System.Windows.Forms.Button();
            this.bCustomerUpdate = new System.Windows.Forms.Button();
            this.bCustomerSave = new System.Windows.Forms.Button();
            this.tbCoustomerPhone = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbCustomerName = new System.Windows.Forms.TextBox();
            this.CustomerName = new System.Windows.Forms.Label();
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
            this.panel1.TabIndex = 14;
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
            this.label1.Size = new System.Drawing.Size(154, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Customer Module";
            // 
            // bCustomerClear
            // 
            this.bCustomerClear.BackColor = System.Drawing.Color.Red;
            this.bCustomerClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bCustomerClear.FlatAppearance.BorderSize = 0;
            this.bCustomerClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bCustomerClear.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bCustomerClear.ForeColor = System.Drawing.Color.White;
            this.bCustomerClear.Location = new System.Drawing.Point(605, 263);
            this.bCustomerClear.Name = "bCustomerClear";
            this.bCustomerClear.Size = new System.Drawing.Size(102, 38);
            this.bCustomerClear.TabIndex = 25;
            this.bCustomerClear.Text = "Clear";
            this.bCustomerClear.UseVisualStyleBackColor = false;
            this.bCustomerClear.Click += new System.EventHandler(this.bCustomerClear_Click);
            // 
            // bCustomerUpdate
            // 
            this.bCustomerUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.bCustomerUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bCustomerUpdate.FlatAppearance.BorderSize = 0;
            this.bCustomerUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bCustomerUpdate.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bCustomerUpdate.ForeColor = System.Drawing.Color.White;
            this.bCustomerUpdate.Location = new System.Drawing.Point(496, 263);
            this.bCustomerUpdate.Name = "bCustomerUpdate";
            this.bCustomerUpdate.Size = new System.Drawing.Size(102, 38);
            this.bCustomerUpdate.TabIndex = 24;
            this.bCustomerUpdate.Text = "Update";
            this.bCustomerUpdate.UseVisualStyleBackColor = false;
            this.bCustomerUpdate.Click += new System.EventHandler(this.bCustomerUpdate_Click);
            // 
            // bCustomerSave
            // 
            this.bCustomerSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.bCustomerSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bCustomerSave.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
            this.bCustomerSave.FlatAppearance.BorderSize = 0;
            this.bCustomerSave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.bCustomerSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bCustomerSave.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bCustomerSave.ForeColor = System.Drawing.Color.White;
            this.bCustomerSave.Location = new System.Drawing.Point(388, 263);
            this.bCustomerSave.Name = "bCustomerSave";
            this.bCustomerSave.Size = new System.Drawing.Size(102, 38);
            this.bCustomerSave.TabIndex = 23;
            this.bCustomerSave.Text = "Save";
            this.bCustomerSave.UseVisualStyleBackColor = false;
            this.bCustomerSave.Click += new System.EventHandler(this.bCustomerSave_Click);
            // 
            // tbCoustomerPhone
            // 
            this.tbCoustomerPhone.Location = new System.Drawing.Point(202, 192);
            this.tbCoustomerPhone.Name = "tbCoustomerPhone";
            this.tbCoustomerPhone.Size = new System.Drawing.Size(502, 28);
            this.tbCoustomerPhone.TabIndex = 22;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(129, 199);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 21);
            this.label5.TabIndex = 21;
            this.label5.Text = "Phone:";
            // 
            // tbCustomerName
            // 
            this.tbCustomerName.Location = new System.Drawing.Point(202, 125);
            this.tbCustomerName.Name = "tbCustomerName";
            this.tbCustomerName.Size = new System.Drawing.Size(502, 28);
            this.tbCustomerName.TabIndex = 16;
            // 
            // CustomerName
            // 
            this.CustomerName.AutoSize = true;
            this.CustomerName.Location = new System.Drawing.Point(45, 128);
            this.CustomerName.Name = "CustomerName";
            this.CustomerName.Size = new System.Drawing.Size(151, 21);
            this.CustomerName.TabIndex = 15;
            this.CustomerName.Text = "Customer Name:";
            // 
            // CustomerModelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 340);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.bCustomerClear);
            this.Controls.Add(this.bCustomerUpdate);
            this.Controls.Add(this.bCustomerSave);
            this.Controls.Add(this.tbCoustomerPhone);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbCustomerName);
            this.Controls.Add(this.CustomerName);
            this.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CustomerModelForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CustomerModelForm";
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
        public System.Windows.Forms.Button bCustomerClear;
        public System.Windows.Forms.Button bCustomerUpdate;
        public System.Windows.Forms.Button bCustomerSave;
        public System.Windows.Forms.TextBox tbCoustomerPhone;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox tbCustomerName;
        private System.Windows.Forms.Label CustomerName;
    }
}