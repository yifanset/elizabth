using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Programming.Model;
using Programming.Model.Classes;

namespace Programming
{
    /// <summary>
    /// Хранит данные о прямоугольнике
    /// </summary>
    internal class Rectangle
    {
        /// <summary>
        /// Длинна
        /// </summary>
        private int _length;

        /// <summary>
        /// Ширина
        /// </summary>
        private int _widght;

        /// <summary>
        /// Цвет
        /// </summary>
        private string _color;

        /// <summary>
        /// Цент прямоугольника
        /// </summary>
        private Point2D _center;

        /// <summary>
        /// Счетчик всех фигур
        /// </summary>
        private static int _allRectanglesCount = 0;

        /// <summary>
        /// Уникальный идентификатор для всех объектов данного класса.
        /// </summary>
        private int _id;

        /// <summary>
        /// Возвращает и задает длину. Должна состоять из цифр больше 0
        /// </summary>
        public int Length
        {
            get { return _length; }
            set
            {
                Validator.AssertOnPositiveValue(value);
                _length = value;
            }
        }

        /// <summary>
        /// Возвращает и задает ширину. Должна состоять из цифр больше 0
        /// </summary>
        public int Widght
        {
            get { return _widght; }
            set
            {
                Validator.AssertOnPositiveValue(value);
                _widght = value;
            }
        }

        /// <summary>
        /// Возвращает и задает цвет фигуры. Должен принадлежать перечислению
        /// </summary>
        public string Color
        {
            get { return _color; }
            set
            {
                if (int.TryParse(value, out var intResult))
                {
                    throw new ArgumentException();
                }
                if (!Enum.TryParse<Color>(value, out var color))
                    throw new ArgumentException();
                _color = value;
            }
        }

        /// <summary>
        /// Возвращает и задает цент фигуры
        /// </summary>
        public Point2D Center { get; set; }

        /// <summary>
        /// Возвращает счетчик всех фигур
        /// </summary>
        public int AllRectanglesCount
        {
            get {return _allRectanglesCount;}
        }

        /// <summary>
        /// Возвращает уникальный идентификатор для всех объектов данного класса
        /// </summary>
        public int Id
        {
            get { return _id; } 
        }

        /// <summary>
        /// Создает экземпляр класса <see cref="Rectangle"/>
        /// </summary>
        /// <param name="length">Длина. Состоит из положительных цифр</param>
        /// <param name="widght">Ширина. Состоит из положительных цифр</param>
        /// <param name="color">Цвет. Принадлежит перечислению</param>
        /// <param name="X">Координата X</param>
        /// <param name="Y">координата Y</param>
        public Rectangle(int length, int widght, string color, int X, int Y)
        {
            Length = length;
            Widght = widght;
            Color = color;
            Center = new Point2D(X,Y);
            _id = _allRectanglesCount;
            _allRectanglesCount++;
        }
        public Rectangle() { }

        public override string ToString()
        {
            return $"{Id}: (X={Center.X}; Y={Center.Y}; H={_length}; W={_widght})";
        }
    }
}
