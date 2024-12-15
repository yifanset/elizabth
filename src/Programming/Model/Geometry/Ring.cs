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
    /// Хранит данные о кольце
    /// </summary>
    internal class Ring
    {
        /// <summary>
        /// Считает площадь фигуры
        /// </summary>
        /// <param name="radius"></param>
        /// <returns></returns>
        private double GetCircleArea(double radius)
        {
            return Math.PI * Math.Pow(radius, 2);
        }

        /// <summary>
        /// Центр фигуры
        /// </summary>
        private Point2D _center;

        /// <summary>
        /// Внутренний радиус
        /// </summary>
        private double _radiusInternal;

        /// <summary>
        /// Внешний радиус
        /// </summary>
        private double _radiusExternal;

        /// <summary>
        /// Возвращает площадь кольца
        /// </summary>
        public double Area
        {
            get
            {
                return GetCircleArea(_radiusExternal) - GetCircleArea(_radiusInternal);
            }
        }
        /// <summary>
        /// Возвращает и задает центр фигуры
        /// </summary>
        public Point2D Center 
        {
            get { return _center; } 
            set { _center = value; } 
        }

        /// <summary>
        /// Возвращает и задает внутренний радиус
        /// </summary>
        public double RadiusInternal
        {
            get { return _radiusInternal; }
            set
            {
                Validator.AssertOnPositiveValue(value);
                if (value > _radiusExternal) throw new ArgumentException(nameof(value));
                _radiusInternal = value;
            }
        }

        public double RadiusExternal
        {
            get { return _radiusExternal; }
            set
            {
                if (value < _radiusInternal) throw new ArgumentException(nameof(value));
                _radiusExternal = value;
            }
        }

        public Ring(Point2D center, int radiusInternal, int radiusExternal)
        {
            Center = center;
            RadiusInternal = radiusInternal;
            RadiusExternal = radiusExternal;
        }

        public Ring() { }
    }
}

