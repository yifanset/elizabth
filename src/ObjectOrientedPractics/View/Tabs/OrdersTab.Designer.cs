namespace ObjectOrientedPractics.View.Tabs
{
    partial class OrdersTab
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            OrdersDataGridView = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            AddressControl = new Controls.AddressControl();
            label3 = new Label();
            IdTextBox = new TextBox();
            CreatedDataTextBox = new TextBox();
            StatusComboBox = new ComboBox();
            idLabel = new Label();
            label5 = new Label();
            label6 = new Label();
            label4 = new Label();
            OrderItemsListBox = new ListBox();
            splitContainer1 = new SplitContainer();
            PrioretyPanel = new Panel();
            DeliveryComboBox = new ComboBox();
            label8 = new Label();
            label7 = new Label();
            panel1 = new Panel();
            OrderId = new DataGridViewTextBoxColumn();
            CreationDate = new DataGridViewTextBoxColumn();
            OrderStatus = new DataGridViewTextBoxColumn();
            CustomerName = new DataGridViewTextBoxColumn();
            DeliveryAddress = new DataGridViewTextBoxColumn();
            Price = new DataGridViewTextBoxColumn();
            TotalPrice = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)OrdersDataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            PrioretyPanel.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // OrdersDataGridView
            // 
            OrdersDataGridView.AllowUserToAddRows = false;
            OrdersDataGridView.AllowUserToDeleteRows = false;
            OrdersDataGridView.AllowUserToResizeRows = false;
            OrdersDataGridView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            OrdersDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            OrdersDataGridView.ColumnHeadersHeight = 29;
            OrdersDataGridView.Columns.AddRange(new DataGridViewColumn[] { OrderId, CreationDate, OrderStatus, CustomerName, DeliveryAddress, Price, TotalPrice });
            OrdersDataGridView.Location = new Point(5, 36);
            OrdersDataGridView.MultiSelect = false;
            OrdersDataGridView.Name = "OrdersDataGridView";
            OrdersDataGridView.ReadOnly = true;
            OrdersDataGridView.RowHeadersVisible = false;
            OrdersDataGridView.RowHeadersWidth = 51;
            OrdersDataGridView.RowTemplate.Height = 29;
            OrdersDataGridView.Size = new Size(558, 541);
            OrdersDataGridView.TabIndex = 1;
            OrdersDataGridView.SelectionChanged += OrdersDataGridView_SelectionChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(5, 2);
            label1.Name = "label1";
            label1.Size = new Size(53, 20);
            label1.TabIndex = 0;
            label1.Text = "Orders";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(3, 0);
            label2.Name = "label2";
            label2.Size = new Size(111, 20);
            label2.TabIndex = 1;
            label2.Text = "Selected Oeder";
            // 
            // AddressControl
            // 
            AddressControl.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            AddressControl.ImeMode = ImeMode.NoControl;
            AddressControl.Location = new Point(3, 159);
            AddressControl.Name = "AddressControl";
            AddressControl.Size = new Size(424, 228);
            AddressControl.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(3, 136);
            label3.Name = "label3";
            label3.Size = new Size(120, 20);
            label3.TabIndex = 3;
            label3.Text = "Delivery Address";
            // 
            // IdTextBox
            // 
            IdTextBox.Location = new Point(87, 23);
            IdTextBox.Name = "IdTextBox";
            IdTextBox.ReadOnly = true;
            IdTextBox.Size = new Size(151, 27);
            IdTextBox.TabIndex = 4;
            // 
            // CreatedDataTextBox
            // 
            CreatedDataTextBox.Location = new Point(87, 59);
            CreatedDataTextBox.Name = "CreatedDataTextBox";
            CreatedDataTextBox.ReadOnly = true;
            CreatedDataTextBox.Size = new Size(151, 27);
            CreatedDataTextBox.TabIndex = 5;
            // 
            // StatusComboBox
            // 
            StatusComboBox.FormattingEnabled = true;
            StatusComboBox.Location = new Point(87, 95);
            StatusComboBox.Name = "StatusComboBox";
            StatusComboBox.Size = new Size(151, 28);
            StatusComboBox.TabIndex = 6;
            StatusComboBox.SelectedIndexChanged += StatusComboBox_SelectedIndexChanged;
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new Point(3, 26);
            idLabel.Name = "idLabel";
            idLabel.Size = new Size(27, 20);
            idLabel.TabIndex = 7;
            idLabel.Text = "ID:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(3, 62);
            label5.Name = "label5";
            label5.Size = new Size(64, 20);
            label5.TabIndex = 8;
            label5.Text = "Created:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(3, 98);
            label6.Name = "label6";
            label6.Size = new Size(49, 20);
            label6.TabIndex = 9;
            label6.Text = "Status";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(3, 390);
            label4.Name = "label4";
            label4.Size = new Size(87, 20);
            label4.TabIndex = 10;
            label4.Text = "Order Items";
            // 
            // OrderItemsListBox
            // 
            OrderItemsListBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            OrderItemsListBox.FormattingEnabled = true;
            OrderItemsListBox.ItemHeight = 20;
            OrderItemsListBox.Location = new Point(3, 413);
            OrderItemsListBox.Name = "OrderItemsListBox";
            OrderItemsListBox.Size = new Size(424, 164);
            OrderItemsListBox.TabIndex = 11;
            // 
            // splitContainer1
            // 
            splitContainer1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(OrdersDataGridView);
            splitContainer1.Panel1.Controls.Add(label1);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(PrioretyPanel);
            splitContainer1.Panel2.Controls.Add(panel1);
            splitContainer1.Panel2.Controls.Add(AddressControl);
            splitContainer1.Panel2.Controls.Add(OrderItemsListBox);
            splitContainer1.Panel2.Controls.Add(label4);
            splitContainer1.Panel2.Controls.Add(label3);
            splitContainer1.Size = new Size(1025, 586);
            splitContainer1.SplitterDistance = 563;
            splitContainer1.TabIndex = 12;
            // 
            // PrioretyPanel
            // 
            PrioretyPanel.Controls.Add(DeliveryComboBox);
            PrioretyPanel.Controls.Add(label8);
            PrioretyPanel.Controls.Add(label7);
            PrioretyPanel.Location = new Point(250, 3);
            PrioretyPanel.Name = "PrioretyPanel";
            PrioretyPanel.Size = new Size(205, 130);
            PrioretyPanel.TabIndex = 13;
            // 
            // DeliveryComboBox
            // 
            DeliveryComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            DeliveryComboBox.FormattingEnabled = true;
            DeliveryComboBox.Items.AddRange(new object[] { "9:00 – 11:00", "11:00 – 13:00", "13:00 – 15:00", "15:00 – 17:00", "17:00 – 19:00", "19:00 – 21:00" });
            DeliveryComboBox.Location = new Point(104, 27);
            DeliveryComboBox.Name = "DeliveryComboBox";
            DeliveryComboBox.Size = new Size(98, 28);
            DeliveryComboBox.TabIndex = 10;
            DeliveryComboBox.SelectedIndexChanged += DeliveryComboBox_SelectedIndexChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(3, 31);
            label8.Name = "label8";
            label8.Size = new Size(103, 20);
            label8.TabIndex = 10;
            label8.Text = "Delivery Time:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(3, 1);
            label7.Name = "label7";
            label7.Size = new Size(102, 20);
            label7.TabIndex = 10;
            label7.Text = "Priorety Order";
            // 
            // panel1
            // 
            panel1.Controls.Add(IdTextBox);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(idLabel);
            panel1.Controls.Add(CreatedDataTextBox);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(StatusComboBox);
            panel1.Controls.Add(label6);
            panel1.Location = new Point(3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(241, 129);
            panel1.TabIndex = 12;
            // 
            // OrderId
            // 
            OrderId.HeaderText = "ID";
            OrderId.MinimumWidth = 6;
            OrderId.Name = "OrderId";
            OrderId.ReadOnly = true;
            OrderId.Resizable = DataGridViewTriState.True;
            // 
            // CreationDate
            // 
            CreationDate.HeaderText = "Created";
            CreationDate.MinimumWidth = 6;
            CreationDate.Name = "CreationDate";
            CreationDate.ReadOnly = true;
            // 
            // OrderStatus
            // 
            OrderStatus.HeaderText = "Order Status";
            OrderStatus.MinimumWidth = 6;
            OrderStatus.Name = "OrderStatus";
            OrderStatus.ReadOnly = true;
            // 
            // CustomerName
            // 
            CustomerName.HeaderText = "Customer Full Name";
            CustomerName.MinimumWidth = 6;
            CustomerName.Name = "CustomerName";
            CustomerName.ReadOnly = true;
            // 
            // DeliveryAddress
            // 
            DeliveryAddress.HeaderText = "Delivery Address";
            DeliveryAddress.MinimumWidth = 6;
            DeliveryAddress.Name = "DeliveryAddress";
            DeliveryAddress.ReadOnly = true;
            // 
            // Price
            // 
            Price.HeaderText = "Price";
            Price.MinimumWidth = 6;
            Price.Name = "Price";
            Price.ReadOnly = true;
            // 
            // TotalPrice
            // 
            TotalPrice.HeaderText = "Total Price";
            TotalPrice.MinimumWidth = 6;
            TotalPrice.Name = "TotalPrice";
            TotalPrice.ReadOnly = true;
            // 
            // OrdersTab
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(splitContainer1);
            Name = "OrdersTab";
            Size = new Size(1025, 586);
            ((System.ComponentModel.ISupportInitialize)OrdersDataGridView).EndInit();
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            PrioretyPanel.ResumeLayout(false);
            PrioretyPanel.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Label label1;
        private DataGridView OrdersDataGridView;
        private Label label2;
        private Controls.AddressControl AddressControl;
        private Label label3;
        private TextBox IdTextBox;
        private TextBox CreatedDataTextBox;
        private ComboBox StatusComboBox;
        private Label idLabel;
        private Label label5;
        private Label label6;
        private Label label4;
        private ListBox OrderItemsListBox;
        private SplitContainer splitContainer1;
        private Panel panel1;
        private Panel PrioretyPanel;
        private ComboBox DeliveryComboBox;
        private Label label8;
        private Label label7;
        private DataGridViewTextBoxColumn OrderId;
        private DataGridViewTextBoxColumn CreationDate;
        private DataGridViewTextBoxColumn OrderStatus;
        private DataGridViewTextBoxColumn CustomerName;
        private DataGridViewTextBoxColumn DeliveryAddress;
        private DataGridViewTextBoxColumn Price;
        private DataGridViewTextBoxColumn TotalPrice;
    }
}
