using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Programming.Model;

namespace Programming
{
    /// <summary>
    /// Хранит данные о перелетах
    /// </summary>
    internal class Flight
    {
        /// <summary>
        /// Начальная точка
        /// </summary>
        private string _pointStart;

        /// <summary>
        /// Точка прилета
        /// </summary>
        private string _pointEnd;

        /// <summary>
        /// Время перелета
        /// </summary>
        private int _time;

        /// <summary>
        /// Возвращает и задает начальную точку
        /// </summary>
        public string PointStart { get; set; }

        /// <summary>
        /// Возвращает и задает точку прилета
        /// </summary>
        public string PointEnd { get; set; }

        /// <summary>
        /// Возвращает и задает время полета. Должно состоять только из цифр
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
        /// Создает экземпляр класса <see cref="Flight"/>
        /// </summary>
        /// <param name="pointStart">Начальная точка</param>
        /// <param name="pointEnd">Точка прилета</param>
        /// <param name="time">Время полета. Должно состоять только из цифр</param>
        public Flight(string pointStart, string pointEnd, int time)
        {
            PointStart = pointStart;
            PointEnd = pointEnd;
            Time = time;
        }
        public Flight() { }
    }
}
