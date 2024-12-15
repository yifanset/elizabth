using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Programming.Model;

namespace Programming
{
    /// <summary>
    /// Хранит данные о времени
    /// </summary>
    internal class Time
    {
        /// <summary>
        /// Часы
        /// </summary>
        private int _hour;

        /// <summary>
        /// Минуты
        /// </summary>
        private int _minute;

        /// <summary>
        /// Секунды
        /// </summary>
        private int _second;

        /// <summary>
        /// Возвращает и задает часы.Должен состоять из цифр
        /// </summary>
        public int Hour
        {
            set
            {
                Validator.AssertOnPositiveValue(value,0,24);
                _hour = value;
                

            }
            get { return _hour; }
        }

        /// <summary>
        /// Возвращает и задает минуты.Должен состоять из цифр
        /// </summary>
        public int Minute
        { 
            set
            {
                Validator.AssertOnPositiveValue(value, 0, 60);
                _minute = value;
            }
            get { return _minute; }
        }

        /// <summary>
        /// Возвращает и задает минуты.Должен состоять из цифр
        /// </summary>
        public int Second
        {
            set
            {
                Validator.AssertOnPositiveValue(value, 0, 60);
                _second = value;
            }
            get { return _second; }
        }

        /// <summary>
        /// Создает экземпляр класса <see cref="Time"/>.
        /// </summary>
        /// <param name="hour">Часы, состоят из цифр</param>
        /// <param name="minute">Минуты, состоят из цирф</param>
        /// <param name="second">Секунды, состоять из цифр</param>
        public Time(int hour,int minute,int second)
        {
            Hour = hour;
            Minute = minute;
            Second = second;
        }
        public Time() { }
    }
}
