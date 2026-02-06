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
    public partial class OrderModuleForm : Form
    {
        private readonly DBConnector _dbconnector;
        private readonly ProductReposiory _productreposiory;
        private readonly OrderRepository _ordertreposiory;
        private int quantity;

        public OrderModuleForm()
        {
            InitializeComponent();
            _dbconnector = new DBConnector();
            _productreposiory = new ProductReposiory(_dbconnector);
            _ordertreposiory = new OrderRepository(_dbconnector);
            LoadProduct();
        }

        private void LoadProduct()
        {
            dgProduct.Rows.Clear();
            string textSearch = tbSearchProduct.Text.Trim();
            int i = 1;
            var result = _productreposiory.GetAllProducts(textSearch);
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


        private void dgProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            tbProductId.Text = dgProduct.Rows[e.RowIndex].Cells["ProductId"].Value.ToString();
            tbProductName.Text = dgProduct.Rows[e.RowIndex].Cells["ProductName"].Value.ToString();
            tbUnitPrice.Text = dgProduct.Rows[e.RowIndex].Cells["ProductPrice"].Value.ToString();
            quantity = Convert.ToInt32(dgProduct.Rows[e.RowIndex].Cells["ProductQty"].Value.ToString());
            if (quantity > 0)
            {
                nudQty.Minimum = 1;
            }
            else
            {
                nudQty.Minimum = 0;
            }
            int total = Convert.ToInt32(tbUnitPrice.Text) * Convert.ToInt32(nudQty.Value);
            tbTotalPrice.Text = total.ToString();
        }
        private void nudQty_ValueChanged(object sender, EventArgs e)
        {
            if (!int.TryParse(tbUnitPrice.Text, out int unitPrice))
                return;

            if (quantity < Convert.ToInt32(nudQty.Value))
            {
                MessageBox.Show("In the Stock not enougth quantity", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                nudQty.Value = Convert.ToInt32(quantity);
                return;
            }
            tbTotalPrice.Text = (unitPrice * (int)nudQty.Value).ToString();
        }

        private void ClearInput()
        {
            tbProductId.Clear();
            tbProductName.Clear();
            tbUnitPrice.Clear();
            tbTotalPrice.Clear();
            dtpDate.Value = DateTime.Now;
            nudQty.Value = nudQty.Minimum;
            LoadProduct();
        }

        private void bOrderSave_Click(object sender, EventArgs e)
        {
            if ( string.IsNullOrEmpty(tbProductId.Text) || string.IsNullOrEmpty(tbProductName.Text) || string.IsNullOrEmpty(tbUnitPrice.ToString()) || string.IsNullOrEmpty(tbTotalPrice.ToString()))
            {
                MessageBox.Show("Oroducts all feilds must be filed", "Error", MessageBoxButtons.OKCancel);
                ClearInput();
                return;
            }
            try
            {
                if (MessageBox.Show("Are you want to create this Order", "Create Order", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    OrderDto orderDto = new OrderDto()
                    {
                        orderDate = dtpDate.Value,
                        productId = Convert.ToInt16(tbProductId.Text.Trim()),
                        productName = tbProductName.Text.Trim(),
                        customerId = Convert.ToInt16(lCId.Text.Trim()),
                        qty = Convert.ToInt16(nudQty.Value),
                        price = Convert.ToInt32(tbUnitPrice.Text.Trim()),
                        tPrice = Convert.ToInt32(tbTotalPrice.Text.Trim())
                    }; 
                    _ordertreposiory.CreateOrder(orderDto);
                    MessageBox.Show("Product Create Successfull", "Success");
                    ClearInput();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void pbClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tbSearchProduct_TextChanged(object sender, EventArgs e)
        {
            LoadProduct();
        }
    }
}
