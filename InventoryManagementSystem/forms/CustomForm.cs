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
    public partial class CustomForm : Form
    {
        private readonly DBConnector _dbconnector;
        private readonly CustomerRepository _customerRepository;
        public CustomForm()
        {
            InitializeComponent();
            _dbconnector = new DBConnector();
            _customerRepository = new CustomerRepository(_dbconnector);
            LoadCustomer();
        }

        public void LoadCustomer()
        {
            dgCustomer.Rows.Clear();
            int i = 1;
            var result = _customerRepository.GetAllCustomers();
            foreach( var customer in result)
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
        private void cbAddUser_Click(object sender, EventArgs e)
        {
            CustomerModuleForm customerModelForm = new CustomerModuleForm();
            customerModelForm.bCustomerSave.Enabled = true;
            customerModelForm.bCustomerUpdate.Enabled = false;
            customerModelForm.bCustomerClear.Enabled = true;
            customerModelForm.ShowDialog();
            LoadCustomer();
        }

        private void dgCustomer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dgCustomer.Columns[e.ColumnIndex].Name;
            if(colName == "Edit")
            {
                int customerId = Convert.ToInt32(dgCustomer.Rows[e.RowIndex].Cells["CustomerId"].Value.ToString());
                CustomerModuleForm customerModelForm = new CustomerModuleForm(customerId);
                customerModelForm.tbCustomerName.Text = dgCustomer.Rows[e.RowIndex].Cells["CustomerName"].Value.ToString();
                customerModelForm.tbCoustomerPhone.Text = dgCustomer.Rows[e.RowIndex].Cells["Phone"].Value.ToString();
                customerModelForm.bCustomerSave.Enabled = false;
                customerModelForm.bCustomerUpdate.Enabled = true;
                customerModelForm.bCustomerClear.Enabled = true;
                customerModelForm.ShowDialog();
                LoadCustomer();
            }
            else if(colName == "Delete")
            {
                if(MessageBox.Show("Are you want to delete this record","Delete Customer",MessageBoxButtons.YesNo,MessageBoxIcon.Warning)== DialogResult.Yes)
                {
                    int customerId = Convert.ToInt32(dgCustomer.Rows[e.RowIndex].Cells["CustomerId"].Value.ToString());
                    try
                    {
                        bool result = _customerRepository.DeleteCustomer(customerId);
                        if(result)
                        {
                            MessageBox.Show("Customer Delete Successfully");
                            LoadCustomer();
                        }
                    }catch(Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error");
                    }
                }
            }
        }
    }
}
