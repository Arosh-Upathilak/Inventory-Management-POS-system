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
    public partial class ProductForm : Form
    {
        private readonly DBConnector _dbconnector;
        private readonly ProductReposiory _productreposiory;
        public ProductForm()
        {
            InitializeComponent();
            _dbconnector = new DBConnector();
            _productreposiory = new ProductReposiory(_dbconnector);
            LoadProduct();
        }

        private void cbAddProduct_Click(object sender, EventArgs e)
        {
            ProductModuleForm productModuleForm = new ProductModuleForm();
            productModuleForm.bProductSave.Enabled = true;
            productModuleForm.bProductUpdate.Enabled = false;
            productModuleForm.bProductClear.Enabled = true;
            productModuleForm.ShowDialog();
            LoadProduct();
        }

        private void LoadProduct()
        {
            dgProduct.Rows.Clear();
            int i = 1;
            var result = _productreposiory.GetAllProducts();
            foreach (var product in result)
            {
                dgProduct.Rows.Add(
                    i,
                    product.productId,
                    product.productName,
                    product.productQuantity,
                    product.productPrice,
                    product.productDescription,
                    product.productCategory
                );
                ++i;
            }
        }

        private void dgProduct_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dgProduct.Columns[e.ColumnIndex].Name;
            if (colName == "Edit")
            {
                ProductModuleForm productModuleForm = new ProductModuleForm();
                productModuleForm.lproductId.Text = dgProduct.Rows[e.RowIndex].Cells["ProductId"].Value.ToString();
                productModuleForm.tbProductName.Text = dgProduct.Rows[e.RowIndex].Cells["ProductName"].Value.ToString();
                productModuleForm.tbQuantity.Text = dgProduct.Rows[e.RowIndex].Cells["ProductQty"].Value.ToString();
                productModuleForm.tbPrice.Text = dgProduct.Rows[e.RowIndex].Cells["ProductPrice"].Value.ToString();
                productModuleForm.tbDescription.Text = dgProduct.Rows[e.RowIndex].Cells["ProductDescription"].Value.ToString();
                productModuleForm.cbCategory.Text = dgProduct.Rows[e.RowIndex].Cells["ProductCategory"].Value.ToString();
                productModuleForm.bProductSave.Enabled = false;
                productModuleForm.bProductUpdate.Enabled = true;
                productModuleForm.bProductClear.Enabled = true;
                productModuleForm.ShowDialog();
                LoadProduct();
            }
            else if (colName == "Delete")
            {
                if (MessageBox.Show("Are you want to delete this record", "Delete Product", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    int productId = Convert.ToInt32(dgProduct.Rows[e.RowIndex].Cells["ProductId"].Value.ToString());
                    try
                    {
                        bool result = _productreposiory.DeleteProduct(productId);
                        if (result)
                        {
                            MessageBox.Show("Product Delete Successfully");
                            LoadProduct();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error");
                    }
                }
            }
        }
    }
}
