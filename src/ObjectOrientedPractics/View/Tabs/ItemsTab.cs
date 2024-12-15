using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ObjectOrientedPractics.Model.Enums;

namespace ObjectOrientedPractics.View.Tabs
{
    public partial class ItemsTab : UserControl
    {
        private List<Item> _items = new List<Item>();
        private Item _item;

        public List<Item> Items
        {
            get
            {
                return _items;
            }
            set
            {
                _items = value;
                UpdateItemsListBox();
            }
        }

        private void UpdateItemsListBox()
        {
            ItemsListBox.Items.Clear();
            foreach (var item in _items)
            {
                ItemsListBox.Items.Add(item.Name);
            }
        }

        public ItemsTab()
        {
            InitializeComponent();
            CategoryComboBox.DataSource = Enum.GetValues(typeof(Category));
            CategoryComboBox.Text = null;
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            try
            {
                Item addItem = new Item(
                    NameTextBox.Text, DiscriptionTextBox.Text,
                    float.Parse(CostTextBox.Text),
                    (Category)CategoryComboBox.SelectedItem);

                _items.Add(addItem);
                ItemsListBox.Items.Add(addItem.Name + " - " +
                    addItem.Cost + " руб.");

                ItemsClear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Произошла ошибка при добавлении товара: "
                    + ex.Message);
            }
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            if (ItemsListBox.SelectedIndex >= 0
                && ItemsListBox.SelectedIndex < _items.Count)
            {
                _items.RemoveAt(ItemsListBox.SelectedIndex);
                ItemsListBox.Items.RemoveAt(ItemsListBox.SelectedIndex);
                AddButton.Enabled = true;
                ItemsClear();
            }
        }

        private void ItemsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ItemsListBox.SelectedIndex >= 0
                && ItemsListBox.SelectedIndex < _items.Count)
            {
                _item = _items[ItemsListBox.SelectedIndex];
                NameTextBox.Text = _item.Name;
                DiscriptionTextBox.Text = _item.Info;
                CostTextBox.Text = Convert.ToString(_item.Cost);
                IdTextBox.Text = Convert.ToString(_item.Id);
                CategoryComboBox.SelectedItem = _item.Category;

                AddButton.Enabled = false;

            }
        }

        void ItemsClear()
        {
            NameTextBox.Text = "";
            DiscriptionTextBox.Text = "";
            CostTextBox.Text = "";
            IdTextBox.Text = "";
            CategoryComboBox.Text = null;

            NameTextBox.BackColor = Color.White;
            DiscriptionTextBox.BackColor = Color.White;
            CostTextBox.BackColor = Color.White;
            IdTextBox.BackColor = Color.White;
        }

        private void CostTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                CostTextBox.BackColor = System.Drawing.Color.White;
                Validator.AssertOnPositiveValue(
                    Convert.ToDouble(CostTextBox.Text), 0, 100_000, "Цена");

                if (ItemsListBox.SelectedIndex >= 0)
                {
                    _items[ItemsListBox.SelectedIndex].Cost =
                        float.Parse(CostTextBox.Text);

                    ItemsListBox.Items[ItemsListBox.SelectedIndex] =
                        (_items[ItemsListBox.SelectedIndex].Name +
                        " - " + _items[ItemsListBox.SelectedIndex].Cost);
                }
            }
            catch
            {
                CostTextBox.BackColor = System.Drawing.Color.LightPink;
            }
        }

        private void NameTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                NameTextBox.BackColor = System.Drawing.Color.White; ;
                Validator.AssertStringOnLength(NameTextBox.Text, 200, "Name");

                if (ItemsListBox.SelectedIndex >= 0)
                {
                    _items[ItemsListBox.SelectedIndex].Name =
                        NameTextBox.Text;

                    ItemsListBox.Items[ItemsListBox.SelectedIndex] =
                        (_items[ItemsListBox.SelectedIndex].Name +
                        " - " + _items[ItemsListBox.SelectedIndex].Cost);
                }
            }
            catch
            {
                NameTextBox.BackColor = System.Drawing.Color.LightPink;
            }
        }
        private void CategoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (ItemsListBox.SelectedIndex >= 0)
                {
                    _items[ItemsListBox.SelectedIndex].Category =
                        (Category)CategoryComboBox.SelectedItem;

                    ItemsListBox.Items[ItemsListBox.SelectedIndex] =
                        (_items[ItemsListBox.SelectedIndex].Name +
                        " - " +
                        _items[ItemsListBox.SelectedIndex].Cost + " руб.");
                }
            }
            catch { }
        }

        private void DiscriptionTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                DiscriptionTextBox.BackColor = System.Drawing.Color.White;
                Validator.AssertStringOnLength(
                    DiscriptionTextBox.Text, -1, 1000, "Информация о товаре");

                if (ItemsListBox.SelectedIndex >= 0)
                {
                    _items[ItemsListBox.SelectedIndex].Info
                        = DiscriptionTextBox.Text;
                }
            }
            catch
            {
                DiscriptionTextBox.BackColor = System.Drawing.Color.LightPink;
            }
        }

        private void ItemsTab_Click(object sender, EventArgs e)
        {
            if (ItemsListBox.SelectedIndex >= 0 &&
                    ItemsListBox.SelectedIndex
                    < _items.Count &&
                    AddButton.Enabled == false)
            {
                ItemsListBox.SetSelected(0, false);
                ItemsClear();
                AddButton.Enabled = true;
            }
        }
    }
}
