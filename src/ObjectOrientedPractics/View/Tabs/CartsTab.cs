using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using ObjectOrientedPractics.Model;
using ObjectOrientedPractics.Model.Order;
using ObjectOrientedPractics.Model.Enums;

namespace ObjectOrientedPractics.View.Tabs
{
    public partial class CartsTab : UserControl
    {
        private Customer _currentCustomer;
        private List<Customer> _customers;
        private List<Item> _items;

        public double DiscountAmount { get; set; }

        public CartsTab()
        {
            InitializeComponent();
        }

        public List<Item> Items
        {
            get => _items;
            set
            {
                _items = value;
                UpdateItemsListBox();
            }
        }

        public List<Customer> Customers
        {
            get => _customers;
            set
            {
                _customers = value;
                UpdateCustomersComboBox();
            }
        }

        private void UpdateItemsListBox()
        {
            ItemsListBox.Items.Clear();
            if (_items != null)
            {
                foreach (var item in _items)
                {
                    ItemsListBox.Items.Add(item.Name);
                }
            }
        }

        private void UpdateCustomersComboBox()
        {
            CustomersComboBox.DataSource = null;
            if (_customers != null && _customers.Count > 0)
            {
                CustomersComboBox.DataSource = _customers;
                CustomersComboBox.DisplayMember = "FullName";
                CustomersComboBox.ValueMember = "Id";
            }
        }

        private void UpdateCartListBox()
        {
            CartsListBox.Items.Clear();
            if (_currentCustomer != null && _currentCustomer.Cart.Items != null)
            {
                foreach (var item in _currentCustomer.Cart.Items)
                {
                    CartsListBox.Items.Add(item.Name);
                }
            }
        }

        private void UpdateAmountLabels()
        {
            try
            {
                DiscountAmount = 0.0;

                foreach (var item in DiscountCheckedListBox.CheckedItems)
                {
                    var index = DiscountCheckedListBox.Items.IndexOf(item);
                    DiscountAmount += _currentCustomer.Discounts[index].Calculate(
                        _currentCustomer.Cart.Items);
                }

                var amount = _currentCustomer.Cart.Amount;
                amountLabel.Text = amount.ToString("F2");
                DiscountAmountLabel.Text = DiscountAmount.ToString("F2");
                TotalLabel.Text = (amount - DiscountAmount).ToString("F2");
            }
            catch { }
        }

        private void UpdateDiscountsCheckedListBox()
        {
            if (_currentCustomer == null || _currentCustomer.Discounts == null)
            {
                DiscountCheckedListBox.Items.Clear();
                DiscountCheckedListBox.Enabled = false;
                return;
            }

            DiscountCheckedListBox.Items.Clear();

            foreach (var discount in _currentCustomer.Discounts)
            {
                DiscountCheckedListBox.Items.Add(discount.Info);
            }

            for (int i = 0; i < DiscountCheckedListBox.Items.Count; i++)
            {
                DiscountCheckedListBox.SetItemChecked(i, true);
            }

            DiscountCheckedListBox.Enabled = true;
            UpdateAmountLabels();
        }

        private void CustomersComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            _currentCustomer = CustomersComboBox.SelectedItem as Customer;
            UpdateDiscountsCheckedListBox();
            UpdateCartListBox();
            UpdateAmountLabels();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            if (_currentCustomer != null && ItemsListBox.SelectedIndex >= 0)
            {
                var selectedItem = _items[ItemsListBox.SelectedIndex];
                _currentCustomer.Cart.Items.Add(selectedItem);
                UpdateCartListBox();
                UpdateAmountLabels();
            }
        }

        private void RemoveItemButton_Click(object sender, EventArgs e)
        {
            if (_currentCustomer != null && CartsListBox.SelectedIndex >= 0)
            {
                var selectedItem = _currentCustomer.Cart.Items[CartsListBox.SelectedIndex];
                _currentCustomer.Cart.Items.Remove(selectedItem);
                UpdateCartListBox();
                UpdateAmountLabels();
            }
        }

        private void CreateOrderButton_Click(object sender, EventArgs e)
        {
            if (_currentCustomer != null && _currentCustomer.Cart.Items.Any())
            {
                Order newOrder;
                if (_currentCustomer.IsPriority)
                {
                    newOrder = new PriorityOrder(
                        _currentCustomer.Address,
                        new List<Item>(_currentCustomer.Cart.Items),
                        DiscountAmount)
                    {
                        Status = OrderStatus.New,
                        Time = OrderTime.FromNineToElevenAM
                    };
                }
                else
                {
                    newOrder = new Order(
                        _currentCustomer.Address,
                        new List<Item>(_currentCustomer.Cart.Items),
                        DiscountAmount)
                    {
                        Status = OrderStatus.New
                    };
                }

                foreach (var item in DiscountCheckedListBox.CheckedItems)
                {
                    var index = DiscountCheckedListBox.Items.IndexOf(item);
                    _currentCustomer.Discounts[index].Apply(_currentCustomer.Cart.Items);
                }

                foreach (var discount in _currentCustomer.Discounts)
                {
                    discount.Update(_currentCustomer.Cart.Items);
                }

                _currentCustomer.Orders.Add(newOrder);
                _currentCustomer.Cart.Items.Clear();

                UpdateCartListBox();
                UpdateAmountLabels();
                UpdateDiscountsCheckedListBox();

                MessageBox.Show("Заказ успешно создан!");
            }
            else
            {
                MessageBox.Show("Корзина пуста или клиент не выбран.");
            }
        }

        public void RefreshData()
        {
            UpdateItemsListBox();
            UpdateCustomersComboBox();
            UpdateCartListBox();
            UpdateAmountLabels();
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            if (_currentCustomer != null)
            {
                _currentCustomer.Cart.Items.Clear();
                UpdateCartListBox();
                UpdateAmountLabels();
            }
        }

        private void DiscountCheckedListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateAmountLabels();
        }
    }
}
