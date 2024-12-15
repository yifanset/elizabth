namespace ObjectOrientedPractics.View.Tabs
{
    partial class CartsTab
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
            AddButton = new Button();
            ItemsLabel = new Label();
            ItemsListBox = new ListBox();
            amountLabel = new Label();
            label2 = new Label();
            RemoveButton = new Button();
            ClearButton = new Button();
            CartsListBox = new ListBox();
            Cart = new Label();
            CustomersComboBox = new ComboBox();
            CustomersLAbel = new Label();
            CreateButton = new Button();
            splitContainer1 = new SplitContainer();
            panel1 = new Panel();
            panel3 = new Panel();
            TotalLabel = new Label();
            label5 = new Label();
            DiscountAmountLabel = new Label();
            label3 = new Label();
            DiscountCheckedListBox = new CheckedListBox();
            label1 = new Label();
            panel2 = new Panel();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // AddButton
            // 
            AddButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            AddButton.Location = new Point(3, 626);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(131, 52);
            AddButton.TabIndex = 0;
            AddButton.Text = "Add To Cart";
            AddButton.UseVisualStyleBackColor = true;
            AddButton.Click += AddButton_Click;
            // 
            // ItemsLabel
            // 
            ItemsLabel.AutoSize = true;
            ItemsLabel.Location = new Point(3, 8);
            ItemsLabel.Name = "ItemsLabel";
            ItemsLabel.Size = new Size(45, 20);
            ItemsLabel.TabIndex = 1;
            ItemsLabel.Text = "Items";
            // 
            // ItemsListBox
            // 
            ItemsListBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ItemsListBox.FormattingEnabled = true;
            ItemsListBox.ItemHeight = 20;
            ItemsListBox.Location = new Point(3, 31);
            ItemsListBox.Name = "ItemsListBox";
            ItemsListBox.Size = new Size(525, 584);
            ItemsListBox.TabIndex = 0;
            // 
            // amountLabel
            // 
            amountLabel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            amountLabel.AutoSize = true;
            amountLabel.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            amountLabel.Location = new Point(646, 21);
            amountLabel.Name = "amountLabel";
            amountLabel.Size = new Size(72, 37);
            amountLabel.TabIndex = 9;
            amountLabel.Text = "0,00";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(648, 2);
            label2.Name = "label2";
            label2.Size = new Size(67, 20);
            label2.TabIndex = 8;
            label2.Text = "Amount";
            // 
            // RemoveButton
            // 
            RemoveButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            RemoveButton.Location = new Point(451, 74);
            RemoveButton.Margin = new Padding(5);
            RemoveButton.Name = "RemoveButton";
            RemoveButton.Size = new Size(131, 52);
            RemoveButton.TabIndex = 7;
            RemoveButton.Text = "Remove Items";
            RemoveButton.UseVisualStyleBackColor = true;
            RemoveButton.Click += RemoveItemButton_Click;
            // 
            // ClearButton
            // 
            ClearButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            ClearButton.Location = new Point(587, 74);
            ClearButton.Name = "ClearButton";
            ClearButton.Size = new Size(131, 52);
            ClearButton.TabIndex = 6;
            ClearButton.Text = "Clear Cart";
            ClearButton.UseVisualStyleBackColor = true;
            ClearButton.Click += ClearButton_Click;
            // 
            // CartsListBox
            // 
            CartsListBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            CartsListBox.FormattingEnabled = true;
            CartsListBox.ItemHeight = 20;
            CartsListBox.Location = new Point(12, 64);
            CartsListBox.Name = "CartsListBox";
            CartsListBox.Size = new Size(706, 204);
            CartsListBox.TabIndex = 5;
            // 
            // Cart
            // 
            Cart.AutoSize = true;
            Cart.Location = new Point(12, 41);
            Cart.Name = "Cart";
            Cart.Size = new Size(36, 20);
            Cart.TabIndex = 4;
            Cart.Text = "Cart";
            // 
            // CustomersComboBox
            // 
            CustomersComboBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            CustomersComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            CustomersComboBox.FormattingEnabled = true;
            CustomersComboBox.Location = new Point(96, 12);
            CustomersComboBox.Name = "CustomersComboBox";
            CustomersComboBox.Size = new Size(620, 28);
            CustomersComboBox.TabIndex = 3;
            CustomersComboBox.SelectedIndexChanged += CustomersComboBox_SelectedIndexChanged;
            // 
            // CustomersLAbel
            // 
            CustomersLAbel.AutoSize = true;
            CustomersLAbel.Location = new Point(12, 15);
            CustomersLAbel.Name = "CustomersLAbel";
            CustomersLAbel.Size = new Size(78, 20);
            CustomersLAbel.TabIndex = 2;
            CustomersLAbel.Text = "Customers";
            // 
            // CreateButton
            // 
            CreateButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            CreateButton.Location = new Point(5, 74);
            CreateButton.Margin = new Padding(5);
            CreateButton.Name = "CreateButton";
            CreateButton.Size = new Size(131, 52);
            CreateButton.TabIndex = 2;
            CreateButton.Text = "Create Order";
            CreateButton.UseVisualStyleBackColor = true;
            CreateButton.Click += CreateOrderButton_Click;
            // 
            // splitContainer1
            // 
            splitContainer1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            splitContainer1.Location = new Point(3, 3);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(AddButton);
            splitContainer1.Panel1.Controls.Add(ItemsListBox);
            splitContainer1.Panel1.Controls.Add(ItemsLabel);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(panel1);
            splitContainer1.Panel2.Controls.Add(panel3);
            splitContainer1.Panel2.Controls.Add(panel2);
            splitContainer1.Size = new Size(1289, 680);
            splitContainer1.SplitterDistance = 546;
            splitContainer1.TabIndex = 2;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.Controls.Add(CartsListBox);
            panel1.Controls.Add(CustomersLAbel);
            panel1.Controls.Add(Cart);
            panel1.Controls.Add(CustomersComboBox);
            panel1.Location = new Point(5, 8);
            panel1.Name = "panel1";
            panel1.Size = new Size(722, 270);
            panel1.TabIndex = 10;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel3.Controls.Add(TotalLabel);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(DiscountAmountLabel);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(DiscountCheckedListBox);
            panel3.Controls.Add(label1);
            panel3.Location = new Point(5, 423);
            panel3.Name = "panel3";
            panel3.Size = new Size(722, 254);
            panel3.TabIndex = 13;
            // 
            // TotalLabel
            // 
            TotalLabel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            TotalLabel.AutoSize = true;
            TotalLabel.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            TotalLabel.Location = new Point(643, 217);
            TotalLabel.Name = "TotalLabel";
            TotalLabel.Size = new Size(72, 37);
            TotalLabel.TabIndex = 17;
            TotalLabel.Text = "0,00";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(671, 197);
            label5.Name = "label5";
            label5.Size = new Size(44, 20);
            label5.TabIndex = 16;
            label5.Text = "Total";
            // 
            // DiscountAmountLabel
            // 
            DiscountAmountLabel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            DiscountAmountLabel.AutoSize = true;
            DiscountAmountLabel.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            DiscountAmountLabel.Location = new Point(644, 20);
            DiscountAmountLabel.Name = "DiscountAmountLabel";
            DiscountAmountLabel.Size = new Size(72, 37);
            DiscountAmountLabel.TabIndex = 15;
            DiscountAmountLabel.Text = "0,00";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(586, 3);
            label3.Name = "label3";
            label3.Size = new Size(130, 20);
            label3.TabIndex = 14;
            label3.Text = "Discount amount";
            // 
            // DiscountCheckedListBox
            // 
            DiscountCheckedListBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            DiscountCheckedListBox.BackColor = SystemColors.Window;
            DiscountCheckedListBox.BorderStyle = BorderStyle.None;
            DiscountCheckedListBox.FormattingEnabled = true;
            DiscountCheckedListBox.Location = new Point(5, 24);
            DiscountCheckedListBox.Name = "DiscountCheckedListBox";
            DiscountCheckedListBox.Size = new Size(350, 220);
            DiscountCheckedListBox.TabIndex = 13;
            DiscountCheckedListBox.SelectedIndexChanged += DiscountCheckedListBox_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(67, 20);
            label1.TabIndex = 12;
            label1.Text = "Amount";
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel2.Controls.Add(amountLabel);
            panel2.Controls.Add(CreateButton);
            panel2.Controls.Add(RemoveButton);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(ClearButton);
            panel2.Location = new Point(5, 287);
            panel2.Name = "panel2";
            panel2.Size = new Size(721, 131);
            panel2.TabIndex = 11;
            // 
            // CartsTab
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(splitContainer1);
            Name = "CartsTab";
            Size = new Size(1307, 686);
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Button AddButton;
        private Label ItemsLabel;
        private ListBox ItemsListBox;
        private Button CreateButton;
        private Label CustomersLAbel;
        private Button RemoveButton;
        private Button ClearButton;
        private ListBox CartsListBox;
        private Label Cart;
        private ComboBox CustomersComboBox;
        private Label amountLabel;
        private Label label2;
        private SplitContainer splitContainer1;
        private Panel panel2;
        private Panel panel3;
        private Label label1;
        private CheckedListBox DiscountCheckedListBox;
        private Label label3;
        private Label DiscountAmountLabel;
        private Label TotalLabel;
        private Label label5;
        private Panel panel1;
    }
}
