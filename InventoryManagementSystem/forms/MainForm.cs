using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryManagementSystem.Forms
{
    public partial class MainForm : Form
    {
        private readonly string _cashierName;
        public MainForm(string fullName="")
        {
            InitializeComponent();
            _cashierName = fullName;
            openChildForm(new ProductForm());
        }

        //To show the subform in mainform
        private Form activeform = null;
        private void openChildForm(Form childForm)
        {
            if(activeform != null)
            {
                activeform.Close();
            }
            activeform = childForm;
            activeform.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelMain.Controls.Add(childForm);
            panelMain.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void cbUser_Click(object sender, EventArgs e)
        {
            openChildForm(new UserForm());
        }

        private void cbCustomer_Click(object sender, EventArgs e)
        {
            openChildForm(new CustomForm());
        }

        private void cbCategories_Click(object sender, EventArgs e)
        {
            openChildForm(new CategoryForm());
        }

        private void cbProduct_Click(object sender, EventArgs e)
        {
            openChildForm(new ProductForm());
        }

        private void cbOrder_Click(object sender, EventArgs e)
        {
            openChildForm(new OrderForm(_cashierName));
        }

        private void cbShowOrder_Click(object sender, EventArgs e)
        {
            openChildForm(new ShowOrderForm());
        }
    }
}
