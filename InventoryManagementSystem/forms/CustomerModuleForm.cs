using InventoryManagementSystem.Data;
using InventoryManagementSystem.Dtos;
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
    public partial class CustomerModuleForm : Form
    {
        private readonly DBConnector _dbConnector;
        private readonly CustomerRepository _customerRepository;
        private int _customerId;
        public CustomerModuleForm()
        {
            InitializeComponent();
            _dbConnector = new DBConnector();
            _customerRepository = new CustomerRepository(_dbConnector);
        }
        public CustomerModuleForm(int customerId)
        {
            InitializeComponent();
            _customerId = customerId;
            _dbConnector = new DBConnector();
            _customerRepository = new CustomerRepository(_dbConnector);
        }
        private void pbClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ClearTextBox()
        {
            tbCustomerName.Clear();
            tbCoustomerPhone.Clear();
        }

        private void bCustomerSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbCustomerName.Text) || string.IsNullOrEmpty(tbCoustomerPhone.Text))
            {
                MessageBox.Show("All feild must be filed", "Error", MessageBoxButtons.OKCancel);
                ClearTextBox();
                return;
            }
            try
            {
                if (MessageBox.Show("Are you want to create this customer", "Create Customer", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) {
                    CustomerDto customerDto = new CustomerDto()
                    {
                        customerName = tbCustomerName.Text.Trim(),
                        customerPhone = tbCoustomerPhone.Text.Trim(),
                    };
                    _customerRepository.CreateCustomer(customerDto);
                    MessageBox.Show("User Create Successfull", "Success");
                    ClearTextBox();
                }
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void bCustomerClear_Click(object sender, EventArgs e)
        {
            ClearTextBox();
        }

        private void bCustomerUpdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbCustomerName.Text) || string.IsNullOrEmpty(tbCoustomerPhone.Text))
            {
                MessageBox.Show("All feild required", "Error");
                ClearTextBox();
                return;
            }
            try
            {
                if (MessageBox.Show("Are you want to update this record", "Update Customer", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    CustomerDto customerDto = new CustomerDto()
                    {
                        customerId = _customerId,
                        customerName = tbCustomerName.Text.Trim(),
                        customerPhone = tbCoustomerPhone.Text.Trim()
                    };
                    bool result = _customerRepository.UpdateCustomer(customerDto);
                    if (result)
                    {
                        MessageBox.Show("Customer Update Succesfully");
                        ClearTextBox();
                        this.Dispose();
                    }
                    else
                    {
                        MessageBox.Show("Customer Update Failed.", "Error");
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }
    }
}
