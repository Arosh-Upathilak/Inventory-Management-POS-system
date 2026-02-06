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
    public partial class ProductModuleForm : Form
    {
        private readonly DBConnector _dbconnector;
        private readonly CategoryRepository _categoryRepository;
        private readonly ProductReposiory _productRepository;
        public ProductModuleForm()
        {
            InitializeComponent();
            _dbconnector = new DBConnector();
            _categoryRepository = new CategoryRepository(_dbconnector);
            _productRepository = new ProductReposiory(_dbconnector);
            LoadCategory();
        }

        private void pbClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LoadCategory()
        {
            cbCategory.Items.Clear();
            var result = _categoryRepository.GetAllCategory();
            foreach(var category in result)
            {
                cbCategory.Items.Add(category.categoryname);
            }
            
        }

        private void bCustomerClear_Click(object sender, EventArgs e)
        {
            ClearInput();
        }

        private void ClearInput()
        {
            tbProductName.Clear();
            tbQuantity.Clear();
            tbPrice.Clear();
            tbDescription.Clear();
            cbCategory.Items.Clear();
            LoadCategory();
        }

        private void bProductSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbProductName.Text) || string.IsNullOrEmpty(tbQuantity.Text) || string.IsNullOrEmpty(tbPrice.Text) || string.IsNullOrEmpty(tbDescription.Text) || string.IsNullOrEmpty(cbCategory.Items.ToString()))
            {
                MessageBox.Show("All feild must be filed", "Error", MessageBoxButtons.OKCancel);
                ClearInput();
                return;
            }
            try
            {
                if (MessageBox.Show("Are you want to create this product", "Create Product", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    ProductDto productDto = new ProductDto()
                    {
                        productName = tbProductName.Text.Trim(),
                        productQuantity = Convert.ToInt32(tbQuantity.Text.Trim()),
                        productPrice = Convert.ToInt32(tbPrice.Text.Trim()),
                        productDescription = tbDescription.Text.Trim(),
                        productCategory = cbCategory.Text.Trim(),
                    };
                    _productRepository.CreateProduct(productDto);
                    MessageBox.Show("Product Create Successfull", "Success");
                    ClearInput();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void bProductUpdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbProductName.Text) || string.IsNullOrEmpty(tbQuantity.Text) || string.IsNullOrEmpty(tbPrice.Text) || string.IsNullOrEmpty(tbDescription.Text) || string.IsNullOrEmpty(cbCategory.Items.ToString()))
            {
                MessageBox.Show("All feild required", "Error");
                return;
            }
            try
            {
                if (MessageBox.Show("Are you want to update this record", "Update Product", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    ProductDto productDto = new ProductDto()
                    {
                        productId = Convert.ToInt32(lproductId.Text.Trim()),
                        productName = tbProductName.Text.Trim(),
                        productQuantity = Convert.ToInt32(tbQuantity.Text.Trim()),
                        productPrice = Convert.ToInt32(tbPrice.Text.Trim()),
                        productDescription = tbDescription.Text.Trim(),
                        productCategory = cbCategory.Text.Trim(),
                    };
                    bool result = _productRepository.UpdateProduct(productDto);
                    if (result)
                    {
                        MessageBox.Show("Product Update Succesfully");
                        ClearInput();
                        this.Dispose();
                    }
                    else
                    {
                        MessageBox.Show("Product Update Failed.", "Error");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }
    }
}
