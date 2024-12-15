using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Programming.Model;

namespace Programming
{
    /// <summary>
    /// Хранит данные о песне
    /// </summary>
    internal class Song
    {
        /// <summary>
        /// Название песни
        /// </summary>
        private string _name;

        /// <summary>
        /// Длительность песни
        /// </summary>
        private int _duration;
        
        /// <summary>
        /// Жанр музыки
        /// </summary>
        private string _genre;

        /// <summary>
        /// Возвращает и задает название песни.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Возвращает и задает длительность песни.Долна состоять из цифр
        /// </summary>
        public int Duration
        {
            get { return _duration; }
            set
            {
                Validator.AssertOnPositiveValue(value);
                _duration = value;
            }
        }

        /// <summary>
        /// Возвращает и задает жанр музыки
        /// </summary>
        public string Genre { get; set; }

        /// <summary>
        /// Создает экземпляр класса <see cref="Song"/>.
        /// </summary>
        /// <param name="name">Название песни</param>
        /// <param name="duration">Длительность песни. Должна состоять из цифр</param>
        /// <param name="genre">Жанр музыки</param>
        public Song(string name, int duration, string genre)
        {
            Name = name;
            Duration = duration;
            Genre = genre;
        }
        public Song() { }
    }
}
