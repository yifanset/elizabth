using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Programming.Model;

namespace Programming
{
    /// <summary>
    /// Хранит данные о созданной фигуре
    /// </summary>
    internal class RectangleFactory
    {
        static Random random = new Random();
        /// <summary>
        /// Генерирует случайны новый объект типа Rectangle
        /// </summary>
        /// <returns></returns>
        static public Rectangle Randomize()
        {

            return new Rectangle(random.Next(1, 100), random.Next(1, 100), "Green", random.Next(1, 471), random.Next(1, 417));
        }
    }
}
