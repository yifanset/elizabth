namespace Programming
{
    partial class MainForm
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
            tabPage2 = new TabPage();
            rectanglesCollisionControl1 = new View.Panels.RectanglesCollisionControl();
            Classes = new TabPage();
            classesRectangleControl1 = new View.Panels.ClassesRectangleControl();
            Tab = new TabPage();
            seasonHandleControl1 = new View.Panels.SeasonHandleControl();
            weerdayParsingControl1 = new View.Panels.WeerdayParsingControl();
            enumerationsControl1 = new View.Panels.EnumerationsControl();
            Enums = new TabControl();
            classesMovieControl1 = new View.Panels.ClassesMovieControl();
            tabPage2.SuspendLayout();
            Classes.SuspendLayout();
            Tab.SuspendLayout();
            Enums.SuspendLayout();
            SuspendLayout();
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(rectanglesCollisionControl1);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(689, 442);
            tabPage2.TabIndex = 3;
            tabPage2.Text = "Rectangles";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // rectanglesCollisionControl1
            // 
            rectanglesCollisionControl1.Dock = DockStyle.Fill;
            rectanglesCollisionControl1.Location = new Point(3, 3);
            rectanglesCollisionControl1.Name = "rectanglesCollisionControl1";
            rectanglesCollisionControl1.Size = new Size(683, 436);
            rectanglesCollisionControl1.TabIndex = 0;
            // 
            // Classes
            // 
            Classes.Controls.Add(classesMovieControl1);
            Classes.Controls.Add(classesRectangleControl1);
            Classes.Location = new Point(4, 29);
            Classes.Name = "Classes";
            Classes.Size = new Size(689, 442);
            Classes.TabIndex = 2;
            Classes.Text = "Classes";
            Classes.UseVisualStyleBackColor = true;
            // 
            // classesRectangleControl1
            // 
            classesRectangleControl1.Location = new Point(3, 3);
            classesRectangleControl1.Name = "classesRectangleControl1";
            classesRectangleControl1.Size = new Size(320, 439);
            classesRectangleControl1.TabIndex = 2;
            // 
            // Tab
            // 
            Tab.Controls.Add(seasonHandleControl1);
            Tab.Controls.Add(weerdayParsingControl1);
            Tab.Controls.Add(enumerationsControl1);
            Tab.Location = new Point(4, 29);
            Tab.Name = "Tab";
            Tab.Padding = new Padding(3);
            Tab.Size = new Size(689, 442);
            Tab.TabIndex = 1;
            Tab.Text = "Enums";
            Tab.UseVisualStyleBackColor = true;
            // 
            // seasonHandleControl1
            // 
            seasonHandleControl1.Location = new Point(421, 292);
            seasonHandleControl1.Name = "seasonHandleControl1";
            seasonHandleControl1.Size = new Size(265, 111);
            seasonHandleControl1.TabIndex = 8;
            // 
            // weerdayParsingControl1
            // 
            weerdayParsingControl1.Location = new Point(8, 280);
            weerdayParsingControl1.Name = "weerdayParsingControl1";
            weerdayParsingControl1.Size = new Size(386, 123);
            weerdayParsingControl1.TabIndex = 7;
            // 
            // enumerationsControl1
            // 
            enumerationsControl1.Location = new Point(8, 0);
            enumerationsControl1.Name = "enumerationsControl1";
            enumerationsControl1.Size = new Size(685, 283);
            enumerationsControl1.TabIndex = 6;
            // 
            // Enums
            // 
            Enums.Controls.Add(Tab);
            Enums.Controls.Add(Classes);
            Enums.Controls.Add(tabPage2);
            Enums.Dock = DockStyle.Fill;
            Enums.Location = new Point(0, 0);
            Enums.Name = "Enums";
            Enums.SelectedIndex = 0;
            Enums.Size = new Size(697, 475);
            Enums.TabIndex = 0;
            // 
            // classesMovieControl1
            // 
            classesMovieControl1.Location = new Point(329, 3);
            classesMovieControl1.Name = "classesMovieControl1";
            classesMovieControl1.Size = new Size(335, 293);
            classesMovieControl1.TabIndex = 3;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(697, 475);
            Controls.Add(Enums);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MainForm";
            tabPage2.ResumeLayout(false);
            Classes.ResumeLayout(false);
            Tab.ResumeLayout(false);
            Enums.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabPage tabPage2;
        private View.Panels.RectanglesCollisionControl rectanglesCollisionControl1;
        private TabPage Classes;
        private TabPage Tab;
        private View.Panels.EnumerationsControl enumerationsControl1;
        private TabControl Enums;
        private View.Panels.WeerdayParsingControl weerdayParsingControl1;
        private View.Panels.SeasonHandleControl seasonHandleControl1;
        private View.Panels.ClassesRectangleControl classesRectangleControl1;
        private View.Panels.ClassesMovieControl classesMovieControl1;
    }
}