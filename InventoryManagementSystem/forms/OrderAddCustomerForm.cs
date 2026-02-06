using InventoryManagementSystem.Data;
using InventoryManagementSystem.Repository;
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
    public partial class OrderAddCustomerForm : Form
    {
        private readonly DBConnector _dbconnector;
        private readonly CustomerRepository _customerRepository;
        private readonly OrderForm _orderForm;
        public OrderAddCustomerForm(OrderForm orderForm)
        {
            InitializeComponent();
            _orderForm = orderForm;
            _dbconnector = new DBConnector();
            _customerRepository = new CustomerRepository(_dbconnector);
            LoadCustomer();
        }

        private void pbClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void LoadCustomer()
        {
            dgCustomer.Rows.Clear();
            string searchValue = tbSearchCustomer.Text.Trim();
            int i = 1;
            var result = _customerRepository.GetAllCustomers(searchValue);
            foreach (var customer in result)
            {
                dgCustomer.Rows.Add(
                    i,
                    customer.customerId,
                    customer.customerName,
                    customer.customerPhone
                );
                ++i;
            }
        }

        private void dgCustomer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tbCustomerId.Text = dgCustomer.Rows[e.RowIndex].Cells["CustomerId"].Value.ToString();
            tbCustomerName.Text = dgCustomer.Rows[e.RowIndex].Cells["CustomerName"].Value.ToString();
        }

        private void bOrderClear_Click(object sender, EventArgs e)
        {
            ClearTextBox();
        }

        private void ClearTextBox()
        {
            tbCustomerId.Clear();
            tbCustomerName.Clear();
            tbSearchCustomer.Clear();
        }

        private void bOrderSave_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(tbCustomerId.Text) || string.IsNullOrEmpty(tbCustomerName.Text))
            {
                MessageBox.Show("Please Select the Customer");
                return;
            }
            OrderForm orderForm = new OrderForm();
            _orderForm.tbCustomer.Text = tbCustomerName.Text.Trim();
            _orderForm.lCustomerID.Text = tbCustomerId.Text.Trim();
            ClearTextBox();
            this.Close();
        }

        private void tbSearchCustomer_TextChanged(object sender, EventArgs e)
        {
            LoadCustomer();
        }
    }
}
