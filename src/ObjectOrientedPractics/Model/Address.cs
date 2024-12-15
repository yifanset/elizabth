using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics
{
    /// <summary>
    /// Представляет адрес клиента, включая индекс, страну, город, улицу, здание и квартиру.
    /// </summary>
    public class Address
    {
        /// <summary>
        /// Хранит индекс.
        /// </summary>
        private int _index;

        /// <summary>
        /// Хранит страну.
        /// </summary>
        private string _country;

        /// <summary>
        /// Хранит город.
        /// </summary>
        private string _city;

        /// <summary>
        /// Хранит улицу.
        /// </summary>
        private string _street;

        /// <summary>
        /// Хранит номер здания.
        /// </summary>
        private string _building;

        /// <summary>
        /// Хранит номер квартиры.
        /// </summary>
        private string _apartment;

        /// <summary>
        /// Возвращает и задает индекс. Значение должно быть в диапазоне от 100000 до 999999.
        /// </summary>
        public int Index
        {
            get { return _index; }
            set
            {
                Validator.AssertOnPositiveValue(value, 100_000, 999_999, nameof(value));
                _index = value;
            }
        }

        /// <summary>
        /// Возвращает и задает страну. Длина строки не должна превышать 50 символов.
        /// </summary>
        public string Country
        {
            get { return _country; }
            set
            {
                Validator.AssertStringOnLength(value, 50, "Страна");
                _country = value;
            }
        }

        /// <summary>
        /// Возвращает и задает город. Длина строки не должна превышать 50 символов.
        /// </summary>
        public string City
        {
            get { return _city; }
            set
            {
                Validator.AssertStringOnLength(value, 50, "Город");
                _city = value;
            }
        }

        /// <summary>
        /// Возвращает и задает улицу. Длина строки не должна превышать 100 символов.
        /// </summary>
        public string Street
        {
            get { return _street; }
            set
            {
                Validator.AssertStringOnLength(value, 100, "Улица");
                _street = value;
            }
        }

        /// <summary>
        /// Возвращает и задает номер здания. Длина строки не должна превышать 10 символов.
        /// </summary>
        public string Building
        {
            get { return _building; }
            set
            {
                Validator.AssertStringOnLength(value, 10, "Номер здания");
                _building = value;
            }
        }

        /// <summary>
        /// Возвращает и задает номер квартиры. Длина строки не должна превышать 10 символов.
        /// </summary>
        public string Apartment
        {
            get { return _apartment; }
            set
            {
                Validator.AssertStringOnLength(value, -1, 10, "Квартира");
                _apartment = value;
            }
        }

        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="Address"/> с заданными параметрами.
        /// </summary>
        /// <param name="index">Индекс</param>
        /// <param name="country">Страна</param>
        /// <param name="city">Город</param>
        /// <param name="street">Улица</param>
        /// <param name="building">Здание</param>
        /// <param name="apartment">Квартира</param>
        public Address(int index, string country, string city, string street, string building, string apartment)
        {
            Index = index;
            Country = country;
            City = city;
            Street = street;
            Building = building;
            Apartment = apartment;
        }


        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="Address"/> на основе другого адреса.
        /// </summary>
        /// <param name="adress">Адрес для копирования</param>
        public Address(Address adress)
        {
            Index = adress.Index;
            Country = adress.Country;
            City = adress.City;
            Street = adress.Street;
            Building = adress.Building;
            Apartment = adress.Apartment;
        }

        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="Address"/> без параметров.
        /// </summary>
        public Address() { }
    }
}
