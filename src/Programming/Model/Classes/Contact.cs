using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Programming
{
    /// <summary>
    /// Хранит данные о номере телефона и его владельца
    /// </summary>
   internal class Contact
    {
        /// <summary>
        /// Проверка на слово состоит из английский букв и цифр
        /// </summary>
        /// <param name="value"></param>
        /// <exception cref="ArgumentException"></exception>
        private void AssertStringContainsOnlyLetters(string value)
        {
            if (!Regex.IsMatch(value, "^[a-zA-Z0-9]*$"))
            {
                throw new ArgumentException(nameof(value));
            }
        }

        /// <summary>
        /// Номер телефона
        /// </summary>
        private string _phoneNumber;

        /// <summary>
        /// Имя контакта
        /// </summary>
        private string _name;

        /// <summary>
        /// Фамилия контакта
        /// </summary>
        private string _surname;

        /// <summary>
        /// Почта контакта
        /// </summary>
        private string _email;

        /// <summary>
        /// с номер телефона
        /// </summary>
        public string PhoneNumber { get;set; }

        /// <summary>
        /// Возвращает и задает имя контакта. Должен состоять только из букв
        /// </summary>
        public string Name
        {
            get { return _name; }
            set
            {
                AssertStringContainsOnlyLetters(value);
                _name = value;
            }
        }
        /// <summary>
        /// Возвращает и задает фамилию контакта. Должке состоять только из букв
        /// </summary>
        public string Surname
        {
            get { return _surname; }
            set
            {
                AssertStringContainsOnlyLetters(value);
                _surname= value;
            }
        }

        /// <summary>
        /// Возвращает и задает почту контакта
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// Создает экземпляр класса <see cref="Contact"/>.
        /// </summary>
        /// <param name="phoneNumber"> Номер телефона</param>
        /// <param name="name">Имя. Должно состоять только из букв</param>
        /// <param name="email">Почта</param>
        public Contact(string phoneNumber, string name, string email)
        { 
            PhoneNumber = phoneNumber;
            Name = name;
            Email = email;
        }
        public Contact() { }
    }
}
