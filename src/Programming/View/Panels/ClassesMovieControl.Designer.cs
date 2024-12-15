namespace Programming.View.Panels
{
    partial class ClassesMovieControl
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
            groupBox1 = new GroupBox();
            FindMovieButton = new Button();
            label8 = new Label();
            RaitingTextBox = new TextBox();
            label9 = new Label();
            GenreTextBox = new TextBox();
            label10 = new Label();
            NameTextBox = new TextBox();
            MovieListBox = new ListBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(FindMovieButton);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(RaitingTextBox);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(GenreTextBox);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(NameTextBox);
            groupBox1.Controls.Add(MovieListBox);
            groupBox1.Location = new Point(3, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(314, 275);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Movie";
            // 
            // FindMovieButton
            // 
            FindMovieButton.Location = new Point(181, 221);
            FindMovieButton.Name = "FindMovieButton";
            FindMovieButton.Size = new Size(94, 29);
            FindMovieButton.TabIndex = 11;
            FindMovieButton.Text = "Find";
            FindMovieButton.UseVisualStyleBackColor = true;
            FindMovieButton.Click += FindMovieButton_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(181, 143);
            label8.Name = "label8";
            label8.Size = new Size(56, 20);
            label8.TabIndex = 8;
            label8.Text = "Raiting";
            // 
            // RaitingTextBox
            // 
            RaitingTextBox.Location = new Point(181, 166);
            RaitingTextBox.Name = "RaitingTextBox";
            RaitingTextBox.Size = new Size(125, 27);
            RaitingTextBox.TabIndex = 7;
            RaitingTextBox.TextChanged += RaitingTextBox_TextChanged;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(181, 84);
            label9.Name = "label9";
            label9.Size = new Size(48, 20);
            label9.TabIndex = 6;
            label9.Text = "Genre";
            // 
            // GenreTextBox
            // 
            GenreTextBox.Location = new Point(181, 107);
            GenreTextBox.Name = "GenreTextBox";
            GenreTextBox.Size = new Size(125, 27);
            GenreTextBox.TabIndex = 5;
            GenreTextBox.TextChanged += GenreTextBox_TextChanged;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(181, 26);
            label10.Name = "label10";
            label10.Size = new Size(49, 20);
            label10.TabIndex = 4;
            label10.Text = "Name";
            // 
            // NameTextBox
            // 
            NameTextBox.Location = new Point(181, 49);
            NameTextBox.Name = "NameTextBox";
            NameTextBox.Size = new Size(125, 27);
            NameTextBox.TabIndex = 2;
            NameTextBox.TextChanged += NameTextBox_TextChanged;
            // 
            // MovieListBox
            // 
            MovieListBox.FormattingEnabled = true;
            MovieListBox.ItemHeight = 20;
            MovieListBox.Items.AddRange(new object[] { "Movie 1", "Movie 2", "Movie 3", "Movie 4", "Movie 5" });
            MovieListBox.Location = new Point(6, 26);
            MovieListBox.Name = "MovieListBox";
            MovieListBox.Size = new Size(150, 224);
            MovieListBox.TabIndex = 1;
            MovieListBox.SelectedIndexChanged += MovieListBox_SelectedIndexChanged;
            // 
            // ClassesMovieControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(groupBox1);
            Name = "ClassesMovieControl";
            Size = new Size(318, 281);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button FindMovieButton;
        private Label label8;
        private TextBox RaitingTextBox;
        private Label label9;
        private TextBox GenreTextBox;
        private Label label10;
        private TextBox NameTextBox;
        private ListBox MovieListBox;
    }
}
