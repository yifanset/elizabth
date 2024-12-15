namespace Final
{
    partial class Final
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
            establishmentListBox = new ListBox();
            appendButton = new Button();
            changeButton = new Button();
            deleteButton = new Button();
            nameTextBox = new TextBox();
            addressTextBox = new TextBox();
            categoryComboBox = new ComboBox();
            ratingTextBox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            groupBox1 = new GroupBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // establishmentListBox
            // 
            establishmentListBox.FormattingEnabled = true;
            establishmentListBox.HorizontalScrollbar = true;
            establishmentListBox.ItemHeight = 20;
            establishmentListBox.Location = new Point(12, 32);
            establishmentListBox.Name = "establishmentListBox";
            establishmentListBox.Size = new Size(299, 444);
            establishmentListBox.TabIndex = 0;
            establishmentListBox.SelectedIndexChanged += establishmentListBox_SelectedIndexChanged;
            // 
            // appendButton
            // 
            appendButton.Location = new Point(12, 501);
            appendButton.Name = "appendButton";
            appendButton.Size = new Size(56, 29);
            appendButton.TabIndex = 1;
            appendButton.Text = "Add";
            appendButton.UseVisualStyleBackColor = true;
            appendButton.Click += appendButton_Click;
            // 
            // changeButton
            // 
            changeButton.Location = new Point(119, 501);
            changeButton.Name = "changeButton";
            changeButton.Size = new Size(74, 29);
            changeButton.TabIndex = 2;
            changeButton.Text = "Change";
            changeButton.UseVisualStyleBackColor = true;
            changeButton.Click += changeButton_Click;
            // 
            // deleteButton
            // 
            deleteButton.Location = new Point(249, 501);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(62, 29);
            deleteButton.TabIndex = 3;
            deleteButton.Text = "Delete";
            deleteButton.UseVisualStyleBackColor = true;
            deleteButton.Click += deleteButton_Click;
            // 
            // nameTextBox
            // 
            nameTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            nameTextBox.Location = new Point(176, 26);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(406, 27);
            nameTextBox.TabIndex = 4;
            nameTextBox.TextChanged += nameTextBox_TextChanged;
            // 
            // addressTextBox
            // 
            addressTextBox.Location = new Point(176, 63);
            addressTextBox.Name = "addressTextBox";
            addressTextBox.Size = new Size(406, 27);
            addressTextBox.TabIndex = 5;
            addressTextBox.TextChanged += addressTextBox_TextChanged;
            // 
            // categoryComboBox
            // 
            categoryComboBox.DropDownHeight = 150;
            categoryComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            categoryComboBox.FormattingEnabled = true;
            categoryComboBox.IntegralHeight = false;
            categoryComboBox.Items.AddRange(new object[] { "Bakery", "Bar", "Buffet", "Cafe", "Canteen", "Cinema", "Club", "Educational", "Gallery", "Gym", "Hairdresser", "Hospital", "Hotel", "Kindergarten", "Library", "Metro", "Museum", "Municipal", "Park", "Pharmacy", "Polyclinic", "Restaurant", "Sauna", "Supermarket", "Theatre" });
            categoryComboBox.Location = new Point(176, 96);
            categoryComboBox.Name = "categoryComboBox";
            categoryComboBox.Size = new Size(125, 28);
            categoryComboBox.TabIndex = 6;
            // 
            // ratingTextBox
            // 
            ratingTextBox.Location = new Point(176, 130);
            ratingTextBox.Name = "ratingTextBox";
            ratingTextBox.Size = new Size(125, 27);
            ratingTextBox.TabIndex = 7;
            ratingTextBox.TextChanged += ratingTextBox_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(7, 34);
            label1.Name = "label1";
            label1.Size = new Size(163, 20);
            label1.TabIndex = 8;
            label1.Text = "Name of establishment";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(108, 66);
            label2.Name = "label2";
            label2.Size = new Size(62, 20);
            label2.TabIndex = 9;
            label2.Text = "Address";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(101, 99);
            label3.Name = "label3";
            label3.Size = new Size(69, 20);
            label3.TabIndex = 10;
            label3.Text = "Category";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(118, 133);
            label4.Name = "label4";
            label4.Size = new Size(52, 20);
            label4.TabIndex = 11;
            label4.Text = "Rating";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(ratingTextBox);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(categoryComboBox);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(addressTextBox);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(nameTextBox);
            groupBox1.Location = new Point(326, 32);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(588, 183);
            groupBox1.TabIndex = 12;
            groupBox1.TabStop = false;
            groupBox1.Text = "Selected establishment";
            // 
            // Final
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(926, 564);
            Controls.Add(groupBox1);
            Controls.Add(deleteButton);
            Controls.Add(changeButton);
            Controls.Add(appendButton);
            Controls.Add(establishmentListBox);
            Name = "Final";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MainForm";
            FormClosed += Final_FormClosed;
            Load += Final_Load;
            Click += Final_Click;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ListBox establishmentListBox;
        private Button appendButton;
        private Button changeButton;
        private Button deleteButton;
        private TextBox nameTextBox;
        private TextBox addressTextBox;
        private ComboBox categoryComboBox;
        private TextBox ratingTextBox;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private GroupBox groupBox1;
    }
}