using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Programming.Model;

namespace Programming
{
    /// <summary>
    /// Хранит данные о фильме
    /// </summary>
    internal class Movie
    {
        /// <summary>
        /// Имя фильма
        /// </summary>
        private string _name;

        /// <summary>
        /// Длительность фильма
        /// </summary>
        private int _time;

        /// <summary>
        /// Дата выхода фильма
        /// </summary>
        private int _data;

        /// <summary>
        /// Жанр фильма
        /// </summary>
        private string _genre;

        /// <summary>
        /// Рейтинг фильма
        /// </summary>
        private double _raiting;

        /// <summary>
        /// Возвращает и задает имя фильма
        /// </summary>
        public string Name { get;set; }

        /// <summary>
        /// Возвращает и задает время фильма. Должно состоять только из цифр
        /// </summary>
        public int Time
        {
            get { return _time; }
            set
            {
                Validator.AssertOnPositiveValue(value);
                _time = value;
            }
        }

        /// <summary>
        /// Возвращает и задает дату выхода фильма. Должно состоять только из чисел в диапозоне 1900-2024
        /// </summary>
        public int Data
        {
            get { return _data; }
            set
            {
                Validator.AssertOnPositiveValue(value, 1900, 2024);
                _data = value;
            }
        }

        /// <summary>
        /// Возвращает и задает жанр фильма. Должен состоять из элементов перечисление 
        /// </summary>
        public string Genre
        {
            get { return _genre; }
            set
            {
                if (int.TryParse(value, out var intResult))
                {
                    throw new ArgumentException();
                }
                if (!Enum.TryParse<Genre>(value, out var genre))
                    throw new ArgumentException();
                _genre = value;
            }
        }

        /// <summary>
        /// Возвращает и задает рейтинг фильма. Должен состоять из чисел в диапозоне от 0 до 10
        /// </summary>
        public double Raiting
        {
            get { return _raiting; }
            set
            {
                Validator.AssertOnPositiveValue(value, 0, 10);


                _raiting = value;
            }
        }

        /// <summary>
        /// Создает экземпляр класса <see cref="Person"/>
        /// </summary>
        /// <param name="name">Название фильма</param>
        /// <param name="time">Длительность фильма. Должна состоять из чисел</param>
        /// <param name="data">Дата выхода фильма. Должно состоять только из чисел в диапозоне 1900-2024</param>
        /// <param name="genre">Жанр фильма. Должен состоять из элементов перечисление</param>
        /// <param name="raiting">Рейтинг фильма. Должен состоять из чисел в диапозоне от 0 до 10</param>
        public Movie(string name,int time, int data, string genre, double raiting)
        {
            Name = name;
            Time = time;
            Data = data;
            Genre = genre;
            Raiting = raiting;
        }
        public Movie() { }
    }
}
