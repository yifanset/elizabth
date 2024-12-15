using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Programming.View.Panels
{
    public partial class ClassesRectangleControl : UserControl
    {
        private Rectangle[] _rectangles;
        private Rectangle _currentRectangles;
        
        public ClassesRectangleControl()
        {
            InitializeComponent();
            _rectangles = new Rectangle[5];
            Random random = new Random();

            for (int i = 0; i < 5; i++)
            {
                _rectangles[i] = new Rectangle(random.Next(1, 10),
                    random.Next(1, 10), "Green", random.Next(1, 50), random.Next(1, 50));
            }

            RectangleListBox1.SelectedIndex = 0;
        }

        

        private void RectangleListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            _currentRectangles = _rectangles[RectangleListBox1.SelectedIndex];
            LengthTextBox.Text = _currentRectangles.Length.ToString();
            WidthTextBox.Text = _currentRectangles.Widght.ToString();
            ColorTextBox.Text = _currentRectangles.Color.ToString();
            CenterXTextBox.Text = _currentRectangles.Center.X.ToString();
            CenterYTextBox.Text = _currentRectangles.Center.Y.ToString();
            IdtextBox.Text = _currentRectangles.Id.ToString();
        }
        private void LengthTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _rectangles[RectangleListBox1.SelectedIndex].Length
                    = Convert.ToInt32(LengthTextBox.Text);
                LengthTextBox.BackColor = System.Drawing.Color.White;
            }
            catch
            {
                LengthTextBox.BackColor = System.Drawing.Color.LightPink;
            }
        }

        private void WidthTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _rectangles[RectangleListBox1.SelectedIndex].Widght
                    = Convert.ToInt32(WidthTextBox.Text);
                WidthTextBox.BackColor = System.Drawing.Color.White;
            }
            catch
            {
                WidthTextBox.BackColor = System.Drawing.Color.LightPink;
            }
        }

        private void ColorTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _rectangles[RectangleListBox1.SelectedIndex].Color
                    = ColorTextBox.Text;
                ColorTextBox.BackColor = System.Drawing.Color.White;
            }
            catch
            {
                ColorTextBox.BackColor = System.Drawing.Color.LightPink;
            }
        }

        /// <summary>
        /// Находит прямоугольник по максимальной ширине
        /// </summary>
        /// <param name="rectangle"></param>
        /// <returns></returns>
        private int FindRectangleWithMaxWidth(Rectangle[] rectangle)
        {
            int maxIndex = 0;
            double maxWidth = 0;
            for (int i = 0; i < rectangle.Length; i++)
            {
                if (maxWidth < rectangle[i].Widght)
                {
                    maxWidth = rectangle[i].Widght;
                    maxIndex = i;
                }
            }
            return maxIndex;
        }

        private void FindButton_Click(object sender, EventArgs e)
        {
            int maxIndex = FindRectangleWithMaxWidth(_rectangles);
            RectangleListBox1.SelectedIndex = maxIndex;
        }
    }
}
