using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Programming;

namespace Programming.View.Panels
{
    public partial class EnumerationsControl : UserControl
    {
        public EnumerationsControl()
        {
            InitializeComponent();
            EnumsListBox.SelectedIndex = 0;
        }

        private void EnumsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectEnums = EnumsListBox.SelectedItem.ToString();
            ValuestPrint(selectEnums);
        }
        private void ValuesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ValueTextBox.Text = ValuesListBox.SelectedIndex.ToString();
        }

        /// <summary>
        /// Выводит индекс перечесления
        /// </summary>
        /// <param name="selectEnums"></param>
        public void ValuestPrint(string selectEnums)
        {
            switch (selectEnums)
            {
                case "Color":
                    ValuesListBox.Items.Clear();
                    ValuesListBox.Items.AddRange(Enum.GetValues
                        (typeof(Color)).Cast<object>().ToArray());
                    break;

                case "Season":
                    ValuesListBox.Items.Clear();
                    ValuesListBox.Items.AddRange(Enum.GetValues
                        (typeof(Season)).Cast<object>().ToArray());
                    break;

                case "EducationForm":
                    ValuesListBox.Items.Clear();
                    ValuesListBox.Items.AddRange(Enum.GetValues
                        (typeof(EducationForm)).Cast<object>().ToArray());
                    break;

                case "Genre":
                    ValuesListBox.Items.Clear();
                    ValuesListBox.Items.AddRange(Enum.GetValues
                        (typeof(Genre)).Cast<object>().ToArray());
                    break;

                case "Weekday":
                    ValuesListBox.Items.Clear();
                    ValuesListBox.Items.AddRange(Enum.GetValues
                        (typeof(Weekday)).Cast<object>().ToArray());
                    break;

                case "Manufacturies":
                    ValuesListBox.Items.Clear();
                    ValuesListBox.Items.AddRange(Enum.GetValues(typeof
                        (Manufacturies)).Cast<object>().ToArray());
                    break;
            }
        }
    }
}
