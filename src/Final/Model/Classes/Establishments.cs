using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final
{

        /// <summary>
        /// Хранит данные о здании
        /// </summary>
    internal class Establishment
    {
        /// <summary>
        /// Название заведения
        /// </summary>
        private string _name;

        /// <summary>
        /// Адресс заведения
        /// </summary>
        private string _address;

        /// <summary>
        /// Категория заведения
        /// </summary>
        private string _category;

        /// <summary>
        /// Рейтинг заведения
        /// </summary>
        private double _raiting;


        /// <summary>
        /// Возвращает и задает название. Длина строки не больше 200 символов.
        /// </summary>
        public string Name
        {
            get { return _name; }
            set
            {
                Validator.AssertForMaximumLength(value, 200);
                _name = value;
            }
        }

        /// <summary>
        /// Возвращает и задает адресс. Длина строки не больше 100 символов.
        /// </summary>
        public string Address
        {
            get { return _address; }
            set
            {
                Validator.AssertForMaximumLength(value, 100);
                _address = value;
            }
        }

        /// <summary>
        /// Возвращает и задает категорию. Берется из перечисления.
        /// </summary>
        public string Category
        {
            get { return _category; }
            set
            {
                if (int.TryParse(value, out var intResult))
                {
                    throw new ArgumentException();
                }
                if (!Enum.TryParse<Category>(value, out var category))
                    throw new ArgumentException();
                _category = value;
            }
        }

        /// <summary>
        /// Возвращает и задает рейтинг. Число больше 0, но меньше 5.
        /// </summary>
        public double Raiting
        {
            get { return _raiting; }
            set
            {
                Validator.AssertOnPositiveValue(value, 5);


                _raiting = value;
            }
        }

        /// <summary>
        /// Создает экземпляр класса <see cref="Establishment"/>
        /// </summary>
        /// <param name="name">Название заведения</param>
        /// <param name="address">Адресс заведения</param>
        /// <param name="category">Категория заведения</param>
        /// <param name="raiting">Ретинг заведения</param>
        public Establishment(string name, string address, string category, double raiting)
        {
            Name = name;
            Address = address;
            Category = category;
            Raiting = raiting;
        }
        public Establishment() { }
    }
}

