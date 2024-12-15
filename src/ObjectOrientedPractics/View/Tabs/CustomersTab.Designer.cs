namespace ObjectOrientedPractics.View.Tabs
{
    partial class CustomersTab
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
            SelectedItemsLabel = new Label();
            ItemsLabel = new Label();
            CostLabel = new Label();
            IdLabel = new Label();
            RemoveButton = new Button();
            AddButton = new Button();
            NameTextBox = new TextBox();
            IdTextBox = new TextBox();
            CustomersListBox = new ListBox();
            splitContainer1 = new SplitContainer();
            panel1 = new Panel();
            DiscountsListBox = new ListBox();
            RemoveDiscountButton = new Button();
            AddDiscountsButton = new Button();
            AddressControl = new Controls.AddressControl();
            panel2 = new Panel();
            PropertyCheckBox = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // SelectedItemsLabel
            // 
            SelectedItemsLabel.AutoSize = true;
            SelectedItemsLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            SelectedItemsLabel.ForeColor = SystemColors.ActiveCaptionText;
            SelectedItemsLabel.Location = new Point(1, 8);
            SelectedItemsLabel.Name = "SelectedItemsLabel";
            SelectedItemsLabel.Size = new Size(197, 28);
            SelectedItemsLabel.TabIndex = 26;
            SelectedItemsLabel.Text = "Selected Customers";
            // 
            // ItemsLabel
            // 
            ItemsLabel.AutoSize = true;
            ItemsLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            ItemsLabel.Location = new Point(13, 14);
            ItemsLabel.Name = "ItemsLabel";
            ItemsLabel.Size = new Size(111, 28);
            ItemsLabel.TabIndex = 25;
            ItemsLabel.Text = "Customers";
            // 
            // CostLabel
            // 
            CostLabel.AutoSize = true;
            CostLabel.Location = new Point(1, 92);
            CostLabel.Name = "CostLabel";
            CostLabel.Size = new Size(79, 20);
            CostLabel.TabIndex = 24;
            CostLabel.Text = "Full Name:";
            // 
            // IdLabel
            // 
            IdLabel.AutoSize = true;
            IdLabel.Location = new Point(1, 59);
            IdLabel.Name = "IdLabel";
            IdLabel.Size = new Size(27, 20);
            IdLabel.TabIndex = 23;
            IdLabel.Text = "ID:";
            // 
            // RemoveButton
            // 
            RemoveButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            RemoveButton.AutoSize = true;
            RemoveButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            RemoveButton.Location = new Point(400, 650);
            RemoveButton.MinimumSize = new Size(131, 52);
            RemoveButton.Name = "RemoveButton";
            RemoveButton.Padding = new Padding(1, 0, 1, 0);
            RemoveButton.Size = new Size(131, 52);
            RemoveButton.TabIndex = 20;
            RemoveButton.Text = "Remove";
            RemoveButton.UseVisualStyleBackColor = true;
            RemoveButton.Click += RemoveButton_Click;
            // 
            // AddButton
            // 
            AddButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            AddButton.AutoSize = true;
            AddButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            AddButton.Location = new Point(13, 650);
            AddButton.MinimumSize = new Size(131, 52);
            AddButton.Name = "AddButton";
            AddButton.Padding = new Padding(1, 0, 1, 0);
            AddButton.Size = new Size(131, 52);
            AddButton.TabIndex = 19;
            AddButton.Text = "Add";
            AddButton.UseVisualStyleBackColor = true;
            AddButton.Click += AddButton_Click;
            // 
            // NameTextBox
            // 
            NameTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            NameTextBox.Location = new Point(86, 89);
            NameTextBox.MaximumSize = new Size(400, 400);
            NameTextBox.MinimumSize = new Size(100, 30);
            NameTextBox.Name = "NameTextBox";
            NameTextBox.Size = new Size(337, 30);
            NameTextBox.TabIndex = 16;
            NameTextBox.TextChanged += NameTextBox_TextChanged;
            // 
            // IdTextBox
            // 
            IdTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            IdTextBox.Location = new Point(87, 56);
            IdTextBox.MaximumSize = new Size(400, 400);
            IdTextBox.MinimumSize = new Size(100, 30);
            IdTextBox.Name = "IdTextBox";
            IdTextBox.ReadOnly = true;
            IdTextBox.Size = new Size(337, 30);
            IdTextBox.TabIndex = 15;
            // 
            // CustomersListBox
            // 
            CustomersListBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            CustomersListBox.FormattingEnabled = true;
            CustomersListBox.ItemHeight = 20;
            CustomersListBox.Location = new Point(13, 45);
            CustomersListBox.Name = "CustomersListBox";
            CustomersListBox.Size = new Size(518, 584);
            CustomersListBox.TabIndex = 14;
            CustomersListBox.SelectedIndexChanged += CustomersListBox_SelectedIndexChanged;
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(CustomersListBox);
            splitContainer1.Panel1.Controls.Add(RemoveButton);
            splitContainer1.Panel1.Controls.Add(ItemsLabel);
            splitContainer1.Panel1.Controls.Add(AddButton);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(panel1);
            splitContainer1.Panel2.Controls.Add(AddressControl);
            splitContainer1.Panel2.Controls.Add(panel2);
            splitContainer1.Panel2.Paint += splitContainer1_Panel2_Paint;
            splitContainer1.Size = new Size(1023, 720);
            splitContainer1.SplitterDistance = 554;
            splitContainer1.TabIndex = 28;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.Controls.Add(DiscountsListBox);
            panel1.Controls.Add(RemoveDiscountButton);
            panel1.Controls.Add(AddDiscountsButton);
            panel1.Location = new Point(4, 432);
            panel1.Name = "panel1";
            panel1.Size = new Size(445, 197);
            panel1.TabIndex = 31;
            // 
            // DiscountsListBox
            // 
            DiscountsListBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            DiscountsListBox.FormattingEnabled = true;
            DiscountsListBox.ItemHeight = 20;
            DiscountsListBox.Location = new Point(3, 3);
            DiscountsListBox.Name = "DiscountsListBox";
            DiscountsListBox.Size = new Size(305, 184);
            DiscountsListBox.TabIndex = 29;
            // 
            // RemoveDiscountButton
            // 
            RemoveDiscountButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            RemoveDiscountButton.AutoSize = true;
            RemoveDiscountButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            RemoveDiscountButton.Location = new Point(311, 62);
            RemoveDiscountButton.MinimumSize = new Size(131, 52);
            RemoveDiscountButton.Name = "RemoveDiscountButton";
            RemoveDiscountButton.Padding = new Padding(1, 0, 1, 0);
            RemoveDiscountButton.Size = new Size(131, 52);
            RemoveDiscountButton.TabIndex = 30;
            RemoveDiscountButton.Text = "Remove";
            RemoveDiscountButton.UseVisualStyleBackColor = true;
            RemoveDiscountButton.Click += RemoveDiscountButton_Click;
            // 
            // AddDiscountsButton
            // 
            AddDiscountsButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            AddDiscountsButton.AutoSize = true;
            AddDiscountsButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            AddDiscountsButton.Location = new Point(311, 4);
            AddDiscountsButton.MinimumSize = new Size(131, 52);
            AddDiscountsButton.Name = "AddDiscountsButton";
            AddDiscountsButton.Padding = new Padding(1, 0, 1, 0);
            AddDiscountsButton.Size = new Size(131, 52);
            AddDiscountsButton.TabIndex = 26;
            AddDiscountsButton.Text = "Add";
            AddDiscountsButton.UseVisualStyleBackColor = true;
            AddDiscountsButton.Click += AddDiscountsButton_Click;
            // 
            // AddressControl
            // 
            AddressControl.AllowDrop = true;
            AddressControl.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            AddressControl.ForeColor = SystemColors.ActiveCaptionText;
            AddressControl.Location = new Point(3, 189);
            AddressControl.Name = "AddressControl";
            AddressControl.Size = new Size(446, 241);
            AddressControl.TabIndex = 0;
            AddressControl.Load += AddressControl_Load;
            AddressControl.Click += AddressControl_Click;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel2.Controls.Add(PropertyCheckBox);
            panel2.Controls.Add(NameTextBox);
            panel2.Controls.Add(IdLabel);
            panel2.Controls.Add(SelectedItemsLabel);
            panel2.Controls.Add(CostLabel);
            panel2.Controls.Add(IdTextBox);
            panel2.Location = new Point(3, 14);
            panel2.Name = "panel2";
            panel2.Size = new Size(446, 156);
            panel2.TabIndex = 28;
            // 
            // PropertyCheckBox
            // 
            PropertyCheckBox.AutoSize = true;
            PropertyCheckBox.Location = new Point(86, 122);
            PropertyCheckBox.Name = "PropertyCheckBox";
            PropertyCheckBox.Size = new Size(101, 24);
            PropertyCheckBox.TabIndex = 27;
            PropertyCheckBox.Text = "Is Property";
            PropertyCheckBox.UseVisualStyleBackColor = true;
            PropertyCheckBox.CheckedChanged += PropertyCheckBox_CheckedChanged;
            // 
            // CustomersTab
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(splitContainer1);
            Name = "CustomersTab";
            Size = new Size(1023, 720);
            Click += CustomersTab_Click;
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label SelectedItemsLabel;
        private Label ItemsLabel;
        private Label CostLabel;
        private Label IdLabel;
        private Label DicriptionLabel;
        private Button RemoveButton;
        private Button AddButton;
        private TextBox DiscriptionTextBox;
        private TextBox NameTextBox;
        private TextBox NameNextBox;
        private TextBox IdTextBox;
        private ListBox CustomersListBox;
        private SplitContainer splitContainer1;
        private Panel panel2;
        private Controls.AddressControl AddressControl;
        private CheckBox PropertyCheckBox;
        private ListBox DiscountsListBox;
        private Button RemoveDiscountButton;
        private Button AddDiscountsButton;
        private Panel panel1;
    }
}