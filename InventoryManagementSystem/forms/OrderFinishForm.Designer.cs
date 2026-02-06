namespace InventoryManagementSystem.Forms
{
    partial class OrderFinishForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrderFinishForm));
            panel1 = new Panel();
            pbClose = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            lbalance = new Label();
            bPrintBill = new Button();
            bClose = new Button();
            lCustomerName = new Label();
            lCashierName = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbClose).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Red;
            panel1.Controls.Add(pbClose);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(656, 71);
            panel1.TabIndex = 15;
            // 
            // pbClose
            // 
            pbClose.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pbClose.Cursor = Cursors.Hand;
            pbClose.Image = (Image)resources.GetObject("pbClose.Image");
            pbClose.Location = new Point(633, 3);
            pbClose.Name = "pbClose";
            pbClose.Size = new Size(20, 20);
            pbClose.SizeMode = PictureBoxSizeMode.AutoSize;
            pbClose.TabIndex = 11;
            pbClose.TabStop = false;
            pbClose.Click += pbClose_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 16.2F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(234, 18);
            label1.Name = "label1";
            label1.Size = new Size(174, 34);
            label1.TabIndex = 0;
            label1.Text = "Finish Order";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(104, 136);
            label2.Name = "label2";
            label2.Size = new Size(238, 34);
            label2.TabIndex = 12;
            label2.Text = "Your Balance is :";
            // 
            // lbalance
            // 
            lbalance.AutoSize = true;
            lbalance.Font = new Font("Century Gothic", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbalance.Location = new Point(372, 136);
            lbalance.Name = "lbalance";
            lbalance.Size = new Size(131, 34);
            lbalance.TabIndex = 16;
            lbalance.Text = "balance";
            // 
            // bPrintBill
            // 
            bPrintBill.Location = new Point(110, 237);
            bPrintBill.Name = "bPrintBill";
            bPrintBill.Size = new Size(185, 36);
            bPrintBill.TabIndex = 17;
            bPrintBill.Text = "Downlod Bill";
            bPrintBill.UseVisualStyleBackColor = true;
            bPrintBill.Click += bPrintBill_Click;
            // 
            // bClose
            // 
            bClose.Location = new Point(354, 237);
            bClose.Name = "bClose";
            bClose.Size = new Size(185, 36);
            bClose.TabIndex = 18;
            bClose.Text = "Close";
            bClose.UseVisualStyleBackColor = true;
            bClose.Click += bClose_Click;
            // 
            // lCustomerName
            // 
            lCustomerName.AutoSize = true;
            lCustomerName.Location = new Point(42, 97);
            lCustomerName.Name = "lCustomerName";
            lCustomerName.Size = new Size(146, 21);
            lCustomerName.TabIndex = 19;
            lCustomerName.Text = "Customer Name";
            lCustomerName.Visible = false;
            // 
            // lCashierName
            // 
            lCashierName.AutoSize = true;
            lCashierName.Location = new Point(223, 97);
            lCashierName.Name = "lCashierName";
            lCashierName.Size = new Size(128, 21);
            lCashierName.TabIndex = 20;
            lCashierName.Text = "Cashier Name";
            lCashierName.Visible = false;
            // 
            // OrderFinishForm
            // 
            AutoScaleDimensions = new SizeF(10F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(656, 296);
            Controls.Add(lCashierName);
            Controls.Add(lCustomerName);
            Controls.Add(bClose);
            Controls.Add(bPrintBill);
            Controls.Add(lbalance);
            Controls.Add(label2);
            Controls.Add(panel1);
            Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "OrderFinishForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "OrderFinishForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbClose).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pbClose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label lbalance;
        private System.Windows.Forms.Button bPrintBill;
        private System.Windows.Forms.Button bClose;
        public System.Windows.Forms.Label lCustomerName;
        public System.Windows.Forms.Label lCashierName;
    }
}