namespace ObjectOrientedPractics.View.Tabs
{
    partial class ItemsTab
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
            ItemsListBox = new ListBox();
            IdTextBox = new TextBox();
            CostTextBox = new TextBox();
            AddButton = new Button();
            RemoveButton = new Button();
            IdLabel = new Label();
            CostLabel = new Label();
            NameTextBox = new TextBox();
            DiscriptionTextBox = new TextBox();
            DicriptionLabel = new Label();
            NameLabel = new Label();
            ItemsLabel = new Label();
            SelectedItemsLabel = new Label();
            label1 = new Label();
            CategoryComboBox = new ComboBox();
            splitContainer1 = new SplitContainer();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // ItemsListBox
            // 
            ItemsListBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ItemsListBox.FormattingEnabled = true;
            ItemsListBox.ItemHeight = 20;
            ItemsListBox.Location = new Point(12, 31);
            ItemsListBox.Name = "ItemsListBox";
            ItemsListBox.Size = new Size(649, 584);
            ItemsListBox.TabIndex = 0;
            ItemsListBox.SelectedIndexChanged += ItemsListBox_SelectedIndexChanged;
            // 
            // IdTextBox
            // 
            IdTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            IdTextBox.Location = new Point(95, 67);
            IdTextBox.MaximumSize = new Size(400, 400);
            IdTextBox.MinimumSize = new Size(100, 30);
            IdTextBox.Name = "IdTextBox";
            IdTextBox.ReadOnly = true;
            IdTextBox.Size = new Size(149, 27);
            IdTextBox.TabIndex = 1;
            // 
            // CostTextBox
            // 
            CostTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            CostTextBox.Location = new Point(95, 100);
            CostTextBox.MaximumSize = new Size(400, 400);
            CostTextBox.MinimumSize = new Size(100, 30);
            CostTextBox.Name = "CostTextBox";
            CostTextBox.Size = new Size(149, 27);
            CostTextBox.TabIndex = 2;
            CostTextBox.TextChanged += CostTextBox_TextChanged;
            // 
            // AddButton
            // 
            AddButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            AddButton.AutoSize = true;
            AddButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            AddButton.Location = new Point(12, 631);
            AddButton.MinimumSize = new Size(131, 52);
            AddButton.Name = "AddButton";
            AddButton.Padding = new Padding(1, 0, 1, 0);
            AddButton.Size = new Size(131, 52);
            AddButton.TabIndex = 6;
            AddButton.Text = "Add";
            AddButton.UseVisualStyleBackColor = true;
            AddButton.Click += AddButton_Click;
            // 
            // RemoveButton
            // 
            RemoveButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            RemoveButton.AutoSize = true;
            RemoveButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            RemoveButton.Location = new Point(530, 631);
            RemoveButton.MinimumSize = new Size(131, 52);
            RemoveButton.Name = "RemoveButton";
            RemoveButton.Padding = new Padding(1, 0, 1, 0);
            RemoveButton.Size = new Size(131, 52);
            RemoveButton.TabIndex = 7;
            RemoveButton.Text = "Remove";
            RemoveButton.UseVisualStyleBackColor = true;
            RemoveButton.Click += RemoveButton_Click;
            // 
            // IdLabel
            // 
            IdLabel.AutoSize = true;
            IdLabel.Location = new Point(17, 70);
            IdLabel.Name = "IdLabel";
            IdLabel.Size = new Size(27, 20);
            IdLabel.TabIndex = 10;
            IdLabel.Text = "ID:";
            // 
            // CostLabel
            // 
            CostLabel.AutoSize = true;
            CostLabel.Location = new Point(17, 103);
            CostLabel.Name = "CostLabel";
            CostLabel.Size = new Size(41, 20);
            CostLabel.TabIndex = 11;
            CostLabel.Text = "Cost:";
            // 
            // NameTextBox
            // 
            NameTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            NameTextBox.Location = new Point(3, 217);
            NameTextBox.Multiline = true;
            NameTextBox.Name = "NameTextBox";
            NameTextBox.Size = new Size(323, 165);
            NameTextBox.TabIndex = 3;
            NameTextBox.TextChanged += NameTextBox_TextChanged;
            // 
            // DiscriptionTextBox
            // 
            DiscriptionTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            DiscriptionTextBox.Location = new Point(3, 421);
            DiscriptionTextBox.Multiline = true;
            DiscriptionTextBox.Name = "DiscriptionTextBox";
            DiscriptionTextBox.Size = new Size(323, 262);
            DiscriptionTextBox.TabIndex = 4;
            DiscriptionTextBox.TextChanged += DiscriptionTextBox_TextChanged;
            // 
            // DicriptionLabel
            // 
            DicriptionLabel.AutoSize = true;
            DicriptionLabel.Location = new Point(3, 398);
            DicriptionLabel.Name = "DicriptionLabel";
            DicriptionLabel.Size = new Size(81, 20);
            DicriptionLabel.TabIndex = 8;
            DicriptionLabel.Text = "Discription";
            // 
            // NameLabel
            // 
            NameLabel.AutoSize = true;
            NameLabel.Location = new Point(3, 194);
            NameLabel.Name = "NameLabel";
            NameLabel.Size = new Size(49, 20);
            NameLabel.TabIndex = 9;
            NameLabel.Text = "Name";
            // 
            // ItemsLabel
            // 
            ItemsLabel.AutoSize = true;
            ItemsLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            ItemsLabel.Location = new Point(12, 0);
            ItemsLabel.Name = "ItemsLabel";
            ItemsLabel.Size = new Size(64, 28);
            ItemsLabel.TabIndex = 12;
            ItemsLabel.Text = "Items";
            // 
            // SelectedItemsLabel
            // 
            SelectedItemsLabel.AutoSize = true;
            SelectedItemsLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            SelectedItemsLabel.ForeColor = SystemColors.ActiveCaptionText;
            SelectedItemsLabel.Location = new Point(17, 19);
            SelectedItemsLabel.Name = "SelectedItemsLabel";
            SelectedItemsLabel.Size = new Size(150, 28);
            SelectedItemsLabel.TabIndex = 13;
            SelectedItemsLabel.Text = "Selected Items";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(17, 137);
            label1.Name = "label1";
            label1.Size = new Size(72, 20);
            label1.TabIndex = 15;
            label1.Text = "Category:";
            // 
            // CategoryComboBox
            // 
            CategoryComboBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            CategoryComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            CategoryComboBox.FormattingEnabled = true;
            CategoryComboBox.Location = new Point(95, 134);
            CategoryComboBox.MaximumSize = new Size(400, 0);
            CategoryComboBox.MinimumSize = new Size(100, 0);
            CategoryComboBox.Name = "CategoryComboBox";
            CategoryComboBox.Size = new Size(149, 28);
            CategoryComboBox.TabIndex = 16;
            CategoryComboBox.SelectedIndexChanged += CategoryComboBox_SelectedIndexChanged;
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(ItemsListBox);
            splitContainer1.Panel1.Controls.Add(RemoveButton);
            splitContainer1.Panel1.Controls.Add(ItemsLabel);
            splitContainer1.Panel1.Controls.Add(AddButton);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(panel1);
            splitContainer1.Panel2.Controls.Add(NameTextBox);
            splitContainer1.Panel2.Controls.Add(DiscriptionTextBox);
            splitContainer1.Panel2.Controls.Add(DicriptionLabel);
            splitContainer1.Panel2.Controls.Add(NameLabel);
            splitContainer1.Size = new Size(1051, 711);
            splitContainer1.SplitterDistance = 668;
            splitContainer1.TabIndex = 17;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.Controls.Add(SelectedItemsLabel);
            panel1.Controls.Add(IdLabel);
            panel1.Controls.Add(CategoryComboBox);
            panel1.Controls.Add(CostLabel);
            panel1.Controls.Add(IdTextBox);
            panel1.Controls.Add(CostTextBox);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(373, 178);
            panel1.TabIndex = 17;
            // 
            // ItemsTab
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            Controls.Add(splitContainer1);
            Name = "ItemsTab";
            Size = new Size(1051, 711);
            Click += ItemsTab_Click;
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ListBox ItemsListBox;
        private TextBox IdTextBox;
        private TextBox CostTextBox;
        private Button AddButton;
        private Button RemoveButton;
        private Label IdLabel;
        private Label CostLabel;
        private TextBox NameTextBox;
        private TextBox DiscriptionTextBox;
        private Label DicriptionLabel;
        private Label NameLabel;
        private Label ItemsLabel;
        private Label SelectedItemsLabel;
        private Label label1;
        private ComboBox CategoryComboBox;
        private SplitContainer splitContainer1;
        private Panel panel1;
    }
}
