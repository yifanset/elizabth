namespace Programming.View.Panels
{
    partial class ClassesRectangleControl
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
            CenterBox = new GroupBox();
            label12 = new Label();
            CenterYTextBox = new TextBox();
            label11 = new Label();
            CenterXTextBox = new TextBox();
            RectangleBox = new GroupBox();
            label13 = new Label();
            IdtextBox = new TextBox();
            FindRectangleButton = new Button();
            label7 = new Label();
            ColorTextBox = new TextBox();
            label6 = new Label();
            WidthTextBox = new TextBox();
            label5 = new Label();
            LengthTextBox = new TextBox();
            RectangleListBox1 = new ListBox();
            CenterBox.SuspendLayout();
            RectangleBox.SuspendLayout();
            SuspendLayout();
            // 
            // CenterBox
            // 
            CenterBox.Controls.Add(label12);
            CenterBox.Controls.Add(CenterYTextBox);
            CenterBox.Controls.Add(label11);
            CenterBox.Controls.Add(CenterXTextBox);
            CenterBox.Location = new Point(3, 309);
            CenterBox.Name = "CenterBox";
            CenterBox.Size = new Size(317, 118);
            CenterBox.TabIndex = 4;
            CenterBox.TabStop = false;
            CenterBox.Text = "Center";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(6, 76);
            label12.Name = "label12";
            label12.Size = new Size(35, 20);
            label12.TabIndex = 11;
            label12.Text = "Y = ";
            // 
            // CenterYTextBox
            // 
            CenterYTextBox.Location = new Point(47, 73);
            CenterYTextBox.Name = "CenterYTextBox";
            CenterYTextBox.ReadOnly = true;
            CenterYTextBox.Size = new Size(97, 27);
            CenterYTextBox.TabIndex = 10;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(6, 43);
            label11.Name = "label11";
            label11.Size = new Size(36, 20);
            label11.TabIndex = 9;
            label11.Text = "X = ";
            // 
            // CenterXTextBox
            // 
            CenterXTextBox.Location = new Point(48, 40);
            CenterXTextBox.Name = "CenterXTextBox";
            CenterXTextBox.ReadOnly = true;
            CenterXTextBox.Size = new Size(96, 27);
            CenterXTextBox.TabIndex = 0;
            // 
            // RectangleBox
            // 
            RectangleBox.Controls.Add(label13);
            RectangleBox.Controls.Add(IdtextBox);
            RectangleBox.Controls.Add(FindRectangleButton);
            RectangleBox.Controls.Add(label7);
            RectangleBox.Controls.Add(ColorTextBox);
            RectangleBox.Controls.Add(label6);
            RectangleBox.Controls.Add(WidthTextBox);
            RectangleBox.Controls.Add(label5);
            RectangleBox.Controls.Add(LengthTextBox);
            RectangleBox.Controls.Add(RectangleListBox1);
            RectangleBox.Location = new Point(3, 5);
            RectangleBox.Name = "RectangleBox";
            RectangleBox.Size = new Size(314, 298);
            RectangleBox.TabIndex = 3;
            RectangleBox.TabStop = false;
            RectangleBox.Text = "Rectangle";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(181, 200);
            label13.Name = "label13";
            label13.Size = new Size(22, 20);
            label13.TabIndex = 13;
            label13.Text = "Id";
            // 
            // IdtextBox
            // 
            IdtextBox.Location = new Point(181, 223);
            IdtextBox.Name = "IdtextBox";
            IdtextBox.ReadOnly = true;
            IdtextBox.Size = new Size(125, 27);
            IdtextBox.TabIndex = 12;
            // 
            // FindRectangleButton
            // 
            FindRectangleButton.Location = new Point(181, 261);
            FindRectangleButton.Name = "FindRectangleButton";
            FindRectangleButton.Size = new Size(94, 29);
            FindRectangleButton.TabIndex = 11;
            FindRectangleButton.Text = "Find";
            FindRectangleButton.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(181, 143);
            label7.Name = "label7";
            label7.Size = new Size(45, 20);
            label7.TabIndex = 8;
            label7.Text = "Color";
            // 
            // ColorTextBox
            // 
            ColorTextBox.Location = new Point(181, 166);
            ColorTextBox.Name = "ColorTextBox";
            ColorTextBox.Size = new Size(125, 27);
            ColorTextBox.TabIndex = 7;
            ColorTextBox.TextChanged += ColorTextBox_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(181, 84);
            label6.Name = "label6";
            label6.Size = new Size(49, 20);
            label6.TabIndex = 6;
            label6.Text = "Width";
            // 
            // WidthTextBox
            // 
            WidthTextBox.Location = new Point(181, 107);
            WidthTextBox.Name = "WidthTextBox";
            WidthTextBox.Size = new Size(125, 27);
            WidthTextBox.TabIndex = 5;
            WidthTextBox.TextChanged += WidthTextBox_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(181, 26);
            label5.Name = "label5";
            label5.Size = new Size(54, 20);
            label5.TabIndex = 4;
            label5.Text = "Length";
            // 
            // LengthTextBox
            // 
            LengthTextBox.Location = new Point(181, 49);
            LengthTextBox.Name = "LengthTextBox";
            LengthTextBox.Size = new Size(125, 27);
            LengthTextBox.TabIndex = 2;
            LengthTextBox.TextChanged += LengthTextBox_TextChanged;
            // 
            // RectangleListBox1
            // 
            RectangleListBox1.FormattingEnabled = true;
            RectangleListBox1.ItemHeight = 20;
            RectangleListBox1.Items.AddRange(new object[] { "Rectangle 1", "Rectangle 2", "Rectangle 3", "Rectangle 4", "Rectangle 5" });
            RectangleListBox1.Location = new Point(6, 26);
            RectangleListBox1.Name = "RectangleListBox1";
            RectangleListBox1.Size = new Size(150, 264);
            RectangleListBox1.TabIndex = 1;
            RectangleListBox1.SelectedIndexChanged += RectangleListBox1_SelectedIndexChanged;
            // 
            // ClassesRectangleControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(CenterBox);
            Controls.Add(RectangleBox);
            Name = "ClassesRectangleControl";
            Size = new Size(320, 426);
            CenterBox.ResumeLayout(false);
            CenterBox.PerformLayout();
            RectangleBox.ResumeLayout(false);
            RectangleBox.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox CenterBox;
        private Label label12;
        private TextBox CenterYTextBox;
        private Label label11;
        private TextBox CenterXTextBox;
        private GroupBox RectangleBox;
        private Label label13;
        private TextBox IdtextBox;
        private Button FindRectangleButton;
        private Label label7;
        private TextBox ColorTextBox;
        private Label label6;
        private TextBox WidthTextBox;
        private Label label5;
        private TextBox LengthTextBox;
        private ListBox RectangleListBox1;
    }
}
