using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programming.View.Panels
{
    public partial class RectanglesCollisionControl : UserControl
    {
        private List<Rectangle> _rectangle = new List<Rectangle>();
        private Rectangle _currentRectangle;
        private List<Panel> _rectanglePanels = new List<Panel>();

        public RectanglesCollisionControl()
        {
            InitializeComponent();
        }
        private void appendButton_Click(object sender, EventArgs e)
        {
            try
            {
                Rectangle addRectangle = RectangleFactory.Randomize();

                rectanglesListBox.Items.Add(addRectangle);
                rectanglesListBox.SelectedIndex = 0;
                _rectangle.Add(addRectangle);


                Addpanel(addRectangle);

            }
            catch { }
            FindCollisions();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                int id = rectanglesListBox.SelectedIndex;
                rectanglesListBox.Items.RemoveAt(id);

                rectanglesPanel.Controls.RemoveAt(id);
                _rectangle.RemoveAt(id);
                _rectanglePanels.RemoveAt(id);
                rectanglesListBox.SelectedIndex = 0;
                FindCollisions();
            }
            catch { }
            FindCollisions();
        }

        private void rectanglesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                _currentRectangle = _rectangle[rectanglesListBox.SelectedIndex];
                UpdateRectangleInfo(_currentRectangle);
            }
            catch
            {
                ClearRectangleInfo();
            }
        }

        private void xTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _rectangle[rectanglesListBox.SelectedIndex].Center.X
                    = Convert.ToInt32(xTextBox.Text);
                xTextBox.BackColor = System.Drawing.Color.White;
                rectanglesListBox.Items[rectanglesListBox.SelectedIndex] = _rectangle[rectanglesListBox.SelectedIndex];
            }
            catch
            {
                xTextBox.BackColor = System.Drawing.Color.LightPink;
            }
        }

        private void yTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _rectangle[rectanglesListBox.SelectedIndex].Center.Y
                    = Convert.ToInt32(yTextBox.Text);
                yTextBox.BackColor = System.Drawing.Color.White;
                rectanglesListBox.Items[rectanglesListBox.SelectedIndex] = _rectangle[rectanglesListBox.SelectedIndex];
            }
            catch
            {
                yTextBox.BackColor = System.Drawing.Color.LightPink;
            }
        }

        private void width_textBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _rectangle[rectanglesListBox.SelectedIndex].Widght
                    = Convert.ToInt32(width_textBox.Text);
                width_textBox.BackColor = System.Drawing.Color.White;
                rectanglesListBox.Items[rectanglesListBox.SelectedIndex] = _rectangle[rectanglesListBox.SelectedIndex];
            }
            catch
            {
                width_textBox.BackColor = System.Drawing.Color.LightPink;
            }
        }

        private void heightTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _rectangle[rectanglesListBox.SelectedIndex].Length
                    = Convert.ToInt32(heightTextBox.Text);
                heightTextBox.BackColor = System.Drawing.Color.White;
                rectanglesListBox.Items[rectanglesListBox.SelectedIndex] = _rectangle[rectanglesListBox.SelectedIndex];
            }
            catch
            {
                heightTextBox.BackColor = System.Drawing.Color.LightPink;
            }
        }
        private void xTextBox_Leave(object sender, EventArgs e)
        {
            try
            {
                rectanglesListBox.Items[rectanglesListBox.SelectedIndex] = _currentRectangle;
                _rectanglePanels[rectanglesListBox.SelectedIndex].Location = new Point(Convert.ToInt32(_currentRectangle.Center.X) - (int)_currentRectangle.Widght / 2, Convert.ToInt32(_currentRectangle.Center.Y) - (int)_currentRectangle.Length / 2);
                rectanglesPanel.Controls[rectanglesListBox.SelectedIndex].Location = new Point(Convert.ToInt32(_currentRectangle.Center.X) - (int)_currentRectangle.Widght / 2, Convert.ToInt32(_currentRectangle.Center.Y) - (int)_currentRectangle.Length / 2);
                FindCollisions();
            }
            catch { }
        }

        private void yTextBox_Leave(object sender, EventArgs e)
        {
            try
            {
                rectanglesListBox.Items[rectanglesListBox.SelectedIndex] = _currentRectangle;
                _rectanglePanels[rectanglesListBox.SelectedIndex].Location = new Point(Convert.ToInt32(_currentRectangle.Center.Y) - (int)_currentRectangle.Widght / 2, Convert.ToInt32(_currentRectangle.Center.Y) - (int)_currentRectangle.Length / 2);
                rectanglesPanel.Controls[rectanglesListBox.SelectedIndex].Location = new Point(Convert.ToInt32(_currentRectangle.Center.X) - (int)_currentRectangle.Widght / 2, Convert.ToInt32(_currentRectangle.Center.Y) - (int)_currentRectangle.Length / 2);
                FindCollisions();
            }
            catch { }
        }

        private void width_textBox_Leave(object sender, EventArgs e)
        {
            try
            {
                rectanglesListBox.Items[rectanglesListBox.SelectedIndex] = _currentRectangle;
                _rectanglePanels[rectanglesListBox.SelectedIndex].Width = _currentRectangle.Widght;
                rectanglesListBox.Controls[rectanglesListBox.SelectedIndex].Width = _currentRectangle.Widght;
                FindCollisions();
            }
            catch { }
        }

        private void heightTextBox_Leave(object sender, EventArgs e)
        {
            try
            {
                rectanglesListBox.Items[rectanglesListBox.SelectedIndex] = _currentRectangle;
                _rectanglePanels[rectanglesListBox.SelectedIndex].Height = _currentRectangle.Length;
                rectanglesListBox.Controls[rectanglesListBox.SelectedIndex].Height = _currentRectangle.Length;
                FindCollisions();
            }
            catch { }
        }

        /// <summary>
        /// Обновляет информацию о прямоугольнике 
        /// </summary>
        /// <param name="rectangle"></param>
        private void UpdateRectangleInfo(Rectangle rectangle)
        {
            id_textBox.Text = rectangle.Id.ToString();
            xTextBox.Text = rectangle.Center.X.ToString();
            yTextBox.Text = rectangle.Center.Y.ToString();
            width_textBox.Text = rectangle.Widght.ToString();
            heightTextBox.Text = rectangle.Length.ToString();

        }

        /// <summary>
        /// Добавляет фигуры на Panel
        /// </summary>
        /// <param name="rect"></param>
        private void Addpanel(Rectangle rect)
        {
            Panel panel = new Panel();
            panel.BackColor = System.Drawing.Color.FromArgb(127, 127, 255, 0);
            panel.Height = (int)rect.Length;
            panel.Width = (int)rect.Widght;
            panel.Location = new Point(Convert.ToInt32(rect.Center.X) - (int)rect.Widght / 2, Convert.ToInt32(rect.Center.Y) - rect.Length / 2);
            _rectanglePanels.Add(panel);
            rectanglesPanel.Controls.Add(panel);
        }

        /// <summary>
        /// Красит фигуры, которые пересикаются, в красный цвет
        /// </summary>
        private void FindCollisions()
        {
            for (int i = 0; i < _rectanglePanels.Count; i++)
            {
                _rectanglePanels[i].BackColor = System.Drawing.Color.FromArgb(127, 127, 255, 0);
                rectanglesPanel.Controls[i].BackColor = System.Drawing.Color.FromArgb(127, 127, 255, 0);

            }
            for (int i = 0; i < _rectanglePanels.Count; i++)
            {
                for (int j = 0; j < _rectanglePanels.Count; j++)
                {
                    if ((i != j) && CollisionManager.IsCollision(_rectangle[i], _rectangle[j]))
                    {
                        _rectanglePanels[i].BackColor = System.Drawing.Color.FromArgb(127, 255, 127, 0);
                        _rectanglePanels[j].BackColor = System.Drawing.Color.FromArgb(127, 255, 127, 0);
                        rectanglesPanel.Controls[i].BackColor = System.Drawing.Color.FromArgb(127, 255, 127, 0);
                        rectanglesPanel.Controls[j].BackColor = System.Drawing.Color.FromArgb(127, 255, 127, 0);
                    }
                }
            }
        }
        /// <summary>
        /// Делает пустыми все TextBox
        /// </summary>
        private void ClearRectangleInfo()
        {
            id_textBox.Clear();
            xTextBox.Clear();
            yTextBox.Clear();
            width_textBox.Clear();
            heightTextBox.Clear();
        }
    }
}
