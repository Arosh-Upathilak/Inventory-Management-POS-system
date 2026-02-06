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
    public partial class OrderEditForm : Form
    {
        private OrderEditDto _order;
        int remaningproductQuantity;
        int orderQuantity;
        int totalQuantity;
        int unitPrice;
        int orderId;
        int productId;
        private readonly DBConnector _dbconnector;
        private readonly OrderRepository _orderreposiory;
        private readonly TempOrderRepository _temporderreposiory;
        public OrderEditForm(OrderEditDto order)
        {
            InitializeComponent();
            _order = order;
            LoadOrderEdit();
            _dbconnector = new DBConnector();
            _orderreposiory = new OrderRepository(_dbconnector);
            _temporderreposiory = new TempOrderRepository(_dbconnector);
        }

        private void pbClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void LoadOrderEdit()
        {
            dgProductEdit.Rows.Clear();
            dgProductEdit.Rows.Add(
                1,
                _order.productId,
                _order.productName,
                _order.productQuantity,
                _order.productPrice,
                _order.productDescription,
                _order.productCategory
             );
            productId = Convert.ToInt32(_order.productId);
            remaningproductQuantity = Convert.ToInt32(_order.productQuantity);
            tbProductId.Text = _order.productId.ToString();
            tbProductName.Text = _order.productName.ToString();
            dtpDate.Value = Convert.ToDateTime(_order.orderDate);
            tbUnitPrice.Text = _order.productPrice.ToString();
            unitPrice = Convert.ToInt32(_order.productPrice);
            nudQty.Value = Convert.ToInt32(_order.orderQuantity);
            orderQuantity = Convert.ToInt32(_order.orderQuantity);
            tbTotalPrice.Text = (Convert.ToInt32(_order.productPrice) * Convert.ToInt32(_order.orderQuantity)).ToString();
            totalQuantity = remaningproductQuantity + orderQuantity;
            lOId.Text = _order.orderId.ToString();
            orderId = Convert.ToInt32(_order.orderId);
        }

        private void nudQty_ValueChanged(object sender, EventArgs e)
        {
            tbTotalPrice.Text = (unitPrice * (int)nudQty.Value).ToString();
        }

        private void bOrderUpdate_Click(object sender, EventArgs e)
        {
            if (totalQuantity < Convert.ToInt32(nudQty.Value))
            {
                MessageBox.Show("In the Stock not enougth quantity", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                nudQty.Value = totalQuantity;
                return;
            }
            
            try
            {
                if (MessageBox.Show("Are you want to update this record", "Update Order", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    int tPrice = Convert.ToInt32(nudQty.Value) * unitPrice;
                    int qty = totalQuantity - Convert.ToInt32(nudQty.Value);
                    int orderqty = Convert.ToInt32(nudQty.Value);
                    int tempOrderId = Convert.ToInt32(lOId.Text);
                    bool result = _orderreposiory.UpdateOrder(orderId, orderqty, tPrice, productId, qty);
                    bool tempresult = _temporderreposiory.TempUpdateOrder(tempOrderId, orderqty, tPrice);
                    if (result && tempresult)
                    {
                        MessageBox.Show("Order Update Succesfully");
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
