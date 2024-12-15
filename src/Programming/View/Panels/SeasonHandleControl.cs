﻿using System;
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
    public partial class SeasonHandleControl : UserControl
    {
        public SeasonHandleControl()
        {
            InitializeComponent();
            HandleComboBox.SelectedIndex = 0;
            HandleComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
        }
        private void HandleButton_Click(object sender, EventArgs e)
        {
            string item = HandleComboBox.SelectedItem.ToString();
            switch (item)
            {
                case "Winter":
                    MessageBox.Show("Бррр! Холодно!");
                    break;

                case "Spring":
                    break;

                case "Summer":
                    MessageBox.Show("Ура! Солнце!");
                    break;

                case "Autumn":
                    break;
            }
        }
    }
}
