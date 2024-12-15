using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Programming.Model;

namespace Programming.Model.Classes
{
    /// <summary>
    /// Хранит данные о центре фигуры
    /// </summary>
    internal class Point2D
    {
        /// <summary>
        /// Координата X
        /// </summary>
        private int _x;

        /// <summary>
        /// Координата Y
        /// </summary>
        private int _y;

        /// <summary>
        /// Возвращает и задает X, состоит только из цифр
        /// </summary>
        public int X
        {
            get { return _x; }
            set
            {
                Validator.AssertOnPositiveValue(value);
                _x = value;
            }
        }

        /// <summary>
        /// Возвращает и задает X, состоит только из цифр
        /// </summary>
        public int Y
        {
            get { return _y; }
            set
            {
                Validator.AssertOnPositiveValue(value);
                _y = value;
            }
        }

        /// <summary>
        /// Создает экземпляр класса <see cref="Point2D"/>.
        /// </summary>
        /// <param name="x">Координата Х, состоит из цифр</param>
        /// <param name="y">Координата Y, состоит из цифр</param>
        public Point2D(int x, int y)
        {
            Y = y;
            X = x;
        }
        public Point2D() { }
    }
}
