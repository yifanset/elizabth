using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final
{
    /// <summary>
    /// Выполняет провекрку данных
    /// </summary>
    internal class Validator
    {
        /// <summary>
        /// Проверяет, что длинна строки меньше указанного значения
        /// </summary>
        /// <param name="value"></param>
        /// <param name="max"></param>
        /// <exception cref="ArgumentException"></exception>
        public static void AssertForMaximumLength(string value,int max)
        {
            if (value.Length <= 0 || value.Length >= max)
                throw new ArgumentException(nameof(value));
        }

        /// <summary>
        /// Проверяет, что значение находится в заданом диапозоне
        /// </summary>
        /// <param name="value"></param>
        /// <param name="max"></param>
        /// <exception cref="ArgumentException"></exception>
        public static void AssertOnPositiveValue(double value, int max)
        {
            if (value < 0 || value > 5)
                throw new ArgumentException(nameof(value));
        }
    }
}
