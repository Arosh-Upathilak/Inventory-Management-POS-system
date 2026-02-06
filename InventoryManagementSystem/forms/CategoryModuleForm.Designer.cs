namespace InventoryManagementSystem.Forms
{
    partial class CategoryModuleForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CategoryModuleForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pbClose = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bCatogoryClear = new System.Windows.Forms.Button();
            this.bCatogoryUpdate = new System.Windows.Forms.Button();
            this.bCatogorySave = new System.Windows.Forms.Button();
            this.tbCategoryName = new System.Windows.Forms.TextBox();
            this.CustomerName = new System.Windows.Forms.Label();
            this.categoryId = new System.Windows.Forms.Label();
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
            this.label1.Size = new System.Drawing.Size(152, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Category Module";
            // 
            // bCatogoryClear
            // 
            this.bCatogoryClear.BackColor = System.Drawing.Color.Red;
            this.bCatogoryClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bCatogoryClear.FlatAppearance.BorderSize = 0;
            this.bCatogoryClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bCatogoryClear.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bCatogoryClear.ForeColor = System.Drawing.Color.White;
            this.bCatogoryClear.Location = new System.Drawing.Point(603, 213);
            this.bCatogoryClear.Name = "bCatogoryClear";
            this.bCatogoryClear.Size = new System.Drawing.Size(102, 38);
            this.bCatogoryClear.TabIndex = 33;
            this.bCatogoryClear.Text = "Clear";
            this.bCatogoryClear.UseVisualStyleBackColor = false;
            this.bCatogoryClear.Click += new System.EventHandler(this.bCustomerClear_Click);
            // 
            // bCatogoryUpdate
            // 
            this.bCatogoryUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.bCatogoryUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bCatogoryUpdate.FlatAppearance.BorderSize = 0;
            this.bCatogoryUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bCatogoryUpdate.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bCatogoryUpdate.ForeColor = System.Drawing.Color.White;
            this.bCatogoryUpdate.Location = new System.Drawing.Point(494, 213);
            this.bCatogoryUpdate.Name = "bCatogoryUpdate";
            this.bCatogoryUpdate.Size = new System.Drawing.Size(102, 38);
            this.bCatogoryUpdate.TabIndex = 32;
            this.bCatogoryUpdate.Text = "Update";
            this.bCatogoryUpdate.UseVisualStyleBackColor = false;
            this.bCatogoryUpdate.Click += new System.EventHandler(this.bCatogoryUpdate_Click);
            // 
            // bCatogorySave
            // 
            this.bCatogorySave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.bCatogorySave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bCatogorySave.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
            this.bCatogorySave.FlatAppearance.BorderSize = 0;
            this.bCatogorySave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.bCatogorySave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bCatogorySave.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bCatogorySave.ForeColor = System.Drawing.Color.White;
            this.bCatogorySave.Location = new System.Drawing.Point(386, 213);
            this.bCatogorySave.Name = "bCatogorySave";
            this.bCatogorySave.Size = new System.Drawing.Size(102, 38);
            this.bCatogorySave.TabIndex = 31;
            this.bCatogorySave.Text = "Save";
            this.bCatogorySave.UseVisualStyleBackColor = false;
            this.bCatogorySave.Click += new System.EventHandler(this.bCatogorySave_Click);
            // 
            // tbCategoryName
            // 
            this.tbCategoryName.Location = new System.Drawing.Point(202, 145);
            this.tbCategoryName.Name = "tbCategoryName";
            this.tbCategoryName.Size = new System.Drawing.Size(502, 28);
            this.tbCategoryName.TabIndex = 28;
            // 
            // CustomerName
            // 
            this.CustomerName.AutoSize = true;
            this.CustomerName.Location = new System.Drawing.Point(46, 148);
            this.CustomerName.Name = "CustomerName";
            this.CustomerName.Size = new System.Drawing.Size(150, 21);
            this.CustomerName.TabIndex = 27;
            this.CustomerName.Text = "Category Name:";
            // 
            // categoryId
            // 
            this.categoryId.AutoSize = true;
            this.categoryId.Location = new System.Drawing.Point(51, 224);
            this.categoryId.Name = "categoryId";
            this.categoryId.Size = new System.Drawing.Size(111, 21);
            this.categoryId.TabIndex = 34;
            this.categoryId.Text = "Category Id";
            this.categoryId.Visible = false;
            // 
            // CategoryModuleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 280);
            this.Controls.Add(this.categoryId);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.bCatogoryClear);
            this.Controls.Add(this.bCatogoryUpdate);
            this.Controls.Add(this.bCatogorySave);
            this.Controls.Add(this.tbCategoryName);
            this.Controls.Add(this.CustomerName);
            this.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CategoryModuleForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CategoriesModuleForm";
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
        public System.Windows.Forms.Button bCatogoryClear;
        public System.Windows.Forms.Button bCatogoryUpdate;
        public System.Windows.Forms.Button bCatogorySave;
        public System.Windows.Forms.TextBox tbCategoryName;
        private System.Windows.Forms.Label CustomerName;
        public System.Windows.Forms.Label categoryId;
    }
}