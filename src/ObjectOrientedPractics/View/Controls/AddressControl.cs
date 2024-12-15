using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ObjectOrientedPractics.View.Controls
{
    public partial class AddressControl : UserControl
    {
        private Address _address;

        public Address Address
        {
            get
            {
                _address.Index = Convert.ToInt32(IndexTextBox.Text);
                _address.Country = CountryTextBox.Text;
                _address.City = CityTextBox.Text;
                _address.Street = StreetTextBox.Text;
                _address.Building = BuildingTextBox.Text;
                _address.Apartment = ApartmentTextBox.Text;
                return _address;
            }
            set
            {
                _address = value;
                UpdateAddressFields();
            }
        }

        private void UpdateAddressFields()
        {
            IndexTextBox.Text = _address.Index.ToString();
            CountryTextBox.Text = _address.Country;
            CityTextBox.Text = _address.City;
            StreetTextBox.Text = _address.Street;
            BuildingTextBox.Text = _address.Building;
            ApartmentTextBox.Text = _address.Apartment;
        }

        public AddressControl()
        {
            InitializeComponent();
            _address = new Address();
        }

        private void IndexTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                IndexTextBox.BackColor = Color.White;
                Validator.AssertOnPositiveValue(
                    Convert.ToInt32(IndexTextBox.Text),
                    100_000, 999_999, "Почтовый индекс");

                _address.Index = Convert.ToInt32(IndexTextBox.Text);
            }
            catch
            {
                IndexTextBox.BackColor = Color.LightPink;
            }
        }

        private void CountryTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                CountryTextBox.BackColor = Color.White;
                Validator.AssertStringOnLength(
                    CountryTextBox.Text, 50, "Страна");

                _address.Country = CountryTextBox.Text;
            }
            catch
            {
                CountryTextBox.BackColor = Color.LightPink;
            }
        }

        private void CityTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                CityTextBox.BackColor = Color.White;
                Validator.AssertStringOnLength(
                    CityTextBox.Text, 50, "Город");

                _address.City = CityTextBox.Text;
            }
            catch
            {
                CityTextBox.BackColor = Color.LightPink;
            }
        }

        private void StreetTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                StreetTextBox.BackColor = Color.White;
                Validator.AssertStringOnLength(
                    StreetTextBox.Text, 100_000, "Улица");

                _address.Street = StreetTextBox.Text;
            }
            catch
            {
                StreetTextBox.BackColor = Color.LightPink;
            }
        }

        private void BuildingTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                BuildingTextBox.BackColor = Color.White;
                Validator.AssertStringOnLength(
                    BuildingTextBox.Text, 10, "Номер дома");

                _address.Building = BuildingTextBox.Text;
            }
            catch
            {
                BuildingTextBox.BackColor = Color.LightPink;
            }
        }

        private void ApartmentTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                ApartmentTextBox.BackColor = Color.White;
                Validator.AssertStringOnLength(
                    ApartmentTextBox.Text, -1, 10, "Квартира");

                _address.Apartment = ApartmentTextBox.Text;
            }
            catch
            {
                ApartmentTextBox.BackColor = Color.LightPink;
            }
        }
        public void Clear()
        {
            _address = new Address();   

            IndexTextBox.Text = "";
            CountryTextBox.Text = "";
            CityTextBox.Text = "";
            StreetTextBox.Text = "";
            BuildingTextBox.Text = "";
            ApartmentTextBox.Text = "";

            IndexTextBox.BackColor = Color.White;
            CountryTextBox.BackColor = Color.White;
            CityTextBox.BackColor = Color.White;
            StreetTextBox.BackColor = Color.White;
            BuildingTextBox.BackColor = Color.White;
            ApartmentTextBox.BackColor = Color.White;
        }
    }
}
