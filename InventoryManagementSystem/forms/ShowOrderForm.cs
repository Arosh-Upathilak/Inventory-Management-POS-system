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
    public partial class ShowOrderForm : Form
    {
        private readonly DBConnector _dbconnector;
        private readonly OrderRepository _orderreposiory;
        public ShowOrderForm()
        {
            InitializeComponent();
            _dbconnector = new DBConnector();
            _orderreposiory = new OrderRepository(_dbconnector);
            LoadOrder();
        }

        private void LoadOrder()
        {
            dgOrder.Rows.Clear();
            int i = 0;
            string searchText = tbSeachOrder.Text;
            var result = _orderreposiory.GetAllOrders(searchText);
            foreach (var order in result)
            {
                dgOrder.Rows.Add(
                    ++i,
                    order.orderId,
                    order.orderDate,
                    order.productId,
                    order.customerId,
                    order.qty,
                    order.price,
                    order.tPrice
                );
            }
        }

        private void tbSeachOrder_TextChanged(object sender, EventArgs e)
        {
            LoadOrder();
        }
    }
}
