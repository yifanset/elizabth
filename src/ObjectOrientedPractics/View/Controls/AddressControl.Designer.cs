namespace ObjectOrientedPractics.View.Controls
{
    partial class AddressControl
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
            label1 = new Label();
            IndexTextBox = new TextBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label2 = new Label();
            label6 = new Label();
            CountryTextBox = new TextBox();
            StreetTextBox = new TextBox();
            BuildingTextBox = new TextBox();
            CityTextBox = new TextBox();
            ApartmentTextBox = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Location = new Point(3, 10);
            label1.Name = "label1";
            label1.Size = new Size(79, 20);
            label1.TabIndex = 0;
            label1.Text = "Post Index:";
            // 
            // IndexTextBox
            // 
            IndexTextBox.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            IndexTextBox.Location = new Point(88, 7);
            IndexTextBox.MaximumSize = new Size(60, 30);
            IndexTextBox.MinimumSize = new Size(60, 30);
            IndexTextBox.Name = "IndexTextBox";
            IndexTextBox.Size = new Size(60, 27);
            IndexTextBox.TabIndex = 1;
            IndexTextBox.TextChanged += IndexTextBox_TextChanged;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Location = new Point(3, 46);
            label3.Name = "label3";
            label3.Size = new Size(63, 20);
            label3.TabIndex = 3;
            label3.Text = "Country:";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Location = new Point(3, 118);
            label4.Name = "label4";
            label4.Size = new Size(51, 20);
            label4.TabIndex = 4;
            label4.Text = "Street:";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Location = new Point(3, 154);
            label5.Name = "label5";
            label5.Size = new Size(73, 20);
            label5.TabIndex = 5;
            label5.Text = "Buildings:";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Location = new Point(3, 82);
            label2.Margin = new Padding(0, 4, 0, 0);
            label2.Name = "label2";
            label2.Size = new Size(34, 20);
            label2.TabIndex = 2;
            label2.Text = "City";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label6.AutoSize = true;
            label6.Location = new Point(3, 190);
            label6.Name = "label6";
            label6.Size = new Size(83, 20);
            label6.TabIndex = 6;
            label6.Text = "Apartment:";
            // 
            // CountryTextBox
            // 
            CountryTextBox.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            CountryTextBox.Location = new Point(88, 43);
            CountryTextBox.Margin = new Padding(0, 4, 0, 0);
            CountryTextBox.MaximumSize = new Size(320, 400);
            CountryTextBox.MinimumSize = new Size(100, 30);
            CountryTextBox.Name = "CountryTextBox";
            CountryTextBox.Size = new Size(155, 30);
            CountryTextBox.TabIndex = 2;
            CountryTextBox.TextChanged += CountryTextBox_TextChanged;
            // 
            // StreetTextBox
            // 
            StreetTextBox.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            StreetTextBox.Location = new Point(88, 115);
            StreetTextBox.MaximumSize = new Size(320, 400);
            StreetTextBox.MinimumSize = new Size(100, 30);
            StreetTextBox.Name = "StreetTextBox";
            StreetTextBox.Size = new Size(320, 30);
            StreetTextBox.TabIndex = 4;
            StreetTextBox.TextChanged += StreetTextBox_TextChanged;
            // 
            // BuildingTextBox
            // 
            BuildingTextBox.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            BuildingTextBox.Location = new Point(88, 151);
            BuildingTextBox.MaximumSize = new Size(320, 400);
            BuildingTextBox.MinimumSize = new Size(100, 30);
            BuildingTextBox.Name = "BuildingTextBox";
            BuildingTextBox.Size = new Size(100, 27);
            BuildingTextBox.TabIndex = 5;
            BuildingTextBox.TextChanged += BuildingTextBox_TextChanged;
            // 
            // CityTextBox
            // 
            CityTextBox.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            CityTextBox.Location = new Point(88, 79);
            CityTextBox.MaximumSize = new Size(320, 400);
            CityTextBox.MinimumSize = new Size(100, 30);
            CityTextBox.Name = "CityTextBox";
            CityTextBox.Size = new Size(155, 30);
            CityTextBox.TabIndex = 3;
            CityTextBox.TextChanged += CityTextBox_TextChanged;
            // 
            // ApartmentTextBox
            // 
            ApartmentTextBox.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            ApartmentTextBox.Location = new Point(88, 187);
            ApartmentTextBox.MaximumSize = new Size(320, 400);
            ApartmentTextBox.MinimumSize = new Size(100, 30);
            ApartmentTextBox.Name = "ApartmentTextBox";
            ApartmentTextBox.Size = new Size(100, 27);
            ApartmentTextBox.TabIndex = 6;
            ApartmentTextBox.TextChanged += ApartmentTextBox_TextChanged;
            // 
            // AddressControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(ApartmentTextBox);
            Controls.Add(CityTextBox);
            Controls.Add(BuildingTextBox);
            Controls.Add(StreetTextBox);
            Controls.Add(CountryTextBox);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(IndexTextBox);
            Controls.Add(label1);
            Name = "AddressControl";
            Size = new Size(467, 231);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox IndexTextBox;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label2;
        private Label label6;
        private TextBox CountryTextBox;
        private TextBox StreetTextBox;
        private TextBox BuildingTextBox;
        private TextBox CityTextBox;
        private TextBox ApartmentTextBox;
    }
}
