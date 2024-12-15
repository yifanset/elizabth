using ObjectOrientedPractics.Model;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using ObjectOrientedPractics.Model.Order;
using ObjectOrientedPractics.Model.Enums;

namespace ObjectOrientedPractics.View.Tabs
{
    public partial class OrdersTab : UserControl
    {
        private List<Customer> _customers = new List<Customer>();
        private Order _currentOrder;
        private PriorityOrder _selectedPriorityOrder;

        public List<Customer> Customers
        {
            get { return _customers; }
            set
            {
                _customers = value;
                UpdateOrders();
            }
        }

        public OrdersTab()
        {
            InitializeComponent();
            StatusComboBox.DataSource = Enum.GetValues(typeof(OrderStatus));
            PrioretyPanel.Visible = false;
        }

        public void UpdateOrders()
        {
            OrdersDataGridView.Rows.Clear();

            foreach (var customer in _customers)
            {
                foreach (var order in customer.Orders)
                {
                    var address = order.Address;
                    var formattedAddress = string.Join(", ",
                        address.Index,
                        address.Country,
                        address.City,
                        address.Street,
                        address.Building,
                        address.Apartment);

                    OrdersDataGridView.Rows.Add(
                        order.Id,
                        order.Date.ToShortDateString(),
                        order.Status,
                        customer.Fullname,
                        formattedAddress,
                        order.TotalAmount,
                        order.Total);
                }
            }
        }

        public void RefreshData()
        {
            UpdateOrders();
        }

        private void OrdersDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            DisplaySelectedOrderDetails();
        }

        private void DisplaySelectedOrderDetails()
        {
            var currentRow = OrdersDataGridView.CurrentRow;
            if (currentRow == null) return;

            int orderId = (int)currentRow.Cells["OrderId"].Value;

            foreach (var customer in _customers)
            {
                foreach (var order in customer.Orders)
                {
                    if (order.Id == orderId)
                    {
                        ShowOrderDetails(order, customer);

                        if (order is PriorityOrder priorityOrder)
                        {
                            PrioretyPanel.Visible = true;
                            _selectedPriorityOrder = priorityOrder;
                        }
                        else
                        {
                            PrioretyPanel.Visible = false;
                            _selectedPriorityOrder = null;
                        }

                        return;
                    }
                }
            }
        }

        private void ShowOrderDetails(Order selectedOrder, Customer customer)
        {
            _currentOrder = selectedOrder;

            IdTextBox.Text = selectedOrder.Id.ToString();
            CreatedDataTextBox.Text = selectedOrder.Date.ToShortDateString();
            StatusComboBox.SelectedItem = selectedOrder.Status;

            AddressControl.Address = selectedOrder.Address;

            AddressControl.Enabled = false;
            IdTextBox.ReadOnly = true;
            CreatedDataTextBox.ReadOnly = true;

            OrderItemsListBox.Items.Clear();
            foreach (var item in selectedOrder.Items)
            {
                OrderItemsListBox.Items.Add($"{item.Name} - {item.Cost:C}");
            }
        }

        private void StatusComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_currentOrder == null) return;


            var selectedStatus = (OrderStatus)StatusComboBox.SelectedItem;
            _currentOrder.Status = selectedStatus;
            UpdateOrderStatusInGrid(_currentOrder.Id, selectedStatus);
        }

        private void UpdateOrderStatusInGrid(int orderId, OrderStatus status)
        {
            foreach (DataGridViewRow row in OrdersDataGridView.Rows)
            {
                if (row.Cells["OrderId"].Value != null && (int)row.Cells["OrderId"].Value == orderId)
                {
                    row.Cells["OrderStatus"].Value = status;
                    break;
                }
            }
        }

        private void DeliveryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_selectedPriorityOrder != null)
            {
                _selectedPriorityOrder.Time = (OrderTime)(DeliveryComboBox.SelectedIndex + 1);
            }
        }
    }
}
