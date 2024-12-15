namespace Programming.View.Panels
{
    partial class WeerdayParsingControl
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
            ParseBox = new GroupBox();
            label1 = new Label();
            ViewParseTextBox = new TextBox();
            ParseButton = new Button();
            ParsingTextBox = new TextBox();
            ParseBox.SuspendLayout();
            SuspendLayout();
            // 
            // ParseBox
            // 
            ParseBox.Controls.Add(label1);
            ParseBox.Controls.Add(ViewParseTextBox);
            ParseBox.Controls.Add(ParseButton);
            ParseBox.Controls.Add(ParsingTextBox);
            ParseBox.Dock = DockStyle.Fill;
            ParseBox.Location = new Point(0, 0);
            ParseBox.Name = "ParseBox";
            ParseBox.Size = new Size(399, 130);
            ParseBox.TabIndex = 5;
            ParseBox.TabStop = false;
            ParseBox.Text = "Weekday Parsing";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 34);
            label1.Name = "label1";
            label1.Size = new Size(153, 20);
            label1.TabIndex = 3;
            label1.Text = "Tipe value for parsing";
            // 
            // ViewParseTextBox
            // 
            ViewParseTextBox.Location = new Point(6, 92);
            ViewParseTextBox.Name = "ViewParseTextBox";
            ViewParseTextBox.ReadOnly = true;
            ViewParseTextBox.Size = new Size(359, 27);
            ViewParseTextBox.TabIndex = 2;
            // 
            // ParseButton
            // 
            ParseButton.Location = new Point(271, 57);
            ParseButton.Name = "ParseButton";
            ParseButton.Size = new Size(94, 29);
            ParseButton.TabIndex = 1;
            ParseButton.Text = "Parse";
            ParseButton.UseVisualStyleBackColor = true;
            ParseButton.Click += ParseButton_Click;
            // 
            // ParsingTextBox
            // 
            ParsingTextBox.Location = new Point(6, 57);
            ParsingTextBox.Name = "ParsingTextBox";
            ParsingTextBox.Size = new Size(222, 27);
            ParsingTextBox.TabIndex = 0;
            // 
            // WeerdayParsingControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(ParseBox);
            Name = "WeerdayParsingControl";
            Size = new Size(399, 130);
            ParseBox.ResumeLayout(false);
            ParseBox.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox ParseBox;
        private Label label1;
        private TextBox ViewParseTextBox;
        private Button ParseButton;
        private TextBox ParsingTextBox;
    }
}
