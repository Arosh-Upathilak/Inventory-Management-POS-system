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
    public partial class OrderForm : Form
    {
        private readonly DBConnector _dbconnector;
        private readonly OrderRepository _orderreposiory;
        private readonly TempOrderRepository _temporderreposiory;
        private readonly string _cashierName;
        public OrderForm(string fullname="")
        {
            InitializeComponent();
            _cashierName = fullname;
            tbCasherName.Text = _cashierName;
            _dbconnector = new DBConnector();
            _orderreposiory = new OrderRepository(_dbconnector);
            _temporderreposiory = new TempOrderRepository(_dbconnector);
            LoadOrder();
        }

        private void cbAddProduct_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbCustomer.Text))
            {
                MessageBox.Show("Select the Customer First", "Warning");
                return;
            }
            OrderModuleForm orderModuleForm = new OrderModuleForm();
            orderModuleForm.lCId.Text = lCustomerID.Text.Trim();
            orderModuleForm.bOrderSave.Enabled = true;
            orderModuleForm.bOrderClear.Enabled = true;
            orderModuleForm.ShowDialog();
            LoadOrder();
        }

        private void LoadOrder()
        {
            dgOrder.Rows.Clear();
            int i = 0;
            int totalAmount = 0;
            var result = _temporderreposiory.TempGetAllOrders();
            foreach (var order in result)
            {
                dgOrder.Rows.Add(
                    ++i,
                    order.temorderId,
                    order.orderId,
                    order.temorderDate,
                    order.temproductName,
                    order.temqty,
                    order.temprice,
                    order.temtPrice
                );
                totalAmount += Convert.ToInt32(order.temtPrice);
            }
            lQuantity.Text = i.ToString();
            lTotalAmount.Text = "RS: "+totalAmount.ToString() + " /=";
            tbCustomerMoney.Clear();

        }

        private void pAddCustomer_Click(object sender, EventArgs e)
        {
            OrderAddCustomerForm orderAddCustomerForm = new OrderAddCustomerForm(this);
            orderAddCustomerForm.ShowDialog();
        }

        private void dgProduct_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dgOrder.Columns[e.ColumnIndex].Name;
            if (colName == "Edit")
            {
                int orderId = Convert.ToInt32(dgOrder.Rows[e.RowIndex].Cells["OrderId"].Value.ToString());
                int temorderId = Convert.ToInt32(dgOrder.Rows[e.RowIndex].Cells["TOID"].Value.ToString());
                var result = _orderreposiory.GetOrderById(orderId);
                OrderEditForm orderEditForm = new OrderEditForm(result);
                orderEditForm.lOId.Text = temorderId.ToString();
                orderEditForm.ShowDialog();
                LoadOrder();
            }
            else if (colName == "Delete")
            {
                if (MessageBox.Show("Are you want to delete this record", "Delete Order", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    int orderId = Convert.ToInt32(dgOrder.Rows[e.RowIndex].Cells["OrderId"].Value.ToString());
                    int temorderId = Convert.ToInt32(dgOrder.Rows[e.RowIndex].Cells["TOID"].Value.ToString());
                    try
                    {
                        bool result = _orderreposiory.DeleteOrder(orderId);
                        bool deleteresult =_temporderreposiory.TempDeleteOrder(temorderId);
                        if (result && deleteresult)
                        {
                            MessageBox.Show("Order Delete Successfully");
                            LoadOrder();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error");
                    }
                }
            }
        }

        private void bFinish_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbCustomerMoney.Text))
            {
                MessageBox.Show("Please do the payment");
                return;
            }
            string numbersOnly = new string(lTotalAmount.Text.Where(char.IsDigit).ToArray());
            int totalAmount = Convert.ToInt32(numbersOnly);
            int payAmount = Convert.ToInt32(tbCustomerMoney.Text);
            if (totalAmount <= payAmount)
            {
                List<TempOrderDto> orderList = _temporderreposiory.TempGetAllOrders();
                OrderFinishForm orderFinishForm = new OrderFinishForm(this, orderList, totalAmount, payAmount);
                orderFinishForm.lbalance.Text = "Rs: " + (payAmount - totalAmount).ToString() + "/=";
                orderFinishForm.lCustomerName.Text = tbCustomer.Text;
                orderFinishForm.lCashierName.Text = tbCasherName.Text;
                orderFinishForm.ShowDialog();
                LoadOrder();
            }
            else
            {
                MessageBox.Show("Please pay the full payment", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                tbCustomerMoney.Clear();
            }
        }
    }
}
