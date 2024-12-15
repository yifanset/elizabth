namespace Programming.View.Panels
{
    partial class EnumerationsControl
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
            EnumBox = new GroupBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            EnumsListBox = new ListBox();
            ValueTextBox = new TextBox();
            ValuesListBox = new ListBox();
            EnumBox.SuspendLayout();
            SuspendLayout();
            // 
            // EnumBox
            // 
            EnumBox.Controls.Add(label4);
            EnumBox.Controls.Add(label3);
            EnumBox.Controls.Add(label2);
            EnumBox.Controls.Add(EnumsListBox);
            EnumBox.Controls.Add(ValueTextBox);
            EnumBox.Controls.Add(ValuesListBox);
            EnumBox.Location = new Point(3, 3);
            EnumBox.Name = "EnumBox";
            EnumBox.Size = new Size(672, 272);
            EnumBox.TabIndex = 4;
            EnumBox.TabStop = false;
            EnumBox.Text = "Enumerations";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(243, 39);
            label4.Name = "label4";
            label4.Size = new Size(98, 20);
            label4.TabIndex = 5;
            label4.Text = "Choose Value";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(445, 39);
            label3.Name = "label3";
            label3.Size = new Size(66, 20);
            label3.TabIndex = 4;
            label3.Text = "Int Value";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(60, 39);
            label2.Name = "label2";
            label2.Size = new Size(152, 20);
            label2.TabIndex = 3;
            label2.Text = "Choose Enumerations";
            // 
            // EnumsListBox
            // 
            EnumsListBox.FormattingEnabled = true;
            EnumsListBox.ItemHeight = 20;
            EnumsListBox.Items.AddRange(new object[] { "Color", "Season", "Weekday", "Genre", "Manufacturies", "EducationForm" });
            EnumsListBox.Location = new Point(62, 62);
            EnumsListBox.Name = "EnumsListBox";
            EnumsListBox.ScrollAlwaysVisible = true;
            EnumsListBox.Size = new Size(150, 204);
            EnumsListBox.TabIndex = 0;
            EnumsListBox.SelectedIndexChanged += EnumsListBox_SelectedIndexChanged;
            // 
            // ValueTextBox
            // 
            ValueTextBox.Location = new Point(445, 62);
            ValueTextBox.Name = "ValueTextBox";
            ValueTextBox.ReadOnly = true;
            ValueTextBox.Size = new Size(125, 27);
            ValueTextBox.TabIndex = 2;
            // 
            // ValuesListBox
            // 
            ValuesListBox.FormattingEnabled = true;
            ValuesListBox.ItemHeight = 20;
            ValuesListBox.Location = new Point(243, 62);
            ValuesListBox.Name = "ValuesListBox";
            ValuesListBox.Size = new Size(150, 204);
            ValuesListBox.TabIndex = 1;
            ValuesListBox.SelectedIndexChanged += ValuesListBox_SelectedIndexChanged;
            // 
            // EnumerationsControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(EnumBox);
            Name = "EnumerationsControl";
            Size = new Size(681, 279);
            EnumBox.ResumeLayout(false);
            EnumBox.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox EnumBox;
        private Label label4;
        private Label label3;
        private Label label2;
        private ListBox EnumsListBox;
        private TextBox ValueTextBox;
        private ListBox ValuesListBox;
    }
}
