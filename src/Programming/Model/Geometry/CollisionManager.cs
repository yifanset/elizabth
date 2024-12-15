using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Programming;

namespace Programming
{
    /// <summary>
    /// Хранит данные о пересечении фигур
    /// </summary>
    internal class CollisionManager
    {
        /// <summary>
        /// True - если фигуру пересекаются, False - нет
        /// </summary>
        /// <param name="rectangle1"></param>
        /// <param name="rectangle2"></param>
        /// <returns></returns>
        static public bool IsCollision(Rectangle rectangle1, Rectangle rectangle2)
        {
            double differenceX = Math.Abs(rectangle1.Center.X - rectangle2.Center.X);
            double halfLatitude = Math.Abs(rectangle1.Widght + rectangle2.Widght) / 2;
            double differenceY = Math.Abs(rectangle1.Center.Y - rectangle2.Center.Y);
            double halfLength = Math.Abs(rectangle1.Length + rectangle2.Length) / 2;
            return differenceX < halfLatitude && differenceY < halfLength;
        }

        /// <summary>
        /// True - если фигуру пересекаются, False - нет
        /// </summary>
        /// <param name="ring1"></param>
        /// <param name="ring2"></param>
        /// <returns></returns>
        public static bool IsCollision(Ring ring1, Ring ring2)
        {
            double distance = Math.Sqrt(Math.Pow(ring2.Center.X - ring1.Center.X, 2) + Math.Pow(ring2.Center.Y - ring1.Center.Y, 2));
            return distance<(ring1.RadiusExternal + ring2.RadiusExternal);
        }
    }
}