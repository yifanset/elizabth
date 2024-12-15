namespace Programming.View.Panels
{
    partial class RectanglesCollisionControl
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
            groupBox2 = new GroupBox();
            rectanglesListBox = new ListBox();
            rectanglesPanel = new Panel();
            label18 = new Label();
            appendButton = new Button();
            label17 = new Label();
            deleteButton = new Button();
            label16 = new Label();
            label14 = new Label();
            label15 = new Label();
            id_textBox = new TextBox();
            xTextBox = new TextBox();
            width_textBox = new TextBox();
            yTextBox = new TextBox();
            heightTextBox = new TextBox();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(rectanglesListBox);
            groupBox2.Controls.Add(rectanglesPanel);
            groupBox2.Controls.Add(label18);
            groupBox2.Controls.Add(appendButton);
            groupBox2.Controls.Add(label17);
            groupBox2.Controls.Add(deleteButton);
            groupBox2.Controls.Add(label16);
            groupBox2.Controls.Add(label14);
            groupBox2.Controls.Add(label15);
            groupBox2.Controls.Add(id_textBox);
            groupBox2.Controls.Add(xTextBox);
            groupBox2.Controls.Add(width_textBox);
            groupBox2.Controls.Add(yTextBox);
            groupBox2.Controls.Add(heightTextBox);
            groupBox2.Location = new Point(3, 3);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(687, 446);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Rectangles";
            // 
            // rectanglesListBox
            // 
            rectanglesListBox.FormattingEnabled = true;
            rectanglesListBox.ItemHeight = 20;
            rectanglesListBox.Location = new Point(6, 30);
            rectanglesListBox.Name = "rectanglesListBox";
            rectanglesListBox.Size = new Size(196, 184);
            rectanglesListBox.TabIndex = 3;
            rectanglesListBox.SelectedIndexChanged += rectanglesListBox_SelectedIndexChanged;
            // 
            // rectanglesPanel
            // 
            rectanglesPanel.BorderStyle = BorderStyle.FixedSingle;
            rectanglesPanel.Location = new Point(207, 17);
            rectanglesPanel.Name = "rectanglesPanel";
            rectanglesPanel.Size = new Size(471, 417);
            rectanglesPanel.TabIndex = 14;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(6, 410);
            label18.Name = "label18";
            label18.Size = new Size(54, 20);
            label18.TabIndex = 12;
            label18.Text = "Height";
            // 
            // appendButton
            // 
            appendButton.FlatStyle = FlatStyle.Flat;
            appendButton.Location = new Point(3, 240);
            appendButton.Name = "appendButton";
            appendButton.Size = new Size(94, 29);
            appendButton.TabIndex = 1;
            appendButton.Text = "APPEND";
            appendButton.UseVisualStyleBackColor = true;
            appendButton.Click += appendButton_Click;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(6, 377);
            label17.Name = "label17";
            label17.Size = new Size(52, 20);
            label17.TabIndex = 11;
            label17.Text = "Width:";
            // 
            // deleteButton
            // 
            deleteButton.FlatStyle = FlatStyle.Flat;
            deleteButton.Location = new Point(101, 240);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(94, 29);
            deleteButton.TabIndex = 2;
            deleteButton.Text = "DELETE";
            deleteButton.UseVisualStyleBackColor = true;
            deleteButton.Click += deleteButton_Click;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(6, 344);
            label16.Name = "label16";
            label16.Size = new Size(20, 20);
            label16.TabIndex = 10;
            label16.Text = "Y:";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(6, 278);
            label14.Name = "label14";
            label14.Size = new Size(25, 20);
            label14.TabIndex = 8;
            label14.Text = "id:";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(6, 311);
            label15.Name = "label15";
            label15.Size = new Size(21, 20);
            label15.TabIndex = 9;
            label15.Text = "X:";
            // 
            // id_textBox
            // 
            id_textBox.Location = new Point(70, 275);
            id_textBox.Name = "id_textBox";
            id_textBox.ReadOnly = true;
            id_textBox.Size = new Size(125, 27);
            id_textBox.TabIndex = 4;
            // 
            // xTextBox
            // 
            xTextBox.Location = new Point(70, 308);
            xTextBox.Name = "xTextBox";
            xTextBox.Size = new Size(125, 27);
            xTextBox.TabIndex = 5;
            xTextBox.TextChanged += xTextBox_TextChanged;
            xTextBox.Leave += xTextBox_Leave;
            // 
            // width_textBox
            // 
            width_textBox.Location = new Point(70, 374);
            width_textBox.Name = "width_textBox";
            width_textBox.Size = new Size(125, 27);
            width_textBox.TabIndex = 7;
            width_textBox.TextChanged += width_textBox_TextChanged;
            width_textBox.Leave += width_textBox_Leave;
            // 
            // yTextBox
            // 
            yTextBox.Location = new Point(70, 341);
            yTextBox.Name = "yTextBox";
            yTextBox.Size = new Size(125, 27);
            yTextBox.TabIndex = 6;
            yTextBox.TextChanged += yTextBox_TextChanged;
            yTextBox.Leave += yTextBox_Leave;
            // 
            // heightTextBox
            // 
            heightTextBox.Location = new Point(70, 407);
            heightTextBox.Name = "heightTextBox";
            heightTextBox.Size = new Size(125, 27);
            heightTextBox.TabIndex = 7;
            heightTextBox.TextChanged += heightTextBox_TextChanged;
            heightTextBox.Leave += heightTextBox_TextChanged;
            // 
            // RectanglesCollisionControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(groupBox2);
            Name = "RectanglesCollisionControl";
            Size = new Size(689, 448);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox2;
        private ListBox rectanglesListBox;
        private Panel rectanglesPanel;
        private Label label18;
        private Button appendButton;
        private Label label17;
        private Button deleteButton;
        private Label label16;
        private Label label14;
        private Label label15;
        private TextBox id_textBox;
        private TextBox xTextBox;
        private TextBox width_textBox;
        private TextBox yTextBox;
        private TextBox heightTextBox;
    }
}
