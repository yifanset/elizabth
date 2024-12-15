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
    public partial class WeerdayParsingControl : UserControl
    {
        public WeerdayParsingControl()
        {
            InitializeComponent();
        }

        private void ParseButton_Click(object sender, EventArgs e)
        {
            string Input = ParsingTextBox.Text;

            if (Enum.TryParse<Weekday>(Input, out var weekday)
                && !(int.TryParse(Input, out var result)))
            {
                ViewParseTextBox.Text = $"Это день недели " +
                    $"({weekday} = {Convert.ToInt32(weekday)})";
            }
            else
            {
                MessageBox.Show("Неправильно введено значение!");
            }
        }
    }
}
