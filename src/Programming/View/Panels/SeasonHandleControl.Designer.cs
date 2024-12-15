namespace Programming.View.Panels
{
    partial class SeasonHandleControl
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
            HandleBox = new GroupBox();
            HandleLabel = new Label();
            HandleComboBox = new ComboBox();
            HandleButton = new Button();
            HandleBox.SuspendLayout();
            SuspendLayout();
            // 
            // HandleBox
            // 
            HandleBox.Controls.Add(HandleLabel);
            HandleBox.Controls.Add(HandleComboBox);
            HandleBox.Controls.Add(HandleButton);
            HandleBox.Location = new Point(0, 0);
            HandleBox.Name = "HandleBox";
            HandleBox.Size = new Size(261, 109);
            HandleBox.TabIndex = 6;
            HandleBox.TabStop = false;
            HandleBox.Text = "Season Handle";
            // 
            // HandleLabel
            // 
            HandleLabel.AutoSize = true;
            HandleLabel.Location = new Point(0, 34);
            HandleLabel.Name = "HandleLabel";
            HandleLabel.Size = new Size(114, 20);
            HandleLabel.TabIndex = 3;
            HandleLabel.Text = "Choose Seasom";
            // 
            // HandleComboBox
            // 
            HandleComboBox.FormattingEnabled = true;
            HandleComboBox.Items.AddRange(new object[] { "Autumn", "Spring", "Summer", "Winter" });
            HandleComboBox.Location = new Point(0, 57);
            HandleComboBox.Name = "HandleComboBox";
            HandleComboBox.Size = new Size(151, 28);
            HandleComboBox.TabIndex = 2;
            // 
            // HandleButton
            // 
            HandleButton.Location = new Point(157, 57);
            HandleButton.Name = "HandleButton";
            HandleButton.Size = new Size(94, 29);
            HandleButton.TabIndex = 1;
            HandleButton.Text = "GO!";
            HandleButton.UseVisualStyleBackColor = true;
            HandleButton.Click += HandleButton_Click;
            // 
            // SeasonHandleControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(HandleBox);
            Name = "SeasonHandleControl";
            Size = new Size(264, 123);
            HandleBox.ResumeLayout(false);
            HandleBox.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox HandleBox;
        private Label HandleLabel;
        private ComboBox HandleComboBox;
        private Button HandleButton;
    }
}
