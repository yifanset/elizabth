namespace ObjectOrientedPractics
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            OrdersTabPadge = new TabPage();
            OrdersTab = new View.Tabs.OrdersTab();
            tabPage1 = new TabPage();
            CartsTabControl = new View.Tabs.CartsTab();
            CustomersTab = new TabPage();
            customersTab1 = new View.Tabs.CustomersTab();
            ItemsTabPage = new TabPage();
            itemsTab1 = new View.Tabs.ItemsTab();
            TabControl = new TabControl();
            OrdersTabPadge.SuspendLayout();
            tabPage1.SuspendLayout();
            CustomersTab.SuspendLayout();
            ItemsTabPage.SuspendLayout();
            TabControl.SuspendLayout();
            SuspendLayout();
            // 
            // OrdersTabPadge
            // 
            OrdersTabPadge.Controls.Add(OrdersTab);
            OrdersTabPadge.Location = new Point(4, 29);
            OrdersTabPadge.Name = "OrdersTabPadge";
            OrdersTabPadge.Padding = new Padding(3);
            OrdersTabPadge.Size = new Size(1104, 835);
            OrdersTabPadge.TabIndex = 3;
            OrdersTabPadge.Text = "Orders";
            OrdersTabPadge.UseVisualStyleBackColor = true;
            // 
            // OrdersTab
            // 
            OrdersTab.Dock = DockStyle.Fill;
            OrdersTab.Location = new Point(3, 3);
            OrdersTab.Name = "OrdersTab";
            OrdersTab.Size = new Size(1098, 829);
            OrdersTab.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(CartsTabControl);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1104, 835);
            tabPage1.TabIndex = 2;
            tabPage1.Text = "Carts";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // CartsTabControl
            // 
            CartsTabControl.Customers = null;
            CartsTabControl.Dock = DockStyle.Fill;
            CartsTabControl.Items = null;
            CartsTabControl.Location = new Point(3, 3);
            CartsTabControl.Name = "CartsTabControl";
            CartsTabControl.Size = new Size(1098, 829);
            CartsTabControl.TabIndex = 0;
            // 
            // CustomersTab
            // 
            CustomersTab.Controls.Add(customersTab1);
            CustomersTab.Location = new Point(4, 29);
            CustomersTab.Name = "CustomersTab";
            CustomersTab.Padding = new Padding(3);
            CustomersTab.Size = new Size(1104, 835);
            CustomersTab.TabIndex = 1;
            CustomersTab.Text = "Customers";
            CustomersTab.UseVisualStyleBackColor = true;
            // 
            // customersTab1
            // 
            customersTab1.Dock = DockStyle.Fill;
            customersTab1.Location = new Point(3, 3);
            customersTab1.Name = "customersTab1";
            customersTab1.Size = new Size(1098, 829);
            customersTab1.TabIndex = 0;
            // 
            // ItemsTabPage
            // 
            ItemsTabPage.Controls.Add(itemsTab1);
            ItemsTabPage.Location = new Point(4, 29);
            ItemsTabPage.Name = "ItemsTabPage";
            ItemsTabPage.Padding = new Padding(3);
            ItemsTabPage.Size = new Size(1104, 835);
            ItemsTabPage.TabIndex = 0;
            ItemsTabPage.Text = "Items";
            ItemsTabPage.UseVisualStyleBackColor = true;
            // 
            // itemsTab1
            // 
            itemsTab1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            itemsTab1.Dock = DockStyle.Fill;
            itemsTab1.Location = new Point(3, 3);
            itemsTab1.Name = "itemsTab1";
            itemsTab1.Size = new Size(1098, 829);
            itemsTab1.TabIndex = 0;
            // 
            // TabControl
            // 
            TabControl.Controls.Add(ItemsTabPage);
            TabControl.Controls.Add(CustomersTab);
            TabControl.Controls.Add(tabPage1);
            TabControl.Controls.Add(OrdersTabPadge);
            TabControl.Dock = DockStyle.Fill;
            TabControl.Location = new Point(0, 0);
            TabControl.Name = "TabControl";
            TabControl.SelectedIndex = 0;
            TabControl.Size = new Size(1112, 868);
            TabControl.TabIndex = 0;
            TabControl.SelectedIndexChanged += CartsTabControl_SelectedIndexChanged;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1112, 868);
            Controls.Add(TabControl);
            Name = "MainForm";
            FormClosed += MainForm_FormClosed;
            Load += MainForm_Load;
            OrdersTabPadge.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            CustomersTab.ResumeLayout(false);
            ItemsTabPage.ResumeLayout(false);
            TabControl.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabControl TabControl;
        private TabPage ItemsTabPage;
        private TabPage CustomersTab;
        private View.Tabs.CustomersTab customersTab1;
        private View.Tabs.ItemsTab itemsTab1;
        private TabPage tabPage1;
        private View.Tabs.CartsTab CartsTabControl;
        private TabPage OrdersTabPadge;
        private View.Tabs.OrdersTab OrdersTab;
        private TabPage PriorityOrder;
        private System.CodeDom.CodeTypeReference priioretyOrdersTab1;
    }
}